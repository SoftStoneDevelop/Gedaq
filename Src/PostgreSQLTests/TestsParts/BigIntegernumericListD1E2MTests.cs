

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
    internal partial interface IBigIntegerListnumericListD1
    {
    }
    
    internal partial class BigIntegerListnumericListD1 : IBigIntegerListnumericListD1
    {


#region TestData

        private readonly BigIntegernumericListD1E2M[] _testData = new BigIntegernumericListD1E2M[]
        {
            new BigIntegernumericListD1E2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3734196211115796895L),

new System.Numerics.BigInteger(5954305292399916274L),

new System.Numerics.BigInteger(139357571344568954L),

new System.Numerics.BigInteger(7300660506047161060L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3601919492184664998L),

new System.Numerics.BigInteger(8283050573421619350L),

new System.Numerics.BigInteger(9123068551610543558L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7842390512260153015L),

new System.Numerics.BigInteger(4174650769580208991L),

new System.Numerics.BigInteger(5766848391788758643L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6143465884667860683L),

new System.Numerics.BigInteger(4743884887427818457L),

new System.Numerics.BigInteger(2851721687227375569L),

new System.Numerics.BigInteger(1128878345402657203L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1295256688541595494L),

new System.Numerics.BigInteger(1468478975020231768L),

new System.Numerics.BigInteger(7188266517759381516L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8191508333770263322L),

new System.Numerics.BigInteger(7651423016427135158L),

new System.Numerics.BigInteger(7970015733926330659L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2057313333757806174L),

new System.Numerics.BigInteger(6070255622047637934L),

new System.Numerics.BigInteger(4565425790384318733L),

new System.Numerics.BigInteger(5008098406297753916L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1949067642265584212L),

new System.Numerics.BigInteger(6006219975659004760L),

new System.Numerics.BigInteger(6537405298368956479L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5982803475681339393L),

new System.Numerics.BigInteger(6838771639893087755L),

new System.Numerics.BigInteger(4751414853481391178L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7178115409588212573L),

new System.Numerics.BigInteger(3837385708367289848L),

new System.Numerics.BigInteger(3965788043093234223L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1415786486755918158L),

new System.Numerics.BigInteger(4775550792843892963L),

new System.Numerics.BigInteger(4359897097401774557L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(506290309148748792L),

new System.Numerics.BigInteger(3364764024147943196L),

new System.Numerics.BigInteger(6300522220728862691L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7359872602422223539L),

new System.Numerics.BigInteger(1259125259825637140L),

new System.Numerics.BigInteger(518779715738173729L),

new System.Numerics.BigInteger(5128112929752508513L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(8764452866391398674L),

new System.Numerics.BigInteger(7258207565716002078L),

new System.Numerics.BigInteger(8533930732090024915L),

new System.Numerics.BigInteger(3729899461793957941L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5117544251858419469L),

new System.Numerics.BigInteger(6701672663320566196L),

new System.Numerics.BigInteger(7531380458612808892L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6115767814190516553L),

new System.Numerics.BigInteger(7791695138840984308L),

new System.Numerics.BigInteger(3607853215699946455L),

new System.Numerics.BigInteger(5703974440492675644L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(522334086954431842L),

new System.Numerics.BigInteger(3553355927690855039L),

new System.Numerics.BigInteger(9192642403799911311L),

new System.Numerics.BigInteger(4783367873625810371L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1846085073161574706L),

new System.Numerics.BigInteger(4224000989825404054L),

new System.Numerics.BigInteger(7221283444436112738L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3693110700952422862L),

new System.Numerics.BigInteger(6720221784393575730L),

new System.Numerics.BigInteger(2155491787970142663L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4194112786158959327L),

new System.Numerics.BigInteger(6437831584290444373L),

new System.Numerics.BigInteger(6091849835581547323L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7173356538056119301L),

new System.Numerics.BigInteger(2085131082681607346L),

new System.Numerics.BigInteger(1100693375432048703L),

new System.Numerics.BigInteger(6773824166871280277L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6399510834052844261L),

new System.Numerics.BigInteger(610238423103455809L),

new System.Numerics.BigInteger(3895350283171657369L),

new System.Numerics.BigInteger(6650813161565720557L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(806337225916682183L),

new System.Numerics.BigInteger(5074984169228482849L),

new System.Numerics.BigInteger(6524084744254255043L),

new System.Numerics.BigInteger(6976843291809998853L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1193761917420762926L),

new System.Numerics.BigInteger(3431945502161873969L),

new System.Numerics.BigInteger(8867628802575620507L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1630431183339313095L),

new System.Numerics.BigInteger(9190888250225645898L),

new System.Numerics.BigInteger(5551915172505264043L),

new System.Numerics.BigInteger(8414836603397790820L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1808056819869990890L),

new System.Numerics.BigInteger(2402455079767297683L),

new System.Numerics.BigInteger(160001844798030051L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6694517432817810898L),

new System.Numerics.BigInteger(1182581469533483525L),

new System.Numerics.BigInteger(6499899341967240523L),

new System.Numerics.BigInteger(3922371316573184952L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4740624913735081276L),

new System.Numerics.BigInteger(9039150652817216028L),

new System.Numerics.BigInteger(7429157172378495075L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4608219859523665513L),

new System.Numerics.BigInteger(8166357488446342028L),

new System.Numerics.BigInteger(5856069470197791986L),

new System.Numerics.BigInteger(4983932916405225963L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2631129075897922384L),

new System.Numerics.BigInteger(5692138072298166263L),

new System.Numerics.BigInteger(3695379001248124727L),

new System.Numerics.BigInteger(1313765503503543381L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7357151043323600459L),

new System.Numerics.BigInteger(2986874684017414273L),

new System.Numerics.BigInteger(1929600940183921751L),

new System.Numerics.BigInteger(6930917750206652669L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1607867407446816351L),

new System.Numerics.BigInteger(8002228575925218698L),

new System.Numerics.BigInteger(8839388366601325109L),

new System.Numerics.BigInteger(3725658384840798597L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4665254460923168996L),

new System.Numerics.BigInteger(4882249063230218568L),

new System.Numerics.BigInteger(6318851633686349116L),

new System.Numerics.BigInteger(2608136188879273078L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2873099071393118083L),

new System.Numerics.BigInteger(9172770169380562275L),

new System.Numerics.BigInteger(5517366771646622508L),

new System.Numerics.BigInteger(3426083345993151466L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3839348767409503282L),

new System.Numerics.BigInteger(5164049622306792693L),

new System.Numerics.BigInteger(7528786584915230177L),

new System.Numerics.BigInteger(6192464654542250312L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9107833405716325592L),

new System.Numerics.BigInteger(1017254438687407119L),

new System.Numerics.BigInteger(1078210852506063125L),

new System.Numerics.BigInteger(2838458752114491434L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5716884174706495749L),

new System.Numerics.BigInteger(1087829544028175317L),

new System.Numerics.BigInteger(7419104619060118844L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5234947910520944451L),

new System.Numerics.BigInteger(3958610764534339996L),

new System.Numerics.BigInteger(2454210757122260010L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3662957324544057452L),

new System.Numerics.BigInteger(2072752999858519327L),

new System.Numerics.BigInteger(5494797792293244471L),

new System.Numerics.BigInteger(2849687020171984143L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6753326952193497128L),

new System.Numerics.BigInteger(3027277697654989818L),

new System.Numerics.BigInteger(341530742517548489L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2720491843176881274L),

new System.Numerics.BigInteger(4839033468317826449L),

new System.Numerics.BigInteger(5606433395358043291L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9053379660106287403L),

new System.Numerics.BigInteger(1435687229332480685L),

new System.Numerics.BigInteger(2090167889429702933L),

new System.Numerics.BigInteger(455816268484491433L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7303604109287001836L),

new System.Numerics.BigInteger(7293766911293469059L),

new System.Numerics.BigInteger(2994830997646200661L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5523140436188689913L),

new System.Numerics.BigInteger(9009992435494798059L),

new System.Numerics.BigInteger(2912700654997351179L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7280644001054209677L),

new System.Numerics.BigInteger(3415165444536346303L),

new System.Numerics.BigInteger(6706480959040726337L),

new System.Numerics.BigInteger(5973352040883966157L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3446291421320209384L),

new System.Numerics.BigInteger(4054604204346539884L),

new System.Numerics.BigInteger(3436953451702274365L),

new System.Numerics.BigInteger(7661347841367516183L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6432564637289669835L),

new System.Numerics.BigInteger(4016983135002961472L),

new System.Numerics.BigInteger(9156866356758635208L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4426144398435324721L),

new System.Numerics.BigInteger(4735418427965699390L),

new System.Numerics.BigInteger(929332867139556041L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6403394055996342754L),

new System.Numerics.BigInteger(8453373003707735751L),

new System.Numerics.BigInteger(1186279155146883195L),

new System.Numerics.BigInteger(90874519809658701L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(155552632343041474L),

new System.Numerics.BigInteger(4389715639900482102L),

new System.Numerics.BigInteger(1573472864356469666L),

new System.Numerics.BigInteger(3846896945455200657L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(717881953150985166L),

new System.Numerics.BigInteger(3427705822441754300L),

new System.Numerics.BigInteger(4729101225272458883L),

new System.Numerics.BigInteger(912386821104790240L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1721256707663945940L),

new System.Numerics.BigInteger(5238154127117221662L),

new System.Numerics.BigInteger(7846428647275165239L),

new System.Numerics.BigInteger(3789458750923739723L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7001903554307517219L),

new System.Numerics.BigInteger(2910751900001860329L),

new System.Numerics.BigInteger(818543480657005871L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7776404016643394284L),

new System.Numerics.BigInteger(5227617640213122573L),

new System.Numerics.BigInteger(4966079572038241120L),

new System.Numerics.BigInteger(5111392249643970207L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2002035758077167286L),

new System.Numerics.BigInteger(2561869541484292350L),

new System.Numerics.BigInteger(1477624138634906681L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1976174469439689435L),

new System.Numerics.BigInteger(7676219830948072573L),

new System.Numerics.BigInteger(7392884008073486340L),

new System.Numerics.BigInteger(5900697980096825207L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1900376919075776654L),

new System.Numerics.BigInteger(1876918584163162689L),

new System.Numerics.BigInteger(4481448681037360308L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(667412948912140041L),

new System.Numerics.BigInteger(1307630600887854324L),

new System.Numerics.BigInteger(7554436347574006973L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(295597160629014628L),

new System.Numerics.BigInteger(3991202473083191083L),

new System.Numerics.BigInteger(669753847100299769L),

new System.Numerics.BigInteger(8979719602509228453L),

},
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7616612601817723457L),

new System.Numerics.BigInteger(1464467335553883293L),

new System.Numerics.BigInteger(639647485220226056L),

new System.Numerics.BigInteger(6912334035498965311L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1343095101090062068L),

new System.Numerics.BigInteger(6303823006206665624L),

new System.Numerics.BigInteger(3394448980097964783L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1145279563415141162L),

new System.Numerics.BigInteger(8134858570359942755L),

new System.Numerics.BigInteger(7099055740871381944L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6720703250087833726L),

new System.Numerics.BigInteger(6719791449439077683L),

new System.Numerics.BigInteger(5000435925785528791L),

new System.Numerics.BigInteger(5955348811977332648L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3718709019721067634L),

new System.Numerics.BigInteger(5024273971212661677L),

new System.Numerics.BigInteger(6454584058421360833L),

new System.Numerics.BigInteger(6441692525082495537L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4686346543922108999L),

new System.Numerics.BigInteger(4669187050449016644L),

new System.Numerics.BigInteger(83286768931560985L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5625313268911513544L),

new System.Numerics.BigInteger(1495242450487668002L),

new System.Numerics.BigInteger(5257957452082808056L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4247477996461425004L),

new System.Numerics.BigInteger(2686903596997610141L),

new System.Numerics.BigInteger(6128398933685316351L),

new System.Numerics.BigInteger(8108974278849138384L),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2772717727457772451L),

new System.Numerics.BigInteger(1532264457013158685L),

new System.Numerics.BigInteger(4462097323956001167L),

new System.Numerics.BigInteger(7456437754279835662L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2064202668349550704L),

new System.Numerics.BigInteger(8961542573223360891L),

new System.Numerics.BigInteger(5878725476346770300L),

new System.Numerics.BigInteger(2213986224265212187L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3080006860594639512L),

new System.Numerics.BigInteger(4813508748751431609L),

new System.Numerics.BigInteger(206231156456025034L),

new System.Numerics.BigInteger(919391364771033036L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1299585594215519075L),

new System.Numerics.BigInteger(611751959989218143L),

new System.Numerics.BigInteger(7043561111982504020L),

new System.Numerics.BigInteger(2740728133581434367L),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7952435344058121280L),

new System.Numerics.BigInteger(3933149684388791181L),

new System.Numerics.BigInteger(1387053148491669892L),

},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(586230965683613810L),

new System.Numerics.BigInteger(1391266346360613288L),

new System.Numerics.BigInteger(8050315474595399293L),

new System.Numerics.BigInteger(1128707480098458402L),

},
    ModelInner = new BigIntegernumericListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4817490231584927517L),

new System.Numerics.BigInteger(6025521510554463196L),

new System.Numerics.BigInteger(1292338533749066812L),

new System.Numerics.BigInteger(2637630382977335291L),

},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1242854821426196260L),

