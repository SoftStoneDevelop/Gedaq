

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
    internal partial interface INpgsqlBoxListboxArray
    {
    }
    
    internal partial class NpgsqlBoxListboxArray : INpgsqlBoxListboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray2M[] _testData = new NpgsqlBoxboxArray2M[]
        {
            new NpgsqlBoxboxArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7746986552950641d,right: 0.4991141709943332d,bottom: 0.296713802024703d,left: 0.43095105035687076d),

new NpgsqlTypes.NpgsqlBox(top: 0.9972673607591978d,right: 0.6163431301544543d,bottom: 0.675822089037615d,left: 0.14816559424273756d),

new NpgsqlTypes.NpgsqlBox(top: 0.6405321107960644d,right: 0.9092738496668987d,bottom: 0.1930343167554861d,left: 0.3999583944047814d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9836443579220899d,right: 0.7813935694921254d,bottom: 0.005583273150460477d,left: 0.03030509519533542d),

new NpgsqlTypes.NpgsqlBox(top: 0.8881843826522909d,right: 0.825623533650861d,bottom: 0.6566197790101687d,left: 0.7056133373292299d),

new NpgsqlTypes.NpgsqlBox(top: 0.6069445756551448d,right: 0.515945348741233d,bottom: 0.4079079140663209d,left: 0.18004024563834964d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5491205158737423d,right: 0.6742570191198763d,bottom: 0.392012917609741d,left: 0.0795911925488052d),

new NpgsqlTypes.NpgsqlBox(top: 0.3944025950750665d,right: 0.9014358153947152d,bottom: 0.18142106955308113d,left: 0.2590770729546277d),

new NpgsqlTypes.NpgsqlBox(top: 0.6004352779260764d,right: 0.4432620109909282d,bottom: 0.29277450611547096d,left: 0.19312672189960245d),

new NpgsqlTypes.NpgsqlBox(top: 0.36674290574817003d,right: 0.432569982631812d,bottom: 0.1270083168495526d,left: 0.14209835305602259d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.22192981343159135d,right: 0.5137216953955229d,bottom: 0.07864122692446185d,left: 0.29416555176249504d),

new NpgsqlTypes.NpgsqlBox(top: 0.9673721059990039d,right: 0.5129803802532535d,bottom: 0.5633355781040567d,left: 0.2961944360708503d),

new NpgsqlTypes.NpgsqlBox(top: 0.8848598984446445d,right: 0.4136679282433101d,bottom: 0.4165088078716034d,left: 0.17193673588404546d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.34447700787282487d,right: 0.6744518725324072d,bottom: 0.07362188718770657d,left: 0.5098359036472229d),

new NpgsqlTypes.NpgsqlBox(top: 0.6050332523607493d,right: 0.8016477308384049d,bottom: 0.10679373448154172d,left: 0.5832779623986689d),

new NpgsqlTypes.NpgsqlBox(top: 0.7561151307762313d,right: 0.452552833002524d,bottom: 0.3158191221147467d,left: 0.10498675483348063d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.36367520570830203d,right: 0.6895523596323246d,bottom: 0.08315452133992995d,left: 0.09226670672767623d),

new NpgsqlTypes.NpgsqlBox(top: 0.6068195776319809d,right: 0.9108065773983609d,bottom: 0.09741756004025548d,left: 0.32877261111554534d),

new NpgsqlTypes.NpgsqlBox(top: 0.7881437069729919d,right: 0.7842517701310368d,bottom: 0.6853442499048219d,left: 0.27435431567919355d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.731469154092533d,right: 0.48286496742772944d,bottom: 0.3402608488365898d,left: 0.19772790217412584d),

new NpgsqlTypes.NpgsqlBox(top: 0.8159802101550997d,right: 0.984605166258543d,bottom: 0.6524800694435438d,left: 0.10220817610011024d),

new NpgsqlTypes.NpgsqlBox(top: 0.8970101969067059d,right: 0.5568360073216614d,bottom: 0.3781168043335401d,left: 0.2536408607304941d),

new NpgsqlTypes.NpgsqlBox(top: 0.07662632014948068d,right: 0.39894272562831756d,bottom: 0.004233635116062118d,left: 0.25890573457585964d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7304581093965681d,right: 0.19897979010935163d,bottom: 0.4111717870117565d,left: 0.01220825599386166d),

new NpgsqlTypes.NpgsqlBox(top: 0.3446683392592693d,right: 0.24448761132210084d,bottom: 0.05184201705042801d,left: 0.020140870965195234d),

new NpgsqlTypes.NpgsqlBox(top: 0.5260191645316635d,right: 0.8610659817590376d,bottom: 0.44777889245897173d,left: 0.2012043301969172d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7201050768499297d,right: 0.5178731857581749d,bottom: 0.3778503985769085d,left: 0.4220520884190444d),

new NpgsqlTypes.NpgsqlBox(top: 0.47466222652572165d,right: 0.8281277569805592d,bottom: 0.4273049109578645d,left: 0.04358411566062781d),

new NpgsqlTypes.NpgsqlBox(top: 0.5174374705929746d,right: 0.4327685065952672d,bottom: 0.49664996960015084d,left: 0.005129912821042915d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2507816087093445d,right: 0.3531971473276393d,bottom: 0.1832193800125913d,left: 0.09280940047828767d),

new NpgsqlTypes.NpgsqlBox(top: 0.6671701603705522d,right: 0.5896026457606459d,bottom: 0.06695603771452108d,left: 0.20794315216452297d),

new NpgsqlTypes.NpgsqlBox(top: 0.5575608164532143d,right: 0.5469315243104819d,bottom: 0.5394619541265041d,left: 0.17442385302253227d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7941647994040407d,right: 0.8793534791169204d,bottom: 0.7617487263050432d,left: 0.6482355938785955d),

new NpgsqlTypes.NpgsqlBox(top: 0.8901472525304046d,right: 0.93147807271998d,bottom: 0.8685770280948092d,left: 0.7042043380139034d),

