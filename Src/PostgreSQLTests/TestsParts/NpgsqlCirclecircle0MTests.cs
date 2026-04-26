

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
    internal partial interface INpgsqlCircleSingleTypecircle
    {
    }
    
    internal partial class NpgsqlCircleSingleTypecircle : INpgsqlCircleSingleTypecircle
    {


#region TestData

        private readonly NpgsqlCirclecircle0M[] _testData = new NpgsqlCirclecircle0M[]
        {
            new NpgsqlCirclecircle0M
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9443536254834638d, y: 0.4922019465647207d), radius: 0.9982189170365228d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8891689403341698d, y: 0.24691288390997534d), radius: 0.3615634468375287d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5997517223801475d, y: 0.4153066139343242d), radius: 0.20936978119894478d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1008956414940767d, y: 0.746328208182952d), radius: 0.20111217325177322d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7738862566150901d, y: 0.8036980643251003d), radius: 0.08553659171761341d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18932265394897885d, y: 0.17667445719590436d), radius: 0.4615939825088339d),
},
            new NpgsqlCirclecircle0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.833356759406552d, y: 0.8869878572524703d), radius: 0.1389977776117055d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29071169737360214d, y: 0.9979879995702606d), radius: 0.9719129288144903d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37056148390362587d, y: 0.7626378185099684d), radius: 0.43027177663318605d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1726740442704383d, y: 0.9937369950994916d), radius: 0.814056791176044d),
},
            new NpgsqlCirclecircle0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07131623892789651d, y: 0.7640095949774068d), radius: 0.4910415692390099d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.028664182893077705d, y: 0.33598340316213726d), radius: 0.23260268624907976d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6808200836525501d, y: 0.48933694091530267d), radius: 0.4992007052582498d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35533899401005187d, y: 0.24963897135535718d), radius: 0.1076063190170723d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7058250249852248d, y: 0.7777263015980783d), radius: 0.048310320332161316d),
},
            new NpgsqlCirclecircle0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6296105108999932d, y: 0.8436253101424563d), radius: 0.4966786546793812d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.468813576840753d, y: 0.9358490689281647d), radius: 0.04737937534517733d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26713786419729413d, y: 0.006676908861024677d), radius: 0.8843332113891051d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5344092142592076d, y: 0.13755597051822077d), radius: 0.14512986988302135d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8147969517923818d, y: 0.07445190111022681d), radius: 0.5540817026059389d),
},
            new NpgsqlCirclecircle0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3097664565214676d, y: 0.2508023483551609d), radius: 0.16876173155101382d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3421689658858358d, y: 0.6566436985730835d), radius: 0.3305611192022143d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3375497379289025d, y: 0.3970576316111901d), radius: 0.5121374978144317d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7413952285731652d, y: 0.9630093799330746d), radius: 0.7665891650996233d),
},
            new NpgsqlCirclecircle0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27585600517199915d, y: 0.2165208915869583d), radius: 0.49557491700979195d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5085562184077607d, y: 0.8797926564237374d), radius: 0.31861559392213135d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08618859941393486d, y: 0.09598684004806124d), radius: 0.11937697455913776d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3814186123762958d, y: 0.2870756742110252d), radius: 0.6352625758109772d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5042359861238721d, y: 0.027156774444867082d), radius: 0.9038567648230608d),
},
            new NpgsqlCirclecircle0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2445932631780111d, y: 0.33638838311943997d), radius: 0.011182059097638142d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5629865008326441d, y: 0.28386771754709206d), radius: 0.6338229463710551d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6377638891240085d, y: 0.4287160482340693d), radius: 0.7235106370685815d),
},
            new NpgsqlCirclecircle0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6803069343957383d, y: 0.5291461807033033d), radius: 0.06320538467460413d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5359159548356133d, y: 0.8505989984034121d), radius: 0.9762175518095912d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9400899535443369d, y: 0.7698808694279186d), radius: 0.515197198532642d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2862075930900023d, y: 0.19948246660720126d), radius: 0.7571780125898427d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5757869755441706d, y: 0.5235252676584343d), radius: 0.9639657580271231d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0799314646292103d, y: 0.0036487311372774833d), radius: 0.3988822484693797d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35674184608670756d, y: 0.262256966995551d), radius: 0.6237778901151151d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42248735758938505d, y: 0.16631538418752867d), radius: 0.7508988578566151d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3748968073344028d, y: 0.20455466995583016d), radius: 0.6595793264294039d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7233418163365622d, y: 0.871820889333456d), radius: 0.4086640100683131d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6564905471782008d, y: 0.7857078153372528d), radius: 0.271297890378033d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09434354759817043d, y: 0.03642630280653503d), radius: 0.9705929910596496d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22997187342205194d, y: 0.746473713347839d), radius: 0.05848804982505984d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2286260657875966d, y: 0.21234943154792307d), radius: 0.9870054309876566d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5051278327164452d, y: 0.45764292554006347d), radius: 0.0005291732539164373d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6947057948544827d, y: 0.3519440414156254d), radius: 0.5205156057301682d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30709371525936513d, y: 0.2625608101792948d), radius: 0.9120517286034305d),
},
            new NpgsqlCirclecircle0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2998914029670704d, y: 0.49057506093057457d), radius: 0.2202267879687596d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3202747033247979d, y: 0.4901741973595274d), radius: 0.36471481582493603d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.296667758718861d, y: 0.5683039182501909d), radius: 0.5965296527660449d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878586575024639d, y: 0.07207249648549718d), radius: 0.6218088065165462d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2160084335844048d, y: 0.9822894071531766d), radius: 0.5907706356934069d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2623785600727577d, y: 0.12171934610041268d), radius: 0.6729900932364895d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027870821225045583d, y: 0.8511836749493258d), radius: 0.8111003605224231d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4278460473059037d, y: 0.049551359630727876d), radius: 0.17373531238031104d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6572150246152081d, y: 0.7004457485020692d), radius: 0.47164921647669333d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9769464939461594d, y: 0.18218967153151489d), radius: 0.2705919734881609d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5163149414194792d, y: 0.9190419189171173d), radius: 0.4278251502020626d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3897154847867633d, y: 0.0832673277328364d), radius: 0.8021473359398085d),
},
            new NpgsqlCirclecircle0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44212943265357096d, y: 0.8946269853999643d), radius: 0.9029250810607373d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09753173427518036d, y: 0.5843708599153988d), radius: 0.2040296433732719d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18593982057355418d, y: 0.884546684778944d), radius: 0.9650712109411962d),
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7058250249852248d, y: 0.7777263015980783d), radius: 0.048310320332161316d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8147969517923818d, y: 0.07445190111022681d), radius: 0.5540817026059389d)));
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7413952285731652d, y: 0.9630093799330746d), radius: 0.7665891650996233d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;

                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;

                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlcirclecircle0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlCircle), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlcirclecircle0mi_id", 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[26],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[30], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[30], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[29], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 140, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 121, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 80, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 117, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 82, query1, 14, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[26],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 139, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[30], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 129, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 53, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[30], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 80, 137))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[29], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 70, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[29], false);
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
                await using var cmd = await ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 14);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[3], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[4], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[5], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[6], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[7], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[8], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[9], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[10], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[11], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[12], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[13], false);NpgsqlCirclecircle0M.AssertModel(models[11],_testData[14], false);NpgsqlCirclecircle0M.AssertModel(models[12],_testData[15], false);NpgsqlCirclecircle0M.AssertModel(models[13],_testData[16], false);NpgsqlCirclecircle0M.AssertModel(models[14],_testData[17], false);NpgsqlCirclecircle0M.AssertModel(models[15],_testData[18], false);NpgsqlCirclecircle0M.AssertModel(models[16],_testData[19], false);NpgsqlCirclecircle0M.AssertModel(models[17],_testData[20], false);NpgsqlCirclecircle0M.AssertModel(models[18],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[19],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[20],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[21],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[22],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[23],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[24],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[25],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 3);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[1], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[2], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[3], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[4], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[5], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[6], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[7], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[8], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[9], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[10], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[11], false);NpgsqlCirclecircle0M.AssertModel(models[11],_testData[12], false);NpgsqlCirclecircle0M.AssertModel(models[12],_testData[13], false);NpgsqlCirclecircle0M.AssertModel(models[13],_testData[14], false);NpgsqlCirclecircle0M.AssertModel(models[14],_testData[15], false);NpgsqlCirclecircle0M.AssertModel(models[15],_testData[16], false);NpgsqlCirclecircle0M.AssertModel(models[16],_testData[17], false);NpgsqlCirclecircle0M.AssertModel(models[17],_testData[18], false);NpgsqlCirclecircle0M.AssertModel(models[18],_testData[19], false);NpgsqlCirclecircle0M.AssertModel(models[19],_testData[20], false);NpgsqlCirclecircle0M.AssertModel(models[20],_testData[21], false);NpgsqlCirclecircle0M.AssertModel(models[21],_testData[22], false);NpgsqlCirclecircle0M.AssertModel(models[22],_testData[23], false);NpgsqlCirclecircle0M.AssertModel(models[23],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[24],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[25],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[26],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[27],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[28],_testData[29], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9443536254834638d, y: 0.4922019465647207d), radius: 0.9982189170365228d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8891689403341698d, y: 0.24691288390997534d), radius: 0.3615634468375287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5997517223801475d, y: 0.4153066139343242d), radius: 0.20936978119894478d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1008956414940767d, y: 0.746328208182952d), radius: 0.20111217325177322d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7738862566150901d, y: 0.8036980643251003d), radius: 0.08553659171761341d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18932265394897885d, y: 0.17667445719590436d), radius: 0.4615939825088339d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.833356759406552d, y: 0.8869878572524703d), radius: 0.1389977776117055d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29071169737360214d, y: 0.9979879995702606d), radius: 0.9719129288144903d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37056148390362587d, y: 0.7626378185099684d), radius: 0.43027177663318605d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1726740442704383d, y: 0.9937369950994916d), radius: 0.814056791176044d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07131623892789651d, y: 0.7640095949774068d), radius: 0.4910415692390099d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.028664182893077705d, y: 0.33598340316213726d), radius: 0.23260268624907976d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6808200836525501d, y: 0.48933694091530267d), radius: 0.4992007052582498d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35533899401005187d, y: 0.24963897135535718d), radius: 0.1076063190170723d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7058250249852248d, y: 0.7777263015980783d), radius: 0.048310320332161316d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6296105108999932d, y: 0.8436253101424563d), radius: 0.4966786546793812d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.468813576840753d, y: 0.9358490689281647d), radius: 0.04737937534517733d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26713786419729413d, y: 0.006676908861024677d), radius: 0.8843332113891051d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5344092142592076d, y: 0.13755597051822077d), radius: 0.14512986988302135d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8147969517923818d, y: 0.07445190111022681d), radius: 0.5540817026059389d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3097664565214676d, y: 0.2508023483551609d), radius: 0.16876173155101382d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3421689658858358d, y: 0.6566436985730835d), radius: 0.3305611192022143d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3375497379289025d, y: 0.3970576316111901d), radius: 0.5121374978144317d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7413952285731652d, y: 0.9630093799330746d), radius: 0.7665891650996233d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27585600517199915d, y: 0.2165208915869583d), radius: 0.49557491700979195d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5085562184077607d, y: 0.8797926564237374d), radius: 0.31861559392213135d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08618859941393486d, y: 0.09598684004806124d), radius: 0.11937697455913776d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3814186123762958d, y: 0.2870756742110252d), radius: 0.6352625758109772d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5042359861238721d, y: 0.027156774444867082d), radius: 0.9038567648230608d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2445932631780111d, y: 0.33638838311943997d), radius: 0.011182059097638142d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5629865008326441d, y: 0.28386771754709206d), radius: 0.6338229463710551d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6377638891240085d, y: 0.4287160482340693d), radius: 0.7235106370685815d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6803069343957383d, y: 0.5291461807033033d), radius: 0.06320538467460413d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5359159548356133d, y: 0.8505989984034121d), radius: 0.9762175518095912d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9400899535443369d, y: 0.7698808694279186d), radius: 0.515197198532642d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2862075930900023d, y: 0.19948246660720126d), radius: 0.7571780125898427d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5757869755441706d, y: 0.5235252676584343d), radius: 0.9639657580271231d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0799314646292103d, y: 0.0036487311372774833d), radius: 0.3988822484693797d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35674184608670756d, y: 0.262256966995551d), radius: 0.6237778901151151d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42248735758938505d, y: 0.16631538418752867d), radius: 0.7508988578566151d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3748968073344028d, y: 0.20455466995583016d), radius: 0.6595793264294039d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7233418163365622d, y: 0.871820889333456d), radius: 0.4086640100683131d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6564905471782008d, y: 0.7857078153372528d), radius: 0.271297890378033d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09434354759817043d, y: 0.03642630280653503d), radius: 0.9705929910596496d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22997187342205194d, y: 0.746473713347839d), radius: 0.05848804982505984d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2286260657875966d, y: 0.21234943154792307d), radius: 0.9870054309876566d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5051278327164452d, y: 0.45764292554006347d), radius: 0.0005291732539164373d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6947057948544827d, y: 0.3519440414156254d), radius: 0.5205156057301682d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30709371525936513d, y: 0.2625608101792948d), radius: 0.9120517286034305d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2998914029670704d, y: 0.49057506093057457d), radius: 0.2202267879687596d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3202747033247979d, y: 0.4901741973595274d), radius: 0.36471481582493603d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.296667758718861d, y: 0.5683039182501909d), radius: 0.5965296527660449d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878586575024639d, y: 0.07207249648549718d), radius: 0.6218088065165462d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2160084335844048d, y: 0.9822894071531766d), radius: 0.5907706356934069d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2623785600727577d, y: 0.12171934610041268d), radius: 0.6729900932364895d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027870821225045583d, y: 0.8511836749493258d), radius: 0.8111003605224231d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4278460473059037d, y: 0.049551359630727876d), radius: 0.17373531238031104d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6572150246152081d, y: 0.7004457485020692d), radius: 0.47164921647669333d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9769464939461594d, y: 0.18218967153151489d), radius: 0.2705919734881609d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5163149414194792d, y: 0.9190419189171173d), radius: 0.4278251502020626d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3897154847867633d, y: 0.0832673277328364d), radius: 0.8021473359398085d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44212943265357096d, y: 0.8946269853999643d), radius: 0.9029250810607373d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09753173427518036d, y: 0.5843708599153988d), radius: 0.2040296433732719d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18593982057355418d, y: 0.884546684778944d), radius: 0.9650712109411962d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9443536254834638d, y: 0.4922019465647207d), radius: 0.9982189170365228d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8891689403341698d, y: 0.24691288390997534d), radius: 0.3615634468375287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5997517223801475d, y: 0.4153066139343242d), radius: 0.20936978119894478d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1008956414940767d, y: 0.746328208182952d), radius: 0.20111217325177322d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7738862566150901d, y: 0.8036980643251003d), radius: 0.08553659171761341d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18932265394897885d, y: 0.17667445719590436d), radius: 0.4615939825088339d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.833356759406552d, y: 0.8869878572524703d), radius: 0.1389977776117055d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29071169737360214d, y: 0.9979879995702606d), radius: 0.9719129288144903d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37056148390362587d, y: 0.7626378185099684d), radius: 0.43027177663318605d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1726740442704383d, y: 0.9937369950994916d), radius: 0.814056791176044d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07131623892789651d, y: 0.7640095949774068d), radius: 0.4910415692390099d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.028664182893077705d, y: 0.33598340316213726d), radius: 0.23260268624907976d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6808200836525501d, y: 0.48933694091530267d), radius: 0.4992007052582498d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35533899401005187d, y: 0.24963897135535718d), radius: 0.1076063190170723d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7058250249852248d, y: 0.7777263015980783d), radius: 0.048310320332161316d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6296105108999932d, y: 0.8436253101424563d), radius: 0.4966786546793812d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.468813576840753d, y: 0.9358490689281647d), radius: 0.04737937534517733d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26713786419729413d, y: 0.006676908861024677d), radius: 0.8843332113891051d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5344092142592076d, y: 0.13755597051822077d), radius: 0.14512986988302135d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8147969517923818d, y: 0.07445190111022681d), radius: 0.5540817026059389d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3097664565214676d, y: 0.2508023483551609d), radius: 0.16876173155101382d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3421689658858358d, y: 0.6566436985730835d), radius: 0.3305611192022143d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3375497379289025d, y: 0.3970576316111901d), radius: 0.5121374978144317d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7413952285731652d, y: 0.9630093799330746d), radius: 0.7665891650996233d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27585600517199915d, y: 0.2165208915869583d), radius: 0.49557491700979195d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5085562184077607d, y: 0.8797926564237374d), radius: 0.31861559392213135d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08618859941393486d, y: 0.09598684004806124d), radius: 0.11937697455913776d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3814186123762958d, y: 0.2870756742110252d), radius: 0.6352625758109772d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5042359861238721d, y: 0.027156774444867082d), radius: 0.9038567648230608d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2445932631780111d, y: 0.33638838311943997d), radius: 0.011182059097638142d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5629865008326441d, y: 0.28386771754709206d), radius: 0.6338229463710551d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6377638891240085d, y: 0.4287160482340693d), radius: 0.7235106370685815d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6803069343957383d, y: 0.5291461807033033d), radius: 0.06320538467460413d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5359159548356133d, y: 0.8505989984034121d), radius: 0.9762175518095912d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9400899535443369d, y: 0.7698808694279186d), radius: 0.515197198532642d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2862075930900023d, y: 0.19948246660720126d), radius: 0.7571780125898427d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5757869755441706d, y: 0.5235252676584343d), radius: 0.9639657580271231d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0799314646292103d, y: 0.0036487311372774833d), radius: 0.3988822484693797d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35674184608670756d, y: 0.262256966995551d), radius: 0.6237778901151151d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42248735758938505d, y: 0.16631538418752867d), radius: 0.7508988578566151d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3748968073344028d, y: 0.20455466995583016d), radius: 0.6595793264294039d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7233418163365622d, y: 0.871820889333456d), radius: 0.4086640100683131d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6564905471782008d, y: 0.7857078153372528d), radius: 0.271297890378033d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09434354759817043d, y: 0.03642630280653503d), radius: 0.9705929910596496d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22997187342205194d, y: 0.746473713347839d), radius: 0.05848804982505984d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2286260657875966d, y: 0.21234943154792307d), radius: 0.9870054309876566d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5051278327164452d, y: 0.45764292554006347d), radius: 0.0005291732539164373d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6947057948544827d, y: 0.3519440414156254d), radius: 0.5205156057301682d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30709371525936513d, y: 0.2625608101792948d), radius: 0.9120517286034305d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2998914029670704d, y: 0.49057506093057457d), radius: 0.2202267879687596d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3202747033247979d, y: 0.4901741973595274d), radius: 0.36471481582493603d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.296667758718861d, y: 0.5683039182501909d), radius: 0.5965296527660449d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9878586575024639d, y: 0.07207249648549718d), radius: 0.6218088065165462d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2160084335844048d, y: 0.9822894071531766d), radius: 0.5907706356934069d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2623785600727577d, y: 0.12171934610041268d), radius: 0.6729900932364895d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027870821225045583d, y: 0.8511836749493258d), radius: 0.8111003605224231d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4278460473059037d, y: 0.049551359630727876d), radius: 0.17373531238031104d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6572150246152081d, y: 0.7004457485020692d), radius: 0.47164921647669333d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9769464939461594d, y: 0.18218967153151489d), radius: 0.2705919734881609d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5163149414194792d, y: 0.9190419189171173d), radius: 0.4278251502020626d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3897154847867633d, y: 0.0832673277328364d), radius: 0.8021473359398085d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44212943265357096d, y: 0.8946269853999643d), radius: 0.9029250810607373d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09753173427518036d, y: 0.5843708599153988d), radius: 0.2040296433732719d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18593982057355418d, y: 0.884546684778944d), radius: 0.9650712109411962d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircle0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlCircleSingleTypecircle)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlCircleSingleTypecircle)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
FROM public.binary_npgsqlcirclecircle0m m
LEFT JOIN public.binary_npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircle0M>(15);

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
                ((INpgsqlCircleSingleTypecircle)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircle0M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircle0M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircle0M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircle0M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircle0M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircle0M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircle0M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircle0M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircle0M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircle0M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircle0M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircle0M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircle0M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircle0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircle0M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircle0M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircle0M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircle0M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircle0M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircle0M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircle0M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircle0M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircle0M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircle0M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircle0M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircle0M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircle0M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircle0M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircle0M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircle0M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircle0M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircle0M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircle0M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircle0M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircle0M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircle0M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircle0M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircle0M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircle0M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircle0M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircle0M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircle0M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircle0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircle0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircle0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

