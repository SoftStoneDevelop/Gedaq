

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
    internal partial interface INpgsqlLineListlineArray
    {
    }
    
    internal partial class NpgsqlLineListlineArray : INpgsqlLineListlineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray2M[] _testData = new NpgsqlLinelineArray2M[]
        {
            new NpgsqlLinelineArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9314875698818966d, b: 0.8520918793786619d, c: 0.4986941783346506d),

new NpgsqlTypes.NpgsqlLine(a: 0.09801332182803513d, b: 0.24422081457755218d, c: 0.9704720813401838d),

new NpgsqlTypes.NpgsqlLine(a: 0.9826785591734556d, b: 0.7973355302265758d, c: 0.9131746553268257d),

new NpgsqlTypes.NpgsqlLine(a: 0.7804182926183193d, b: 0.2648535272175029d, c: 0.16857261788247624d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6862715792423758d, b: 0.8342392205233302d, c: 0.7383376992338461d),

new NpgsqlTypes.NpgsqlLine(a: 0.8790915077237693d, b: 0.13620413931832398d, c: 0.3233708205882605d),

new NpgsqlTypes.NpgsqlLine(a: 0.3952407136415629d, b: 0.7325815715551706d, c: 0.2230027654612854d),

new NpgsqlTypes.NpgsqlLine(a: 0.5116682509103638d, b: 0.23057025044072588d, c: 0.07650944003964477d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8510949345232504d, b: 0.9616447848850426d, c: 0.11478765578460881d),

new NpgsqlTypes.NpgsqlLine(a: 0.8736904695485925d, b: 0.43780082761131955d, c: 0.18855046788032526d),

new NpgsqlTypes.NpgsqlLine(a: 0.13244415467044435d, b: 0.0980419991909649d, c: 0.8937975115135823d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9211215478478584d, b: 0.9550343599697548d, c: 0.41041150574001317d),

new NpgsqlTypes.NpgsqlLine(a: 0.8244552708266327d, b: 0.046208527896820284d, c: 0.8041873341241386d),

new NpgsqlTypes.NpgsqlLine(a: 0.290698347879498d, b: 0.23666917193919212d, c: 0.6274294269070596d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5977239895036524d, b: 0.4695551719562012d, c: 0.17832841850705994d),

new NpgsqlTypes.NpgsqlLine(a: 0.21624648143695202d, b: 0.4820828921806828d, c: 0.07177338180204418d),

new NpgsqlTypes.NpgsqlLine(a: 0.9469834724883621d, b: 0.8158496845136309d, c: 0.19949854452551907d),

new NpgsqlTypes.NpgsqlLine(a: 0.5712630585113986d, b: 0.4607311375425137d, c: 0.34508122430091315d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5481868938294993d, b: 0.8499811793504891d, c: 0.22664602836815873d),

new NpgsqlTypes.NpgsqlLine(a: 0.866226237664753d, b: 0.8354747276320593d, c: 0.9080047653770363d),

new NpgsqlTypes.NpgsqlLine(a: 0.6053795061570202d, b: 0.16141650961816656d, c: 0.5734063694417363d),

new NpgsqlTypes.NpgsqlLine(a: 0.773880524913976d, b: 0.718991127285203d, c: 0.6116371103121083d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9857209945610138d, b: 0.10864327356720616d, c: 0.5534043294334275d),

new NpgsqlTypes.NpgsqlLine(a: 0.9883087332784465d, b: 0.6667660641877633d, c: 0.2101655497146505d),

new NpgsqlTypes.NpgsqlLine(a: 0.2896813180320197d, b: 0.3923837845330497d, c: 0.35176009248513185d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7863633481333221d, b: 0.61230279348882d, c: 0.5380287751328693d),

new NpgsqlTypes.NpgsqlLine(a: 0.8376738985329437d, b: 0.5540024722327617d, c: 0.48953399049832946d),

new NpgsqlTypes.NpgsqlLine(a: 0.23080108487749107d, b: 0.46611783922379313d, c: 0.9396166743765779d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14432025902758638d, b: 0.8021807248606722d, c: 0.03154716323494178d),

new NpgsqlTypes.NpgsqlLine(a: 0.9220992226661278d, b: 0.5192546160034841d, c: 0.4240056391260608d),

