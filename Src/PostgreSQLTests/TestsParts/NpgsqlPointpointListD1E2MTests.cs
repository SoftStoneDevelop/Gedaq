

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04638286925307811d, y: 0.7404715971143309d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26326774148699295d, y: 0.7846766827113659d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10353910595253846d, y: 0.035133915224062284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6957166818700478d, y: 0.4534390699699994d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6364604168117834d, y: 0.10294562868785273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32096813899916676d, y: 0.016080943336843512d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03399285914164507d, y: 0.1728371502175432d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3099338670178461d, y: 0.8136429135774289d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2904234793142836d, y: 0.5481525270117993d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1333812924613501d, y: 0.25180868087077923d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42699251431510776d, y: 0.9751096180405615d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06387326011395622d, y: 0.7326059562132198d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5509652043372756d, y: 0.9451655700236308d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08058809050227889d, y: 0.21962293438241842d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9900271341605743d, y: 0.501090157977121d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8885811692828995d, y: 0.7243393852783687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9820201505661803d, y: 0.25399129451415503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6689825851098387d, y: 0.7445373128770659d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20473768662456326d, y: 0.722289456827609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3369490923207047d, y: 0.9943010319924243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5566349678746166d, y: 0.8253112286028134d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47463788988932387d, y: 0.0864695414472525d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46686875695269403d, y: 0.952631801131409d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32509544454371464d, y: 0.5175592721254627d),

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
new NpgsqlTypes.NpgsqlPoint(x: 0.8707632581310067d, y: 0.05264986328183008d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13368411112339873d, y: 0.5159782657003585d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7616467073739345d, y: 0.3915958223507775d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0785925045936875d, y: 0.918437317535075d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7434583191414391d, y: 0.34286595081567406d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48175246270022887d, y: 0.650430172162015d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29649876854544377d, y: 0.6964271579772623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02197447565232069d, y: 0.3215785418629826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8397668945366144d, y: 0.6410530785246557d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5536902908195325d, y: 0.8845404300813862d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31850783279847905d, y: 0.9171275015693031d),

new NpgsqlTypes.NpgsqlPoint(x: 0.042140862312813776d, y: 0.3023198271749842d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8904405118600442d, y: 0.1547464305057642d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6507127325335766d, y: 0.5690428528246384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19148697746826515d, y: 0.5238254619214733d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2316432616367634d, y: 0.21441437970402666d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23166774746120444d, y: 0.42882145817687023d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45838234463323413d, y: 0.7882075968437595d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7066454230689531d, y: 0.8197433945562864d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9657959092226301d, y: 0.11952641491682547d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9827420136286508d, y: 0.310053820415674d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3582043062496163d, y: 0.9360170552856866d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42452415065008275d, y: 0.3241711480583638d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4938058321304968d, y: 0.8307603772168101d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15052110417738052d, y: 0.09866713706039187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8526944987180851d, y: 0.24346396151510652d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24279201408260087d, y: 0.2891902611218202d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5207190460842168d, y: 0.9433189972444815d),

new NpgsqlTypes.NpgsqlPoint(x: 0.009983552749873281d, y: 0.4147214022527532d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6086926950997193d, y: 0.9121149829572638d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19101104180191908d, y: 0.4024136787872279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.023947424882223456d, y: 0.4574179446484061d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11863216663186948d, y: 0.5234313359610068d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9391804736923431d, y: 0.6351220276372733d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5128290485634999d, y: 0.8384295497830137d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3548598229503054d, y: 0.13206246684114753d),

new NpgsqlTypes.NpgsqlPoint(x: 0.861746298252149d, y: 0.7950296305719889d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2712783375399126d, y: 0.654154244177229d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3083692288836589d, y: 0.09476726717053896d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8670996313277087d, y: 0.9375529163506703d),

