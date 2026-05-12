

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
    internal partial interface IUInt64MArrayMArrayD2
    {
    }
    
    internal partial class UInt64MArrayMArrayD2 : IUInt64MArrayMArrayD2
    {


#region TestData

        private readonly UInt64MArrayD2E1M[] _testData = new UInt64MArrayD2E1M[]
        {
            new UInt64MArrayD2E1M
{
    Id = 4,
    Value = 
new System.UInt64[,] { { 3506331922468369279L, 6009854187860758765L, }, { 3222267258295162545L, 2230333030236657182L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 9,
    Value = 
new System.UInt64[,] { { 7395460617145424307L, 9169163865108057717L, }, { 4419659979123042563L, 5104620000958667347L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 8157771147141706041L, 6556838596779980707L, }, { 8609141764364733454L, 8266247070306583432L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 12,
    Value = 
new System.UInt64[,] { { 1554755285398149887L, 8450430230590359391L, }, { 3008584722045401502L, 1244239171262386816L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 13,
    Value = 
new System.UInt64[,] { { 8644560818161373100L, 3114570946925985993L, }, { 3068256623246317621L, 4716246071793377784L, }, },
    NullableValue = 
new System.UInt64[,] { { 2145831405543974610L, 5161970611369309173L, }, { 6232382884666214086L, 1443719145247833950L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 14,
    Value = 
new System.UInt64[,] { { 6036653769224021291L, 6130138572201458599L, }, { 217675931677849290L, 8731043497117202467L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 16,
    Value = 
new System.UInt64[,] { { 678747770632320010L, 2196967182427212692L, }, { 6971927408490946276L, 3092468825251986337L, }, },
    NullableValue = 
new System.UInt64[,] { { 2035781932109576282L, 6933191699541207474L, }, { 9035249214475655175L, 2968364710532735089L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 19,
    Value = 
new System.UInt64[,] { { 158569427268746977L, 5105782098256028609L, }, { 6048362307178484304L, 7558739957877181669L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.UInt64[,] { { 8153368004224397526L, 3265684886135104748L, }, { 2445808724176624968L, 9174572372144157710L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 8263332772725415646L, 5059481416192354414L, }, { 4285041575757795756L, 9137698557294394954L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 26,
    Value = 
new System.UInt64[,] { { 2654448024594777871L, 6944524051297403269L, }, { 7754800895864319543L, 5430444666294308360L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 31,
    Value = 
new System.UInt64[,] { { 5484566526391038905L, 1226394326494834672L, }, { 2426316023003449736L, 885682074702178922L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 28,
    Value = 
new System.UInt64[,] { { 1344152429249029107L, 7735246627972945759L, }, { 6286229178228803581L, 4747208483507266200L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 35,
    Value = 
new System.UInt64[,] { { 6350119478645193381L, 5917550855579417002L, }, { 8572088757965366624L, 2293718263807841732L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 4804534862537873945L, 320146871317612945L, }, { 5073816193092191710L, 683666081058202053L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 37,
    Value = 
new System.UInt64[,] { { 8125294067050636305L, 487039975736532655L, }, { 7751309733414517037L, 8262983833486377792L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 37,
    Value = 
new System.UInt64[,] { { 1641787963805039186L, 5877511888291801203L, }, { 2182794755843834003L, 2944210746526101880L, }, },
    NullableValue = 
new System.UInt64[,] { { 1180240818553803330L, 5885965506495984704L, }, { 1279778766924034956L, 4839538026960418948L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 42,
    Value = 
new System.UInt64[,] { { 3430711796867856986L, 6859082348352588554L, }, { 2388077200658745968L, 6078310445594761663L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 44,
    Value = 
new System.UInt64[,] { { 7236221031543848356L, 8311683054345394356L, }, { 6433881880867329300L, 890161905329699018L, }, },
    NullableValue = 
new System.UInt64[,] { { 6877978221250206071L, 6960931324563044149L, }, { 4039687031334694018L, 7505861129822857021L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 2451911628270013490L, 3297289084901919918L, }, { 4803633704417608618L, 5674769185229514317L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 45,
    Value = 
new System.UInt64[,] { { 3432325066512594173L, 9129470869491471536L, }, { 1334620782459005771L, 1842513980512729491L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.UInt64[,] { { 7488949285145974529L, 388808752027566370L, }, { 7611490649219121546L, 1149932143992732184L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 46,
    Value = 
new System.UInt64[,] { { 2350615103926353470L, 3223763504220278720L, }, { 555349186863567531L, 3940503560532798442L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 54,
    Value = 
new System.UInt64[,] { { 6713742248651490200L, 1699071906187909274L, }, { 5270310361117344753L, 7037166648889363560L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 1010398062610251515L, 9037018002729035843L, }, { 8727348032737189944L, 4387687736960363171L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 52,
    Value = 
new System.UInt64[,] { { 335675781508530915L, 449700637618767939L, }, { 6150285728224904123L, 2869332910323746412L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 59,
    Value = 
new System.UInt64[,] { { 9158867838055953069L, 6929457800281960275L, }, { 5754262289556600199L, 2451405754834083928L, }, },
    NullableValue = 
new System.UInt64[,] { { 609674186035328807L, 1731548538784597706L, }, { 3664122353462646076L, 7594236310603045214L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 56,
    Value = 
new System.UInt64[,] { { 6460493743709895733L, 2602052746085912225L, }, { 3313923088878016510L, 7758012649512926232L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 65,
    Value = 
new System.UInt64[,] { { 2813208060579142052L, 415097645227923448L, }, { 6748599537069903841L, 3212242250285126410L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 4866668841879976200L, 4129396820111225961L, }, { 315586026857506723L, 5735935217816152317L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 57,
    Value = 
new System.UInt64[,] { { 5179061194143166472L, 4502367537165885313L, }, { 1434255945284644995L, 2694061092062336650L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 72,
    Value = 
new System.UInt64[,] { { 2994364083971318308L, 7310558728723100019L, }, { 4615865732211262829L, 4781655973349855782L, }, },
    NullableValue = 
new System.UInt64[,] { { 857000777214193508L, 4930945857671051969L, }, { 770722606843215807L, 4109784746814934393L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 61,
    Value = 
new System.UInt64[,] { { 321527477712618764L, 5574394971573761155L, }, { 7454746423861415657L, 8506378220237036921L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 73,
    Value = 
new System.UInt64[,] { { 7509765141588265687L, 2666899523200304290L, }, { 6291533081971413361L, 2796584274244734211L, }, },
    NullableValue = 
new System.UInt64[,] { { 2923006435097179505L, 4016682565860283890L, }, { 4765021064990105994L, 5501409599269524616L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 5146973012715665590L, 5970081212502639333L, }, { 6175009187053672107L, 2767789155119386709L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 66,
    Value = 
new System.UInt64[,] { { 4639216499869056631L, 5257015864275223150L, }, { 5225639466799910339L, 1477393199577937844L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 76,
    Value = 
new System.UInt64[,] { { 3615528791196843114L, 5396350130353043183L, }, { 7049581180075871459L, 4964599775151885291L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 1936248390712834930L, 8598051072137754611L, }, { 1745609865963217549L, 4320725198369092005L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 69,
    Value = 
new System.UInt64[,] { { 469389844810224780L, 6749705807333922925L, }, { 7131451450304769165L, 7613853141281253195L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 77,
    Value = 
new System.UInt64[,] { { 5948543005618333248L, 3369719236136121343L, }, { 5188919415044538504L, 555291921221110954L, }, },
    NullableValue = 
new System.UInt64[,] { { 8695961646984769389L, 1267176078693451619L, }, { 7283994479174426061L, 6893048461273566636L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 8670371130755035387L, 7192485897135605340L, }, { 7056490645227834733L, 757330622852609994L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 78,
    Value = 
new System.UInt64[,] { { 4915248391363275097L, 6871327594389787233L, }, { 8870469975291373606L, 5020992571145478250L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 79,
    Value = 
new System.UInt64[,] { { 276348801796889398L, 5796771493049188990L, }, { 564067756519685697L, 6521382350441255600L, }, },
    NullableValue = 
new System.UInt64[,] { { 8114983191333809141L, 7187352974245932640L, }, { 2571461148876075075L, 4492405654740732065L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 6624533173434860684L, 5987372965999846439L, }, { 867958670404918702L, 4614236620749589583L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 87,
    Value = 
new System.UInt64[,] { { 1028673015461952326L, 425814823822665061L, }, { 7469795916609848469L, 1187593627902704205L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 83,
    Value = 
new System.UInt64[,] { { 7225979039282376480L, 2558187072806795137L, }, { 5526565322087642151L, 4355798818103791176L, }, },
    NullableValue = 
new System.UInt64[,] { { 1195452541948520661L, 7080432886652292150L, }, { 4901456660330833241L, 2044693657643119060L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 92,
    Value = 
new System.UInt64[,] { { 4428382389619706092L, 1257193899643280487L, }, { 4718731446112134238L, 4919896571783759709L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.UInt64[,] { { 6350330691647403439L, 7001271377101427021L, }, { 6067071257838380L, 250877756271968599L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 1653258267528911036L, 8092589586546314930L, }, { 7682972576160682703L, 8354588283104141067L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 96,
    Value = 
new System.UInt64[,] { { 7864399232116820630L, 5992709686907740596L, }, { 5323534965613849751L, 5744246765620026156L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 94,
    Value = 
new System.UInt64[,] { { 7573230983917775015L, 1019848102445751999L, }, { 4629268043594673539L, 160704280245340422L, }, },
    NullableValue = 
new System.UInt64[,] { { 1308258629530676515L, 5137994279815510777L, }, { 3181207136263724339L, 8995832336772737960L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 206016432269254903L, 1228932954999131870L, }, { 84782688735665884L, 5675446508559090241L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 98,
    Value = 
new System.UInt64[,] { { 3339808829436848334L, 146485994521050408L, }, { 825573000435947989L, 2925116897017375281L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 97,
    Value = 
new System.UInt64[,] { { 761796230304237089L, 1958765354954808120L, }, { 4602067519877204717L, 2067616602891059905L, }, },
    NullableValue = 
new System.UInt64[,] { { 7981551565264164476L, 7509936736521578875L, }, { 86195616320136896L, 8187976904768916182L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 382318983264607012L, 5135622611995811238L, }, { 9116317207497837138L, 8278789708004559760L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 103,
    Value = 
new System.UInt64[,] { { 5441845916064636318L, 5540562020151232706L, }, { 1395176381073912929L, 4643928981825582100L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 98,
    Value = 
new System.UInt64[,] { { 7748787708035265351L, 1359366504110711054L, }, { 2579073718197037592L, 1973560660101657435L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 3521366390983913717L, 5857752987930868770L, }, { 5632088148910962242L, 368529337175539624L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 109,
    Value = 
new System.UInt64[,] { { 2606218135649022611L, 664987040527163377L, }, { 8761816103519088631L, 3510901941048608905L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 105,
    Value = 
new System.UInt64[,] { { 4354567144256196702L, 1589631954769181601L, }, { 7820088392993677425L, 4348809943829053878L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 9188611883407962356L, 2753926738868265926L, }, { 896956942311914383L, 5353421505406839040L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 117,
    Value = 
new System.UInt64[,] { { 5403651003602269604L, 1242756910491598710L, }, { 3170150541179980068L, 6621462294799003665L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 110,
    Value = 
new System.UInt64[,] { { 4825600715361304425L, 3780965479085248007L, }, { 4844067580920024877L, 6110873517945008542L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 3529033365907006278L, 1721236667275731841L, }, { 854860655443969595L, 8365644513504168315L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 126,
    Value = 
new System.UInt64[,] { { 2234422963403722643L, 697865980630322686L, }, { 5115529633522050175L, 2312228321927438229L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 115,
    Value = 
new System.UInt64[,] { { 8427178751304465915L, 4009954000927086874L, }, { 5568375737611427155L, 3046928986436120726L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 134,
    Value = 
new System.UInt64[,] { { 6128416033272372827L, 4841082698387019744L, }, { 2058044996851868666L, 6267330745107190362L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 122,
    Value = 
new System.UInt64[,] { { 5809276468138525118L, 8189139348799089859L, }, { 1580677160465933422L, 7200408788555803272L, }, },
    NullableValue = 
new System.UInt64[,] { { 5605820335156787553L, 490367510817451381L, }, { 6534881083709194355L, 666679360820511572L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 840181518987142316L, 7865226192732325363L, }, { 6496115715195815327L, 3552240654739642050L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 139,
    Value = 
new System.UInt64[,] { { 6020630526226106524L, 9129331002029035594L, }, { 946152112416131435L, 7051323168461760992L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 124,
    Value = 
new System.UInt64[,] { { 461652685101165594L, 7396353868617574566L, }, { 268541776270315392L, 4574181551946823410L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 143,
    Value = 
new System.UInt64[,] { { 7257435608287405702L, 5383202086150547325L, }, { 4530742476737083094L, 5095773853859359321L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 133,
    Value = 
new System.UInt64[,] { { 9021098783702550362L, 7763216918971403907L, }, { 5394824289355465993L, 7326383100926429977L, }, },
    NullableValue = 
new System.UInt64[,] { { 2383786104799661436L, 505958885992714158L, }, { 6683449923102164148L, 903265886228499466L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 145,
    Value = 
new System.UInt64[,] { { 4153132062924562967L, 2411989839181527432L, }, { 8898427093183229339L, 1862852681054709653L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 136,
    Value = 
new System.UInt64[,] { { 7496726763374732041L, 2776098041987750141L, }, { 7453640035392571459L, 7301331504546177574L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 153,
    Value = 
new System.UInt64[,] { { 8065842486050658763L, 4781585696868181350L, }, { 5289420706042700738L, 2809877812291578999L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.UInt64[,] { { 7721786674246035079L, 4502440496678710817L, }, { 2456479133467121575L, 1658722867950919309L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 161,
    Value = 
new System.UInt64[,] { { 4965351389703963222L, 2998883144546130263L, }, { 9121015913393072379L, 6960676823857743465L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 147,
    Value = 
new System.UInt64[,] { { 6231972963650380503L, 4116795578790693202L, }, { 2794261264684479271L, 6798469079742864513L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 4042594308618796162L, 8843635278656136077L, }, { 3696050338987868498L, 2307241616403869574L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 166,
    Value = 
new System.UInt64[,] { { 9083201167882196324L, 5475084175798852074L, }, { 2679230560414148368L, 7662333392807637501L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 155,
    Value = 
new System.UInt64[,] { { 3823876744765500731L, 1107355466109708284L, }, { 2304827821202832480L, 8808823336262915958L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 5187016497391105184L, 2555580924357411102L, }, { 5017293821958697266L, 6832486777127652033L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 174,
    Value = 
new System.UInt64[,] { { 862958058187237586L, 1933739817446711981L, }, { 2128832433680380494L, 3307356958480388522L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 164,
    Value = 
new System.UInt64[,] { { 3481319442074824802L, 7120433791720732644L, }, { 5286813700210889879L, 8135405800313848358L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 7075001135914348844L, 7591143981045273703L, }, { 3049319825377414284L, 2702019262531947522L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 183,
    Value = 
new System.UInt64[,] { { 5422194830262350591L, 212006788391442216L, }, { 5070908539423391204L, 5905467866145579136L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 169,
    Value = 
new System.UInt64[,] { { 3893394529126400575L, 56104497622123885L, }, { 1687877767578653186L, 6332690041017685515L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 2377662522036989050L, 8750119120532166399L, }, { 1225493409476931031L, 6977613774427088515L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 186,
    Value = 
new System.UInt64[,] { { 161171567266115955L, 6790985626617774505L, }, { 2967260466486062030L, 347762699043484155L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 171,
    Value = 
new System.UInt64[,] { { 4699886413064210699L, 7752195219760793981L, }, { 5747025128886476169L, 8770499634025447679L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 7988436089998372320L, 5440505310905725864L, }, { 3544117648495472425L, 9076864093663033865L, }, },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UInt64))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UInt64))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[,]), 
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
                    await ((IUInt64MArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IUInt64MArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.uint64marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD2)),
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
                    var models = await ((IUInt64MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt64MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

