

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
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.48055527331343395d, b: 0.6249039279149068d, c: 0.15199438253096054d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.727895723075834d, b: 0.5752038889891677d, c: 0.03631463927911227d),
},
            new NpgsqlLineline0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.26744521069280824d, b: 0.992543375778684d, c: 0.732596706051228d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1309752736735319d, b: 0.6128294122292256d, c: 0.0653766426896889d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6056229366409427d, b: 0.1777796614149928d, c: 0.19069164818651807d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3904216026331139d, b: 0.3441068777834627d, c: 0.307709042683209d),
},
            new NpgsqlLineline0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.23736463777845562d, b: 0.10816715382001296d, c: 0.6481835185215921d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.878538562378935d, b: 0.02945643814001775d, c: 0.298259238845482d),
},
            new NpgsqlLineline0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9426839997950142d, b: 0.5220044078502238d, c: 0.6331982464097795d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.651932740139992d, b: 0.14935204812885616d, c: 0.386024472341262d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8122002216780163d, b: 0.20489580285204467d, c: 0.6893247935448148d),
},
            new NpgsqlLineline0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7764093490874011d, b: 0.09186446068920129d, c: 0.8870283421759414d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4913664746411138d, b: 0.24189011686686068d, c: 0.4225263854016533d),
},
            new NpgsqlLineline0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6075999566068179d, b: 0.5506337395485061d, c: 0.781197572560621d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3832737049809076d, b: 0.8555465781567885d, c: 0.4198329001513541d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9324432427494198d, b: 0.6655927077233852d, c: 0.6571894411983952d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.10587318621277242d, b: 0.2512695249744181d, c: 0.14879984540519375d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7880161960112282d, b: 0.4503920827497536d, c: 0.7182047483650995d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.033393350530258825d, b: 0.7665842642182522d, c: 0.6321134323035246d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2597145063679469d, b: 0.4562289397928718d, c: 0.9016439688289756d),
},
            new NpgsqlLineline0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.31297956247800174d, b: 0.3248577912811236d, c: 0.7702705912109752d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.04444182939026897d, b: 0.3370572655636671d, c: 0.8409927781153981d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.531501850730363d, b: 0.6890357159043884d, c: 0.6625686184700825d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6045819278375845d, b: 0.5182600393718235d, c: 0.44677938839313835d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6010475048662505d, b: 0.18735108476499518d, c: 0.06238370970837637d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.02607812980405766d, b: 0.8075029728420982d, c: 0.20259950631285828d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7545441903969595d, b: 0.4411240925758265d, c: 0.29829802593028243d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8227011784723837d, b: 0.24321728396367703d, c: 0.8673586609017582d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9837247905771643d, b: 0.7381730797891957d, c: 0.29600584158244037d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8231915468200944d, b: 0.7217625459144916d, c: 0.8424643406016324d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4154572379301089d, b: 0.06820210665394888d, c: 0.1265705333575846d),
},
            new NpgsqlLineline0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9023468509062423d, b: 0.9659682407851872d, c: 0.4602094416228696d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3367078017481905d, b: 0.7303994410720117d, c: 0.13782370257063847d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6231179968476226d, b: 0.5135564691001143d, c: 0.26713460266063593d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6552449702195091d, b: 0.95207561141762d, c: 0.6987776554453531d),
},
            new NpgsqlLineline0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.18716237952626336d, b: 0.5267547782693275d, c: 0.6043586511175184d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.07255704962419096d, b: 0.29780761689084434d, c: 0.9790079520259829d),
},
            new NpgsqlLineline0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7825911684710745d, b: 0.4293757075390465d, c: 0.6576182362682981d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7907044744058879d, b: 0.011791399993552387d, c: 0.013540346594417496d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6361638080280906d, b: 0.7819281213185506d, c: 0.7171300574443068d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4697438652495247d, b: 0.536925864530837d, c: 0.31295739233370157d),
},
            new NpgsqlLineline0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4548465208589373d, b: 0.1958234099521382d, c: 0.6825780860862594d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.15327135328260588d, b: 0.6997939288591517d, c: 0.11044608203919615d),
},
            new NpgsqlLineline0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7838203602629151d, b: 0.9953289099670805d, c: 0.09528297272598196d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.28037273130082685d, b: 0.45416711555307854d, c: 0.8670267320328081d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5567402239508549d, b: 0.5155004231912056d, c: 0.7288072810463564d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9294813149915193d, b: 0.3724750068028285d, c: 0.24257297915048914d),
},
            new NpgsqlLineline0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.42674295116916394d, b: 0.40621177139361564d, c: 0.7814605976954124d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.17186785488311662d, b: 0.09187363430375162d, c: 0.9996645659224903d),
},
            new NpgsqlLineline0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9400053071826222d, b: 0.9446529096111465d, c: 0.4208233487153178d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9869594755191561d, b: 0.21779604882895076d, c: 0.5419582933806114d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.18824361581042204d, b: 0.11428934955927517d, c: 0.3788148404639414d),
},
            new NpgsqlLineline0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3045642851026811d, b: 0.5348630103225557d, c: 0.8201066317447061d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.29553052780468025d, b: 0.16000591801031727d, c: 0.7866881826829804d),
},
            new NpgsqlLineline0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.457863527628561d, b: 0.20480292211462514d, c: 0.5197222146075265d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7585891522021045d, b: 0.5621696143472503d, c: 0.8056918062045657d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.46429471253487586d, b: 0.046258404983642754d, c: 0.2900781954036896d),
},
            new NpgsqlLineline0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7040955257167236d, b: 0.8127699453299955d, c: 0.9103446373530538d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5136924918057622d, b: 0.7927352582990279d, c: 0.978918038322103d),
},
            new NpgsqlLineline0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.26634637090016877d, b: 0.06607618133224524d, c: 0.9778889525315652d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1605100563784645d, b: 0.4357725656001422d, c: 0.30021400603840487d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.40665009368964244d, b: 0.6846034923500988d, c: 0.3346432900194175d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8270161418940802d, b: 0.47509112365106165d, c: 0.4980394108099703d),
},
            new NpgsqlLineline0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8498309988062474d, b: 0.9225782611268103d, c: 0.4684644089131317d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.21907322941645857d, b: 0.6958413989428794d, c: 0.3722262122694062d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7166662953907966d, b: 0.05531034804798385d, c: 0.4712549911472552d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5718837455681504d, b: 0.3217911187117263d, c: 0.5597741578691848d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5670923521280421d, b: 0.8022028706290676d, c: 0.24711303178872046d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.13928286042220872d, b: 0.9484472225890077d, c: 0.44444736629805826d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7878766021164837d, b: 0.03452823605222477d, c: 0.5430718643275194d),
},
    NullableValue = null,
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4913664746411138d, b: 0.24189011686686068d, c: 0.4225263854016533d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.2597145063679469d, b: 0.4562289397928718d, c: 0.9016439688289756d)));
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlLineSingleTypeline)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlLineSingleTypeline)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM public.npgsqllineline0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[29], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
FROM public.npgsqllineline0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 11;
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
FROM public.npgsqllineline0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[29], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
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
FROM public.npgsqllineline0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[29], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 50, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqllineline0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 101, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[29], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 22, query1, 11, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM public.npgsqllineline0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 128, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 88, query1, 22, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 68, query1, 108, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 66, query1, 101, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[29], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 101, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 41, 20))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[29], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 78, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[29], false);
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
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlLineline0M.AssertModel(models[0],_testData[2], false);NpgsqlLineline0M.AssertModel(models[1],_testData[3], false);NpgsqlLineline0M.AssertModel(models[2],_testData[4], false);NpgsqlLineline0M.AssertModel(models[3],_testData[5], false);NpgsqlLineline0M.AssertModel(models[4],_testData[6], false);NpgsqlLineline0M.AssertModel(models[5],_testData[7], false);NpgsqlLineline0M.AssertModel(models[6],_testData[8], false);NpgsqlLineline0M.AssertModel(models[7],_testData[9], false);NpgsqlLineline0M.AssertModel(models[8],_testData[10], false);NpgsqlLineline0M.AssertModel(models[9],_testData[11], false);NpgsqlLineline0M.AssertModel(models[10],_testData[12], false);NpgsqlLineline0M.AssertModel(models[11],_testData[13], false);NpgsqlLineline0M.AssertModel(models[12],_testData[14], false);NpgsqlLineline0M.AssertModel(models[13],_testData[15], false);NpgsqlLineline0M.AssertModel(models[14],_testData[16], false);NpgsqlLineline0M.AssertModel(models[15],_testData[17], false);NpgsqlLineline0M.AssertModel(models[16],_testData[18], false);NpgsqlLineline0M.AssertModel(models[17],_testData[19], false);NpgsqlLineline0M.AssertModel(models[18],_testData[20], false);NpgsqlLineline0M.AssertModel(models[19],_testData[21], false);NpgsqlLineline0M.AssertModel(models[20],_testData[22], false);NpgsqlLineline0M.AssertModel(models[21],_testData[23], false);NpgsqlLineline0M.AssertModel(models[22],_testData[24], false);NpgsqlLineline0M.AssertModel(models[23],_testData[25], false);NpgsqlLineline0M.AssertModel(models[24],_testData[26], false);NpgsqlLineline0M.AssertModel(models[25],_testData[27], false);NpgsqlLineline0M.AssertModel(models[26],_testData[28], false);NpgsqlLineline0M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlLineline0M.AssertModel(models[0],_testData[16], false);NpgsqlLineline0M.AssertModel(models[1],_testData[17], false);NpgsqlLineline0M.AssertModel(models[2],_testData[18], false);NpgsqlLineline0M.AssertModel(models[3],_testData[19], false);NpgsqlLineline0M.AssertModel(models[4],_testData[20], false);NpgsqlLineline0M.AssertModel(models[5],_testData[21], false);NpgsqlLineline0M.AssertModel(models[6],_testData[22], false);NpgsqlLineline0M.AssertModel(models[7],_testData[23], false);NpgsqlLineline0M.AssertModel(models[8],_testData[24], false);NpgsqlLineline0M.AssertModel(models[9],_testData[25], false);NpgsqlLineline0M.AssertModel(models[10],_testData[26], false);NpgsqlLineline0M.AssertModel(models[11],_testData[27], false);NpgsqlLineline0M.AssertModel(models[12],_testData[28], false);NpgsqlLineline0M.AssertModel(models[13],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.48055527331343395d, b: 0.6249039279149068d, c: 0.15199438253096054d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.727895723075834d, b: 0.5752038889891677d, c: 0.03631463927911227d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.26744521069280824d, b: 0.992543375778684d, c: 0.732596706051228d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1309752736735319d, b: 0.6128294122292256d, c: 0.0653766426896889d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6056229366409427d, b: 0.1777796614149928d, c: 0.19069164818651807d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3904216026331139d, b: 0.3441068777834627d, c: 0.307709042683209d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23736463777845562d, b: 0.10816715382001296d, c: 0.6481835185215921d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.878538562378935d, b: 0.02945643814001775d, c: 0.298259238845482d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9426839997950142d, b: 0.5220044078502238d, c: 0.6331982464097795d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.651932740139992d, b: 0.14935204812885616d, c: 0.386024472341262d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8122002216780163d, b: 0.20489580285204467d, c: 0.6893247935448148d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7764093490874011d, b: 0.09186446068920129d, c: 0.8870283421759414d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4913664746411138d, b: 0.24189011686686068d, c: 0.4225263854016533d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6075999566068179d, b: 0.5506337395485061d, c: 0.781197572560621d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3832737049809076d, b: 0.8555465781567885d, c: 0.4198329001513541d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9324432427494198d, b: 0.6655927077233852d, c: 0.6571894411983952d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10587318621277242d, b: 0.2512695249744181d, c: 0.14879984540519375d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7880161960112282d, b: 0.4503920827497536d, c: 0.7182047483650995d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.033393350530258825d, b: 0.7665842642182522d, c: 0.6321134323035246d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2597145063679469d, b: 0.4562289397928718d, c: 0.9016439688289756d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.31297956247800174d, b: 0.3248577912811236d, c: 0.7702705912109752d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04444182939026897d, b: 0.3370572655636671d, c: 0.8409927781153981d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.531501850730363d, b: 0.6890357159043884d, c: 0.6625686184700825d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6045819278375845d, b: 0.5182600393718235d, c: 0.44677938839313835d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6010475048662505d, b: 0.18735108476499518d, c: 0.06238370970837637d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.02607812980405766d, b: 0.8075029728420982d, c: 0.20259950631285828d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7545441903969595d, b: 0.4411240925758265d, c: 0.29829802593028243d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8227011784723837d, b: 0.24321728396367703d, c: 0.8673586609017582d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9837247905771643d, b: 0.7381730797891957d, c: 0.29600584158244037d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8231915468200944d, b: 0.7217625459144916d, c: 0.8424643406016324d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4154572379301089d, b: 0.06820210665394888d, c: 0.1265705333575846d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9023468509062423d, b: 0.9659682407851872d, c: 0.4602094416228696d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3367078017481905d, b: 0.7303994410720117d, c: 0.13782370257063847d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6231179968476226d, b: 0.5135564691001143d, c: 0.26713460266063593d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6552449702195091d, b: 0.95207561141762d, c: 0.6987776554453531d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18716237952626336d, b: 0.5267547782693275d, c: 0.6043586511175184d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07255704962419096d, b: 0.29780761689084434d, c: 0.9790079520259829d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7825911684710745d, b: 0.4293757075390465d, c: 0.6576182362682981d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7907044744058879d, b: 0.011791399993552387d, c: 0.013540346594417496d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6361638080280906d, b: 0.7819281213185506d, c: 0.7171300574443068d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4697438652495247d, b: 0.536925864530837d, c: 0.31295739233370157d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4548465208589373d, b: 0.1958234099521382d, c: 0.6825780860862594d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.15327135328260588d, b: 0.6997939288591517d, c: 0.11044608203919615d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7838203602629151d, b: 0.9953289099670805d, c: 0.09528297272598196d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.28037273130082685d, b: 0.45416711555307854d, c: 0.8670267320328081d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5567402239508549d, b: 0.5155004231912056d, c: 0.7288072810463564d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9294813149915193d, b: 0.3724750068028285d, c: 0.24257297915048914d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42674295116916394d, b: 0.40621177139361564d, c: 0.7814605976954124d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17186785488311662d, b: 0.09187363430375162d, c: 0.9996645659224903d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9400053071826222d, b: 0.9446529096111465d, c: 0.4208233487153178d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9869594755191561d, b: 0.21779604882895076d, c: 0.5419582933806114d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18824361581042204d, b: 0.11428934955927517d, c: 0.3788148404639414d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3045642851026811d, b: 0.5348630103225557d, c: 0.8201066317447061d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29553052780468025d, b: 0.16000591801031727d, c: 0.7866881826829804d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.457863527628561d, b: 0.20480292211462514d, c: 0.5197222146075265d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7585891522021045d, b: 0.5621696143472503d, c: 0.8056918062045657d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.46429471253487586d, b: 0.046258404983642754d, c: 0.2900781954036896d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7040955257167236d, b: 0.8127699453299955d, c: 0.9103446373530538d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5136924918057622d, b: 0.7927352582990279d, c: 0.978918038322103d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.26634637090016877d, b: 0.06607618133224524d, c: 0.9778889525315652d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1605100563784645d, b: 0.4357725656001422d, c: 0.30021400603840487d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40665009368964244d, b: 0.6846034923500988d, c: 0.3346432900194175d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8270161418940802d, b: 0.47509112365106165d, c: 0.4980394108099703d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8498309988062474d, b: 0.9225782611268103d, c: 0.4684644089131317d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21907322941645857d, b: 0.6958413989428794d, c: 0.3722262122694062d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7166662953907966d, b: 0.05531034804798385d, c: 0.4712549911472552d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5718837455681504d, b: 0.3217911187117263d, c: 0.5597741578691848d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5670923521280421d, b: 0.8022028706290676d, c: 0.24711303178872046d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13928286042220872d, b: 0.9484472225890077d, c: 0.44444736629805826d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7878766021164837d, b: 0.03452823605222477d, c: 0.5430718643275194d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.48055527331343395d, b: 0.6249039279149068d, c: 0.15199438253096054d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.727895723075834d, b: 0.5752038889891677d, c: 0.03631463927911227d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.26744521069280824d, b: 0.992543375778684d, c: 0.732596706051228d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1309752736735319d, b: 0.6128294122292256d, c: 0.0653766426896889d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6056229366409427d, b: 0.1777796614149928d, c: 0.19069164818651807d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3904216026331139d, b: 0.3441068777834627d, c: 0.307709042683209d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23736463777845562d, b: 0.10816715382001296d, c: 0.6481835185215921d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.878538562378935d, b: 0.02945643814001775d, c: 0.298259238845482d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9426839997950142d, b: 0.5220044078502238d, c: 0.6331982464097795d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.651932740139992d, b: 0.14935204812885616d, c: 0.386024472341262d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8122002216780163d, b: 0.20489580285204467d, c: 0.6893247935448148d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7764093490874011d, b: 0.09186446068920129d, c: 0.8870283421759414d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4913664746411138d, b: 0.24189011686686068d, c: 0.4225263854016533d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6075999566068179d, b: 0.5506337395485061d, c: 0.781197572560621d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3832737049809076d, b: 0.8555465781567885d, c: 0.4198329001513541d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9324432427494198d, b: 0.6655927077233852d, c: 0.6571894411983952d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10587318621277242d, b: 0.2512695249744181d, c: 0.14879984540519375d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7880161960112282d, b: 0.4503920827497536d, c: 0.7182047483650995d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.033393350530258825d, b: 0.7665842642182522d, c: 0.6321134323035246d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2597145063679469d, b: 0.4562289397928718d, c: 0.9016439688289756d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.31297956247800174d, b: 0.3248577912811236d, c: 0.7702705912109752d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.04444182939026897d, b: 0.3370572655636671d, c: 0.8409927781153981d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.531501850730363d, b: 0.6890357159043884d, c: 0.6625686184700825d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6045819278375845d, b: 0.5182600393718235d, c: 0.44677938839313835d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6010475048662505d, b: 0.18735108476499518d, c: 0.06238370970837637d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.02607812980405766d, b: 0.8075029728420982d, c: 0.20259950631285828d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7545441903969595d, b: 0.4411240925758265d, c: 0.29829802593028243d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8227011784723837d, b: 0.24321728396367703d, c: 0.8673586609017582d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9837247905771643d, b: 0.7381730797891957d, c: 0.29600584158244037d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8231915468200944d, b: 0.7217625459144916d, c: 0.8424643406016324d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4154572379301089d, b: 0.06820210665394888d, c: 0.1265705333575846d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9023468509062423d, b: 0.9659682407851872d, c: 0.4602094416228696d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3367078017481905d, b: 0.7303994410720117d, c: 0.13782370257063847d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6231179968476226d, b: 0.5135564691001143d, c: 0.26713460266063593d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6552449702195091d, b: 0.95207561141762d, c: 0.6987776554453531d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18716237952626336d, b: 0.5267547782693275d, c: 0.6043586511175184d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07255704962419096d, b: 0.29780761689084434d, c: 0.9790079520259829d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7825911684710745d, b: 0.4293757075390465d, c: 0.6576182362682981d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7907044744058879d, b: 0.011791399993552387d, c: 0.013540346594417496d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6361638080280906d, b: 0.7819281213185506d, c: 0.7171300574443068d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4697438652495247d, b: 0.536925864530837d, c: 0.31295739233370157d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4548465208589373d, b: 0.1958234099521382d, c: 0.6825780860862594d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.15327135328260588d, b: 0.6997939288591517d, c: 0.11044608203919615d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7838203602629151d, b: 0.9953289099670805d, c: 0.09528297272598196d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.28037273130082685d, b: 0.45416711555307854d, c: 0.8670267320328081d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5567402239508549d, b: 0.5155004231912056d, c: 0.7288072810463564d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9294813149915193d, b: 0.3724750068028285d, c: 0.24257297915048914d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42674295116916394d, b: 0.40621177139361564d, c: 0.7814605976954124d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.17186785488311662d, b: 0.09187363430375162d, c: 0.9996645659224903d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9400053071826222d, b: 0.9446529096111465d, c: 0.4208233487153178d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9869594755191561d, b: 0.21779604882895076d, c: 0.5419582933806114d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18824361581042204d, b: 0.11428934955927517d, c: 0.3788148404639414d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3045642851026811d, b: 0.5348630103225557d, c: 0.8201066317447061d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.29553052780468025d, b: 0.16000591801031727d, c: 0.7866881826829804d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.457863527628561d, b: 0.20480292211462514d, c: 0.5197222146075265d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7585891522021045d, b: 0.5621696143472503d, c: 0.8056918062045657d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.46429471253487586d, b: 0.046258404983642754d, c: 0.2900781954036896d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7040955257167236d, b: 0.8127699453299955d, c: 0.9103446373530538d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5136924918057622d, b: 0.7927352582990279d, c: 0.978918038322103d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.26634637090016877d, b: 0.06607618133224524d, c: 0.9778889525315652d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1605100563784645d, b: 0.4357725656001422d, c: 0.30021400603840487d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.40665009368964244d, b: 0.6846034923500988d, c: 0.3346432900194175d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8270161418940802d, b: 0.47509112365106165d, c: 0.4980394108099703d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8498309988062474d, b: 0.9225782611268103d, c: 0.4684644089131317d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21907322941645857d, b: 0.6958413989428794d, c: 0.3722262122694062d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7166662953907966d, b: 0.05531034804798385d, c: 0.4712549911472552d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5718837455681504d, b: 0.3217911187117263d, c: 0.5597741578691848d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5670923521280421d, b: 0.8022028706290676d, c: 0.24711303178872046d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13928286042220872d, b: 0.9484472225890077d, c: 0.44444736629805826d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7878766021164837d, b: 0.03452823605222477d, c: 0.5430718643275194d))));//InnerModel.NullableValue

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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
            queryMapType: typeof(NpgsqlLineline0MI),
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

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineSingleTypeline)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLineline0MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineSingleTypeline)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlLineline0M),
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

