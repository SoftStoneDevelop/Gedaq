

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
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.28570031084087255d, b: 0.7158886316539325d, c: 0.8383990146657055d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.19002705121602836d, b: 0.2732052137444805d, c: 0.01201780370876393d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.369307376689719d, b: 0.7007061355160176d, c: 0.4201982872294189d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.2063279022723039d, b: 0.0870128824991141d, c: 0.018566717668492383d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8066151670462398d, b: 0.10683616494336212d, c: 0.7900768967364799d),
},
            new NpgsqlLineline0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.23243581873536812d, b: 0.08783175605996296d, c: 0.3407721521787255d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.21418238581423132d, b: 0.44105361781950003d, c: 0.2883000384991389d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.03176111842806484d, b: 0.9261139929188679d, c: 0.1498767840645686d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6084336667156317d, b: 0.7167793128300309d, c: 0.07091134841460578d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8076201814789463d, b: 0.78214105765282d, c: 0.02058107424927136d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8271905426381777d, b: 0.8947217577751971d, c: 0.4929727945408626d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9091937421576854d, b: 0.012889082862923895d, c: 0.8977766985568665d),
},
            new NpgsqlLineline0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5566167667518546d, b: 0.08912255975647976d, c: 0.7447102962788195d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.42620524488222367d, b: 0.7650347664604427d, c: 0.7706588109977602d),
},
            new NpgsqlLineline0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4840635078581007d, b: 0.5104514609854052d, c: 0.7702331112161904d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4664894320218166d, b: 0.7549991228308698d, c: 0.36103629003220605d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.834028570868479d, b: 0.6674967057842994d, c: 0.0794721164516553d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.004970702127799154d, b: 0.6339573982473341d, c: 0.31368080722780256d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.19823636631878894d, b: 0.6348415918706859d, c: 0.8627356353607196d),
},
            new NpgsqlLineline0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8547595296125773d, b: 0.2737430497330594d, c: 0.05374283367796562d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2534227725018252d, b: 0.22035429452108946d, c: 0.5544566913761277d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.210498902610888d, b: 0.8985472925785885d, c: 0.8577254360130686d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.19227997856750634d, b: 0.5455609639794688d, c: 0.9357879609141524d),
},
            new NpgsqlLineline0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.26470751105870083d, b: 0.3006066694352756d, c: 0.1406459503602332d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7608318506188779d, b: 0.442547982586292d, c: 0.6451120528967293d),
},
            new NpgsqlLineline0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9406567838642562d, b: 0.1879771074642853d, c: 0.35462780886642287d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.761499186974486d, b: 0.5921206709657071d, c: 0.5171908409404328d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6219999341249174d, b: 0.44129642582122286d, c: 0.7118187409482133d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.08977405047992115d, b: 0.23567052350132423d, c: 0.030853296446717637d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.38005538343880585d, b: 0.8533257890173865d, c: 0.40980129366787277d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.20608797505366916d, b: 0.4813099261351719d, c: 0.31247835291888326d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.25323042374222915d, b: 0.32379060094792855d, c: 0.5720831718127918d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.20896729714198004d, b: 0.8594525622825849d, c: 0.32890217541759226d),
},
            new NpgsqlLineline0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1923368301677213d, b: 0.613414156962471d, c: 0.48398819301413465d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6601410594028747d, b: 0.9085419893700563d, c: 0.49074798806414077d),
},
            new NpgsqlLineline0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8204597492223635d, b: 0.37972970211328694d, c: 0.5770435138199943d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8466312820259254d, b: 0.6079664207096003d, c: 0.7632724810986483d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.24625063681860193d, b: 0.2184421524886846d, c: 0.34976209097390953d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9435960566325654d, b: 0.10096201365543789d, c: 0.8334175103185852d),
},
            new NpgsqlLineline0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8188079166360126d, b: 0.017752582150156182d, c: 0.8601818255342392d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7276872621078171d, b: 0.7686152993518613d, c: 0.6705132494926641d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4808272421583334d, b: 0.7431553268010578d, c: 0.6351999322957497d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3303593064078013d, b: 0.07272483461247914d, c: 0.8319341282645337d),
},
            new NpgsqlLineline0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9107015248969303d, b: 0.7476809047811984d, c: 0.3598429930864375d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7719769381017632d, b: 0.4541117849086679d, c: 0.9506110866686601d),
},
            new NpgsqlLineline0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12857895809613384d, b: 0.9200575297708038d, c: 0.5583477885895266d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3269389393180806d, b: 0.9247123858760264d, c: 0.07065022276083288d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.47653193353129664d, b: 0.8625741672516366d, c: 0.16822757212348094d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.38332738782472275d, b: 0.2056471730253967d, c: 0.6089791584954823d),
},
            new NpgsqlLineline0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6505734063978977d, b: 0.14524285522409475d, c: 0.08497555022056225d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.1423583548566183d, b: 0.8524233160594051d, c: 0.4994883737146194d),
},
            new NpgsqlLineline0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2316092642705624d, b: 0.22948720295874248d, c: 0.08504849485397625d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.09190434957476523d, b: 0.7777165240688021d, c: 0.9204980749785683d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9188712328322712d, b: 0.9798298911903467d, c: 0.9690032453868733d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3994687223776736d, b: 0.2897663112346349d, c: 0.16541686784046017d),
},
            new NpgsqlLineline0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5248672386652216d, b: 0.7864391064854557d, c: 0.5852692916045283d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.80220132142867d, b: 0.929462085731671d, c: 0.8439701162251887d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9845537661949065d, b: 0.6084383163957743d, c: 0.5398887878451889d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8962975525333662d, b: 0.621594063414007d, c: 0.7940909231626118d),
},
            new NpgsqlLineline0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8002760330563439d, b: 0.6790038990190186d, c: 0.8375267535856071d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4331284064411104d, b: 0.6539825084983629d, c: 0.00798472535114747d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.00923083309851791d, b: 0.3835519718246607d, c: 0.030304758888862193d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.08376788125427681d, b: 0.7524243865926888d, c: 0.11138880661363881d),
},
            new NpgsqlLineline0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2937454957486847d, b: 0.8886835597294448d, c: 0.9053358639474719d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8041589649350663d, b: 0.20093963025210515d, c: 0.19566740581740705d),
},
            new NpgsqlLineline0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8922632827942678d, b: 0.5153919031788047d, c: 0.859211920658587d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7669013204428158d, b: 0.9527149158018738d, c: 0.8933283358379628d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.07615186907528648d, b: 0.8616093450149542d, c: 0.7846341736823647d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.33997490374187966d, b: 0.2565204623431099d, c: 0.24570931078963576d),
},
            new NpgsqlLineline0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8163860641053444d, b: 0.5156687801696106d, c: 0.11618109548588995d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8011588881052847d, b: 0.0808406228772145d, c: 0.8181512624830581d),
},
            new NpgsqlLineline0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8260211344257687d, b: 0.8250692017168565d, c: 0.2653389773108912d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.43387015807680007d, b: 0.7305759673718307d, c: 0.29143973485339947d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.997826051564723d, b: 0.7636239090105578d, c: 0.8602759008337398d),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.9091937421576854d, b: 0.012889082862923895d, c: 0.8977766985568665d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.42620524488222367d, b: 0.7650347664604427d, c: 0.7706588109977602d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.19823636631878894d, b: 0.6348415918706859d, c: 0.8627356353607196d)));
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.19227997856750634d, b: 0.5455609639794688d, c: 0.9357879609141524d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.7608318506188779d, b: 0.442547982586292d, c: 0.6451120528967293d)));
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[29], false);
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
                parametr2.Value = 135;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[29], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[29], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 1;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[29], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[29], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[29], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[29], false);
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 24, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[25],_testData[29], false);
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 41, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[29], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 58, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[29], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 1, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 10, query1, 69, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[29], false);
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
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 144, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 144, query1, 129, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[29], false);
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
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 63, query1, 135, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 50, 107))
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 33, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[29], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 50);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
NpgsqlLineline0M.AssertModel(models[0],_testData[10], false);NpgsqlLineline0M.AssertModel(models[1],_testData[11], false);NpgsqlLineline0M.AssertModel(models[2],_testData[12], false);NpgsqlLineline0M.AssertModel(models[3],_testData[13], false);NpgsqlLineline0M.AssertModel(models[4],_testData[14], false);NpgsqlLineline0M.AssertModel(models[5],_testData[15], false);NpgsqlLineline0M.AssertModel(models[6],_testData[16], false);NpgsqlLineline0M.AssertModel(models[7],_testData[17], false);NpgsqlLineline0M.AssertModel(models[8],_testData[18], false);NpgsqlLineline0M.AssertModel(models[9],_testData[19], false);NpgsqlLineline0M.AssertModel(models[10],_testData[20], false);NpgsqlLineline0M.AssertModel(models[11],_testData[21], false);NpgsqlLineline0M.AssertModel(models[12],_testData[22], false);NpgsqlLineline0M.AssertModel(models[13],_testData[23], false);NpgsqlLineline0M.AssertModel(models[14],_testData[24], false);NpgsqlLineline0M.AssertModel(models[15],_testData[25], false);NpgsqlLineline0M.AssertModel(models[16],_testData[26], false);NpgsqlLineline0M.AssertModel(models[17],_testData[27], false);NpgsqlLineline0M.AssertModel(models[18],_testData[28], false);NpgsqlLineline0M.AssertModel(models[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlLineline0M.AssertModel(models[0],_testData[12], false);NpgsqlLineline0M.AssertModel(models[1],_testData[13], false);NpgsqlLineline0M.AssertModel(models[2],_testData[14], false);NpgsqlLineline0M.AssertModel(models[3],_testData[15], false);NpgsqlLineline0M.AssertModel(models[4],_testData[16], false);NpgsqlLineline0M.AssertModel(models[5],_testData[17], false);NpgsqlLineline0M.AssertModel(models[6],_testData[18], false);NpgsqlLineline0M.AssertModel(models[7],_testData[19], false);NpgsqlLineline0M.AssertModel(models[8],_testData[20], false);NpgsqlLineline0M.AssertModel(models[9],_testData[21], false);NpgsqlLineline0M.AssertModel(models[10],_testData[22], false);NpgsqlLineline0M.AssertModel(models[11],_testData[23], false);NpgsqlLineline0M.AssertModel(models[12],_testData[24], false);NpgsqlLineline0M.AssertModel(models[13],_testData[25], false);NpgsqlLineline0M.AssertModel(models[14],_testData[26], false);NpgsqlLineline0M.AssertModel(models[15],_testData[27], false);NpgsqlLineline0M.AssertModel(models[16],_testData[28], false);NpgsqlLineline0M.AssertModel(models[17],_testData[29], false);
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
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.28570031084087255d, b: 0.7158886316539325d, c: 0.8383990146657055d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19002705121602836d, b: 0.2732052137444805d, c: 0.01201780370876393d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.369307376689719d, b: 0.7007061355160176d, c: 0.4201982872294189d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2063279022723039d, b: 0.0870128824991141d, c: 0.018566717668492383d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8066151670462398d, b: 0.10683616494336212d, c: 0.7900768967364799d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23243581873536812d, b: 0.08783175605996296d, c: 0.3407721521787255d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21418238581423132d, b: 0.44105361781950003d, c: 0.2883000384991389d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03176111842806484d, b: 0.9261139929188679d, c: 0.1498767840645686d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6084336667156317d, b: 0.7167793128300309d, c: 0.07091134841460578d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8076201814789463d, b: 0.78214105765282d, c: 0.02058107424927136d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8271905426381777d, b: 0.8947217577751971d, c: 0.4929727945408626d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9091937421576854d, b: 0.012889082862923895d, c: 0.8977766985568665d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5566167667518546d, b: 0.08912255975647976d, c: 0.7447102962788195d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42620524488222367d, b: 0.7650347664604427d, c: 0.7706588109977602d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4840635078581007d, b: 0.5104514609854052d, c: 0.7702331112161904d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4664894320218166d, b: 0.7549991228308698d, c: 0.36103629003220605d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.834028570868479d, b: 0.6674967057842994d, c: 0.0794721164516553d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.004970702127799154d, b: 0.6339573982473341d, c: 0.31368080722780256d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19823636631878894d, b: 0.6348415918706859d, c: 0.8627356353607196d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8547595296125773d, b: 0.2737430497330594d, c: 0.05374283367796562d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2534227725018252d, b: 0.22035429452108946d, c: 0.5544566913761277d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.210498902610888d, b: 0.8985472925785885d, c: 0.8577254360130686d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19227997856750634d, b: 0.5455609639794688d, c: 0.9357879609141524d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.26470751105870083d, b: 0.3006066694352756d, c: 0.1406459503602332d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7608318506188779d, b: 0.442547982586292d, c: 0.6451120528967293d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9406567838642562d, b: 0.1879771074642853d, c: 0.35462780886642287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.761499186974486d, b: 0.5921206709657071d, c: 0.5171908409404328d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6219999341249174d, b: 0.44129642582122286d, c: 0.7118187409482133d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08977405047992115d, b: 0.23567052350132423d, c: 0.030853296446717637d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.38005538343880585d, b: 0.8533257890173865d, c: 0.40980129366787277d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20608797505366916d, b: 0.4813099261351719d, c: 0.31247835291888326d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25323042374222915d, b: 0.32379060094792855d, c: 0.5720831718127918d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20896729714198004d, b: 0.8594525622825849d, c: 0.32890217541759226d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1923368301677213d, b: 0.613414156962471d, c: 0.48398819301413465d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6601410594028747d, b: 0.9085419893700563d, c: 0.49074798806414077d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8204597492223635d, b: 0.37972970211328694d, c: 0.5770435138199943d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8466312820259254d, b: 0.6079664207096003d, c: 0.7632724810986483d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24625063681860193d, b: 0.2184421524886846d, c: 0.34976209097390953d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9435960566325654d, b: 0.10096201365543789d, c: 0.8334175103185852d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8188079166360126d, b: 0.017752582150156182d, c: 0.8601818255342392d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7276872621078171d, b: 0.7686152993518613d, c: 0.6705132494926641d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4808272421583334d, b: 0.7431553268010578d, c: 0.6351999322957497d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3303593064078013d, b: 0.07272483461247914d, c: 0.8319341282645337d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9107015248969303d, b: 0.7476809047811984d, c: 0.3598429930864375d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7719769381017632d, b: 0.4541117849086679d, c: 0.9506110866686601d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12857895809613384d, b: 0.9200575297708038d, c: 0.5583477885895266d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3269389393180806d, b: 0.9247123858760264d, c: 0.07065022276083288d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47653193353129664d, b: 0.8625741672516366d, c: 0.16822757212348094d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.38332738782472275d, b: 0.2056471730253967d, c: 0.6089791584954823d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6505734063978977d, b: 0.14524285522409475d, c: 0.08497555022056225d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1423583548566183d, b: 0.8524233160594051d, c: 0.4994883737146194d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2316092642705624d, b: 0.22948720295874248d, c: 0.08504849485397625d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09190434957476523d, b: 0.7777165240688021d, c: 0.9204980749785683d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9188712328322712d, b: 0.9798298911903467d, c: 0.9690032453868733d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3994687223776736d, b: 0.2897663112346349d, c: 0.16541686784046017d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5248672386652216d, b: 0.7864391064854557d, c: 0.5852692916045283d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.80220132142867d, b: 0.929462085731671d, c: 0.8439701162251887d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9845537661949065d, b: 0.6084383163957743d, c: 0.5398887878451889d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8962975525333662d, b: 0.621594063414007d, c: 0.7940909231626118d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8002760330563439d, b: 0.6790038990190186d, c: 0.8375267535856071d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4331284064411104d, b: 0.6539825084983629d, c: 0.00798472535114747d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.00923083309851791d, b: 0.3835519718246607d, c: 0.030304758888862193d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08376788125427681d, b: 0.7524243865926888d, c: 0.11138880661363881d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2937454957486847d, b: 0.8886835597294448d, c: 0.9053358639474719d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8041589649350663d, b: 0.20093963025210515d, c: 0.19566740581740705d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8922632827942678d, b: 0.5153919031788047d, c: 0.859211920658587d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7669013204428158d, b: 0.9527149158018738d, c: 0.8933283358379628d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07615186907528648d, b: 0.8616093450149542d, c: 0.7846341736823647d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33997490374187966d, b: 0.2565204623431099d, c: 0.24570931078963576d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8163860641053444d, b: 0.5156687801696106d, c: 0.11618109548588995d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8011588881052847d, b: 0.0808406228772145d, c: 0.8181512624830581d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8260211344257687d, b: 0.8250692017168565d, c: 0.2653389773108912d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43387015807680007d, b: 0.7305759673718307d, c: 0.29143973485339947d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.997826051564723d, b: 0.7636239090105578d, c: 0.8602759008337398d))));

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
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.28570031084087255d, b: 0.7158886316539325d, c: 0.8383990146657055d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19002705121602836d, b: 0.2732052137444805d, c: 0.01201780370876393d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.369307376689719d, b: 0.7007061355160176d, c: 0.4201982872294189d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2063279022723039d, b: 0.0870128824991141d, c: 0.018566717668492383d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8066151670462398d, b: 0.10683616494336212d, c: 0.7900768967364799d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23243581873536812d, b: 0.08783175605996296d, c: 0.3407721521787255d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.21418238581423132d, b: 0.44105361781950003d, c: 0.2883000384991389d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.03176111842806484d, b: 0.9261139929188679d, c: 0.1498767840645686d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6084336667156317d, b: 0.7167793128300309d, c: 0.07091134841460578d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8076201814789463d, b: 0.78214105765282d, c: 0.02058107424927136d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8271905426381777d, b: 0.8947217577751971d, c: 0.4929727945408626d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9091937421576854d, b: 0.012889082862923895d, c: 0.8977766985568665d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5566167667518546d, b: 0.08912255975647976d, c: 0.7447102962788195d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.42620524488222367d, b: 0.7650347664604427d, c: 0.7706588109977602d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4840635078581007d, b: 0.5104514609854052d, c: 0.7702331112161904d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4664894320218166d, b: 0.7549991228308698d, c: 0.36103629003220605d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.834028570868479d, b: 0.6674967057842994d, c: 0.0794721164516553d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.004970702127799154d, b: 0.6339573982473341d, c: 0.31368080722780256d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19823636631878894d, b: 0.6348415918706859d, c: 0.8627356353607196d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8547595296125773d, b: 0.2737430497330594d, c: 0.05374283367796562d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2534227725018252d, b: 0.22035429452108946d, c: 0.5544566913761277d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.210498902610888d, b: 0.8985472925785885d, c: 0.8577254360130686d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19227997856750634d, b: 0.5455609639794688d, c: 0.9357879609141524d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.26470751105870083d, b: 0.3006066694352756d, c: 0.1406459503602332d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7608318506188779d, b: 0.442547982586292d, c: 0.6451120528967293d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9406567838642562d, b: 0.1879771074642853d, c: 0.35462780886642287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.761499186974486d, b: 0.5921206709657071d, c: 0.5171908409404328d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6219999341249174d, b: 0.44129642582122286d, c: 0.7118187409482133d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08977405047992115d, b: 0.23567052350132423d, c: 0.030853296446717637d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.38005538343880585d, b: 0.8533257890173865d, c: 0.40980129366787277d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20608797505366916d, b: 0.4813099261351719d, c: 0.31247835291888326d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25323042374222915d, b: 0.32379060094792855d, c: 0.5720831718127918d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20896729714198004d, b: 0.8594525622825849d, c: 0.32890217541759226d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1923368301677213d, b: 0.613414156962471d, c: 0.48398819301413465d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6601410594028747d, b: 0.9085419893700563d, c: 0.49074798806414077d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8204597492223635d, b: 0.37972970211328694d, c: 0.5770435138199943d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8466312820259254d, b: 0.6079664207096003d, c: 0.7632724810986483d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24625063681860193d, b: 0.2184421524886846d, c: 0.34976209097390953d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9435960566325654d, b: 0.10096201365543789d, c: 0.8334175103185852d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8188079166360126d, b: 0.017752582150156182d, c: 0.8601818255342392d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7276872621078171d, b: 0.7686152993518613d, c: 0.6705132494926641d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4808272421583334d, b: 0.7431553268010578d, c: 0.6351999322957497d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3303593064078013d, b: 0.07272483461247914d, c: 0.8319341282645337d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9107015248969303d, b: 0.7476809047811984d, c: 0.3598429930864375d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7719769381017632d, b: 0.4541117849086679d, c: 0.9506110866686601d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12857895809613384d, b: 0.9200575297708038d, c: 0.5583477885895266d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3269389393180806d, b: 0.9247123858760264d, c: 0.07065022276083288d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.47653193353129664d, b: 0.8625741672516366d, c: 0.16822757212348094d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.38332738782472275d, b: 0.2056471730253967d, c: 0.6089791584954823d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6505734063978977d, b: 0.14524285522409475d, c: 0.08497555022056225d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1423583548566183d, b: 0.8524233160594051d, c: 0.4994883737146194d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2316092642705624d, b: 0.22948720295874248d, c: 0.08504849485397625d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09190434957476523d, b: 0.7777165240688021d, c: 0.9204980749785683d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9188712328322712d, b: 0.9798298911903467d, c: 0.9690032453868733d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3994687223776736d, b: 0.2897663112346349d, c: 0.16541686784046017d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5248672386652216d, b: 0.7864391064854557d, c: 0.5852692916045283d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.80220132142867d, b: 0.929462085731671d, c: 0.8439701162251887d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9845537661949065d, b: 0.6084383163957743d, c: 0.5398887878451889d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8962975525333662d, b: 0.621594063414007d, c: 0.7940909231626118d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8002760330563439d, b: 0.6790038990190186d, c: 0.8375267535856071d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4331284064411104d, b: 0.6539825084983629d, c: 0.00798472535114747d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.00923083309851791d, b: 0.3835519718246607d, c: 0.030304758888862193d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.08376788125427681d, b: 0.7524243865926888d, c: 0.11138880661363881d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2937454957486847d, b: 0.8886835597294448d, c: 0.9053358639474719d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8041589649350663d, b: 0.20093963025210515d, c: 0.19566740581740705d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8922632827942678d, b: 0.5153919031788047d, c: 0.859211920658587d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7669013204428158d, b: 0.9527149158018738d, c: 0.8933283358379628d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.07615186907528648d, b: 0.8616093450149542d, c: 0.7846341736823647d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33997490374187966d, b: 0.2565204623431099d, c: 0.24570931078963576d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8163860641053444d, b: 0.5156687801696106d, c: 0.11618109548588995d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8011588881052847d, b: 0.0808406228772145d, c: 0.8181512624830581d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8260211344257687d, b: 0.8250692017168565d, c: 0.2653389773108912d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.43387015807680007d, b: 0.7305759673718307d, c: 0.29143973485339947d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.997826051564723d, b: 0.7636239090105578d, c: 0.8602759008337398d))));

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
                for (int i = 0; i < 4; i++)
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
value,
nullablevalue
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

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 4; i < 8; i++)
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
value,
nullablevalue
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MI>(2);
                for (int i = 8; i < 12; i++)
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

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLineline0MI>(2);
                for (int i = 12; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(15));
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(6)]
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

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlLineSingleTypeline)this).ExportModelInner(connection).ToList();
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

