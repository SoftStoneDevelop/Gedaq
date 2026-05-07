

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25819035817684255d, y: 0.4894454700487302d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3282028612980311d, y: 0.7790285820606376d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5561852283950167d, y: 0.17040432257387317d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07149559716067688d, y: 0.9914212533898694d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8953304454479117d, y: 0.48730542901399243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.920639005169175d, y: 0.3159861876197607d),

new NpgsqlTypes.NpgsqlPoint(x: 0.687151717591648d, y: 0.3068504404227773d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9432793209695503d, y: 0.258305593592388d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.84333557212459d, y: 0.07994295907454396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9578312616068476d, y: 0.63938701225329d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4035722936041376d, y: 0.8267926016814316d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0599505248879858d, y: 0.7221254514610268d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6067060957899203d, y: 0.1993405550389884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7106356224134707d, y: 0.03484239233616282d),

new NpgsqlTypes.NpgsqlPoint(x: 0.168978508969845d, y: 0.18544237487234605d),

new NpgsqlTypes.NpgsqlPoint(x: 0.753642694179108d, y: 0.9925641801698802d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9393520629261666d, y: 0.11686581276181751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28487938250293743d, y: 0.12752637252529608d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7603173250176285d, y: 0.38412365324735964d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7284016414725715d, y: 0.9219008686617429d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5950910528357658d, y: 0.1516059973844781d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2260125758582452d, y: 0.24498530307869626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23227395569838094d, y: 0.25924356800439374d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8142573312137518d, y: 0.2489751032195623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9712526556414542d, y: 0.493967460861246d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6384336789094364d, y: 0.9822623041106613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5150562919046056d, y: 0.8957861496539266d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5042084425176174d, y: 0.32772463188140954d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2895353186678813d, y: 0.8228183290663793d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17748022116872908d, y: 0.9044753453878422d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7677695230830359d, y: 0.7948780002116577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2943369467035717d, y: 0.4429504108999526d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04979966085649701d, y: 0.09139022870026792d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6786796380665637d, y: 0.5689972182728946d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49550674250903426d, y: 0.19774313438154967d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3465791517651834d, y: 0.6187700908024847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6897230798188009d, y: 0.9052714467243809d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47478020907040575d, y: 0.5776798819308274d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7155480050580952d, y: 0.605073560359075d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9604293242403029d, y: 0.7654059896372606d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7554638120617997d, y: 0.38880685503186596d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7123561089799728d, y: 0.8785795141858369d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6753121009820546d, y: 0.9165440914242788d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07042909499976224d, y: 0.7524294819499888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8032749516155241d, y: 0.9660517501727276d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9884133102087728d, y: 0.4836603796894252d),

new NpgsqlTypes.NpgsqlPoint(x: 0.640585243812786d, y: 0.920334949117115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16211418368575825d, y: 0.28685913735319557d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7116419571367314d, y: 0.8206035660955028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8151897226698678d, y: 0.3564481634225426d),

new NpgsqlTypes.NpgsqlPoint(x: 0.774506311100969d, y: 0.6790922091245714d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8560901234497538d, y: 0.23315934832123342d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6266160415000516d, y: 0.022412789448500336d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1421769786481999d, y: 0.04766593363269589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.044091876477381886d, y: 0.4389816463122431d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5668739783416151d, y: 0.5016157383594558d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5137215100784291d, y: 0.5593004345472385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4636406248824061d, y: 0.15929972968027306d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38223790453832807d, y: 0.5160152784410333d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9522467556551746d, y: 0.5309989493155994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9600690286868608d, y: 0.8954998776789834d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6177123107439002d, y: 0.7420702394496238d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7036590913947687d, y: 0.26009989076680484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1635290523497387d, y: 0.39075172893718113d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3523348072788366d, y: 0.9724808858973577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6535306499842397d, y: 0.7745528382746872d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04603102564133221d, y: 0.2731485774373179d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3057807564592643d, y: 0.6426913228687106d),

new NpgsqlTypes.NpgsqlPoint(x: 0.030188637507932325d, y: 0.2371974167762494d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07098502829201558d, y: 0.6737913526863204d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9639096462443437d, y: 0.7112543994205258d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9134333717095665d, y: 0.3929786457759702d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15513366522068162d, y: 0.610799822933043d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.27187889628607864d, y: 0.6866835526115195d),

new NpgsqlTypes.NpgsqlPoint(x: 0.861043644562626d, y: 0.9895698454246882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2789222289219754d, y: 0.8944964519923116d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8638322057775595d, y: 0.33996784836393257d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2155483326630353d, y: 0.26783934958043565d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7106685015576434d, y: 0.5920959201274651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5213540694248637d, y: 0.12303511105469689d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12826087441735878d, y: 0.0931751837875413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7311753204576189d, y: 0.5814217834502206d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6147208523527917d, y: 0.5299430380939054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6020295815245581d, y: 0.8780921437928053d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6271193213134675d, y: 0.2832771279930516d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6938802727252281d, y: 0.328354900795492d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37252066977863696d, y: 0.28706195908067933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36301191297291757d, y: 0.47140671529161415d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7597818421266672d, y: 0.8337163944568063d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7925947470727281d, y: 0.6450479500198281d),

