

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
new System.Int64[,] { { 4398913047003319400L, 7602005184700710059L, }, { 689327743810078107L, 4374469851989502425L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 5,
    Value = 
new System.Int64[,] { { 1747594486538810531L, 8822428269984998222L, }, { 182850871446329026L, 2173262405209776634L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 8915509759408121262L, 7145246000957168562L, }, { 2402503482601519631L, 7122923900946685690L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 16,
    Value = 
new System.Int64[,] { { 5987884066125761720L, 3748227161981135368L, }, { 531809590863884841L, 7060114012239596730L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Int64[,] { { 1978464040691062058L, 8128598260731568364L, }, { 6676648548894510672L, 8996208024856181366L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 17,
    Value = 
new System.Int64[,] { { 6964836430948609368L, 800906273794423967L, }, { 2242815858133496227L, 2466517610237298181L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Int64[,] { { 5750736726304281451L, 2536693342029300978L, }, { 4162371490762342505L, 6597420050977703590L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 366407620056820012L, 4408231319930389706L, }, { 2319066028251363442L, 3416094855733902696L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 22,
    Value = 
new System.Int64[,] { { 287875675937240427L, 6683418980870622506L, }, { 5147179870292521698L, 8724213815154186858L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Int64[,] { { 1886366961554963675L, 3879914971827411982L, }, { 6391254811135176220L, 3033764258895017499L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 26,
    Value = 
new System.Int64[,] { { 8661249616698876175L, 1359051803367632426L, }, { 8517225645760467144L, 4133965377318442737L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Int64[,] { { 7079698375584293750L, 7353292257640427854L, }, { 8545473752833520943L, 5883394215415706526L, }, },
    NullableValue = 
new System.Int64[,] { { 3416644161994587324L, 1498050812230401326L, }, { 7045717473788200037L, 5799240886928085613L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 28,
    Value = 
new System.Int64[,] { { 2638416857658736777L, 7025326643652015273L, }, { 7163378389780148757L, 5061912454768602727L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Int64[,] { { 837184749579354436L, 2713116640592727531L, }, { 8178576265163865840L, 7849450106177215771L, }, },
    NullableValue = 
new System.Int64[,] { { 3570504211251361803L, 948126450896477299L, }, { 9031866148215838658L, 7194245788136629788L, }, },
},
    NullableValue = 
new System.Int64[,] { { 6803164155562705880L, 4122989183673797391L, }, { 5347960701767537889L, 589225203870634290L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 34,
    Value = 
new System.Int64[,] { { 4563009915097412562L, 2529941180780210593L, }, { 5076953502120688844L, 6068910713191558445L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Int64[,] { { 8419583054682324561L, 4307412208136561826L, }, { 53480196335679689L, 7419455246864300239L, }, },
    NullableValue = 
new System.Int64[,] { { 6896924395646017121L, 6319527247359076611L, }, { 136920380411742954L, 9172569121769621056L, }, },
},
    NullableValue = 
new System.Int64[,] { { 795381209113751724L, 2652763640462311333L, }, { 7660728667129829289L, 7035953410561211697L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 39,
    Value = 
new System.Int64[,] { { 4512044890689187626L, 990606860762836766L, }, { 2991886263935356178L, 216078321947632919L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Int64[,] { { 5719026618657190772L, 6733755475347123898L, }, { 6202226935041485225L, 5715627866303763286L, }, },
    NullableValue = 
new System.Int64[,] { { 6415786234798706643L, 2906184244655776877L, }, { 8802090063674292774L, 9178250898718056058L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 47,
    Value = 
new System.Int64[,] { { 8216225484212836461L, 4207454951793964479L, }, { 8028751390477135500L, 7672213163011718672L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 45,
    Value = 
new System.Int64[,] { { 8022015796110038166L, 7612906341836249670L, }, { 1101703987338143233L, 135569522064895617L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 2360000490927816633L, 5701083529942350960L, }, { 3874929176625601910L, 259884432432907059L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 53,
    Value = 
new System.Int64[,] { { 8545825703482479062L, 5303915603086562301L, }, { 8032091095455534382L, 6237998949690827395L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Int64[,] { { 513036381652116185L, 2327775774831375351L, }, { 366003052885850767L, 5488729755534716473L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 2609808591170648936L, 1971366420903149272L, }, { 6834416746108855959L, 384557717033221096L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 60,
    Value = 
new System.Int64[,] { { 2478296903238851279L, 3949783024380479762L, }, { 6033883733702930170L, 4035438969189275489L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Int64[,] { { 7692624288897878358L, 7308902538372210988L, }, { 3191775053845808989L, 9052455590929562631L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 64,
    Value = 
new System.Int64[,] { { 2934254708926290488L, 884147144623770924L, }, { 758540288702887332L, 5869063911107542202L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Int64[,] { { 8277672107651506326L, 6034709025575120504L, }, { 2098678493628361025L, 8688144455242699771L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 68,
    Value = 
new System.Int64[,] { { 339834179924820726L, 1560725879844612476L, }, { 1998478289109753881L, 5760470706225681084L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 69,
    Value = 
new System.Int64[,] { { 6550095102259819445L, 3285247895644684864L, }, { 5640847412388611413L, 5405637746596804846L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 74,
    Value = 
new System.Int64[,] { { 7996998891562600475L, 6925187304752347310L, }, { 5171625455618020771L, 7662171607178226423L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Int64[,] { { 8432379394978080851L, 8974556287878149320L, }, { 7111081698510154143L, 4170289559986527131L, }, },
    NullableValue = 
new System.Int64[,] { { 8519311233811714822L, 349040012523126994L, }, { 388637269206874529L, 6640041117648799889L, }, },
},
    NullableValue = 
new System.Int64[,] { { 4116763853990684653L, 3756883777826690646L, }, { 954444710314993706L, 4400982894643898263L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 78,
    Value = 
new System.Int64[,] { { 7717137961711955773L, 7722201105613005543L, }, { 2895414921574752402L, 9091146060610763745L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 84,
    Value = 
new System.Int64[,] { { 6712770768790462224L, 7900742576413527566L, }, { 2889669297953609658L, 9180274716047678799L, }, },
    NullableValue = 
new System.Int64[,] { { 5433685540213874340L, 895444735598322261L, }, { 5225572293397374450L, 8764264519322785298L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 86,
    Value = 
new System.Int64[,] { { 1285936134108049132L, 1340288356881226014L, }, { 7926767385346480354L, 4103407520017923764L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 90,
    Value = 
new System.Int64[,] { { 5438036384466484734L, 5158564333951833583L, }, { 4956511766886336386L, 3840889292613978863L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 2199276245892716759L, 727288117337026484L, }, { 2898645589847537755L, 6584213500671542748L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 94,
    Value = 
new System.Int64[,] { { 4999738403768655676L, 2647999042771943114L, }, { 3725819940707656574L, 4484979025484000776L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 95,
    Value = 
new System.Int64[,] { { 5107076895464524829L, 4229833708210203253L, }, { 5347621674283965743L, 7118988123097921693L, }, },
    NullableValue = 
new System.Int64[,] { { 976220089257444299L, 3981900790501269391L, }, { 8725802477574003014L, 633426646075140119L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 98,
    Value = 
new System.Int64[,] { { 8433561311595626035L, 7686468044332326880L, }, { 1693099177070786956L, 464709676231699750L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 104,
    Value = 
new System.Int64[,] { { 3063197286577609797L, 8917639575549168315L, }, { 6113890752885966140L, 429623909336392901L, }, },
    NullableValue = 
new System.Int64[,] { { 983164396446590444L, 97390571778912188L, }, { 2326146664947434819L, 2528802014928128613L, }, },
},
    NullableValue = 
new System.Int64[,] { { 4606861923848291436L, 227594459426544098L, }, { 4169322843911585814L, 8569686359955066442L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 107,
    Value = 
new System.Int64[,] { { 2852202091943282884L, 3784768377067731821L, }, { 7020918736985489381L, 4336458824869800304L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 109,
    Value = 
new System.Int64[,] { { 7031912835778405735L, 7837876871246864794L, }, { 5664549535906002279L, 2183989484194440595L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 580062371317908864L, 4441466108100046720L, }, { 4987587629780924722L, 5564850402214355957L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 114,
    Value = 
new System.Int64[,] { { 4730977104769726055L, 809068463409436638L, }, { 3519790959572673785L, 3096471218387424104L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 113,
    Value = 
new System.Int64[,] { { 5555861726451428527L, 2787227340313505205L, }, { 8164779402820944603L, 8025086145580640308L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 123,
    Value = 
new System.Int64[,] { { 8545766872913110646L, 6802951315526082678L, }, { 8888878879865019779L, 432035297456214871L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 114,
    Value = 
new System.Int64[,] { { 6622657983415241782L, 4125352228267480527L, }, { 4772162436300054653L, 3901330702038414324L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 126,
    Value = 
new System.Int64[,] { { 6449815743859424460L, 3848312783799871830L, }, { 1994949081818853783L, 8585565581684041134L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 116,
    Value = 
new System.Int64[,] { { 7022069609923167204L, 7256219814670721114L, }, { 5227532626899893041L, 2125274218361403556L, }, },
    NullableValue = 
new System.Int64[,] { { 2409540619688229749L, 23743599509463652L, }, { 4708952952804844473L, 1499733761531861283L, }, },
},
    NullableValue = 
new System.Int64[,] { { 410004514903826474L, 7038669697198049374L, }, { 4988890843284916361L, 5841894348542411969L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 135,
    Value = 
new System.Int64[,] { { 4144662752746230800L, 4722057581602796487L, }, { 4274382567949642644L, 1851580720800774889L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 120,
    Value = 
new System.Int64[,] { { 8044283596410914901L, 4346792899236257201L, }, { 3944496691620337611L, 1849184837089754604L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 136,
    Value = 
new System.Int64[,] { { 6257460921122447021L, 5748001436097856610L, }, { 5129377624941194556L, 8036852232857873574L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Int64[,] { { 4672180215338321054L, 6412686149068126336L, }, { 6960851957967965609L, 1477354193078325725L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 142,
    Value = 
new System.Int64[,] { { 8150548145801498864L, 2838645458527658037L, }, { 9112604229667129186L, 3018541852806907152L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 134,
    Value = 
new System.Int64[,] { { 8213749555808944383L, 5897988950812685440L, }, { 7257484144200551709L, 8988274453356073888L, }, },
    NullableValue = 
new System.Int64[,] { { 8434008568556974149L, 286449595591854454L, }, { 5116422886005339061L, 1460483012326036810L, }, },
},
    NullableValue = 
new System.Int64[,] { { 7397017613331462981L, 1029660234561872069L, }, { 1600500560864075365L, 343737573313831824L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 147,
    Value = 
new System.Int64[,] { { 8780117209974540386L, 1529207303994714570L, }, { 6795567679830128646L, 9071945775086490857L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 142,
    Value = 
new System.Int64[,] { { 490653641994389734L, 3955238292151297100L, }, { 3233940865937791693L, 5933279131395250988L, }, },
    NullableValue = 
new System.Int64[,] { { 4250452474981085308L, 78144149948707741L, }, { 8005511659320433101L, 1316972510267277226L, }, },
},
    NullableValue = 
new System.Int64[,] { { 3354335353508448566L, 802964291644201724L, }, { 7612222012960380054L, 5420710160379722418L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 148,
    Value = 
new System.Int64[,] { { 3221025196564192591L, 8747668157614480729L, }, { 3922608524944413770L, 6517888366082598967L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.Int64[,] { { 5522785338176956886L, 3618793154520752227L, }, { 6727627825292057823L, 2683904429987852502L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 151,
    Value = 
new System.Int64[,] { { 7011484984826530594L, 3290037309169923293L, }, { 139478096520030972L, 1699937598627131393L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 154,
    Value = 
new System.Int64[,] { { 7931621944562080308L, 95389271379253014L, }, { 4655473532695190059L, 1505817462014278156L, }, },
    NullableValue = 
new System.Int64[,] { { 1294374222880603061L, 3275855346550582823L, }, { 6220462647091132945L, 835332835820938829L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2651708236830844050L, 5362315000517701020L, }, { 7844696227085732468L, 6788062733195672844L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 155,
    Value = 
new System.Int64[,] { { 2290569736116515435L, 7411075147860413117L, }, { 8574225668885005454L, 7345710944662602087L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 160,
    Value = 
new System.Int64[,] { { 3098768267424733578L, 6037389452718620939L, }, { 6106441335233053918L, 3414778984074048554L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 158,
    Value = 
new System.Int64[,] { { 8175534216817215450L, 3034400253036718984L, }, { 3029091069898476178L, 957258647135174630L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 163,
    Value = 
new System.Int64[,] { { 7951908694702297223L, 4207047594123448481L, }, { 7470873478682522903L, 5716416974219520425L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 5288171491515015772L, 8896191396163247446L, }, { 5070032986368729430L, 1471736034644577387L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 166,
    Value = 
new System.Int64[,] { { 914320087249787215L, 7650652053586439883L, }, { 3968124748103818823L, 3897896840759746217L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 170,
    Value = 
new System.Int64[,] { { 383742924446416539L, 7151815742919053039L, }, { 540593289077225227L, 5478069180762713471L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 2454862295135044405L, 7139880572010930663L, }, { 4598048893839852571L, 4502558940374894219L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 173,
    Value = 
new System.Int64[,] { { 7830016993274423528L, 4881159949457880721L, }, { 1695067393225397733L, 5526809945809791057L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 171,
    Value = 
new System.Int64[,] { { 8646054348274077208L, 133169687354760385L, }, { 1765678488963407165L, 1575354205572633778L, }, },
    NullableValue = 
new System.Int64[,] { { 5178577519629649516L, 7349854461298052100L, }, { 5127871208632542476L, 4007634890531749571L, }, },
},
    NullableValue = 
new System.Int64[,] { { 3365819568375126098L, 7101382412322915799L, }, { 8409852401496157454L, 1398683374409447563L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 180,
    Value = 
new System.Int64[,] { { 2187088125655020964L, 4181534425281087860L, }, { 4730234161016673566L, 4284614325863831907L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 175,
    Value = 
new System.Int64[,] { { 5681037549618971048L, 2127438440701511927L, }, { 8661043856465342979L, 8503984393422737322L, }, },
    NullableValue = 
new System.Int64[,] { { 2352483572514022454L, 4843314601478651383L, }, { 4852175574112372102L, 2128010095416992233L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 187,
    Value = 
new System.Int64[,] { { 2330772242622777545L, 4004027259774910884L, }, { 1861549782437317215L, 1403562608935594877L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 182,
    Value = 
new System.Int64[,] { { 5051885888013089538L, 8372368894493420987L, }, { 180898443072740013L, 5773609429215688821L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 190,
    Value = 
new System.Int64[,] { { 5146629893898805353L, 3065366346306502760L, }, { 504317649775148171L, 3719877603618122251L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 188,
    Value = 
new System.Int64[,] { { 8693854450059464281L, 6794995134447742784L, }, { 6005859358122809011L, 5511246830496524551L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 2391596928768722412L, 484037489519586886L, }, { 5965151298361404898L, 6666566896450384420L, }, },
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