new NpgsqlTypes.NpgsqlPoint(x: 0.031675067207781016d, y: 0.26765516626246155d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.566645747052003d, y: 0.8836045069154376d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9535324059854794d, y: 0.6571335599889947d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0739378626632996d, y: 0.5459710405508115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6056696542239186d, y: 0.5983469540847821d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48764003962824565d, y: 0.2882790720561603d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5033081870600123d, y: 0.9255430920544616d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8227573783354319d, y: 0.8471120363023942d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5229266188570432d, y: 0.475410633381229d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.944547796048018d, y: 0.35925549619085273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6312955933884131d, y: 0.2966362926508228d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9816418127442671d, y: 0.22799101231925822d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1567372703625851d, y: 0.8492575335387477d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32474217468590694d, y: 0.3850719641610565d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2741748396019894d, y: 0.3206310965261515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2780891219610194d, y: 0.3934130742553099d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6743644748326365d, y: 0.18116297174254237d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.34146714791934285d, y: 0.6687366588482373d),

new NpgsqlTypes.NpgsqlPoint(x: 0.015109863394483725d, y: 0.6959198355488384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9436039946117628d, y: 0.6529732656401372d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9188624628113455d, y: 0.6974050471309116d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5642705766983361d, y: 0.3291292817189714d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6952263018094325d, y: 0.31956570928227157d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2743696735741875d, y: 0.4559000750034664d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23071247247594417d, y: 0.2287848516920703d),

new NpgsqlTypes.NpgsqlPoint(x: 0.815130037217056d, y: 0.593010293855605d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5516314207317925d, y: 0.4214783341483226d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12335747186723844d, y: 0.7167238102351225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10813938752106278d, y: 0.7241307311340526d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4505992794070749d, y: 0.1645739877014295d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5023246146212701d, y: 0.19769268321676658d),

new NpgsqlTypes.NpgsqlPoint(x: 0.015353991227808339d, y: 0.6309304032281725d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9487088073276084d, y: 0.5251461463861905d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6612604579630518d, y: 0.7291379425383064d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4043554957435338d, y: 0.8537354162243594d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4050555274550154d, y: 0.30164359079129033d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29476642460734137d, y: 0.8723136099240473d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.375493284047684d, y: 0.19973500532554167d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6502994455351353d, y: 0.3744576178709509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6351602636205299d, y: 0.029664429179772855d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8469809435942078d, y: 0.695969926053609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8503476685545283d, y: 0.5636313364276608d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8165607757895729d, y: 0.9723970297576159d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9986387180576689d, y: 0.3117634098035412d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1567549345392022d, y: 0.48199709671865587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.01676769416338908d, y: 0.24834557644896904d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6577751135945589d, y: 0.6470999258762516d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7751124216380351d, y: 0.8892283523880062d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4080839675217056d, y: 0.841251483912295d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15708957846340277d, y: 0.46283944888559525d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4688817278816675d, y: 0.9978859413435687d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9642691296234895d, y: 0.7795100082050428d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8261729551624032d, y: 0.43621542410439196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05455406758143788d, y: 0.36410636535150065d),

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
new NpgsqlTypes.NpgsqlPoint(x: 0.5085909479039189d, y: 0.16167108484352888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24432984204440045d, y: 0.0319036905310065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4776938123811052d, y: 0.1102698611265246d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9461235421245708d, y: 0.7273208325645837d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7982027119358472d, y: 0.8290317932302352d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32421577339254026d, y: 0.899463206026273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6097254078895118d, y: 0.025271252734760385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9642952525174019d, y: 0.605313147401014d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9400783469345285d, y: 0.6848987567124808d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03511519145502495d, y: 0.9455053796074974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6663946689857744d, y: 0.3675305289149996d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9766454034341627d, y: 0.5437000811610666d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7413714387035979d, y: 0.639647008055713d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1008103146403514d, y: 0.39351504456098685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5669356829753077d, y: 0.0034191378569812247d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1315206858649285d, y: 0.436973948994693d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19257654562608517d, y: 0.783983365934741d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6889858158438703d, y: 0.2650648421508116d),