new NpgsqlTypes.NpgsqlPoint(x: 0.590890844227039d, y: 0.9480858348783685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6976118778971887d, y: 0.778887489230269d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8655169969773819d, y: 0.8880516554049048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.003088007608789245d, y: 0.854152201977061d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5950714827209533d, y: 0.8459660292192724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.252371269773223d, y: 0.6336343239014935d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1512087325390844d, y: 0.5345866897005253d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08416193858532928d, y: 0.42663631955191583d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9977285592395004d, y: 0.10681529640766996d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7815678693593401d, y: 0.5852192657705163d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9611926235501863d, y: 0.5981489977320119d),

new NpgsqlTypes.NpgsqlPoint(x: 0.639905386736405d, y: 0.17499808373630654d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15945852973893793d, y: 0.1133454251718995d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6705990384234592d, y: 0.31975487112960443d),

new NpgsqlTypes.NpgsqlPoint(x: 0.985239471369998d, y: 0.1191286964303434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4576320937547321d, y: 0.2283413536214105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6087498696200472d, y: 0.8517122517123685d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2007314683800583d, y: 0.8304409938504683d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5964259046018461d, y: 0.4501501330384756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33449761462693905d, y: 0.411537208988769d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21165071420434245d, y: 0.7996879874288185d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.26444450086516436d, y: 0.6885648532256801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.052934204702380194d, y: 0.25243487412585763d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6622598530616465d, y: 0.7599327014812816d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46315865261862543d, y: 0.8497074746374519d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3583231037016815d, y: 0.10487640046493785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5595040957757936d, y: 0.20135085606687098d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3801531151490082d, y: 0.17608963519088228d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4890816647115205d, y: 0.3044265467823658d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8130377664796452d, y: 0.5974703518612277d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3514143457203709d, y: 0.17821071247168374d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24671649647398808d, y: 0.9035397298751963d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2697465390996202d, y: 0.42597487544862034d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18903093968788087d, y: 0.6381017572202811d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27487189336807505d, y: 0.23432594190050615d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16125838241502355d, y: 0.5016701794570729d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5993452066477165d, y: 0.22864580348679997d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7209524120012902d, y: 0.4821293206971068d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7543707999866968d, y: 0.0482158300783988d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2166489674022123d, y: 0.01307891908579828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6468142234688964d, y: 0.07966335089872323d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5273559452467109d, y: 0.5798597353135072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8422689636077887d, y: 0.5040878480202943d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2709834350080754d, y: 0.5465064909496709d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8672668096256233d, y: 0.06522353555885652d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4528271771473935d, y: 0.3793477421854071d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6358279347494606d, y: 0.8117116725678867d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26648616610752285d, y: 0.46297276658678366d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9745462221904281d, y: 0.21071784278048755d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3978737221534353d, y: 0.8029923869887605d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5847352498420214d, y: 0.13913512659829275d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7644016128495876d, y: 0.7588510785466298d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41129385867412027d, y: 0.14655059591018316d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2744674585683261d, y: 0.20958242036190022d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6817857454613769d, y: 0.47448300704696644d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14662661745189642d, y: 0.3267674410824599d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4060770828783883d, y: 0.10745007241911164d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29016043658117807d, y: 0.6463346382790948d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5059932408315788d, y: 0.6016181161327977d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44034512138103976d, y: 0.15955259486422935d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2773267122706934d, y: 0.2496331173092443d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6312174325022444d, y: 0.5794549027698401d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13310733619611903d, y: 0.35300105308655605d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7909967467249192d, y: 0.6378516975424772d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.062423147818766456d, y: 0.17521605251364292d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14660466227967384d, y: 0.7466132528991131d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0759229896857121d, y: 0.7337929795375431d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36805074894235357d, y: 0.39708463383527093d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16900827703372867d, y: 0.7832450283366148d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19705353114000068d, y: 0.4440185187580846d),

new NpgsqlTypes.NpgsqlPoint(x: 0.010791811586485012d, y: 0.48427236966246556d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9051751396172284d, y: 0.17118657276697424d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6769412911675595d, y: 0.3372179952893515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46380295027892116d, y: 0.14485655891299065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2605578811493985d, y: 0.8634041500373848d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28424593144611987d, y: 0.8435045104582226d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7457744138586365d, y: 0.5621562775293593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20560410973780663d, y: 0.9204719560944317d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22835232185337528d, y: 0.0666734519720591d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23621351244435185d, y: 0.2694164826121851d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36420338925855045d, y: 0.9347522872411067d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19230228522813608d, y: 0.8864414071220381d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05778570012007189d, y: 0.5878877217562937d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7651534228178125d, y: 0.9577804101813414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5463115012369817d, y: 0.749984006565054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20316106627290698d, y: 0.015293384583738967d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6415135581316109d, y: 0.006758922325626138d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8292834556695715d, y: 0.710038774739259d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9037329509842686d, y: 0.547866173797483d),

