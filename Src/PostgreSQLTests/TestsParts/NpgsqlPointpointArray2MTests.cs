

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
    internal partial interface INpgsqlPointListpointArray
    {
    }
    
    internal partial class NpgsqlPointListpointArray : INpgsqlPointListpointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray2M[] _testData = new NpgsqlPointpointArray2M[]
        {
            new NpgsqlPointpointArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4547093839533132d, y: 0.7852547345249787d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8214714170166202d, y: 0.09293167862365082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1196630630340102d, y: 0.13613036829815262d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9883538763383782d, y: 0.13471100361225397d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6762121733627681d, y: 0.3235410764315806d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7871463953653948d, y: 0.7841805753934575d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09422951485880116d, y: 0.0634112478514427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39981891436126304d, y: 0.9210131969484855d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36757407705372647d, y: 0.06775815086705228d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7666067972219894d, y: 0.7441074605777611d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.261328005369484d, y: 0.8425348226764877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012468847090761237d, y: 0.6449059124847497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5015377642808972d, y: 0.880926764345065d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7961686970017412d, y: 0.9039715185566021d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42703389206088727d, y: 0.012102936886419058d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9061656556525878d, y: 0.08660278444614777d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5215025699870938d, y: 0.9037759449345817d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.33831167861152855d, y: 0.49452236754563883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9241233974250355d, y: 0.3856733494866329d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8941694031648983d, y: 0.7631129191299132d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4225615926352908d, y: 0.254784559496366d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3308722422405004d, y: 0.7136526018031726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.658117749468712d, y: 0.2039950756525749d),

new NpgsqlTypes.NpgsqlPoint(x: 0.660932948313637d, y: 0.9334906294395124d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8798434412034661d, y: 0.2587240444057697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8429208725600051d, y: 0.16825603403516676d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5624797216634996d, y: 0.9938937356266941d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8599686374674188d, y: 0.48200116454917696d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7958224814775582d, y: 0.5487656095930706d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9454375223698719d, y: 0.6835165581841928d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5651056485710586d, y: 0.17060624000852664d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17319803477297357d, y: 0.6109558257185254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5284233808393934d, y: 0.280090157874747d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9377464234832277d, y: 0.2723806012423535d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47309905143819586d, y: 0.13439618523316454d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9809354535487974d, y: 0.7010259065745061d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10641689425083889d, y: 0.8736186976460678d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6523074993299618d, y: 0.09631922856392727d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3120579972568863d, y: 0.20574396901648462d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15391028370878845d, y: 0.4586603804517472d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6422296320285136d, y: 0.637990048292731d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8564202158002926d, y: 0.406444141659391d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4459759746601415d, y: 0.18238528711149582d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7980111151401493d, y: 0.4651776164940157d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8995326396411526d, y: 0.9397039048187832d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6732829067920189d, y: 0.4719293219831536d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6280029327300435d, y: 0.8530668116549519d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09168720370115557d, y: 0.07676550427539097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6659564470097898d, y: 0.37322565638325844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6905593918008718d, y: 0.027789694715852242d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7921804477446096d, y: 0.05506109037737583d),

new NpgsqlTypes.NpgsqlPoint(x: 0.71537124269851d, y: 0.4669898364427685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49863151747838563d, y: 0.8309662056781125d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7967002203727871d, y: 0.9470296269854779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6563715177526769d, y: 0.2250250481841698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18547770325979995d, y: 0.7181165961965196d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4474391769031266d, y: 0.7501279197504265d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9484115348405892d, y: 0.31963638877110856d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6404424783010813d, y: 0.7427198774027973d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.600379542626997d, y: 0.6960438224906366d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7785973814048608d, y: 0.952592856871896d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8954523555141952d, y: 0.8005320860747627d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5827502797274141d, y: 0.5252156775602821d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9287999706802349d, y: 0.920837724964953d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7214185550159652d, y: 0.31651811742295544d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8802361885782403d, y: 0.9703797996886265d),

new NpgsqlTypes.NpgsqlPoint(x: 0.030613983454220173d, y: 0.5178454655745702d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21027138066368667d, y: 0.11744565285656616d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5662712602729185d, y: 0.1057235022803058d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5231885364172822d, y: 0.9561948674397902d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6340264866908587d, y: 0.8087693989418939d),

new NpgsqlTypes.NpgsqlPoint(x: 0.028306760341063164d, y: 0.20083049845311973d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17992485765170796d, y: 0.10246021217799617d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6617133326564477d, y: 0.29801919046128433d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03343023449621829d, y: 0.661896896901482d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8278763607029906d, y: 0.6514276675596262d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8260895924363435d, y: 0.3949688029669257d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012295425024013373d, y: 0.5310934337057966d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19954319757112815d, y: 0.3231747798020801d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8138129796316886d, y: 0.7172113607378706d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6437469448481858d, y: 0.28063859141445857d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8653917886515118d, y: 0.0857167573049844d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19633160749512968d, y: 0.28737130297535707d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2069159626860847d, y: 0.6749285819173768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17679350515604342d, y: 0.005782722715704569d),