new NpgsqlTypes.NpgsqlBox(top: 0.9185704808617597d,right: 0.25431530413835013d,bottom: 0.36347134319071994d,left: 0.24876512182403665d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.15592208952154107d,right: 0.8631322280177358d,bottom: 0.0322572016851953d,left: 0.6371233767318325d),

new NpgsqlTypes.NpgsqlBox(top: 0.45424370343980813d,right: 0.27705206803463645d,bottom: 0.2615814640134666d,left: 0.07404596941827957d),

new NpgsqlTypes.NpgsqlBox(top: 0.6261399039013283d,right: 0.6974768395441513d,bottom: 0.42607950041553355d,left: 0.15696022584629288d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8116050877232466d,right: 0.39013650595886473d,bottom: 0.0006482218045715804d,left: 0.2735575549157572d),

new NpgsqlTypes.NpgsqlBox(top: 0.8396261588690442d,right: 0.5494354945528891d,bottom: 0.7848784735807519d,left: 0.05320876465452429d),

new NpgsqlTypes.NpgsqlBox(top: 0.8275842349499994d,right: 0.8041290630145707d,bottom: 0.3135121602423169d,left: 0.3908375790414951d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.32577831254037404d,right: 0.9666542235588368d,bottom: 0.2852243538867121d,left: 0.4828155795713345d),

new NpgsqlTypes.NpgsqlBox(top: 0.9584204789878602d,right: 0.9295574767029752d,bottom: 0.6965526412032454d,left: 0.8313081992271019d),

new NpgsqlTypes.NpgsqlBox(top: 0.7864212538609d,right: 0.5560010341330411d,bottom: 0.5656870751200479d,left: 0.34945429427986274d),

new NpgsqlTypes.NpgsqlBox(top: 0.4262332269156588d,right: 0.8325474064399073d,bottom: 0.010320580863132922d,left: 0.5672818426505818d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9007930594191362d,right: 0.9879469605748189d,bottom: 0.023203250177763257d,left: 0.19468929222958853d),

new NpgsqlTypes.NpgsqlBox(top: 0.9338688753597163d,right: 0.6870192182668731d,bottom: 0.2816997529725811d,left: 0.05476260700106317d),

new NpgsqlTypes.NpgsqlBox(top: 0.34978642412503635d,right: 0.08598874665709622d,bottom: 0.22773080636958598d,left: 0.03421392461092121d),

new NpgsqlTypes.NpgsqlBox(top: 0.9976378819078188d,right: 0.4015824390275313d,bottom: 0.4350786063304053d,left: 0.17413511695358996d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8483527966964891d,right: 0.6249541222336755d,bottom: 0.7288940158060967d,left: 0.5385508257110497d),

new NpgsqlTypes.NpgsqlBox(top: 0.8078185725149336d,right: 0.4752115613158877d,bottom: 0.6157293690242536d,left: 0.34562018348401513d),

new NpgsqlTypes.NpgsqlBox(top: 0.18584415722161973d,right: 0.495204637163961d,bottom: 0.07206346121674678d,left: 0.24456869457596386d),

new NpgsqlTypes.NpgsqlBox(top: 0.6580870819477668d,right: 0.518964847796072d,bottom: 0.1840154280995655d,left: 0.4938503861684276d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8171883583963595d,right: 0.8194529742209175d,bottom: 0.5692784348905733d,left: 0.7281085701206732d),

new NpgsqlTypes.NpgsqlBox(top: 0.9706423540916379d,right: 0.4469181982666167d,bottom: 0.4907690367707028d,left: 0.3494801865138686d),

new NpgsqlTypes.NpgsqlBox(top: 0.3910801302225063d,right: 0.2725500863372081d,bottom: 0.10604832601014536d,left: 0.0470785075369583d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9458849943866364d,right: 0.9287253010666748d,bottom: 0.47622456415087566d,left: 0.04452995153700956d),

new NpgsqlTypes.NpgsqlBox(top: 0.6622749143226306d,right: 0.4114142941784301d,bottom: 0.3496842061801416d,left: 0.35549174163808084d),

new NpgsqlTypes.NpgsqlBox(top: 0.8661464231201355d,right: 0.7361625841286304d,bottom: 0.13444850861779412d,left: 0.6561572275638793d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.13052062977649437d,right: 0.9315426364859101d,bottom: 0.10021220038508916d,left: 0.07829085179156103d),

new NpgsqlTypes.NpgsqlBox(top: 0.5719947936125884d,right: 0.5210539170813919d,bottom: 0.5715559356104515d,left: 0.2389821991357831d),

new NpgsqlTypes.NpgsqlBox(top: 0.7501667126565992d,right: 0.8625903687214553d,bottom: 0.5235162116446859d,left: 0.7298823279619588d),

new NpgsqlTypes.NpgsqlBox(top: 0.7491417502528401d,right: 0.9177365983427024d,bottom: 0.6101306804021366d,left: 0.11238894962694257d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.704811484181098d,right: 0.5616329220710322d,bottom: 0.5977546172249121d,left: 0.3382223544091312d),

new NpgsqlTypes.NpgsqlBox(top: 0.9946941446212456d,right: 0.9751882374081944d,bottom: 0.7509687197758761d,left: 0.059019391606399796d),

new NpgsqlTypes.NpgsqlBox(top: 0.9725372473193042d,right: 0.9591111810513409d,bottom: 0.6293813278632799d,left: 0.915908265306904d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9720411615186226d,right: 0.9338988679935089d,bottom: 0.7790831951987147d,left: 0.26078419507010575d),

new NpgsqlTypes.NpgsqlBox(top: 0.36809843126571995d,right: 0.9321269142945676d,bottom: 0.0285714349763162d,left: 0.07232447160819722d),

new NpgsqlTypes.NpgsqlBox(top: 0.9618481833673251d,right: 0.6823380978317868d,bottom: 0.00033830636388942903d,left: 0.41015290973099605d),

new NpgsqlTypes.NpgsqlBox(top: 0.7664234073839993d,right: 0.8266507180589314d,bottom: 0.37082635171680356d,left: 0.45973194138997087d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6053702177432845d,right: 0.9048764531312059d,bottom: 0.2161739693153617d,left: 0.11214598657442432d),

