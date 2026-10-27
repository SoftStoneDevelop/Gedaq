

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
    Id = 6,
    Value = 
new System.UInt64[,] { { 1909117412168184477L, 532137073742935663L, }, { 988340060019662433L, 5530801460107888933L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 6,
    Value = 
new System.UInt64[,] { { 2976801900290063002L, 8801751698863202364L, }, { 3554498144030923405L, 5959282418943184239L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 15,
    Value = 
new System.UInt64[,] { { 8393880934617518406L, 2659415292193168578L, }, { 2905710908379999349L, 16497198311562041L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 13,
    Value = 
new System.UInt64[,] { { 8018396960495134009L, 6095723411249716964L, }, { 8352017345724316886L, 6645201418495107629L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 8867734380065542873L, 9169150428006539916L, }, { 4828370571345627481L, 4760093273570375330L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 19,
    Value = 
new System.UInt64[,] { { 5139535196446581452L, 7829228174473027427L, }, { 816486796437437597L, 4568847366197920189L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 22,
    Value = 
new System.UInt64[,] { { 8729933975927077827L, 4369744984073319339L, }, { 8978813894586301885L, 3750239002824282643L, }, },
    NullableValue = 
new System.UInt64[,] { { 5067385900238320725L, 801131880148756155L, }, { 7024207875379991938L, 7078025172418506634L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 2028415279923963286L, 5838989045773941496L, }, { 4921152484014520892L, 7946598540601959010L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 22,
    Value = 
new System.UInt64[,] { { 5317380888301452646L, 2303955990861420120L, }, { 2461587155894639529L, 4950884513672221254L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.UInt64[,] { { 3456596798651069291L, 6098715276390394126L, }, { 3133792871801035990L, 4386892955542341920L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 25,
    Value = 
new System.UInt64[,] { { 1533336706567571429L, 7256890028348905031L, }, { 6195418643977810109L, 8665111141279605564L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 31,
    Value = 
new System.UInt64[,] { { 5452249791841279874L, 2280003389323515804L, }, { 4124176701160841452L, 7275485623373931952L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 2133554712430494696L, 2002703907016043495L, }, { 5388114678650866271L, 1247443751957246274L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 29,
    Value = 
new System.UInt64[,] { { 3384858620148251792L, 5972371077009519982L, }, { 959501784243867410L, 6343957851796614591L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 36,
    Value = 
new System.UInt64[,] { { 4649433578428002395L, 1648597080461090210L, }, { 4469680937780493882L, 8525289717317478893L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 6500247539270885095L, 1127863763404715417L, }, { 5010165312815833924L, 2962722935765570068L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 31,
    Value = 
new System.UInt64[,] { { 8961671498560246583L, 7614212640299776946L, }, { 5335192538462878226L, 3283808232462063862L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 40,
    Value = 
new System.UInt64[,] { { 6276379055841743729L, 4958212120092301309L, }, { 7918972527927166512L, 8261237458190681630L, }, },
    NullableValue = 
new System.UInt64[,] { { 5346513830945760831L, 6517064658939221445L, }, { 4366985443798421960L, 6795086674058122442L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 34,
    Value = 
new System.UInt64[,] { { 5813788203809874713L, 9012229699332679546L, }, { 5556341686359021896L, 34383623059038848L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 45,
    Value = 
new System.UInt64[,] { { 1157954112537615457L, 5668152857475484934L, }, { 2655631021300443117L, 6780749764897013230L, }, },
    NullableValue = 
new System.UInt64[,] { { 358101533782960221L, 23996739584606924L, }, { 6660806334030046892L, 5082940049251868062L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 42,
    Value = 
new System.UInt64[,] { { 5001369778014760303L, 8919535375468483612L, }, { 3677028819097176723L, 4212483205545239579L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 53,
    Value = 
new System.UInt64[,] { { 7208820947621502146L, 1757937561604413311L, }, { 8106749818419708127L, 3235035002388891365L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 1844646393504278638L, 5800803548813783513L, }, { 756764814479341779L, 5994508144148158920L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 43,
    Value = 
new System.UInt64[,] { { 5120971104056384034L, 8002907148977748659L, }, { 6315949398042580893L, 4199508472524216809L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 54,
    Value = 
new System.UInt64[,] { { 3262555463401846908L, 6187912904745764996L, }, { 3910212684848834738L, 4616420662096037572L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 49,
    Value = 
new System.UInt64[,] { { 1397626412771961694L, 8383803970188499078L, }, { 5549612925246999397L, 7299470044745712672L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 63,
    Value = 
new System.UInt64[,] { { 4349022591808499089L, 1549434204000898423L, }, { 7079222902764487982L, 7188675351656980537L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 56,
    Value = 
new System.UInt64[,] { { 4406955735610858142L, 7399340729962732642L, }, { 3791795739990262358L, 8061428534077492437L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 67,
    Value = 
new System.UInt64[,] { { 5630332162668965813L, 8346831592290453287L, }, { 8086285223274416920L, 5394907602260107725L, }, },
    NullableValue = 
new System.UInt64[,] { { 8521817967163596765L, 5905585517880531794L, }, { 3897937654500116502L, 1946867994711882737L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 3518939182270644444L, 2924003365663207892L, }, { 5564019257677965164L, 5771654283243329388L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 57,
    Value = 
new System.UInt64[,] { { 5874343046196776573L, 4133193108545228236L, }, { 8116682675206885389L, 1288413517470535765L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 76,
    Value = 
new System.UInt64[,] { { 853671493174965146L, 5596707005012061245L, }, { 7322795964858578034L, 2961712082133406778L, }, },
    NullableValue = 
new System.UInt64[,] { { 875009814107356622L, 717202674473761858L, }, { 5656074545606065897L, 4066496306763221862L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 5550560094037977089L, 118291554633761875L, }, { 5004362045482096877L, 5865335147140811799L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 65,
    Value = 
new System.UInt64[,] { { 6223620750215651194L, 7617079175143621390L, }, { 3047564861211835892L, 8491190788605660854L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 78,
    Value = 
new System.UInt64[,] { { 5807902204191514379L, 6642527113193905084L, }, { 190669741761110775L, 7065156746700459423L, }, },
    NullableValue = 
new System.UInt64[,] { { 4003138879072348016L, 1970148538340844320L, }, { 9124964103152631051L, 1649534429288406507L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 72,
    Value = 
new System.UInt64[,] { { 972469049478523525L, 8375268832782542200L, }, { 1807551811736937896L, 3543630161341285966L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 83,
    Value = 
new System.UInt64[,] { { 7161383825725125981L, 4420791613755813506L, }, { 6342771513453429457L, 2770859454739305580L, }, },
    NullableValue = 
new System.UInt64[,] { { 4814208845835751488L, 2065171398320600797L, }, { 5663981294710852405L, 1435417717702041982L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 271916565536531644L, 3381795437779295034L, }, { 2741979518650697646L, 5474070617416429816L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 78,
    Value = 
new System.UInt64[,] { { 5450477789365328449L, 6119374371584678416L, }, { 2292175791584737480L, 3323894566113779861L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.UInt64[,] { { 6063381422603690252L, 995558627045019108L, }, { 4785581774716542656L, 1960441464251723915L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 7189875063376252028L, 3975197194485573143L, }, { 6562843115682023114L, 1727986381300839008L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 81,
    Value = 
new System.UInt64[,] { { 8940780059444845600L, 8083768213612291085L, }, { 3889473679680430882L, 8239292159560494203L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 95,
    Value = 
new System.UInt64[,] { { 7402752500181972648L, 7750623510649059084L, }, { 3478796387118944243L, 8533513219578381035L, }, },
    NullableValue = 
new System.UInt64[,] { { 7216123175512147332L, 2386393884624991715L, }, { 8396867472043988555L, 7958644404295314758L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 541075460507278387L, 3297387666270764582L, }, { 7992514111060744913L, 2792033649029343982L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 87,
    Value = 
new System.UInt64[,] { { 1625939033734298126L, 7570946609218632792L, }, { 8166889157364414477L, 4185614580422156906L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 98,
    Value = 
new System.UInt64[,] { { 6367858687101172579L, 6845557992028530146L, }, { 2319704238874604206L, 4217127932147028287L, }, },
    NullableValue = 
new System.UInt64[,] { { 400338180102268281L, 3344719898480651137L, }, { 5507874559691019294L, 5757321443929440717L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 89,
    Value = 
new System.UInt64[,] { { 8364292325362570041L, 7071586251541086152L, }, { 4939685296435695184L, 1474551513701699338L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 103,
    Value = 
new System.UInt64[,] { { 5566512427613342432L, 5918161569996359886L, }, { 5489292365994544927L, 9165431109218547355L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 216004703744024393L, 8982561711430690315L, }, { 5926687104484245139L, 1707882671267279740L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 92,
    Value = 
new System.UInt64[,] { { 4113337611368005513L, 7223993072411477355L, }, { 9009216846079389057L, 7391590441816370666L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 110,
    Value = 
new System.UInt64[,] { { 8343374530752905962L, 6069580234567902554L, }, { 2630387724025180433L, 787222073167900191L, }, },
    NullableValue = 
new System.UInt64[,] { { 8606568156079662186L, 8682881410226065357L, }, { 2078833372902919801L, 2717086387520512802L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 95,
    Value = 
new System.UInt64[,] { { 660009397286178095L, 6124017490963873666L, }, { 2200733672318584046L, 3462720947498079405L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 118,
    Value = 
new System.UInt64[,] { { 4384877930544580078L, 5983112396530992338L, }, { 3507922254339395953L, 4536358448180473460L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 99,
    Value = 
new System.UInt64[,] { { 9028774878806560549L, 8377738923960646038L, }, { 8353047023767143833L, 1417401565556172094L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 125,
    Value = 
new System.UInt64[,] { { 876056708850934728L, 2117755220449254965L, }, { 6127509339300241925L, 1954524583613106213L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 104,
    Value = 
new System.UInt64[,] { { 11089157477898105L, 6943467223948602356L, }, { 1032237066823504775L, 5088463397186335197L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 134,
    Value = 
new System.UInt64[,] { { 6823817756972503713L, 831066285487450L, }, { 5577663326047805085L, 6753707009417124063L, }, },
    NullableValue = 
new System.UInt64[,] { { 6877128014400034247L, 2246251998911147683L, }, { 559623311812075310L, 1947399096730517253L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 5312167213978025878L, 314284668784944714L, }, { 5673181943882225221L, 2731396068792538039L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 106,
    Value = 
new System.UInt64[,] { { 8413158982874758563L, 107906223608287413L, }, { 1431245768264663303L, 1410288455780339128L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 140,
    Value = 
new System.UInt64[,] { { 1011639742373270897L, 7183854838182489329L, }, { 4551232823226542017L, 228418305442503825L, }, },
    NullableValue = 
new System.UInt64[,] { { 3770995744845191393L, 6039762164877274633L, }, { 6613915083312998958L, 2247518700673937524L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 115,
    Value = 
new System.UInt64[,] { { 9209366153467393096L, 2042502016937034515L, }, { 2496845661388293686L, 4268543603891394799L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 144,
    Value = 
new System.UInt64[,] { { 4328368950115781151L, 7516755245019313296L, }, { 8246650531674703879L, 5259024931271123846L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 6283877985714859270L, 6843723741873719785L, }, { 2437601582212449104L, 3140809334419872247L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 117,
    Value = 
new System.UInt64[,] { { 8022191865133325345L, 1216070141479446762L, }, { 2641230497528796131L, 1479376308299427235L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 150,
    Value = 
new System.UInt64[,] { { 7397577733277322972L, 5199776225327648893L, }, { 4943119026855158612L, 3636489258313234674L, }, },
    NullableValue = 
new System.UInt64[,] { { 6138497957399936524L, 6355311225055631750L, }, { 4241512891786889494L, 6689923624036000516L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 125,
    Value = 
new System.UInt64[,] { { 4890633941467281365L, 8257514016147949359L, }, { 2385967216434819658L, 1735831980085685600L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 153,
    Value = 
new System.UInt64[,] { { 7184405328299381065L, 1222039369262066684L, }, { 2422639652003705157L, 7517258081703042539L, }, },
    NullableValue = 
new System.UInt64[,] { { 5190981418720877040L, 9000927693850383303L, }, { 7253464380554937021L, 6416008339109637932L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 127,
    Value = 
new System.UInt64[,] { { 3726430792625625007L, 4079255732714928004L, }, { 1096961439366166334L, 8643788154852711714L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 159,
    Value = 
new System.UInt64[,] { { 1838705127925460350L, 2481127949395624706L, }, { 9122623611197118325L, 3940942221550213188L, }, },
    NullableValue = 
new System.UInt64[,] { { 1153353884374387557L, 6063543273156618503L, }, { 2258832468630842972L, 6695832434101949452L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 5147631259130028617L, 6981272413588992988L, }, { 2598576776629745743L, 5042496195759969437L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 130,
    Value = 
new System.UInt64[,] { { 4467841017338722373L, 7349751004433938941L, }, { 6006030146268159527L, 5853119664912601267L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 162,
    Value = 
new System.UInt64[,] { { 2881707215171303066L, 5227199695528852739L, }, { 5866484224689063763L, 3367576505577344960L, }, },
    NullableValue = 
new System.UInt64[,] { { 656334732448197079L, 5808965796177163707L, }, { 337676656461517569L, 6188686033369405544L, }, },
},
    NullableValue = 
new System.UInt64[,] { { 4619396557490307758L, 4277577309655247999L, }, { 2465924840554199506L, 6049136636335191250L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 133,
    Value = 
new System.UInt64[,] { { 1682052404562653478L, 3591288243284092623L, }, { 2181915935542250168L, 2909694930669001146L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 168,
    Value = 
new System.UInt64[,] { { 4994524687866685491L, 7918880758332393421L, }, { 7997266559979798980L, 5389871988885899713L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 135,
    Value = 
new System.UInt64[,] { { 537752949679716837L, 6733162988552511494L, }, { 4175346873487593668L, 902224945805954345L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 175,
    Value = 
new System.UInt64[,] { { 6366187128837841892L, 7154779829385037452L, }, { 8580955388318525991L, 9177511300521951756L, }, },
    NullableValue = 
new System.UInt64[,] { { 1983541425093887419L, 9117785360080286841L, }, { 3250978530255200264L, 1944868992527052612L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 144,
    Value = 
new System.UInt64[,] { { 5938430117343272043L, 314971068901375530L, }, { 883631296446028654L, 3777379755501274841L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 183,
    Value = 
new System.UInt64[,] { { 3800958693342993876L, 1249590734171893214L, }, { 5529342969605507533L, 926392835061396844L, }, },
    NullableValue = 
new System.UInt64[,] { { 1416718664624257350L, 554795311423803977L, }, { 133368987302735733L, 6424602907875879872L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 152,
    Value = 
new System.UInt64[,] { { 538451375131134190L, 11210874574420768L, }, { 2354026818982386670L, 6551594885834847749L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 185,
    Value = 
new System.UInt64[,] { { 5586966251096579009L, 4068693407644097798L, }, { 4626504914067432778L, 34859962581783359L, }, },
    NullableValue = 
new System.UInt64[,] { { 8892975046981322402L, 6299506870661346011L, }, { 8975256411384072094L, 2332199435150105569L, }, },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 160,
    Value = 
new System.UInt64[,] { { 9142679411721407016L, 1130702550373294938L, }, { 5483323603264235303L, 636183302506786423L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 186,
    Value = 
new System.UInt64[,] { { 6252838766223535383L, 9141989172260719358L, }, { 791133666203472925L, 6101925023739319290L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { { 2067232994535145742L, 6153183594594535185L, }, { 516365370780179615L, 4529749477496913898L, }, },
},
            new UInt64MArrayD2E1M
{
    Id = 164,
    Value = 
new System.UInt64[,] { { 2457442157531972311L, 9078783609316181578L, }, { 8404973190987499010L, 4020466223079423125L, }, },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 190,
    Value = 
new System.UInt64[,] { { 5418706935700286059L, 9003029957226882283L, }, { 6747918468839688182L, 294898261018297639L, }, },
    NullableValue = 
new System.UInt64[,] { { 4055729052370125544L, 9169131939364555697L, }, { 8593321496051795294L, 3242910588082396280L, }, },
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

