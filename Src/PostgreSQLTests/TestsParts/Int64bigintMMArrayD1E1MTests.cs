

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
    Id = 4,
    Value = 
new System.Int64[3]
{
2698687986773249174L,
7999498661099680724L,
8833593191579882800L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
7438075676482757069L,
2063964142226077943L,
6540844546610257299L,
1818598689326381354L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 7,
    Value = 
new System.Int64[3]
{
4517394096854176905L,
2366136685115611068L,
7667642755893998816L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 7,
    Value = 
new System.Int64[3]
{
5439434826885957975L,
1878828884778298075L,
3120316797580590908L,
},
    NullableValue = 
new System.Int64[3]
{
7468397033805917918L,
4471515569938800236L,
8713051363072128647L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Int64[3]
{
3860422008623614343L,
6794499558128501498L,
2940489848770750345L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
5536860275229999021L,
4874277134664510311L,
7631752389851349479L,
3150571442773429693L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Int64[4]
{
1867423640951781465L,
2953241081027470636L,
113483940833813973L,
1288850946855091873L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Int64[3]
{
5926963016992442354L,
1277659379188599596L,
6804177652341766383L,
},
    NullableValue = 
new System.Int64[3]
{
2565317534296468824L,
4964357985209272822L,
8665954871096888153L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Int64[3]
{
3015543444164430132L,
5380841014247662837L,
3004321290967907879L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
5241318145163904621L,
2277443323061187137L,
1470734668799108495L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 24,
    Value = 
new System.Int64[3]
{
1743313367236051677L,
7457795642203158622L,
3135860578270199050L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Int64[4]
{
7300661585487573622L,
2932352057305965457L,
6163103286172844226L,
317640063086649937L,
},
    NullableValue = 
new System.Int64[4]
{
3631176072598381000L,
4081669825636246417L,
897741895478670642L,
7540633696483002655L,
},
},
    NullableValue = 
new System.Int64[3]
{
2743293919474561804L,
4665431661900596094L,
1202592382996999601L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Int64[4]
{
2380796627394397036L,
2781709253693587535L,
5305647821140580708L,
8236029953867961357L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
8471588799751092795L,
5081504872033271216L,
664060999137399201L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 27,
    Value = 
new System.Int64[4]
{
5060814695139576321L,
6777515883332285877L,
4729038723530462628L,
3417719190340940346L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Int64[4]
{
1742445151326542039L,
2400870000339208042L,
213745518451179822L,
5663040214621099144L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Int64[3]
{
5818143715518999063L,
7099352658560705967L,
178161311304768814L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
2689485820657356833L,
7691541202860165719L,
2609252927834176340L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 41,
    Value = 
new System.Int64[3]
{
7728673640870046182L,
3911314715419569514L,
4613169456689795909L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Int64[3]
{
8081251789501980551L,
2965717339980819680L,
5763533903415116605L,
},
    NullableValue = 
new System.Int64[4]
{
4083746924523463131L,
927569926865673215L,
3511665888137551144L,
8337175795897556431L,
},
},
    NullableValue = 
new System.Int64[4]
{
1439735242776595791L,
1065503881609186469L,
8899344433272049595L,
606157147612383820L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Int64[3]
{
809133932889093036L,
1802348352286781845L,
2039227986648076656L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Int64[4]
{
1562332732998816906L,
6746008966013510402L,
2160291082662261434L,
4709488436046879465L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 28,
    Value = 
new System.Int64[4]
{
6836870667185794070L,
4469958119912746836L,
3405497855407999869L,
2414408077670279781L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Int64[4]
{
7518214162481411949L,
5842858166690255636L,
5930339212234951397L,
1896976798758799480L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Int64[3]
{
9111400732874210307L,
7070150287902906128L,
8611048149511934319L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Int64[4]
{
4212982000827508454L,
694844126582898629L,
2279496181077848414L,
5085943754616360351L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Int64[3]
{
5885506048489803198L,
6334264341145611468L,
7410829977919129900L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 72,
    Value = 
new System.Int64[4]
{
9161780816002136794L,
7730805056618676370L,
4313215288387239851L,
5298135139142718319L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Int64[4]
{
6539253624695339754L,
7987380477173875811L,
4592220734208846539L,
4461117072940024599L,
},
    NullableValue = 
new System.Int64[3]
{
1534817288747489222L,
988459311657615033L,
4269363678186792627L,
},
},
    NullableValue = 
new System.Int64[4]
{
7122060943059822569L,
121594162184022295L,
8479715882436381768L,
7755773773841835636L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 81,
    Value = 
new System.Int64[3]
{
6121066168432169344L,
1172880018721184354L,
6958269860371638806L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 87,
    Value = 
new System.Int64[4]
{
8052694491131030219L,
5483425919850102106L,
1036476182297543317L,
6991909835950619523L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Int64[3]
{
4987668415023988370L,
3418829624922865255L,
210727453563308255L,
},
    NullableValue = 
new System.Int64[4]
{
8111934287493334468L,
2664296079251071703L,
2633978215925102043L,
2722729113591140719L,
},
},
    NullableValue = 
new System.Int64[4]
{
4590691090085425109L,
2288914316106756487L,
8494625422850401121L,
4391302317678192888L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Int64[4]
{
8755674924364237715L,
6222666087456969986L,
764011602423214806L,
2964277713448834497L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Int64[4]
{
934979582181636343L,
5159640753281324422L,
8974962063801994310L,
6359225994229031139L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 42,
    Value = 
new System.Int64[3]
{
3120535965437178540L,
5807803334035678887L,
6506959428061183656L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6986387074504427602L,
1362494325523962459L,
4709814580567421759L,
172261543543681806L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Int64[3]
{
718609375598687303L,
8683321519611183832L,
5977424170582366708L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 107,
    Value = 
new System.Int64[3]
{
294608932837326132L,
5563337844355096530L,
4980162246828331664L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 44,
    Value = 
new System.Int64[3]
{
8190948734513230354L,
7344017536384382190L,
3787528705843451035L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
2723357967165127943L,
8357704659039710426L,
7896912397331883235L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 108,
    Value = 
new System.Int64[4]
{
8272917340112270901L,
475408042559512461L,
8166224882141382786L,
8649804608373561039L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1020860720476720130L,
3429556956426041213L,
2167863786625070976L,
6744652601305013213L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Int64[4]
{
8513034929599781287L,
8450121369551463901L,
8788411459773209917L,
913848533339659361L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Int64[4]
{
4332535278396105440L,
2652277425204479580L,
5305977956985134743L,
7504835871943133693L,
},
    NullableValue = 
new System.Int64[4]
{
498064881219579725L,
6502591510014042992L,
7577396884740460070L,
5093369972415253470L,
},
},
    NullableValue = 
new System.Int64[3]
{
7517079262576367246L,
8463117925228949189L,
7089232068724057356L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Int64[4]
{
3721622816651184512L,
3129117594290326220L,
3154873787782887859L,
3554902167984185510L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
6647173314858852840L,
3912292979540275366L,
1713210478761150499L,
1609785906179483582L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Int64[3]
{
2374312390083361354L,
8313173223200530112L,
8237757802553556703L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.Int64[3]
{
7537544905007082774L,
6037136608936283318L,
6243872093223834844L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Int64[4]
{
8142441500628474525L,
7695490359756266058L,
8816044523507457663L,
6818350304414001118L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
7088644398064111939L,
7797214471298587369L,
3505228862493574573L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Int64[3]
{
3914894412910976681L,
6052735420389549289L,
4582438855385791243L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Int64[4]
{
5609629930925034143L,
199972610579906949L,
5059354767502254334L,
9026641012287145777L,
},
    NullableValue = 
new System.Int64[4]
{
2199442821030585224L,
3327516581884338824L,
8641487282987989814L,
1978489041445274682L,
},
},
    NullableValue = 
new System.Int64[3]
{
5882477839408413641L,
7395387009556760710L,
5183190911203690632L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 130,
    Value = 
new System.Int64[4]
{
2462202436031740802L,
6661942933782349265L,
326704869711075596L,
4722361619641334968L,
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
5078834263464673661L,
4598859034821254231L,
910631935572237263L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Int64[4]
{
1430634320559961583L,
7746615093835698910L,
5682741136549186775L,
323683801611936733L,
},
    NullableValue = 
new System.Int64[3]
{
3211529386153553426L,
3800060425306310534L,
748440625176503295L,
},
},
    NullableValue = 
new System.Int64[4]
{
980682946709207521L,
3061237978970305854L,
6258144341578595613L,
2929354989838588504L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Int64[3]
{
6299550612412769569L,
5140647740728768953L,
799872571380336050L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 135,
    Value = 
new System.Int64[4]
{
6571347650611818876L,
1996332844147073883L,
4016910449217672150L,
8954772313502806412L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 71,
    Value = 
new System.Int64[3]
{
131252913801684960L,
7392127867103100196L,
3444366883379260199L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Int64[4]
{
8476912562725546439L,
3622424159010412144L,
7551349703225640245L,
5860776515569432717L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
2395117565889118349L,
4013411507894564510L,
25896030620194972L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Int64[3]
{
7906421552211797981L,
2776420078171207642L,
708202825505453261L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Int64[3]
{
8372349604079827008L,
8471743109913551055L,
5649029437791195855L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Int64[4]
{
7390100202642292004L,
3940557671238808122L,
4447371022233349671L,
6860555762293344583L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
5088553935885599920L,
1244896090271278591L,
692469638320051809L,
3185038132512520592L,
},
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
new System.Int64[3]
{
5241318145163904621L,
2277443323061187137L,
1470734668799108495L,
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
2743293919474561804L,
4665431661900596094L,
1202592382996999601L,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
8471588799751092795L,
5081504872033271216L,
664060999137399201L,
}));
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
2689485820657356833L,
7691541202860165719L,
2609252927834176340L,
}));
                nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
1439735242776595791L,
1065503881609186469L,
8899344433272049595L,
606157147612383820L,
}));
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
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 104;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 135;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
                parametr2.Value = 105;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 134, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 26, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
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
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 104, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
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
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 111, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 4, query1, 81, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
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
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 123, query1, 129, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 71, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 108, query1, 129, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 111, 60))
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 60, 4))
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
                ((IInt64MArraybigintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 105);
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64MArraybigintMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64MArraybigintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 19);
                var models =  ((IInt64MArraybigintMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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

