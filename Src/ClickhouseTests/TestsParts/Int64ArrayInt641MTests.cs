

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
    internal partial interface IInt64ArrayArrayInt64
    {
    }
    
    internal partial class Int64ArrayArrayInt64 : IInt64ArrayArrayInt64
    {


#region TestData

        private readonly Int64ArrayInt641M[] _testData = new Int64ArrayInt641M[]
        {
            new Int64ArrayInt641M
{
    Id = 9,
    Value = 
new System.Int64[4]
{
1947274932102386260L,
8239097883441365434L,
4749784474684989120L,
5269740397199865978L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 4,
    Value = 
new System.Int64[4]
{
6829387965108559219L,
1023873178547211579L,
3925517403885710450L,
7157677385033319278L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
4653742487997990962L,
2950179352714242912L,
3308194671204278774L,
},
},
            new Int64ArrayInt641M
{
    Id = 14,
    Value = 
new System.Int64[3]
{
3431929118860409461L,
2552089949595634901L,
856744337297371518L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 11,
    Value = 
new System.Int64[4]
{
8681751787500979403L,
3848815220166927762L,
2479565455087030724L,
2044657590768309477L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
5091188313861156651L,
7438698029487512478L,
7360613232211737011L,
},
},
            new Int64ArrayInt641M
{
    Id = 22,
    Value = 
new System.Int64[3]
{
4953108580834497544L,
2273833081340954546L,
2744711269970336943L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 17,
    Value = 
new System.Int64[3]
{
7427604405356510562L,
3678346708160416935L,
4055092486125571315L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
4710166474969184177L,
2697049677355183319L,
4991795281238490458L,
977475832830432301L,
},
},
            new Int64ArrayInt641M
{
    Id = 30,
    Value = 
new System.Int64[3]
{
8667494144358215499L,
1594669503934192069L,
3891086089149201771L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 24,
    Value = 
new System.Int64[4]
{
8196429387472365616L,
3815397094840916392L,
2780585522300518884L,
4777788336847602518L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayInt641M
{
    Id = 37,
    Value = 
new System.Int64[4]
{
7072854237312249901L,
7799299941890970572L,
4111907103687216801L,
6184161521073488928L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 33,
    Value = 
new System.Int64[3]
{
8155643230823122250L,
2674825053876024967L,
7553533481326731913L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
4647821668612741529L,
5092061590034819885L,
3196571857202608891L,
1609777623379135852L,
},
},
            new Int64ArrayInt641M
{
    Id = 38,
    Value = 
new System.Int64[4]
{
4628156707322487358L,
8743753864859980220L,
6546913852497273750L,
3260135309715566509L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 42,
    Value = 
new System.Int64[3]
{
51809902729913126L,
5912862465907611536L,
1704892094805953121L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
8723793797661654792L,
308052602670654254L,
6437606610161117709L,
2802941369340827559L,
},
},
            new Int64ArrayInt641M
{
    Id = 41,
    Value = 
new System.Int64[4]
{
3596088154418987009L,
4674128664988547815L,
501935527297391240L,
2553737166056191027L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 50,
    Value = 
new System.Int64[4]
{
333675780869918352L,
7223187627515060733L,
4622771912342861739L,
6826464059761799628L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
3258126274871145466L,
7518537383131110856L,
868238666670395142L,
6366954008175054775L,
},
},
            new Int64ArrayInt641M
{
    Id = 48,
    Value = 
new System.Int64[3]
{
7734202337239152376L,
5327858254072936087L,
3798838044292168412L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 57,
    Value = 
new System.Int64[4]
{
7070102427295962837L,
1420690455767946466L,
6722840127814903729L,
5191935405753582654L,
},
    NullableValue = 
new System.Int64[4]
{
8859565277475858711L,
5495446681117561842L,
21151511200213242L,
2375643281645972436L,
},
},
    NullableValue = 
new System.Int64[4]
{
6310839665986520551L,
8607097465765457656L,
6745232980538070261L,
4472252955755110046L,
},
},
            new Int64ArrayInt641M
{
    Id = 57,
    Value = 
new System.Int64[4]
{
3367949124917729684L,
2258685369960860928L,
887557612327415934L,
7853903442128235148L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 59,
    Value = 
new System.Int64[3]
{
9131732132721458593L,
2286959091480258856L,
3530272332069832266L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayInt641M
{
    Id = 64,
    Value = 
new System.Int64[3]
{
3675616574637184920L,
1517595287785365013L,
4998391673967841566L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 68,
    Value = 
new System.Int64[3]
{
2474218439531657794L,
6785783024332945672L,
4734181783751382029L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayInt641M
{
    Id = 65,
    Value = 
new System.Int64[3]
{
3869526240778144134L,
3434479144558109812L,
2381944563210320306L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 73,
    Value = 
new System.Int64[3]
{
304057831038368320L,
2603433265916917930L,
639622689744335766L,
},
    NullableValue = 
new System.Int64[4]
{
2539421280138974197L,
1871826974025107421L,
5533907467041424534L,
3769341966695060614L,
},
},
    NullableValue = 
new System.Int64[3]
{
2265701602291110069L,
8826791986307629823L,
8686035028752517599L,
},
},
            new Int64ArrayInt641M
{
    Id = 66,
    Value = 
new System.Int64[4]
{
6124007297141065336L,
7089105519554800871L,
4780530624919234750L,
7721717862797366198L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 82,
    Value = 
new System.Int64[4]
{
6720624307219098778L,
1717565825851743927L,
4931297761647889515L,
6008401580254557121L,
},
    NullableValue = 
new System.Int64[3]
{
5291022688587391258L,
361382344129966444L,
1139374163484049021L,
},
},
    NullableValue = 
new System.Int64[4]
{
4745826040204802036L,
8075853139020068649L,
6391611803657371507L,
2479982645905829644L,
},
},
            new Int64ArrayInt641M
{
    Id = 67,
    Value = 
new System.Int64[3]
{
5484814281709335970L,
8671054643461630646L,
1700909314326212174L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 84,
    Value = 
new System.Int64[4]
{
5495803585496808876L,
5836556159069313583L,
7268821896368672652L,
6756856231500483573L,
},
    NullableValue = 
new System.Int64[3]
{
3493000533469078369L,
4296964969049986423L,
239472509225557923L,
},
},
    NullableValue = null,
},
            new Int64ArrayInt641M
{
    Id = 73,
    Value = 
new System.Int64[4]
{
2885305568418605398L,
793651982569963561L,
6788035531769294160L,
254552118483852442L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 91,
    Value = 
new System.Int64[4]
{
7748391713794685123L,
6974067794871961458L,
6451802611652294746L,
570361758329526239L,
},
    NullableValue = 
new System.Int64[3]
{
1676670782344810158L,
4253829062611927005L,
1838626987979445968L,
},
},
    NullableValue = null,
},
            new Int64ArrayInt641M
{
    Id = 78,
    Value = 
new System.Int64[4]
{
4762202764161668939L,
5815267881422246865L,
8362894834104539018L,
569164127471870100L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 92,
    Value = 
new System.Int64[4]
{
3788873778048362705L,
4389469188136261291L,
3501065136253867503L,
1427597493901663825L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayInt641M
{
    Id = 87,
    Value = 
new System.Int64[4]
{
1812451103312340954L,
2031552563928103917L,
6095241972339069802L,
738266431125794095L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 101,
    Value = 
new System.Int64[4]
{
6199884090026523421L,
1771426755962193979L,
5982214357451921898L,
2822907212008619489L,
},
    NullableValue = 
new System.Int64[3]
{
9009037187194371290L,
5264378767353715121L,
4849542278101782740L,
},
},
    NullableValue = 
new System.Int64[3]
{
8238869180929868660L,
4324539221990947877L,
6022501318189596721L,
},
},
            new Int64ArrayInt641M
{
    Id = 95,
    Value = 
new System.Int64[4]
{
3811443264629237995L,
8036538764011472268L,
448744748073269087L,
350130803501485917L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 109,
    Value = 
new System.Int64[4]
{
7671366869422606878L,
1629643652585863514L,
8031146770961478836L,
5762970673547712479L,
},
    NullableValue = 
new System.Int64[4]
{
7904790788436838503L,
3665092186746109534L,
8090662826791291222L,
449009254991614561L,
},
},
    NullableValue = null,
},
            new Int64ArrayInt641M
{
    Id = 99,
    Value = 
new System.Int64[4]
{
2864321422176910860L,
162747612827656618L,
918060492279277346L,
2359963437380504065L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 118,
    Value = 
new System.Int64[3]
{
959800605963274732L,
7976084331444053353L,
3625670548982739500L,
},
    NullableValue = 
new System.Int64[4]
{
3472754546576310341L,
7889078362771979987L,
3623013093325808281L,
1710311399285389251L,
},
},
    NullableValue = 
new System.Int64[3]
{
9011041451457194628L,
6131769945194106445L,
986423756495505693L,
},
},
            new Int64ArrayInt641M
{
    Id = 102,
    Value = 
new System.Int64[3]
{
7941844573910829761L,
3098053236278386555L,
6454198112001909191L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 121,
    Value = 
new System.Int64[3]
{
2750117301382757330L,
427030134719919676L,
7833913502196729653L,
},
    NullableValue = 
new System.Int64[4]
{
1995999976633549072L,
3248404560443701948L,
546450836677077266L,
6263491937181751380L,
},
},
    NullableValue = 
new System.Int64[3]
{
3113715811200445020L,
5511989013059027903L,
2615401279989569575L,
},
},
            new Int64ArrayInt641M
{
    Id = 108,
    Value = 
new System.Int64[3]
{
8964783656862201138L,
6365344310516742031L,
3035409577600292316L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 130,
    Value = 
new System.Int64[4]
{
917616936165575328L,
5534475525847519959L,
2804091641316150252L,
7797635422954260272L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64ArrayInt641M
{
    Id = 117,
    Value = 
new System.Int64[4]
{
5723672543777896888L,
425563571770740612L,
4509967930468698990L,
673553885286971803L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 132,
    Value = 
new System.Int64[3]
{
7631551803097603359L,
498899230706039753L,
1616440377474664589L,
},
    NullableValue = 
new System.Int64[3]
{
1991661789997614287L,
3305871146635797432L,
2574528193789013704L,
},
},
    NullableValue = null,
},
            new Int64ArrayInt641M
{
    Id = 126,
    Value = 
new System.Int64[4]
{
8543605049060580486L,
3121264793332447235L,
3378997687193258187L,
5033546830807141328L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 133,
    Value = 
new System.Int64[3]
{
1518041525776928370L,
2052082274029583561L,
998711497905401186L,
},
    NullableValue = 
new System.Int64[3]
{
3167430256380755046L,
6929374608070026249L,
1216527515531862139L,
},
},
    NullableValue = 
new System.Int64[3]
{
717381277755812385L,
2776885511086105238L,
8491973232929098800L,
},
},
            new Int64ArrayInt641M
{
    Id = 134,
    Value = 
new System.Int64[3]
{
8098788638789335142L,
5092850156906795445L,
1811389636828713006L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 137,
    Value = 
new System.Int64[3]
{
7174840700048338818L,
8747694079414543877L,
6767618902243333296L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
4813056835518743267L,
590822873381954160L,
5577529695415929902L,
},
},
            new Int64ArrayInt641M
{
    Id = 141,
    Value = 
new System.Int64[3]
{
6741383964462456897L,
8410169230494776497L,
1103927714645323941L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 145,
    Value = 
new System.Int64[3]
{
525786440332058616L,
9180730599379921684L,
8617323642756490696L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
9104116923945437725L,
5552054687644002778L,
1189545056528344157L,
5028349254828337718L,
},
},
            new Int64ArrayInt641M
{
    Id = 142,
    Value = 
new System.Int64[3]
{
7948741374024988466L,
2528150412944815704L,
2026433893403759540L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 153,
    Value = 
new System.Int64[4]
{
7781738748722511507L,
2611050464178337741L,
2615958504004360139L,
9220337612560850752L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
3035138951877653602L,
8674591864131856612L,
404562444912078726L,
6893543764864652754L,
},
},
            new Int64ArrayInt641M
{
    Id = 145,
    Value = 
new System.Int64[3]
{
7637928641815490562L,
3582655444532587117L,
3214561909739483212L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 162,
    Value = 
new System.Int64[3]
{
2404726729823943031L,
3287770227048506302L,
6389927661753095517L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
8024388312460338403L,
1798138711032525570L,
5890699916475172762L,
},
},
            new Int64ArrayInt641M
{
    Id = 152,
    Value = 
new System.Int64[3]
{
1105617699501084171L,
609648569332630884L,
3837983796221788950L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 166,
    Value = 
new System.Int64[4]
{
9158224038599726373L,
7477864788127383677L,
5171946597011101055L,
6380635314878668572L,
},
    NullableValue = 
new System.Int64[3]
{
7395292894877660647L,
1331810649403521071L,
1569044129683035583L,
},
},
    NullableValue = 
new System.Int64[3]
{
2015597635751304007L,
4454354134210485722L,
3032643642981851038L,
},
},
            new Int64ArrayInt641M
{
    Id = 155,
    Value = 
new System.Int64[4]
{
438571565705907277L,
8119990063215078618L,
9021515927133107847L,
5098924676347299095L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 171,
    Value = 
new System.Int64[3]
{
3370796324415585761L,
7788692251897447655L,
2428958135929405671L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
1591104780630009821L,
4183546670154962494L,
6613135066898358654L,
5144930507737830649L,
},
},
            new Int64ArrayInt641M
{
    Id = 159,
    Value = 
new System.Int64[3]
{
6428519222961437523L,
7607739522878055334L,
4949522536395280978L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 178,
    Value = 
new System.Int64[4]
{
4012377384280123306L,
1807426575702845208L,
9156015165101202001L,
5507831531225688649L,
},
    NullableValue = 
new System.Int64[3]
{
4186819296881991109L,
7719542504887452816L,
6254849661343649244L,
},
},
    NullableValue = 
new System.Int64[3]
{
7036468810045537099L,
4165774864900720699L,
6919950129734259555L,
},
},
            new Int64ArrayInt641M
{
    Id = 161,
    Value = 
new System.Int64[4]
{
2107956884781896090L,
3120553160336192976L,
8939333972040825843L,
2386025644562848921L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 187,
    Value = 
new System.Int64[4]
{
8072416313910434698L,
6462277126280406600L,
6062237810214396115L,
3909194302586933232L,
},
    NullableValue = 
new System.Int64[4]
{
8467014391495545067L,
8409362014532387388L,
3657249941737370441L,
1804316259241554349L,
},
},
    NullableValue = null,
},
            new Int64ArrayInt641M
{
    Id = 165,
    Value = 
new System.Int64[3]
{
1998202734779111290L,
8558202187167126370L,
9201525978136393944L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 189,
    Value = 
new System.Int64[4]
{
4293865377603228728L,
6759883014012559861L,
4241783734791410494L,
5894373152418489986L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
8673737504812921549L,
813900421717830756L,
6936547312877392791L,
},
},
            new Int64ArrayInt641M
{
    Id = 167,
    Value = 
new System.Int64[3]
{
5333421913279599297L,
7409086562630828849L,
1304928312646427282L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 198,
    Value = 
new System.Int64[4]
{
241257331141881017L,
4976947224724985944L,
3675069823977216971L,
584813783398942098L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
2963498930135930788L,
3197413017024331963L,
8751925000521401736L,
},
},
            new Int64ArrayInt641M
{
    Id = 174,
    Value = 
new System.Int64[4]
{
3926050332945319580L,
7690124832175998112L,
785725878911747201L,
2487523930777089604L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 202,
    Value = 
new System.Int64[4]
{
2288952566704498112L,
8366722597376494018L,
2112803614308905452L,
2109697092225203970L,
},
    NullableValue = 
new System.Int64[3]
{
318218003822746064L,
1431505918186571990L,
2680221747077585712L,
},
},
    NullableValue = 
new System.Int64[3]
{
715939271035007087L,
6573583375583785221L,
2900904207066215901L,
},
},
            new Int64ArrayInt641M
{
    Id = 178,
    Value = 
new System.Int64[3]
{
6764565438642521140L,
5184110331726443787L,
9202615873699654802L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 206,
    Value = 
new System.Int64[4]
{
8459742154225403716L,
2424362894221390886L,
7957434422104483706L,
3053615156395728891L,
},
    NullableValue = 
new System.Int64[3]
{
3921390187046294149L,
1273901963190287626L,
3993730581438831784L,
},
},
    NullableValue = 
new System.Int64[4]
{
4877739021932986595L,
6075727241329915770L,
2888249376757760077L,
1396874635443504904L,
},
},
            new Int64ArrayInt641M
{
    Id = 187,
    Value = 
new System.Int64[4]
{
3027995716315737868L,
8113800852179711201L,
6854831956268235716L,
2815782544843835201L,
},
    ModelInner = new Int64ArrayInt641MI
{
    Id = 207,
    Value = 
new System.Int64[4]
{
4413471266678683685L,
7463298868577536157L,
5655177305295211919L,
5216081259920224454L,
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
INSERT INTO gedaqtests.int64arrayint641m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Int64)}, 
    {mi_id:Int32},
    {mi_value:Array(Int64)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArrayArrayInt64)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
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
                    await ((IInt64ArrayArrayInt64)this).InsertModelDbConnectionAsync(
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
                     ((IInt64ArrayArrayInt64)this).InsertModelDbConnection(
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
FROM gedaqtests.int64arrayint641m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int64ArrayInt641M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArrayArrayInt64)),
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
                    var models = await ((IInt64ArrayArrayInt64)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64ArrayInt641M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt64ArrayArrayInt64)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64ArrayInt641M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