new NpgsqlTypes.NpgsqlPoint(x: 0.014489218090767086d, y: 0.3144968713022873d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20050732087427925d, y: 0.7202504704821211d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4258173378031165d, y: 0.7106084003139091d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28074021367957813d, y: 0.8148130039643918d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7152396430422658d, y: 0.22699265510157007d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2913316612546287d, y: 0.6280708154516996d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3624103247326287d, y: 0.3262858989050005d),

new NpgsqlTypes.NpgsqlPoint(x: 0.981015680009876d, y: 0.9791625628175378d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8831590338698837d, y: 0.3216768385294255d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6739284285306288d, y: 0.15209668345580785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8046475860826401d, y: 0.7597576309844002d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2068497808483556d, y: 0.058251942213550345d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8220281646417782d, y: 0.020047355784422516d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4219830846665885d, y: 0.2863043314734116d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8970841002643406d, y: 0.036492032498703364d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7789941732170671d, y: 0.8653067716385073d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2181586071714655d, y: 0.32648483950747187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2616286258450985d, y: 0.8658212240296376d),

new NpgsqlTypes.NpgsqlPoint(x: 0.622179152460141d, y: 0.6546230911006857d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7568839103756374d, y: 0.4971840058893303d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02785334589344768d, y: 0.08963251374886028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.070290542955037d, y: 0.4007151204861036d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1274916822255303d, y: 0.9095070508167812d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5337801531656062d, y: 0.5907746483715502d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1359183408687975d, y: 0.8933818840986174d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9702170490439034d, y: 0.7812715514892571d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7818835916453593d, y: 0.06321202769640843d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12555774254366525d, y: 0.19749386554782034d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3180657306784054d, y: 0.23579909813621847d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0021055979695003835d, y: 0.891865338822447d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5727828436110158d, y: 0.49450414528287157d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0394547953515777d, y: 0.19559800441941544d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5070502858691457d, y: 0.8316768227650239d),

new NpgsqlTypes.NpgsqlPoint(x: 0.81368489236508d, y: 0.08863619724712646d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6910203374802434d, y: 0.6246973657994176d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7035188682395851d, y: 0.7880326554272991d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4281994350915588d, y: 0.0710412381307498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8200305729095139d, y: 0.4685666074910164d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8277302816142589d, y: 0.3873016636871781d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42522651334858386d, y: 0.545137381281859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11581913458103033d, y: 0.13468330270869844d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49624533463987697d, y: 0.23056202264508519d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09336604659177683d, y: 0.9946732804186307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9146509523849622d, y: 0.7701583512412253d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6482091931672356d, y: 0.0818875293315412d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.287340369150175d, y: 0.9388375928665225d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3119093752180514d, y: 0.9850998208004192d),

new NpgsqlTypes.NpgsqlPoint(x: 0.499882142862085d, y: 0.9728710145420494d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7927118002599639d, y: 0.8323758987110106d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8889996654610095d, y: 0.8256168755037365d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6066508384451031d, y: 0.024327931838520778d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9404365201224929d, y: 0.5705513939877987d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.850821082262155d, y: 0.960497208253099d),

new NpgsqlTypes.NpgsqlPoint(x: 0.971316376136117d, y: 0.8962639321087329d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5837744603221415d, y: 0.08180888264550601d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7597638657305347d, y: 0.09529505601159849d),

new NpgsqlTypes.NpgsqlPoint(x: 0.771605123713552d, y: 0.9618990290257938d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13432274320688575d, y: 0.6818014103355519d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07223992693692916d, y: 0.3768892443532331d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7103711493865825d, y: 0.79003859119109d),