new NpgsqlTypes.NpgsqlBox(top: 0.4585010303757435d,right: 0.7415766351567827d,bottom: 0.25250166066646906d,left: 0.6875815743064476d),

new NpgsqlTypes.NpgsqlBox(top: 0.40088175968721773d,right: 0.9226454640806427d,bottom: 0.32886955563905573d,left: 0.7418592773910588d),

new NpgsqlTypes.NpgsqlBox(top: 0.37080262727571656d,right: 0.7586320415402671d,bottom: 0.14157588213381544d,left: 0.02573044071616304d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.29026567694979455d,right: 0.6610680842960898d,bottom: 0.26628503880151166d,left: 0.13490160754109815d),

new NpgsqlTypes.NpgsqlBox(top: 0.23014454589712785d,right: 0.9863917386070878d,bottom: 0.09511775406342149d,left: 0.8504734839363783d),

new NpgsqlTypes.NpgsqlBox(top: 0.49294770239717156d,right: 0.9630427801823274d,bottom: 0.17269146369890453d,left: 0.5473806741771495d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.630326735047587d,right: 0.2715325049701012d,bottom: 0.441827093332687d,left: 0.19170792904028755d),

new NpgsqlTypes.NpgsqlBox(top: 0.9066797375084408d,right: 0.5488878532479313d,bottom: 0.36095920402067705d,left: 0.22131606679283966d),

new NpgsqlTypes.NpgsqlBox(top: 0.7764225604299583d,right: 0.9357970498932661d,bottom: 0.6678523926441159d,left: 0.5284454410624269d),

new NpgsqlTypes.NpgsqlBox(top: 0.5768151205105814d,right: 0.7091287329841643d,bottom: 0.004282150581944255d,left: 0.00941684693307554d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8184611572542779d,right: 0.7786980721404623d,bottom: 0.24349710214156373d,left: 0.12806659782404373d),

new NpgsqlTypes.NpgsqlBox(top: 0.66452780472442d,right: 0.9921082477157999d,bottom: 0.395269363981264d,left: 0.8967240202372059d),

new NpgsqlTypes.NpgsqlBox(top: 0.7553872544082667d,right: 0.5697619094479226d,bottom: 0.02290700901755005d,left: 0.04766475040433049d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.645923140598453d,right: 0.902857518337585d,bottom: 0.16997896501539578d,left: 0.6029166159798568d),

new NpgsqlTypes.NpgsqlBox(top: 0.944845305368174d,right: 0.6756348025828776d,bottom: 0.5817135681422719d,left: 0.17568506003543027d),

new NpgsqlTypes.NpgsqlBox(top: 0.2889794138243992d,right: 0.7130454105252312d,bottom: 0.1982651445920438d,left: 0.5939812858514164d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5050375256720272d,right: 0.5865980099946213d,bottom: 0.0067733298478867d,left: 0.18945223354786844d),

new NpgsqlTypes.NpgsqlBox(top: 0.4259224750345373d,right: 0.8475766792301609d,bottom: 0.36056725172378234d,left: 0.26286658040887156d),

new NpgsqlTypes.NpgsqlBox(top: 0.6361218245085267d,right: 0.908330769061331d,bottom: 0.06128874094745518d,left: 0.050233115576251874d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.38503000238025686d,right: 0.2615664640248957d,bottom: 0.10807283695364756d,left: 0.10460342357902241d),

new NpgsqlTypes.NpgsqlBox(top: 0.5047336198013626d,right: 0.3772269429573938d,bottom: 0.006444851240187233d,left: 0.0054361455820368665d),

new NpgsqlTypes.NpgsqlBox(top: 0.7618354358899128d,right: 0.8787895494518595d,bottom: 0.47850213573034095d,left: 0.7098801262534213d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.39073506385406276d,right: 0.2123405059085619d,bottom: 0.1695595817272394d,left: 0.00867430952112902d),

new NpgsqlTypes.NpgsqlBox(top: 0.8241800878660005d,right: 0.6621102400499481d,bottom: 0.292094902571568d,left: 0.09823608195051015d),

new NpgsqlTypes.NpgsqlBox(top: 0.9038787170803025d,right: 0.2898910768352977d,bottom: 0.23056142069426733d,left: 0.06416229864264866d),

new NpgsqlTypes.NpgsqlBox(top: 0.5598611539229182d,right: 0.7391884972818314d,bottom: 0.16409136621525255d,left: 0.14777466964827835d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8617940117295002d,right: 0.9524289464305122d,bottom: 0.5831335466840797d,left: 0.38606831017744103d),

new NpgsqlTypes.NpgsqlBox(top: 0.9258511483543649d,right: 0.4873740495020633d,bottom: 0.0658122205377435d,left: 0.08657601456822683d),

new NpgsqlTypes.NpgsqlBox(top: 0.7154455149635758d,right: 0.44561770186927574d,bottom: 0.4066451867372678d,left: 0.17828470401412144d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2548996854440567d,right: 0.31612882774381834d,bottom: 0.07707943207486945d,left: 0.15399731102500636d),

new NpgsqlTypes.NpgsqlBox(top: 0.31801263723726525d,right: 0.5687678388075896d,bottom: 0.06796000165732508d,left: 0.4607113428081334d),

new NpgsqlTypes.NpgsqlBox(top: 0.32443363998198416d,right: 0.9634254686754994d,bottom: 0.17148876133724278d,left: 0.4247825566619846d),

new NpgsqlTypes.NpgsqlBox(top: 0.34049782998798617d,right: 0.27757562376270206d,bottom: 0.08812236138576257d,left: 0.15438914006117033d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.614817674599124d,right: 0.9636890252398972d,bottom: 0.21593453690406106d,left: 0.06521846213490146d),

new NpgsqlTypes.NpgsqlBox(top: 0.10787323420540817d,right: 0.9393191246365223d,bottom: 0.08322361048795768d,left: 0.9234904460129061d),

new NpgsqlTypes.NpgsqlBox(top: 0.6911742240880007d,right: 0.09403237404019382d,bottom: 0.5511988610320102d,left: 0.00611635115604392d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8402365822668226d,right: 0.8334091022638032d,bottom: 0.47687825468332623d,left: 0.6470927527636053d),