new NpgsqlTypes.NpgsqlLine(a: 0.47484471909344816d, b: 0.4308565673984025d, c: 0.25234225105864594d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.050272846505865054d, b: 0.10535424208767263d, c: 0.20075849518303301d),

new NpgsqlTypes.NpgsqlLine(a: 0.07164180758724326d, b: 0.19870064557080724d, c: 0.8012664138279503d),

new NpgsqlTypes.NpgsqlLine(a: 0.8231533013522102d, b: 0.36054071489124406d, c: 0.028780596489737853d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8051430574968369d, b: 0.1532135277957466d, c: 0.010732547138972759d),

new NpgsqlTypes.NpgsqlLine(a: 0.3725549009339997d, b: 0.16485450524739587d, c: 0.5359005586913046d),

new NpgsqlTypes.NpgsqlLine(a: 0.21638308425056618d, b: 0.20525076413458943d, c: 0.6014917516185061d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7517042815218298d, b: 0.5051741625254554d, c: 0.22191076302927737d),

new NpgsqlTypes.NpgsqlLine(a: 0.9163180884612404d, b: 0.9275793353561466d, c: 0.18952329044995497d),

new NpgsqlTypes.NpgsqlLine(a: 0.5898412189326508d, b: 0.6718276330564931d, c: 0.5914546205937765d),

new NpgsqlTypes.NpgsqlLine(a: 0.940234047983228d, b: 0.13941812843882273d, c: 0.9998867198642923d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6364017758109306d, b: 0.976790773595105d, c: 0.3551375495914373d),

new NpgsqlTypes.NpgsqlLine(a: 0.010176994378196969d, b: 0.8633112442393962d, c: 0.39789897883319014d),

new NpgsqlTypes.NpgsqlLine(a: 0.8388688968339219d, b: 0.8906363762938662d, c: 0.18945325655903d),

new NpgsqlTypes.NpgsqlLine(a: 0.31602801003504d, b: 0.5228830852084299d, c: 0.8898315234155036d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35003459087652744d, b: 0.49984675902348674d, c: 0.18191598954216437d),

new NpgsqlTypes.NpgsqlLine(a: 0.37369526726176017d, b: 0.7073970320709749d, c: 0.8255572637790152d),

new NpgsqlTypes.NpgsqlLine(a: 0.9089211455618565d, b: 0.45906371880151d, c: 0.5835507129171437d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7664771022735127d, b: 0.6783576969781612d, c: 0.8110877931661586d),

new NpgsqlTypes.NpgsqlLine(a: 0.01192175018462327d, b: 0.37031192290560955d, c: 0.412847599237643d),

new NpgsqlTypes.NpgsqlLine(a: 0.41782266803863977d, b: 0.639201485008785d, c: 0.6911451427292112d),

new NpgsqlTypes.NpgsqlLine(a: 0.8921635404133418d, b: 0.28409555819609356d, c: 0.9163893582932874d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2810647573236975d, b: 0.2686473414056296d, c: 0.11956415245187513d),

new NpgsqlTypes.NpgsqlLine(a: 0.35495508811576904d, b: 0.530961521847834d, c: 0.6809302090568021d),

new NpgsqlTypes.NpgsqlLine(a: 0.0417887898199758d, b: 0.5004298082040999d, c: 0.13823845059923745d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7471673334610879d, b: 0.2606203757456026d, c: 0.5351058701637755d),

new NpgsqlTypes.NpgsqlLine(a: 0.47596419933110556d, b: 0.5803910672489336d, c: 0.7515763481390448d),

new NpgsqlTypes.NpgsqlLine(a: 0.4600564026889524d, b: 0.5305232645376922d, c: 0.6212925877280684d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.37131885388445907d, b: 0.32048208574451886d, c: 0.3408169061338886d),

new NpgsqlTypes.NpgsqlLine(a: 0.748034483426982d, b: 0.2840267547943869d, c: 0.7982052986332302d),

new NpgsqlTypes.NpgsqlLine(a: 0.10088195510420139d, b: 0.5368363750511179d, c: 0.21548380779726173d),

new NpgsqlTypes.NpgsqlLine(a: 0.6074486730580019d, b: 0.140536878934737d, c: 0.5164212534643439d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5987185354914161d, b: 0.27808348806090244d, c: 0.26377511653673014d),