new NpgsqlTypes.NpgsqlPoint(x: 0.002665412632615549d, y: 0.7980568115848601d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3557099128022986d, y: 0.7116430638500301d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2888350649156072d, y: 0.45973423126255053d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8371549089103512d, y: 0.7035517631876967d),

new NpgsqlTypes.NpgsqlPoint(x: 0.908255307903792d, y: 0.6274041346228524d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1650599028687466d, y: 0.16277484896125394d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16562990173858683d, y: 0.591444416197562d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7991641518398183d, y: 0.07255819914247919d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6865569013742938d, y: 0.6608293748597538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5520223329787253d, y: 0.4868264659050162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7456749262803573d, y: 0.3956149924290777d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0849488181594854d, y: 0.2832730113345292d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47405385203730777d, y: 0.5988256711504454d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9220465267195141d, y: 0.6816524306424206d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6407457541842304d, y: 0.20935802512376456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47407445345691446d, y: 0.6624858513580271d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7501436450769478d, y: 0.7944662174213819d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20087896346534695d, y: 0.6985886752474211d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32146106868217417d, y: 0.3160511707817617d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9072079424431474d, y: 0.6464980475581875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6747640567844038d, y: 0.24030562581942727d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6838157444507135d, y: 0.41655459886307944d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4727118197510811d, y: 0.6792837866200807d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43154693799525523d, y: 0.046642643886854684d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5517449319065417d, y: 0.736594486420596d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8613888328595453d, y: 0.31840988855745034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14236286230834805d, y: 0.11136026046141878d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31939350276390455d, y: 0.025932026160532917d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14205031077425656d, y: 0.23266278668019347d),

new NpgsqlTypes.NpgsqlPoint(x: 0.488088646865962d, y: 0.8425866690397024d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6679642961033517d, y: 0.19705894619803777d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5133820574908009d, y: 0.6182209017580683d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9662727228175565d, y: 0.9430878877632916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8752272880266845d, y: 0.5794656612545515d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43024660309451956d, y: 0.830498184075712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7896527653628559d, y: 0.7321371956705438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2878647602404891d, y: 0.829078368264662d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03142408303280264d, y: 0.6165176820229402d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8512089845480107d, y: 0.3829230072729197d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2255264263581701d, y: 0.47389481965784974d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5109535418107234d, y: 0.12811216584237894d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09744228455514348d, y: 0.6819360837774712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44564057404650326d, y: 0.4089276200453589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06640336412298942d, y: 0.9054397358281555d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6229759938242275d, y: 0.12486269365850733d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6279600894705144d, y: 0.7075047972997173d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5397967686891227d, y: 0.2178487117963923d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9397227451303476d, y: 0.06600027398410524d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29679903380932793d, y: 0.6728781385760311d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24083207256191685d, y: 0.9181200921488044d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9450610343145419d, y: 0.9591377140401468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5439374237284683d, y: 0.5616078990853403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43160398470449746d, y: 0.0033342119841252016d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23333176623164353d, y: 0.4456288736768127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9542202830128117d, y: 0.9577379591531471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10282185322923432d, y: 0.4031857535089466d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9160582643487402d, y: 0.07100371523935034d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19354974684282622d, y: 0.3086235122670129d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6507941314672029d, y: 0.07836338225561379d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12457023718403837d, y: 0.15472938059113495d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7194338139353724d, y: 0.8364266189171002d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3326298925818497d, y: 0.8252663715330797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47587426891200246d, y: 0.2067365929977738d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10955376099260239d, y: 0.21486260222043096d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7810902597359595d, y: 0.8492741742627594d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49256941763861084d, y: 0.31999543162062927d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7172152444891732d, y: 0.25768528274725555d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7337291969411436d, y: 0.6930986222136406d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9008856060884862d, y: 0.13488673497780845d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18714305845397505d, y: 0.18384542604606124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.641160324939145d, y: 0.015399661079047444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08888986296161983d, y: 0.17749977000094763d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39244911970376495d, y: 0.3523513792665708d),