new NpgsqlTypes.NpgsqlBox(top: 0.9612050946117603d,right: 0.5266579922197997d,bottom: 0.9500606665059783d,left: 0.21009048608810443d),

new NpgsqlTypes.NpgsqlBox(top: 0.1583808836442484d,right: 0.8733782465770021d,bottom: 0.1011443068197646d,left: 0.3114657427532874d),

new NpgsqlTypes.NpgsqlBox(top: 0.6722225638816417d,right: 0.6898524705251394d,bottom: 0.23508109320134996d,left: 0.08708396866435442d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6954031371530136d,right: 0.19736629675771744d,bottom: 0.2266823923524779d,left: 0.16600319147342613d),

new NpgsqlTypes.NpgsqlBox(top: 0.39771040552620995d,right: 0.7559166009815833d,bottom: 0.3272349663438773d,left: 0.5240075219735568d),

new NpgsqlTypes.NpgsqlBox(top: 0.754904257439274d,right: 0.9038443893704855d,bottom: 0.4109472396948105d,left: 0.4292673396637311d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3325666470742987d,right: 0.8631503487842449d,bottom: 0.18675212950554665d,left: 0.729433257951575d),

new NpgsqlTypes.NpgsqlBox(top: 0.17827305707722407d,right: 0.7327349944448637d,bottom: 0.0604711081522149d,left: 0.10264258172517049d),

new NpgsqlTypes.NpgsqlBox(top: 0.8121934286525514d,right: 0.5608740610925993d,bottom: 0.4008241134864605d,left: 0.519683054344933d),

new NpgsqlTypes.NpgsqlBox(top: 0.48664378019990395d,right: 0.3976177944022975d,bottom: 0.4451320601128842d,left: 0.38521492558645976d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3736014702011444d,right: 0.8626206940762352d,bottom: 0.19453737998287524d,left: 0.4677497779897317d),

new NpgsqlTypes.NpgsqlBox(top: 0.49446996210168004d,right: 0.38699462881136226d,bottom: 0.12546348131023355d,left: 0.32483725591051016d),

new NpgsqlTypes.NpgsqlBox(top: 0.08827870815564653d,right: 0.9897448810844452d,bottom: 0.05492939015364495d,left: 0.8090323612712809d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.366332635219228d,right: 0.8190237300237279d,bottom: 0.35142717623294983d,left: 0.44209912980257093d),

new NpgsqlTypes.NpgsqlBox(top: 0.695933230881239d,right: 0.44226635225662836d,bottom: 0.6406874984187705d,left: 0.4130994630854332d),

new NpgsqlTypes.NpgsqlBox(top: 0.3475843373925148d,right: 0.617646904848187d,bottom: 0.11243994117691036d,left: 0.19158335641936441d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9685300760522609d,right: 0.5266691101297536d,bottom: 0.4568323520784551d,left: 0.18650908804348942d),

new NpgsqlTypes.NpgsqlBox(top: 0.7644327945271538d,right: 0.8069919298326002d,bottom: 0.59476650447848d,left: 0.03238095372557703d),

new NpgsqlTypes.NpgsqlBox(top: 0.5719583544958314d,right: 0.40529735886405516d,bottom: 0.5109214031525156d,left: 0.020873201683021092d),

new NpgsqlTypes.NpgsqlBox(top: 0.7513281552510145d,right: 0.9858605463751605d,bottom: 0.6888165693247558d,left: 0.6885026500782562d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.26604239934582774d,right: 0.6553324324826164d,bottom: 0.18872656755351613d,left: 0.02070532560506244d),

new NpgsqlTypes.NpgsqlBox(top: 0.48047291950608495d,right: 0.7000590662266348d,bottom: 0.40644126772420863d,left: 0.590906449791973d),

new NpgsqlTypes.NpgsqlBox(top: 0.6898532066853739d,right: 0.39565030836772863d,bottom: 0.43567185841826206d,left: 0.011119250276087622d),

new NpgsqlTypes.NpgsqlBox(top: 0.5611298533433174d,right: 0.79566599233445d,bottom: 0.0210543267366462d,left: 0.543826630523942d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9768428593426626d,right: 0.8423709716854875d,bottom: 0.9255404418842976d,left: 0.5703296769764267d),

new NpgsqlTypes.NpgsqlBox(top: 0.9259279185315794d,right: 0.6165906237683885d,bottom: 0.8792431095442749d,left: 0.041353565002628656d),

new NpgsqlTypes.NpgsqlBox(top: 0.3788146932591926d,right: 0.5584087670271625d,bottom: 0.31030097300653725d,left: 0.1757594794902182d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8607064928700909d,right: 0.6255102131906105d,bottom: 0.14515185660516416d,left: 0.21990374492077347d),

new NpgsqlTypes.NpgsqlBox(top: 0.8478311664900792d,right: 0.9249273507222036d,bottom: 0.20877487455600086d,left: 0.8084720268553588d),

new NpgsqlTypes.NpgsqlBox(top: 0.47001529386310026d,right: 0.43938163681878695d,bottom: 0.3689026261551054d,left: 0.347625778777197d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6011695983819346d,right: 0.39591486481701854d,bottom: 0.3120686524612064d,left: 0.12964774100902698d),

new NpgsqlTypes.NpgsqlBox(top: 0.6774369414976682d,right: 0.876036130551251d,bottom: 0.5196191741950805d,left: 0.3946347083664229d),

new NpgsqlTypes.NpgsqlBox(top: 0.7978686172593163d,right: 0.23811768138303369d,bottom: 0.4846930614516648d,left: 0.011697873752634758d),

new NpgsqlTypes.NpgsqlBox(top: 0.3851703802975439d,right: 0.7608275389262685d,bottom: 0.2218605786548028d,left: 0.24405394137105663d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7267136520423759d,right: 0.5537041952576691d,bottom: 0.02208006889076375d,left: 0.4726885594567235d),

new NpgsqlTypes.NpgsqlBox(top: 0.5617413874150969d,right: 0.308255484062515d,bottom: 0.2512947991668555d,left: 0.19596818276018935d),

