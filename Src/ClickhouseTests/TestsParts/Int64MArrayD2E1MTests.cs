

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
    Id = 8,
    Value = 
new System.Int64[,] { { 6644709008509495377L, 4865968949554438023L, }, { 8023950665118155675L, 365049700556237218L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 1,
    Value = 
new System.Int64[,] { { 2722489441344153200L, 3165319874658656265L, }, { 6246272416644006588L, 8588597518987416451L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 10,
    Value = 
new System.Int64[,] { { 1626959448800959330L, 2376312109487739974L, }, { 5970228281768182253L, 7683422326763481810L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Int64[,] { { 8754990356909218162L, 7667142447481224362L, }, { 3641049955008911607L, 1139741539947269892L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 13,
    Value = 
new System.Int64[,] { { 1639198010958976272L, 7962284718761019562L, }, { 8521325867949108615L, 5631898365020443780L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Int64[,] { { 1262711680972356615L, 7223007064064349329L, }, { 9184402009305695537L, 6010778630039888306L, }, },
    NullableValue = 
new System.Int64[,] { { 3188655181693523101L, 3125781902885653707L, }, { 6935118620952465244L, 4477251428294152676L, }, },
},
    NullableValue = 
new System.Int64[,] { { 8855114909145043602L, 986974067983080752L, }, { 4936910054730451023L, 5538211663325637971L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 17,
    Value = 
new System.Int64[,] { { 2401658501405445153L, 821249640338309738L, }, { 2393766559969581096L, 2357160861776336273L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Int64[,] { { 8997954246717757105L, 1352202389668610682L, }, { 8526214338518237367L, 8903405923024646104L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 23,
    Value = 
new System.Int64[,] { { 4581107766399828638L, 2760912360024944041L, }, { 8428469894615177714L, 9081305959919848647L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Int64[,] { { 7192119708580381105L, 3253204368931050180L, }, { 6986738594978612749L, 5886071333029606882L, }, },
    NullableValue = 
new System.Int64[,] { { 1451076027998095473L, 6805459756693672260L, }, { 6093019687827285482L, 1388150030928786302L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2004477018221501630L, 3031668993110069785L, }, { 2628031634889135111L, 3396676795650106312L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 26,
    Value = 
new System.Int64[,] { { 1475587207419357677L, 5577442536976629044L, }, { 6680032822591762932L, 6978654548435901846L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Int64[,] { { 7725150052426232183L, 6011706187920425374L, }, { 47292526198451866L, 2898250104996546853L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 35,
    Value = 
new System.Int64[,] { { 8637194380636486635L, 7419082147127258097L, }, { 2776388473406918576L, 1025090389799043316L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Int64[,] { { 5130893553352173692L, 7196307996188766535L, }, { 8859696115503979809L, 4737411818848591363L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 41,
    Value = 
new System.Int64[,] { { 4098205618161530808L, 1111440060100375791L, }, { 5596593915496743370L, 8105589978707122996L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Int64[,] { { 4648639206476588100L, 7192838972501344395L, }, { 3208151064581571277L, 2415638579236608410L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 2660425072994918266L, 4915168222803547161L, }, { 1178359349759924897L, 4011643452863580972L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 49,
    Value = 
new System.Int64[,] { { 7125342940500673575L, 626687994507253293L, }, { 6737388083094721333L, 623423595367702976L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Int64[,] { { 6715894807179731990L, 3713117274717288428L, }, { 3887573017463016313L, 2969995477744967332L, }, },
    NullableValue = 
new System.Int64[,] { { 5973144013387831769L, 1311398626974961275L, }, { 245181253847581351L, 2565188547500593650L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 55,
    Value = 
new System.Int64[,] { { 5390264282533549326L, 5371530151535318113L, }, { 229403727252792038L, 4420920557234548301L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Int64[,] { { 5240358999495997840L, 3326304354255167261L, }, { 5121710679931796885L, 384729709093848060L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 57,
    Value = 
new System.Int64[,] { { 2210318942012611921L, 5118275722817471354L, }, { 6471555710729619822L, 5994332890369713539L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Int64[,] { { 4935202051285549942L, 8679452746035539164L, }, { 5537770146769456724L, 4363108765534560426L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 369011695518563979L, 6394608895181967255L, }, { 3566582468777815770L, 4783694698731813604L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 66,
    Value = 
new System.Int64[,] { { 454257768838784566L, 8115051758463125279L, }, { 1378430407749297656L, 1241511557744161024L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Int64[,] { { 7137435720593113251L, 7542938886464641165L, }, { 3486593824927454568L, 6280311336842842126L, }, },
    NullableValue = 
new System.Int64[,] { { 3218679425276252250L, 403655532982372153L, }, { 8365209887782524122L, 5097195535229495827L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 74,
    Value = 
new System.Int64[,] { { 721878385916772386L, 4411506176654246569L, }, { 3775796784365726741L, 6743539168042613917L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 75,
    Value = 
new System.Int64[,] { { 5501045457515857062L, 3149094813623719341L, }, { 1505924878003501917L, 1605208592183693324L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 82,
    Value = 
new System.Int64[,] { { 2174193972676259252L, 6132631826093055906L, }, { 7205431820412602008L, 6109816935689498854L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Int64[,] { { 8317190095618732171L, 5927744191909610346L, }, { 2839824879785740596L, 4422650240918456507L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 86,
    Value = 
new System.Int64[,] { { 7228169725562122598L, 5151864611074427125L, }, { 3238852614086232962L, 8521940697782374869L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Int64[,] { { 7508679251907935127L, 5423893080851465170L, }, { 1341120502301901458L, 5480770754952781049L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 8396025698002557642L, 8401092099163000671L, }, { 7524801842778209762L, 309258381247124432L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 92,
    Value = 
new System.Int64[,] { { 7386602044604775747L, 3692503616286070657L, }, { 6013735827883775787L, 1469408051183863662L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 94,
    Value = 
new System.Int64[,] { { 6777753233944305234L, 1814611979375148542L, }, { 8683635793509658817L, 9066161026899662616L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 98,
    Value = 
new System.Int64[,] { { 3558707848647620436L, 6582654759493972416L, }, { 6083640826130229710L, 8572409892627787892L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 98,
    Value = 
new System.Int64[,] { { 6667746337395364479L, 5486642967596563626L, }, { 2958239570024594195L, 9040686698176471306L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 6572819083585701013L, 7689672474667194130L, }, { 4917194380748783638L, 4724836798252586043L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 99,
    Value = 
new System.Int64[,] { { 3204746096820973419L, 3511483183371304599L, }, { 9032859481520310474L, 163381679081851963L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 102,
    Value = 
new System.Int64[,] { { 8159118311388069697L, 4605632407506498399L, }, { 2306422465615022746L, 6875457661549690275L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 106,
    Value = 
new System.Int64[,] { { 6095684834401758657L, 531753972535655880L, }, { 8980164228297834371L, 8584451637258841515L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 105,
    Value = 
new System.Int64[,] { { 5793221161941666413L, 8487410873299784742L, }, { 6397761048514924961L, 267238850923935894L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 9111343315592251593L, 1431584989449825994L, }, { 7314500540037923871L, 4002161200539153730L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 110,
    Value = 
new System.Int64[,] { { 4554459126384416147L, 2347436314049525788L, }, { 8796189969743810163L, 1006564979654634832L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 108,
    Value = 
new System.Int64[,] { { 476670659611611494L, 5630403927625331133L, }, { 3059412735202232157L, 1840099619469079247L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 5250469333343814972L, 5930910434551428938L, }, { 7641532122601136716L, 3770770228049450265L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 113,
    Value = 
new System.Int64[,] { { 1987773354962387125L, 4760656751300720409L, }, { 6571061796377524713L, 7972040250449891720L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 114,
    Value = 
new System.Int64[,] { { 3866828621680074089L, 4988676032865218701L, }, { 4473091602801848066L, 5377808967187073389L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 464999965762622478L, 5892518548602233646L, }, { 1777144082555128246L, 1775832204358647702L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 119,
    Value = 
new System.Int64[,] { { 2515804329103303428L, 412758242772205671L, }, { 4565186510550221315L, 8377969146112692534L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 115,
    Value = 
new System.Int64[,] { { 4646627549046005104L, 288903895520512896L, }, { 2065034871342582326L, 4119000934914467675L, }, },
    NullableValue = 
new System.Int64[,] { { 5571701048893095678L, 4379032966421015097L, }, { 1124384495126113827L, 3685136324710384170L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2385731339497005771L, 5530650542903695322L, }, { 9216177762258052512L, 1608995596391348506L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 123,
    Value = 
new System.Int64[,] { { 1206292124309489446L, 8442089631015509497L, }, { 4386679722365089071L, 1573664906275875186L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 122,
    Value = 
new System.Int64[,] { { 1290030570705923613L, 8350695832036591487L, }, { 4773719941887545078L, 5080446964158226042L, }, },
    NullableValue = 
new System.Int64[,] { { 2389295217047804758L, 5874551475444380065L, }, { 7573742589820857647L, 5714815662282054602L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 127,
    Value = 
new System.Int64[,] { { 2863676630273585453L, 6318756116932088513L, }, { 4033312640806142797L, 4130892330731116493L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 129,
    Value = 
new System.Int64[,] { { 2882729928555850097L, 1004832015217752164L, }, { 3218695799635804557L, 5071289460097582715L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 134,
    Value = 
new System.Int64[,] { { 7671234738484181279L, 3468906520204359406L, }, { 5363487030725330325L, 8250000345868225783L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 135,
    Value = 
new System.Int64[,] { { 7759251547010242528L, 727014186337541264L, }, { 6569231980396628871L, 780488772273479737L, }, },
    NullableValue = 
new System.Int64[,] { { 5259475171464455534L, 719030564797766284L, }, { 771915486172367540L, 4004129900583662052L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 140,
    Value = 
new System.Int64[,] { { 2119685632282719859L, 1356410116368314388L, }, { 2826231311336801139L, 5941185610543843374L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 142,
    Value = 
new System.Int64[,] { { 2603035469178915917L, 8067753366768481597L, }, { 4238284240813484645L, 7980695623481725496L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 8055229448316290417L, 5633029164598322479L, }, { 4437915357131298082L, 3420356441871656078L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 149,
    Value = 
new System.Int64[,] { { 441806015137955923L, 6740547577002534577L, }, { 1213478394118220763L, 3985478308422758093L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 147,
    Value = 
new System.Int64[,] { { 8452634611512643225L, 1319252843118331311L, }, { 7670261437155658451L, 5042474090694702597L, }, },
    NullableValue = 
new System.Int64[,] { { 2808738086002132375L, 613995114572645698L, }, { 3000426405850356246L, 3338442600721181920L, }, },
},
    NullableValue = 
new System.Int64[,] { { 4937388868965869901L, 765739739135998786L, }, { 1690784016486118354L, 7847998321784099467L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 154,
    Value = 
new System.Int64[,] { { 766871818763151248L, 1389250555481261026L, }, { 7617773427483860997L, 1010038806378835078L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 156,
    Value = 
new System.Int64[,] { { 6776783219899311362L, 8483047189084871584L, }, { 4635681986372188174L, 6581618835074089106L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 163,
    Value = 
new System.Int64[,] { { 2852546940122855131L, 3498803128385235946L, }, { 2102585829037164301L, 2348073196591065272L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 162,
    Value = 
new System.Int64[,] { { 386183739655917218L, 4197633882376768555L, }, { 7004647187813270627L, 6709697779090479004L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 7681387548312661821L, 2521488095937021228L, }, { 6562864836971287643L, 2048676404950622361L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 166,
    Value = 
new System.Int64[,] { { 4405300806297145786L, 8103520670117446750L, }, { 1659801292902016348L, 2953520045538186728L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 165,
    Value = 
new System.Int64[,] { { 6091372349372143478L, 4016859334562558305L, }, { 2837507796952966397L, 4088729624571316071L, }, },
    NullableValue = 
new System.Int64[,] { { 4798022899060325495L, 605394225130423450L, }, { 5828248989043954274L, 7582183252827663166L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 173,
    Value = 
new System.Int64[,] { { 7457977150406178202L, 1388250962023172466L, }, { 7030781901671948184L, 2483935392270042335L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 170,
    Value = 
new System.Int64[,] { { 7604264994740580351L, 8009383055475648395L, }, { 641925449442099201L, 3077453946347172765L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 181,
    Value = 
new System.Int64[,] { { 6215442803942271439L, 4092212187579527731L, }, { 8445557607830837625L, 8125048138789049446L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 176,
    Value = 
new System.Int64[,] { { 7433519242193981259L, 6553814943697306596L, }, { 1867084340199115695L, 5321200769524998976L, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 182,
    Value = 
new System.Int64[,] { { 32460592318400146L, 2399152020951799307L, }, { 779727549529115381L, 7407683317522993967L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 177,
    Value = 
new System.Int64[,] { { 4191849132403449927L, 8138788396298778631L, }, { 1967818867312417786L, 6405442805918252263L, }, },
    NullableValue = 
new System.Int64[,] { { 1853706115117078397L, 1219529906949470971L, }, { 6154693442713594568L, 603195329849713651L, }, },
},
    NullableValue = null,
},
            new Int64MArrayD2E1M
{
    Id = 188,
    Value = 
new System.Int64[,] { { 5365191960588537286L, 737613286765800435L, }, { 1847680808624990017L, 7907577143068275918L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 178,
    Value = 
new System.Int64[,] { { 1198703107605321014L, 5833014460266960382L, }, { 8251072814350629491L, 7220900453589393667L, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int64[,] { { 4876502944738707604L, 257693333881092148L, }, { 4618882278609469478L, 9223221491020563523L, }, },
},
            new Int64MArrayD2E1M
{
    Id = 195,
    Value = 
new System.Int64[,] { { 1413852615689497903L, 6651834038982253211L, }, { 8524386649937843793L, 8004576168525135775L, }, },
    ModelInner = new Int64MArrayD2E1MI
{
    Id = 183,
    Value = 
new System.Int64[,] { { 1841627453435988935L, 3282981164120706108L, }, { 1027709476111448786L, 7398215746592487167L, }, },
    NullableValue = 
new System.Int64[,] { { 8904151941580574755L, 6838640504679522355L, }, { 3973183518214810532L, 5481791783505190733L, }, },
},
    NullableValue = 
new System.Int64[,] { { 2099878536809795248L, 8509913379830577686L, }, { 5900886415710824824L, 2813124532585503359L, }, },
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

