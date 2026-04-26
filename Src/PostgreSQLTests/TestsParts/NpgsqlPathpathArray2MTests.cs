

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3124128522894196d, y: 0.1683345735159837d), new NpgsqlTypes.NpgsqlPoint(x: 0.24058613816008423d, y: 0.5349859261558422d), new NpgsqlTypes.NpgsqlPoint(x: 0.1598726240109568d, y: 0.30167649995021284d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35662607074170627d, y: 0.4880938708208289d), new NpgsqlTypes.NpgsqlPoint(x: 0.9395898123776066d, y: 0.1929486760885033d), new NpgsqlTypes.NpgsqlPoint(x: 0.508451126322391d, y: 0.0742675067311297d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43223249815856535d, y: 0.3459331533473945d), new NpgsqlTypes.NpgsqlPoint(x: 0.5278665842583716d, y: 0.6845972116428827d), new NpgsqlTypes.NpgsqlPoint(x: 0.7516459959126697d, y: 0.565518232631399d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5424718607631421d, y: 0.7239772763354414d), new NpgsqlTypes.NpgsqlPoint(x: 0.20861233072382346d, y: 0.7340368038436029d), new NpgsqlTypes.NpgsqlPoint(x: 0.9282726730330877d, y: 0.7278159611155797d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08238888660482291d, y: 0.3360967520781205d), new NpgsqlTypes.NpgsqlPoint(x: 0.3017955696910587d, y: 0.8291810822641141d), new NpgsqlTypes.NpgsqlPoint(x: 0.635090131484202d, y: 0.16765703895948314d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27272904355382577d, y: 0.5301561354664446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898777413957146d, y: 0.5500444722875538d), new NpgsqlTypes.NpgsqlPoint(x: 0.2798004667428977d, y: 0.0133307416168148d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26996632228018735d, y: 0.677488202577385d), new NpgsqlTypes.NpgsqlPoint(x: 0.7378375689273716d, y: 0.7606637355699395d), new NpgsqlTypes.NpgsqlPoint(x: 0.5609563530604653d, y: 0.4092546273578679d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10065073039513328d, y: 0.39110597388008894d), new NpgsqlTypes.NpgsqlPoint(x: 0.42137577669969384d, y: 0.9803132259029654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8363292259563648d, y: 0.8601120413442868d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2934561041591337d, y: 0.32723859818649337d), new NpgsqlTypes.NpgsqlPoint(x: 0.5999370756700149d, y: 0.590043311301239d), new NpgsqlTypes.NpgsqlPoint(x: 0.8755241043436782d, y: 0.6799556980030041d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8903559715333996d, y: 0.4304023252513578d), new NpgsqlTypes.NpgsqlPoint(x: 0.39084473643158213d, y: 0.0031260289207259984d), new NpgsqlTypes.NpgsqlPoint(x: 0.24187200526979225d, y: 0.5528396675338062d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.914117856843655d, y: 0.6466585568225718d), new NpgsqlTypes.NpgsqlPoint(x: 0.07587775424259113d, y: 0.7875778495175092d), new NpgsqlTypes.NpgsqlPoint(x: 0.669117387156312d, y: 0.9622667084999414d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9923237759883959d, y: 0.651808479863379d), new NpgsqlTypes.NpgsqlPoint(x: 0.3154328623121011d, y: 0.6488432875343182d), new NpgsqlTypes.NpgsqlPoint(x: 0.1510089885133009d, y: 0.39816821430118055d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08689947644595497d, y: 0.3504176786979555d), new NpgsqlTypes.NpgsqlPoint(x: 0.1351880033130971d, y: 0.13293006298291898d), new NpgsqlTypes.NpgsqlPoint(x: 0.3203297946598679d, y: 0.05289665660120668d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5592291147681594d, y: 0.6597004849260798d), new NpgsqlTypes.NpgsqlPoint(x: 0.6649022884342026d, y: 0.40586840445715155d), new NpgsqlTypes.NpgsqlPoint(x: 0.21234681318529602d, y: 0.6615982779905362d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9818745494946486d, y: 0.15635419604590195d), new NpgsqlTypes.NpgsqlPoint(x: 0.5750524974400354d, y: 0.32271505887905116d), new NpgsqlTypes.NpgsqlPoint(x: 0.7766072553954371d, y: 0.663534132383456d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8775221538050086d, y: 0.09908461392269952d), new NpgsqlTypes.NpgsqlPoint(x: 0.29007850222707765d, y: 0.6274569150897636d), new NpgsqlTypes.NpgsqlPoint(x: 0.3204853247428182d, y: 0.764290452094644d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17556885536668554d, y: 0.7402741797932811d), new NpgsqlTypes.NpgsqlPoint(x: 0.7534380509014427d, y: 0.1494062401012347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7602413811359261d, y: 0.25951219853650054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31000783791018416d, y: 0.4916554516887244d), new NpgsqlTypes.NpgsqlPoint(x: 0.4385765692431577d, y: 0.5386916771166106d), new NpgsqlTypes.NpgsqlPoint(x: 0.7768671594961513d, y: 0.6491635510325047d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1951426185548465d, y: 0.6485144984526231d), new NpgsqlTypes.NpgsqlPoint(x: 0.7073148016456429d, y: 0.16120257686061223d), new NpgsqlTypes.NpgsqlPoint(x: 0.5162344718575973d, y: 0.5845351380839366d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9448181671877696d, y: 0.6127141551026768d), new NpgsqlTypes.NpgsqlPoint(x: 0.7346630862367253d, y: 0.634057391327542d), new NpgsqlTypes.NpgsqlPoint(x: 0.5759318503893014d, y: 0.6962794835142877d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.088529509122238d, y: 0.6800392565041089d), new NpgsqlTypes.NpgsqlPoint(x: 0.004407290801684893d, y: 0.29070045922361165d), new NpgsqlTypes.NpgsqlPoint(x: 0.3791232871589806d, y: 0.8119099991495903d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.632288156365377d, y: 0.5341326174328048d), new NpgsqlTypes.NpgsqlPoint(x: 0.32684627573184566d, y: 0.171186395379764d), new NpgsqlTypes.NpgsqlPoint(x: 0.38930898031346584d, y: 0.6879061823922673d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9145924962989889d, y: 0.11751898004617733d), new NpgsqlTypes.NpgsqlPoint(x: 0.8618402826895187d, y: 0.7944596201224967d), new NpgsqlTypes.NpgsqlPoint(x: 0.5537581902967114d, y: 0.5291580633672606d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4363716342955699d, y: 0.14950086300989252d), new NpgsqlTypes.NpgsqlPoint(x: 0.5806831524040923d, y: 0.5507242211598905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407205794846558d, y: 0.8391683692120019d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44920597536500273d, y: 0.637170415810303d), new NpgsqlTypes.NpgsqlPoint(x: 0.9512846944452628d, y: 0.3203849258805358d), new NpgsqlTypes.NpgsqlPoint(x: 0.9837319087528931d, y: 0.7376413719638111d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2593596039308187d, y: 0.5495565645725415d), new NpgsqlTypes.NpgsqlPoint(x: 0.3197037649981682d, y: 0.5509225399036215d), new NpgsqlTypes.NpgsqlPoint(x: 0.8169283252864824d, y: 0.39350798466830916d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37519197759001943d, y: 0.23509956599532178d), new NpgsqlTypes.NpgsqlPoint(x: 0.1062486470663162d, y: 0.7898132285745324d), new NpgsqlTypes.NpgsqlPoint(x: 0.3777815832666468d, y: 0.6635669868018739d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04271967714010749d, y: 0.7629157403171731d), new NpgsqlTypes.NpgsqlPoint(x: 0.1065828988420906d, y: 0.6036312442268894d), new NpgsqlTypes.NpgsqlPoint(x: 0.3436210480883368d, y: 0.31359920550283205d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6024759861863193d, y: 0.32399197353399134d), new NpgsqlTypes.NpgsqlPoint(x: 0.7259323623619074d, y: 0.6304306250904044d), new NpgsqlTypes.NpgsqlPoint(x: 0.6256521206236769d, y: 0.5515613306652042d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4933900641151382d, y: 0.3777298476098603d), new NpgsqlTypes.NpgsqlPoint(x: 0.964619729311066d, y: 0.5416389326466657d), new NpgsqlTypes.NpgsqlPoint(x: 0.8048949049436118d, y: 0.7822213081695805d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6822763364956868d, y: 0.9047315793591424d), new NpgsqlTypes.NpgsqlPoint(x: 0.5392368134528074d, y: 0.8332788391952556d), new NpgsqlTypes.NpgsqlPoint(x: 0.8536269833139241d, y: 0.36851680546093224d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3425301695251739d, y: 0.0706824164812827d), new NpgsqlTypes.NpgsqlPoint(x: 0.9280004954731041d, y: 0.16302895794705452d), new NpgsqlTypes.NpgsqlPoint(x: 0.7208123606471718d, y: 0.9135623334118316d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.058319202634728784d, y: 0.05449739354791083d), new NpgsqlTypes.NpgsqlPoint(x: 0.950166980181979d, y: 0.37974378092227257d), new NpgsqlTypes.NpgsqlPoint(x: 0.33947071719499156d, y: 0.5602191302902159d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21149629798895686d, y: 0.5342909549457555d), new NpgsqlTypes.NpgsqlPoint(x: 0.176561054688548d, y: 0.9618848403447985d), new NpgsqlTypes.NpgsqlPoint(x: 0.9380290377669239d, y: 0.17951677060288818d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4731415050535871d, y: 0.7642625701039096d), new NpgsqlTypes.NpgsqlPoint(x: 0.022520591952081115d, y: 0.8474201864986186d), new NpgsqlTypes.NpgsqlPoint(x: 0.6243872804400009d, y: 0.4655115843707982d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4882152136550483d, y: 0.23917818823323056d), new NpgsqlTypes.NpgsqlPoint(x: 0.3199656035962848d, y: 0.5705504126099766d), new NpgsqlTypes.NpgsqlPoint(x: 0.9400611638984006d, y: 0.6936501417946271d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1607281495321251d, y: 0.28390485566331214d), new NpgsqlTypes.NpgsqlPoint(x: 0.6350700130204284d, y: 0.341595212318915d), new NpgsqlTypes.NpgsqlPoint(x: 0.23514972845157633d, y: 0.13104249805077894d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8841705029441554d, y: 0.8988121008178964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8570837996482716d, y: 0.23029272343268214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8562407428651907d, y: 0.2836895904041079d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7998405035898238d, y: 0.46848462479101294d), new NpgsqlTypes.NpgsqlPoint(x: 0.1903042174793772d, y: 0.9842864428798583d), new NpgsqlTypes.NpgsqlPoint(x: 0.8902674481182679d, y: 0.07551406114580028d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08559563554287553d, y: 0.9982398650147183d), new NpgsqlTypes.NpgsqlPoint(x: 0.8984869720579436d, y: 0.31756907250635635d), new NpgsqlTypes.NpgsqlPoint(x: 0.2894010554943558d, y: 0.9947503690432233d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4268861511865021d, y: 0.9751812636926493d), new NpgsqlTypes.NpgsqlPoint(x: 0.7511540309652305d, y: 0.29292001401697954d), new NpgsqlTypes.NpgsqlPoint(x: 0.1685341263743484d, y: 0.5128988978212866d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05865472092828117d, y: 0.06301167107058914d), new NpgsqlTypes.NpgsqlPoint(x: 0.2490206411611362d, y: 0.7396317476186351d), new NpgsqlTypes.NpgsqlPoint(x: 0.671842554978357d, y: 0.9183925632222495d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09150592105520627d, y: 0.6721731030612852d), new NpgsqlTypes.NpgsqlPoint(x: 0.8995693114255692d, y: 0.9765528514377355d), new NpgsqlTypes.NpgsqlPoint(x: 0.3797830546873928d, y: 0.10116837666959788d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8704522340617236d, y: 0.12363309300664027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6347912398043859d, y: 0.16040344085462477d), new NpgsqlTypes.NpgsqlPoint(x: 0.24702349628990838d, y: 0.712851000159029d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8115048179371052d, y: 0.9914518110085216d), new NpgsqlTypes.NpgsqlPoint(x: 0.9699805368529691d, y: 0.9452621545515075d), new NpgsqlTypes.NpgsqlPoint(x: 0.7634944112519282d, y: 0.1206694298499491d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3442767770450592d, y: 0.0859471609976441d), new NpgsqlTypes.NpgsqlPoint(x: 0.2660094649892025d, y: 0.674095509721099d), new NpgsqlTypes.NpgsqlPoint(x: 0.5344594019184785d, y: 0.3465231020289966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5541923292063d, y: 0.33792226458814334d), new NpgsqlTypes.NpgsqlPoint(x: 0.992698834663895d, y: 0.5506812271934844d), new NpgsqlTypes.NpgsqlPoint(x: 0.6072698621829336d, y: 0.7284592266793285d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27448475668426664d, y: 0.40105921224229424d), new NpgsqlTypes.NpgsqlPoint(x: 0.4720389529027227d, y: 0.9352851546035483d), new NpgsqlTypes.NpgsqlPoint(x: 0.6433290298323898d, y: 0.9001542896003871d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19118545485477167d, y: 0.39832924592793584d), new NpgsqlTypes.NpgsqlPoint(x: 0.7891455029349925d, y: 0.42483000651808256d), new NpgsqlTypes.NpgsqlPoint(x: 0.4553913955006119d, y: 0.8138252282980939d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2980081806613738d, y: 0.9513713108584726d), new NpgsqlTypes.NpgsqlPoint(x: 0.14913829949709045d, y: 0.31059126373877366d), new NpgsqlTypes.NpgsqlPoint(x: 0.3398671582583003d, y: 0.11454485949749615d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.67904231002872d, y: 0.46195457615419155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6032073120760892d, y: 0.30829996150721106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6453382669253056d, y: 0.10775105560135245d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9298558392369947d, y: 0.28107149436160817d), new NpgsqlTypes.NpgsqlPoint(x: 0.9027275731803461d, y: 0.07543999602502716d), new NpgsqlTypes.NpgsqlPoint(x: 0.05734076605148697d, y: 0.5381959150384719d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00831565731893158d, y: 0.061834013593888404d), new NpgsqlTypes.NpgsqlPoint(x: 0.4106655891674612d, y: 0.3317962688179883d), new NpgsqlTypes.NpgsqlPoint(x: 0.2661100537932346d, y: 0.957952568312806d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03021976368944279d, y: 0.754001359967778d), new NpgsqlTypes.NpgsqlPoint(x: 0.7021797206269268d, y: 0.23413291471097075d), new NpgsqlTypes.NpgsqlPoint(x: 0.2256314942073785d, y: 0.2709402166246464d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16084487808506553d, y: 0.5244859909824322d), new NpgsqlTypes.NpgsqlPoint(x: 0.5108871559173124d, y: 0.5998368373133641d), new NpgsqlTypes.NpgsqlPoint(x: 0.6982042807631597d, y: 0.29305825898662174d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6262873705983711d, y: 0.5439725919728154d), new NpgsqlTypes.NpgsqlPoint(x: 0.5552657386136601d, y: 0.7740994304032167d), new NpgsqlTypes.NpgsqlPoint(x: 0.27211602916442124d, y: 0.17216135084426643d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7639302680666031d, y: 0.9674238821314844d), new NpgsqlTypes.NpgsqlPoint(x: 0.9723504392542835d, y: 0.6943672783365122d), new NpgsqlTypes.NpgsqlPoint(x: 0.10835086349055767d, y: 0.6748926855520426d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34786378553764685d, y: 0.3243529726366673d), new NpgsqlTypes.NpgsqlPoint(x: 0.34999451126218906d, y: 0.2643457728192685d), new NpgsqlTypes.NpgsqlPoint(x: 0.4694933275305373d, y: 0.40281264032605124d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17628051603718775d, y: 0.39466169186796274d), new NpgsqlTypes.NpgsqlPoint(x: 0.31410261055232247d, y: 0.8900147299802913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9580066515177993d, y: 0.12449231260632887d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2899280092968354d, y: 0.4652939162478006d), new NpgsqlTypes.NpgsqlPoint(x: 0.5984184381360121d, y: 0.387095121298909d), new NpgsqlTypes.NpgsqlPoint(x: 0.6445134307045242d, y: 0.35814452936687935d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9925646638859374d, y: 0.9896354057040324d), new NpgsqlTypes.NpgsqlPoint(x: 0.6384164562779537d, y: 0.5011665913447015d), new NpgsqlTypes.NpgsqlPoint(x: 0.400686222982235d, y: 0.021625646054188374d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2082966314335789d, y: 0.6858682341432591d), new NpgsqlTypes.NpgsqlPoint(x: 0.5670634543768458d, y: 0.4254362328268816d), new NpgsqlTypes.NpgsqlPoint(x: 0.6260517707052826d, y: 0.3540390183298229d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7983935525147398d, y: 0.7687510993237002d), new NpgsqlTypes.NpgsqlPoint(x: 0.7920765653933722d, y: 0.2921811317464973d), new NpgsqlTypes.NpgsqlPoint(x: 0.39536360972821327d, y: 0.4170431936298852d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7860778135587094d, y: 0.970622701614006d), new NpgsqlTypes.NpgsqlPoint(x: 0.26325015961099985d, y: 0.3236198474585624d), new NpgsqlTypes.NpgsqlPoint(x: 0.7467686897467223d, y: 0.9682362401728254d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024709297599172175d, y: 0.8091336744958616d), new NpgsqlTypes.NpgsqlPoint(x: 0.19863087652324385d, y: 0.33933987538422095d), new NpgsqlTypes.NpgsqlPoint(x: 0.8970755351535511d, y: 0.6281809502645003d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14375312057262257d, y: 0.40326201641516946d), new NpgsqlTypes.NpgsqlPoint(x: 0.9550254807069397d, y: 0.39213857553638887d), new NpgsqlTypes.NpgsqlPoint(x: 0.026623829629442652d, y: 0.902009514487406d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15085692996157163d, y: 0.5926697564905082d), new NpgsqlTypes.NpgsqlPoint(x: 0.3202938211801123d, y: 0.1331852402029391d), new NpgsqlTypes.NpgsqlPoint(x: 0.8912436044944061d, y: 0.21188967270848613d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.542308753180226d, y: 0.72980774131617d), new NpgsqlTypes.NpgsqlPoint(x: 0.06596817126516274d, y: 0.09211596217902929d), new NpgsqlTypes.NpgsqlPoint(x: 0.915587899204145d, y: 0.28870548836723786d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04728638898399429d, y: 0.3111863251591922d), new NpgsqlTypes.NpgsqlPoint(x: 0.9918204760237856d, y: 0.45492572820113086d), new NpgsqlTypes.NpgsqlPoint(x: 0.9736034287405974d, y: 0.8677028203512622d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8135035562884595d, y: 0.27620250243632793d), new NpgsqlTypes.NpgsqlPoint(x: 0.694076539073936d, y: 0.5103054308751691d), new NpgsqlTypes.NpgsqlPoint(x: 0.3966852176703636d, y: 0.7085529181788845d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9036253308091473d, y: 0.8581389556588973d), new NpgsqlTypes.NpgsqlPoint(x: 0.43735437202512095d, y: 0.0745339249020528d), new NpgsqlTypes.NpgsqlPoint(x: 0.6537684568434209d, y: 0.477847686965028d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8638010680824985d, y: 0.49626163326683626d), new NpgsqlTypes.NpgsqlPoint(x: 0.23348294721940488d, y: 0.08586911791030383d), new NpgsqlTypes.NpgsqlPoint(x: 0.7839273611064744d, y: 0.3337039385831687d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5562495128108887d, y: 0.02422767699340489d), new NpgsqlTypes.NpgsqlPoint(x: 0.3325523735507444d, y: 0.32084712275171146d), new NpgsqlTypes.NpgsqlPoint(x: 0.4901539712293681d, y: 0.6331779455850713d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46548189974450493d, y: 0.11711116913557684d), new NpgsqlTypes.NpgsqlPoint(x: 0.793120272787919d, y: 0.42438608391186405d), new NpgsqlTypes.NpgsqlPoint(x: 0.04704215268396572d, y: 0.05059870564657831d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5497843909973307d, y: 0.16723067155089588d), new NpgsqlTypes.NpgsqlPoint(x: 0.011466916228760948d, y: 0.3519731432747102d), new NpgsqlTypes.NpgsqlPoint(x: 0.6607944381090609d, y: 0.7841277779768026d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18655809308449245d, y: 0.7982322595904207d), new NpgsqlTypes.NpgsqlPoint(x: 0.3613207433484791d, y: 0.4715273860608862d), new NpgsqlTypes.NpgsqlPoint(x: 0.39556985678790335d, y: 0.8294756393509557d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17439491978739152d, y: 0.39447262223781276d), new NpgsqlTypes.NpgsqlPoint(x: 0.5272326559678476d, y: 0.58521016369777d), new NpgsqlTypes.NpgsqlPoint(x: 0.10018358356158308d, y: 0.20258389289009604d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31954280155257875d, y: 0.7574243174813322d), new NpgsqlTypes.NpgsqlPoint(x: 0.6229476884623587d, y: 0.9532061319165429d), new NpgsqlTypes.NpgsqlPoint(x: 0.9933566806461541d, y: 0.5327630569595994d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.398014195125056d, y: 0.4708894749089074d), new NpgsqlTypes.NpgsqlPoint(x: 0.6811257531906602d, y: 0.45791463320275905d), new NpgsqlTypes.NpgsqlPoint(x: 0.4179499085452806d, y: 0.8018450701357466d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9881476490653255d, y: 0.5280795884568785d), new NpgsqlTypes.NpgsqlPoint(x: 0.6153817797951193d, y: 0.184830110188841d), new NpgsqlTypes.NpgsqlPoint(x: 0.3475385094985256d, y: 0.717149780703297d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35649354050091764d, y: 0.8214660600883132d), new NpgsqlTypes.NpgsqlPoint(x: 0.42149769537980075d, y: 0.2928502275878244d), new NpgsqlTypes.NpgsqlPoint(x: 0.6565187465281601d, y: 0.5346177638539418d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2285816864318878d, y: 0.7291437734723288d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131517577403978d, y: 0.9893509951776044d), new NpgsqlTypes.NpgsqlPoint(x: 0.6768191862940137d, y: 0.9460760071633912d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5935289120287506d, y: 0.8526891845028141d), new NpgsqlTypes.NpgsqlPoint(x: 0.9571338339190132d, y: 0.8680597624202567d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412945880934053d, y: 0.8100778146123485d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21731306157599128d, y: 0.053284030432379614d), new NpgsqlTypes.NpgsqlPoint(x: 0.24935334660577757d, y: 0.8803362244872377d), new NpgsqlTypes.NpgsqlPoint(x: 0.7701513085886827d, y: 0.9554055091123118d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3474438648528513d, y: 0.26752228330300254d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810707166204457d, y: 0.07738283966912851d), new NpgsqlTypes.NpgsqlPoint(x: 0.4484780602631536d, y: 0.9242337688857298d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9293832443347649d, y: 0.0025506815221216783d), new NpgsqlTypes.NpgsqlPoint(x: 0.3649648200551495d, y: 0.5836151300075884d), new NpgsqlTypes.NpgsqlPoint(x: 0.507810593268624d, y: 0.8752951813746275d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5745885367514978d, y: 0.42238313944325834d), new NpgsqlTypes.NpgsqlPoint(x: 0.19845634020187775d, y: 0.5813206646919102d), new NpgsqlTypes.NpgsqlPoint(x: 0.5552836137411211d, y: 0.024458139006106716d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5397144120294042d, y: 0.2893498431615442d), new NpgsqlTypes.NpgsqlPoint(x: 0.06995466767528258d, y: 0.5422480757772458d), new NpgsqlTypes.NpgsqlPoint(x: 0.20446461284422224d, y: 0.693879519895998d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.82138330970945d, y: 0.8549921665010384d), new NpgsqlTypes.NpgsqlPoint(x: 0.6099992087705517d, y: 0.03940928018276624d), new NpgsqlTypes.NpgsqlPoint(x: 0.699842041076503d, y: 0.8156382234122685d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6297654334803043d, y: 0.6517282881293075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6244769422576657d, y: 0.522973827097323d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621080585961836d, y: 0.5591388343133552d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7985245919857588d, y: 0.6304845368016878d), new NpgsqlTypes.NpgsqlPoint(x: 0.7973719229951213d, y: 0.5162668023878133d), new NpgsqlTypes.NpgsqlPoint(x: 0.13087851854298804d, y: 0.4352775517299443d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.332844875017276d, y: 0.794123223608246d), new NpgsqlTypes.NpgsqlPoint(x: 0.4211822907016113d, y: 0.16466612300240346d), new NpgsqlTypes.NpgsqlPoint(x: 0.06591846629813336d, y: 0.0005634967839484029d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7460358283124958d, y: 0.20508386843084103d), new NpgsqlTypes.NpgsqlPoint(x: 0.1009722837767022d, y: 0.8609583277243124d), new NpgsqlTypes.NpgsqlPoint(x: 0.7634785440748826d, y: 0.9552624845470543d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6414985958979267d, y: 0.2963638319488008d), new NpgsqlTypes.NpgsqlPoint(x: 0.8752521930298547d, y: 0.9132259144301117d), new NpgsqlTypes.NpgsqlPoint(x: 0.697679418435956d, y: 0.9825676191189244d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9485061455832559d, y: 0.8541495151000353d), new NpgsqlTypes.NpgsqlPoint(x: 0.0900207287738991d, y: 0.27819366493952435d), new NpgsqlTypes.NpgsqlPoint(x: 0.16043998873978038d, y: 0.2949763694887779d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23906349412056827d, y: 0.709287053137633d), new NpgsqlTypes.NpgsqlPoint(x: 0.774639422917294d, y: 0.49606215939584986d), new NpgsqlTypes.NpgsqlPoint(x: 0.7288543091142052d, y: 0.12042708014069681d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.466522380131435d, y: 0.3421473425656393d), new NpgsqlTypes.NpgsqlPoint(x: 0.291992495420491d, y: 0.6885910897768763d), new NpgsqlTypes.NpgsqlPoint(x: 0.02762665257662067d, y: 0.6992474996156472d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.980039610381882d, y: 0.3543464679109103d), new NpgsqlTypes.NpgsqlPoint(x: 0.9717784444912169d, y: 0.3795313043190386d), new NpgsqlTypes.NpgsqlPoint(x: 0.22256967295869134d, y: 0.015921344543566418d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4260421302951054d, y: 0.5676167601811304d), new NpgsqlTypes.NpgsqlPoint(x: 0.2016291115243396d, y: 0.9352837831749351d), new NpgsqlTypes.NpgsqlPoint(x: 0.1484241016530763d, y: 0.35266326338697007d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5046630537556729d, y: 0.65293552044251d), new NpgsqlTypes.NpgsqlPoint(x: 0.17975378140272413d, y: 0.33011108282575763d), new NpgsqlTypes.NpgsqlPoint(x: 0.8353768251648707d, y: 0.6425296680296934d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15806060514334352d, y: 0.23117838940220026d), new NpgsqlTypes.NpgsqlPoint(x: 0.9195147401721376d, y: 0.8296277506828279d), new NpgsqlTypes.NpgsqlPoint(x: 0.501893408366496d, y: 0.5086492545686985d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6789155192628855d, y: 0.1053406887435342d), new NpgsqlTypes.NpgsqlPoint(x: 0.17301094882835144d, y: 0.3527007123845166d), new NpgsqlTypes.NpgsqlPoint(x: 0.24818475685137054d, y: 0.44415212509621027d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005804004086707559d, y: 0.4556051233598465d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670094706237347d, y: 0.0852633054209061d), new NpgsqlTypes.NpgsqlPoint(x: 0.5118474282886701d, y: 0.27310620396053187d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7349797035367105d, y: 0.4795508302177266d), new NpgsqlTypes.NpgsqlPoint(x: 0.28528192871501457d, y: 0.3536955562402113d), new NpgsqlTypes.NpgsqlPoint(x: 0.6685964266047353d, y: 0.05485391530471684d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7263576350131178d, y: 0.6317371598935755d), new NpgsqlTypes.NpgsqlPoint(x: 0.5939636258951472d, y: 0.37848327774712687d), new NpgsqlTypes.NpgsqlPoint(x: 0.8583359989408249d, y: 0.32033403327309506d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.951643731331414d, y: 0.7171101504643472d), new NpgsqlTypes.NpgsqlPoint(x: 0.5353134038278196d, y: 0.38447734629359265d), new NpgsqlTypes.NpgsqlPoint(x: 0.17734934623144116d, y: 0.38399461802128576d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9962199117185551d, y: 0.12072264762349949d), new NpgsqlTypes.NpgsqlPoint(x: 0.5677125412177291d, y: 0.0008455498161025199d), new NpgsqlTypes.NpgsqlPoint(x: 0.4908340122442336d, y: 0.5117348312684017d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21681610253820371d, y: 0.25574276374321425d), new NpgsqlTypes.NpgsqlPoint(x: 0.12135434621770125d, y: 0.6945248518745286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6793376226828097d, y: 0.8511524193482654d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11484784216365096d, y: 0.45237911852442214d), new NpgsqlTypes.NpgsqlPoint(x: 0.11838548464044896d, y: 0.5172498381273247d), new NpgsqlTypes.NpgsqlPoint(x: 0.9786391944804492d, y: 0.3096391204220069d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4565996351743521d, y: 0.3966093672172889d), new NpgsqlTypes.NpgsqlPoint(x: 0.8955906557795873d, y: 0.12772411035452091d), new NpgsqlTypes.NpgsqlPoint(x: 0.6567113096653017d, y: 0.4019947117355236d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6336789600213298d, y: 0.6298756908115093d), new NpgsqlTypes.NpgsqlPoint(x: 0.768494612802085d, y: 0.32053653807367044d), new NpgsqlTypes.NpgsqlPoint(x: 0.8793209712922405d, y: 0.17170875140290542d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8899941193341704d, y: 0.6627823712102509d), new NpgsqlTypes.NpgsqlPoint(x: 0.8704363407463801d, y: 0.9339308449279856d), new NpgsqlTypes.NpgsqlPoint(x: 0.6396578840438145d, y: 0.356679093950352d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4119523948718117d, y: 0.3607309439744d), new NpgsqlTypes.NpgsqlPoint(x: 0.7478382396740026d, y: 0.8169168111869131d), new NpgsqlTypes.NpgsqlPoint(x: 0.24141374806237392d, y: 0.33941789113909593d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8297693005351815d, y: 0.045472073997529505d), new NpgsqlTypes.NpgsqlPoint(x: 0.5290481078264592d, y: 0.9062195301712643d), new NpgsqlTypes.NpgsqlPoint(x: 0.2985240741482146d, y: 0.8610311764011197d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1209591889411159d, y: 0.47388865078255815d), new NpgsqlTypes.NpgsqlPoint(x: 0.5164315942401184d, y: 0.9370670704580291d), new NpgsqlTypes.NpgsqlPoint(x: 0.9377310260879322d, y: 0.12934132459228598d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7523334511913727d, y: 0.779637314078209d), new NpgsqlTypes.NpgsqlPoint(x: 0.44252164280422923d, y: 0.6154952085964079d), new NpgsqlTypes.NpgsqlPoint(x: 0.05970389531833609d, y: 0.535250178554533d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.469759785678349d, y: 0.41513199639331555d), new NpgsqlTypes.NpgsqlPoint(x: 0.6343688408276743d, y: 0.8989440473796348d), new NpgsqlTypes.NpgsqlPoint(x: 0.35995891187559126d, y: 0.7834205717825258d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.879692949455583d, y: 0.17313781292596597d), new NpgsqlTypes.NpgsqlPoint(x: 0.9747051690586936d, y: 0.8097474450920105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5794890305788958d, y: 0.8241254380564359d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5910035265698755d, y: 0.37202502513882585d), new NpgsqlTypes.NpgsqlPoint(x: 0.08179592890340759d, y: 0.7627032263764922d), new NpgsqlTypes.NpgsqlPoint(x: 0.6799640740330246d, y: 0.6112999412732844d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8578833925238117d, y: 0.2566721605408129d), new NpgsqlTypes.NpgsqlPoint(x: 0.3971537364258384d, y: 0.6420232600248277d), new NpgsqlTypes.NpgsqlPoint(x: 0.8724125356224578d, y: 0.9015553533968855d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3942830342904472d, y: 0.7585438104579386d), new NpgsqlTypes.NpgsqlPoint(x: 0.31345013309179914d, y: 0.0946541210659867d), new NpgsqlTypes.NpgsqlPoint(x: 0.17690585963713013d, y: 0.2706922144877777d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6067153571779057d, y: 0.28436719136284827d), new NpgsqlTypes.NpgsqlPoint(x: 0.8566219091444975d, y: 0.9026071691928006d), new NpgsqlTypes.NpgsqlPoint(x: 0.4603530623289781d, y: 0.9383644486208018d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8504490414663306d, y: 0.5958767324945043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6547158071313932d, y: 0.4514201883951824d), new NpgsqlTypes.NpgsqlPoint(x: 0.6885844440395752d, y: 0.5825639048762822d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8160672437425903d, y: 0.5773154546941146d), new NpgsqlTypes.NpgsqlPoint(x: 0.07739015741889255d, y: 0.7028119244744395d), new NpgsqlTypes.NpgsqlPoint(x: 0.2363553206887784d, y: 0.8891136471190628d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4149500232964124d, y: 0.544725590347177d), new NpgsqlTypes.NpgsqlPoint(x: 0.9394036521561829d, y: 0.1517613737757264d), new NpgsqlTypes.NpgsqlPoint(x: 0.94135959497114d, y: 0.31045917398110146d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4919957435764032d, y: 0.32510851058755785d), new NpgsqlTypes.NpgsqlPoint(x: 0.9780139976563877d, y: 0.8865025879379793d), new NpgsqlTypes.NpgsqlPoint(x: 0.6182980916551822d, y: 0.5696923065541252d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8193381830479624d, y: 0.46787618277143916d), new NpgsqlTypes.NpgsqlPoint(x: 0.10293903680058525d, y: 0.1997532994448683d), new NpgsqlTypes.NpgsqlPoint(x: 0.3879112956268008d, y: 0.9908238628881385d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05757411185300776d, y: 0.22492609820036258d), new NpgsqlTypes.NpgsqlPoint(x: 0.07306029012515658d, y: 0.3734277287131409d), new NpgsqlTypes.NpgsqlPoint(x: 0.18601729631260022d, y: 0.8591774012392389d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7799982915544921d, y: 0.7021848531454968d), new NpgsqlTypes.NpgsqlPoint(x: 0.18502438561094947d, y: 0.27722814981159616d), new NpgsqlTypes.NpgsqlPoint(x: 0.4059547840190365d, y: 0.37143679021037346d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8458516752819698d, y: 0.36985954212926264d), new NpgsqlTypes.NpgsqlPoint(x: 0.3642925248701929d, y: 0.8565016442766071d), new NpgsqlTypes.NpgsqlPoint(x: 0.9112370321191622d, y: 0.47581023947934165d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7845539776506342d, y: 0.18083803316066993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5518474066062652d, y: 0.3424087656248256d), new NpgsqlTypes.NpgsqlPoint(x: 0.64202649247654d, y: 0.3711580115508949d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38116732926179486d, y: 0.5238431720113972d), new NpgsqlTypes.NpgsqlPoint(x: 0.3287367306402973d, y: 0.9702294519103087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5966942236515356d, y: 0.28969711080591354d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13333397005401093d, y: 0.49920179587766944d), new NpgsqlTypes.NpgsqlPoint(x: 0.0361621765694069d, y: 0.6092700569795754d), new NpgsqlTypes.NpgsqlPoint(x: 0.5973940574132216d, y: 0.3368520600874062d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.884643369297389d, y: 0.8367395527042065d), new NpgsqlTypes.NpgsqlPoint(x: 0.3870367819680123d, y: 0.860839132561717d), new NpgsqlTypes.NpgsqlPoint(x: 0.7107129066617959d, y: 0.6983556596003754d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30306963643366924d, y: 0.27120277242247803d), new NpgsqlTypes.NpgsqlPoint(x: 0.37797074430651d, y: 0.2897260540904878d), new NpgsqlTypes.NpgsqlPoint(x: 0.641355173523576d, y: 0.2559682481090152d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15812728723471148d, y: 0.8298124145601237d), new NpgsqlTypes.NpgsqlPoint(x: 0.7006635988083959d, y: 0.35742180384449285d), new NpgsqlTypes.NpgsqlPoint(x: 0.12251715863276458d, y: 0.08837201411715656d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7644870163275653d, y: 0.10237750634078324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7126048805401192d, y: 0.8518337557660014d), new NpgsqlTypes.NpgsqlPoint(x: 0.23238172090802878d, y: 0.9054955956205354d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6341100391329769d, y: 0.4911611770001303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8433768616142163d, y: 0.4528099790305201d), new NpgsqlTypes.NpgsqlPoint(x: 0.9682248058732577d, y: 0.9790230166361241d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4257986733934255d, y: 0.9133713381523006d), new NpgsqlTypes.NpgsqlPoint(x: 0.6754271274682543d, y: 0.4752983328664988d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375127039236072d, y: 0.970203132071132d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6805227912788693d, y: 0.9505475405127957d), new NpgsqlTypes.NpgsqlPoint(x: 0.44240653389390183d, y: 0.31301216616851657d), new NpgsqlTypes.NpgsqlPoint(x: 0.7221400026122343d, y: 0.4612287800461141d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47819987067029535d, y: 0.7529059635762121d), new NpgsqlTypes.NpgsqlPoint(x: 0.7299486251229529d, y: 0.018575436961840497d), new NpgsqlTypes.NpgsqlPoint(x: 0.9625195363983164d, y: 0.7943664299057773d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7125931727958296d, y: 0.5423850835184173d), new NpgsqlTypes.NpgsqlPoint(x: 0.916218739154596d, y: 0.6959603304677452d), new NpgsqlTypes.NpgsqlPoint(x: 0.33399129411561157d, y: 0.7907532629589834d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44484401697198395d, y: 0.8724270581421264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9155958516782521d, y: 0.299108457863839d), new NpgsqlTypes.NpgsqlPoint(x: 0.652724519660556d, y: 0.8754335874097496d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17968961879387024d, y: 0.9256869869020619d), new NpgsqlTypes.NpgsqlPoint(x: 0.3301695871830612d, y: 0.39231608213845837d), new NpgsqlTypes.NpgsqlPoint(x: 0.7628658784974489d, y: 0.06462167345956937d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9469757418305111d, y: 0.6371361847673915d), new NpgsqlTypes.NpgsqlPoint(x: 0.6612575023118342d, y: 0.7533935963951188d), new NpgsqlTypes.NpgsqlPoint(x: 0.6168540949218583d, y: 0.6314547369715067d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2838093813199549d, y: 0.22834258513583572d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554338737194024d, y: 0.9137745161832959d), new NpgsqlTypes.NpgsqlPoint(x: 0.2844752623916921d, y: 0.5080188953400074d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4568201932346744d, y: 0.5663473608008825d), new NpgsqlTypes.NpgsqlPoint(x: 0.6816301311022414d, y: 0.020896000891966193d), new NpgsqlTypes.NpgsqlPoint(x: 0.7378189824840813d, y: 0.8019310932736713d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03316976067404476d, y: 0.9939471744029451d), new NpgsqlTypes.NpgsqlPoint(x: 0.03982896827675375d, y: 0.8824667090907989d), new NpgsqlTypes.NpgsqlPoint(x: 0.2185040786615181d, y: 0.6611139869936085d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2510352612303528d, y: 0.6388462659632189d), new NpgsqlTypes.NpgsqlPoint(x: 0.10902907192176714d, y: 0.23657537872419732d), new NpgsqlTypes.NpgsqlPoint(x: 0.6553801255979567d, y: 0.8687311330483807d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9094521704731693d, y: 0.5474969888665211d), new NpgsqlTypes.NpgsqlPoint(x: 0.6427067959784063d, y: 0.9181149351113437d), new NpgsqlTypes.NpgsqlPoint(x: 0.1137705111611852d, y: 0.06634370357474251d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39176739326789256d, y: 0.3335394682054601d), new NpgsqlTypes.NpgsqlPoint(x: 0.4077651562979424d, y: 0.5580767900106415d), new NpgsqlTypes.NpgsqlPoint(x: 0.8762064853582034d, y: 0.6234285640485183d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3578589346821571d, y: 0.6261926390292775d), new NpgsqlTypes.NpgsqlPoint(x: 0.909317813361424d, y: 0.8693658467135126d), new NpgsqlTypes.NpgsqlPoint(x: 0.9290686441080958d, y: 0.6181260148891621d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6996675705097506d, y: 0.10336123661567775d), new NpgsqlTypes.NpgsqlPoint(x: 0.6509100120852689d, y: 0.6890236873473844d), new NpgsqlTypes.NpgsqlPoint(x: 0.46742049436283695d, y: 0.7151358717146257d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13904521347935983d, y: 0.23900905476459122d), new NpgsqlTypes.NpgsqlPoint(x: 0.7612547352979988d, y: 0.43192325637466533d), new NpgsqlTypes.NpgsqlPoint(x: 0.9793308758557638d, y: 0.8122529104090169d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3567787695745329d, y: 0.5531687587423662d), new NpgsqlTypes.NpgsqlPoint(x: 0.5238487481297104d, y: 0.374751534440266d), new NpgsqlTypes.NpgsqlPoint(x: 0.7908021617188794d, y: 0.15797186689319487d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5340406013618634d, y: 0.2702237757533328d), new NpgsqlTypes.NpgsqlPoint(x: 0.2642605006164004d, y: 0.9875490286732667d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227085770915139d, y: 0.8438382105510367d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11430898492180708d, y: 0.23484033397800308d), new NpgsqlTypes.NpgsqlPoint(x: 0.9697592557175627d, y: 0.7956519480953874d), new NpgsqlTypes.NpgsqlPoint(x: 0.41775842655917594d, y: 0.9121045943247011d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8398538142221885d, y: 0.5045104766905589d), new NpgsqlTypes.NpgsqlPoint(x: 0.2720163502255838d, y: 0.740188761281654d), new NpgsqlTypes.NpgsqlPoint(x: 0.2644020859086017d, y: 0.48005320764659976d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4573163649484424d, y: 0.07156299511763276d), new NpgsqlTypes.NpgsqlPoint(x: 0.16827885444594348d, y: 0.9700920570856579d), new NpgsqlTypes.NpgsqlPoint(x: 0.5178880427448622d, y: 0.9599861727396832d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24619120234881742d, y: 0.6007201438944426d), new NpgsqlTypes.NpgsqlPoint(x: 0.2379584452455641d, y: 0.8504264612818493d), new NpgsqlTypes.NpgsqlPoint(x: 0.12851798363395517d, y: 0.7999526657953024d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3455932753326081d, y: 0.623172416908289d), new NpgsqlTypes.NpgsqlPoint(x: 0.97817067178658d, y: 0.754167533688546d), new NpgsqlTypes.NpgsqlPoint(x: 0.7725200964002846d, y: 0.09719357011624319d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08655250707952544d, y: 0.10696109095066686d), new NpgsqlTypes.NpgsqlPoint(x: 0.14112386475722583d, y: 0.8855834246557219d), new NpgsqlTypes.NpgsqlPoint(x: 0.9899107497013737d, y: 0.4845429010887754d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4721588385298029d, y: 0.6517599609274735d), new NpgsqlTypes.NpgsqlPoint(x: 0.6787794048433062d, y: 0.10360524345063316d), new NpgsqlTypes.NpgsqlPoint(x: 0.6437296316993563d, y: 0.8208652786626575d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9890190981472335d, y: 0.18401965597932468d), new NpgsqlTypes.NpgsqlPoint(x: 0.25292595422894415d, y: 0.07961737201787178d), new NpgsqlTypes.NpgsqlPoint(x: 0.009661778503529672d, y: 0.6488548249067838d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7260745116872012d, y: 0.7132229650986294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6226852266065359d, y: 0.12477415444651307d), new NpgsqlTypes.NpgsqlPoint(x: 0.31060248071920415d, y: 0.3715929836880848d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.782069920042236d, y: 0.9360498537417918d), new NpgsqlTypes.NpgsqlPoint(x: 0.7519305062737227d, y: 0.7708619017785568d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621378539634839d, y: 0.10872936005201372d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1759947002583454d, y: 0.19751020071119263d), new NpgsqlTypes.NpgsqlPoint(x: 0.31655307663556387d, y: 0.33941080422600656d), new NpgsqlTypes.NpgsqlPoint(x: 0.05291407740793019d, y: 0.7429059616755166d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33991740196106557d, y: 0.004396729925712939d), new NpgsqlTypes.NpgsqlPoint(x: 0.16958789963440912d, y: 0.9358073797824981d), new NpgsqlTypes.NpgsqlPoint(x: 0.23115792913148714d, y: 0.9777857636963777d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35941838276834803d, y: 0.11444877907740492d), new NpgsqlTypes.NpgsqlPoint(x: 0.1278578951282986d, y: 0.2452721354469829d), new NpgsqlTypes.NpgsqlPoint(x: 0.33704620829192355d, y: 0.30783410934031374d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.762047718743525d, y: 0.43089972750746197d), new NpgsqlTypes.NpgsqlPoint(x: 0.2629103908614905d, y: 0.12398548911178253d), new NpgsqlTypes.NpgsqlPoint(x: 0.8300438143323622d, y: 0.799029124489768d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7439243728091253d, y: 0.5204198152386569d), new NpgsqlTypes.NpgsqlPoint(x: 0.6290260939797618d, y: 0.5149321525135001d), new NpgsqlTypes.NpgsqlPoint(x: 0.11516173880407565d, y: 0.7185477883977942d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4451062531466804d, y: 0.05615173784442695d), new NpgsqlTypes.NpgsqlPoint(x: 0.27068605423083303d, y: 0.0364604039895603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5105987867647047d, y: 0.5702272938809377d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5636542407308304d, y: 0.7209620029948638d), new NpgsqlTypes.NpgsqlPoint(x: 0.19533576202475866d, y: 0.8591238495754049d), new NpgsqlTypes.NpgsqlPoint(x: 0.5145364216195241d, y: 0.06699069915115963d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5377774045810761d, y: 0.7523310895154559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8163706256947423d, y: 0.238260052715088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3320040304795665d, y: 0.192077108193762d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7361287921971795d, y: 0.9008000619817303d), new NpgsqlTypes.NpgsqlPoint(x: 0.4522421467036938d, y: 0.008736268821516568d), new NpgsqlTypes.NpgsqlPoint(x: 0.04530680606786264d, y: 0.1860547062236083d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5446169744203354d, y: 0.8224680406608935d), new NpgsqlTypes.NpgsqlPoint(x: 0.12689393849917008d, y: 0.24129395889481053d), new NpgsqlTypes.NpgsqlPoint(x: 0.45144767920198314d, y: 0.9326191394403601d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19357384066464178d, y: 0.8173540616238069d), new NpgsqlTypes.NpgsqlPoint(x: 0.08309267129937381d, y: 0.8771705164182644d), new NpgsqlTypes.NpgsqlPoint(x: 0.2110795700223015d, y: 0.05730767320365471d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6284763591628773d, y: 0.3703762339208245d), new NpgsqlTypes.NpgsqlPoint(x: 0.652274030424522d, y: 0.4711713741503799d), new NpgsqlTypes.NpgsqlPoint(x: 0.9604592575213672d, y: 0.8913798195437797d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07068538474206132d, y: 0.2850794742152375d), new NpgsqlTypes.NpgsqlPoint(x: 0.8573524671884734d, y: 0.3296199448192453d), new NpgsqlTypes.NpgsqlPoint(x: 0.4468607946060089d, y: 0.7969137676767604d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1827976545317762d, y: 0.9421920848205201d), new NpgsqlTypes.NpgsqlPoint(x: 0.20601900122490313d, y: 0.9006209358877081d), new NpgsqlTypes.NpgsqlPoint(x: 0.2110048384372294d, y: 0.24745115426082331d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.656617010656624d, y: 0.2757913891562369d), new NpgsqlTypes.NpgsqlPoint(x: 0.16135038362128484d, y: 0.345023661045453d), new NpgsqlTypes.NpgsqlPoint(x: 0.5430261947638589d, y: 0.2107431721432479d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5377385258563981d, y: 0.5078088803249893d), new NpgsqlTypes.NpgsqlPoint(x: 0.5321236749026644d, y: 0.7952147463180557d), new NpgsqlTypes.NpgsqlPoint(x: 0.8409260763826417d, y: 0.9472977738806022d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4130762862891758d, y: 0.4246345171294894d), new NpgsqlTypes.NpgsqlPoint(x: 0.42648966088566864d, y: 0.9640134058921686d), new NpgsqlTypes.NpgsqlPoint(x: 0.5986159645840895d, y: 0.6836415517599382d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.215796719239417d, y: 0.9914557297507168d), new NpgsqlTypes.NpgsqlPoint(x: 0.32931754550059267d, y: 0.2291661088470871d), new NpgsqlTypes.NpgsqlPoint(x: 0.8183407104125113d, y: 0.0421669837248021d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7338924263596439d, y: 0.6991294407233387d), new NpgsqlTypes.NpgsqlPoint(x: 0.673782989144252d, y: 0.5985187971990945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7450236785134468d, y: 0.1872967295511595d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8412055463793944d, y: 0.9082401799669833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8538707191324072d, y: 0.5551766730437497d), new NpgsqlTypes.NpgsqlPoint(x: 0.13880866448757156d, y: 0.5869283350824185d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6642285834293685d, y: 0.05586739346096481d), new NpgsqlTypes.NpgsqlPoint(x: 0.778599564627804d, y: 0.6595114008635088d), new NpgsqlTypes.NpgsqlPoint(x: 0.4827275769688605d, y: 0.9011679115175247d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3201318902362481d, y: 0.08601303055444542d), new NpgsqlTypes.NpgsqlPoint(x: 0.5600976530197624d, y: 0.33462239372808034d), new NpgsqlTypes.NpgsqlPoint(x: 0.5812734787483844d, y: 0.4800468443847794d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8502015909327009d, y: 0.5193731661965162d), new NpgsqlTypes.NpgsqlPoint(x: 0.0916712684956511d, y: 0.5074503444017375d), new NpgsqlTypes.NpgsqlPoint(x: 0.5412206539878223d, y: 0.07881204017226218d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34398350111326215d, y: 0.6039995042098785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7095426009618148d, y: 0.8489092937914865d), new NpgsqlTypes.NpgsqlPoint(x: 0.007689153318447217d, y: 0.20370432467055166d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13156723659528746d, y: 0.6561839912343687d), new NpgsqlTypes.NpgsqlPoint(x: 0.6216781166996658d, y: 0.24090697430692942d), new NpgsqlTypes.NpgsqlPoint(x: 0.716471344971832d, y: 0.806999268620648d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08325785799447749d, y: 0.5065796086990263d), new NpgsqlTypes.NpgsqlPoint(x: 0.8494018061124832d, y: 0.630508164021736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6178872420798978d, y: 0.942707477937123d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5976664976561501d, y: 0.7679804534478898d), new NpgsqlTypes.NpgsqlPoint(x: 0.038443077833102635d, y: 0.35582987347391604d), new NpgsqlTypes.NpgsqlPoint(x: 0.9628239410717048d, y: 0.5853078914687635d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7658356147925427d, y: 0.7492173675355689d), new NpgsqlTypes.NpgsqlPoint(x: 0.7930873253401284d, y: 0.5443867830855227d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439544574553038d, y: 0.30715584381189487d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5041129060434254d, y: 0.4855331580266714d), new NpgsqlTypes.NpgsqlPoint(x: 0.8151521467070196d, y: 0.21670299773397173d), new NpgsqlTypes.NpgsqlPoint(x: 0.8441925852029868d, y: 0.00123272901566851d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35165252193839724d, y: 0.2715169690138711d), new NpgsqlTypes.NpgsqlPoint(x: 0.2708519565776941d, y: 0.6355926663848839d), new NpgsqlTypes.NpgsqlPoint(x: 0.4634877971633896d, y: 0.27834875296923d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35541368087332836d, y: 0.631423252022746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6365512409090551d, y: 0.7424062072010466d), new NpgsqlTypes.NpgsqlPoint(x: 0.5023547834724408d, y: 0.4912121016726769d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3203858456537768d, y: 0.6603500299466731d), new NpgsqlTypes.NpgsqlPoint(x: 0.8972369628412977d, y: 0.44585386371035185d), new NpgsqlTypes.NpgsqlPoint(x: 0.5097132113125017d, y: 0.4796009634712247d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8774253844808196d, y: 0.645020148197735d), new NpgsqlTypes.NpgsqlPoint(x: 0.5667472227957904d, y: 0.3022453561120574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5744915158648927d, y: 0.22257904634581427d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15725023065286303d, y: 0.11780122548946026d), new NpgsqlTypes.NpgsqlPoint(x: 0.3048608857677406d, y: 0.5550135230523547d), new NpgsqlTypes.NpgsqlPoint(x: 0.3018900559260237d, y: 0.6328041714002424d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6582816024991917d, y: 0.5899045016303052d), new NpgsqlTypes.NpgsqlPoint(x: 0.8792483901763863d, y: 0.14103200894176227d), new NpgsqlTypes.NpgsqlPoint(x: 0.36353501624545626d, y: 0.467474197846631d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2550530359560732d, y: 0.21826087217767043d), new NpgsqlTypes.NpgsqlPoint(x: 0.11428864157754237d, y: 0.2681302147508082d), new NpgsqlTypes.NpgsqlPoint(x: 0.647959034125415d, y: 0.7154692730966543d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025100384875898496d, y: 0.9208398242341802d), new NpgsqlTypes.NpgsqlPoint(x: 0.5402417183743791d, y: 0.26883098322701404d), new NpgsqlTypes.NpgsqlPoint(x: 0.8214157520770433d, y: 0.5920283512087434d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.026843341314674918d, y: 0.6790575551643079d), new NpgsqlTypes.NpgsqlPoint(x: 0.3800188892658608d, y: 0.693254513257989d), new NpgsqlTypes.NpgsqlPoint(x: 0.607512645291162d, y: 0.0016587385532029764d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4088534089741893d, y: 0.5191057952597502d), new NpgsqlTypes.NpgsqlPoint(x: 0.6475277511298163d, y: 0.561741587905095d), new NpgsqlTypes.NpgsqlPoint(x: 0.2341448079911408d, y: 0.8355358264769013d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7213464322172279d, y: 0.47611578887966477d), new NpgsqlTypes.NpgsqlPoint(x: 0.25670806199074625d, y: 0.056459804514558676d), new NpgsqlTypes.NpgsqlPoint(x: 0.01746844424428695d, y: 0.5235962408896131d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19581021092626838d, y: 0.4831500699682765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8169293367130257d, y: 0.8027076214318072d), new NpgsqlTypes.NpgsqlPoint(x: 0.3813153177012154d, y: 0.3070449962207954d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9696506016124312d, y: 0.5614775390800385d), new NpgsqlTypes.NpgsqlPoint(x: 0.23831284758147486d, y: 0.9071179208651098d), new NpgsqlTypes.NpgsqlPoint(x: 0.90871586770248d, y: 0.08828401753110904d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6375209248466599d, y: 0.9068732504715158d), new NpgsqlTypes.NpgsqlPoint(x: 0.9875119564509541d, y: 0.047197376951332526d), new NpgsqlTypes.NpgsqlPoint(x: 0.18410268397837282d, y: 0.6998934148163887d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5088031843783136d, y: 0.9259208468775612d), new NpgsqlTypes.NpgsqlPoint(x: 0.7906296172932408d, y: 0.4218776066525377d), new NpgsqlTypes.NpgsqlPoint(x: 0.16604225531878436d, y: 0.6295935616536525d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5795170155286636d, y: 0.6659814450876536d), new NpgsqlTypes.NpgsqlPoint(x: 0.338507033600992d, y: 0.2948128233587932d), new NpgsqlTypes.NpgsqlPoint(x: 0.7755874608696367d, y: 0.9447330491415483d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1976713453094957d, y: 0.9876123179051468d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141755111804844d, y: 0.3890281097568078d), new NpgsqlTypes.NpgsqlPoint(x: 0.4565963883418579d, y: 0.8261859490875054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9867089947623213d, y: 0.312116275122464d), new NpgsqlTypes.NpgsqlPoint(x: 0.2662008866241391d, y: 0.4843977408871991d), new NpgsqlTypes.NpgsqlPoint(x: 0.21337833058056832d, y: 0.0009701773663884916d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6811208033233274d, y: 0.09605476622859643d), new NpgsqlTypes.NpgsqlPoint(x: 0.7456211875482739d, y: 0.9225928110014463d), new NpgsqlTypes.NpgsqlPoint(x: 0.26938656538519434d, y: 0.7263395029026036d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22970788149102916d, y: 0.26750909045482407d), new NpgsqlTypes.NpgsqlPoint(x: 0.38391545855617826d, y: 0.853537460946249d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006455572147013d, y: 0.0639346486691732d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6152358105043848d, y: 0.9810164765791297d), new NpgsqlTypes.NpgsqlPoint(x: 0.30691660716115066d, y: 0.8424488419448407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8601376471173595d, y: 0.5092969051546888d)),

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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[29], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 108, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 133, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 143, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 57, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 75, query1, 143, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 16, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 16, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 133, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 105, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 33, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);
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
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 95);
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

