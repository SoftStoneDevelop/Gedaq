

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7703795288712125d, y: 0.13342127745867005d), new NpgsqlTypes.NpgsqlPoint(x: 0.3987447504441186d, y: 0.00432743958219306d), new NpgsqlTypes.NpgsqlPoint(x: 0.08445699021104602d, y: 0.644782982042233d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6665578697674498d, y: 0.940816432656696d), new NpgsqlTypes.NpgsqlPoint(x: 0.06213703483775135d, y: 0.6681580547188237d), new NpgsqlTypes.NpgsqlPoint(x: 0.9579398511543454d, y: 0.8818657545661104d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.764887456363784d, y: 0.3942617724882247d), new NpgsqlTypes.NpgsqlPoint(x: 0.4488962356975975d, y: 0.9533133409328476d), new NpgsqlTypes.NpgsqlPoint(x: 0.41212364144970703d, y: 0.48487123196978177d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6937642728333879d, y: 0.31583532267690895d), new NpgsqlTypes.NpgsqlPoint(x: 0.48226811354652177d, y: 0.9580410226060655d), new NpgsqlTypes.NpgsqlPoint(x: 0.5091828912213903d, y: 0.0277879662638153d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9699441215067546d, y: 0.49818626685180367d), new NpgsqlTypes.NpgsqlPoint(x: 0.9378568490253155d, y: 0.9765029557554302d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742454746081363d, y: 0.8922169773444758d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26793650365054567d, y: 0.2897827807149228d), new NpgsqlTypes.NpgsqlPoint(x: 0.12712674261170587d, y: 0.09741332705765127d), new NpgsqlTypes.NpgsqlPoint(x: 0.3841181830903816d, y: 0.5448874314074155d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3460261689022913d, y: 0.4808436797245137d), new NpgsqlTypes.NpgsqlPoint(x: 0.7544297209776945d, y: 0.892003627298879d), new NpgsqlTypes.NpgsqlPoint(x: 0.011960295048078717d, y: 0.14205493850340523d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03331311254710212d, y: 0.09477280732174509d), new NpgsqlTypes.NpgsqlPoint(x: 0.3889062450205292d, y: 0.23519694350478637d), new NpgsqlTypes.NpgsqlPoint(x: 0.8098174707724713d, y: 0.21111245564102998d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9198987866325458d, y: 0.14336960972730828d), new NpgsqlTypes.NpgsqlPoint(x: 0.43287582378803313d, y: 0.22383463472248277d), new NpgsqlTypes.NpgsqlPoint(x: 0.6165667951398224d, y: 0.2361169042136556d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4257621092444027d, y: 0.8702780963639847d), new NpgsqlTypes.NpgsqlPoint(x: 0.3309768642785923d, y: 0.9349632729030651d), new NpgsqlTypes.NpgsqlPoint(x: 0.6664398644142202d, y: 0.5343664664103296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6768194275895457d, y: 0.8155901241678968d), new NpgsqlTypes.NpgsqlPoint(x: 0.1505221174581134d, y: 0.8354979204955894d), new NpgsqlTypes.NpgsqlPoint(x: 0.5376223241265594d, y: 0.5323159354109279d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3079851062059812d, y: 0.9184795527375066d), new NpgsqlTypes.NpgsqlPoint(x: 0.8317836103762074d, y: 0.9743972682381764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6805912528114085d, y: 0.7011119495431389d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4164942575646894d, y: 0.4876116026771996d), new NpgsqlTypes.NpgsqlPoint(x: 0.3566059001879074d, y: 0.9953955489428247d), new NpgsqlTypes.NpgsqlPoint(x: 0.148796936563951d, y: 0.11907137080809338d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7116232290801345d, y: 0.18877158835678243d), new NpgsqlTypes.NpgsqlPoint(x: 0.5763688316014693d, y: 0.6317856284959291d), new NpgsqlTypes.NpgsqlPoint(x: 0.01773296014734993d, y: 0.2228981176860796d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9663257328033882d, y: 0.611191959532543d), new NpgsqlTypes.NpgsqlPoint(x: 0.6405311473896853d, y: 0.4574055386404068d), new NpgsqlTypes.NpgsqlPoint(x: 0.3775976996052156d, y: 0.7675223033485914d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.54090757559981d, y: 0.8815846835812509d), new NpgsqlTypes.NpgsqlPoint(x: 0.2136341561397166d, y: 0.8091299080464442d), new NpgsqlTypes.NpgsqlPoint(x: 0.48909446484424957d, y: 0.9565484576084827d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7594309076520086d, y: 0.6433420455890204d), new NpgsqlTypes.NpgsqlPoint(x: 0.9690302133469557d, y: 0.8013333726821305d), new NpgsqlTypes.NpgsqlPoint(x: 0.3462298152000638d, y: 0.20160437426400446d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008687318048500314d, y: 0.3976161937584649d), new NpgsqlTypes.NpgsqlPoint(x: 0.051718059537203875d, y: 0.07150804879443917d), new NpgsqlTypes.NpgsqlPoint(x: 0.6841473054041461d, y: 0.545301117333111d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6754608824477647d, y: 0.9666256823430602d), new NpgsqlTypes.NpgsqlPoint(x: 0.7323218312923666d, y: 0.6494371253616669d), new NpgsqlTypes.NpgsqlPoint(x: 0.013570647927209634d, y: 0.7172369241235179d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2061051887547547d, y: 0.7019205076846888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8764186082771218d, y: 0.7943695337008239d), new NpgsqlTypes.NpgsqlPoint(x: 0.8180095983081025d, y: 0.6880151384017392d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19322178140067248d, y: 0.5372751912246523d), new NpgsqlTypes.NpgsqlPoint(x: 0.6981388680262994d, y: 0.1541207220265406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8008208888282919d, y: 0.2256977915283197d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5043234771289891d, y: 0.9385765231443284d), new NpgsqlTypes.NpgsqlPoint(x: 0.030336937188993773d, y: 0.689296381169149d), new NpgsqlTypes.NpgsqlPoint(x: 0.3506416608787497d, y: 0.39405920099309266d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2684893737067854d, y: 0.5567338877991302d), new NpgsqlTypes.NpgsqlPoint(x: 0.5159328560070409d, y: 0.835069300404333d), new NpgsqlTypes.NpgsqlPoint(x: 0.9461193543095642d, y: 0.4849612312686742d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09047085000458865d, y: 0.10063422461834914d), new NpgsqlTypes.NpgsqlPoint(x: 0.15456375805676947d, y: 0.652664743834783d), new NpgsqlTypes.NpgsqlPoint(x: 0.0709101720480676d, y: 0.4643893656345097d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9992319501116107d, y: 0.5088695010437059d), new NpgsqlTypes.NpgsqlPoint(x: 0.40382166355447724d, y: 0.8116913855897976d), new NpgsqlTypes.NpgsqlPoint(x: 0.11900349445645853d, y: 0.1052142918862492d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2771904169381745d, y: 0.9751417712110435d), new NpgsqlTypes.NpgsqlPoint(x: 0.043994015765741024d, y: 0.6282412305627313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9816547122468763d, y: 0.8950085872280308d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3773138563859172d, y: 0.9268537161046246d), new NpgsqlTypes.NpgsqlPoint(x: 0.4310738805890981d, y: 0.3398442719354614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7054978760930619d, y: 0.016377419737832244d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9882261906316282d, y: 0.7277580127496381d), new NpgsqlTypes.NpgsqlPoint(x: 0.8692025333819082d, y: 0.5578008975992835d), new NpgsqlTypes.NpgsqlPoint(x: 0.40125107959065687d, y: 0.025926365312814892d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40785659761563553d, y: 0.4518573663220954d), new NpgsqlTypes.NpgsqlPoint(x: 0.6490344207441209d, y: 0.07738675232508774d), new NpgsqlTypes.NpgsqlPoint(x: 0.4114401749502765d, y: 0.6145487880362195d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03411888574490429d, y: 0.3967656256638711d), new NpgsqlTypes.NpgsqlPoint(x: 0.7291648382260466d, y: 0.11943945072638795d), new NpgsqlTypes.NpgsqlPoint(x: 0.37008389344962245d, y: 0.6018059707286195d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1666135815320976d, y: 0.8874732658722092d), new NpgsqlTypes.NpgsqlPoint(x: 0.006559789720548825d, y: 0.6840965507863382d), new NpgsqlTypes.NpgsqlPoint(x: 0.8997382904712282d, y: 0.0378114898566132d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12360154170222482d, y: 0.903819377926514d), new NpgsqlTypes.NpgsqlPoint(x: 0.806373493303294d, y: 0.38263238560250357d), new NpgsqlTypes.NpgsqlPoint(x: 0.8918311361383969d, y: 0.7413954958407353d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7252946441893341d, y: 0.5786476385640911d), new NpgsqlTypes.NpgsqlPoint(x: 0.5530529124783513d, y: 0.5858965561394376d), new NpgsqlTypes.NpgsqlPoint(x: 0.5463544386794749d, y: 0.5259007139984719d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3073036849321855d, y: 0.7819922645847014d), new NpgsqlTypes.NpgsqlPoint(x: 0.2529113487695709d, y: 0.18691943951762757d), new NpgsqlTypes.NpgsqlPoint(x: 0.11401652611044644d, y: 0.18838041415594753d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6126519551030575d, y: 0.23805886079355176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8423361557611081d, y: 0.3124162724351066d), new NpgsqlTypes.NpgsqlPoint(x: 0.8252177782682925d, y: 0.6407183124864051d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5503844146005175d, y: 0.4994554910878013d), new NpgsqlTypes.NpgsqlPoint(x: 0.9752592221283707d, y: 0.10150805715149824d), new NpgsqlTypes.NpgsqlPoint(x: 0.370085417319438d, y: 0.6111093269105242d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9471992782405637d, y: 0.5517132286214691d), new NpgsqlTypes.NpgsqlPoint(x: 0.9415602517435195d, y: 0.44448682766584746d), new NpgsqlTypes.NpgsqlPoint(x: 0.13904371548095185d, y: 0.3859972594923201d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5263561650941342d, y: 0.0068288676088866795d), new NpgsqlTypes.NpgsqlPoint(x: 0.4020869894879653d, y: 0.6606865230975851d), new NpgsqlTypes.NpgsqlPoint(x: 0.39295040437632445d, y: 0.48736808963543865d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1903078672096038d, y: 0.9115468475390045d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470424621254853d, y: 0.7932802039375276d), new NpgsqlTypes.NpgsqlPoint(x: 0.229020476773097d, y: 0.7357123594941893d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4385117658032194d, y: 0.06020669120708333d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522695037129441d, y: 0.8301986599457268d), new NpgsqlTypes.NpgsqlPoint(x: 0.15590827233353122d, y: 0.6680143585928145d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6058053936101951d, y: 0.7119970732671503d), new NpgsqlTypes.NpgsqlPoint(x: 0.35277110560133007d, y: 0.29322937689317097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7577416326773442d, y: 0.37336195109670045d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05386779066832503d, y: 0.4032983010579928d), new NpgsqlTypes.NpgsqlPoint(x: 0.518822329974387d, y: 0.997586737253005d), new NpgsqlTypes.NpgsqlPoint(x: 0.36611811491653734d, y: 0.7073883512017398d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8198518965759584d, y: 0.927432937386278d), new NpgsqlTypes.NpgsqlPoint(x: 0.9759468753228345d, y: 0.18290359851734606d), new NpgsqlTypes.NpgsqlPoint(x: 0.20349117893339808d, y: 0.1439082890879685d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12208119180704435d, y: 0.9080870501477941d), new NpgsqlTypes.NpgsqlPoint(x: 0.9457472107742654d, y: 0.6338832954445204d), new NpgsqlTypes.NpgsqlPoint(x: 0.011998903321966403d, y: 0.38118404397157835d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5039611197182939d, y: 0.7656416071387656d), new NpgsqlTypes.NpgsqlPoint(x: 0.48005609207494415d, y: 0.8980125363506358d), new NpgsqlTypes.NpgsqlPoint(x: 0.8951384228784611d, y: 0.5311780664000902d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9052113446890179d, y: 0.8121785651791925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7809475756630022d, y: 0.010988927884518884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9847909116152926d, y: 0.441310761746902d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.90184324788799d, y: 0.7013000506833387d), new NpgsqlTypes.NpgsqlPoint(x: 0.48610782807466524d, y: 0.46635937023006346d), new NpgsqlTypes.NpgsqlPoint(x: 0.08256334752624672d, y: 0.8693746002810743d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05281157448903673d, y: 0.887098263170071d), new NpgsqlTypes.NpgsqlPoint(x: 0.3171483509093922d, y: 0.39082751245816116d), new NpgsqlTypes.NpgsqlPoint(x: 0.6920661626297523d, y: 0.009795928868819859d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11069239230906847d, y: 0.6648209913553885d), new NpgsqlTypes.NpgsqlPoint(x: 0.011184811185206978d, y: 0.4694198943883252d), new NpgsqlTypes.NpgsqlPoint(x: 0.0887677326026628d, y: 0.5828701976656026d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5641708491187615d, y: 0.001939317896416215d), new NpgsqlTypes.NpgsqlPoint(x: 0.8838791783835842d, y: 0.28225314231231535d), new NpgsqlTypes.NpgsqlPoint(x: 0.9032342119701149d, y: 0.8313383418065328d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8381465856023247d, y: 0.337277428860581d), new NpgsqlTypes.NpgsqlPoint(x: 0.6998490045286956d, y: 0.034886348627495845d), new NpgsqlTypes.NpgsqlPoint(x: 0.056983708632114216d, y: 0.15670990617527736d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42045547813597095d, y: 0.45631350938320236d), new NpgsqlTypes.NpgsqlPoint(x: 0.4626721769681372d, y: 0.5776435362825769d), new NpgsqlTypes.NpgsqlPoint(x: 0.9925639831026931d, y: 0.03856118673193265d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9024652653954235d, y: 0.7398662415048864d), new NpgsqlTypes.NpgsqlPoint(x: 0.517109214598374d, y: 0.327339110038116d), new NpgsqlTypes.NpgsqlPoint(x: 0.8394379583866876d, y: 0.6672302001758613d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29135303743687613d, y: 0.3575071763770392d), new NpgsqlTypes.NpgsqlPoint(x: 0.5902725126433345d, y: 0.2642165473474024d), new NpgsqlTypes.NpgsqlPoint(x: 0.4942007013469988d, y: 0.7779599517604047d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8993572122125535d, y: 0.5201517925466829d), new NpgsqlTypes.NpgsqlPoint(x: 0.19007559343162828d, y: 0.3263672215662444d), new NpgsqlTypes.NpgsqlPoint(x: 0.7346721898406205d, y: 0.7075795073423133d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6127950415710719d, y: 0.2965436770706361d), new NpgsqlTypes.NpgsqlPoint(x: 0.5792586307594162d, y: 0.3071593843428122d), new NpgsqlTypes.NpgsqlPoint(x: 0.8621101118331231d, y: 0.672612372629588d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15525065020646234d, y: 0.32574297543487996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7604859293562128d, y: 0.26436439673123324d), new NpgsqlTypes.NpgsqlPoint(x: 0.8080487075696963d, y: 0.9051145165272777d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31795035705650665d, y: 0.48237975874665995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6637702307149265d, y: 0.3063605146435603d), new NpgsqlTypes.NpgsqlPoint(x: 0.6707876627105359d, y: 0.6020257908896686d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7364225480014498d, y: 0.5445268623996178d), new NpgsqlTypes.NpgsqlPoint(x: 0.12759800868699178d, y: 0.8985777683437708d), new NpgsqlTypes.NpgsqlPoint(x: 0.6127585502621066d, y: 0.34196970552894645d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7012075575830972d, y: 0.22217179778728413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652771543716198d, y: 0.49049580619655264d), new NpgsqlTypes.NpgsqlPoint(x: 0.5034371199293782d, y: 0.21702619878587737d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5095106456064004d, y: 0.8038646735505534d), new NpgsqlTypes.NpgsqlPoint(x: 0.9508913914150384d, y: 0.9391892452474564d), new NpgsqlTypes.NpgsqlPoint(x: 0.19193861753325947d, y: 0.47402058896668087d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6617771229909987d, y: 0.03645296663951758d), new NpgsqlTypes.NpgsqlPoint(x: 0.8655100006569528d, y: 0.6904505079770263d), new NpgsqlTypes.NpgsqlPoint(x: 0.2766024390701315d, y: 0.5011446669022034d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5280608434729351d, y: 0.9011754614759668d), new NpgsqlTypes.NpgsqlPoint(x: 0.8420563994413293d, y: 0.17803492346086836d), new NpgsqlTypes.NpgsqlPoint(x: 0.9171868422761226d, y: 0.9754780643482304d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8312540889578286d, y: 0.014406039288896055d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768160104680545d, y: 0.5784696002080765d), new NpgsqlTypes.NpgsqlPoint(x: 0.24517657180628505d, y: 0.3902584480426652d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43344867505773776d, y: 0.10599986453151289d), new NpgsqlTypes.NpgsqlPoint(x: 0.17901205135986564d, y: 0.07094615082113298d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569538685283116d, y: 0.8837252496428354d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2151920946292465d, y: 0.4284542557574105d), new NpgsqlTypes.NpgsqlPoint(x: 0.7073796961641403d, y: 0.2988751285612087d), new NpgsqlTypes.NpgsqlPoint(x: 0.6709694712086656d, y: 0.13126842731045407d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9913950662868578d, y: 0.20543346923949724d), new NpgsqlTypes.NpgsqlPoint(x: 0.2770425594229434d, y: 0.9370548949025255d), new NpgsqlTypes.NpgsqlPoint(x: 0.7044630297741403d, y: 0.02847919977095248d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6687862116658261d, y: 0.3140331951158615d), new NpgsqlTypes.NpgsqlPoint(x: 0.9940283939531399d, y: 0.344870404540659d), new NpgsqlTypes.NpgsqlPoint(x: 0.6029769379732276d, y: 0.3390002130749904d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04686604854590237d, y: 0.9408116853237507d), new NpgsqlTypes.NpgsqlPoint(x: 0.06594521932385211d, y: 0.3601762098014468d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549662546587549d, y: 0.6131708964495599d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23276772064144136d, y: 0.24782528133343507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9826607874213629d, y: 0.2600031692035655d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040911563341182d, y: 0.8730409458246895d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07029320744419298d, y: 0.737687795222061d), new NpgsqlTypes.NpgsqlPoint(x: 0.42881166186161046d, y: 0.4608593938493216d), new NpgsqlTypes.NpgsqlPoint(x: 0.189917645943252d, y: 0.7955811346944488d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27112150831786963d, y: 0.8732399996375259d), new NpgsqlTypes.NpgsqlPoint(x: 0.04765704188558573d, y: 0.9411976104427884d), new NpgsqlTypes.NpgsqlPoint(x: 0.09879739573227098d, y: 0.6054899677310276d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4393905052193927d, y: 0.03937919726266892d), new NpgsqlTypes.NpgsqlPoint(x: 0.206717757082172d, y: 0.6953314822933135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8458249807560408d, y: 0.8662788416024072d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37641440708271257d, y: 0.3343363769499422d), new NpgsqlTypes.NpgsqlPoint(x: 0.29431319976416526d, y: 0.43539929143298817d), new NpgsqlTypes.NpgsqlPoint(x: 0.7460782667273086d, y: 0.6139866364338681d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7852790253769236d, y: 0.3267845787618141d), new NpgsqlTypes.NpgsqlPoint(x: 0.9134376109135586d, y: 0.4974692688049571d), new NpgsqlTypes.NpgsqlPoint(x: 0.7633451268544434d, y: 0.051390805125880346d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20678154891806633d, y: 0.9791348469573302d), new NpgsqlTypes.NpgsqlPoint(x: 0.43676213110909934d, y: 0.8519662060966948d), new NpgsqlTypes.NpgsqlPoint(x: 0.272827628911962d, y: 0.9901531723899708d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5036376202157253d, y: 0.9496205939835604d), new NpgsqlTypes.NpgsqlPoint(x: 0.3907815592264513d, y: 0.11250236110082845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5391605697753442d, y: 0.821908609710404d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5963190989187057d, y: 0.8643142056354132d), new NpgsqlTypes.NpgsqlPoint(x: 0.4444992278535259d, y: 0.2757667505253908d), new NpgsqlTypes.NpgsqlPoint(x: 0.47402312054581963d, y: 0.7265970718963792d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22477334213930789d, y: 0.5264592962624619d), new NpgsqlTypes.NpgsqlPoint(x: 0.8923768219307778d, y: 0.561373222803d), new NpgsqlTypes.NpgsqlPoint(x: 0.30476827948799146d, y: 0.021295787939969446d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4636446350282425d, y: 0.7467779935017408d), new NpgsqlTypes.NpgsqlPoint(x: 0.48193715953131044d, y: 0.23209026728343785d), new NpgsqlTypes.NpgsqlPoint(x: 0.9289324062008164d, y: 0.6866864829340493d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26154210921610954d, y: 0.43817958958804437d), new NpgsqlTypes.NpgsqlPoint(x: 0.4433996998318108d, y: 0.45406722826192203d), new NpgsqlTypes.NpgsqlPoint(x: 0.6714409458025119d, y: 0.31575744584713716d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6060500857123459d, y: 0.7139542617359166d), new NpgsqlTypes.NpgsqlPoint(x: 0.8545631500766827d, y: 0.014236467364914795d), new NpgsqlTypes.NpgsqlPoint(x: 0.8662886271825513d, y: 0.5596524036077956d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.200145666356624d, y: 0.9591554507649739d), new NpgsqlTypes.NpgsqlPoint(x: 0.36779431885315916d, y: 0.7659200381496977d), new NpgsqlTypes.NpgsqlPoint(x: 0.7494431095724002d, y: 0.23319111631210632d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9436916162379155d, y: 0.669418452090259d), new NpgsqlTypes.NpgsqlPoint(x: 0.7024721030685575d, y: 0.8455289402870123d), new NpgsqlTypes.NpgsqlPoint(x: 0.2309704419795211d, y: 0.6375025644459797d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9156012233799891d, y: 0.4732502282253851d), new NpgsqlTypes.NpgsqlPoint(x: 0.45214204142164827d, y: 0.7099750400334346d), new NpgsqlTypes.NpgsqlPoint(x: 0.9613151625903171d, y: 0.3909466306179967d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49946217526475534d, y: 0.8807126828553961d), new NpgsqlTypes.NpgsqlPoint(x: 0.8647568390934608d, y: 0.6603933294041101d), new NpgsqlTypes.NpgsqlPoint(x: 0.43629381529070776d, y: 0.7297886719155793d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8393061387120156d, y: 0.45446351692452047d), new NpgsqlTypes.NpgsqlPoint(x: 0.8289231974001638d, y: 0.21683190550954434d), new NpgsqlTypes.NpgsqlPoint(x: 0.17737472119076747d, y: 0.09332455077655932d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5491469796482342d, y: 0.19984903266088638d), new NpgsqlTypes.NpgsqlPoint(x: 0.9780863259537818d, y: 0.5714332595803485d), new NpgsqlTypes.NpgsqlPoint(x: 0.5032644694523538d, y: 0.20783043342876573d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5602125891570892d, y: 0.2511818467549476d), new NpgsqlTypes.NpgsqlPoint(x: 0.254224540072019d, y: 0.12257973139115352d), new NpgsqlTypes.NpgsqlPoint(x: 0.23529130717648072d, y: 0.7328734129934896d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37343309210643116d, y: 0.6431096191813626d), new NpgsqlTypes.NpgsqlPoint(x: 0.052556727290508864d, y: 0.904067394977878d), new NpgsqlTypes.NpgsqlPoint(x: 0.2543656633901197d, y: 0.08072724812493037d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30389794193359043d, y: 0.3067821755733393d), new NpgsqlTypes.NpgsqlPoint(x: 0.11630581835451526d, y: 0.9377924625446062d), new NpgsqlTypes.NpgsqlPoint(x: 0.27788346402632547d, y: 0.4811771543112273d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7741841660766978d, y: 0.7462494765005544d), new NpgsqlTypes.NpgsqlPoint(x: 0.8392751649001327d, y: 0.6180208827464904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5044148913462831d, y: 0.6761949893351379d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5377348169105893d, y: 0.8588374087970085d), new NpgsqlTypes.NpgsqlPoint(x: 0.26099593156908985d, y: 0.4859026528266954d), new NpgsqlTypes.NpgsqlPoint(x: 0.8758538576933813d, y: 0.2710799565329849d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03681587457595348d, y: 0.23933133239021442d), new NpgsqlTypes.NpgsqlPoint(x: 0.3584204349235517d, y: 0.17532872370061847d), new NpgsqlTypes.NpgsqlPoint(x: 0.8956794422174347d, y: 0.41307495353735224d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08713371830404781d, y: 0.9936451904472585d), new NpgsqlTypes.NpgsqlPoint(x: 0.8178069281719483d, y: 0.2922777872983212d), new NpgsqlTypes.NpgsqlPoint(x: 0.3416020260221251d, y: 0.48822023727656005d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12181545900098167d, y: 0.9480893284655247d), new NpgsqlTypes.NpgsqlPoint(x: 0.3836361384483854d, y: 0.384189013688909d), new NpgsqlTypes.NpgsqlPoint(x: 0.24225185906323587d, y: 0.40038173534371335d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08062990764433964d, y: 0.8666493478368553d), new NpgsqlTypes.NpgsqlPoint(x: 0.40530675018449924d, y: 0.7515485380279582d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810294085281385d, y: 0.6796407660123547d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8648219575745902d, y: 0.45043710267189985d), new NpgsqlTypes.NpgsqlPoint(x: 0.14782574065229726d, y: 0.7375618089882963d), new NpgsqlTypes.NpgsqlPoint(x: 0.006237578741285166d, y: 0.5476344355118774d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8334203807336035d, y: 0.4100580788032959d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083985212137617d, y: 0.2800551841219284d), new NpgsqlTypes.NpgsqlPoint(x: 0.1977106340589162d, y: 0.32740851150624484d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7262652316448204d, y: 0.10698287374967164d), new NpgsqlTypes.NpgsqlPoint(x: 0.43101840125186563d, y: 0.9590687121193722d), new NpgsqlTypes.NpgsqlPoint(x: 0.04004478206115747d, y: 0.6139920198783823d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9567267504212704d, y: 0.9178545936488636d), new NpgsqlTypes.NpgsqlPoint(x: 0.15241076085325067d, y: 0.18793153144770336d), new NpgsqlTypes.NpgsqlPoint(x: 0.21750074104377182d, y: 0.5098275406094437d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20307458270861956d, y: 0.7238949427598255d), new NpgsqlTypes.NpgsqlPoint(x: 0.2862650220393681d, y: 0.15643994173379772d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205370604804179d, y: 0.10291394656802377d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6311650769880512d, y: 0.9043728841942752d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029317087942661d, y: 0.3291650180180955d), new NpgsqlTypes.NpgsqlPoint(x: 0.08756212551308418d, y: 0.7419679873090207d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1356641908477928d, y: 0.8484827527958935d), new NpgsqlTypes.NpgsqlPoint(x: 0.9263197790517818d, y: 0.298432407298283d), new NpgsqlTypes.NpgsqlPoint(x: 0.3650387634012098d, y: 0.9203512769839435d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6943306023619528d, y: 0.32128806233915397d), new NpgsqlTypes.NpgsqlPoint(x: 0.6080718979241084d, y: 0.43258549660448786d), new NpgsqlTypes.NpgsqlPoint(x: 0.8084149319666514d, y: 0.02960613791949096d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9924313400917089d, y: 0.7821423102203882d), new NpgsqlTypes.NpgsqlPoint(x: 0.33755650302675444d, y: 0.8676271082220107d), new NpgsqlTypes.NpgsqlPoint(x: 0.8128478057718416d, y: 0.6632177137143038d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3824712631977738d, y: 0.915392516883787d), new NpgsqlTypes.NpgsqlPoint(x: 0.5412848219709611d, y: 0.6878949990934924d), new NpgsqlTypes.NpgsqlPoint(x: 0.3662194627389308d, y: 0.228242114551665d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8673389176806972d, y: 0.9652850156659294d), new NpgsqlTypes.NpgsqlPoint(x: 0.07031591623579492d, y: 0.6315547658629748d), new NpgsqlTypes.NpgsqlPoint(x: 0.7655750541246228d, y: 0.9125827588105877d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2827791047290501d, y: 0.5777252917271205d), new NpgsqlTypes.NpgsqlPoint(x: 0.8802669810685717d, y: 0.5966782725284321d), new NpgsqlTypes.NpgsqlPoint(x: 0.1849640806086108d, y: 0.4724549835333892d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.480900059346859d, y: 0.2766424690937732d), new NpgsqlTypes.NpgsqlPoint(x: 0.8382887793831899d, y: 0.5484608795777784d), new NpgsqlTypes.NpgsqlPoint(x: 0.8635627875612758d, y: 0.45684381378245653d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9418529726026424d, y: 0.8189678377293786d), new NpgsqlTypes.NpgsqlPoint(x: 0.470329849361816d, y: 0.5479518232545417d), new NpgsqlTypes.NpgsqlPoint(x: 0.7691947874407692d, y: 0.1547448890790022d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20219805601367957d, y: 0.19262657694819718d), new NpgsqlTypes.NpgsqlPoint(x: 0.013429846368129605d, y: 0.4585694249186033d), new NpgsqlTypes.NpgsqlPoint(x: 0.26840618343119615d, y: 0.6189168466982153d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6242118088489955d, y: 0.6061499087735939d), new NpgsqlTypes.NpgsqlPoint(x: 0.6730866185590884d, y: 0.5719119800390626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6354736887848293d, y: 0.7265744140561222d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8048218343209811d, y: 0.4456968664243053d), new NpgsqlTypes.NpgsqlPoint(x: 0.25980917963701156d, y: 0.6372677953854273d), new NpgsqlTypes.NpgsqlPoint(x: 0.4170238676577128d, y: 0.4573817898375112d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30099774829719705d, y: 0.3767625743524071d), new NpgsqlTypes.NpgsqlPoint(x: 0.04176358075355657d, y: 0.07051135118165008d), new NpgsqlTypes.NpgsqlPoint(x: 0.1947420206033762d, y: 0.9043013536999092d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16553777849917384d, y: 0.08419061043162901d), new NpgsqlTypes.NpgsqlPoint(x: 0.6376376263086608d, y: 0.8174076502983493d), new NpgsqlTypes.NpgsqlPoint(x: 0.16683228268641737d, y: 0.7576420292855419d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14951350639345817d, y: 0.8208196410669092d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006060091869588d, y: 0.7131563189229031d), new NpgsqlTypes.NpgsqlPoint(x: 0.7869894920726895d, y: 0.5053138854017034d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28508364398039854d, y: 0.4833813650504083d), new NpgsqlTypes.NpgsqlPoint(x: 0.9557025935864085d, y: 0.6987480569390716d), new NpgsqlTypes.NpgsqlPoint(x: 0.328047745042953d, y: 0.16495442899186918d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6144637333589962d, y: 0.052999739387022626d), new NpgsqlTypes.NpgsqlPoint(x: 0.43239640085111297d, y: 0.942443766499428d), new NpgsqlTypes.NpgsqlPoint(x: 0.03867732926738776d, y: 0.9381881685107127d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7671180352761061d, y: 0.749599352837735d), new NpgsqlTypes.NpgsqlPoint(x: 0.17755586712094473d, y: 0.22171541225889602d), new NpgsqlTypes.NpgsqlPoint(x: 0.45042148420597194d, y: 0.09760250225991929d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8104673284416709d, y: 0.36570270237965363d), new NpgsqlTypes.NpgsqlPoint(x: 0.985834467224451d, y: 0.010922274286199962d), new NpgsqlTypes.NpgsqlPoint(x: 0.14581399582212495d, y: 0.9286183655333421d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.305828980748041d, y: 0.42313821889188197d), new NpgsqlTypes.NpgsqlPoint(x: 0.463340592831884d, y: 0.31570017300596653d), new NpgsqlTypes.NpgsqlPoint(x: 0.8574356343441767d, y: 0.30377400732760873d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9732058072160489d, y: 0.4609191748772675d), new NpgsqlTypes.NpgsqlPoint(x: 0.495152371838977d, y: 0.34754460253732544d), new NpgsqlTypes.NpgsqlPoint(x: 0.41062811816555056d, y: 0.7882743277587599d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7648706908746307d, y: 0.3319756803977443d), new NpgsqlTypes.NpgsqlPoint(x: 0.5774329148473519d, y: 0.2568023383644804d), new NpgsqlTypes.NpgsqlPoint(x: 0.44223105931522844d, y: 0.10055623209264997d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33739383820824886d, y: 0.30689550189284254d), new NpgsqlTypes.NpgsqlPoint(x: 0.5290012630456764d, y: 0.24884650705697509d), new NpgsqlTypes.NpgsqlPoint(x: 0.7352821922481529d, y: 0.620694973912884d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11781389278408605d, y: 0.643994861519696d), new NpgsqlTypes.NpgsqlPoint(x: 0.29976566983947284d, y: 0.19607134601526943d), new NpgsqlTypes.NpgsqlPoint(x: 0.0424141666968082d, y: 0.37729266669894135d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6121216013150472d, y: 0.975601630769062d), new NpgsqlTypes.NpgsqlPoint(x: 0.9376691589675779d, y: 0.4033454814913471d), new NpgsqlTypes.NpgsqlPoint(x: 0.7088986364732044d, y: 0.14206894228576317d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.987818278365352d, y: 0.8189852283735036d), new NpgsqlTypes.NpgsqlPoint(x: 0.7213952839284388d, y: 0.3635749978522942d), new NpgsqlTypes.NpgsqlPoint(x: 0.7176236708081136d, y: 0.9989697219466284d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5924565029114394d, y: 0.38286691067095335d), new NpgsqlTypes.NpgsqlPoint(x: 0.2497226592199887d, y: 0.5189971355767267d), new NpgsqlTypes.NpgsqlPoint(x: 0.12343438356395542d, y: 0.07427788827512338d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39293186041586126d, y: 0.6835256049930825d), new NpgsqlTypes.NpgsqlPoint(x: 0.51809533379654d, y: 0.282009652281501d), new NpgsqlTypes.NpgsqlPoint(x: 0.3476478726912491d, y: 0.9070615091707661d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8095915255552316d, y: 0.026066800861526684d), new NpgsqlTypes.NpgsqlPoint(x: 0.3319787001675155d, y: 0.7964676968897847d), new NpgsqlTypes.NpgsqlPoint(x: 0.39840277311782313d, y: 0.5905315077409876d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9909040989530722d, y: 0.6784085680397761d), new NpgsqlTypes.NpgsqlPoint(x: 0.4602305457999156d, y: 0.46126570071588147d), new NpgsqlTypes.NpgsqlPoint(x: 0.6527777035101676d, y: 0.37192510438675996d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02356926588298358d, y: 0.6910799596123786d), new NpgsqlTypes.NpgsqlPoint(x: 0.5303255675565688d, y: 0.4911296168213025d), new NpgsqlTypes.NpgsqlPoint(x: 0.089261595314444d, y: 0.07365055968485623d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7218858087522992d, y: 0.4746183396039845d), new NpgsqlTypes.NpgsqlPoint(x: 0.2910230201608829d, y: 0.9985961286303544d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180855569374864d, y: 0.820717743437188d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5785479538062193d, y: 0.5096408717619632d), new NpgsqlTypes.NpgsqlPoint(x: 0.9187055311914603d, y: 0.5791331769429778d), new NpgsqlTypes.NpgsqlPoint(x: 0.48874986548469923d, y: 0.5505687945934237d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08085225782835026d, y: 0.159723424535001d), new NpgsqlTypes.NpgsqlPoint(x: 0.8864424627191633d, y: 0.10432199505164041d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201952048370637d, y: 0.11469388584129003d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3620814416554896d, y: 0.24982020006679695d), new NpgsqlTypes.NpgsqlPoint(x: 0.9356883609373076d, y: 0.2541841176183015d), new NpgsqlTypes.NpgsqlPoint(x: 0.4674216369167451d, y: 0.723875806564296d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3885288387454815d, y: 0.34936870574961154d), new NpgsqlTypes.NpgsqlPoint(x: 0.6914130575042691d, y: 0.5594315548785112d), new NpgsqlTypes.NpgsqlPoint(x: 0.5684924748953019d, y: 0.4851589646299813d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5404902426820234d, y: 0.3930095281438505d), new NpgsqlTypes.NpgsqlPoint(x: 0.2767842015623513d, y: 0.9002304769787113d), new NpgsqlTypes.NpgsqlPoint(x: 0.5293986927268017d, y: 0.2777307190241851d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008928725943735172d, y: 0.5794396879370897d), new NpgsqlTypes.NpgsqlPoint(x: 0.05571350574391509d, y: 0.6243227152613612d), new NpgsqlTypes.NpgsqlPoint(x: 0.9809208103936111d, y: 0.6862341399235029d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30637955211009615d, y: 0.6548878862055351d), new NpgsqlTypes.NpgsqlPoint(x: 0.8265753331367437d, y: 0.12115495631406414d), new NpgsqlTypes.NpgsqlPoint(x: 0.8820713128487299d, y: 0.36999688883422954d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6584026943821142d, y: 0.20355353280094657d), new NpgsqlTypes.NpgsqlPoint(x: 0.7659160239887876d, y: 0.8759234067619341d), new NpgsqlTypes.NpgsqlPoint(x: 0.7404037871524348d, y: 0.8439698893456172d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5741537312193147d, y: 0.24155742067351305d), new NpgsqlTypes.NpgsqlPoint(x: 0.36237977669771493d, y: 0.9673143947550487d), new NpgsqlTypes.NpgsqlPoint(x: 0.8946519182600626d, y: 0.055070789902224915d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5996247315461392d, y: 0.8826002299280284d), new NpgsqlTypes.NpgsqlPoint(x: 0.3113211760079968d, y: 0.4829297197384781d), new NpgsqlTypes.NpgsqlPoint(x: 0.9465007390469816d, y: 0.2987266707571855d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9511924117346207d, y: 0.18240862437157312d), new NpgsqlTypes.NpgsqlPoint(x: 0.9579561703739351d, y: 0.4694123605848173d), new NpgsqlTypes.NpgsqlPoint(x: 0.16121908356397474d, y: 0.7828422444140173d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8539869662492267d, y: 0.33708514082439445d), new NpgsqlTypes.NpgsqlPoint(x: 0.29807209544073465d, y: 0.13566146986925187d), new NpgsqlTypes.NpgsqlPoint(x: 0.643387809969947d, y: 0.8601210821628625d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13559774041661976d, y: 0.42166573695893095d), new NpgsqlTypes.NpgsqlPoint(x: 0.602069669535798d, y: 0.614906766329639d), new NpgsqlTypes.NpgsqlPoint(x: 0.08760178752568437d, y: 0.17869441866916735d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8533005957702983d, y: 0.6166047175647937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8422866053424725d, y: 0.571471046604722d), new NpgsqlTypes.NpgsqlPoint(x: 0.6004638496829524d, y: 0.0008209151806025661d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03100598460616355d, y: 0.17946391266255957d), new NpgsqlTypes.NpgsqlPoint(x: 0.6377262916604587d, y: 0.08104435310177016d), new NpgsqlTypes.NpgsqlPoint(x: 0.295129190567492d, y: 0.7343999594381951d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5344442540973406d, y: 0.8741555515704535d), new NpgsqlTypes.NpgsqlPoint(x: 0.9498875087169361d, y: 0.3134676904446284d), new NpgsqlTypes.NpgsqlPoint(x: 0.23045265888377697d, y: 0.656702295272279d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4877514465394417d, y: 0.6449559237788968d), new NpgsqlTypes.NpgsqlPoint(x: 0.8006024444926181d, y: 0.5280767466762761d), new NpgsqlTypes.NpgsqlPoint(x: 0.1420309934396372d, y: 0.04434373474893705d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7917107690733999d, y: 0.445286801521552d), new NpgsqlTypes.NpgsqlPoint(x: 0.45136140705818717d, y: 0.0694247081728031d), new NpgsqlTypes.NpgsqlPoint(x: 0.2016463486709692d, y: 0.10608904175209577d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3583211410965358d, y: 0.5642593126801152d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040192774169373d, y: 0.40656951621936277d), new NpgsqlTypes.NpgsqlPoint(x: 0.9056679614972024d, y: 0.40688797108751185d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8579353248677812d, y: 0.26391869566404524d), new NpgsqlTypes.NpgsqlPoint(x: 0.7532324907490981d, y: 0.5555038207212588d), new NpgsqlTypes.NpgsqlPoint(x: 0.03801359854916442d, y: 0.31129902361633477d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6082387836545998d, y: 0.08716350743854895d), new NpgsqlTypes.NpgsqlPoint(x: 0.42668651377670286d, y: 0.023973337786003523d), new NpgsqlTypes.NpgsqlPoint(x: 0.8758334274321682d, y: 0.88072173599392d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.532520426849804d, y: 0.0010757692898791804d), new NpgsqlTypes.NpgsqlPoint(x: 0.7982310940380957d, y: 0.9133129847670057d), new NpgsqlTypes.NpgsqlPoint(x: 0.3198045870298044d, y: 0.9964168626766671d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07439472977444084d, y: 0.9737544737639832d), new NpgsqlTypes.NpgsqlPoint(x: 0.22891616570374407d, y: 0.7138187072618308d), new NpgsqlTypes.NpgsqlPoint(x: 0.4440233975040332d, y: 0.730836495567642d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26329226295962627d, y: 0.003468979291641361d), new NpgsqlTypes.NpgsqlPoint(x: 0.656708761980433d, y: 0.3564650976222238d), new NpgsqlTypes.NpgsqlPoint(x: 0.8906278521723289d, y: 0.06300536983172389d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6131640165168767d, y: 0.6469439700588304d), new NpgsqlTypes.NpgsqlPoint(x: 0.285729717639152d, y: 0.9636806274765798d), new NpgsqlTypes.NpgsqlPoint(x: 0.4530352523082447d, y: 0.4914658407323619d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9559256214765762d, y: 0.5696675908563306d), new NpgsqlTypes.NpgsqlPoint(x: 0.934735814491191d, y: 0.6411413232480027d), new NpgsqlTypes.NpgsqlPoint(x: 0.4950178585040069d, y: 0.9624068434857491d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3672875895514781d, y: 0.4664013789188508d), new NpgsqlTypes.NpgsqlPoint(x: 0.7918852916512747d, y: 0.7400252567503763d), new NpgsqlTypes.NpgsqlPoint(x: 0.11873968322911754d, y: 0.05013096023922203d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04816123624449209d, y: 0.3079133366947553d), new NpgsqlTypes.NpgsqlPoint(x: 0.1689124009470614d, y: 0.3106783786533528d), new NpgsqlTypes.NpgsqlPoint(x: 0.19835115815034177d, y: 0.06349535761226754d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8441117128703691d, y: 0.8441270310545687d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328038015614825d, y: 0.6992524088773218d), new NpgsqlTypes.NpgsqlPoint(x: 0.2220494139153789d, y: 0.09785638942137387d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3164680812888758d, y: 0.3834619629917756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5592430475212032d, y: 0.5938344901724751d), new NpgsqlTypes.NpgsqlPoint(x: 0.627804628890207d, y: 0.5895169144657098d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7641204427283964d, y: 0.08882335490429516d), new NpgsqlTypes.NpgsqlPoint(x: 0.3196423283789662d, y: 0.11791272046171475d), new NpgsqlTypes.NpgsqlPoint(x: 0.5186560948619291d, y: 0.4604067245413489d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3454802634522869d, y: 0.39258337921939945d), new NpgsqlTypes.NpgsqlPoint(x: 0.20691930706310524d, y: 0.8292787044856511d), new NpgsqlTypes.NpgsqlPoint(x: 0.2865786499239765d, y: 0.7972453070394596d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0998703904703836d, y: 0.6803738044441013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5986563353267468d, y: 0.03356240050134318d), new NpgsqlTypes.NpgsqlPoint(x: 0.891639104373998d, y: 0.40672236474583423d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45406763210433665d, y: 0.6821336369886962d), new NpgsqlTypes.NpgsqlPoint(x: 0.22130413343290178d, y: 0.4457405625852444d), new NpgsqlTypes.NpgsqlPoint(x: 0.8134479563860383d, y: 0.832340596049277d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6082089271885095d, y: 0.9747301436164355d), new NpgsqlTypes.NpgsqlPoint(x: 0.8269046283306565d, y: 0.9493081963312509d), new NpgsqlTypes.NpgsqlPoint(x: 0.5794932497755722d, y: 0.7226268153892191d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2083778005779663d, y: 0.3864508770706797d), new NpgsqlTypes.NpgsqlPoint(x: 0.6473295362217913d, y: 0.3668088602281676d), new NpgsqlTypes.NpgsqlPoint(x: 0.9860666306709122d, y: 0.9893730322316187d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.838999632533037d, y: 0.18871238610862706d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361210931262411d, y: 0.43095429315293676d), new NpgsqlTypes.NpgsqlPoint(x: 0.2756499355669394d, y: 0.15660541313486143d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44378387280395604d, y: 0.11724806194985771d), new NpgsqlTypes.NpgsqlPoint(x: 0.7915067656716583d, y: 0.5194921873990485d), new NpgsqlTypes.NpgsqlPoint(x: 0.1232188270612109d, y: 0.6686062041508567d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7538665286747461d, y: 0.3037730202633786d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914908288015587d, y: 0.24528974750359112d), new NpgsqlTypes.NpgsqlPoint(x: 0.03207724081959584d, y: 0.8748566312953622d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23244518870066144d, y: 0.3022622657781219d), new NpgsqlTypes.NpgsqlPoint(x: 0.4165249689662426d, y: 0.27739769793639146d), new NpgsqlTypes.NpgsqlPoint(x: 0.5058223293573422d, y: 0.45891904433829445d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5048275000812162d, y: 0.8312172864786355d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600034405341294d, y: 0.8539288824536512d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560781729446369d, y: 0.9976997634465541d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4352523892845528d, y: 0.8047669302591638d), new NpgsqlTypes.NpgsqlPoint(x: 0.375341712994292d, y: 0.058057496139371834d), new NpgsqlTypes.NpgsqlPoint(x: 0.03552381014574468d, y: 0.20859127355213503d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2947316656489699d, y: 0.15139530210629015d), new NpgsqlTypes.NpgsqlPoint(x: 0.23765930123033507d, y: 0.5312510230650671d), new NpgsqlTypes.NpgsqlPoint(x: 0.2721713149937268d, y: 0.06567323841820805d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2549209450071409d, y: 0.8613703633531471d), new NpgsqlTypes.NpgsqlPoint(x: 0.7677080912364074d, y: 0.1792244875611173d), new NpgsqlTypes.NpgsqlPoint(x: 0.2779999199682216d, y: 0.9253653322012275d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46249725233420114d, y: 0.7920740613724366d), new NpgsqlTypes.NpgsqlPoint(x: 0.08304400222582575d, y: 0.5342358346819157d), new NpgsqlTypes.NpgsqlPoint(x: 0.1056897981791396d, y: 0.23576818245000153d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08256716341929338d, y: 0.2339594811728345d), new NpgsqlTypes.NpgsqlPoint(x: 0.7955678218873964d, y: 0.8406215072819699d), new NpgsqlTypes.NpgsqlPoint(x: 0.21609943714209423d, y: 0.4221322631667227d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6434158694413524d, y: 0.8854524394957611d), new NpgsqlTypes.NpgsqlPoint(x: 0.8312791292629963d, y: 0.725885494755387d), new NpgsqlTypes.NpgsqlPoint(x: 0.2629349271588888d, y: 0.9598719935990881d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12986977840759018d, y: 0.5651217732128626d), new NpgsqlTypes.NpgsqlPoint(x: 0.5379249007049623d, y: 0.5831349404826206d), new NpgsqlTypes.NpgsqlPoint(x: 0.8378477145661287d, y: 0.2666109848333762d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18041613099902898d, y: 0.3793796565599262d), new NpgsqlTypes.NpgsqlPoint(x: 0.9906130806253793d, y: 0.7667846664820602d), new NpgsqlTypes.NpgsqlPoint(x: 0.31194393634861184d, y: 0.7198289208342905d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03911377059951282d, y: 0.5930685234664683d), new NpgsqlTypes.NpgsqlPoint(x: 0.3707383075982952d, y: 0.0262578621499977d), new NpgsqlTypes.NpgsqlPoint(x: 0.2556063297446064d, y: 0.08830363467425995d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.897622810668954d, y: 0.15120244346464506d), new NpgsqlTypes.NpgsqlPoint(x: 0.19396751412645197d, y: 0.31278575965915345d), new NpgsqlTypes.NpgsqlPoint(x: 0.7820143967985216d, y: 0.2247135557112434d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.883046971791472d, y: 0.7827163852514929d), new NpgsqlTypes.NpgsqlPoint(x: 0.3069848024553815d, y: 0.19170128284490795d), new NpgsqlTypes.NpgsqlPoint(x: 0.7727875121433965d, y: 0.15975049884183934d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5273156162999012d, y: 0.9931970194041335d), new NpgsqlTypes.NpgsqlPoint(x: 0.5269580253475294d, y: 0.2066770453453063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7423755995599562d, y: 0.7355026310865942d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5807358811513813d, y: 0.29858310423407475d), new NpgsqlTypes.NpgsqlPoint(x: 0.18281391377758316d, y: 0.7269982121830734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7633534570959676d, y: 0.8093008463919743d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2534485943847625d, y: 0.981766183273569d), new NpgsqlTypes.NpgsqlPoint(x: 0.5156319510749054d, y: 0.9610039892468999d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131352562356875d, y: 0.8983301714985152d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7543888987460272d, y: 0.9378545117276643d), new NpgsqlTypes.NpgsqlPoint(x: 0.4542528665331258d, y: 0.44838353996483693d), new NpgsqlTypes.NpgsqlPoint(x: 0.462121032778121d, y: 0.3331391213544327d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6259781932782985d, y: 0.5453222962740506d), new NpgsqlTypes.NpgsqlPoint(x: 0.04320419328679237d, y: 0.43728488911192887d), new NpgsqlTypes.NpgsqlPoint(x: 0.24980621211006293d, y: 0.5142436957322184d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7148170718753731d, y: 0.9328125519651037d), new NpgsqlTypes.NpgsqlPoint(x: 0.28433111058156346d, y: 0.7099109196501574d), new NpgsqlTypes.NpgsqlPoint(x: 0.029236864360328685d, y: 0.08590081367302738d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11658278053659721d, y: 0.6641304939705214d), new NpgsqlTypes.NpgsqlPoint(x: 0.7765805844579506d, y: 0.7684101385884101d), new NpgsqlTypes.NpgsqlPoint(x: 0.5851350298097694d, y: 0.7095031837828224d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8410641856617767d, y: 0.8797171541282077d), new NpgsqlTypes.NpgsqlPoint(x: 0.38184717173273364d, y: 0.4274779883585714d), new NpgsqlTypes.NpgsqlPoint(x: 0.6473668997771013d, y: 0.7967678606022065d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3914633399141718d, y: 0.39973525126108034d), new NpgsqlTypes.NpgsqlPoint(x: 0.11430037405977334d, y: 0.7171866497205797d), new NpgsqlTypes.NpgsqlPoint(x: 0.639606608681286d, y: 0.19957903811522681d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9415066747607488d, y: 0.4290604204121208d), new NpgsqlTypes.NpgsqlPoint(x: 0.7688648733675777d, y: 0.9558712987679175d), new NpgsqlTypes.NpgsqlPoint(x: 0.44103500235199855d, y: 0.04833155746618345d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007427834005655165d, y: 0.6482610798086245d), new NpgsqlTypes.NpgsqlPoint(x: 0.9133546987335569d, y: 0.21457893331188693d), new NpgsqlTypes.NpgsqlPoint(x: 0.20960694197879393d, y: 0.087173504447418d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49135295075471386d, y: 0.87405464543292d), new NpgsqlTypes.NpgsqlPoint(x: 0.39996679626240417d, y: 0.8518249935562703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7733475852461775d, y: 0.7201707253058058d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8791353894464844d, y: 0.806815816133207d), new NpgsqlTypes.NpgsqlPoint(x: 0.7838687126593993d, y: 0.960851106876016d), new NpgsqlTypes.NpgsqlPoint(x: 0.6637207560099595d, y: 0.38421707482797574d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6432611456674412d, y: 0.7802814685296519d), new NpgsqlTypes.NpgsqlPoint(x: 0.6795047416864867d, y: 0.092398238707882d), new NpgsqlTypes.NpgsqlPoint(x: 0.41393981016839165d, y: 0.6722688241426437d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6777872748356167d, y: 0.7116633027357511d), new NpgsqlTypes.NpgsqlPoint(x: 0.39119345675237827d, y: 0.19179673834942856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5001704512232918d, y: 0.11529008780381478d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3286028063797515d, y: 0.4057985933811953d), new NpgsqlTypes.NpgsqlPoint(x: 0.03176727958374881d, y: 0.8538881102236718d), new NpgsqlTypes.NpgsqlPoint(x: 0.05863334551871402d, y: 0.22809304257053764d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10962746538220136d, y: 0.84009735146127d), new NpgsqlTypes.NpgsqlPoint(x: 0.020285404032854837d, y: 0.5245800487840114d), new NpgsqlTypes.NpgsqlPoint(x: 0.7679735031174528d, y: 0.6797907984436199d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6776592800265068d, y: 0.06516189250123283d), new NpgsqlTypes.NpgsqlPoint(x: 0.14476413140676436d, y: 0.21797743581460516d), new NpgsqlTypes.NpgsqlPoint(x: 0.0929652267429456d, y: 0.5689084124543229d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15973709231762412d, y: 0.45778633979255623d), new NpgsqlTypes.NpgsqlPoint(x: 0.4289167526514309d, y: 0.582936830047546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6649415047546368d, y: 0.8385919372953847d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7939864747515561d, y: 0.2724467612737863d), new NpgsqlTypes.NpgsqlPoint(x: 0.07410805654181374d, y: 0.12899901866271124d), new NpgsqlTypes.NpgsqlPoint(x: 0.3031545197362532d, y: 0.3268423749907561d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36790675364587866d, y: 0.5220909016032673d), new NpgsqlTypes.NpgsqlPoint(x: 0.20924211530147552d, y: 0.10419579043755745d), new NpgsqlTypes.NpgsqlPoint(x: 0.26188083958831265d, y: 0.428072231037132d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24304511001173434d, y: 0.895733262904848d), new NpgsqlTypes.NpgsqlPoint(x: 0.5837114888997894d, y: 0.2645850825921221d), new NpgsqlTypes.NpgsqlPoint(x: 0.768209172578702d, y: 0.5505351130525459d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5816446959478137d, y: 0.9137767160984586d), new NpgsqlTypes.NpgsqlPoint(x: 0.4531110796554384d, y: 0.05066873300432184d), new NpgsqlTypes.NpgsqlPoint(x: 0.8676859936178373d, y: 0.08249000349946256d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4716165603975032d, y: 0.08551464175191137d), new NpgsqlTypes.NpgsqlPoint(x: 0.3061650052927274d, y: 0.02800543261855537d), new NpgsqlTypes.NpgsqlPoint(x: 0.6957594442910441d, y: 0.29289465626137134d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21980699542805227d, y: 0.519455479414541d), new NpgsqlTypes.NpgsqlPoint(x: 0.8312759452445498d, y: 0.5669754702253096d), new NpgsqlTypes.NpgsqlPoint(x: 0.4064011955305561d, y: 0.4785847976585854d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7308483794256997d, y: 0.7725845406881534d), new NpgsqlTypes.NpgsqlPoint(x: 0.7490397125218302d, y: 0.6562148247268196d), new NpgsqlTypes.NpgsqlPoint(x: 0.6961783304121043d, y: 0.14881559230436658d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0032715742535313064d, y: 0.4460546292367862d), new NpgsqlTypes.NpgsqlPoint(x: 0.26819236268961477d, y: 0.9606241955806537d), new NpgsqlTypes.NpgsqlPoint(x: 0.5205591760870883d, y: 0.35679975750140447d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44912801820512405d, y: 0.8182663938148591d), new NpgsqlTypes.NpgsqlPoint(x: 0.8743622742183589d, y: 0.7746899163021008d), new NpgsqlTypes.NpgsqlPoint(x: 0.15073260128932242d, y: 0.8393077065052705d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011353216448982129d, y: 0.003745276365919481d), new NpgsqlTypes.NpgsqlPoint(x: 0.376066236936087d, y: 0.6733574928664704d), new NpgsqlTypes.NpgsqlPoint(x: 0.7024747434436566d, y: 0.6135026170182859d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020974001915118d, y: 0.87225434789809d), new NpgsqlTypes.NpgsqlPoint(x: 0.4452658844557432d, y: 0.3486945358765219d), new NpgsqlTypes.NpgsqlPoint(x: 0.22928694552096818d, y: 0.7826470346231583d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30989417131180974d, y: 0.9918250324667326d), new NpgsqlTypes.NpgsqlPoint(x: 0.33194179752746633d, y: 0.8085830404087868d), new NpgsqlTypes.NpgsqlPoint(x: 0.08821428811388432d, y: 0.24201243591226718d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9182690432358871d, y: 0.8139694832687364d), new NpgsqlTypes.NpgsqlPoint(x: 0.31293536941589706d, y: 0.5705257733170482d), new NpgsqlTypes.NpgsqlPoint(x: 0.9651162747106118d, y: 0.25990993488513103d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6710552715879482d, y: 0.8057077884716339d), new NpgsqlTypes.NpgsqlPoint(x: 0.6117641199267958d, y: 0.8624876281277056d), new NpgsqlTypes.NpgsqlPoint(x: 0.6042530596456271d, y: 0.37809025235748406d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38470124815308304d, y: 0.051297449509632664d), new NpgsqlTypes.NpgsqlPoint(x: 0.30962625415419964d, y: 0.7463961021608806d), new NpgsqlTypes.NpgsqlPoint(x: 0.674268403419941d, y: 0.30062323274319347d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6222546016799586d, y: 0.03392517252278937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8810760398946355d, y: 0.09420801855959315d), new NpgsqlTypes.NpgsqlPoint(x: 0.33091723748141033d, y: 0.6201662450064129d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1926199910897597d, y: 0.6162673150930429d), new NpgsqlTypes.NpgsqlPoint(x: 0.25186816234909637d, y: 0.34191813376190805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8591688711607414d, y: 0.3495759125975644d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32522001620342145d, y: 0.08993637822569067d), new NpgsqlTypes.NpgsqlPoint(x: 0.8687236540315298d, y: 0.20468225868156908d), new NpgsqlTypes.NpgsqlPoint(x: 0.3514045779210535d, y: 0.9945552906259165d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27053788440480653d, y: 0.24624561517182209d), new NpgsqlTypes.NpgsqlPoint(x: 0.8266330194612235d, y: 0.40512344792664146d), new NpgsqlTypes.NpgsqlPoint(x: 0.3760378189423358d, y: 0.0526656229380712d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6870209530068986d, y: 0.6046467532410795d), new NpgsqlTypes.NpgsqlPoint(x: 0.8356517509026195d, y: 0.6116592278812811d), new NpgsqlTypes.NpgsqlPoint(x: 0.8641870853095073d, y: 0.07875829329308992d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4214039627195312d, y: 0.5938335313034834d), new NpgsqlTypes.NpgsqlPoint(x: 0.23863102846967077d, y: 0.3722697325771409d), new NpgsqlTypes.NpgsqlPoint(x: 0.5627420591229919d, y: 0.8925282207466648d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3479590159325914d, y: 0.5732801734022246d), new NpgsqlTypes.NpgsqlPoint(x: 0.3920038313608031d, y: 0.06645502872412701d), new NpgsqlTypes.NpgsqlPoint(x: 0.8890382626562815d, y: 0.19147403711138666d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6328955419661813d, y: 0.3937740829489649d), new NpgsqlTypes.NpgsqlPoint(x: 0.1170118005587194d, y: 0.28484132195030165d), new NpgsqlTypes.NpgsqlPoint(x: 0.12424705625975385d, y: 0.4591972150368515d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.87772469783591d, y: 0.23447478812733114d), new NpgsqlTypes.NpgsqlPoint(x: 0.46130322408648106d, y: 0.9038343993133968d), new NpgsqlTypes.NpgsqlPoint(x: 0.4664312462650517d, y: 0.19003772752654324d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2909908019245715d, y: 0.5537230270856639d), new NpgsqlTypes.NpgsqlPoint(x: 0.41656393119134405d, y: 0.7844154540328301d), new NpgsqlTypes.NpgsqlPoint(x: 0.4801031366525097d, y: 0.5218553535036046d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.671341599644272d, y: 0.9401393038307763d), new NpgsqlTypes.NpgsqlPoint(x: 0.25860797307702243d, y: 0.30860256224817184d), new NpgsqlTypes.NpgsqlPoint(x: 0.3456737523167869d, y: 0.6292825486392672d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7351751701090575d, y: 0.6585398291391804d), new NpgsqlTypes.NpgsqlPoint(x: 0.31972115814904656d, y: 0.5199198080230986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5878665071879213d, y: 0.2567734216835741d)),

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
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[29], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 27, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 15, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 111, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 53, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 147, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 45, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 6, query1, 105, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 142, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 142, 97))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[29], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 73, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 118);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2M>(15);

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
                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