new NpgsqlTypes.NpgsqlPoint(x: 0.863085683765148d, y: 0.3646188899620946d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4941059403200837d, y: 0.034954471175395074d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6369676574994116d, y: 0.25218960160598725d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6968382778873802d, y: 0.9956770645577908d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6271359296222582d, y: 0.2942177810171803d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5894910634389741d, y: 0.9285278969157886d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9731093812908103d, y: 0.2863599100457026d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3491177097005913d, y: 0.5728328059645063d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07436974854669864d, y: 0.15979907557786088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5376838780653069d, y: 0.8719538262836388d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07097712388602206d, y: 0.32296606820573837d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38359455912680607d, y: 0.9468822192200833d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7977529525964241d, y: 0.711400370883868d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5143952581379635d, y: 0.3324837143021616d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9411074482032215d, y: 0.45214907759968914d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9191953434618982d, y: 0.47522945742186706d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7812121074483926d, y: 0.27381885187041477d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12570216596045636d, y: 0.4288039131763761d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3910482140628342d, y: 0.34120567154174286d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5800689171655447d, y: 0.8874474342909927d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3309118101807397d, y: 0.8555459944054953d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9698933748744059d, y: 0.5873053595999211d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46425781944927025d, y: 0.1631363146334064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4534360987364848d, y: 0.711712670551932d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7027613993998196d, y: 0.9836619317383148d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23566615809914482d, y: 0.6334881927914522d),

new NpgsqlTypes.NpgsqlPoint(x: 0.406115163963895d, y: 0.5648816948281574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7974453314428878d, y: 0.36646917763666365d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3516785118136444d, y: 0.8835715421686232d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1332026833211689d, y: 0.30745542003864756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3651218430681409d, y: 0.008172279889068768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8157566478479362d, y: 0.8068433418112568d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.33383200553386894d, y: 0.22138633718565282d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39690799603836d, y: 0.3880285762401563d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1466796499536991d, y: 0.9850137612922745d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17563384892499745d, y: 0.016424983393475312d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.055493829501116365d, y: 0.2996118609054712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4999874092534834d, y: 0.8652696253616868d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7857987241556288d, y: 0.06085224137278866d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22314731620833828d, y: 0.16580571127446264d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6919325164913276d, y: 0.9768644858451936d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6970835912220683d, y: 0.5749290444607638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13637353040639866d, y: 0.6712683352506508d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8996804770465602d, y: 0.9560652047429624d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3570065272902534d, y: 0.5297727468443235d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1487673379688247d, y: 0.930652700206986d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31528153624966904d, y: 0.4917883296791028d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6289876731100411d, y: 0.46860955796564574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09348130227139784d, y: 0.944807056543074d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5191008702212091d, y: 0.36894628736463797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21019612924462383d, y: 0.6643930576455251d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49188969263807525d, y: 0.6270494453210559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6424530295231692d, y: 0.48821942704124655d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9027967063092055d, y: 0.05800573019859634d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8967384830555771d, y: 0.3201603330623406d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2760020411892823d, y: 0.8434419632279627d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8813455723232716d, y: 0.08558288585880158d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21777070001392207d, y: 0.1878813156500373d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2509828454868208d, y: 0.13290632612112985d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24805086190703274d, y: 0.1411855130959364d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3102001072136321d, y: 0.771845438217317d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8696721618383603d, y: 0.25361572366009677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6220209302975048d, y: 0.13768907751270265d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7605968005321687d, y: 0.9771291986314432d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3859941274794031d, y: 0.6342164472413784d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9479073815819192d, y: 0.5623347607162621d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41201208939025924d, y: 0.2729185642476679d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7870891328213455d, y: 0.4418884230322975d),

},
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
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
                parametr1.Value = 131;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
                parametr1.Value = 53;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 59;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[34], false);
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
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 43, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
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
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 167, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
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
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 43, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
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
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 4, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 69, query1, 143, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[34], false);
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
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 122, query1, 167, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 39, query1, 138, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[34], false);
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
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 55, query1, 131, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 29, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatch(connection, 104, 97))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[34], false);
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
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 16);
                var models = await ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[3], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[4], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[5], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[6], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[7], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[8], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[9], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[10], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[11], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[12], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[13], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[14], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[15], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[16], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[17], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[18], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[19], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[20], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[21], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[22], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[23], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models =  ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[1], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[2], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[3], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[4], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[5], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[6], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[7], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[8], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[9], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[10], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[11], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[12], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[13], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[14], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[15], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[16], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[17], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[18], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[19], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[20], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[21], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[22], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[23], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[31],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[32],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[33],_testData[34], false);
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