new NpgsqlTypes.NpgsqlPoint(x: 0.200696797275131d, y: 0.5109179295661309d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8080313224598714d, y: 0.9934565831023232d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8067619409232284d, y: 0.9776854423071485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2773260235430508d, y: 0.6256352054181505d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.773384685031139d, y: 0.07783531598073423d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35109671843799517d, y: 0.6368876978490402d),

new NpgsqlTypes.NpgsqlPoint(x: 0.045752380785570756d, y: 0.5706370907997497d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2657280385679053d, y: 0.2376484049585883d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17850824413748778d, y: 0.11314009922560975d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14632674778563437d, y: 0.09089452342627502d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48270106651772593d, y: 0.36419851170751305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18927861264335755d, y: 0.05541172953475526d),

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
new NpgsqlTypes.NpgsqlPoint(x: 0.2635549816491358d, y: 0.27027724853288293d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24353529061271728d, y: 0.8409161767814872d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5499219569838465d, y: 0.21092889237304524d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1522793173998066d, y: 0.4213065732872986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8516584681250713d, y: 0.10522389528938503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28412134276625256d, y: 0.2100668241732796d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8057242237772967d, y: 0.1829257113109588d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38319067157873754d, y: 0.9601873383711902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41901141826256305d, y: 0.40952706750496737d),

new NpgsqlTypes.NpgsqlPoint(x: 0.027549503943445686d, y: 0.46576481341438625d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2736379609749212d, y: 0.015554248345231336d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1265925406690216d, y: 0.09168304530002025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6704905871237968d, y: 0.7356944921486229d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7947628711345328d, y: 0.06304110623679438d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5695755340475724d, y: 0.8887322214811496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.019547189582060476d, y: 0.4542916763032233d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08271954372993395d, y: 0.41384381148235516d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8685222130728149d, y: 0.6675128451802039d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2712570364626684d, y: 0.5989067090282989d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41441968442859334d, y: 0.7984724260657035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9446316857098969d, y: 0.8295855685396847d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4336316483273477d, y: 0.5611676023831557d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7082814500841741d, y: 0.5648357427677378d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3865557029141957d, y: 0.6701333714492521d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2758784365600849d, y: 0.9466141527745171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10559844287992037d, y: 0.18165765887065255d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5604393241397628d, y: 0.22808122329606406d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17317179138779337d, y: 0.05962831085006348d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7716471912232639d, y: 0.03618582445693297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16688201204022235d, y: 0.5337242815266517d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9815776371482775d, y: 0.686937971846651d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7923720307559572d, y: 0.4771616381702656d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3464666486968019d, y: 0.293911026102319d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07756969663200775d, y: 0.7114643106319184d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4590097467764046d, y: 0.1341677686471403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22821055610980157d, y: 0.7828676669648335d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05498296329207264d, y: 0.07349212471748057d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9803248756448252d, y: 0.6122561955867394d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7605577092931994d, y: 0.387384151093503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05180517557856512d, y: 0.9350044688685413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6999354250391002d, y: 0.035649964473278395d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8027696591116348d, y: 0.9470090346349401d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3996094588966944d, y: 0.2734113172687894d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02091441802032734d, y: 0.06663323148307121d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5183994965987127d, y: 0.014298201062791671d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9356498478905901d, y: 0.9219441828826834d),

new NpgsqlTypes.NpgsqlPoint(x: 0.906472965960866d, y: 0.2567942693257256d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05188731244634748d, y: 0.6546873855208651d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6385585177888148d, y: 0.9485749927247058d),

new NpgsqlTypes.NpgsqlPoint(x: 0.045901637992197375d, y: 0.7177216105679735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9799258289561654d, y: 0.5306060559964266d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7465035669520854d, y: 0.15041577140072915d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9350587674183044d, y: 0.31164185628238117d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33235021764387696d, y: 0.6939890736414868d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46223765275372897d, y: 0.33794756551792104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08896237653263439d, y: 0.9249144297694779d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22108011303927289d, y: 0.031442255122416496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3747982321911272d, y: 0.3749542312878661d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7458618308865761d, y: 0.545184500014995d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6434973029265478d, y: 0.0687655477195721d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12866910614017424d, y: 0.13913035913515526d),

new NpgsqlTypes.NpgsqlPoint(x: 0.058573643025537026d, y: 0.719838654923229d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11143343046829712d, y: 0.9989363821526501d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8378592279952433d, y: 0.2439190037978184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4420604062896524d, y: 0.6837329446566728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6584811481034356d, y: 0.01544877670327105d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6917654118140824d, y: 0.6287662946979009d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2156792389482084d, y: 0.37698934946777696d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3307828276213275d, y: 0.5063827428894184d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07794089914989444d, y: 0.6779193889483719d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9545678741675893d, y: 0.9325330277411505d),

new NpgsqlTypes.NpgsqlPoint(x: 0.471560360819535d, y: 0.6254058411181903d),

},
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[34], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 101;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[34], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 159;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[33],_testData[34], false);
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
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 51, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 57, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[34], false);
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
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 25, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 147, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 11, query1, 159, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[34], false);
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
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 175, query1, 65, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 28, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[34], false);
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
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 73, query1, 116, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 73, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 18, 159))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[34], false);
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
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[29], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 167);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[34], false);
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

