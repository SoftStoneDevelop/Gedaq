

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
    internal partial interface INpgsqlCircleListcircleArray
    {
    }
    
    internal partial class NpgsqlCircleListcircleArray : INpgsqlCircleListcircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray2M[] _testData = new NpgsqlCirclecircleArray2M[]
        {
            new NpgsqlCirclecircleArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25535275910749755d, y: 0.9373807138073353d), radius: 0.9645023041079605d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.013352047348818008d, y: 0.23496108711773844d), radius: 0.3710765346872076d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35291942214500505d, y: 0.21224804823949728d), radius: 0.9380977919432805d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7426275017276583d, y: 0.8430217894338082d), radius: 0.0045895356268687015d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28443015273677597d, y: 0.9933450371416678d), radius: 0.11534613657649284d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7067339613644715d, y: 0.8148405190509875d), radius: 0.834196078265388d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5616047315733197d, y: 0.027402156114334497d), radius: 0.6562890280747143d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18183201362881496d, y: 0.6820498661408709d), radius: 0.36785018977368333d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7691232559884271d, y: 0.015268656223976107d), radius: 0.505541763802207d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.004978136177510306d, y: 0.3989681830062731d), radius: 0.47085783101111867d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4147066044878426d, y: 0.44262798438162365d), radius: 0.2728894268416677d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5901359424200514d, y: 0.6400737966157791d), radius: 0.8589528654520767d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.977576359938689d, y: 0.16323654930236853d), radius: 0.9357480239343295d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4916010739944008d, y: 0.3663404465939799d), radius: 0.20219666471137676d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36446851659845014d, y: 0.8262935662388282d), radius: 0.1195549725904419d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3916657798146561d, y: 0.17241099525972126d), radius: 0.9450639692210885d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6118344781855127d, y: 0.8563354018547211d), radius: 0.4897581383899494d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8588671852804476d, y: 0.30814037990205967d), radius: 0.5361559301791806d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5742206365473935d, y: 0.9278104992989068d), radius: 0.598296990921729d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7095040014443565d, y: 0.412116551342227d), radius: 0.2717011178566934d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3433340059325718d, y: 0.8025541663340884d), radius: 0.4798537009783126d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23622186045413796d, y: 0.47067780729845854d), radius: 0.7164673071805943d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9198819577757055d, y: 0.0916265966002151d), radius: 0.45406168515804324d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9027080418721514d, y: 0.865338552526294d), radius: 0.7617912058804941d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5857899936223369d, y: 0.5213943595543516d), radius: 0.16465289674081385d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29972850519127625d, y: 0.9515686562962704d), radius: 0.2886568775687842d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24020665454706258d, y: 0.4445465597848759d), radius: 0.14070471233088067d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6812850513325602d, y: 0.4115839168297234d), radius: 0.9270068559597284d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9072975592470581d, y: 0.13774226118390176d), radius: 0.21255210388228274d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8488917470632188d, y: 0.8892295471592228d), radius: 0.18210210529478865d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.59156209911528d, y: 0.624651074528568d), radius: 0.7950740385426736d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7380045816611214d, y: 0.6967275602954255d), radius: 0.03440105687795059d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9972054486925656d, y: 0.8968176792007131d), radius: 0.07751695867003772d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13573047592445053d, y: 0.007070828692816611d), radius: 0.8451123130794439d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4594592655885076d, y: 0.9184132033624614d), radius: 0.676221187261977d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39983217779171865d, y: 0.9862524245078592d), radius: 0.039235924483409734d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09406405948179586d, y: 0.9102872476406293d), radius: 0.7019179386979096d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9701887221210097d, y: 0.21919409885743468d), radius: 0.9838363334114087d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22466496021714188d, y: 0.4011664005749571d), radius: 0.20447268253842887d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2141807800825759d, y: 0.16429416796391616d), radius: 0.20157808076094041d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7660575304896388d, y: 0.30661677965991696d), radius: 0.05520728742732661d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.825410736082617d, y: 0.37383227763053306d), radius: 0.6645221617952313d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09528666505427685d, y: 0.1615582149889574d), radius: 0.9250982427961679d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4505222241500265d, y: 0.9480235690666632d), radius: 0.29947471797690417d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6162315185091081d, y: 0.36736364623015016d), radius: 0.8358458431068805d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24412540942525385d, y: 0.6937826832785018d), radius: 0.8315964351182004d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40344919413387104d, y: 0.9691496576455382d), radius: 0.25902956878704475d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9056628020373786d, y: 0.8663091774463886d), radius: 0.6225208282559024d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4670981572424552d, y: 0.8314103387693722d), radius: 0.007490148020782517d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5954361060010608d, y: 0.32596621445130025d), radius: 0.08571392478306561d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39025562265836244d, y: 0.6946554517926338d), radius: 0.9090536416983415d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.253292841028949d, y: 0.1969961307052146d), radius: 0.6491484299400554d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19452040831815665d, y: 0.7924614080293709d), radius: 0.9333548900038651d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8511588381727013d, y: 0.19041405108200937d), radius: 0.0900257070841134d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13672401825216973d, y: 0.06987514527032856d), radius: 0.7263712929826504d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7195607750454276d, y: 0.47525997244540574d), radius: 0.41052788916447647d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12902142651742932d, y: 0.20733500800412386d), radius: 0.3025409489532396d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7390008599921597d, y: 0.5237521805509049d), radius: 0.9495667316036529d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5742366427401171d, y: 0.38181177622241724d), radius: 0.06403070711730319d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.429186527439801d, y: 0.8613468333679403d), radius: 0.265691855196841d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9886640168641374d, y: 0.925778364508194d), radius: 0.12109405507414817d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6091091996560802d, y: 0.8677998003490567d), radius: 0.6174301056562378d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.613073064922116d, y: 0.6085621532864584d), radius: 0.46044719912984433d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04169921700471546d, y: 0.32805503695405347d), radius: 0.7808011972658463d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44747012249971607d, y: 0.8331249607253572d), radius: 0.6080415661400773d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11754812787852764d, y: 0.4714576373651864d), radius: 0.01974654888979166d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6101554548125045d, y: 0.37713968222626637d), radius: 0.7220877334937338d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8414236428862858d, y: 0.4369995302302321d), radius: 0.2068359497618022d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.733106815152817d, y: 0.1224735847731051d), radius: 0.3925716435194099d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1987191551153341d, y: 0.9517660447566448d), radius: 0.4164557237933767d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.011531964554476026d, y: 0.6607792278031962d), radius: 0.39345922448494164d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8612275489584594d, y: 0.28369109040836127d), radius: 0.28326407416913757d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10753082047996887d, y: 0.695860923846223d), radius: 0.8563241826515414d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.003822080633190894d, y: 0.5666145833032441d), radius: 0.7675137261242991d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7571594791672049d, y: 0.6805552340570964d), radius: 0.8003685112410813d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9136926230623803d, y: 0.8639780750835299d), radius: 0.5917663978746357d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2764933516268625d, y: 0.7843638669956793d), radius: 0.050176919705215206d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4943213962056615d, y: 0.04656084897717516d), radius: 0.6856424116781804d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1481021945810086d, y: 0.017128827774336886d), radius: 0.1829767272025946d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33321258467391046d, y: 0.1809728577200722d), radius: 0.6177403745555932d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6848470695392483d, y: 0.7215378347653056d), radius: 0.5320908715051289d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8105594895676818d, y: 0.9561963041624595d), radius: 0.3263172983640861d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14070469813945774d, y: 0.39888440077573606d), radius: 0.2962643221676349d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5378666506286053d, y: 0.4310792963907306d), radius: 0.7036788670079327d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8962230429063089d, y: 0.9645987614582145d), radius: 0.5681682839986222d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44004875158291645d, y: 0.8465887315494423d), radius: 0.9287303507053246d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3837163454430529d, y: 0.33958464702836166d), radius: 0.2808007414774816d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7434427709081717d, y: 0.27489812476738396d), radius: 0.32957342450681526d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3099100931481089d, y: 0.252307130323996d), radius: 0.9837455119345349d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9811889993243007d, y: 0.5524369667140322d), radius: 0.004495624739204396d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7485575685962443d, y: 0.8198669508970335d), radius: 0.9303230374607785d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8209310472631907d, y: 0.9305024521450627d), radius: 0.7819576112600823d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08659946655738315d, y: 0.25229898898063396d), radius: 0.7722019736874095d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8536487691419368d, y: 0.87839267206814d), radius: 0.9991414749418998d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.769137017518408d, y: 0.5885565848189473d), radius: 0.7464626156241143d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6442601551540048d, y: 0.16279898345046828d), radius: 0.10961334085349095d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5923301553706553d, y: 0.45747835105405255d), radius: 0.70750733295711d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7464007187228455d, y: 0.6725621317274244d), radius: 0.22986431849293298d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4578549477647491d, y: 0.47609321351511114d), radius: 0.02973695691582534d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7844740494531496d, y: 0.6056397465535432d), radius: 0.6279697499349896d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15484442548973132d, y: 0.017693803084866788d), radius: 0.9411442542429664d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9218575678442533d, y: 0.3864336614756013d), radius: 0.6081126143647113d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12334765194748032d, y: 0.6964868802688801d), radius: 0.03074129549670268d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0944634546004941d, y: 0.7565638800385448d), radius: 0.5939902380323911d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5014632547928715d, y: 0.5711948938093665d), radius: 0.07977175109203871d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03633577730556092d, y: 0.7495670582449177d), radius: 0.5527072620374437d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34662246516036377d, y: 0.8881197526098759d), radius: 0.7471651419173827d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7399766510680659d, y: 0.07087950046258862d), radius: 0.5126648444159584d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10215088225984159d, y: 0.4341273565623436d), radius: 0.9885516690087283d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3800340032429267d, y: 0.6221493899547008d), radius: 0.14632255021889606d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16327914031773183d, y: 0.21523514510385455d), radius: 0.39450678441221d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42845473660678546d, y: 0.31619506295574107d), radius: 0.47661214244350625d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15830643193058558d, y: 0.5375885142920589d), radius: 0.3164899567578816d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12870112249543197d, y: 0.2631766598650943d), radius: 0.41513720243027286d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.162333414443247d, y: 0.6456412143538371d), radius: 0.9060672137465274d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5979094883631437d, y: 0.08998610153578768d), radius: 0.3366962038896286d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08117778271576248d, y: 0.4636515251326625d), radius: 0.6298900662555941d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8197588911858593d, y: 0.36904820589933796d), radius: 0.3808463589663784d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05686526021009031d, y: 0.047728282441243275d), radius: 0.7803131160893698d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8780029807280878d, y: 0.8234387728035992d), radius: 0.2434547173904541d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6627483929251317d, y: 0.17661380501636192d), radius: 0.11925651946458027d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6134876083822264d, y: 0.8379236432959636d), radius: 0.6609033598079335d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33453117291015544d, y: 0.37285098521341564d), radius: 0.12237433228723815d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7930109463955144d, y: 0.7740472927653301d), radius: 0.6867952765896692d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.031023411528692924d, y: 0.39064688176699314d), radius: 0.1825692540767806d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2914708473376195d, y: 0.014126904687100317d), radius: 0.6328554816008308d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18080373021141816d, y: 0.9622503183169829d), radius: 0.19072704322282485d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27673499268874335d, y: 0.23648506639415456d), radius: 0.3599751078303136d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30846849892779615d, y: 0.31918857234930575d), radius: 0.45005531648527086d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9524648829538284d, y: 0.8256924514811672d), radius: 0.060605850158514496d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08723783990085199d, y: 0.922128176025395d), radius: 0.20428387272401072d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.036283331762791415d, y: 0.9523890789199859d), radius: 0.8191111430604063d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02471146080232156d, y: 0.7610441449379406d), radius: 0.4076711120946429d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5819227489914756d, y: 0.1661261867090641d), radius: 0.9074385930503177d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6278979359144052d, y: 0.3216873247722294d), radius: 0.7156256430945585d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6580470043056635d, y: 0.35312673056520605d), radius: 0.10612338575106506d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7189657842972802d, y: 0.9019611287908745d), radius: 0.6392539096981348d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7696850046362494d, y: 0.6595731597379969d), radius: 0.8902119002389586d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2970144816230347d, y: 0.6867076206357642d), radius: 0.7744652615303598d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.969805411463333d, y: 0.8377100318786808d), radius: 0.3028153673310354d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.606394781020074d, y: 0.5136776929365326d), radius: 0.6183152015365918d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.884579360548223d, y: 0.8087965491550504d), radius: 0.6590484316236893d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.342545424049589d, y: 0.7148008750014334d), radius: 0.5077042733884448d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02461841148591981d, y: 0.8327047224964744d), radius: 0.328198303898246d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.907084532638213d, y: 0.8034718559434637d), radius: 0.3784962641621521d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.062641758841671d, y: 0.01751684320841118d), radius: 0.8046689653597162d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2598461876007693d, y: 0.1498816063277688d), radius: 0.027382231820807124d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36551374084174504d, y: 0.6554566633307444d), radius: 0.20211667335614836d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7170420025712756d, y: 0.1251955811686457d), radius: 0.7736891821038241d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07993147795551925d, y: 0.8786283840833442d), radius: 0.26104912348156206d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11191760032776266d, y: 0.7366839857033923d), radius: 0.5561227835919236d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.012720288131714441d, y: 0.17030332688905048d), radius: 0.6039941011212262d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1406861577060392d, y: 0.8242119468939074d), radius: 0.7298182574644868d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2173846975088114d, y: 0.3986215436577002d), radius: 0.22119809555824477d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12905544117295997d, y: 0.6547224620973942d), radius: 0.6553900850891751d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6644083188157799d, y: 0.7507381037855068d), radius: 0.8241852317847063d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6296121830950349d, y: 0.7950449835077521d), radius: 0.5565528169344556d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11668002194766613d, y: 0.7429926710735419d), radius: 0.22472152153017877d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09629830878512446d, y: 0.7262087996480643d), radius: 0.34047095045323883d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9328589602515155d, y: 0.7108035366387777d), radius: 0.6648790968401156d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5658622882157154d, y: 0.14193655066192445d), radius: 0.5700721398210146d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.030904148094230255d, y: 0.7342171940242018d), radius: 0.04324492736253005d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8183442220374261d, y: 0.2962299323630666d), radius: 0.6817814379827928d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47137714984081147d, y: 0.7090835231172423d), radius: 0.0729580876102448d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5893137021670164d, y: 0.07841457828972365d), radius: 0.17211054561702388d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.452240149447084d, y: 0.8690356260560506d), radius: 0.9801823474353896d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1320843839969561d, y: 0.010359911254275933d), radius: 0.16113702624165593d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5980219603935458d, y: 0.6217441162916291d), radius: 0.6281753209078645d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07579233238785277d, y: 0.28048203871796296d), radius: 0.9095622864590003d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6146634896072513d, y: 0.40399147898807264d), radius: 0.9762750793343682d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9998836911988249d, y: 0.5283333072167817d), radius: 0.34938468055232297d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5976425204902284d, y: 0.3600628462116353d), radius: 0.07025512194214589d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6732724298199972d, y: 0.15658486356477985d), radius: 0.7094697842632882d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8031946105986428d, y: 0.38184318940861517d), radius: 0.4461508440332247d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6463288673180867d, y: 0.6101575307941872d), radius: 0.8294132913309138d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.820838794958241d, y: 0.8311756460489294d), radius: 0.7762975341591255d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7302309499016575d, y: 0.6712055387317796d), radius: 0.09701627566158944d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9311829316726314d, y: 0.016995265523176206d), radius: 0.000997504697289875d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9518657847231828d, y: 0.43257931560942475d), radius: 0.7384252122540569d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42409710415617896d, y: 0.7965367915947095d), radius: 0.365392565422458d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2375345230403778d, y: 0.6225727450492999d), radius: 0.7776383672402208d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36448256699839243d, y: 0.5533478892244642d), radius: 0.7997703073620184d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7351099682318413d, y: 0.5827021606822926d), radius: 0.19206527713598665d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5281017562296836d, y: 0.43059301431427266d), radius: 0.5722304879234591d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8150201639656336d, y: 0.3446490494437723d), radius: 0.20362887785098527d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11553426745410311d, y: 0.8833958294912071d), radius: 0.04463144610212777d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7872509682562909d, y: 0.2491320354364681d), radius: 0.7396962461216605d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6146439987224409d, y: 0.2670092730298569d), radius: 0.8298833001853992d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15895639570936337d, y: 0.12690649284840583d), radius: 0.21486073956197582d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3825508576253607d, y: 0.8524579358424589d), radius: 0.09819450422143094d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5587427074206165d, y: 0.3741408761073117d), radius: 0.3868402185040758d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.534828695549538d, y: 0.8896527739420826d), radius: 0.9632385842349893d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3901705887420964d, y: 0.04488178099076323d), radius: 0.9413123630978293d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07634024304265408d, y: 0.9126877394383468d), radius: 0.7860591699361416d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9427707914388361d, y: 0.45090470070583166d), radius: 0.6483484704489456d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07563075514362816d, y: 0.24774167926079693d), radius: 0.9775104106518325d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.377356578913263d, y: 0.6858833857165727d), radius: 0.32416967670563035d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5650957526133523d, y: 0.7488138172343884d), radius: 0.5992894234198438d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7454922460860057d, y: 0.7856860830736669d), radius: 0.20072548604179197d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3041379476419743d, y: 0.3167557646152467d), radius: 0.3069757822195105d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3404588013084646d, y: 0.950335123044117d), radius: 0.26153023411634724d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1175525389112152d, y: 0.7610954398492067d), radius: 0.6383886749458556d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8755798179052009d, y: 0.15976789479597897d), radius: 0.6437570070403145d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5048257764682611d, y: 0.2100290865531803d), radius: 0.5983461773716199d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.618089490421976d, y: 0.3378861530278191d), radius: 0.941540060418772d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2950936377312273d, y: 0.4615504562719084d), radius: 0.962359207095265d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2922924087681926d, y: 0.12123285400053341d), radius: 0.12852622934390245d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.015353886140964113d, y: 0.5325254469696648d), radius: 0.11431520130674311d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6374585960907997d, y: 0.2816004946714846d), radius: 0.2393265010403317d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9280054601372673d, y: 0.07596102486848832d), radius: 0.5572202364628118d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025724988191174636d, y: 0.026234438279026162d), radius: 0.37856951565825403d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3042154659272198d, y: 0.48319913008978876d), radius: 0.29231545313251617d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44472379889695135d, y: 0.7742637863817421d), radius: 0.6755298992888371d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2791199695708395d, y: 0.6370259509466274d), radius: 0.9310475191999498d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29571721805577744d, y: 0.3273512493742532d), radius: 0.47477162213597823d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4146794920270025d, y: 0.9935508298657943d), radius: 0.7392236940669032d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7524763368362106d, y: 0.04247875751148922d), radius: 0.4772844318934678d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7790109191618148d, y: 0.9444003658563255d), radius: 0.4472532722343411d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6466383969122314d, y: 0.5757879658953685d), radius: 0.5229537620644424d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9770911005610855d, y: 0.5559647961992165d), radius: 0.2593094653711828d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8931626724319808d, y: 0.4731735508483106d), radius: 0.624584745159064d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5164506809023813d, y: 0.16712767399157935d), radius: 0.08214366960545183d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2292270861954041d, y: 0.5459118934273126d), radius: 0.9967900858351215d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08939102413379285d, y: 0.4858053558967822d), radius: 0.7218218761423394d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.046461454827551374d, y: 0.1575435997249781d), radius: 0.7582391111994096d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6061038039804508d, y: 0.08474288593056145d), radius: 0.3006659495951707d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7733677724978304d, y: 0.9185106388239568d), radius: 0.9066660944318699d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9431352571923275d, y: 0.38722003907177427d), radius: 0.7163400067611865d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9935682633143207d, y: 0.4487046647432378d), radius: 0.8594777511991083d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09765509419095864d, y: 0.43633869269323433d), radius: 0.37893171732894027d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5353947159642325d, y: 0.1260989321939502d), radius: 0.22667225614354014d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5017966515096249d, y: 0.1647264356108581d), radius: 0.5911541682661823d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3919344753564653d, y: 0.825177321638824d), radius: 0.7632928395625764d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44329807704366586d, y: 0.5015325934034842d), radius: 0.6151003292856991d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8084947797735977d, y: 0.8967434577968492d), radius: 0.921415673219433d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7839935526969023d, y: 0.9849566192698744d), radius: 0.23155254332801d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9732947614833498d, y: 0.3185619138232707d), radius: 0.29080688854138526d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3121464726934371d, y: 0.583369047960906d), radius: 0.11608937828534949d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23225803585905436d, y: 0.08362629287933343d), radius: 0.42268374198205205d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7728810590855565d, y: 0.8491955530240819d), radius: 0.7282193736150585d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20694521363927354d, y: 0.5040916332470359d), radius: 0.4005431795559996d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9528673490502293d, y: 0.5728670975014614d), radius: 0.036845861534077096d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6697919017979922d, y: 0.2184970183772359d), radius: 0.016582104097204953d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9065186604518956d, y: 0.5963551920918515d), radius: 0.30748949312097085d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9468068118414208d, y: 0.9072875567740625d), radius: 0.6294400959137464d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9091345277193641d, y: 0.16692172357528157d), radius: 0.43408797852834746d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7421876671356679d, y: 0.20371535163700627d), radius: 0.03365255082500451d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6725498242178976d, y: 0.011412429445081917d), radius: 0.3181282922776304d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0016256161065022479d, y: 0.46516535383518465d), radius: 0.4911960991997719d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10715673468863418d, y: 0.3872895112984608d), radius: 0.8610331366165278d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9787523526837945d, y: 0.8164189688201959d), radius: 0.565290545062891d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9713747366850903d, y: 0.6610618991384635d), radius: 0.29516500240636356d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9710679267642759d, y: 0.7558860747617994d), radius: 0.16242937186492146d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20631012540996796d, y: 0.35196480621653137d), radius: 0.28822326241387486d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.889038295109468d, y: 0.8237535905792462d), radius: 0.9852226759448656d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15267862357920237d, y: 0.31689721283835215d), radius: 0.11489436324199154d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8963470572451956d, y: 0.4208550413872295d), radius: 0.32079081289726485d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7976454274363144d, y: 0.5342752430415291d), radius: 0.9598072128256512d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31930526983249496d, y: 0.30147353631147067d), radius: 0.8107627875798586d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2206105279364562d, y: 0.2749136692305051d), radius: 0.5952402533816376d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5724115632869308d, y: 0.8637345370927066d), radius: 0.5651572749175562d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42607354010183096d, y: 0.6389495117235412d), radius: 0.08328924912285796d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7596853070582217d, y: 0.9882759488949021d), radius: 0.9159037871511592d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4407049261097008d, y: 0.5436068729001973d), radius: 0.9316335273798948d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49105033934255915d, y: 0.26549654800298916d), radius: 0.49024806709233004d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9817377013517877d, y: 0.697193048930709d), radius: 0.5137915859812128d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36372547705966285d, y: 0.24985354048080322d), radius: 0.13848777187937544d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34643770967756693d, y: 0.10466908685228005d), radius: 0.5402318525880025d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5441054392187089d, y: 0.6765145190906505d), radius: 0.027615110735432102d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4630288317730721d, y: 0.2923007126612407d), radius: 0.17514817272512606d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7401156959144495d, y: 0.021897103370896898d), radius: 0.4685477804644974d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19246427000421784d, y: 0.10452187763807996d), radius: 0.2922537809264022d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32365300346297277d, y: 0.753903176301918d), radius: 0.49682429157130803d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5338743283532892d, y: 0.7536088963598602d), radius: 0.49409388797051923d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                List<NpgsqlCirclecircleArray2M> models = null;

                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray2M> models = null;

                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleListcircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 51;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 15, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 71, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 73, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 55, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 150, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 74, query1, 128, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 45, query1, 128, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 36, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 45, 93))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatch(connection, 21, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 82);
                var models = await ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[15], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[29], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[30], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[31], false);NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[32], false);NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[33], false);NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models =  ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[29], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[30], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[31], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[32], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[33], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray2m m
LEFT JOIN public.binary_npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleListcircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI), typeof(NpgsqlCirclecircleArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleArray2MI>();
                var models2 = new List<NpgsqlCirclecircleArray2MI>();
                await ((INpgsqlCircleListcircleArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MI>();
                var models2 = new List<NpgsqlCirclecircleArray2MI>();
                ((INpgsqlCircleListcircleArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleListcircleArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

