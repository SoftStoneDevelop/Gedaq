

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
    Id = 6,
    Value = 
new System.Int64[,] { { 2343131354752897828L, 1204481367648339266L, }, { 1987175785284457295L, 4775828918647230548L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 5,
    Value = 
new System.Int64[,] { { 7119665663725409664L, 2878031876028364962L, }, { 7662625499428999865L, 1465778707812861807L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 10,
    Value = 
new System.Int64[,] { { 4480312320547033792L, 3254311587571463510L, }, { 3372476893021285293L, 7608084679642409674L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Int64[,] { { 8266660798484537243L, 3965622368326574749L, }, { 7997386402647065759L, 8719631903952486943L, }, },
    NullableValue = 
new System.Int64[,] { { 1689034064517225173L, 2397216123698457726L, }, { 3916458364123395145L, 4100148198981886913L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 12,
    Value = 
new System.Int64[,] { { 8452635355565210901L, 8552308555004663502L, }, { 4013116148485063981L, 7229677828682422889L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 15,
    Value = 
new System.Int64[,] { { 8213927921642552148L, 2932455621041066499L, }, { 2830894067335597491L, 8462794869771844672L, }, },
    NullableValue = 
new System.Int64[,] { { 8913281954893671253L, 4165706065509991206L, }, { 5939268442612413190L, 6590801166097509690L, }, },
},
    NullableValue = 
new System.Int64[,] { { 6856235746846853962L, 2114049067449356553L, }, { 7799523840498907374L, 7308640718633951429L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 19,
    Value = 
new System.Int64[,] { { 7208704884729693873L, 821390356885863313L, }, { 2110856343336264953L, 3222058092903963264L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Int64[,] { { 2192822764363452879L, 6164647855850464765L, }, { 2945525378335514696L, 44775401245460072L, }, },
    NullableValue = 
new System.Int64[,] { { 6571109852133294413L, 2346189931643224039L, }, { 6227811092640978815L, 3162581702354102673L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2820772612794346061L, 3256459630055039313L, }, { 4375129304144074166L, 810149692933783799L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 25,
    Value = 
new System.Int64[,] { { 403324921261906016L, 6596188854673722277L, }, { 6162400231539021349L, 2893583078892796237L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Int64[,] { { 2755348955997921918L, 3904493755134178895L, }, { 3769207307196777818L, 5182452975336718409L, }, },
    NullableValue = 
new System.Int64[,] { { 8303186459968701665L, 1033791078290799109L, }, { 2456234577773169224L, 145620442330205488L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2378496628857335760L, 8958455174539044357L, }, { 9103463691912102372L, 9083244011852207192L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 29,
    Value = 
new System.Int64[,] { { 1433546039808486577L, 2788463679199692271L, }, { 5735041410423929669L, 4833522247156785683L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Int64[,] { { 3068874968991597333L, 2974616538397163767L, }, { 8498631338165768120L, 590134534519814378L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 5586564922065310735L, 105271111388124726L, }, { 5530273567425125575L, 8708917294867679928L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 35,
    Value = 
new System.Int64[,] { { 7904813071777752895L, 7546034422642876093L, }, { 8964421520676111028L, 3265741667703287705L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Int64[,] { { 8750510687939185796L, 7491926966114356282L, }, { 4512513958577907115L, 7599524932776133912L, }, },
    NullableValue = 
new System.Int64[,] { { 7448967486901237259L, 3038332377640859616L, }, { 88547669359922923L, 8754412314620387722L, }, },
},
    NullableValue = 
new System.Int64[,] { { 6099630396609680352L, 2330822165576605676L, }, { 8214016672398384079L, 8415617943200996793L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 43,
    Value = 
new System.Int64[,] { { 8950255071172143713L, 8214150085683461093L, }, { 4966018938891153186L, 7107476625203091318L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Int64[,] { { 7493770263742609640L, 2574943376825519450L, }, { 4629232527207245819L, 5555302803911490506L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 52,
    Value = 
new System.Int64[,] { { 9083261918485759067L, 8643271188827249991L, }, { 2983054267417495324L, 2147571164459562706L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Int64[,] { { 6540997123941717863L, 5237138636127632513L, }, { 4479137067812851913L, 7208010767840029704L, }, },
    NullableValue = 
new System.Int64[,] { { 2584092276005032465L, 161883139484668826L, }, { 3406640735638415199L, 8191216678826132147L, }, },
},
    NullableValue = 
new System.Int64[,] { { 7499017262386719613L, 714895450933824569L, }, { 3236951379634243225L, 3197981891445368042L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 60,
    Value = 
new System.Int64[,] { { 951628324458044646L, 1033001354002984125L, }, { 8230348638682644479L, 3519027633720656018L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Int64[,] { { 4664834289835591827L, 7752571337175153599L, }, { 6111129314604540733L, 8308730938471364900L, }, },
    NullableValue = 
new System.Int64[,] { { 1677704170048905280L, 7363236103020961623L, }, { 358277644794694389L, 389700638039647364L, }, },
},
    NullableValue = 
new System.Int64[,] { { 4012812340414144072L, 4324324997939276494L, }, { 2074279033104338507L, 6462883182300107774L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 67,
    Value = 
new System.Int64[,] { { 4607135770933590912L, 829565053710478250L, }, { 6428775333142999458L, 186023255556918392L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 42,
    Value = 
new System.Int64[,] { { 5665231077755292948L, 4348414573852445051L, }, { 4500925147308266601L, 1816805548695687004L, }, },
    NullableValue = 
new System.Int64[,] { { 3725080491356333554L, 5121904061269926873L, }, { 3443873066639725032L, 4053283066654234497L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 71,
    Value = 
new System.Int64[,] { { 6324176719570440546L, 5569787805518095629L, }, { 254273460080225753L, 4140928944437198508L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Int64[,] { { 4127037316804474094L, 6311736018682611975L, }, { 2003701758900693029L, 1140378018889877051L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 2301770106077722713L, 768076609530118895L, }, { 7490083470126892133L, 8664374785338557064L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 76,
    Value = 
new System.Int64[,] { { 5240352170075314940L, 8390472557865413518L, }, { 4292006537211243929L, 5613085967218741755L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Int64[,] { { 7532690034152885170L, 7057539834705826430L, }, { 6675546832148692342L, 9023210335044600261L, }, },
    NullableValue = 
new System.Int64[,] { { 6472066849229868266L, 1702332676798377423L, }, { 8360434319847452212L, 6300454909741104682L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 83,
    Value = 
new System.Int64[,] { { 3283144752757660750L, 8709854839688847460L, }, { 1079328590916027078L, 8609859244467082718L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 62,
    Value = 
new System.Int64[,] { { 4946680332428904317L, 1515479917424974479L, }, { 5261746230428042321L, 2137587629168829069L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 84,
    Value = 
new System.Int64[,] { { 6889823476172026972L, 1147310302472607721L, }, { 1650229719381164411L, 8614910942950972664L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Int64[,] { { 635440425546074530L, 7094417936016400424L, }, { 5916861919693310932L, 8137524706365383269L, }, },
    NullableValue = 
new System.Int64[,] { { 4790748378737026363L, 2849088829523234367L, }, { 4149471174481451866L, 6236416540753871288L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 85,
    Value = 
new System.Int64[,] { { 1429504709828385906L, 3926455019661152897L, }, { 4736856559600713934L, 8163016492523239994L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 80,
    Value = 
new System.Int64[,] { { 2652048800793253810L, 469598626707304284L, }, { 315235867783553632L, 7893754626969991196L, }, },
    NullableValue = 
new System.Int64[,] { { 1904471023196427287L, 6438051060886069311L, }, { 7903965510559410934L, 391632647716004551L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 93,
    Value = 
new System.Int64[,] { { 5213118416608906608L, 805032743088791179L, }, { 1143912353420464324L, 6833486876982418090L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Int64[,] { { 6262448832540663392L, 6940877612256800861L, }, { 222204055122350486L, 92050728731172479L, }, },
    NullableValue = 
new System.Int64[,] { { 5864185173197177351L, 2557990638018508197L, }, { 3287813967905842901L, 2039913965969302957L, }, },
},
    NullableValue = 
new System.Int64[,] { { 8041730169645388588L, 7883466182842804830L, }, { 3970740518642967762L, 591355380502125013L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 96,
    Value = 
new System.Int64[,] { { 2623512052846482619L, 346819979292733062L, }, { 8305665774584559374L, 5671852221338474371L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 89,
    Value = 
new System.Int64[,] { { 933917909993575741L, 6415516533299046075L, }, { 8823871574195289454L, 8579977426348518592L, }, },
    NullableValue = 
new System.Int64[,] { { 1841278348162043031L, 7943341524769447833L, }, { 5277318593043339699L, 2141602497047354711L, }, },
},
    NullableValue = 
new System.Int64[,] { { 758875715268723102L, 7719065771921025572L, }, { 5405794589201221915L, 474240971248212504L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 97,
    Value = 
new System.Int64[,] { { 4105911518229742590L, 3019074810153410445L, }, { 2869241430175691179L, 5986399635504559055L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Int64[,] { { 7126044985661321761L, 3781799637386199345L, }, { 3644298126698525364L, 4607172034610281181L, }, },
    NullableValue = 
new System.Int64[,] { { 9153435405621812307L, 3022991269409956923L, }, { 4330886201141987655L, 818470798457526016L, }, },
},
    NullableValue = 
new System.Int64[,] { { 5866954146201544476L, 5533596831216915966L, }, { 6743389376021781835L, 5483918621213447739L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 102,
    Value = 
new System.Int64[,] { { 3575775505264731864L, 2324669883991141504L, }, { 4367698441565398325L, 1323121299425259377L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 100,
    Value = 
new System.Int64[,] { { 149164370034078187L, 6746502099427579755L, }, { 7932708077262813739L, 222793865712944144L, }, },
    NullableValue = 
new System.Int64[,] { { 7140484697265786597L, 5897112986496941679L, }, { 6822066787636518852L, 2886886392544747526L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 105,
    Value = 
new System.Int64[,] { { 4955930607451694597L, 5945811541928986369L, }, { 2977802977477387805L, 836828922469544184L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 101,
    Value = 
new System.Int64[,] { { 3350179429152941532L, 6769329085081986507L, }, { 7895985650031268402L, 7919993322708666553L, }, },
    NullableValue = 
new System.Int64[,] { { 9073828587399068397L, 837020874960283617L, }, { 7816758988640545646L, 8110421257354821608L, }, },
},
    NullableValue = 
new System.Int64[,] { { 9038092300337268896L, 7797759950978432035L, }, { 5478535788888769376L, 3419119403565526588L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 112,
    Value = 
new System.Int64[,] { { 8423471237176784289L, 2356580650805871386L, }, { 978713690014044511L, 4819393787860528610L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 105,
    Value = 
new System.Int64[,] { { 2009500897154669867L, 3766146271771847135L, }, { 4428188197304626445L, 5967689446615817882L, }, },
    NullableValue = 
new System.Int64[,] { { 7916039473049696256L, 2889981742510492572L, }, { 3979686912311730368L, 1309715237246744816L, }, },
},
    NullableValue = 
new System.Int64[,] { { 4471942173511179730L, 1384648059873387729L, }, { 8244566906070882141L, 1105854177105191271L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 118,
    Value = 
new System.Int64[,] { { 2863302817928470349L, 6721233977804062175L, }, { 1893382753711593459L, 5183840588633766608L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 108,
    Value = 
new System.Int64[,] { { 6102856190364574969L, 9128265367763803493L, }, { 4673568560274877216L, 294522406980215466L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 8637709851403630000L, 2590409107120540539L, }, { 7165633629389620231L, 3492556220556019743L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 126,
    Value = 
new System.Int64[,] { { 5189632234875740170L, 9087340557943021537L, }, { 796011836146055524L, 1741185947083294712L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 116,
    Value = 
new System.Int64[,] { { 3213761290577353596L, 1021704433023397797L, }, { 2846715877821461288L, 7624426427751354056L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 127,
    Value = 
new System.Int64[,] { { 7252192452331284076L, 384481232224781225L, }, { 8463146598203424920L, 8943193052774899882L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 125,
    Value = 
new System.Int64[,] { { 8922788012695883264L, 56663723717940011L, }, { 322204001429413415L, 3530766972678667992L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6152091954636241115L, 6617524104751829430L, }, { 7297388951081668418L, 755134834433995876L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 136,
    Value = 
new System.Int64[,] { { 4198495429087733201L, 3452542437653656275L, }, { 1503994246226997086L, 1173402598380680023L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 130,
    Value = 
new System.Int64[,] { { 1465193934962065675L, 5387000085516128448L, }, { 3784784327962661227L, 8729863995395609286L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 143,
    Value = 
new System.Int64[,] { { 8346184822509803834L, 3044325649166049065L, }, { 4887034262679340751L, 7953538392482546419L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 137,
    Value = 
new System.Int64[,] { { 2863580598536390508L, 8075970399719621384L, }, { 981784191885397476L, 3815353462112630023L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 8390480095559098147L, 4225269207982031553L, }, { 976637129243494514L, 7153557099439521428L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 146,
    Value = 
new System.Int64[,] { { 2907364897131640499L, 1391212108456446296L, }, { 7134349947064177257L, 1027617367379739611L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 140,
    Value = 
new System.Int64[,] { { 4059357173272644097L, 3308936559957441441L, }, { 4014685785454076296L, 2650901712106824199L, }, },
    NullableValue = 
new System.Int64[,] { { 8376161366410527875L, 3421700833677615246L, }, { 4819027752004897927L, 2008088733263530887L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 149,
    Value = 
new System.Int64[,] { { 7880713860066997341L, 5619524776497932758L, }, { 6484203360270515773L, 213938819475436753L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 147,
    Value = 
new System.Int64[,] { { 2466134191206477129L, 7735492697938202746L, }, { 66679896221051532L, 3749746428873200391L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 151,
    Value = 
new System.Int64[,] { { 3941036160986972810L, 9205097678933686131L, }, { 7623323321160713518L, 8221104297639735762L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 148,
    Value = 
new System.Int64[,] { { 7293173692993926169L, 4724657350451902165L, }, { 7577453331294581183L, 8158062967333846695L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 3651118502030418381L, 2712640629287655115L, }, { 6651180926674835603L, 1848089808705094763L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 158,
    Value = 
new System.Int64[,] { { 2743456655346514229L, 8205039749490332310L, }, { 529261217628257662L, 1435992328868929884L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 156,
    Value = 
new System.Int64[,] { { 8856965992701239930L, 1979264893748603026L, }, { 4722400888525110101L, 7134653386865616728L, }, },
    NullableValue = 
new System.Int64[,] { { 8558753193494074380L, 6569036610443455703L, }, { 3224903171894884611L, 7955459570298907572L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 164,
    Value = 
new System.Int64[,] { { 5856790695931576269L, 8817569697445104649L, }, { 3959794935876492628L, 1175379964839114022L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 161,
    Value = 
new System.Int64[,] { { 8317888197859697426L, 5197747555475935701L, }, { 2817990610447358188L, 7385762528609061286L, }, },
    NullableValue = 
new System.Int64[,] { { 1236585509519241634L, 7333960246386373075L, }, { 7330663189827654252L, 8338782827418784320L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 169,
    Value = 
new System.Int64[,] { { 8113073514927386370L, 5231599301626435173L, }, { 1847468038725963913L, 601564532728979987L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 163,
    Value = 
new System.Int64[,] { { 3608671567358801488L, 8316401527394093921L, }, { 8777143076956612966L, 4027374586386757095L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 170,
    Value = 
new System.Int64[,] { { 5826204736562493158L, 8534200466601022546L, }, { 8730099809169378364L, 1903133550490454698L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 166,
    Value = 
new System.Int64[,] { { 4534903987973126463L, 3015322496084056221L, }, { 3384539434848811328L, 7984281993917897484L, }, },
    NullableValue = 
new System.Int64[,] { { 3285344691544185677L, 5819554821002346424L, }, { 4962419454381907047L, 4590997855211578638L, }, },
},
    NullableValue = 
new System.Int64[,] { { 256054781501591224L, 2371348135539840707L, }, { 5203481086230397554L, 1130095035853121821L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 174,
    Value = 
new System.Int64[,] { { 3453871710666926443L, 419539394250262123L, }, { 6259656437427095349L, 8980031285464379269L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 175,
    Value = 
new System.Int64[,] { { 1022852640614533765L, 3562103812377460566L, }, { 7719445010658240929L, 4235049150825900804L, }, },
    NullableValue = 
new System.Int64[,] { { 9171068874557791678L, 8057746667157287649L, }, { 5692150523893067265L, 51137153039873631L, }, },
},
    NullableValue = 
new System.Int64[,] { { 4141220736463004979L, 9129293232566737487L, }, { 3804990357633351843L, 4582332167520226399L, }, },
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

