

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
    internal partial interface IBigIntegerArraynumericArray
    {
    }
    
    internal partial class BigIntegerArraynumericArray : IBigIntegerArraynumericArray
    {


#region TestData

        private readonly BigIntegernumericArray1M[] _testData = new BigIntegernumericArray1M[]
        {
            new BigIntegernumericArray1M
{
    Id = 2,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6848054519093557404L),
new System.Numerics.BigInteger(9207946492822651399L),
new System.Numerics.BigInteger(3648648119162664427L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 3,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7535791959814748870L),
new System.Numerics.BigInteger(3320840985417960965L),
new System.Numerics.BigInteger(4029769035023143195L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 2,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5810938402965371582L),
new System.Numerics.BigInteger(7333933319360168095L),
new System.Numerics.BigInteger(7847448448521331371L),
new System.Numerics.BigInteger(3673931980852231621L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5616107239602113563L),
new System.Numerics.BigInteger(5560800019211739906L),
new System.Numerics.BigInteger(7013752818336380245L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5767402373022303213L),
new System.Numerics.BigInteger(4281280466624112714L),
new System.Numerics.BigInteger(2298672964299982434L),
new System.Numerics.BigInteger(5030357955435251000L),
},
},
            new BigIntegernumericArray1M
{
    Id = 9,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6938270719306261478L),
new System.Numerics.BigInteger(5894158872270735306L),
new System.Numerics.BigInteger(3588196171945593191L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(425722519137952115L),
new System.Numerics.BigInteger(8607287684762665438L),
new System.Numerics.BigInteger(1444982344757557416L),
new System.Numerics.BigInteger(8246667101494023361L),
},
},
            new BigIntegernumericArray1M
{
    Id = 16,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(670725858073695644L),
new System.Numerics.BigInteger(4674981914862236772L),
new System.Numerics.BigInteger(7773283940415154772L),
new System.Numerics.BigInteger(19442878015539120L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 3,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8647239282671266312L),
new System.Numerics.BigInteger(985753921832094901L),
new System.Numerics.BigInteger(7097372624956945247L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3870048337863371370L),
new System.Numerics.BigInteger(7574566853910459737L),
new System.Numerics.BigInteger(4894455336207079758L),
new System.Numerics.BigInteger(7214540812345252679L),
},
},
            new BigIntegernumericArray1M
{
    Id = 21,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2455483513015925434L),
new System.Numerics.BigInteger(8796431655736775714L),
new System.Numerics.BigInteger(1718113013339906304L),
new System.Numerics.BigInteger(1891608318545453245L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 28,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3970133769964468992L),
new System.Numerics.BigInteger(6970953326792413L),
new System.Numerics.BigInteger(8012507504168133505L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 5,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4228576976369135336L),
new System.Numerics.BigInteger(114169135156704656L),
new System.Numerics.BigInteger(5488295086264187555L),
new System.Numerics.BigInteger(1631944088428207788L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5528190038886890681L),
new System.Numerics.BigInteger(2915735415386779571L),
new System.Numerics.BigInteger(3692324274614479538L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1993772097822343843L),
new System.Numerics.BigInteger(4403141607416949387L),
new System.Numerics.BigInteger(6696976593439844384L),
new System.Numerics.BigInteger(888677779927674161L),
},
},
            new BigIntegernumericArray1M
{
    Id = 31,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6683425715915204488L),
new System.Numerics.BigInteger(1832770707604229956L),
new System.Numerics.BigInteger(1062464987683645700L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 37,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3834096043901415150L),
new System.Numerics.BigInteger(7598785914853189548L),
new System.Numerics.BigInteger(6080105064179113990L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 8,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7963035618795859129L),
new System.Numerics.BigInteger(5927396341124688910L),
new System.Numerics.BigInteger(1793075668072217598L),
new System.Numerics.BigInteger(5120055963493779440L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1152551363637154270L),
new System.Numerics.BigInteger(2008341820538589471L),
new System.Numerics.BigInteger(2537447720547208977L),
new System.Numerics.BigInteger(528414173630357484L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 38,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8778681045393236073L),
new System.Numerics.BigInteger(8757817657856655099L),
new System.Numerics.BigInteger(5267385419748446661L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8119734375978634042L),
new System.Numerics.BigInteger(3464818142874029726L),
new System.Numerics.BigInteger(6757845505787007991L),
new System.Numerics.BigInteger(4027133415494584738L),
},
},
            new BigIntegernumericArray1M
{
    Id = 46,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2519115769073507879L),