new NpgsqlTypes.NpgsqlLine(a: 0.46211247504996167d, b: 0.7385443276426522d, c: 0.8236980083958637d),

new NpgsqlTypes.NpgsqlLine(a: 0.32539335014929227d, b: 0.18865355689363794d, c: 0.6222769534279335d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.02755348360203791d, b: 0.6095174388185783d, c: 0.8572394634766141d),

new NpgsqlTypes.NpgsqlLine(a: 0.5744774594136619d, b: 0.9501473558630827d, c: 0.08773289950097374d),

new NpgsqlTypes.NpgsqlLine(a: 0.22251505697700003d, b: 0.015244687517364075d, c: 0.7879090462808067d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20346805756574826d, b: 0.8731936259708123d, c: 0.68288395162952d),

new NpgsqlTypes.NpgsqlLine(a: 0.21492957640906685d, b: 0.01955860462414205d, c: 0.03337709153098467d),

new NpgsqlTypes.NpgsqlLine(a: 0.267060282259889d, b: 0.3058702977812906d, c: 0.20690753081947355d),

new NpgsqlTypes.NpgsqlLine(a: 0.4056674538199495d, b: 0.08463518501093548d, c: 0.6128430673639748d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5862346861428774d, b: 0.25752326891917465d, c: 0.40295707262685976d),

new NpgsqlTypes.NpgsqlLine(a: 0.5613682792640895d, b: 0.28063568034235753d, c: 0.012023042384899374d),

new NpgsqlTypes.NpgsqlLine(a: 0.770522535170204d, b: 0.06245772120071402d, c: 0.14495414480257518d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.545889408649161d, b: 0.03599500712259007d, c: 0.9275660899397186d),

new NpgsqlTypes.NpgsqlLine(a: 0.41490806632378907d, b: 0.2723061600113541d, c: 0.9478677754989637d),

new NpgsqlTypes.NpgsqlLine(a: 0.951621098984225d, b: 0.6833609801615773d, c: 0.23604761112215777d),

new NpgsqlTypes.NpgsqlLine(a: 0.44016221635702035d, b: 0.31033718613481065d, c: 0.6022782384618468d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.611072170916804d, b: 0.2719823751512658d, c: 0.9152382846797598d),

new NpgsqlTypes.NpgsqlLine(a: 0.586094814273125d, b: 0.46788313601217424d, c: 0.39319057894811615d),

new NpgsqlTypes.NpgsqlLine(a: 0.27952420069570394d, b: 0.2760110351023015d, c: 0.7404977007798863d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8287164579430522d, b: 0.2802684526404574d, c: 0.11024082049389572d),

new NpgsqlTypes.NpgsqlLine(a: 0.9391728618253753d, b: 0.2861729584576521d, c: 0.10155755377708964d),

new NpgsqlTypes.NpgsqlLine(a: 0.28153777392754d, b: 0.12713039308299856d, c: 0.96856282064765d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5445299549133706d, b: 0.1372495295327899d, c: 0.3595925269514765d),

new NpgsqlTypes.NpgsqlLine(a: 0.8754475419617415d, b: 0.3157967353128397d, c: 0.42379650232080224d),

new NpgsqlTypes.NpgsqlLine(a: 0.20404950910036646d, b: 0.6672797932797104d, c: 0.9614718051579877d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47147070800737534d, b: 0.4036357248141089d, c: 0.41928881271753893d),

new NpgsqlTypes.NpgsqlLine(a: 0.35777912869507844d, b: 0.09761636965038067d, c: 0.06410681762725445d),

new NpgsqlTypes.NpgsqlLine(a: 0.0268715830910079d, b: 0.41735674570091263d, c: 0.7137929047580577d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3558641133381514d, b: 0.42257476817895456d, c: 0.07585329156709297d),

new NpgsqlTypes.NpgsqlLine(a: 0.3733256341557688d, b: 0.13875093182170384d, c: 0.8185810845441871d),

new NpgsqlTypes.NpgsqlLine(a: 0.7736311356343414d, b: 0.5864271237301275d, c: 0.8198117569531264d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8824491728097171d, b: 0.788950118790072d, c: 0.10136696933875233d),

new NpgsqlTypes.NpgsqlLine(a: 0.4801624768371442d, b: 0.38429330474805423d, c: 0.4925667213066207d),