new NpgsqlTypes.NpgsqlBox(top: 0.4410207200079317d,right: 0.9379520087066162d,bottom: 0.33857971716770585d,left: 0.08737870186067898d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5003485995774334d,right: 0.34998171745783335d,bottom: 0.30738808888820746d,left: 0.12006575970101696d),

new NpgsqlTypes.NpgsqlBox(top: 0.8831350806778637d,right: 0.2090540808285103d,bottom: 0.8360423786982734d,left: 0.17167958586055387d),

new NpgsqlTypes.NpgsqlBox(top: 0.6659526276438057d,right: 0.3733253731935505d,bottom: 0.4183472246542834d,left: 0.07514966482740792d),

new NpgsqlTypes.NpgsqlBox(top: 0.05646776811492804d,right: 0.9707265385163252d,bottom: 0.045840000807797154d,left: 0.5990459121986611d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9926711681081228d,right: 0.9970061848125669d,bottom: 0.3586651037608728d,left: 0.5662028250885189d),

new NpgsqlTypes.NpgsqlBox(top: 0.42777266062424446d,right: 0.7205185042776922d,bottom: 0.3353981898924361d,left: 0.08461789747694204d),

new NpgsqlTypes.NpgsqlBox(top: 0.3600094616299443d,right: 0.7412038336122833d,bottom: 0.14711544375577346d,left: 0.17795794742359827d),

new NpgsqlTypes.NpgsqlBox(top: 0.2872516853242426d,right: 0.6058315167646535d,bottom: 0.13843910479822563d,left: 0.18213215073874212d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.48815998963205065d,right: 0.8019714250938176d,bottom: 0.01407192816110181d,left: 0.3643762743075477d),

new NpgsqlTypes.NpgsqlBox(top: 0.394764131678081d,right: 0.9032726394941637d,bottom: 0.18549283473448375d,left: 0.13000721220049294d),

new NpgsqlTypes.NpgsqlBox(top: 0.7884964224066203d,right: 0.5256565523868749d,bottom: 0.15071243133496903d,left: 0.34562689991633766d),

new NpgsqlTypes.NpgsqlBox(top: 0.3618963670497152d,right: 0.961880763511491d,bottom: 0.10309370028473075d,left: 0.7281527213948515d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7792144393916458d,right: 0.34924986975079253d,bottom: 0.5134718087973638d,left: 0.3314095063249146d),

new NpgsqlTypes.NpgsqlBox(top: 0.4410932713842388d,right: 0.25785392656579276d,bottom: 0.13113085967051286d,left: 0.2315779051245217d),

new NpgsqlTypes.NpgsqlBox(top: 0.9225177367442954d,right: 0.10145680523974354d,bottom: 0.3565345047161891d,left: 0.09637816010306677d),

new NpgsqlTypes.NpgsqlBox(top: 0.6577889957401478d,right: 0.7799595541367531d,bottom: 0.06661059824967297d,left: 0.7294075872240952d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7331814638850916d,right: 0.7646924101512902d,bottom: 0.09537832583043115d,left: 0.22600919568824684d),

new NpgsqlTypes.NpgsqlBox(top: 0.4719120065106832d,right: 0.6528584757114061d,bottom: 0.13258648785039762d,left: 0.14260755291893068d),

new NpgsqlTypes.NpgsqlBox(top: 0.9259044899321666d,right: 0.853091024903383d,bottom: 0.1897847118356436d,left: 0.7966494552172042d),

new NpgsqlTypes.NpgsqlBox(top: 0.5654165566202425d,right: 0.28902701341072734d,bottom: 0.07318768054725477d,left: 0.21757919846281848d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6101089925943847d,right: 0.25374637373671804d,bottom: 0.05590565349613108d,left: 0.05082892091330826d),

new NpgsqlTypes.NpgsqlBox(top: 0.7179655738398665d,right: 0.778818394007025d,bottom: 0.6226557007181959d,left: 0.5670899507571002d),

new NpgsqlTypes.NpgsqlBox(top: 0.4689726930325854d,right: 0.8199706606425631d,bottom: 0.31331730682996894d,left: 0.3850452320932658d),

new NpgsqlTypes.NpgsqlBox(top: 0.24291979223085014d,right: 0.9391009256474803d,bottom: 0.22207792304653895d,left: 0.7931175577696276d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9796818634761281d,right: 0.6158512701515635d,bottom: 0.2989761307711797d,left: 0.5334335694411841d),

new NpgsqlTypes.NpgsqlBox(top: 0.9537711495152708d,right: 0.6181276850223271d,bottom: 0.525755109882322d,left: 0.26370699218874627d),

new NpgsqlTypes.NpgsqlBox(top: 0.8131752420440893d,right: 0.583163680076682d,bottom: 0.5086281820968906d,left: 0.3300653375207826d),

new NpgsqlTypes.NpgsqlBox(top: 0.230395140282194d,right: 0.2692396106133347d,bottom: 0.09897099916546237d,left: 0.23340004601758624d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8912895462241583d,right: 0.6993038854594845d,bottom: 0.6674330339330081d,left: 0.6521366764717322d),

new NpgsqlTypes.NpgsqlBox(top: 0.7477803287818716d,right: 0.7815438728482174d,bottom: 0.23790517813171497d,left: 0.5201168954403551d),

new NpgsqlTypes.NpgsqlBox(top: 0.30891736090773614d,right: 0.6149173219775578d,bottom: 0.3080495086874754d,left: 0.07776042819998841d),

new NpgsqlTypes.NpgsqlBox(top: 0.3526991036485755d,right: 0.2414733629346093d,bottom: 0.26653053235131174d,left: 0.015480535053778222d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7277710117362007d,right: 0.7685662867068597d,bottom: 0.5854597262476968d,left: 0.20680574751683445d),

new NpgsqlTypes.NpgsqlBox(top: 0.3762505384391942d,right: 0.6412281366382991d,bottom: 0.019790479632482594d,left: 0.6286600993768418d),