new System.Numerics.BigInteger(87836139470433745L),
new System.Numerics.BigInteger(6575154607311702046L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 13,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5172501885953859293L),
new System.Numerics.BigInteger(1542891128322696848L),
new System.Numerics.BigInteger(5944547497853375516L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(238758836657068065L),
new System.Numerics.BigInteger(7439146152571400562L),
new System.Numerics.BigInteger(8888365925338005138L),
new System.Numerics.BigInteger(6088947472324531346L),
},
},
            new BigIntegernumericArray1M
{
    Id = 51,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5395492317617150237L),
new System.Numerics.BigInteger(3197735741652583912L),
new System.Numerics.BigInteger(3989895315183527030L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6144010950453203962L),
new System.Numerics.BigInteger(6369910611301188072L),
new System.Numerics.BigInteger(2211345488534267855L),
new System.Numerics.BigInteger(2273330161285101710L),
},
},
            new BigIntegernumericArray1M
{
    Id = 52,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(748357941669407535L),
new System.Numerics.BigInteger(3223903531496628575L),
new System.Numerics.BigInteger(4367918993901667547L),
new System.Numerics.BigInteger(4656704470398919763L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3337725066394938293L),
new System.Numerics.BigInteger(7815778171843197261L),
new System.Numerics.BigInteger(5672718437215558622L),
new System.Numerics.BigInteger(4113637489829777795L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8556279001931960040L),
new System.Numerics.BigInteger(8851134926644928463L),
new System.Numerics.BigInteger(1410167548432502675L),
new System.Numerics.BigInteger(1840834992826858716L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 53,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7787827995434096962L),
new System.Numerics.BigInteger(619013959103329781L),
new System.Numerics.BigInteger(5098232508545670534L),
new System.Numerics.BigInteger(1054374822228709805L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5852686810561441406L),
new System.Numerics.BigInteger(1695802787835004344L),
new System.Numerics.BigInteger(6539975310264715457L),
},
},
            new BigIntegernumericArray1M
{
    Id = 55,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5733098151108691032L),
new System.Numerics.BigInteger(5747845622627372497L),
new System.Numerics.BigInteger(3894902158463248910L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 23,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1344816917249501346L),
new System.Numerics.BigInteger(3441752046673673315L),
new System.Numerics.BigInteger(6494305434637339205L),
new System.Numerics.BigInteger(6535597743615070919L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2675745613612329673L),
new System.Numerics.BigInteger(5905505310664995040L),
new System.Numerics.BigInteger(4848973525276061377L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8991899824764389402L),
new System.Numerics.BigInteger(4353037606668982163L),
new System.Numerics.BigInteger(4112777200103883364L),
new System.Numerics.BigInteger(342994855449556103L),
},
},
            new BigIntegernumericArray1M
{
    Id = 61,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1586608929529286294L),
new System.Numerics.BigInteger(1598715175920699039L),
new System.Numerics.BigInteger(610999597491890537L),
new System.Numerics.BigInteger(6843447994792873761L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(482599646991750413L),
new System.Numerics.BigInteger(2405568806909268269L),
new System.Numerics.BigInteger(7928752318145238903L),
new System.Numerics.BigInteger(1926301792440719933L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 26,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1853175491143030070L),
new System.Numerics.BigInteger(2248299969951583098L),
new System.Numerics.BigInteger(1115894979219527395L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3053289244478268816L),
new System.Numerics.BigInteger(6938470250960777367L),
new System.Numerics.BigInteger(5551441656105037973L),
new System.Numerics.BigInteger(2416711512921043225L),
},
},
            new BigIntegernumericArray1M
{
    Id = 66,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5593875907625138210L),