new NpgsqlTypes.NpgsqlLine(a: 0.5693221402898592d, b: 0.4744466445182417d, c: 0.4043950740198837d),

new NpgsqlTypes.NpgsqlLine(a: 0.3882520884508308d, b: 0.6015804294632998d, c: 0.6857867681590558d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8470342936256738d, b: 0.3046015377659662d, c: 0.7338549668608358d),

new NpgsqlTypes.NpgsqlLine(a: 0.21388264207079077d, b: 0.6329383953243647d, c: 0.9597910252767456d),

new NpgsqlTypes.NpgsqlLine(a: 0.5373457004024335d, b: 0.7747304227873664d, c: 0.6568521119448503d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6518929534763154d, b: 0.6695453405756001d, c: 0.3659311366581144d),

new NpgsqlTypes.NpgsqlLine(a: 0.18303545924056785d, b: 0.0323870390600457d, c: 0.7089031182848813d),

new NpgsqlTypes.NpgsqlLine(a: 0.6303672517835734d, b: 0.59754940999584d, c: 0.5232789757619337d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8223092019080214d, b: 0.792575083841617d, c: 0.9108841073040758d),

new NpgsqlTypes.NpgsqlLine(a: 0.3179234823592638d, b: 0.7799852535700564d, c: 0.873628747381586d),

new NpgsqlTypes.NpgsqlLine(a: 0.4262529402356382d, b: 0.8265280001524965d, c: 0.4575725710530235d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8063070094435401d, b: 0.7410583234793777d, c: 0.1329186764500906d),

new NpgsqlTypes.NpgsqlLine(a: 0.5843499067391301d, b: 0.6888894977458595d, c: 0.7938417931933595d),

new NpgsqlTypes.NpgsqlLine(a: 0.30372915373943044d, b: 0.3187393015873812d, c: 0.06666405353061877d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1959671336704638d, b: 0.3710311438692392d, c: 0.8459061172722713d),

new NpgsqlTypes.NpgsqlLine(a: 0.7807012723358728d, b: 0.01818716747406146d, c: 0.8273239187726953d),

new NpgsqlTypes.NpgsqlLine(a: 0.13893230373390242d, b: 0.9205258050054784d, c: 0.679732648760472d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5508333886699823d, b: 0.28998901441722236d, c: 0.7042330070337521d),

new NpgsqlTypes.NpgsqlLine(a: 0.46055094790824114d, b: 0.8743388035737513d, c: 0.2618005495640351d),

new NpgsqlTypes.NpgsqlLine(a: 0.3075225388189796d, b: 0.8622133002430571d, c: 0.8735442024790365d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3134515053217418d, b: 0.7091412637390252d, c: 0.09455036098486569d),

new NpgsqlTypes.NpgsqlLine(a: 0.37614136099426865d, b: 0.6908307960258472d, c: 0.5347843152917161d),

new NpgsqlTypes.NpgsqlLine(a: 0.2469190087506168d, b: 0.820962632133267d, c: 0.6796131502334637d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07383571990090354d, b: 0.07586331477485264d, c: 0.8540959283558446d),

new NpgsqlTypes.NpgsqlLine(a: 0.6296338707314084d, b: 0.23386685496134396d, c: 0.07641023041039074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7572204147894914d, b: 0.6600706975231274d, c: 0.303028423646148d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10545870939332436d, b: 0.9631397383510706d, c: 0.07535551913992233d),

new NpgsqlTypes.NpgsqlLine(a: 0.5490112569110617d, b: 0.25017863264521245d, c: 0.10200735556208729d),

new NpgsqlTypes.NpgsqlLine(a: 0.7653510102913066d, b: 0.22024175661810397d, c: 0.6473483196369101d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.559513066442932d, b: 0.44282803669966664d, c: 0.5006506068508679d),

new NpgsqlTypes.NpgsqlLine(a: 0.5440833363527933d, b: 0.6428534803940503d, c: 0.7947414723319314d),

new NpgsqlTypes.NpgsqlLine(a: 0.5533076239658362d, b: 0.7759852204884407d, c: 0.6763518656253512d),

new NpgsqlTypes.NpgsqlLine(a: 0.47610310433452785d, b: 0.6058560097790637d, c: 0.15108280321540712d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6047969848065049d, b: 0.7809944132423384d, c: 0.23459260292398643d),

