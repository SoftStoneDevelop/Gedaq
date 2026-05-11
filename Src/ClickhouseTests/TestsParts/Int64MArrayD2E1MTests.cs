

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
    internal partial interface IInt64MArrayMArrayD2
    {
    }
    
    internal partial class Int64MArrayMArrayD2 : IInt64MArrayMArrayD2
    {


#region TestData

        private readonly Int64MArrayD2E1M[] _testData = new Int64MArrayD2E1M[]
        {
            new Int64MArrayD2E1M
{
    Id = 9,
    Value = 
new System.Int64[,] { { 1298667451017126972L, 4263233995873811768L, }, { 7813309405324413836L, 3382653398228965154L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Int64[,] { { 7148117304113548812L, 1428300330480587484L, }, { 4992661660227180346L, 7447517303078472709L, }, },
    NullableValue = 
new System.Int64[,] { { 42258388818905529L, 3112165354494421284L, }, { 3510658812288614044L, 9103989176551789090L, }, },
},
    NullableValue = 
new System.Int64[,] { { 6660601589449640062L, 9151570791395253421L, }, { 146566463607225351L, 4833581367872096695L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 10,
    Value = 
new System.Int64[,] { { 1629407241286589198L, 8664768514714805192L, }, { 39147828466038996L, 6239963455994544316L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 14,
    Value = 
new System.Int64[,] { { 2416790219740553557L, 2382586735652117695L, }, { 5138781911735274347L, 5224520013944663124L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 7275564569116648215L, 448165802446824846L, }, { 139582512137077902L, 4499342512403005483L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 16,
    Value = 
new System.Int64[,] { { 2491374121895458620L, 4950977006152642118L, }, { 8159756677112839607L, 7097672887455553131L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Int64[,] { { 2357675834730180558L, 3735179645217484000L, }, { 665647015965486919L, 9125295428271869050L, }, },
    NullableValue = 
new System.Int64[,] { { 8303570879396861527L, 7903216039146972536L, }, { 2464306635329512642L, 1366882472539115026L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 21,
    Value = 
new System.Int64[,] { { 7578346736783857779L, 3661038619436947294L, }, { 896534477898450330L, 7911720043196727201L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Int64[,] { { 296392725755719739L, 489581824490931391L, }, { 8578795738154932100L, 6039295345676878505L, }, },
    NullableValue = 
new System.Int64[,] { { 6542608223875539760L, 2500970677364769595L, }, { 8518996518461442719L, 6122879292585007740L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 23,
    Value = 
new System.Int64[,] { { 2929781814951830977L, 7269692335849226012L, }, { 1663515221247156935L, 4575110080762540688L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Int64[,] { { 4706462217001631670L, 3528783436943431941L, }, { 6323055668130788363L, 8013746194049302520L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 4513367976408687680L, 8352431187202218648L, }, { 1192937159589643355L, 3059853546983583311L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 31,
    Value = 
new System.Int64[,] { { 4811381152931000318L, 9128039784024589976L, }, { 2650850474433953723L, 7533007468200286803L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Int64[,] { { 7907542576523963467L, 1352536460334730716L, }, { 2189451176748333220L, 4624638003735905829L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 1805727084117312530L, 3280244455414152493L, }, { 5557873881579745598L, 7741791641073538389L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 38,
    Value = 
new System.Int64[,] { { 2249517365420906160L, 7361347211339238817L, }, { 6157346294974302551L, 8574156398487320381L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Int64[,] { { 6791921979686648431L, 8669191683334410654L, }, { 2752622478735054847L, 6805312581327318751L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6596875457293998949L, 5148268762338910932L, }, { 7394474636663251283L, 4992001101125860693L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 44,
    Value = 
new System.Int64[,] { { 8754165208476359287L, 3604759963983290690L, }, { 4853589161533477125L, 384643426315017680L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Int64[,] { { 1031868301895539022L, 6137922626701409590L, }, { 3728083387277870312L, 2508205367129343911L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 47,
    Value = 
new System.Int64[,] { { 610185230116637525L, 8592152800217647378L, }, { 1932975118450541326L, 6875051960674884184L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Int64[,] { { 1229906424935748581L, 4855118205199686544L, }, { 4427963494173336305L, 3481403908809690092L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 666214569482813636L, 343269945576489263L, }, { 8385672742990635680L, 909850074304725941L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 51,
    Value = 
new System.Int64[,] { { 5929158104649924827L, 3965163596415820299L, }, { 549433656460863145L, 446628774196074093L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Int64[,] { { 7715862128673849085L, 4396396208968333500L, }, { 251107241318368881L, 8178973303443989831L, }, },
    NullableValue = 
new System.Int64[,] { { 5021318064721866873L, 6489295634691663800L, }, { 2116844360743939334L, 5845584981352305095L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 53,
    Value = 
new System.Int64[,] { { 5663601189604439020L, 8285280215173622615L, }, { 990656500157706537L, 1258973153890829446L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Int64[,] { { 1001049865246884150L, 1135703263060008006L, }, { 5384555130357095090L, 384454207230250262L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 8972161735573297090L, 2236986068826372013L, }, { 2258488997584373930L, 8052315054343793883L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 62,
    Value = 
new System.Int64[,] { { 5465310309339371411L, 7682522472607657969L, }, { 4507922805497455782L, 8783760411376649365L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 78,
    Value = 
new System.Int64[,] { { 6624273788195025825L, 1567563716633937339L, }, { 5896933363116245966L, 8399223741254953989L, }, },
    NullableValue = 
new System.Int64[,] { { 887577995362154502L, 5260433280627343833L, }, { 8035963262510001081L, 8562832555611169261L, }, },
},
    NullableValue = 
new System.Int64[,] { { 4498293084031585129L, 3112801993398557990L, }, { 2373918183531135317L, 6395457760128696706L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 70,
    Value = 
new System.Int64[,] { { 7780264966043295292L, 3828146474174375601L, }, { 234286669571962244L, 5013295341872858340L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Int64[,] { { 4866075166369261938L, 2178716911859608372L, }, { 9170213898465423114L, 1753584662001436251L, }, },
    NullableValue = 
new System.Int64[,] { { 1779505898974726970L, 8884002706846030608L, }, { 8487767302301154837L, 7428251983315263737L, }, },
},
    NullableValue = 
new System.Int64[,] { { 5650599008914083989L, 3304646008827436664L, }, { 2805177627720677456L, 3537181446971318882L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 79,
    Value = 
new System.Int64[,] { { 8479745225391489638L, 2589558354691234914L, }, { 3007415112545435172L, 1830090799781809151L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Int64[,] { { 2437185397308145039L, 8930828374301542385L, }, { 5042527164633761602L, 9042380686705350720L, }, },
    NullableValue = 
new System.Int64[,] { { 3079193757195151159L, 881408693266960155L, }, { 8144774232891039126L, 7333320989217000575L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2747849614128161500L, 2495600987937554352L, }, { 276697851742879389L, 8595473937590561400L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 85,
    Value = 
new System.Int64[,] { { 4728574984818545631L, 4878267419029750469L, }, { 3201615717982521197L, 1940245844205262461L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 94,
    Value = 
new System.Int64[,] { { 8399051840023919937L, 4274153798157388670L, }, { 2713755196717987074L, 3147360077898812245L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 90,
    Value = 
new System.Int64[,] { { 245915344014201478L, 7165476673689107196L, }, { 8054691513303336750L, 9179257878282899999L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 100,
    Value = 
new System.Int64[,] { { 4527539448822384534L, 2515112840995878758L, }, { 2174959640754683432L, 4110691901875634795L, }, },
    NullableValue = 
new System.Int64[,] { { 7714249441733070211L, 7735776352942165826L, }, { 7657879546720448594L, 6958418004300304756L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 99,
    Value = 
new System.Int64[,] { { 7799745443017399247L, 6491629200168507197L, }, { 8519232915188247425L, 7994852287308825744L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 109,
    Value = 
new System.Int64[,] { { 5597032297813424952L, 2695680476933434988L, }, { 6028848157926884272L, 699417100865517482L, }, },
    NullableValue = 
new System.Int64[,] { { 643198402150636600L, 5769036480911281888L, }, { 3906119667073327927L, 6518279240458396563L, }, },
},
    NullableValue = 
new System.Int64[,] { { 185421746615410787L, 2153478280520293826L, }, { 5218177795123881085L, 6284344571895514950L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 108,
    Value = 
new System.Int64[,] { { 5530057580358739046L, 8377117468742589650L, }, { 3355058015778816303L, 2177932279141995138L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 118,
    Value = 
new System.Int64[,] { { 5290055428025602991L, 2128812072342956818L, }, { 8951574570544778785L, 2532723702121753604L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 113,
    Value = 
new System.Int64[,] { { 4850404571242047946L, 1575886807650754804L, }, { 8085546900617266890L, 5864423208332936353L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 119,
    Value = 
new System.Int64[,] { { 1338844193608707640L, 3763147174454466096L, }, { 5009644959391107335L, 2939480920528234175L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 120,
    Value = 
new System.Int64[,] { { 6561320048609496649L, 3376019017671580546L, }, { 4278073579538308005L, 8167259174295048006L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 124,
    Value = 
new System.Int64[,] { { 3185988682901997101L, 5109533371508367814L, }, { 30444187455972451L, 8485468674134630657L, }, },
    NullableValue = 
new System.Int64[,] { { 6581471685762359955L, 6579046518100010562L, }, { 3224040040760945608L, 5573013270482626777L, }, },
},
    NullableValue = 
new System.Int64[,] { { 6470977260537195991L, 6253046103678449608L, }, { 5974312658466129128L, 5050455960821397164L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 125,
    Value = 
new System.Int64[,] { { 2928995320113486952L, 4574528681177599125L, }, { 5974401061767055735L, 2481893762438238976L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 130,
    Value = 
new System.Int64[,] { { 1548788154138774139L, 262918309025198236L, }, { 5059219962726355660L, 6707550233366130051L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 215886231494927390L, 7909258374254458167L, }, { 448031762328432290L, 5189999706735886616L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 132,
    Value = 
new System.Int64[,] { { 3886692697270135546L, 6930051904811670451L, }, { 995180894849454119L, 3655705985879894881L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 139,
    Value = 
new System.Int64[,] { { 3545246474978879620L, 2473776916115406486L, }, { 4514237485114730958L, 7657037245486530180L, }, },
    NullableValue = 
new System.Int64[,] { { 7447798734364497007L, 912942725434937400L, }, { 1426134329351095954L, 8239250907233993755L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 141,
    Value = 
new System.Int64[,] { { 9006927047522096521L, 5447261139597099932L, }, { 9214885023140794999L, 2534002156739805406L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.Int64[,] { { 3014436502092629615L, 4547174052172339562L, }, { 7349884215620467316L, 5222464729592822862L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 147,
    Value = 
new System.Int64[,] { { 1897529490840791200L, 4502854808376582948L, }, { 1120379827172977359L, 5825617397614972927L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 148,
    Value = 
new System.Int64[,] { { 6089115200802179050L, 4755600485182488865L, }, { 4888677839256177492L, 9094122941925837476L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 155,
    Value = 
new System.Int64[,] { { 4072540847126652059L, 2051585768749130219L, }, { 3548155201450395606L, 4290362345862948600L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 156,
    Value = 
new System.Int64[,] { { 5970732220336815885L, 4869660926568504348L, }, { 3973679051053578144L, 8141531240107774797L, }, },
    NullableValue = 
new System.Int64[,] { { 354291501924350913L, 1228393864474634142L, }, { 6843396471952469305L, 2776228685080338735L, }, },
},
    NullableValue = 
new System.Int64[,] { { 5847962053195332891L, 8305879593190112080L, }, { 5806424697411091591L, 6557954087002779123L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 163,
    Value = 
new System.Int64[,] { { 3088585169761580L, 3097411315186299438L, }, { 3498393918608990711L, 8457179881094756435L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 161,
    Value = 
new System.Int64[,] { { 7112625604867989402L, 1830447345631861800L, }, { 7858407041145535343L, 7046652183049063214L, }, },
    NullableValue = 
new System.Int64[,] { { 6438269583178372744L, 8278615869566827496L, }, { 4470387727177772434L, 5215012568627971552L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 168,
    Value = 
new System.Int64[,] { { 345272713697188238L, 9118067611626896600L, }, { 653500747016161010L, 1519360357847276643L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 170,
    Value = 
new System.Int64[,] { { 2889468982596907543L, 5527127624501371245L, }, { 1227477776821781580L, 619421001729454482L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 172,
    Value = 
new System.Int64[,] { { 3586301289582213313L, 5973065371885255336L, }, { 2952106810650944652L, 3970685821213637134L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 173,
    Value = 
new System.Int64[,] { { 3493772319254245682L, 3793930666838546619L, }, { 4586109462090585904L, 6091526817727272230L, }, },
    NullableValue = 
new System.Int64[,] { { 7652509279792845036L, 4879185358940582017L, }, { 2317405082543698565L, 8531104841734402464L, }, },
},
    NullableValue = 
new System.Int64[,] { { 50228694465492024L, 8524455435069714875L, }, { 7188810245649249897L, 1705693128174192983L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 180,
    Value = 
new System.Int64[,] { { 1761786313551828934L, 8860410439841080523L, }, { 8419677265777955650L, 3706946679225709785L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 179,
    Value = 
new System.Int64[,] { { 5561048869414095437L, 8753151880292968241L, }, { 2055274873578195075L, 3383929055302364972L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 3337865380751564941L, 3551733764848946581L, }, { 7777644906826288834L, 6294200967520048378L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 188,
    Value = 
new System.Int64[,] { { 29060104039013225L, 1746535227661730919L, }, { 5948332051775947577L, 473496153236099047L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 187,
    Value = 
new System.Int64[,] { { 5767466356480579416L, 7968063980385049823L, }, { 2098130583961276277L, 5099508941374023845L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 227291783249243784L, 859338284096494188L, }, { 790827289669918713L, 3293227717623496448L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 192,
    Value = 
new System.Int64[,] { { 1438226843824014693L, 7926989664676914264L, }, { 5405728951146588531L, 663432753050463891L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 196,
    Value = 
new System.Int64[,] { { 3533059548683227046L, 6148540544105160798L, }, { 9158300669289761964L, 6716430609252803502L, }, },
    NullableValue = 
new System.Int64[,] { { 717798912562268229L, 8128623983911887074L, }, { 425179781251775010L, 7832157593350003306L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 196,
    Value = 
new System.Int64[,] { { 4393358740144273245L, 1940677266555054620L, }, { 5267041386140550736L, 8967227888623786495L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 203,
    Value = 
new System.Int64[,] { { 3120636893958339750L, 5469537609063529568L, }, { 1309070224729615059L, 5737770872516924556L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 203,
    Value = 
new System.Int64[,] { { 6176418854933101416L, 6188334573683541636L, }, { 8641345857036784854L, 9011032037797536689L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 204,
    Value = 
new System.Int64[,] { { 7058842471873244730L, 1748747901338532392L, }, { 3609006564853450856L, 3359675264165544739L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 3292939390734005060L, 4128177790306310222L, }, { 4729746833527498218L, 8001292589414548706L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 204,
    Value = 
new System.Int64[,] { { 3113439486456744560L, 4530976272681432551L, }, { 1425488331904679991L, 3714904556707841955L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 210,
    Value = 
new System.Int64[,] { { 3998719068454703192L, 7482036775357735769L, }, { 6661316756240472847L, 4932967517688484485L, }, },
    NullableValue = 
new System.Int64[,] { { 5482315089998942827L, 3489518362584903797L, }, { 1720359962990489275L, 2117877722917331870L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2298021897135222897L, 8217280032731357135L, }, { 1230896405771394680L, 8966615000819128440L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 205,
    Value = 
new System.Int64[,] { { 7339394195694622808L, 917125708032199191L, }, { 267671749726504484L, 3376279087538497493L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 214,
    Value = 
new System.Int64[,] { { 2142170238008120678L, 5470178571289320130L, }, { 7077278427124044341L, 5266332891112968565L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 1370817709750586992L, 5565227252898372103L, }, { 5365625426342215077L, 6861230773699360936L, }, },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(Int64))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(Int64))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64[,]), 
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
                    await ((IInt64MArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IInt64MArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.int64marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int64MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArrayMArrayD2)),
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
                    var models = await ((IInt64MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt64MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

