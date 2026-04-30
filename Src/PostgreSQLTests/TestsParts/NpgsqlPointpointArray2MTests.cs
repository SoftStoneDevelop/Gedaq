

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
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3299933262510586d, y: 0.19581199513932324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8740038161192321d, y: 0.2602324316404928d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32054349296837215d, y: 0.7205505595831327d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8137620453337792d, y: 0.8236174254241271d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4102585252649087d, y: 0.7534560643825055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8540561372089142d, y: 0.8805226000999276d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3837890369428667d, y: 0.6875521566059861d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6849123040039007d, y: 0.16528795897919601d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46238356898330224d, y: 0.9498446280710702d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5033881400933227d, y: 0.6641440730926401d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8392170355762334d, y: 0.8448544306678235d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2013110440091882d, y: 0.8420502944500948d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9265744933848828d, y: 0.6553909144640069d),

new NpgsqlTypes.NpgsqlPoint(x: 0.611714174425618d, y: 0.10786456436157321d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30415155500444424d, y: 0.5548377459154685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7538420901176341d, y: 0.5030486783570748d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3959495065285429d, y: 0.7746762168369752d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26958657476384573d, y: 0.45293906610770673d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8998765446062087d, y: 0.305988391136377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7618770344543313d, y: 0.8791671160675578d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5312766020436415d, y: 0.8831026332945655d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09117604740796659d, y: 0.8430134671047801d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030881182160148013d, y: 0.6893168263545024d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11417899581043123d, y: 0.7717915945775764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5765206243459132d, y: 0.41608152718220304d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7640478658561815d, y: 0.4357184122723661d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22232808086588685d, y: 0.23359132178193176d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8549508493116432d, y: 0.542113940623495d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7680324213982335d, y: 0.6439139545093703d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.001855712780408636d, y: 0.4326704153025891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7716096181592177d, y: 0.4129280306905946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7809236752971839d, y: 0.6648084581039367d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9554031325348833d, y: 0.767144541042269d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4757096747100362d, y: 0.0295211900783946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1247366217239737d, y: 0.9466935112990172d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3417489414343081d, y: 0.7038940341311563d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18639658447637664d, y: 0.12686063054578134d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9331565588276355d, y: 0.7799206604384104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11775656079954933d, y: 0.8418035905558643d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04491114940071106d, y: 0.2871850480125737d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9278562689989927d, y: 0.5020697109223263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12714170580757211d, y: 0.3348960454975932d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3881678009741435d, y: 0.5290340918016126d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3071553476074139d, y: 0.6564309367882196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20791111063754086d, y: 0.8621050012785241d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7745798718783795d, y: 0.9008526278076491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33620990067473877d, y: 0.5749959620052197d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1668206595086401d, y: 0.6820402319966963d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15526955094432193d, y: 0.8268665556178801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5980047553052988d, y: 0.6869067515251599d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6771566285879557d, y: 0.3070308951425351d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5636671563791227d, y: 0.17198067361597968d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6960312009624431d, y: 0.32613849538659245d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30667729315270775d, y: 0.008105871406201781d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.296587844878376d, y: 0.7227115407904194d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6020444866656088d, y: 0.7923375452432916d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2396843408439865d, y: 0.5210038703112426d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14299073499623394d, y: 0.9847586187761318d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8058465584849253d, y: 0.969378749260081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1447837237482429d, y: 0.5829774892565599d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2810388389804338d, y: 0.16815393112956234d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7949099668637527d, y: 0.36585828515448504d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37051496037569953d, y: 0.21282864331299034d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9612907867677205d, y: 0.25131573635175364d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9150476494261028d, y: 0.9915807464474923d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9597118828634015d, y: 0.28723008773805603d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.045066355715357775d, y: 0.10637642653899948d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9145548637472841d, y: 0.3739629079354072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2944770838557549d, y: 0.5328004515269381d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0515923752615669d, y: 0.26540632574280343d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8389564390943546d, y: 0.5279606847489774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5062315734165975d, y: 0.476426821462403d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3358631028039192d, y: 0.2955148604225105d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6778220414482434d, y: 0.5824286746159447d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32492477043737256d, y: 0.7688227499082748d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5154217196231718d, y: 0.04208108669099131d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13168958976930212d, y: 0.8087335722716732d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7589048315199252d, y: 0.651869874297975d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8768006123485346d, y: 0.9724375995860166d),

new NpgsqlTypes.NpgsqlPoint(x: 0.030079987647083195d, y: 0.05343380087606653d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9815637564024172d, y: 0.513385016186127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26741866793456237d, y: 0.23402325823908532d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3710738872445074d, y: 0.30068798594490453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8583586022778881d, y: 0.4047460835748672d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3979759668683108d, y: 0.4682898338576551d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5561256288590193d, y: 0.4605140724825202d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08711888433485226d, y: 0.40507358306007657d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2658718236502887d, y: 0.2925048456573027d),