new System.Numerics.BigInteger(8017656132215165173L),
new System.Numerics.BigInteger(5290253355396897330L),
new System.Numerics.BigInteger(5959708109395937787L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1027832195447156317L),
new System.Numerics.BigInteger(8801392063198118052L),
new System.Numerics.BigInteger(5232566782790798596L),
new System.Numerics.BigInteger(6260242865545092308L),
},
},
            new BigIntegernumericArray1M
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5199559666208613571L),
new System.Numerics.BigInteger(234658701447871293L),
new System.Numerics.BigInteger(6183679857566884442L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 31,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9216891379184403088L),
new System.Numerics.BigInteger(6740687481005840853L),
new System.Numerics.BigInteger(8748100937507699195L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 76,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8995126102575233933L),
new System.Numerics.BigInteger(7874164820051707472L),
new System.Numerics.BigInteger(534644340783262802L),
new System.Numerics.BigInteger(1796233622261471515L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8373705783715567979L),
new System.Numerics.BigInteger(3086303308946848891L),
new System.Numerics.BigInteger(5473680152549450301L),
},
},
            new BigIntegernumericArray1M
{
    Id = 81,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3610808232032225415L),
new System.Numerics.BigInteger(7344199224430114156L),
new System.Numerics.BigInteger(1758377790768929155L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 34,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6783330860742479183L),
new System.Numerics.BigInteger(6205467305413234073L),
new System.Numerics.BigInteger(7519606957223619604L),
new System.Numerics.BigInteger(750507119886023753L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3100982298849454431L),
new System.Numerics.BigInteger(9136035912255538067L),
new System.Numerics.BigInteger(3042822999409883925L),
},
},
            new BigIntegernumericArray1M
{
    Id = 84,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2844778766580228411L),
new System.Numerics.BigInteger(4487593375071599097L),
new System.Numerics.BigInteger(4084241061635990016L),
new System.Numerics.BigInteger(6940273193472651828L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8664322411483546488L),
new System.Numerics.BigInteger(8176410798289760422L),
new System.Numerics.BigInteger(2938384336750420432L),
new System.Numerics.BigInteger(4228149945602461826L),
},
},
            new BigIntegernumericArray1M
{
    Id = 90,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8368061973334805635L),
new System.Numerics.BigInteger(4468344464182427907L),
new System.Numerics.BigInteger(6173761207926358354L),
new System.Numerics.BigInteger(4431510085826082386L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 41,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1653057588535296466L),
new System.Numerics.BigInteger(6590640282561564332L),
new System.Numerics.BigInteger(1989921380624257720L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2023536067343434706L),
new System.Numerics.BigInteger(8756786121736248756L),
new System.Numerics.BigInteger(111721307912379332L),
new System.Numerics.BigInteger(7539190132119330092L),
},
},
            new BigIntegernumericArray1M
{
    Id = 99,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8017477805862418580L),
new System.Numerics.BigInteger(3515963207216666612L),
new System.Numerics.BigInteger(6377855478889337543L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 103,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1974485192995513477L),
new System.Numerics.BigInteger(4571787974373557335L),
new System.Numerics.BigInteger(8826671226146299248L),
new System.Numerics.BigInteger(7118195231382921385L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 48,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3965202807515595343L),
new System.Numerics.BigInteger(6405756860187353066L),
new System.Numerics.BigInteger(1594049595565356390L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4007256548520206024L),
new System.Numerics.BigInteger(4405382803871822015L),
new System.Numerics.BigInteger(1868133429956606571L),
},
},
            new BigIntegernumericArray1M
{
    Id = 110,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2141815991942343517L),
new System.Numerics.BigInteger(5394911912830369552L),
new System.Numerics.BigInteger(3734535848851282209L),
new System.Numerics.BigInteger(7960333452257500642L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2811922183166301634L),
new System.Numerics.BigInteger(1303440835178535285L),
new System.Numerics.BigInteger(3146720541437004870L),
new System.Numerics.BigInteger(4902507943825040506L),
},
},
            new BigIntegernumericArray1M
{
    Id = 115,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3044323371151583781L),
