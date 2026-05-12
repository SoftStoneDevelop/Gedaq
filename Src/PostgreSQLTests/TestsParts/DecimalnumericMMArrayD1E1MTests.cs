

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
    internal partial interface IDecimalMArraynumericMMArrayD1
    {
    }
    
    internal partial class DecimalMArraynumericMMArrayD1 : IDecimalMArraynumericMMArrayD1
    {


#region TestData

        private readonly DecimalnumericMMArrayD1E1M[] _testData = new DecimalnumericMMArrayD1E1M[]
        {
            new DecimalnumericMMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Decimal[3]
{
0.91594992657782m,
0.0417121697343356m,
0.714719302512787m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 11,
    Value = 
new System.Decimal[4]
{
0.274523379719071m,
0.949100298757249m,
0.929563064665531m,
0.74850695935798m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 5,
    Value = 
new System.Decimal[3]
{
0.83835464283234m,
0.213520399876276m,
0.379643794504705m,
},
    NullableValue = 
new System.Decimal[4]
{
0.168730496477256m,
0.813233096489426m,
0.243877676934272m,
0.49102641306468m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.75694124550553m,
0.906976130845626m,
0.32992330565202m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 16,
    Value = 
new System.Decimal[4]
{
0.739131432704611m,
0.150488194679027m,
0.93302322910338m,
0.20871859062993m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.804347674582264m,
0.211426802898744m,
0.972312980900639m,
0.0731197731672954m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Decimal[4]
{
0.78404566975323m,
0.986560169886763m,
0.861364702600248m,
0.467548977575692m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Decimal[3]
{
0.890999622348405m,
0.283880263186698m,
0.853748613847543m,
},
    NullableValue = 
new System.Decimal[4]
{
0.157896123175385m,
0.324894022104146m,
0.733590769953725m,
0.307018217886053m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.043178755981312m,
0.266906797938354m,
0.285265583844918m,
0.0461715247888244m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 24,
    Value = 
new System.Decimal[4]
{
0.777474570501709m,
0.721943804768411m,
0.397755335493284m,
0.816240676502491m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 27,
    Value = 
new System.Decimal[4]
{
0.241720129171592m,
0.265741439833732m,
0.382568725240014m,
0.8700299021991m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Decimal[4]
{
0.458247916184384m,
0.452899093044578m,
0.0537358810963083m,
0.62378624386738m,
},
    NullableValue = 
new System.Decimal[3]
{
0.307332526141581m,
0.613712223450508m,
0.862570127030955m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.45838867051292m,
0.0896507472415671m,
0.699250833819591m,
0.263774046740878m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 33,
    Value = 
new System.Decimal[3]
{
0.320554061909284m,
0.977380461817833m,
0.0554929885969718m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.618791195786615m,
0.138450358793386m,
0.722090377403346m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 39,
    Value = 
new System.Decimal[4]
{
0.656471629930732m,
0.800357540803706m,
0.280736631280311m,
0.998713711607474m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Decimal[3]
{
0.0158582919880927m,
0.447311162076522m,
0.430279032020995m,
},
    NullableValue = 
new System.Decimal[3]
{
0.848775783701039m,
0.695526234868878m,
0.0185373891011728m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 41,
    Value = 
new System.Decimal[4]
{
0.876598111895382m,
0.86693705596804m,
0.800241868145528m,
0.118719094228931m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Decimal[3]
{
0.964901139904416m,
0.948182769394701m,
0.77422428355844m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Decimal[3]
{
0.356002821396452m,
0.351218716255557m,
0.721072674750584m,
},
    NullableValue = 
new System.Decimal[4]
{
0.310059532181279m,
0.384090061116868m,
0.546473510358254m,
0.325028581301858m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.814388953816077m,
0.299537453751877m,
0.160958251816115m,
0.517391785787062m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Decimal[3]
{
0.213117517175191m,
0.252169409106957m,
0.426064153079161m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.691655658448643m,
0.801758805953178m,
0.66216333844588m,
0.257870672493013m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Decimal[4]
{
0.94830149446077m,
0.703686517171866m,
0.00458843773043738m,
0.736070532091329m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 39,
    Value = 
new System.Decimal[3]
{
0.976714321057985m,
0.867866802130679m,
0.0889779487721652m,
},
    NullableValue = 
new System.Decimal[3]
{
0.692966437926598m,
0.715211563318706m,
0.102423719431359m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 51,
    Value = 
new System.Decimal[4]
{
0.937078861133585m,
0.693984591366752m,
0.785220135855178m,
0.900699841246744m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.698913609582175m,
0.491469495326521m,
0.483493073153814m,
0.608971478797547m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Decimal[3]
{
0.404960692114126m,
0.0639171281827271m,
0.146212417400109m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Decimal[3]
{
0.873549828342521m,
0.292408104734646m,
0.247317546764153m,
},
    NullableValue = 
new System.Decimal[4]
{
0.468679130161198m,
0.382726547953237m,
0.827767264812466m,
0.22438042266255m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Decimal[4]
{
0.987468676038826m,
0.00202910247101351m,
0.657742730122319m,
0.415003224063924m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 69,
    Value = 
new System.Decimal[3]
{
0.110214552970882m,
0.21953813863143m,
0.209339773618093m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Decimal[3]
{
0.315150357380044m,
0.617940309742291m,
0.039303550370834m,
},
    NullableValue = 
new System.Decimal[4]
{
0.246650147477028m,
0.502398032387086m,
0.162503237977458m,
0.42618506245157m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.0350295938781032m,
0.793304581784862m,
0.834087268399304m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Decimal[4]
{
0.567141651680612m,
0.39675288806546m,
0.898734226628138m,
0.44949571597068m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 77,
    Value = 
new System.Decimal[3]
{
0.426355762201472m,
0.0365933372268745m,
0.217567545693982m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Decimal[4]
{
0.212127014708998m,
0.563328490407527m,
0.279014486929539m,
0.690295977281942m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.965342934090286m,
0.877524513278256m,
0.226745891315793m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 86,
    Value = 
new System.Decimal[4]
{
0.921176933110227m,
0.661253022887457m,
0.190689578779514m,
0.0826029766976494m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.362205975353243m,
0.694663301351434m,
0.978297232031152m,
0.0398496820414116m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Decimal[4]
{
0.457442138212663m,
0.518971917229495m,
0.822013933583398m,
0.847464177953603m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Decimal[4]
{
0.838863945815098m,
0.934830190178698m,
0.916937526235298m,
0.957815316034572m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Decimal[4]
{
0.187160827132083m,
0.427481012999214m,
0.0698932948683535m,
0.395326336353348m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 107,
    Value = 
new System.Decimal[3]
{
0.505608896828131m,
0.0621394026001717m,
0.781231796070256m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Decimal[3]
{
0.111760391286722m,
0.016922325190576m,
0.8961728335864m,
},
    NullableValue = 
new System.Decimal[4]
{
0.140445887712871m,
0.896066025890683m,
0.641186875267192m,
0.0269715548997813m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Decimal[4]
{
0.798122742271674m,
0.242271147001207m,
0.0452840763782513m,
0.729003682261901m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.430145607706532m,
0.79477353427377m,
0.329303087622901m,
0.896395101069188m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Decimal[3]
{
0.0390041402063432m,
0.192998390405052m,
0.620831515388966m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Decimal[4]
{
0.66588034618614m,
0.0280981132218577m,
0.692733015778844m,
0.239792295942073m,
},
    NullableValue = 
new System.Decimal[3]
{
0.0752639574640831m,
0.0530726128182601m,
0.430081969808607m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.951455258815889m,
0.232440929704687m,
0.734180124488264m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Decimal[3]
{
0.935918839443598m,
0.772256954346977m,
0.653196149047176m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Decimal[4]
{
0.456132963330557m,
0.202191408003388m,
0.414782741042314m,
0.505764559618679m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Decimal[3]
{
0.489724772725522m,
0.378818830275587m,
0.0976972446467804m,
},
    NullableValue = 
new System.Decimal[3]
{
0.192266375774351m,
0.714346207640587m,
0.505533131121047m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.907160267608582m,
0.260718735135283m,
0.605711654688058m,
0.589976577890211m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Decimal[4]
{
0.497423989254262m,
0.525173462018311m,
0.723206578527292m,
0.0198405346202881m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Decimal[3]
{
0.460672736085373m,
0.0681438213500859m,
0.368472992490283m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Decimal[3]
{
0.523222838608556m,
0.448220746023236m,
0.247924960435922m,
},
    NullableValue = 
new System.Decimal[4]
{
0.703973822103044m,
0.369464339454502m,
0.189012429167346m,
0.171860033756976m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 152,
    Value = 
new System.Decimal[4]
{
0.221107565928054m,
0.313789863668159m,
0.843801336964788m,
0.395658877198013m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 155,
    Value = 
new System.Decimal[4]
{
0.229793700000449m,
0.287695686044946m,
0.358667116956133m,
0.439691691002293m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Decimal[4]
{
0.424412302615547m,
0.542049414309972m,
0.551510349254017m,
0.863933004692589m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 164,
    Value = 
new System.Decimal[4]
{
0.55222615555403m,
0.149641624767794m,
0.617804656734621m,
0.699858322083249m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.852867176591921m,
0.725055204530346m,
0.463685932869045m,
0.609009005698348m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Decimal[4]
{
0.795735937016067m,
0.925865223812032m,
0.45413538808709m,
0.110881969030119m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 88,
    Value = 
new System.Decimal[4]
{
0.743520464882016m,
0.825220064282076m,
0.301610837940549m,
0.878381319168608m,
},
    NullableValue = 
new System.Decimal[4]
{
0.393063328359808m,
0.726170094180282m,
0.40449617194529m,
0.643938082753581m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.267916299174331m,
0.719320340790134m,
0.136327221525132m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 178,
    Value = 
new System.Decimal[4]
{
0.616197653429963m,
0.246956333139178m,
0.711451290115177m,
0.568025861717434m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.814950718991466m,
0.22153628105421m,
0.790716147938573m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 186,
    Value = 
new System.Decimal[3]
{
0.328548262189908m,
0.442660738120499m,
0.886119811274375m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 96,
    Value = 
new System.Decimal[4]
{
0.172894432754605m,
0.608131237790056m,
0.53514979403524m,
0.112828733267457m,
},
    NullableValue = 
new System.Decimal[3]
{
0.203456413990711m,
0.51105701892118m,
0.700538786254043m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 189,
    Value = 
new System.Decimal[3]
{
0.192162088011071m,
0.544751333620044m,
0.409173226987402m,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1mi(
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1mi(
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
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericmmarrayd1e1mi_id", 
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
                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.45838867051292m,
0.0896507472415671m,
0.699250833819591m,
0.263774046740878m,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.618791195786615m,
0.138450358793386m,
0.722090377403346m,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericmmarrayd1e1mi_id", 
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
                System.Decimal[] nullable = null;
                nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.814388953816077m,
0.299537453751877m,
0.160958251816115m,
0.517391785787062m,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.691655658448643m,
0.801758805953178m,
0.66216333844588m,
0.257870672493013m,
}));
                nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD1E1M> models = null;

                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD1E1M> models = null;

                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 39;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 51;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 75, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 152, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 164, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 91, query1, 178, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 39, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 120, query1, 66, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 120, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 155, query1, 178, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 86, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 45, 27))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
                await using var cmd = await ((IDecimalMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models =  ((IDecimalMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
FROM public.binary_decimalnumericmmarrayd1e1m m
LEFT JOIN public.binary_decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models =  ((IDecimalMArraynumericMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI), typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericMMArrayD1E1MI>();
                var models2 = new List<DecimalnumericMMArrayD1E1MI>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MI>();
                var models2 = new List<DecimalnumericMMArrayD1E1MI>();
                ((IDecimalMArraynumericMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