new NpgsqlTypes.NpgsqlLine(a: 0.5937642298238893d, b: 0.15259680243858165d, c: 0.10497476601909428d),

new NpgsqlTypes.NpgsqlLine(a: 0.5276465922735851d, b: 0.10186135959659481d, c: 0.47988838994229543d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3854635629832187d, b: 0.20281267229866562d, c: 0.6961640366748629d),

new NpgsqlTypes.NpgsqlLine(a: 0.5690908497440412d, b: 0.040174991062257304d, c: 0.29810879573441174d),

new NpgsqlTypes.NpgsqlLine(a: 0.9387263198071635d, b: 0.7340715323237648d, c: 0.2614887159550031d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.27947476364780643d, b: 0.8196210034002293d, c: 0.004472555628655006d),

new NpgsqlTypes.NpgsqlLine(a: 0.5707664596809817d, b: 0.6924952738045276d, c: 0.21565872356712634d),

new NpgsqlTypes.NpgsqlLine(a: 0.8033446774931196d, b: 0.6233161561632576d, c: 0.0966306691890374d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4954366826105723d, b: 0.7562436871876299d, c: 0.0226100691787241d),

new NpgsqlTypes.NpgsqlLine(a: 0.4323567936631535d, b: 0.07372234325860405d, c: 0.20798593653079556d),

new NpgsqlTypes.NpgsqlLine(a: 0.6649080599864201d, b: 0.3365397607818008d, c: 0.1519306291631689d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3144246456916707d, b: 0.14544639863105457d, c: 0.1324117448518748d),

new NpgsqlTypes.NpgsqlLine(a: 0.033422610022661114d, b: 0.13583435518240017d, c: 0.3465621334667812d),

new NpgsqlTypes.NpgsqlLine(a: 0.38704549169529423d, b: 0.010873008906643666d, c: 0.2329402236776249d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7816430897525991d, b: 0.5225108013867525d, c: 0.24985720482235974d),

new NpgsqlTypes.NpgsqlLine(a: 0.139315587324515d, b: 0.8334873517267356d, c: 0.025118946488623783d),

new NpgsqlTypes.NpgsqlLine(a: 0.7163148037241612d, b: 0.9821067876679613d, c: 0.7388154971851545d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4926161101264298d, b: 0.17660858173403993d, c: 0.21578072864863873d),

new NpgsqlTypes.NpgsqlLine(a: 0.3315895347988458d, b: 0.9569397142495166d, c: 0.9899174924042025d),

new NpgsqlTypes.NpgsqlLine(a: 0.0822993106696488d, b: 0.9828877974674399d, c: 0.6588076980228842d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7817184322292056d, b: 0.33611847537426165d, c: 0.17146779337216833d),

new NpgsqlTypes.NpgsqlLine(a: 0.5782405471419582d, b: 0.5741589068688728d, c: 0.709140391037502d),

new NpgsqlTypes.NpgsqlLine(a: 0.8323864859513461d, b: 0.9161893630596781d, c: 0.9866473732810715d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792666690200818d, b: 0.45921478949402716d, c: 0.2612110470852034d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16971850554526857d, b: 0.21922915802701726d, c: 0.25277789638371817d),

new NpgsqlTypes.NpgsqlLine(a: 0.7398517705742759d, b: 0.6480281970429571d, c: 0.43856848434959517d),

new NpgsqlTypes.NpgsqlLine(a: 0.8550575855887855d, b: 0.44334473201919544d, c: 0.5285479325167194d),

new NpgsqlTypes.NpgsqlLine(a: 0.4835088364434533d, b: 0.7769034380712802d, c: 0.03232345426412653d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22195354551960156d, b: 0.05820404553815606d, c: 0.043572427271145076d),

new NpgsqlTypes.NpgsqlLine(a: 0.17176077365268738d, b: 0.4538135530431181d, c: 0.7205720684643014d),

new NpgsqlTypes.NpgsqlLine(a: 0.5632535510373214d, b: 0.8252076611223755d, c: 0.7348671358274657d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5101892278935947d, b: 0.3431554269694349d, c: 0.5643769864516871d),

new NpgsqlTypes.NpgsqlLine(a: 0.6864926550342362d, b: 0.7592048100995d, c: 0.6437302703447099d),