new NpgsqlTypes.NpgsqlPoint(x: 0.985865513568114d, y: 0.5346179544127098d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3556707238254392d, y: 0.6700423923273164d),

new NpgsqlTypes.NpgsqlPoint(x: 0.705772718759011d, y: 0.9321788898888952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2613467830398629d, y: 0.47378921524229767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8982385003328093d, y: 0.033850533135947436d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39473056845664944d, y: 0.8197339394145012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.854513242943124d, y: 0.1812814431786487d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27167547069138787d, y: 0.339309144677604d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10608850898445854d, y: 0.5079876237813036d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3237099545243364d, y: 0.20655012554636787d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3575404577444188d, y: 0.8023339755138769d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13759992964127432d, y: 0.05897837541949991d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3114030787411862d, y: 0.2287354116484328d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12808597958354317d, y: 0.15659558164221277d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10465013853125527d, y: 0.06244287187956932d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6419379018867886d, y: 0.3696144532875085d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7401344006076787d, y: 0.4040406845235709d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4933812378359187d, y: 0.9662352834810539d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7394941878491215d, y: 0.8053467323924438d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8441407493180196d, y: 0.6635377424234906d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5972857944361442d, y: 0.01550780614724645d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12924137329911434d, y: 0.08393359096585506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.847155898591356d, y: 0.2751165379463011d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5302309269123332d, y: 0.4276260602285038d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4647749040771766d, y: 0.08907043440115281d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46084664982124857d, y: 0.2500524168742433d),

new NpgsqlTypes.NpgsqlPoint(x: 0.006131525191069409d, y: 0.9919106253176697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11513520427643154d, y: 0.5008154087660169d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31559781771479134d, y: 0.033368009319601266d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7694052486453073d, y: 0.5117938820883421d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8702728851644205d, y: 0.9207806302013958d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6208220467596182d, y: 0.595158041552939d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5107965196305774d, y: 0.27248976746280285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0415381980821824d, y: 0.36597006326220993d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9459039982599247d, y: 0.5968798904988549d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05253681061432247d, y: 0.2717090147879049d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2785071007449019d, y: 0.33935295574008173d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21623241844340058d, y: 0.07053712696939096d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8000612353619544d, y: 0.6075177409624375d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9620822017334166d, y: 0.6578907916389498d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.341957639241283d, y: 0.38599635914724684d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4991778463778703d, y: 0.3629044251326491d),

new NpgsqlTypes.NpgsqlPoint(x: 0.927862062069522d, y: 0.7144472735222507d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8618784694310264d, y: 0.563468613829293d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5948874102028241d, y: 0.6675708366655707d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5072057580305863d, y: 0.9571440533604126d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15505310549772855d, y: 0.8055371361948762d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.27206969449547735d, y: 0.7247445102662599d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3755422810639205d, y: 0.5164002825711435d),

new NpgsqlTypes.NpgsqlPoint(x: 0.047270829992340224d, y: 0.3589984314557798d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6863497667664392d, y: 0.5511207385852245d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05803370359954507d, y: 0.7457807540159228d),

new NpgsqlTypes.NpgsqlPoint(x: 0.940201267826636d, y: 0.03821053923614781d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8369149430986608d, y: 0.4070904390290697d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5613166660401445d, y: 0.1714640383447693d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5326232745836746d, y: 0.40142031145458346d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5244822747400282d, y: 0.9596196528093467d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.924990906261969d, y: 0.026089053640357518d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018886299439224263d, y: 0.7174608824614416d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9444622334864814d, y: 0.6798326797580686d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4580880984465989d, y: 0.24368089414753236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9736100302725703d, y: 0.3191708969829684d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11842303267454513d, y: 0.14214883797632405d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45297820038984016d, y: 0.5723383817862169d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.021970279998378084d, y: 0.5805865673961748d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17064358489015008d, y: 0.07745429775577539d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5044703608057418d, y: 0.9950796715701894d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10515023324410211d, y: 0.875931993814562d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37505215090527255d, y: 0.48108910729975474d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8941479168604614d, y: 0.21371167434550675d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40181938144635665d, y: 0.7763615185842588d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21614203998790227d, y: 0.4090525457373888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8078102775007281d, y: 0.655000610944718d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5458807330084018d, y: 0.5262838303746187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2066483568099715d, y: 0.22861560170131678d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38293392715931085d, y: 0.8221950412854325d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24455079726342954d, y: 0.875991638046249d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9437877680739475d, y: 0.9656958106420077d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5342575151032426d, y: 0.7074189156561341d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9403193299475621d, y: 0.4181098691457372d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04983732507407734d, y: 0.4126860463021035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6754380760714694d, y: 0.7417642308786239d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4807231010805484d, y: 0.11811102263763062d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5305015080821511d, y: 0.2529143089778485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4616153377053487d, y: 0.6735877599979452d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9857186654005212d, y: 0.36531718375784705d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32969727221597667d, y: 0.7016378807797057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4675751872582604d, y: 0.8775073179572773d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3172550763430725d, y: 0.018486381443537092d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8019909134936422d, y: 0.3620143139739921d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6537775437788713d, y: 0.591150541572014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5392569255716066d, y: 0.5881049353002067d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5773176917268628d, y: 0.8295178365274676d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7026117687293589d, y: 0.21036853987148452d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7722275151909698d, y: 0.35163149149436435d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44189411226377573d, y: 0.7639443279072774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4815819889880658d, y: 0.3152160203276435d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32655695596499734d, y: 0.8428231707349458d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34352206939341956d, y: 0.5703211424183559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6910019882310541d, y: 0.09815470963032358d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6235531084291784d, y: 0.8503660277647249d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7415327247472957d, y: 0.2344091256968246d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7879412509344085d, y: 0.6445050296006117d),

