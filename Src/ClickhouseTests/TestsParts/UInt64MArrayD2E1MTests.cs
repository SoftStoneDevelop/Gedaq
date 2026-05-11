

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
    Id = 2,
    Value = 
new System.UInt64[,] { { 3034258597349181569L, 1523999717989579834L, }, { 1595191184430008082L, 2150259745125863882L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 6,
    Value = 
new System.UInt64[,] { { 6339528665279322030L, 6428649498479694004L, }, { 6980836659806318159L, 3816372964733347981L, }, },
    NullableValue = 
new System.UInt64[,] { { 8401616706060034653L, 2436594369644444391L, }, { 7280998764056353892L, 1289014942997725008L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 1879112755082628522L, 2381917023771389999L, }, { 379851632062375829L, 485224804877497980L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 9,
    Value = 
new System.UInt64[,] { { 6897860908849751318L, 8596256009599897734L, }, { 8591267232374094704L, 6841834647506889227L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 15,
    Value = 
new System.UInt64[,] { { 659976795900814754L, 4181347224077868739L, }, { 3970943943764949536L, 7300249919473011024L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 2717095823940031984L, 5767300054725296732L, }, { 935495949386683399L, 8963020008772585581L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 13,
    Value = 
new System.UInt64[,] { { 8737461350336239724L, 896673312363146054L, }, { 8441590247002740068L, 523956531745371155L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 20,
    Value = 
new System.UInt64[,] { { 1374174306233990815L, 2232868141525633522L, }, { 5121943366543218630L, 5637745561640482726L, }, },
    NullableValue = 
new System.UInt64[,] { { 748988784403922535L, 1348864087737845219L, }, { 1674733699793530341L, 8022713333757722060L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 17,
    Value = 
new System.UInt64[,] { { 6893300429932225813L, 228994664587976275L, }, { 2865323103887998102L, 6246623842150068831L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 21,
    Value = 
new System.UInt64[,] { { 695119991500623757L, 7519935059670652065L, }, { 5190766915726894352L, 6923737672621024237L, }, },
    NullableValue = 
new System.UInt64[,] { { 6919807347149526399L, 6415199584209124747L, }, { 3988075084290323956L, 5418028008132016502L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 8270596449011883063L, 6764056190123552028L, }, { 4346582264280834760L, 7309347073910659704L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 22,
    Value = 
new System.UInt64[,] { { 3162217114586559620L, 8236906090369783102L, }, { 5388757810215721482L, 2801573898207320374L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 23,
    Value = 
new System.UInt64[,] { { 3071929717614193258L, 1369777615804287778L, }, { 8738810395784174442L, 7135331504071939140L, }, },
    NullableValue = 
new System.UInt64[,] { { 3209443073232619841L, 7230099953428047785L, }, { 3545925549299963828L, 908470272692339629L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 6462511086877203128L, 1633287260687410543L, }, { 6177945460278746654L, 5407575573886823328L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 24,
    Value = 
new System.UInt64[,] { { 5715374229080867597L, 92440065565094627L, }, { 6605354587073162862L, 6392500712733003328L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 24,
    Value = 
new System.UInt64[,] { { 2004452294305755203L, 9210662716096000409L, }, { 4193215103979899588L, 8196995744909369592L, }, },
    NullableValue = 
new System.UInt64[,] { { 4358685059678123613L, 6991110115022768873L, }, { 6901214546087194959L, 2664945363497464813L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 4061099321072245167L, 1211082833060321419L, }, { 3676833609743574241L, 1835689879458429306L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 33,
    Value = 
new System.UInt64[,] { { 7072268102238189207L, 8726741564450633372L, }, { 5871722668713826381L, 7559630996053389657L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 31,
    Value = 
new System.UInt64[,] { { 4829009557784002407L, 8849977307891164182L, }, { 8381960034807658725L, 6329832761759421978L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 35,
    Value = 
new System.UInt64[,] { { 5144474570381617071L, 6649017980341339724L, }, { 1518704190396055727L, 2031707184148968746L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 35,
    Value = 
new System.UInt64[,] { { 6511858536661591310L, 3995049611635524286L, }, { 7844174083599680132L, 8266976893029291711L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 40,
    Value = 
new System.UInt64[,] { { 719964230656710627L, 8448823372912259902L, }, { 3914175380770583550L, 6841247088915449624L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 40,
    Value = 
new System.UInt64[,] { { 5399394883015416139L, 6253456108438131073L, }, { 4038297059348366552L, 3137027277021747184L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 49,
    Value = 
new System.UInt64[,] { { 5469833401114031157L, 3175216623118022432L, }, { 3965033166350419195L, 4104552996441941480L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.UInt64[,] { { 6359609805523177510L, 893190122932359790L, }, { 3864929678427504616L, 8737510052132747512L, }, },
    NullableValue = 
new System.UInt64[,] { { 1540413277434329294L, 4588560575231692675L, }, { 7505161241845616564L, 3821332714773436594L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 54,
    Value = 
new System.UInt64[,] { { 5580402853882847578L, 5706165877435681857L, }, { 1893236106542828291L, 6343337330115462498L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 54,
    Value = 
new System.UInt64[,] { { 2531873042775537205L, 1469546532855625614L, }, { 7715405136765234271L, 1877571728079719024L, }, },
    NullableValue = 
new System.UInt64[,] { { 2767117263503570603L, 2366561324854101603L, }, { 4295294545543364579L, 4436024883951060260L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 58,
    Value = 
new System.UInt64[,] { { 5986753647725908969L, 4302813219188686418L, }, { 6875501680331454043L, 5690409900900355105L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 59,
    Value = 
new System.UInt64[,] { { 3556349477071609592L, 3837523861658984567L, }, { 7882472117938903214L, 3553554894548407386L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 59,
    Value = 
new System.UInt64[,] { { 1140723327124429674L, 5750689647043068515L, }, { 2935148814522036195L, 4909765248547867410L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 68,
    Value = 
new System.UInt64[,] { { 7073312448579201785L, 8988550586727114049L, }, { 7322271976833482629L, 454254353215744370L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 491696855731388268L, 3992793038324255481L, }, { 4429205458871051030L, 3381087118155160479L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 67,
    Value = 
new System.UInt64[,] { { 8443966029045608676L, 4433758273048267717L, }, { 1155012854889249725L, 6493745335805451866L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 70,
    Value = 
new System.UInt64[,] { { 2526487740308316816L, 775157615854002535L, }, { 935386549596295934L, 4785220407260548680L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 3622862834000896828L, 5181123319378506800L, }, { 5176729733165205552L, 4817989798714022775L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 72,
    Value = 
new System.UInt64[,] { { 2031417859642719548L, 8995850212368436892L, }, { 6368745059291146930L, 6714425850296680484L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 75,
    Value = 
new System.UInt64[,] { { 3324588898063793566L, 5617096077262938308L, }, { 2864145207240694185L, 3082160530907111436L, }, },
    NullableValue = 
new System.UInt64[,] { { 8798608242252961618L, 7649826136932059174L, }, { 3689426092993468294L, 7091262198493878318L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 76,
    Value = 
new System.UInt64[,] { { 8339464244917020882L, 2968450098572609807L, }, { 8024714829679052068L, 3900142554214630880L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 79,
    Value = 
new System.UInt64[,] { { 1849434694314180883L, 2255031030719011964L, }, { 3027851171338972555L, 2595249542491560402L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 83,
    Value = 
new System.UInt64[,] { { 1518046097802736080L, 3856125595617178947L, }, { 4739048903063175494L, 7965457648123274399L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 86,
    Value = 
new System.UInt64[,] { { 7189978579609977594L, 8088427036881564244L, }, { 6724327978827270917L, 291151459817034616L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 526700431975719490L, 2471370462229111541L, }, { 740906702772156755L, 9028158368894673961L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 88,
    Value = 
new System.UInt64[,] { { 3351563896619192164L, 5153632600080937812L, }, { 2016029880681077222L, 4005474937462115256L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.UInt64[,] { { 1351377411007265857L, 4943397699865107375L, }, { 4569766543330784008L, 2136567392642509226L, }, },
    NullableValue = 
new System.UInt64[,] { { 2261713188247796497L, 4611273528754689363L, }, { 4722296020610888217L, 7741537798579609534L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 96,
    Value = 
new System.UInt64[,] { { 208327754808664131L, 3333060508029454199L, }, { 7093669553785912158L, 2205094883191430187L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 97,
    Value = 
new System.UInt64[,] { { 4796382863612490416L, 4784684043906480014L, }, { 1920903914320743493L, 2016634368524599515L, }, },
    NullableValue = 
new System.UInt64[,] { { 5357173357397070415L, 945359864542052266L, }, { 4706298277700807916L, 2039080838270231225L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 2002875355716045654L, 2559497060091516175L, }, { 2241681991802106007L, 999054781514266821L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 97,
    Value = 
new System.UInt64[,] { { 1702167681713267495L, 7023367804704721586L, }, { 6566479119964404259L, 1019084270980073883L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 101,
    Value = 
new System.UInt64[,] { { 884076589253102563L, 2617445806953431251L, }, { 6845268812546840569L, 6259881638441780861L, }, },
    NullableValue = 
new System.UInt64[,] { { 8729576202592117988L, 7720374497583482489L, }, { 6807451249353620688L, 3525668534375072245L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 106,
    Value = 
new System.UInt64[,] { { 7972303759301681272L, 7210630315854720244L, }, { 1726124611406647855L, 646505915425797083L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 108,
    Value = 
new System.UInt64[,] { { 2293542244660752266L, 523378175593646144L, }, { 8919267955674482308L, 6600017449034318612L, }, },
    NullableValue = 
new System.UInt64[,] { { 5644725246456082777L, 6888905568775871587L, }, { 1972355258360678509L, 6149410381520681075L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 115,
    Value = 
new System.UInt64[,] { { 7358307632231930577L, 7903797193085089548L, }, { 3094728807015489412L, 1549168577937882108L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 112,
    Value = 
new System.UInt64[,] { { 2179357585305159570L, 2340177393578718795L, }, { 5466126929301915749L, 204013246007102439L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 2095585557572737125L, 3923077271410681489L, }, { 8160417702269857210L, 2039692100682559479L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 120,
    Value = 
new System.UInt64[,] { { 5784370395052831245L, 2353265692812039333L, }, { 5940633362529367403L, 8743641743204679971L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 117,
    Value = 
new System.UInt64[,] { { 6782396464233220216L, 9001763296702640216L, }, { 7816986782083985846L, 5848437593834204777L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 7553774627128749250L, 8988701740098799016L, }, { 8183873291729655051L, 3417493748205661448L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 123,
    Value = 
new System.UInt64[,] { { 2257574206454645123L, 3262561048001419239L, }, { 5955179512453049122L, 9112306226697002183L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 126,
    Value = 
new System.UInt64[,] { { 6031082431497581692L, 1463876320641711940L, }, { 2231387072689182227L, 8071400148316046706L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 7518931015410884991L, 4561422329614968101L, }, { 2914941063724404411L, 3383848808440371269L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 125,
    Value = 
new System.UInt64[,] { { 5373414104066286979L, 5514083679930649827L, }, { 8995677019180139171L, 7355148272080794024L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 128,
    Value = 
new System.UInt64[,] { { 6833589281572485267L, 2882536622703205365L, }, { 9127885508520265835L, 7545599486005918200L, }, },
    NullableValue = 
new System.UInt64[,] { { 1668530946707764162L, 1718220669924891517L, }, { 3782488327360337288L, 1335465332206750002L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 381562005329662053L, 3313455306696589717L, }, { 3692988779055951143L, 7521856536982994243L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 129,
    Value = 
new System.UInt64[,] { { 726038552244416718L, 5463107124703235105L, }, { 6808505623836999263L, 627613513636333699L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 135,
    Value = 
new System.UInt64[,] { { 7626337939259818169L, 6256389034816378184L, }, { 6589014666205937628L, 2420034656218488361L, }, },
    NullableValue = 
new System.UInt64[,] { { 1642857767575920019L, 7769595474217267862L, }, { 2134461554970933652L, 6479879430425056506L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 8499238063145516410L, 1766844306552383702L, }, { 6804656900966272310L, 7578823228685303264L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 138,
    Value = 
new System.UInt64[,] { { 7691625995161951571L, 7189437929539905477L, }, { 6757776605155081766L, 8618031130497673731L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 142,
    Value = 
new System.UInt64[,] { { 8213200465383142670L, 5750343127099179321L, }, { 1952303443984004636L, 5058483382035403283L, }, },
    NullableValue = 
new System.UInt64[,] { { 4830813829579332964L, 3313969219208629847L, }, { 8471699759391765064L, 2028696446954081522L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 3762780006358613210L, 8132443275837165625L, }, { 1633851146315200635L, 5163961731479945537L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 140,
    Value = 
new System.UInt64[,] { { 8022245847445468374L, 604463555210196568L, }, { 3878193271474283096L, 3215013440770646918L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 150,
    Value = 
new System.UInt64[,] { { 2921921328926481234L, 1142419944922056638L, }, { 4060545218171205632L, 23364298168331558L, }, },
    NullableValue = 
new System.UInt64[,] { { 6938777965043577218L, 8507471847095558970L, }, { 3873055731393946878L, 1258046471380686748L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 145,
    Value = 
new System.UInt64[,] { { 8943008020741940080L, 6724482032347359826L, }, { 3096192620953040633L, 656793706953044497L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 157,
    Value = 
new System.UInt64[,] { { 1795164438521896893L, 514114120086430141L, }, { 2616041978879417201L, 134952462385782400L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 152,
    Value = 
new System.UInt64[,] { { 6287250636056640162L, 5351092127046533762L, }, { 6264580896204314304L, 1296493739284599680L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 159,
    Value = 
new System.UInt64[,] { { 6261000077197462906L, 386528398389334148L, }, { 270298562057359112L, 6066784024536259088L, }, },
    NullableValue = 
new System.UInt64[,] { { 4747964147499172093L, 2532869081722531030L, }, { 714709289360005325L, 4643223180535845740L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 153,
    Value = 
new System.UInt64[,] { { 6893189363717847995L, 4562428683662286348L, }, { 3144940389025104846L, 5742449598443466767L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 167,
    Value = 
new System.UInt64[,] { { 5273867064462204108L, 5232149229739560952L, }, { 2421891401044141283L, 7867392048415908754L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 5277469952458715897L, 8117493763709699733L, }, { 1760270372400814202L, 3814842757255445994L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 156,
    Value = 
new System.UInt64[,] { { 5679479835129048862L, 2048027547185341600L, }, { 2636939000983443268L, 8034537798853640703L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 168,
    Value = 
new System.UInt64[,] { { 5200857884756979136L, 2736488665363728329L, }, { 4034580300291225311L, 6604713460183596245L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 162,
    Value = 
new System.UInt64[,] { { 3562592152485689795L, 7757625737405107986L, }, { 6263343988333451164L, 6955729101045969423L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 177,
    Value = 
new System.UInt64[,] { { 3833617830324677402L, 2438560353217179875L, }, { 6381001931918915120L, 1311678218615077002L, }, },
    NullableValue = 
new System.UInt64[,] { { 2563742937349192825L, 4423161365183800505L, }, { 7020191914044122819L, 1894717741654599121L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 6538255795982884709L, 7701797991363777974L, }, { 1034786001117734777L, 4283475388993440226L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 163,
    Value = 
new System.UInt64[,] { { 1610133561675930323L, 3197346296069123998L, }, { 5484419431283002349L, 903752779513216973L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 185,
    Value = 
new System.UInt64[,] { { 7188208427846601551L, 4829275896285286458L, }, { 1371783518909817125L, 2270311710878997053L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 166,
    Value = 
new System.UInt64[,] { { 3210758080872068075L, 3020006421716729390L, }, { 5816567033242473463L, 6708083863186312243L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 193,
    Value = 
new System.UInt64[,] { { 5136090883480893543L, 8433407240048358852L, }, { 6161418037132585986L, 9210966291408956112L, }, },
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

