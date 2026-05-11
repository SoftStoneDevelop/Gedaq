

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
    internal partial interface IInt64MArraybigintMMArrayD1
    {
    }
    
    internal partial class Int64MArraybigintMMArrayD1 : IInt64MArraybigintMMArrayD1
    {


#region TestData

        private readonly Int64bigintMMArrayD1E1M[] _testData = new Int64bigintMMArrayD1E1M[]
        {
            new Int64bigintMMArrayD1E1M
{
    Id = 5,
    Value = 
new System.Int64[3]
{
7139034031069481042L,
5035183436226349775L,
6350006377606452010L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 7,
    Value = 
new System.Int64[3]
{
6107745693447957082L,
4634339455868779930L,
4031500219699288917L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 1,
    Value = 
new System.Int64[4]
{
6744104496760934897L,
7939802423513672990L,
5168660549789561286L,
5522154986988609775L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
8200416932938654229L,
7137409871294271495L,
3483663400121443275L,
1514906510084679465L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Int64[4]
{
5410474146436803258L,
7475288342291706491L,
2422467982025209550L,
4559080479364525472L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
8004177496180878436L,
7444468502176558995L,
1463766415006623321L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Int64[4]
{
5425270242570624008L,
8713397684548166422L,
333295952422609864L,
3767604458597880129L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 2,
    Value = 
new System.Int64[4]
{
4275972669954199033L,
4884525479760109837L,
5193971428790285495L,
1863391439207339714L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Int64[3]
{
2099454722164583497L,
4979372934747444723L,
5548729002463330594L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4469825310901068005L,
8078994602599636715L,
6082284217751800682L,
8555300713221936988L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Int64[4]
{
644789425745915595L,
9021622358275972628L,
5018836270955429543L,
4815108953620986819L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Int64[4]
{
3666434150119904092L,
4179542747412475860L,
8735821825635551479L,
6136077777253882624L,
},
    NullableValue = 
new System.Int64[4]
{
8403033964109807678L,
6867985531913181763L,
6507810233138816695L,
6131710928782163623L,
},
},
    NullableValue = 
new System.Int64[3]
{
2769563109519862208L,
4750507979901162608L,
3370946605628849208L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Int64[3]
{
5380976196601584367L,
8255611783314316664L,
6038189648429235186L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Int64[4]
{
6321829986335756627L,
6622902557945266996L,
5125269154129836665L,
2358231884093743107L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Int64[3]
{
5255871500711665354L,
8164371068753922972L,
8749657006623413568L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Int64[4]
{
9104485761181734539L,
8056840653122198996L,
2358817017253074809L,
3937409737266399202L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
3530328973312015682L,
6408820127653681240L,
210236003048984323L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Int64[3]
{
6071225523173669344L,
4465730396209348326L,
4689709931179208416L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Int64[4]
{
5310358026252381473L,
5884118231247853955L,
2334006427709795290L,
4937789927155877779L,
},
    NullableValue = 
new System.Int64[3]
{
6010798401230619083L,
8998499944075824664L,
8136097945354322694L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Int64[3]
{
650668483799706643L,
9080665593379595286L,
1909017708002542510L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Int64[4]
{
6754969868118227609L,
6321250007996357901L,
6963810409931307123L,
8480887759616586882L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Int64[4]
{
2802149381613640091L,
3544821028083478833L,
330999579278842118L,
4656401357700989107L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
3589580605914474182L,
4927522255978662419L,
1728299284402946912L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 62,
    Value = 
new System.Int64[4]
{
7972094939574410021L,
324402072388612724L,
3007250458446446209L,
4782907496455079818L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
176008797558415022L,
7583811611853579611L,
8252590193253719535L,
6905978762842732264L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Int64[3]
{
2575531827434198877L,
8171021170142849933L,
5773318701220345306L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.Int64[4]
{
1113375913689831295L,
2187823641670283916L,
791791463958268242L,
5287051112752467627L,
},
    NullableValue = 
new System.Int64[4]
{
3267633391163380554L,
9098221297668543415L,
636700673024539148L,
744333696760957660L,
},
},
    NullableValue = 
new System.Int64[3]
{
6286000697411506402L,
1253890734394955824L,
6421311784987078464L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Int64[4]
{
4677076837626741259L,
2467988989080313768L,
6378288216697435760L,
4379847030386275612L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Int64[3]
{
2414260167558999040L,
8988973235628301256L,
5016767590464483444L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 42,
    Value = 
new System.Int64[4]
{
3611396242012002561L,
6841042399752092070L,
7822998170758610197L,
7795733518421038216L,
},
    NullableValue = 
new System.Int64[3]
{
3262472053559334075L,
7169249537033795834L,
3640683851731418555L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Int64[4]
{
1524972037435724320L,
1872945100747722336L,
9215816798688561268L,
3422427624018775732L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
6830870506092275446L,
2322838131417612424L,
4952432885150077394L,
2544920482961538548L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 85,
    Value = 
new System.Int64[3]
{
1226833157502527680L,
908727815736531721L,
1326306088307513352L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Int64[4]
{
7121278118216489768L,
4706952495659319736L,
5379101228781895585L,
3803335358183740349L,
},
    NullableValue = 
new System.Int64[3]
{
3358454065825257766L,
7189180333029956545L,
167026376925060651L,
},
},
    NullableValue = 
new System.Int64[4]
{
7966898942777539856L,
3713298976802094445L,
1844506383410739933L,
4872455971686087163L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Int64[4]
{
5657916102984480072L,
4277259209768387819L,
1862195085973913042L,
7833269837653664521L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4970027050997830703L,
3943472913868053923L,
4222798101465353211L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Int64[4]
{
5316438284833550289L,
966683095485377988L,
8767678472307409703L,
6193474009588492635L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Int64[3]
{
2306883812288360003L,
7564131930027224245L,
2183863487036384370L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 100,
    Value = 
new System.Int64[3]
{
3684388865749236630L,
2509598655795179232L,
1195063086398851069L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
8158199807831940891L,
3045921059838147494L,
3559790184588812668L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Int64[3]
{
8454745615547690647L,
9114071587461419048L,
4439556970770546275L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Int64[3]
{
3802938320868647937L,
2638422373222356405L,
1390151206138655575L,
},
    NullableValue = 
new System.Int64[3]
{
5299140946971175852L,
8551751646621475310L,
6232034753003095425L,
},
},
    NullableValue = 
new System.Int64[3]
{
8880924351849586974L,
2796063327092065316L,
2488813079204029554L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Int64[4]
{
5726320167327210144L,
8138741810982301853L,
8432734297984641741L,
6741130892673752870L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 113,
    Value = 
new System.Int64[4]
{
6326099253443656111L,
7218092223128458182L,
3445015614277948852L,
3506521337709983698L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Int64[4]
{
1270560697939513635L,
480564465160866549L,
5657225940118120399L,
5647256380869952029L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Int64[4]
{
5463040066479345928L,
2785774982091409515L,
4352188168162595554L,
457876176124092770L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
8387924666084449827L,
7908629745588944217L,
1388821741401696148L,
1618137903602747975L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Int64[4]
{
106398146785602444L,
6019151820983813527L,
8363867800412442653L,
1484194045111758090L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 66,
    Value = 
new System.Int64[4]
{
5581072572384842413L,
7572317250299874270L,
7329619690367940860L,
7625884523905777183L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Int64[4]
{
254825749808550632L,
4976863980103919251L,
8393787247357277436L,
2090698451674393182L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 131,
    Value = 
new System.Int64[3]
{
5670993378571978499L,
9110882899785277286L,
4545568003157392766L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Int64[3]
{
4238921573567751960L,
8254892093334342308L,
8280828510294281754L,
},
    NullableValue = 
new System.Int64[3]
{
9138742744812340508L,
7163265442049228316L,
6677063642529628354L,
},
},
    NullableValue = 
new System.Int64[4]
{
5536487802806630710L,
885275753097740720L,
1078296796679877885L,
6589603366330960834L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Int64[3]
{
6978088621996592120L,
1465661627186379082L,
524981169602299147L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
5122933331689522901L,
4212960974121242113L,
2989885671446972241L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Int64[4]
{
6795548739574649945L,
6115760111775469203L,
9076269928346258096L,
5066759276131754587L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Int64[3]
{
5263165401437538806L,
3772921900050063078L,
3562742633934362161L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Int64[4]
{
7826590988247853507L,
6604041974182472522L,
8969079105847320150L,
2482233912741192255L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Int64[4]
{
3808482491187687448L,
1822379863663017357L,
3336544624266222583L,
2216965239159512328L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Int64[4]
{
6230620667561495259L,
7426658164007028370L,
2877764171238141922L,
8796683606726856349L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
2115452752565308345L,
4009331892553257873L,
3618261352915101485L,
716219427543941813L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 155,
    Value = 
new System.Int64[4]
{
326821619776077744L,
6262450047552722455L,
2381079133903997431L,
4148050881715835800L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Int64[3]
{
7660052509264000180L,
9159220847537206903L,
9009589349031302407L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.Int64[3]
{
5355843283812438904L,
2447297115413974265L,
974258297259279781L,
},
    NullableValue = 
new System.Int64[3]
{
1611452425203605641L,
8596249080855558417L,
3862092159564381836L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 164,
    Value = 
new System.Int64[4]
{
1758602485791641498L,
5913581913768704367L,
360644023059429236L,
7917008836822403527L,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1mi(
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1mi(
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
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
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

                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd1e1mi_id
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintmmarrayd1e1mi_id", 
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
                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd1e1mi_id
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
    int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
4469825310901068005L,
8078994602599636715L,
6082284217751800682L,
8555300713221936988L,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
2769563109519862208L,
4750507979901162608L,
3370946605628849208L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd1e1mi_id
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
    int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintmmarrayd1e1mi_id", 
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
                System.Int64[] nullable = null;
                nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
3530328973312015682L,
6408820127653681240L,
210236003048984323L,
}));
                nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
3589580605914474182L,
4927522255978662419L,
1728299284402946912L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD1E1M> models = null;

                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD1E1M> models = null;

                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 141;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 78, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 116, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 78, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 122, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 32, query1, 95, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 141, query1, 71, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 28, query1, 129, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 35, query1, 83, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 62, 19))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 34, 122))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((IInt64MArraybigintMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64MArraybigintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 5);
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64MArraybigintMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64MArraybigintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 83);
                var models =  ((IInt64MArraybigintMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MI),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintMMArrayD1E1M),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
FROM public.binary_int64bigintmmarrayd1e1m m
LEFT JOIN public.binary_int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models =  ((IInt64MArraybigintMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA), typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA), typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI), typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models1 = new List<Int64bigintMMArrayD1E1MI>();
                var models2 = new List<Int64bigintMMArrayD1E1MI>();
                await ((IInt64MArraybigintMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MI>();
                var models2 = new List<Int64bigintMMArrayD1E1MI>();
                ((IInt64MArraybigintMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA), typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                await ((IInt64MArraybigintMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                ((IInt64MArraybigintMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