new NpgsqlTypes.NpgsqlLine(a: 0.46860681965200535d, b: 0.9453923510704845d, c: 0.18690626797873933d),

new NpgsqlTypes.NpgsqlLine(a: 0.36893228220133834d, b: 0.7297451080038352d, c: 0.5621202581330489d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9337926640232309d, b: 0.14194197842023926d, c: 0.8424070759485031d),

new NpgsqlTypes.NpgsqlLine(a: 0.3414267056427037d, b: 0.9891040568343356d, c: 0.09890528083568606d),

new NpgsqlTypes.NpgsqlLine(a: 0.4779390911520016d, b: 0.09940488925511981d, c: 0.08514154788710238d),

new NpgsqlTypes.NpgsqlLine(a: 0.38429553965650753d, b: 0.15522840245721437d, c: 0.04773588739089707d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8285272758065836d, b: 0.9484997213740277d, c: 0.2319961386992655d),

new NpgsqlTypes.NpgsqlLine(a: 0.31842780145090765d, b: 0.10374488320480524d, c: 0.3253837502560947d),

new NpgsqlTypes.NpgsqlLine(a: 0.9915415692110192d, b: 0.8831881429916174d, c: 0.7281177669030322d),

new NpgsqlTypes.NpgsqlLine(a: 0.45371907262675515d, b: 0.22271054969930182d, c: 0.8480541868604731d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8855553552796914d, b: 0.29672978636606306d, c: 0.48003442899313786d),

new NpgsqlTypes.NpgsqlLine(a: 0.5955475543474312d, b: 0.8135942207659954d, c: 0.030994095476275296d),

new NpgsqlTypes.NpgsqlLine(a: 0.5118054690798588d, b: 0.6208591626037012d, c: 0.4230976793159834d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47792714674783354d, b: 0.6813087899122958d, c: 0.9254918799502718d),

new NpgsqlTypes.NpgsqlLine(a: 0.3745952438816962d, b: 0.5843513174630727d, c: 0.9090416386045336d),

new NpgsqlTypes.NpgsqlLine(a: 0.08260159980948079d, b: 0.8154985248457706d, c: 0.42894048648683836d),

new NpgsqlTypes.NpgsqlLine(a: 0.3259805850075227d, b: 0.19568875455682366d, c: 0.602765978181892d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22897620763061777d, b: 0.15297925848112703d, c: 0.7013979531014064d),

new NpgsqlTypes.NpgsqlLine(a: 0.5339881509006191d, b: 0.9444288354010314d, c: 0.10228824520397217d),

new NpgsqlTypes.NpgsqlLine(a: 0.8991751563497963d, b: 0.7244479110951283d, c: 0.9059459783575784d),

new NpgsqlTypes.NpgsqlLine(a: 0.4622560149593681d, b: 0.7306420764134248d, c: 0.43673423270617306d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6149838811768699d, b: 0.2105386158887036d, c: 0.8658876602786393d),

new NpgsqlTypes.NpgsqlLine(a: 0.033986897485969836d, b: 0.4386414271113209d, c: 0.6896239447989881d),

new NpgsqlTypes.NpgsqlLine(a: 0.743387461324838d, b: 0.6833241715806309d, c: 0.9390918780950475d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.024483773474660464d, b: 0.679589828508981d, c: 0.043709868848070266d),

new NpgsqlTypes.NpgsqlLine(a: 0.8616137828578103d, b: 0.04515824434820093d, c: 0.7484288556791857d),

new NpgsqlTypes.NpgsqlLine(a: 0.6518587856520384d, b: 0.5843370155549549d, c: 0.17997545372334667d),

new NpgsqlTypes.NpgsqlLine(a: 0.6694085366260499d, b: 0.5448077652363497d, c: 0.06843519299576661d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.747543414844419d, b: 0.5108034213249659d, c: 0.020530598210677153d),

new NpgsqlTypes.NpgsqlLine(a: 0.9159992044883237d, b: 0.4820662772005607d, c: 0.3804894551776712d),

new NpgsqlTypes.NpgsqlLine(a: 0.5722551355870475d, b: 0.737702832525893d, c: 0.9086646987686425d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.869468239297266d, b: 0.5515566293281593d, c: 0.8653431910159326d),

new NpgsqlTypes.NpgsqlLine(a: 0.14406232100242233d, b: 0.46112172952183184d, c: 0.202916916976268d),