new NpgsqlTypes.NpgsqlBox(top: 0.22263564056437435d,right: 0.6810465433400749d,bottom: 0.00800672442790884d,left: 0.038984562537460965d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5388385991288758d,right: 0.98708689821247d,bottom: 0.20774075992541563d,left: 0.8951748288289607d),

new NpgsqlTypes.NpgsqlBox(top: 0.7351741294305529d,right: 0.27757216798661255d,bottom: 0.6939186887696986d,left: 0.2211942550840459d),

new NpgsqlTypes.NpgsqlBox(top: 0.8721203345313994d,right: 0.5941085676891487d,bottom: 0.6814470892218989d,left: 0.45464876230268847d),

new NpgsqlTypes.NpgsqlBox(top: 0.9497674602402034d,right: 0.8019363364354789d,bottom: 0.6937168445105611d,left: 0.2365306824473452d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8555828563855056d,right: 0.6526942679351795d,bottom: 0.5320779777937247d,left: 0.6010817493732242d),

new NpgsqlTypes.NpgsqlBox(top: 0.23574660332960007d,right: 0.8436435194943313d,bottom: 0.0862168452499158d,left: 0.42280850448291407d),

new NpgsqlTypes.NpgsqlBox(top: 0.8814398103759898d,right: 0.5609974072357181d,bottom: 0.8740872151088814d,left: 0.12130851205184545d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5400130503280964d,right: 0.7509089134530924d,bottom: 0.4221710880339624d,left: 0.3966073670745154d),

new NpgsqlTypes.NpgsqlBox(top: 0.48283011918619223d,right: 0.07371757205060858d,bottom: 0.3002871362617867d,left: 0.03915864962496041d),

new NpgsqlTypes.NpgsqlBox(top: 0.5575015897535041d,right: 0.9954765513135553d,bottom: 0.35969092861176444d,left: 0.5384782766398001d),

new NpgsqlTypes.NpgsqlBox(top: 0.877527469585345d,right: 0.6842087035886066d,bottom: 0.5097638733124262d,left: 0.2460580790933079d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8389935739040374d,right: 0.7872339109419783d,bottom: 0.001991849492637421d,left: 0.24095853772152886d),

new NpgsqlTypes.NpgsqlBox(top: 0.7535773785853478d,right: 0.7867361960112543d,bottom: 0.6137625187768512d,left: 0.27740463573503904d),

new NpgsqlTypes.NpgsqlBox(top: 0.2570071425697561d,right: 0.9503963953558665d,bottom: 0.0623999277459244d,left: 0.2699239142801567d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.862199792629214d,right: 0.5524788245839058d,bottom: 0.6439758799126555d,left: 0.1743137312785178d),

new NpgsqlTypes.NpgsqlBox(top: 0.7735422589366474d,right: 0.9976089230323726d,bottom: 0.32289307860141025d,left: 0.20442992824842254d),

new NpgsqlTypes.NpgsqlBox(top: 0.7167677735301845d,right: 0.9801529270432784d,bottom: 0.46524459182386235d,left: 0.3211834987801496d),

new NpgsqlTypes.NpgsqlBox(top: 0.7866190271049783d,right: 0.9182134496931342d,bottom: 0.4063843800713196d,left: 0.5010111342617084d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8071249419431576d,right: 0.9974805657385807d,bottom: 0.6151739834952582d,left: 0.5453808992412984d),

new NpgsqlTypes.NpgsqlBox(top: 0.9428536092041362d,right: 0.5439641967798291d,bottom: 0.8791691129264417d,left: 0.33608636046788876d),

new NpgsqlTypes.NpgsqlBox(top: 0.9067622261317566d,right: 0.4574587684405038d,bottom: 0.19986704313019032d,left: 0.2437448747308617d),

new NpgsqlTypes.NpgsqlBox(top: 0.3301505106290903d,right: 0.39114473344531187d,bottom: 0.25383261009940583d,left: 0.21099075587727956d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5266542513456078d,right: 0.37198654014229815d,bottom: 0.09823055656097246d,left: 0.05898572993245843d),

new NpgsqlTypes.NpgsqlBox(top: 0.5132045963747142d,right: 0.8940253880557841d,bottom: 0.26540842230478745d,left: 0.505832111924303d),

new NpgsqlTypes.NpgsqlBox(top: 0.4805297344012168d,right: 0.834283889250502d,bottom: 0.17542245167324677d,left: 0.6715431360451828d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8946439736468301d,right: 0.3160086344367231d,bottom: 0.024724865401305474d,left: 0.0667877735591047d),

new NpgsqlTypes.NpgsqlBox(top: 0.8367108973737427d,right: 0.9998944516754545d,bottom: 0.3843126089209775d,left: 0.29685063094884345d),

new NpgsqlTypes.NpgsqlBox(top: 0.7031610021433882d,right: 0.8220332426731082d,bottom: 0.18813487863084188d,left: 0.21796708308203727d),

new NpgsqlTypes.NpgsqlBox(top: 0.9375644179547211d,right: 0.6080928579718428d,bottom: 0.8079931663165877d,left: 0.04457883724751577d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9400459672228559d,right: 0.5377929495885048d,bottom: 0.8867126804559065d,left: 0.27794525221351385d),

new NpgsqlTypes.NpgsqlBox(top: 0.690643018584407d,right: 0.7358165456292947d,bottom: 0.1647148264364593d,left: 0.5286321440094696d),

new NpgsqlTypes.NpgsqlBox(top: 0.786479727927077d,right: 0.9216230827287909d,bottom: 0.3894417323494075d,left: 0.4651946441360052d),

new NpgsqlTypes.NpgsqlBox(top: 0.09211295039244738d,right: 0.8309051597798188d,bottom: 0.04942107869169954d,left: 0.14516155295728816d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9914104352111077d,right: 0.6922745410351118d,bottom: 0.10038424230390541d,left: 0.3085433618757951d),

new NpgsqlTypes.NpgsqlBox(top: 0.6048770728160938d,right: 0.8397344124026668d,bottom: 0.5298470707264722d,left: 0.44958674009804667d),

new NpgsqlTypes.NpgsqlBox(top: 0.7663198178771247d,right: 0.9286830374579429d,bottom: 0.3188489057959589d,left: 0.5021061649859239d),