new System.Numerics.BigInteger(8739440290986464608L),
new System.Numerics.BigInteger(5174830134155108347L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7707511648103338848L),
new System.Numerics.BigInteger(1547514503310326958L),
new System.Numerics.BigInteger(3063875699028539285L),
new System.Numerics.BigInteger(2154105315915419198L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 119,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4133041743970810914L),
new System.Numerics.BigInteger(9103577604733433718L),
new System.Numerics.BigInteger(5105539686549083443L),
new System.Numerics.BigInteger(8745127530714491678L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 120,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8555476745384293410L),
new System.Numerics.BigInteger(8658212518908849244L),
new System.Numerics.BigInteger(1763131914165655144L),
new System.Numerics.BigInteger(2079872955360239751L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7880414063922250650L),
new System.Numerics.BigInteger(3361801059814306948L),
new System.Numerics.BigInteger(3204305205606986911L),
new System.Numerics.BigInteger(3488996210184787014L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8943789536382764731L),
new System.Numerics.BigInteger(4848755456858456958L),
new System.Numerics.BigInteger(4331263343787489332L),
},
},
            new BigIntegernumericArray1M
{
    Id = 126,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8311435239932517613L),
new System.Numerics.BigInteger(3794542284206602615L),
new System.Numerics.BigInteger(7533036473137423105L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 127,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5351615316785802385L),
new System.Numerics.BigInteger(3082741436548881914L),
new System.Numerics.BigInteger(4771298431984856708L),
new System.Numerics.BigInteger(7920560354853170083L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 67,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1928829237997659218L),
new System.Numerics.BigInteger(5318749605265001761L),
new System.Numerics.BigInteger(733461702479530658L),
new System.Numerics.BigInteger(5482474434907651804L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8002429847188703893L),
new System.Numerics.BigInteger(6532947099288415662L),
new System.Numerics.BigInteger(1109465110268103792L),
new System.Numerics.BigInteger(1468462801554692579L),
},
},
            new BigIntegernumericArray1M
{
    Id = 133,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4619958195578841224L),
new System.Numerics.BigInteger(5164358592092348881L),
new System.Numerics.BigInteger(3076176676217592234L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 140,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6144885577805969811L),
new System.Numerics.BigInteger(2767626211665849499L),
new System.Numerics.BigInteger(8824760911651341918L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 76,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6327338589667710481L),
new System.Numerics.BigInteger(42046926104057188L),
new System.Numerics.BigInteger(2874966610918461977L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2468197857157578654L),
new System.Numerics.BigInteger(7838266807381665614L),
new System.Numerics.BigInteger(3823391149771727195L),
},
},
            new BigIntegernumericArray1M
{
    Id = 144,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8567740314763736095L),
new System.Numerics.BigInteger(6481525755890124934L),
new System.Numerics.BigInteger(2492206617432576466L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 145,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8404320354428439583L),
new System.Numerics.BigInteger(7104480116306609302L),
new System.Numerics.BigInteger(9001232106163266445L),
new System.Numerics.BigInteger(1567742731154319704L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 84,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2189850941705383102L),
new System.Numerics.BigInteger(2816475652346125772L),
new System.Numerics.BigInteger(8567100882052805342L),
new System.Numerics.BigInteger(8290399370551629231L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 152,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3090114023516836249L),
new System.Numerics.BigInteger(6150328395988533493L),
new System.Numerics.BigInteger(85900323693693485L),
new System.Numerics.BigInteger(4022974776058537603L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9120305405557831379L),
new System.Numerics.BigInteger(1031216161264285290L),
new System.Numerics.BigInteger(2112111610682102144L),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
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
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;

                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[34], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M), typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                await((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 115, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 46, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericArray1M>();
                var models2 = new List<FlatBigIntegernumericArray1M>();
                ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 61, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var firstItems2 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 52, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 144, query1, 2, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[1], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[2], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[29],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[30],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[31],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[32],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[33],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 120, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 55, query1, 99, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
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
FROM public.bigintegernumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems1 = new List<FlatBigIntegernumericArray1M>();
                var secondItems2 = new List<FlatBigIntegernumericArray1M>();
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 144, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)),
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
                var models = await((IBigIntegerArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 53, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[3], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[4], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[5], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[6], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[7], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[8], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[26],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[27],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[28],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[29],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[30],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[31],_testData[34], false);
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
                var models = ((IBigIntegerArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 66, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
BigIntegernumericArray1M.AssertModel(models[0],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[29], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[30], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[31], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[32], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[33], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
BigIntegernumericArray1M.AssertModel(models[0],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[29], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[30], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[31], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[32], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[33], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[34], false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
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
FROM public.binary_bigintegernumericarray1m m
LEFT JOIN public.binary_bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerArraynumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IBigIntegerArraynumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IBigIntegerArraynumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