new NpgsqlTypes.NpgsqlLine(a: 0.6765483948349728d, b: 0.37415983069881575d, c: 0.863529317424228d),

new NpgsqlTypes.NpgsqlLine(a: 0.5799292696584311d, b: 0.4646261788312992d, c: 0.07420119927988833d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7924489717758736d, b: 0.47475726256824924d, c: 0.77061943882847d),

new NpgsqlTypes.NpgsqlLine(a: 0.4786701213654593d, b: 0.7881708772438277d, c: 0.7307035743929483d),

new NpgsqlTypes.NpgsqlLine(a: 0.7993073450645056d, b: 0.9125698782319646d, c: 0.22983352107407862d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5183530197157715d, b: 0.18917258472076393d, c: 0.23872739576849333d),

new NpgsqlTypes.NpgsqlLine(a: 0.9087274134219826d, b: 0.37254315186651876d, c: 0.23863979004969182d),

new NpgsqlTypes.NpgsqlLine(a: 0.10239436302671245d, b: 0.5135455464898117d, c: 0.0364983795362358d),

new NpgsqlTypes.NpgsqlLine(a: 0.14372224924968113d, b: 0.5947812715026498d, c: 0.16806928991087033d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7856156490857785d, b: 0.680234232107722d, c: 0.10220228463171577d),

new NpgsqlTypes.NpgsqlLine(a: 0.8855740218078962d, b: 0.09499241039889239d, c: 0.05039304439535719d),

new NpgsqlTypes.NpgsqlLine(a: 0.43029895317495714d, b: 0.7511464642465667d, c: 0.7452068127906729d),

new NpgsqlTypes.NpgsqlLine(a: 0.48033109861974443d, b: 0.45941967280695184d, c: 0.03839103699787061d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6543739495228907d, b: 0.6961970515304292d, c: 0.8891373635185829d),

new NpgsqlTypes.NpgsqlLine(a: 0.355613060244544d, b: 0.12483086241786034d, c: 0.6638514510323367d),

new NpgsqlTypes.NpgsqlLine(a: 0.25499821073642714d, b: 0.4068716473105298d, c: 0.38698663939859634d),

new NpgsqlTypes.NpgsqlLine(a: 0.17229547213729735d, b: 0.47483410783722246d, c: 0.6893144175300793d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.39933956805535875d, b: 0.5576735390484804d, c: 0.6216028193052128d),

new NpgsqlTypes.NpgsqlLine(a: 0.8631787842474701d, b: 0.5356222489916406d, c: 0.5279207056992233d),

new NpgsqlTypes.NpgsqlLine(a: 0.6264647010228316d, b: 0.9516613330410825d, c: 0.5780353333990234d),

new NpgsqlTypes.NpgsqlLine(a: 0.2076543550847738d, b: 0.6672232866547664d, c: 0.41488857060469375d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5849582681032452d, b: 0.3676580636453384d, c: 0.32727745076361203d),

new NpgsqlTypes.NpgsqlLine(a: 0.11288272478883943d, b: 0.004425483768001004d, c: 0.6148269691503322d),

new NpgsqlTypes.NpgsqlLine(a: 0.23395691841763344d, b: 0.18217109496357398d, c: 0.6500194335308177d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4278929722313479d, b: 0.8396190563049597d, c: 0.5798540257828005d),

new NpgsqlTypes.NpgsqlLine(a: 0.37269195729189963d, b: 0.824499033878097d, c: 0.2988529078531017d),

new NpgsqlTypes.NpgsqlLine(a: 0.8697730995454916d, b: 0.9983421339660463d, c: 0.69457931577754d),

},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                List<NpgsqlLinelineArray2M> models = null;

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray2M> models = null;

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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

                var models = await ((INpgsqlLineListlineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlLineListlineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlLineListlineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[8], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[9], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[10], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[29], false);
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

                var models =  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 145, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 135, query1, 65, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelBatchAsync(connection, 122, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[29], false);
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
                var models =  ((INpgsqlLineListlineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelBatch(connection, 163, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[29], false);
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
                await using var cmd = await ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 54);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
FROM public.binary_npgsqllinelinearray2m m
LEFT JOIN public.binary_npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray2M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((INpgsqlLineListlineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((INpgsqlLineListlineArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineListlineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlLinelineArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlLinelineArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

