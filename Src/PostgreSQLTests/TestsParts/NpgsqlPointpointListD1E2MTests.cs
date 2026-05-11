

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
    internal partial interface INpgsqlPointListpointListD1
    {
    }
    
    internal partial class NpgsqlPointListpointListD1 : INpgsqlPointListpointListD1
    {


#region TestData

        private readonly NpgsqlPointpointListD1E2M[] _testData = new NpgsqlPointpointListD1E2M[]
        {
            new NpgsqlPointpointListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9118200213316945d, y: 0.6608140664435425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6651216815950988d, y: 0.9242782647798861d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18349514978727954d, y: 0.6236803667956494d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19510566847043986d, y: 0.06969346363670958d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7696259310933079d, y: 0.17672896937353333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.861633013013929d, y: 0.47564511775643814d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9936145490932752d, y: 0.1628175237391799d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6044123604634776d, y: 0.13249506869089d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9730008518743117d, y: 0.04488335020853784d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6884038084571035d, y: 0.45619329858261315d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33351885006020365d, y: 0.4866781102097264d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3275826068067881d, y: 0.5101060166349211d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9948886336195516d, y: 0.07534799777000512d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8317016630823579d, y: 0.29619976783792057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3817546222995769d, y: 0.6755514701470141d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30625997133018756d, y: 0.5578888983393812d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4302368518212739d, y: 0.6961572113404548d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7585011201818345d, y: 0.5904404890241245d),

new NpgsqlTypes.NpgsqlPoint(x: 0.048331159197223195d, y: 0.13169921968172071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8607200621940233d, y: 0.39036139316784435d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8481309616249383d, y: 0.4219788313305898d),

new NpgsqlTypes.NpgsqlPoint(x: 0.036544338851889124d, y: 0.7551826707094d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9814888003506339d, y: 0.751951827399232d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17897273865241337d, y: 0.8804916535924225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12202019515615292d, y: 0.13986252585575198d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13741778486882417d, y: 0.9018518066193744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0010901965902120336d, y: 0.7610477590808642d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38153726936818466d, y: 0.383466457270757d),

new NpgsqlTypes.NpgsqlPoint(x: 0.364724376987556d, y: 0.3340633787928168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12621451030264685d, y: 0.47156113126219257d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42462627328988733d, y: 0.9031688041997878d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2631252022558398d, y: 0.8354382676269533d),

new NpgsqlTypes.NpgsqlPoint(x: 0.681248569806811d, y: 0.8824383315739558d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.772287980039057d, y: 0.07826943441699497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3850616323489321d, y: 0.2391124793514532d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8330344343879225d, y: 0.7883153041651578d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44368121099536495d, y: 0.6639326295119208d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5085152465528207d, y: 0.03179607934499695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4671090350425442d, y: 0.7903939895177703d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6095596995185143d, y: 0.2016723749457865d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6691745468868717d, y: 0.17283697597101289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8057915628000974d, y: 0.31377358596509675d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3122776785449597d, y: 0.5305197521167782d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15863955199221325d, y: 0.4642824207367614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6731474846149258d, y: 0.829601952457865d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09818151538643427d, y: 0.013484984923895715d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3142866858511365d, y: 0.4854529047507904d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9294465760065631d, y: 0.9119130777794748d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6571347474874144d, y: 0.44464900557685794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.807746595043056d, y: 0.7509911056342856d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08009029469294893d, y: 0.04584154701247434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9209984478892627d, y: 0.13512817023516988d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06261641235086213d, y: 0.293597226358827d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9653368556370345d, y: 0.6819931483110777d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5633891907739413d, y: 0.08786393277113891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5804123029407627d, y: 0.8387180005764581d),

new NpgsqlTypes.NpgsqlPoint(x: 0.695240746854903d, y: 0.036780621292390125d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05124937491327186d, y: 0.20836754963967352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5904135871442443d, y: 0.08345963865234107d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5142758519775248d, y: 0.5283039367719544d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5054708198358909d, y: 0.508572485271309d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29986662124007113d, y: 0.9033308244638125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9592868310859821d, y: 0.9438921397225295d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7004254173927145d, y: 0.09764925566597149d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24065311339735407d, y: 0.6800778907217117d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9227923810550756d, y: 0.454983674461229d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2522360931820782d, y: 0.4827159834643461d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16449966360765134d, y: 0.3317808981226248d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4410353647451779d, y: 0.6209889955864376d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9690339428059788d, y: 0.34916733583852155d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8973986058158997d, y: 0.9970007791547354d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25575323118466753d, y: 0.05116949106532631d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17696349605626172d, y: 0.6888231344739156d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7090734744100959d, y: 0.606638968871196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27199748450108785d, y: 0.09593827258192777d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3785704353940694d, y: 0.16862547229596936d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7684243192422333d, y: 0.8855105938164384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.022200262968993245d, y: 0.3333708545304095d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04158997084752425d, y: 0.8796806339659252d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5718875527792964d, y: 0.015223238267328076d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14291998483812385d, y: 0.6996684797900601d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5616401407434757d, y: 0.3426016175474076d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6010099819397313d, y: 0.5134180691127435d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8536494447492349d, y: 0.5703174084141033d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5125546158852996d, y: 0.29579333873484914d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.431747796792594d, y: 0.5621067914463149d),

new NpgsqlTypes.NpgsqlPoint(x: 0.010481367743683911d, y: 0.4510897884476641d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2897392021500158d, y: 0.4745953139808201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7611985335285093d, y: 0.9059123528500919d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9618698260022276d, y: 0.7290769259282409d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32699790491129666d, y: 0.517601818298313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4500034890955863d, y: 0.317211631326238d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.00871252490003449d, y: 0.27672008385594493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7251017046874051d, y: 0.9942634017370349d),

new NpgsqlTypes.NpgsqlPoint(x: 0.019626496051746267d, y: 0.6582226339406557d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46926217453213115d, y: 0.3811053988295865d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35192696128918743d, y: 0.369914989033304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3654932027306017d, y: 0.6643396501393795d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34537769798489226d, y: 0.7665731459169491d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09028883741123317d, y: 0.369145209694542d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5753257989131524d, y: 0.7983815776759391d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04378214994016605d, y: 0.9980006445005396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6093594960830622d, y: 0.15038089580798653d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.054820152205938166d, y: 0.2660004493605578d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8098166924523409d, y: 0.191608139056064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15725047663860237d, y: 0.6433610072318561d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7803812491380622d, y: 0.6273446061988849d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8157797780484237d, y: 0.742066603207796d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45259596767173527d, y: 0.33441433976229407d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5084846852264634d, y: 0.8364880465035331d),

new NpgsqlTypes.NpgsqlPoint(x: 0.791349172516871d, y: 0.24232082582649594d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08746450942533401d, y: 0.44904596694659593d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14997378421465557d, y: 0.8242040408209593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27983445059849055d, y: 0.4280722809838723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.688175956945904d, y: 0.05370199914326701d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6090044576121976d, y: 0.805430430201788d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5140344929697171d, y: 0.9125137267359198d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5739713796101144d, y: 0.9370878061047214d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0807887246012381d, y: 0.5415784111740233d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4173348709272716d, y: 0.7544481868490894d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2173792409154015d, y: 0.28709059148255234d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9291911643692494d, y: 0.8963395131125476d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7938160410684887d, y: 0.21273541991482292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08833991758697146d, y: 0.27655708983411587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02349460379367685d, y: 0.11659143676610928d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5283938531847135d, y: 0.1238993497589419d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7033970653681796d, y: 0.01286960578420604d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6258650513480314d, y: 0.19232741819374444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45024045072879604d, y: 0.19904924193111018d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26811654030057097d, y: 0.4750426784371917d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08681853515560356d, y: 0.18462121030969092d),

new NpgsqlTypes.NpgsqlPoint(x: 0.497021990780823d, y: 0.007470615289742799d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25154423588312125d, y: 0.8292993618979578d),

new NpgsqlTypes.NpgsqlPoint(x: 0.402646539274499d, y: 0.10653802535623247d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8902435659751599d, y: 0.3825060184707154d),

new NpgsqlTypes.NpgsqlPoint(x: 0.737791242561082d, y: 0.6549598082074244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9770045778762637d, y: 0.8535351623289853d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5614363290462097d, y: 0.9763285553413429d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8064739993829977d, y: 0.35393259826570134d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4133893012271944d, y: 0.33944262930062863d),

new NpgsqlTypes.NpgsqlPoint(x: 0.010623830109314336d, y: 0.8156098127207201d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8213124961130481d, y: 0.057807966008404654d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6699989276774638d, y: 0.09593608646933727d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8126855211010361d, y: 0.662036009519532d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8379342556975369d, y: 0.15654557146451353d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4286462442889193d, y: 0.6504393770014087d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08700666959228587d, y: 0.40049115051823747d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4719941515362883d, y: 0.6718973617617056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5066286120483563d, y: 0.5674360730322899d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5526862020331057d, y: 0.31899550523593445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.766919220752442d, y: 0.0761932010635572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8794834885873157d, y: 0.3407218928365552d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9488270952928634d, y: 0.8687218949753555d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9945857292405615d, y: 0.13170241913208014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.863520271506505d, y: 0.4726199196317621d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5639746378966095d, y: 0.7334821927832629d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31512436425762524d, y: 0.45889269288435475d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4576984211384274d, y: 0.5451807432593786d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4242028277921086d, y: 0.5227172261537053d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32829189930309777d, y: 0.4548569431082784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6301794918861667d, y: 0.897682366382543d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09502504784418242d, y: 0.969116359453096d),

new NpgsqlTypes.NpgsqlPoint(x: 0.932737522578041d, y: 0.3225811645738931d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1753788767319292d, y: 0.12165497070376441d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5917494537053151d, y: 0.04670598657989067d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8625594230096472d, y: 0.49265596216596264d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18004510230933057d, y: 0.13195677195705913d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1302708403286964d, y: 0.8717589548174779d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5598982679930471d, y: 0.0564041542212842d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4988851893000993d, y: 0.9818182464568007d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7449597182880225d, y: 0.028003869718216334d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4772486020008181d, y: 0.0498527112438093d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8040435115658118d, y: 0.6697300726559685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07447501987924388d, y: 0.0249229524728678d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06063229704236606d, y: 0.4545922862303746d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29572842256433474d, y: 0.783151572247319d),

new NpgsqlTypes.NpgsqlPoint(x: 0.023178849890773345d, y: 0.17891959461300022d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42066288152952125d, y: 0.45579780361963107d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18040805268600812d, y: 0.38800327587211114d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5396506614630421d, y: 0.06083353525046575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7932401408654016d, y: 0.6154728936499243d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.516274382174781d, y: 0.43601752774538993d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0762876618482321d, y: 0.39442687475045135d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8239013076311912d, y: 0.25316141036462203d),

new NpgsqlTypes.NpgsqlPoint(x: 0.056354772402107844d, y: 0.45870023223304035d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8107851624988894d, y: 0.990233715778282d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23258119455867654d, y: 0.8722436095167944d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09822341335300866d, y: 0.012993866377669416d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47113232977032915d, y: 0.7317365755206228d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0771677570146595d, y: 0.6518053676866001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12064163391722182d, y: 0.5365394409813898d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9814500686788874d, y: 0.49522972351759265d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4411215808550478d, y: 0.36497449481609645d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5754873324722819d, y: 0.3510957384089707d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27006014327674743d, y: 0.6263349278510294d),

new NpgsqlTypes.NpgsqlPoint(x: 0.567612140369892d, y: 0.8040349391102883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6591447178237506d, y: 0.6915468930238048d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6494718926671816d, y: 0.9234981943541094d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31255438072920516d, y: 0.891994119872644d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9389151385809511d, y: 0.6225715195397079d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9853604048778669d, y: 0.9711289272567023d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1975052027446892d, y: 0.5695883337640045d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8412529649585226d, y: 0.1191253598884654d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7155878106277385d, y: 0.21795836464196394d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9288894718023598d, y: 0.3040889656573914d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47789768803264454d, y: 0.8336419479259621d),

new NpgsqlTypes.NpgsqlPoint(x: 0.806293994508678d, y: 0.9659459819554853d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6948275602088333d, y: 0.07509024827677224d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5961456970763489d, y: 0.7439930419538912d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19095621025745246d, y: 0.6174724583208284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.698607735857661d, y: 0.45066893719457257d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1271813594426251d, y: 0.21818722573699822d),

new NpgsqlTypes.NpgsqlPoint(x: 0.822242395037043d, y: 0.7191530014942584d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6737429064393042d, y: 0.05938123791540606d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9373434320482228d, y: 0.049103192113263416d),

new NpgsqlTypes.NpgsqlPoint(x: 0.608402607407704d, y: 0.6173741004335572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36558662149577037d, y: 0.5363726247621639d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32180312450792925d, y: 0.8286339699542302d),

new NpgsqlTypes.NpgsqlPoint(x: 0.534741216272993d, y: 0.6863226413071856d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9357560319702104d, y: 0.3879304045520562d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8333909474876688d, y: 0.8629224232939274d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4797452591133343d, y: 0.5172322635522754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13626092596794548d, y: 0.8366146969658056d),

new NpgsqlTypes.NpgsqlPoint(x: 0.013469554942356798d, y: 0.39451119364016174d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03513623908052421d, y: 0.19012923779398505d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5375919597960287d, y: 0.5668458168147633d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12191213475058449d, y: 0.8283849676406677d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9764977997825525d, y: 0.3639771201448335d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8158487677068087d, y: 0.08644525846376261d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3281418101068775d, y: 0.5909471466646324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23998554931188365d, y: 0.11479733630201083d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20792214236638462d, y: 0.45395724148667216d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7847181886596751d, y: 0.2463029279611847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3213942549919424d, y: 0.4946764330987531d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6056330259920301d, y: 0.7716132910351018d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6880949881506785d, y: 0.878669089122785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19555864796179379d, y: 0.9329744530011976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8204785380519413d, y: 0.6033218353981109d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4994115176321887d, y: 0.29778271978366255d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4113610075871059d, y: 0.20679251435992207d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9730011100901547d, y: 0.9642052718509062d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7126486738429649d, y: 0.539195259851241d),

new NpgsqlTypes.NpgsqlPoint(x: 0.466725818468228d, y: 0.7944362301380526d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7638460274002971d, y: 0.6326009316788488d),

new NpgsqlTypes.NpgsqlPoint(x: 0.762728013030598d, y: 0.2271833454689941d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7401405863289257d, y: 0.806271927181048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5116554519194447d, y: 0.3905781657813441d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20652001660365438d, y: 0.06974257645944804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6103896739594589d, y: 0.29862378444639437d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23116811124380254d, y: 0.38174534340781685d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9544066486306856d, y: 0.6655132651756349d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8245122272295531d, y: 0.9283257911447833d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14191653232385937d, y: 0.4171431358907637d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2753788520924747d, y: 0.31373857238753533d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06823417438607471d, y: 0.7826129581221883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0035029567481117407d, y: 0.30980380597504253d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43843130497155214d, y: 0.9663012751119199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6420007154273305d, y: 0.051161021541004326d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10538044906366162d, y: 0.34248650467477304d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6462571146936835d, y: 0.673563937846007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1229823481458866d, y: 0.9171041108397582d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021064795213678544d, y: 0.6298336931001358d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.510342737486518d, y: 0.5466733793812824d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30129966176725065d, y: 0.7264001556824556d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24254564235291165d, y: 0.8169051089006275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8388877905280263d, y: 0.29113248990825213d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40653753831661665d, y: 0.17843185233866077d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5850710239596969d, y: 0.9494854706696025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2369767706605761d, y: 0.043019382707521925d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3817731423525016d, y: 0.6137403297056764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6359095917360513d, y: 0.09799947794925445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30625541737606443d, y: 0.3612203909633608d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.008816097518149268d, y: 0.9705185537837357d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6324912340965301d, y: 0.21652357279292866d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9097547499189682d, y: 0.08870002857942594d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45864875141211714d, y: 0.4601795458774639d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8531641310013695d, y: 0.9599805771623299d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06262647164534652d, y: 0.9452038156806674d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021007854619038646d, y: 0.4957414814693243d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11117650669819179d, y: 0.975604544376217d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25268648936028926d, y: 0.1477271689309848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4388530834002715d, y: 0.6426071658559409d),

new NpgsqlTypes.NpgsqlPoint(x: 0.898677177012069d, y: 0.5089502998998436d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06404837237974048d, y: 0.9486795932542957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6559869180926811d, y: 0.922373520135524d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4118901313791603d, y: 0.6591533356709927d),

new NpgsqlTypes.NpgsqlPoint(x: 0.017664896364228744d, y: 0.5766862059174993d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
INSERT INTO public.npgsqlpointpointlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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

                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)), 
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
                methodParametrName: "npgsqlpointpointlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                methodParametrName: "npgsqlpointpointlistd1e2mi_id", 
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
                List<NpgsqlPointpointListD1E2M> models = null;

                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointListD1E2M> models = null;

                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 11;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 142;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[34], false);
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
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 29, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 89, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 102, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 93, query1, 149, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 84, query1, 27, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 113, query1, 13, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 65, query1, 69, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 122, query1, 65, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 40, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[34], false);
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
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatch(connection, 65, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 78);
                var models = await ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[17], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[18], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[19], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[20], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[21], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[22], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[23], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models =  ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[20], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[21], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[22], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[23], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[34], false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MI),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointListD1E2M),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
FROM public.binary_npgsqlpointpointlistd1e2m m
LEFT JOIN public.binary_npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models =  ((INpgsqlPointListpointListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI), typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models1 = new List<NpgsqlPointpointListD1E2MI>();
                var models2 = new List<NpgsqlPointpointListD1E2MI>();
                await ((INpgsqlPointListpointListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MI>();
                var models2 = new List<NpgsqlPointpointListD1E2MI>();
                ((INpgsqlPointListpointListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models = await ((INpgsqlPointListpointListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

