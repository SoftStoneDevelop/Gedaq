

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IUInt64MArrayMArrayD1
    {
    }
    
    internal partial class UInt64MArrayMArrayD1 : IUInt64MArrayMArrayD1
    {


#region TestData

        private readonly UInt64MArrayD1E1M[] _testData = new UInt64MArrayD1E1M[]
        {
            new UInt64MArrayD1E1M
{
    Id = 9,
    Value = 
new System.UInt64[4]
{
6876021289954546852L,
8189285390815115484L,
5967941373586403591L,
7291424798495051505L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 4,
    Value = 
new System.UInt64[4]
{
1545868190332786385L,
5599011984700587232L,
2206792027315583893L,
4579882681702926915L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 18,
    Value = 
new System.UInt64[4]
{
2753096190397442912L,
6581669583274266176L,
7809747625119579356L,
8399389752822609884L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 5,
    Value = 
new System.UInt64[3]
{
2492534977972687582L,
1601160127482528025L,
6781766562100058928L,
},
    NullableValue = 
new System.UInt64[4]
{
5777495301574847452L,
3534005241198833061L,
438250844772930062L,
1172131748697168934L,
},
},
    NullableValue = 
new System.UInt64[4]
{
8031761146633012774L,
7203371544097709801L,
846057682124131369L,
3320806866769974818L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 21,
    Value = 
new System.UInt64[3]
{
4536339487122516785L,
5863629234784300447L,
2327287863620750776L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 9,
    Value = 
new System.UInt64[3]
{
3297077317463126725L,
4255358072475982070L,
1084701309861414937L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
2811784702034993966L,
9156884072260973301L,
2754971551950048273L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 27,
    Value = 
new System.UInt64[3]
{
5549820880181049860L,
8659660418841801686L,
2397961781676737327L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 13,
    Value = 
new System.UInt64[3]
{
5395927787081256075L,
225421284215514450L,
7836462246737857703L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 28,
    Value = 
new System.UInt64[4]
{
6906318779507165699L,
4105708242378332758L,
7794153158830331249L,
396780535260464789L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 21,
    Value = 
new System.UInt64[3]
{
2583399856349631243L,
8059489115135684629L,
8375721842269853181L,
},
    NullableValue = 
new System.UInt64[4]
{
1755446120426726360L,
2605650670083455417L,
1332045553642313854L,
5582610801628161930L,
},
},
    NullableValue = 
new System.UInt64[3]
{
6563237473616211858L,
429582017617420563L,
6256351740851407412L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 32,
    Value = 
new System.UInt64[4]
{
329238417788561676L,
8738491144478770336L,
1347396991500664816L,
7598763392182885620L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 27,
    Value = 
new System.UInt64[4]
{
2883643938058805518L,
1115949748292520183L,
3226690048969437456L,
7287059077206922727L,
},
    NullableValue = 
new System.UInt64[3]
{
600964567302443453L,
6346146112440810074L,
3757114066342784433L,
},
},
    NullableValue = 
new System.UInt64[3]
{
8861412785552460921L,
1150970410447330587L,
3878999835704782696L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 39,
    Value = 
new System.UInt64[4]
{
6520102242958564488L,
7272972463377339538L,
6222603540784961557L,
3483204197059429950L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 28,
    Value = 
new System.UInt64[3]
{
9019889335689458395L,
3593003041163047063L,
2255188204867634192L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
1216595120798220894L,
9016761125063150010L,
6825825722974919716L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 40,
    Value = 
new System.UInt64[4]
{
7131562815234836091L,
1717715528846017864L,
4185887602760692840L,
1254150636043301799L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 32,
    Value = 
new System.UInt64[3]
{
3841423504963869271L,
5262841956363336421L,
1082490985321974153L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
2618232710069062140L,
5944566537778496962L,
4302433801479759891L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 49,
    Value = 
new System.UInt64[4]
{
2061983808207663227L,
3470380272168389782L,
550999593230697075L,
8983974053252381404L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 40,
    Value = 
new System.UInt64[3]
{
201231523476955811L,
8120904897362163018L,
63250334786123371L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 52,
    Value = 
new System.UInt64[4]
{
8203310397028036004L,
2961272955419766940L,
7407623784582119851L,
6501335268831205458L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 44,
    Value = 
new System.UInt64[3]
{
7284687401394905002L,
6907788588581653657L,
5721716403379295724L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
1296981749529533935L,
3127394927639907762L,
978333405488016419L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 54,
    Value = 
new System.UInt64[4]
{
1979357908073317346L,
1108510099197075475L,
6079285618677321727L,
717042793926616945L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 52,
    Value = 
new System.UInt64[4]
{
5318347140507799916L,
569554253739539901L,
3718297583590542939L,
1189844498643125783L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
8560130607760410777L,
4747668169719320051L,
1420166873871303201L,
3513407725388091612L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 61,
    Value = 
new System.UInt64[4]
{
4730058115226129414L,
1457308680331162468L,
7005206547036919892L,
4227678807225807189L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 54,
    Value = 
new System.UInt64[3]
{
9092848812415006804L,
9047158858171624300L,
331382923994393049L,
},
    NullableValue = 
new System.UInt64[3]
{
4159485758863347707L,
8892558415633812668L,
9068955819827741054L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 64,
    Value = 
new System.UInt64[3]
{
6643211225334987096L,
4156861445286944164L,
1698658672028902694L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 56,
    Value = 
new System.UInt64[4]
{
1970170693405161165L,
5459869195615215667L,
7176479812232209928L,
4420687068937946987L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 71,
    Value = 
new System.UInt64[3]
{
202113018456148894L,
4092462140573333631L,
7059408315088545558L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 57,
    Value = 
new System.UInt64[4]
{
3288902596698889890L,
4034136488435622406L,
3717668704302493016L,
568929469454152404L,
},
    NullableValue = 
new System.UInt64[3]
{
6963696309168975060L,
5665033908279921916L,
3258302356884236003L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 78,
    Value = 
new System.UInt64[4]
{
5873677013330158716L,
5340225611914289648L,
5293955027345801764L,
3782878868877486480L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 65,
    Value = 
new System.UInt64[3]
{
2929941356693018610L,
6373484873061443232L,
357949700411400555L,
},
    NullableValue = 
new System.UInt64[4]
{
8682397017536209413L,
2248478598736824011L,
8484614433232776273L,
3629034004250463592L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 85,
    Value = 
new System.UInt64[3]
{
3468233792834685672L,
7302976870484695688L,
3585550304220939762L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 74,
    Value = 
new System.UInt64[4]
{
7725607703201138421L,
1087639048237412186L,
4133007598038980981L,
2307585811824096417L,
},
    NullableValue = 
new System.UInt64[4]
{
5914762862712122407L,
1606639047009820747L,
7806487953934464016L,
2651038497866376112L,
},
},
    NullableValue = 
new System.UInt64[4]
{
7365191740113062355L,
8397024581332463057L,
3874559493389319826L,
7673197053359484836L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 88,
    Value = 
new System.UInt64[4]
{
8376436221752542491L,
8023412957105793960L,
6893012204743552661L,
6032612039013189333L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 78,
    Value = 
new System.UInt64[3]
{
551287268339049232L,
29824625582748574L,
2018851928104196162L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 90,
    Value = 
new System.UInt64[4]
{
80589177295881610L,
3228011109149675489L,
7902035691195166962L,
3010784673580317517L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 85,
    Value = 
new System.UInt64[4]
{
7690203454399817280L,
2650433925951906618L,
1505655775088492221L,
5435081321320786001L,
},
    NullableValue = 
new System.UInt64[3]
{
4235018091668280502L,
8424078670514388979L,
1322579042705987681L,
},
},
    NullableValue = 
new System.UInt64[4]
{
6177288923261944028L,
4759471981064988922L,
6299943853985300131L,
6220708987902346961L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 98,
    Value = 
new System.UInt64[3]
{
8462633455030708611L,
8897625858541766804L,
7205030713365519106L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 93,
    Value = 
new System.UInt64[3]
{
1272029276054546157L,
528094742486567955L,
5077188070372952908L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[3]
{
7895305471788786350L,
3531635149248794591L,
6081758310551726226L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 105,
    Value = 
new System.UInt64[3]
{
6281713047014708822L,
8546602091430171786L,
3330495015517526248L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 98,
    Value = 
new System.UInt64[4]
{
8507244166735772199L,
1418794486868566059L,
5741702115599331166L,
8741425932312541535L,
},
    NullableValue = 
new System.UInt64[3]
{
3252146100802880222L,
3707131918810367219L,
254874812034737193L,
},
},
    NullableValue = 
new System.UInt64[3]
{
4814641183920444293L,
8665846515669654319L,
1221276476986895546L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 110,
    Value = 
new System.UInt64[3]
{
2217566538331406651L,
6017788625442066751L,
7755668652810071402L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 106,
    Value = 
new System.UInt64[3]
{
5864614673087792000L,
1762841899079247399L,
6038701374028481449L,
},
    NullableValue = 
new System.UInt64[3]
{
7861551874837565660L,
5574783818272110040L,
4814389623085136904L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 113,
    Value = 
new System.UInt64[4]
{
4707141142436554234L,
8611291147096171395L,
5742638309301172610L,
6632071596088534749L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 107,
    Value = 
new System.UInt64[3]
{
2187780891207696389L,
3998708627387856846L,
4969213311143975371L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 117,
    Value = 
new System.UInt64[3]
{
8662475606614382016L,
7196914375324573504L,
1382288090877576501L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 109,
    Value = 
new System.UInt64[4]
{
6562610421148557858L,
1636755849050701989L,
8270077077124865893L,
6264574297432216145L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 123,
    Value = 
new System.UInt64[4]
{
8121127647350683359L,
6150980218207348806L,
2939663614847239699L,
2761334048779990091L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 114,
    Value = 
new System.UInt64[3]
{
2090764118439764119L,
1501296795932329669L,
7345410351714728592L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 124,
    Value = 
new System.UInt64[4]
{
6436775006452232650L,
7631777698218918255L,
4892248961791800728L,
8390627413730420970L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 123,
    Value = 
new System.UInt64[4]
{
4101873971609998664L,
8169056254465047052L,
5899684275706023752L,
8250720754102868050L,
},
    NullableValue = 
new System.UInt64[3]
{
6555158821904525905L,
2865613614312497005L,
9049210080740749045L,
},
},
    NullableValue = 
new System.UInt64[4]
{
4342672298824987759L,
7639525330741545496L,
6352832201281272697L,
2128166301419229696L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 127,
    Value = 
new System.UInt64[4]
{
1576343602823219502L,
6297258673601515536L,
4429703071342891826L,
1369915392444393240L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 129,
    Value = 
new System.UInt64[3]
{
6116936283311066926L,
1600164579703797659L,
5401493855640222609L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
9049240841018220904L,
9136260983089566350L,
3306925996945617412L,
1317796413974846520L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 129,
    Value = 
new System.UInt64[4]
{
6076123580354860548L,
4676965886787811255L,
2707799340121991420L,
3442125442993832495L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 131,
    Value = 
new System.UInt64[3]
{
7190952626270640729L,
584128234839812076L,
6993393272768880960L,
},
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[4]
{
3891204212009452989L,
5961778019707548505L,
3667409451705612181L,
8453636290951832827L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 136,
    Value = 
new System.UInt64[3]
{
4505443450456712535L,
5943285909822645528L,
3273458834186051337L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 136,
    Value = 
new System.UInt64[4]
{
4354444899836089473L,
3435257025335356844L,
3882272416409371523L,
8011419661133986905L,
},
    NullableValue = 
new System.UInt64[4]
{
190331770744462029L,
7036925686438550600L,
924314018680452087L,
2307134365064946622L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 139,
    Value = 
new System.UInt64[4]
{
569820759123199955L,
4970282955368043361L,
7287977905364330503L,
1581741229291118893L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 140,
    Value = 
new System.UInt64[4]
{
2848344590337160764L,
462865110320595550L,
6259001778639579230L,
2061733778460978397L,
},
    NullableValue = 
new System.UInt64[4]
{
5474559701741751740L,
7381364223901743420L,
8300909788875706657L,
7041894144670771368L,
},
},
    NullableValue = 
new System.UInt64[3]
{
2542640828682861386L,
8954133329331811088L,
269776862010261899L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 145,
    Value = 
new System.UInt64[4]
{
5976338881879370226L,
6376965007306875678L,
7184169939177898473L,
6958554977295647638L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 141,
    Value = 
new System.UInt64[4]
{
6590118027811415771L,
8487525607075208367L,
5965545180362490651L,
616329804182703274L,
},
    NullableValue = 
new System.UInt64[3]
{
7975924131124073732L,
6581033698531186648L,
2689225241348252521L,
},
},
    NullableValue = 
new System.UInt64[4]
{
5380870437512186302L,
8345629728054623410L,
4193088544819839179L,
4105133413398817128L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 151,
    Value = 
new System.UInt64[3]
{
5822072763042222040L,
3918167347075320684L,
4845819824107471686L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 143,
    Value = 
new System.UInt64[3]
{
2653795209718171376L,
5491725342091236909L,
3129311573656332388L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 153,
    Value = 
new System.UInt64[4]
{
7806431018641980385L,
1687962801299908805L,
5664475388239141663L,
6493561855303013133L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 147,
    Value = 
new System.UInt64[3]
{
8798881582516191220L,
8833317144638675281L,
7649632088708638296L,
},
    NullableValue = 
new System.UInt64[3]
{
912898324010226123L,
1799414026782031083L,
6755589523485548050L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 159,
    Value = 
new System.UInt64[3]
{
5527387090034368439L,
7461727441049834740L,
8366997354420616542L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 155,
    Value = 
new System.UInt64[4]
{
2971021946842296095L,
3699517675378284033L,
2291053311606789616L,
2537479905835960940L,
},
    NullableValue = 
new System.UInt64[3]
{
1088347841785473739L,
3089445009319443267L,
1415370347249854167L,
},
},
    NullableValue = null,
},
            new UInt64MArrayD1E1M
{
    Id = 163,
    Value = 
new System.UInt64[3]
{
886890592787939140L,
6649115642737931183L,
3382100247183858885L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 157,
    Value = 
new System.UInt64[4]
{
7883222153895801500L,
809053171596040679L,
2541323052224023930L,
5117890465112435877L,
},
    NullableValue = 
new System.UInt64[4]
{
7752313106065642829L,
493886206099318764L,
3864784785590936451L,
6377372534490414251L,
},
},
    NullableValue = 
new System.UInt64[4]
{
2933433427950009236L,
3164757348306793446L,
7309659071272767067L,
7011604236573541892L,
},
},
            new UInt64MArrayD1E1M
{
    Id = 166,
    Value = 
new System.UInt64[4]
{
394342748155551801L,
8514376234039940425L,
3018486662318904752L,
6625794273347577567L,
},
    ModelInner = new UInt64MArrayD1E1MI
{
    Id = 161,
    Value = 
new System.UInt64[4]
{
8086044268044896983L,
5598105186064563151L,
4870497683418623300L,
8032659528098158234L,
},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64marrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UInt64)}, 
    {mi_id:Int32},
    {mi_value:Array(UInt64)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IUInt64MArrayMArrayD1)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IUInt64MArrayMArrayD1)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.uint64marrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64MArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IUInt64MArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IUInt64MArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

