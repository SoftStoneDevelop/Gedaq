

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
    internal partial interface IInt64MArraybigintMMArrayD2
    {
    }
    
    internal partial class Int64MArraybigintMMArrayD2 : IInt64MArraybigintMMArrayD2
    {


#region TestData

        private readonly Int64bigintMMArrayD2E1M[] _testData = new Int64bigintMMArrayD2E1M[]
        {
            new Int64bigintMMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Int64[,] { { 2235074298229216928L, 4668648180059614811L, }, { 6288961677527291057L, 5680617980433780038L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 10,
    Value = 
new System.Int64[,] { { 1890561045909463760L, 6651651347481087048L, }, { 1784395992895995078L, 5325096573010822856L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 4,
    Value = 
new System.Int64[,] { { 7718632502577235784L, 2549861586302579412L, }, { 329018151689348553L, 3586321759531219667L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 8291462350687123480L, 5762175034413290521L, }, { 2429450682346015160L, 7778987864764562631L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 15,
    Value = 
new System.Int64[,] { { 5763098910246705275L, 6772450575345802641L, }, { 6066911983680470909L, 4189739634170884814L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Int64[,] { { 3589607035839258264L, 764082521290491989L, }, { 8964419715263358405L, 8131845554169051026L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Int64[,] { { 10219751008472903L, 7025048725211557930L, }, { 33831506694188522L, 2943314973377475783L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 4840127113419638785L, 6699573655181072914L, }, { 1905956276076312149L, 445502825624091167L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Int64[,] { { 454053654264681702L, 6880016599319366698L, }, { 9039292056708445669L, 4221430898108684090L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 2498520143408188595L, 7008788964532686922L, }, { 6541997586781073334L, 7623017654749080668L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 26,
    Value = 
new System.Int64[,] { { 4360881153934608345L, 4147373219475521189L, }, { 1816958252415182278L, 259634905422661977L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Int64[,] { { 8790125232692913303L, 1339087117796042046L, }, { 4874435213795851104L, 2159001380968319019L, }, },
    NullableValue = 
new System.Int64[,] { { 1637518697759558243L, 8421242913617236408L, }, { 8129876017033195433L, 628995206666303179L, }, },
},
    NullableValue = 
new System.Int64[,] { { 3825695579281938355L, 4188789812416247506L, }, { 7581104469765571565L, 4724429986458586452L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Int64[,] { { 3103250487802718803L, 4367311559333012760L, }, { 6360913356453288101L, 3847484658245704073L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 5164529090046232864L, 7980106278251135278L, }, { 8707198646345879443L, 2148636559357435694L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 29,
    Value = 
new System.Int64[,] { { 7997203810207319386L, 727169518599896669L, }, { 6083714494169735085L, 4119949477831136840L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Int64[,] { { 8666220388895418172L, 1564088008518848797L, }, { 978316112978311921L, 7153503180633833220L, }, },
    NullableValue = 
new System.Int64[,] { { 4315556477207453565L, 6990828118393074819L, }, { 1071650883587557048L, 6245816774050994088L, }, },
},
    NullableValue = 
new System.Int64[,] { { 124641166945820976L, 189607785976092229L, }, { 7387116055146402943L, 572566840312720110L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Int64[,] { { 7811933980487674800L, 4713109711729121400L, }, { 618526908909885460L, 4278323202341425725L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 3324386413875648716L, 8945670951500101501L, }, { 7917898944294452466L, 97455131331183495L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 42,
    Value = 
new System.Int64[,] { { 6271752267170817862L, 6182726278821341449L, }, { 7795429062450289749L, 6625676900331832277L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Int64[,] { { 1105412914322962353L, 6009909033038654649L, }, { 7943919939833707854L, 2152206662662861305L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6780540853779182453L, 276158526352252524L, }, { 8457016020077273858L, 4994343351090825373L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 51,
    Value = 
new System.Int64[,] { { 6306509771670641205L, 5180335252560046327L, }, { 6390313419864339802L, 6291773752118502520L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 1234415816071710432L, 3483391649640484113L, }, { 5650974232828906351L, 3549179297305015262L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Int64[,] { { 8969195280615975715L, 6244505573143391807L, }, { 1555484178143784691L, 736778015114407161L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Int64[,] { { 1177632212088235833L, 1407583893943952355L, }, { 1992780087903083009L, 2521775211870396359L, }, },
    NullableValue = 
new System.Int64[,] { { 7219635391746178161L, 585463250997035358L, }, { 91248526543895204L, 7709873665884099568L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 64,
    Value = 
new System.Int64[,] { { 8261038408569369065L, 4829279595004306624L, }, { 9093288211328724253L, 9072650378511222872L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 5190679118874076328L, 2101103765500093404L, }, { 5788991962012313822L, 153752074194029777L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Int64[,] { { 4233603322216718464L, 7786022643394941962L, }, { 8106000316944018979L, 5880338549699063965L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Int64[,] { { 4453652556095412526L, 5881381234501345074L, }, { 5528163291791897545L, 3830654506543510617L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 1315176573501040580L, 6671901451668894782L, }, { 2300715105892818858L, 8316170853369677972L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 71,
    Value = 
new System.Int64[,] { { 896467775849054410L, 6200385387609281307L, }, { 5745610036022569555L, 7513224981339427516L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 75,
    Value = 
new System.Int64[,] { { 6195280237070765947L, 9078332292326022003L, }, { 5319475094372923790L, 1106722839750308686L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Int64[,] { { 8398547206189603632L, 937080341207524034L, }, { 841927568561933035L, 4401560290583064611L, }, },
    NullableValue = 
new System.Int64[,] { { 5235178346939978811L, 828325657689045577L, }, { 9181922050111507059L, 3946419485600970011L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 82,
    Value = 
new System.Int64[,] { { 9189049231820081269L, 4611752538961613011L, }, { 8845398701901210755L, 5172729243955397010L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Int64[,] { { 6518340795434683188L, 1761904410809792208L, }, { 4364630639682281142L, 2650940016054836754L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Int64[,] { { 3856701971830135548L, 736509545991340104L, }, { 6275195970729880175L, 8007505780027189700L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Int64[,] { { 4474941974699968605L, 897562208607518140L, }, { 3419798911939062269L, 58352983588926080L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Int64[,] { { 5707158237147095100L, 151414614710057367L, }, { 2269144136027172920L, 8672247980368476557L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Int64[,] { { 9082074036195545062L, 797582921192905439L, }, { 8959396382216227879L, 8565764359725038700L, }, },
    NullableValue = 
new System.Int64[,] { { 7385812799155785778L, 7285436617134698638L, }, { 6819320131741068562L, 3960212057691274642L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2826356085770321657L, 681253173478910910L, }, { 3841327274561804248L, 6798543633394959L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 106,
    Value = 
new System.Int64[,] { { 7312455861489690039L, 3547881236000993655L, }, { 5099252686773441883L, 4689593030695225855L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 5303091842888129592L, 99772042957536007L, }, { 9217621009080676967L, 4044843974505491701L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Int64[,] { { 632254364539208590L, 3346134827317167940L, }, { 4733396060581144596L, 2699937748323964659L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Int64[,] { { 3496415372369213000L, 3471017460428535989L, }, { 7971099213263538638L, 7928821489297293575L, }, },
    NullableValue = 
new System.Int64[,] { { 5670042851437179214L, 3908287421588515335L, }, { 3294372589185251467L, 4190042430882604009L, }, },
},
    NullableValue = 
new System.Int64[,] { { 6983652848911864405L, 9003905452666030434L, }, { 7317085044425652143L, 206240760592306771L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Int64[,] { { 2900041096783457377L, 1979694174652828608L, }, { 8168078969630692033L, 7658663971060909995L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 114,
    Value = 
new System.Int64[,] { { 8769485726203432989L, 7340249763002543905L, }, { 2840687316790024483L, 5668922244131010597L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Int64[,] { { 955052900800578622L, 6600516041947100542L, }, { 2288219776455447930L, 8092347794309831761L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 118,
    Value = 
new System.Int64[,] { { 5121662657476949008L, 1664260626879800669L, }, { 7168377900265971909L, 251134930856160663L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 4919009671298611552L, 4721054058598005584L, }, { 6097901631082157084L, 4483081382897202688L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Int64[,] { { 7328898566355820421L, 3204270432792665890L, }, { 3204949746955627283L, 1358350130397753526L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 72,
    Value = 
new System.Int64[,] { { 6779873875367282701L, 6848007605485801230L, }, { 6810222038122713003L, 1414604725018109806L, }, },
    NullableValue = 
new System.Int64[,] { { 4571299043353635042L, 1950528155468786724L, }, { 2473269924973715940L, 4269259613029722230L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2817172944549987282L, 5791599109664242438L, }, { 932341529150507341L, 3120226319525910666L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 131,
    Value = 
new System.Int64[,] { { 6321033787265419011L, 7151274053264224947L, }, { 1325670859425554629L, 4458413548508830454L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 136,
    Value = 
new System.Int64[,] { { 5329563261402574388L, 6690737582561342436L, }, { 3235911538481878551L, 2010742429342738719L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.Int64[,] { { 3566475306016601497L, 2106369909724647470L, }, { 4189028035810662685L, 9112473691410725557L, }, },
    NullableValue = 
new System.Int64[,] { { 5987427830910453496L, 2212574610284905268L, }, { 4926100204488837434L, 3839824814558067606L, }, },
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Int64[,] { { 6159589154310281088L, 758916204064497051L, }, { 6980827029425986979L, 5417953438589352195L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 148,
    Value = 
new System.Int64[,] { { 5816378983872681039L, 740833698413954563L, }, { 4279970908563252068L, 4410149532972336484L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 80,
    Value = 
new System.Int64[,] { { 3099461068246057504L, 6710771244526039058L, }, { 1271620506043672115L, 4074435812431682125L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Int64[,] { { 3183533130778036376L, 4298204474321978833L, }, { 7266323034432518917L, 7210357856624847867L, }, },
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 156,
    Value = 
new System.Int64[,] { { 7450979177336509038L, 3141394113819214364L, }, { 7280143401296628732L, 8719982125386905422L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Int64[,] { { 8692569611462909709L, 4353047842385276762L, }, { 1626824706089345872L, 3464230276002788177L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD2E1M
{
    Id = 159,
    Value = 
new System.Int64[,] { { 2033949373539373054L, 1497471614527394553L, }, { 686272761443839516L, 7975322932034963947L, }, },
    ModelInner = null,
    NullableValue = 
new System.Int64[,] { { 2449488931013605439L, 5192716159353108247L, }, { 157287276847216698L, 3924422191433907427L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 168,
    Value = 
new System.Int64[,] { { 587586329643352546L, 5896609700943913342L, }, { 3091093321777123609L, 5857289020798856322L, }, },
    ModelInner = new Int64bigintMMArrayD2E1MI
{
    Id = 88,
    Value = 
new System.Int64[,] { { 8699672836490266694L, 4364474282127010309L, }, { 245589284736829464L, 6215058404106518855L, }, },
    NullableValue = 
new System.Int64[,] { { 4610989073323749046L, 786911779816822873L, }, { 3072934918180223766L, 528433197754113168L, }, },
},
    NullableValue = 
new System.Int64[,] { { 3407256404433784583L, 554660897934477819L, }, { 5963336790257112541L, 6965454314187197870L, }, },
},
            new Int64bigintMMArrayD2E1M
{
    Id = 172,
    Value = 
new System.Int64[,] { { 8624233297221838077L, 108730247862466101L, }, { 8801578910966758618L, 8007299939488000355L, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1mi(
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1mi(
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
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
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

                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd2e1mi_id
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintmmarrayd2e1mi_id", 
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
                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64MArraybigintMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64MArraybigintMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd2e1mi_id
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
    int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                System.Int64[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 2498520143408188595L, 7008788964532686922L, }, { 6541997586781073334L, 7623017654749080668L, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 3825695579281938355L, 4188789812416247506L, }, { 7581104469765571565L, 4724429986458586452L, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 5164529090046232864L, 7980106278251135278L, }, { 8707198646345879443L, 2148636559357435694L, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[,]>();
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 124641166945820976L, 189607785976092229L, }, { 7387116055146402943L, 572566840312720110L, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd2e1mi_id
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
    int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintmmarrayd2e1mi_id", 
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
                System.Int64[,] nullable = null;
                nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 3324386413875648716L, 8945670951500101501L, }, { 7917898944294452466L, 97455131331183495L, }, }));
                nullable =  ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 6780540853779182453L, 276158526352252524L, }, { 8457016020077273858L, 4994343351090825373L, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[,] nullable = null;
                nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[,] { { 1234415816071710432L, 3483391649640484113L, }, { 5650974232828906351L, 3549179297305015262L, }, }));
                nullable = await ((IInt64MArraybigintMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD2E1M> models = null;

                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64MArraybigintMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD2E1M> models = null;

                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64MArraybigintMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 122;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M), typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 9, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 156, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD2E1M>();
                ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 150, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 42, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 136, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                await ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 15, query1, 29, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 82, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
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
FROM public.int64bigintmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD2E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD2E1M>();
                 ((IInt64MArraybigintMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 25, query1, 82, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt64bigintMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.int64bigintmmarrayd2e1m m
LEFT JOIN public.int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
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
                var models = await((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 19, 29))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 10, 122))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((IInt64MArraybigintMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64MArraybigintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 148);
                var models = await ((IInt64MArraybigintMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64MArraybigintMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64MArraybigintMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 71);
                var models =  ((IInt64MArraybigintMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                Int64bigintMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                Int64bigintMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
FROM public.binary_int64bigintmmarrayd2e1m m
LEFT JOIN public.binary_int64bigintmmarrayd2e1mi mi ON mi.id = m.int64bigintmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models =  ((IInt64MArraybigintMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64MArraybigintMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA), typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
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
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
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
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA), typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                await ((IInt64MArraybigintMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                ((IInt64MArraybigintMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
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
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd2e1mi
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
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI), typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models1 = new List<Int64bigintMMArrayD2E1MI>();
                var models2 = new List<Int64bigintMMArrayD2E1MI>();
                await ((IInt64MArraybigintMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD2E1MI>();
                var models2 = new List<Int64bigintMMArrayD2E1MI>();
                ((IInt64MArraybigintMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA), typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                await ((IInt64MArraybigintMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD2E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD2E1MIWA>();
                ((IInt64MArraybigintMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD2))]
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
                var models = await ((IInt64MArraybigintMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