new NpgsqlTypes.NpgsqlBox(top: 0.8631214714689778d,right: 0.5499948857423721d,bottom: 0.2358924775617044d,left: 0.5113588668532293d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7446217233994605d,right: 0.98870369572712d,bottom: 0.3468625669173212d,left: 0.7041553393996692d),

new NpgsqlTypes.NpgsqlBox(top: 0.6779965712955869d,right: 0.1423897625743118d,bottom: 0.3136518228600246d,left: 0.12616230437689324d),

new NpgsqlTypes.NpgsqlBox(top: 0.7333617465695977d,right: 0.672432284630403d,bottom: 0.5495697715987681d,left: 0.5742037545392327d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7237676213038144d,right: 0.9283348659090012d,bottom: 0.2979699394762867d,left: 0.8766311708355784d),

new NpgsqlTypes.NpgsqlBox(top: 0.5281368584415158d,right: 0.6012363543892755d,bottom: 0.16741984052366055d,left: 0.4791334362443136d),

new NpgsqlTypes.NpgsqlBox(top: 0.8463210373139188d,right: 0.18326184753444263d,bottom: 0.7067986263696779d,left: 0.05254460066898181d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6753647994817364d,right: 0.7596724775569152d,bottom: 0.21686646162546142d,left: 0.5656785184589326d),

new NpgsqlTypes.NpgsqlBox(top: 0.5416612641195473d,right: 0.9300667232892023d,bottom: 0.4261520668390725d,left: 0.5980358889679716d),

new NpgsqlTypes.NpgsqlBox(top: 0.6081300492874678d,right: 0.6429739528020081d,bottom: 0.3466899704101273d,left: 0.3653713731776421d),

new NpgsqlTypes.NpgsqlBox(top: 0.9129143031408935d,right: 0.47214116816959195d,bottom: 0.621127975581057d,left: 0.12500368754033797d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8845065001249054d,right: 0.4787673518274447d,bottom: 0.250508324898587d,left: 0.02632866464100081d),

new NpgsqlTypes.NpgsqlBox(top: 0.3990355579893641d,right: 0.6715469908613378d,bottom: 0.3553125717052509d,left: 0.10680477337421346d),

new NpgsqlTypes.NpgsqlBox(top: 0.1939180702966683d,right: 0.902377039081931d,bottom: 0.16650005606522855d,left: 0.4398931628723015d),

new NpgsqlTypes.NpgsqlBox(top: 0.5158136552832212d,right: 0.8369906729954336d,bottom: 0.4736207121181212d,left: 0.10094408156751267d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.24504660279188983d,right: 0.9131235601816172d,bottom: 0.1246495707692381d,left: 0.23766008166105124d),

new NpgsqlTypes.NpgsqlBox(top: 0.8981881713871929d,right: 0.8154669064868588d,bottom: 0.15247311478559122d,left: 0.6855789038704247d),

new NpgsqlTypes.NpgsqlBox(top: 0.6596128419345647d,right: 0.7997201753957035d,bottom: 0.5705240972446408d,left: 0.11863208309424034d),

new NpgsqlTypes.NpgsqlBox(top: 0.629819038160077d,right: 0.918815409731153d,bottom: 0.08103982249068964d,left: 0.13094895491877312d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.13936842211524414d,right: 0.7964741482926156d,bottom: 0.006613125649735485d,left: 0.7213597253683585d),

new NpgsqlTypes.NpgsqlBox(top: 0.9338679382521023d,right: 0.6734053880393136d,bottom: 0.6221756565667124d,left: 0.23352235025072898d),

new NpgsqlTypes.NpgsqlBox(top: 0.6659513834987021d,right: 0.9039736046925444d,bottom: 0.14605173164045193d,left: 0.2912694594843952d),

new NpgsqlTypes.NpgsqlBox(top: 0.40459913879750486d,right: 0.12809883749464035d,bottom: 0.060325272998256185d,left: 0.00924956028606494d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5609248681816519d,right: 0.5887012545549546d,bottom: 0.5221994813444353d,left: 0.17399015227098147d),

new NpgsqlTypes.NpgsqlBox(top: 0.5124095007946429d,right: 0.7843105714768049d,bottom: 0.1029299067477839d,left: 0.1980864914267828d),

new NpgsqlTypes.NpgsqlBox(top: 0.43949313577780713d,right: 0.3567778230556241d,bottom: 0.4169034419162031d,left: 0.24746991859356815d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6827438601235678d,right: 0.6991647733415041d,bottom: 0.15762045313582773d,left: 0.4681274728715309d),

new NpgsqlTypes.NpgsqlBox(top: 0.32120251399257693d,right: 0.5873820432442013d,bottom: 0.06166796332400326d,left: 0.04968674164325626d),

new NpgsqlTypes.NpgsqlBox(top: 0.332624820381918d,right: 0.6544000219255912d,bottom: 0.10371608656331044d,left: 0.07698792633630591d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9406607993279656d,right: 0.9409608765692467d,bottom: 0.4823798337798014d,left: 0.16170707472010026d),

new NpgsqlTypes.NpgsqlBox(top: 0.6930638411023161d,right: 0.769259666289161d,bottom: 0.1305302999674408d,left: 0.5282127225324665d),

new NpgsqlTypes.NpgsqlBox(top: 0.8368116248477068d,right: 0.8915846564672468d,bottom: 0.29623412235367763d,left: 0.6894111743169256d),

new NpgsqlTypes.NpgsqlBox(top: 0.8111967231377889d,right: 0.4411710104180726d,bottom: 0.031502159365507376d,left: 0.31940747581442785d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3624695108631998d,right: 0.5844431830147192d,bottom: 0.3421540139785444d,left: 0.4530444417023761d),

new NpgsqlTypes.NpgsqlBox(top: 0.3444233391197916d,right: 0.516416075569142d,bottom: 0.2688940096796246d,left: 0.059748802355716224d),

new NpgsqlTypes.NpgsqlBox(top: 0.7716985706258003d,right: 0.9503969725157977d,bottom: 0.39054233628536206d,left: 0.4742173974914943d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1353917175979269d,right: 0.9262495297401886d,bottom: 0.07436073273282873d,left: 0.20746377554214335d),