new NpgsqlTypes.NpgsqlPoint(x: 0.669017829437151d, y: 0.16910951697044918d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6442420312696152d, y: 0.6642642717841748d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9399123141749887d, y: 0.08029349969280553d),

new NpgsqlTypes.NpgsqlPoint(x: 0.009218909533529884d, y: 0.7463134212346533d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7023451902837702d, y: 0.7174592076327723d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5425772881342785d, y: 0.23296062795629946d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08755346466432956d, y: 0.3044548587808499d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7465818956953449d, y: 0.7414222115198297d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3960086777929236d, y: 0.8464735104560167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5527388029073632d, y: 0.6573568531214835d),

new NpgsqlTypes.NpgsqlPoint(x: 0.999842934387452d, y: 0.7963945037113477d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2940446542842561d, y: 0.17029920567681744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7656412999296448d, y: 0.7020159337412196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5414803237754967d, y: 0.9412541504984573d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17371866897232668d, y: 0.2806414951530425d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4077280374067579d, y: 0.584547528685732d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21294360292613346d, y: 0.19346596766082247d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5474098160625998d, y: 0.4815126987026256d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3766682333381344d, y: 0.2412959528989279d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10558223010493861d, y: 0.5450751710818276d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6061429658559744d, y: 0.9212007227765802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8203811660157819d, y: 0.15178858618087288d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4130259382035818d, y: 0.16794337906983903d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43994886081380846d, y: 0.22520527807864432d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3270046634225471d, y: 0.7577887045168362d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8757253235094017d, y: 0.6320203257896446d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12280871357269929d, y: 0.8108268241910674d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19401674357814713d, y: 0.025195099004992283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09252098188446578d, y: 0.3993304652497053d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.734845147827162d, y: 0.2439983730824915d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2801044380177933d, y: 0.5500947351450011d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22796068914859147d, y: 0.8425974635653034d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9934486837745745d, y: 0.5767242294420187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5456335068642094d, y: 0.7043589703310418d),

new NpgsqlTypes.NpgsqlPoint(x: 0.01772007793633046d, y: 0.19348250614552154d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8737898184796331d, y: 0.6660845528767179d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48010599747869764d, y: 0.8327389782155917d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3462200477115237d, y: 0.9055871006528831d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6748914055708052d, y: 0.45046709943830965d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9011122789667075d, y: 0.33557046220672204d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.90537682019441d, y: 0.46633656891212627d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44664533273194695d, y: 0.7698948962694627d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7156366972380578d, y: 0.22378521517826944d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5578205400008801d, y: 0.6847264211900881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3537114880170844d, y: 0.14294493341283276d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11851195540288195d, y: 0.9750248229366751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9100257137094704d, y: 0.7120925980735645d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8312312541271762d, y: 0.14419958788157883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5865908253722111d, y: 0.8299937975252857d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6600491611304259d, y: 0.5926630439278231d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5034544227660811d, y: 0.020284429315297503d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8881804198230673d, y: 0.1856640557725303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29695490584916884d, y: 0.7046281455244499d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6307358851106714d, y: 0.4485915738080296d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.508696817049906d, y: 0.5573906009263093d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39664746133535234d, y: 0.06509921536860563d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09423069227051528d, y: 0.6848066181469193d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7865825990591799d, y: 0.6063472261130294d),

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 84;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 116;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 120, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[29], false);
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
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 62, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 28, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
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
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 16, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 116, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
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
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 45, query1, 113, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 62, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[29], false);
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
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 31, query1, 111, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 45, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 84, 120))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[29], false);
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
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 55);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[29], false);
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 0; i < 6; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInnerAsync(connection);
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

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 4; i < 10; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInner(connection);
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
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray2M>(15);

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
                ((INpgsqlPointListpointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointListpointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointListpointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