new System.Numerics.BigInteger(6955559143521069916L),

new System.Numerics.BigInteger(3883390901898737788L),

new System.Numerics.BigInteger(3425222662086381314L),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7327020714733231254L),

new System.Numerics.BigInteger(7650393222628391024L),

new System.Numerics.BigInteger(8511921665432595462L),

},
},
            new BigIntegernumericListD1E2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(836014291940620842L),

new System.Numerics.BigInteger(7240234510618232777L),

new System.Numerics.BigInteger(8974656842953209508L),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4107470431735545198L),

new System.Numerics.BigInteger(1676716792578115817L),

new System.Numerics.BigInteger(2022545606271009313L),

new System.Numerics.BigInteger(2126557759351008364L),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2mi(
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2mi(
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
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
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

                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerListnumericListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerListnumericListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2m(
	id,
    value,
    nullablevalue,
    bigintegernumericlistd1e2mi_id
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericlistd1e2mi_id", 
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
                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerListnumericListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerListnumericListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2m(
	id,
    value,
    nullablevalue,
    bigintegernumericlistd1e2mi_id
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
    bigintegernumericlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericlistd1e2m(
	id,
    value,
    nullablevalue,
    bigintegernumericlistd1e2mi_id
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
    bigintegernumericlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericlistd1e2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericListD1E2M> models = null;

                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerListnumericListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericListD1E2M> models = null;

                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerListnumericListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerListnumericListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerListnumericListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await ((IBigIntegerListnumericListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerListnumericListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerListnumericListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await ((IBigIntegerListnumericListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerListnumericListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[34], false);
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
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M), typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                await((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 19, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 10, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericListD1E2M>();
                var models2 = new List<FlatBigIntegernumericListD1E2M>();
                ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 76, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var firstItems2 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 140, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 7, query1, 33, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[27],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                await ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 45, query1, 33, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 51, query1, 43, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatBigIntegernumericListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(models[24],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
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
FROM public.bigintegernumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems1 = new List<FlatBigIntegernumericListD1E2M>();
                var secondItems2 = new List<FlatBigIntegernumericListD1E2M>();
                 ((IBigIntegerListnumericListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 7, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatBigIntegernumericListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.bigintegernumericlistd1e2m m
LEFT JOIN public.bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
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
                var models = await((IBigIntegerListnumericListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 33, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[7], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[8], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[26],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[34], false);
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
                var models = ((IBigIntegerListnumericListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerListnumericListD1)this).DbConnectionSTSelectModelBatch(connection, 35, 68))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        BigIntegernumericListD1E2M.AssertModel(models[0],_testData[14], false);
                        BigIntegernumericListD1E2M.AssertModel(models[1],_testData[15], false);
                        BigIntegernumericListD1E2M.AssertModel(models[2],_testData[16], false);
                        BigIntegernumericListD1E2M.AssertModel(models[3],_testData[17], false);
                        BigIntegernumericListD1E2M.AssertModel(models[4],_testData[18], false);
                        BigIntegernumericListD1E2M.AssertModel(models[5],_testData[19], false);
                        BigIntegernumericListD1E2M.AssertModel(models[6],_testData[20], false);
                        BigIntegernumericListD1E2M.AssertModel(models[7],_testData[21], false);
                        BigIntegernumericListD1E2M.AssertModel(models[8],_testData[22], false);
                        BigIntegernumericListD1E2M.AssertModel(models[9],_testData[23], false);
                        BigIntegernumericListD1E2M.AssertModel(models[10],_testData[24], false);
                        BigIntegernumericListD1E2M.AssertModel(models[11],_testData[25], false);
                        BigIntegernumericListD1E2M.AssertModel(models[12],_testData[26], false);
                        BigIntegernumericListD1E2M.AssertModel(models[13],_testData[27], false);
                        BigIntegernumericListD1E2M.AssertModel(models[14],_testData[28], false);
                        BigIntegernumericListD1E2M.AssertModel(models[15],_testData[29], false);
                        BigIntegernumericListD1E2M.AssertModel(models[16],_testData[30], false);
                        BigIntegernumericListD1E2M.AssertModel(models[17],_testData[31], false);
                        BigIntegernumericListD1E2M.AssertModel(models[18],_testData[32], false);
                        BigIntegernumericListD1E2M.AssertModel(models[19],_testData[33], false);
                        BigIntegernumericListD1E2M.AssertModel(models[20],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerListnumericListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 107);
                var models = await ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[22], false);
                BigIntegernumericListD1E2M.AssertModel(models[1],_testData[23], false);
                BigIntegernumericListD1E2M.AssertModel(models[2],_testData[24], false);
                BigIntegernumericListD1E2M.AssertModel(models[3],_testData[25], false);
                BigIntegernumericListD1E2M.AssertModel(models[4],_testData[26], false);
                BigIntegernumericListD1E2M.AssertModel(models[5],_testData[27], false);
                BigIntegernumericListD1E2M.AssertModel(models[6],_testData[28], false);
                BigIntegernumericListD1E2M.AssertModel(models[7],_testData[29], false);
                BigIntegernumericListD1E2M.AssertModel(models[8],_testData[30], false);
                BigIntegernumericListD1E2M.AssertModel(models[9],_testData[31], false);
                BigIntegernumericListD1E2M.AssertModel(models[10],_testData[32], false);
                BigIntegernumericListD1E2M.AssertModel(models[11],_testData[33], false);
                BigIntegernumericListD1E2M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerListnumericListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 156);
                var models =  ((IBigIntegerListnumericListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                BigIntegernumericListD1E2M.AssertModel(models[0],_testData[32], false);
                BigIntegernumericListD1E2M.AssertModel(models[1],_testData[33], false);
                BigIntegernumericListD1E2M.AssertModel(models[2],_testData[34], false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericListD1E2MIWA),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerListnumericListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerListnumericListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericListD1E2MI),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerListnumericListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerListnumericListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerListnumericListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericListD1E2M),
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
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
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
FROM public.binary_bigintegernumericlistd1e2m m
LEFT JOIN public.binary_bigintegernumericlistd1e2mi mi ON mi.id = m.bigintegernumericlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerListnumericListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerListnumericListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerListnumericListD1)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerListnumericListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerListnumericListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerListnumericListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA), typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                await ((IBigIntegerListnumericListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                ((IBigIntegerListnumericListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IBigIntegerListnumericListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IBigIntegerListnumericListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA), typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                await ((IBigIntegerListnumericListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                ((IBigIntegerListnumericListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IBigIntegerListnumericListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IBigIntegerListnumericListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI), typeof(BigIntegernumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<BigIntegernumericListD1E2MI>();
                var models2 = new List<BigIntegernumericListD1E2MI>();
                await ((IBigIntegerListnumericListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<BigIntegernumericListD1E2MI>();
                var models2 = new List<BigIntegernumericListD1E2MI>();
                ((IBigIntegerListnumericListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IBigIntegerListnumericListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IBigIntegerListnumericListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA), typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                await ((IBigIntegerListnumericListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<BigIntegernumericListD1E2MIWA>();
                var models2 = new List<BigIntegernumericListD1E2MIWA>();
                ((IBigIntegerListnumericListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericListD1))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IBigIntegerListnumericListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IBigIntegerListnumericListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