new NpgsqlTypes.NpgsqlBox(top: 0.9053280999668978d,right: 0.2909976436254441d,bottom: 0.4260091696652981d,left: 0.2816297446758671d),

new NpgsqlTypes.NpgsqlBox(top: 0.7228646580104965d,right: 0.09490833010796385d,bottom: 0.1893367077721102d,left: 0.04037035788317245d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.32273242050325635d,right: 0.37242598607032373d,bottom: 0.27757460685889357d,left: 0.06264032612428894d),

new NpgsqlTypes.NpgsqlBox(top: 0.7767084549702393d,right: 0.5450912695129744d,bottom: 0.1943223201789337d,left: 0.436767224425472d),

new NpgsqlTypes.NpgsqlBox(top: 0.9795190912572099d,right: 0.8254653672462665d,bottom: 0.4132406216584601d,left: 0.2589932063271617d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7291827180026863d,right: 0.576981122895675d,bottom: 0.5394406974744744d,left: 0.17931227962614416d),

new NpgsqlTypes.NpgsqlBox(top: 0.5548512640643396d,right: 0.44336112766976865d,bottom: 0.45310114450517336d,left: 0.008931805277539229d),

new NpgsqlTypes.NpgsqlBox(top: 0.6398239425656441d,right: 0.7016208514526328d,bottom: 0.009496300004505631d,left: 0.5766545616969954d),

new NpgsqlTypes.NpgsqlBox(top: 0.9343362873513522d,right: 0.8863243057605644d,bottom: 0.15829777961122427d,left: 0.059240309797496504d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.46743334544146653d,right: 0.9407122933856393d,bottom: 0.3070610227562064d,left: 0.704194202589153d),

new NpgsqlTypes.NpgsqlBox(top: 0.4853908171153154d,right: 0.7999960140519002d,bottom: 0.06002225242587378d,left: 0.5082127570194706d),

new NpgsqlTypes.NpgsqlBox(top: 0.5482047262831439d,right: 0.41787930729003697d,bottom: 0.46340638229006914d,left: 0.2936839294020491d),

new NpgsqlTypes.NpgsqlBox(top: 0.2980709048123559d,right: 0.932981146124734d,bottom: 0.15945167094527302d,left: 0.5875095042308037d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7804252475231195d,right: 0.41864020384351075d,bottom: 0.20675978818486618d,left: 0.18720839634041575d),

new NpgsqlTypes.NpgsqlBox(top: 0.5447776212326518d,right: 0.8660121103531375d,bottom: 0.2978274331122672d,left: 0.6103421924417809d),

new NpgsqlTypes.NpgsqlBox(top: 0.12156870228107275d,right: 0.567971112088653d,bottom: 0.06484778624907284d,left: 0.39318555040852243d),

new NpgsqlTypes.NpgsqlBox(top: 0.9121511976835757d,right: 0.9124610166835597d,bottom: 0.10162144131641171d,left: 0.7847654934089775d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.718260118394104d,right: 0.7928675604171261d,bottom: 0.5872927131384006d,left: 0.6353789709090047d),

new NpgsqlTypes.NpgsqlBox(top: 0.7678154800759243d,right: 0.28247878432154216d,bottom: 0.0731478239553337d,left: 0.17943977575016434d),

new NpgsqlTypes.NpgsqlBox(top: 0.8138547948984238d,right: 0.6943065789516082d,bottom: 0.7636136758037163d,left: 0.43782816563112736d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7930316782402689d,right: 0.23152913519064078d,bottom: 0.5176923239934018d,left: 0.025543905827183133d),

new NpgsqlTypes.NpgsqlBox(top: 0.9549706668370426d,right: 0.6512272404772139d,bottom: 0.7848842083573535d,left: 0.23403597015581012d),

new NpgsqlTypes.NpgsqlBox(top: 0.8049007891568019d,right: 0.0839735783315606d,bottom: 0.7283818308065619d,left: 0.03845055334972802d),

new NpgsqlTypes.NpgsqlBox(top: 0.9154183068753561d,right: 0.8910643161651898d,bottom: 0.7002377236606215d,left: 0.7200276841519689d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.27574476891420074d,right: 0.8869611017244021d,bottom: 0.035852727890615776d,left: 0.471103423504055d),

new NpgsqlTypes.NpgsqlBox(top: 0.7726441693360728d,right: 0.5963752127325228d,bottom: 0.30787228860631455d,left: 0.5161788054329094d),

new NpgsqlTypes.NpgsqlBox(top: 0.8817376155667422d,right: 0.564435122884572d,bottom: 0.4179505216722781d,left: 0.5494392170697177d),

new NpgsqlTypes.NpgsqlBox(top: 0.6063805856944564d,right: 0.5863234446260054d,bottom: 0.11006157208656198d,left: 0.0754744497228036d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                List<NpgsqlBoxboxArray2M> models = null;

                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray2M> models = null;

                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 90, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 140, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 7, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 50, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 59, query1, 27, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 35, query1, 108, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 134, query1, 12, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(models[30],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray2M>();
                 ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 75, query1, 126, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 59, 34))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSTSelectModelBatch(connection, 114, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
                NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[30], false);
                NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[31], false);
                NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[32], false);
                NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[33], false);
                NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
                NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[30], false);
                NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[31], false);
                NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[32], false);
                NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[33], false);
                NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[34], false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2m m
LEFT JOIN public.binary_npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models =  ((INpgsqlBoxListboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models = await ((INpgsqlBoxListboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray2mi
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
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI), typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxArray2MI>();
                var models2 = new List<NpgsqlBoxboxArray2MI>();
                await ((INpgsqlBoxListboxArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MI>();
                var models2 = new List<NpgsqlBoxboxArray2MI>();
                ((INpgsqlBoxListboxArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxListboxArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA), typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                await ((INpgsqlBoxListboxArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray2MIWA>();
                var models2 = new List<NpgsqlBoxboxArray2MIWA>();
                ((INpgsqlBoxListboxArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