new NpgsqlTypes.NpgsqlPoint(x: 0.753443684294374d, y: 0.9387519108515141d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5666189258266197d, y: 0.14633243495922577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15205412803255502d, y: 0.2694146307336286d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6567362423117071d, y: 0.5592040086031909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41278349633543865d, y: 0.3091089617228052d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18395465557246238d, y: 0.14695627717879622d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7763373548183968d, y: 0.07313971950600129d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05424273452434403d, y: 0.40327870284138323d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9539474550625733d, y: 0.47825277598698734d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9676771562251041d, y: 0.5637094110153396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7888986431435775d, y: 0.8827309575899073d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4729151493248196d, y: 0.1638276239556964d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7773617306280763d, y: 0.8076133426797746d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11580166143625814d, y: 0.3238263034790063d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14748677936189747d, y: 0.4089765440688673d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20588274319481537d, y: 0.24815118905680977d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33013239016056795d, y: 0.8574559337578257d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7231589670745312d, y: 0.15932978843626466d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8000830271881672d, y: 0.8591783683631057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2769784955115888d, y: 0.3781451719963135d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5701174596838077d, y: 0.06945015053554782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7756257678764474d, y: 0.9478336654726146d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5046034523611015d, y: 0.3509849706993471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5613962315000259d, y: 0.30131213683922686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8858407775416132d, y: 0.6657624843296728d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8122763033363721d, y: 0.8347043366332656d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09323515158744866d, y: 0.5226798436987998d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5865044734765268d, y: 0.656795484345323d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3189531649363494d, y: 0.3336825306971757d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5618094600683367d, y: 0.8056568034109199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.933779713814566d, y: 0.6325042868234568d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19681924929261185d, y: 0.8288331774043579d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35599890914328625d, y: 0.10188595797560496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8724633931332793d, y: 0.2686354729997742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5876267402754637d, y: 0.8021375243911295d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7995071413325398d, y: 0.9987667817272233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8838549938366643d, y: 0.4883704346352582d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5014650259427913d, y: 0.4844659602958863d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12960311435681915d, y: 0.12352750388470124d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9832231025130919d, y: 0.3048292223563501d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5617678240020395d, y: 0.09160750827992159d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7589101124460458d, y: 0.154431995326064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5257491647141562d, y: 0.9263506512585135d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45340646703650556d, y: 0.6495440958286374d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4742667711253892d, y: 0.4390814463661301d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15098683504090016d, y: 0.3146774936563298d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20155824196741456d, y: 0.7001972009718446d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4486894143043636d, y: 0.037020212894353755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8715166828575666d, y: 0.7277780173714973d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7963306771301939d, y: 0.687572271058411d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2305507720133827d, y: 0.41081093255674483d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39722252112429124d, y: 0.5255687555219195d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05590289927153336d, y: 0.07140610031961858d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09664017120380508d, y: 0.2116198768037394d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8517281143304942d, y: 0.7312078053362436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4666412115301817d, y: 0.48623903625066567d),

new NpgsqlTypes.NpgsqlPoint(x: 0.819663330653345d, y: 0.07223716622400012d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.67030093551184d, y: 0.23867719670910748d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7352114025131544d, y: 0.1976534249579429d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10729044817853528d, y: 0.7404647029011616d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7343989732256848d, y: 0.39276911543178705d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14565505297958248d, y: 0.18931490038563747d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3695488164575583d, y: 0.12898881043500166d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0189823840092741d, y: 0.9355075523737303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8085644431553036d, y: 0.5133356002887542d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08251921172165322d, y: 0.767195025189212d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3303177266733188d, y: 0.5169814388171297d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9563508526824948d, y: 0.6033807736856626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42018364538531416d, y: 0.2898765758507651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7558076816205066d, y: 0.4035269220754937d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45215813920868564d, y: 0.8047611522934801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26250188888460024d, y: 0.3456499668657089d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8561203573164625d, y: 0.6808881983314482d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9765635643936972d, y: 0.2083458844573104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3804583744643282d, y: 0.39704109719916936d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6879403924607915d, y: 0.101716550896078d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6615069451535776d, y: 0.6500032830003651d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23747957357063254d, y: 0.15514011198871536d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8690813657536813d, y: 0.8932270960607387d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37305178897154123d, y: 0.44096362677085965d),

new NpgsqlTypes.NpgsqlPoint(x: 0.870260565508596d, y: 0.262631573381103d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7426286803070026d, y: 0.7032850002190156d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4857508879747757d, y: 0.8310241420868765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.640640727730926d, y: 0.3010538487262544d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10652768244440691d, y: 0.7678175517472933d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3161421845225745d, y: 0.9575368776903291d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09232436256954168d, y: 0.3324242515159712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.739297482330394d, y: 0.6568894685496598d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8638743912065486d, y: 0.9098656001245415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8064718532674088d, y: 0.8871721305529463d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5905487121880233d, y: 0.7327203830538108d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.788488089909601d, y: 0.9082332581944362d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8209177360269005d, y: 0.8079829766015334d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18810077426594896d, y: 0.5100798904275425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5974911290166778d, y: 0.940344850144033d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43501527937673257d, y: 0.24732300269303498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7959797737048188d, y: 0.8297620866868439d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13439273636845028d, y: 0.8380202988081595d),

new NpgsqlTypes.NpgsqlPoint(x: 0.929521358446677d, y: 0.0993925215538568d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
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

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                List<NpgsqlPointpointArray2M> models = null;

                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray2M> models = null;

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 21;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 104;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 30, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 43, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 91, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 142, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 120, query1, 8, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 41, query1, 101, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 41, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 135, query1, 91, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 124, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 113, 86))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[17], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[18], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[19], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[29], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[15],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[16],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[17],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[29], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[34], false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
FROM public.binary_npgsqlpointpointarray2m m
LEFT JOIN public.binary_npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models =  ((INpgsqlPointListpointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI), typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                await ((INpgsqlPointListpointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                ((INpgsqlPointListpointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointListpointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

