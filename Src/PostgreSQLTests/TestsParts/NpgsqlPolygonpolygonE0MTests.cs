

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
    internal partial interface INpgsqlPolygonSingleTypepolygon
    {
    }
    
    internal partial class NpgsqlPolygonSingleTypepolygon : INpgsqlPolygonSingleTypepolygon
    {


#region TestData

        private readonly NpgsqlPolygonpolygonE0M[] _testData = new NpgsqlPolygonpolygonE0M[]
        {
            new NpgsqlPolygonpolygonE0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9109167822590589d, y: 0.6379943455472734d), new NpgsqlTypes.NpgsqlPoint(x: 0.22791767104696603d, y: 0.14413113186820015d), new NpgsqlTypes.NpgsqlPoint(x: 0.0012857373103637437d, y: 0.5422811924311735d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4782298610434843d, y: 0.2663295177917685d), new NpgsqlTypes.NpgsqlPoint(x: 0.26511868018934326d, y: 0.03250992017478038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5051370979539542d, y: 0.7442289827637926d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9889097814382325d, y: 0.6948057845811519d), new NpgsqlTypes.NpgsqlPoint(x: 0.8880916711280509d, y: 0.7502357326917123d), new NpgsqlTypes.NpgsqlPoint(x: 0.04800313823181801d, y: 0.10806934098078802d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29429382873158627d, y: 0.0338882567079557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077982675185806d, y: 0.24018093911399163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7270370896702113d, y: 0.820132395114726d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9373208824757985d, y: 0.7374949340071767d), new NpgsqlTypes.NpgsqlPoint(x: 0.3332479951842727d, y: 0.22502053651421272d), new NpgsqlTypes.NpgsqlPoint(x: 0.30735335918629225d, y: 0.7230354275716165d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6848225403036495d, y: 0.6280836260101814d), new NpgsqlTypes.NpgsqlPoint(x: 0.3887296005911751d, y: 0.03389318842465905d), new NpgsqlTypes.NpgsqlPoint(x: 0.4795671218912334d, y: 0.6075265104609865d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4273869601521961d, y: 0.9087859852422303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428306492566859d, y: 0.09929615675303571d), new NpgsqlTypes.NpgsqlPoint(x: 0.7675138916148619d, y: 0.32393151276967236d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6361024050574287d, y: 0.8100818043206333d), new NpgsqlTypes.NpgsqlPoint(x: 0.2936946902714114d, y: 0.46674209513450915d), new NpgsqlTypes.NpgsqlPoint(x: 0.5369548406776432d, y: 0.6375584869283379d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1748278891570152d, y: 0.0848929368501018d), new NpgsqlTypes.NpgsqlPoint(x: 0.827623777596489d, y: 0.35921434322157697d), new NpgsqlTypes.NpgsqlPoint(x: 0.03515207039317769d, y: 0.29942439310910096d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6215061619906715d, y: 0.6582624527353286d), new NpgsqlTypes.NpgsqlPoint(x: 0.20126281328434514d, y: 0.5083100794232843d), new NpgsqlTypes.NpgsqlPoint(x: 0.12346639467446763d, y: 0.8122068749793175d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2731035915433404d, y: 0.9519581421473258d), new NpgsqlTypes.NpgsqlPoint(x: 0.27806673851317343d, y: 0.16905531371962312d), new NpgsqlTypes.NpgsqlPoint(x: 0.9371900850707833d, y: 0.8236308251480443d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4963327356971008d, y: 0.9724094277712714d), new NpgsqlTypes.NpgsqlPoint(x: 0.02345722540811035d, y: 0.9994845826859913d), new NpgsqlTypes.NpgsqlPoint(x: 0.702366802674066d, y: 0.3226662050718935d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31717838668732357d, y: 0.5398816853257901d), new NpgsqlTypes.NpgsqlPoint(x: 0.6832041667130534d, y: 0.9140569738048524d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121262045755887d, y: 0.8788078137320866d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17342177347185583d, y: 0.3163084655921704d), new NpgsqlTypes.NpgsqlPoint(x: 0.7108187619105171d, y: 0.3526611202301684d), new NpgsqlTypes.NpgsqlPoint(x: 0.02073602107361383d, y: 0.503927152269893d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6655262666783374d, y: 0.32784078612362555d), new NpgsqlTypes.NpgsqlPoint(x: 0.31243903024020314d, y: 0.6758171460280334d), new NpgsqlTypes.NpgsqlPoint(x: 0.7512743754371254d, y: 0.9142569304027465d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35774281470084235d, y: 0.6438540582671918d), new NpgsqlTypes.NpgsqlPoint(x: 0.16937002709090154d, y: 0.979379647248583d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881741620009439d, y: 0.9214826465135623d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10854103539549131d, y: 0.09946583410747889d), new NpgsqlTypes.NpgsqlPoint(x: 0.9779428110038056d, y: 0.6895917626139211d), new NpgsqlTypes.NpgsqlPoint(x: 0.25444214399990617d, y: 0.025973942591299704d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24574943516970849d, y: 0.015363266156472433d), new NpgsqlTypes.NpgsqlPoint(x: 0.45864263762018576d, y: 0.7167716175716022d), new NpgsqlTypes.NpgsqlPoint(x: 0.0746260146000074d, y: 0.9278117465064071d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7625758475800613d, y: 0.010593027589338888d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231879750314012d, y: 0.2020639613954731d), new NpgsqlTypes.NpgsqlPoint(x: 0.845832777684248d, y: 0.22256059829809383d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39885831934596905d, y: 0.7243573149210671d), new NpgsqlTypes.NpgsqlPoint(x: 0.19346275378863365d, y: 0.6668362407462537d), new NpgsqlTypes.NpgsqlPoint(x: 0.038317893737672803d, y: 0.6490102169904582d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22492894814222164d, y: 0.9842843409013271d), new NpgsqlTypes.NpgsqlPoint(x: 0.8959869007316953d, y: 0.3053958187480319d), new NpgsqlTypes.NpgsqlPoint(x: 0.7222466519823557d, y: 0.14952016911003263d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6070056477260579d, y: 0.42357362183619596d), new NpgsqlTypes.NpgsqlPoint(x: 0.0783943578051629d, y: 0.2545659521614565d), new NpgsqlTypes.NpgsqlPoint(x: 0.41815525366914574d, y: 0.37301973749869355d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43992531719446404d, y: 0.03166282808189391d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304897548514752d, y: 0.22904838958035711d), new NpgsqlTypes.NpgsqlPoint(x: 0.2392111239911867d, y: 0.20935218089147622d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8802857931350914d, y: 0.6079886583520223d), new NpgsqlTypes.NpgsqlPoint(x: 0.4482946516157398d, y: 0.4044569228438841d), new NpgsqlTypes.NpgsqlPoint(x: 0.7455226172309501d, y: 0.26746653725526137d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6141264956351243d, y: 0.4814179648842932d), new NpgsqlTypes.NpgsqlPoint(x: 0.8400633918002128d, y: 0.9811001791679734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4759533171236646d, y: 0.5409886832862519d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1985040353101184d, y: 0.12150269226782995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9939353656985265d, y: 0.8411406232298015d), new NpgsqlTypes.NpgsqlPoint(x: 0.11080053996209871d, y: 0.37220032034202166d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005536665029967525d, y: 0.7527187470868221d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304741105065109d, y: 0.44581656206035947d), new NpgsqlTypes.NpgsqlPoint(x: 0.46289075384874323d, y: 0.37677866187907283d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6039631141040084d, y: 0.8069612131024438d), new NpgsqlTypes.NpgsqlPoint(x: 0.32455201952841173d, y: 0.9778135710527458d), new NpgsqlTypes.NpgsqlPoint(x: 0.10699576396430843d, y: 0.067280424710905d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9896398088041595d, y: 0.28784049332270667d), new NpgsqlTypes.NpgsqlPoint(x: 0.3100640986876153d, y: 0.3214707455181013d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712792648740431d, y: 0.6687158172054307d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28702414662017806d, y: 0.07530891768145154d), new NpgsqlTypes.NpgsqlPoint(x: 0.242538021830624d, y: 0.13544691552782295d), new NpgsqlTypes.NpgsqlPoint(x: 0.8690189732399497d, y: 0.38388897950800993d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16252189793245375d, y: 0.2898730918503969d), new NpgsqlTypes.NpgsqlPoint(x: 0.823818058284042d, y: 0.23516681394976724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6796929091652425d, y: 0.983582623568654d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48406779577953885d, y: 0.87608697517151d), new NpgsqlTypes.NpgsqlPoint(x: 0.29321764181178533d, y: 0.5114414391165925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7831630154614629d, y: 0.8676028525595907d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8284228295325501d, y: 0.07772601750223052d), new NpgsqlTypes.NpgsqlPoint(x: 0.6634531232284108d, y: 0.06740108757946772d), new NpgsqlTypes.NpgsqlPoint(x: 0.27513814656980007d, y: 0.33091404916961364d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.662834891169112d, y: 0.5230173919806234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914192387367067d, y: 0.49048333940963473d), new NpgsqlTypes.NpgsqlPoint(x: 0.4554417737219144d, y: 0.6483767935972367d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5831335789081196d, y: 0.508619342045313d), new NpgsqlTypes.NpgsqlPoint(x: 0.8507868198489099d, y: 0.9715505963496568d), new NpgsqlTypes.NpgsqlPoint(x: 0.2673145039918351d, y: 0.7834697480538554d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37383356840829485d, y: 0.7158582601995566d), new NpgsqlTypes.NpgsqlPoint(x: 0.4002511246703837d, y: 0.6019637744697596d), new NpgsqlTypes.NpgsqlPoint(x: 0.1661944885408937d, y: 0.05015440415140937d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9664686495433525d, y: 0.404379519283504d), new NpgsqlTypes.NpgsqlPoint(x: 0.06579761288352926d, y: 0.22765567031504252d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132610796201961d, y: 0.5773874415073214d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17420342329453642d, y: 0.69783985344197d), new NpgsqlTypes.NpgsqlPoint(x: 0.40443337005392643d, y: 0.7469250903754855d), new NpgsqlTypes.NpgsqlPoint(x: 0.658347498159873d, y: 0.4457800431298209d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6122405134053093d, y: 0.6864275973897199d), new NpgsqlTypes.NpgsqlPoint(x: 0.48068612932374266d, y: 0.8615538145778552d), new NpgsqlTypes.NpgsqlPoint(x: 0.3775370378793358d, y: 0.6922603780901211d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24265361249523854d, y: 0.7426836188096251d), new NpgsqlTypes.NpgsqlPoint(x: 0.35558490247728636d, y: 0.6637546829595234d), new NpgsqlTypes.NpgsqlPoint(x: 0.08204243651607979d, y: 0.9378705817655498d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29310852789050956d, y: 0.9321318839570543d), new NpgsqlTypes.NpgsqlPoint(x: 0.7179965332094024d, y: 0.9087044862121856d), new NpgsqlTypes.NpgsqlPoint(x: 0.43789269411364473d, y: 0.7743849566026303d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7580467870861705d, y: 0.3419141571972498d), new NpgsqlTypes.NpgsqlPoint(x: 0.06414733900571412d, y: 0.3325190494012217d), new NpgsqlTypes.NpgsqlPoint(x: 0.021529574131570417d, y: 0.9936224465964263d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9168390045873337d, y: 0.39742902009006387d), new NpgsqlTypes.NpgsqlPoint(x: 0.5992353114106587d, y: 0.1951662092280958d), new NpgsqlTypes.NpgsqlPoint(x: 0.6827412402191013d, y: 0.34950395362123643d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4914846444700216d, y: 0.7299228048027147d), new NpgsqlTypes.NpgsqlPoint(x: 0.4981675735229061d, y: 0.9570236762192814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8145776194930646d, y: 0.08509552669255183d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4627640538645129d, y: 0.783559999285597d), new NpgsqlTypes.NpgsqlPoint(x: 0.4222339035864705d, y: 0.9306144960395574d), new NpgsqlTypes.NpgsqlPoint(x: 0.052962911306298266d, y: 0.7608109163533741d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19467073090986675d, y: 0.9103261131618365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9179698259066694d, y: 0.6378730395333362d), new NpgsqlTypes.NpgsqlPoint(x: 0.4097114691303154d, y: 0.40301970350119853d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9680158175570656d, y: 0.8561536127310574d), new NpgsqlTypes.NpgsqlPoint(x: 0.8520414331391428d, y: 0.06535125357628924d), new NpgsqlTypes.NpgsqlPoint(x: 0.08877949522489414d, y: 0.3224577295261484d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05865515249658193d, y: 0.26889306617711906d), new NpgsqlTypes.NpgsqlPoint(x: 0.264909562586899d, y: 0.6438482976537068d), new NpgsqlTypes.NpgsqlPoint(x: 0.016669192213220496d, y: 0.8181897537612294d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18458459885698375d, y: 0.07400197326531543d), new NpgsqlTypes.NpgsqlPoint(x: 0.5524531690693645d, y: 0.02224700608647545d), new NpgsqlTypes.NpgsqlPoint(x: 0.9160373173550428d, y: 0.7170817048161879d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8450116821859607d, y: 0.32492028332858136d), new NpgsqlTypes.NpgsqlPoint(x: 0.5903687254624927d, y: 0.02360098541381417d), new NpgsqlTypes.NpgsqlPoint(x: 0.5109146048857272d, y: 0.6604268786717549d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7429550796184307d, y: 0.9897838084541145d), new NpgsqlTypes.NpgsqlPoint(x: 0.10426916114075402d, y: 0.8605167527705408d), new NpgsqlTypes.NpgsqlPoint(x: 0.5378529004160791d, y: 0.3315283473292766d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11236367841837192d, y: 0.8531039584567058d), new NpgsqlTypes.NpgsqlPoint(x: 0.9878207231774478d, y: 0.020358907842035756d), new NpgsqlTypes.NpgsqlPoint(x: 0.4060840311673528d, y: 0.8543686984619489d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8765842448566797d, y: 0.288599264767581d), new NpgsqlTypes.NpgsqlPoint(x: 0.41376053839326754d, y: 0.26774269996971045d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168558330214712d, y: 0.1372321332880313d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21837612830348163d, y: 0.017579719632604962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4695991069208296d, y: 0.4736358167875033d), new NpgsqlTypes.NpgsqlPoint(x: 0.18269354273651395d, y: 0.8243831867521555d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06139624221323359d, y: 0.522385716049343d), new NpgsqlTypes.NpgsqlPoint(x: 0.6748352576498483d, y: 0.40249610467114894d), new NpgsqlTypes.NpgsqlPoint(x: 0.3168632417979871d, y: 0.9234803320945143d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5655486938239972d, y: 0.5595851696140897d), new NpgsqlTypes.NpgsqlPoint(x: 0.5813347436113301d, y: 0.06798013288778415d), new NpgsqlTypes.NpgsqlPoint(x: 0.7378723704962924d, y: 0.29157257249266877d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6897334776678304d, y: 0.35004970180678696d), new NpgsqlTypes.NpgsqlPoint(x: 0.261939225946209d, y: 0.7006812341740555d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083093965414735d, y: 0.704494036977919d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4077518185589267d, y: 0.28164784378125185d), new NpgsqlTypes.NpgsqlPoint(x: 0.39108294232515395d, y: 0.8944944124044546d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554988534083007d, y: 0.7718863083785144d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.906210826440027d, y: 0.3240789353347159d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029530033883576d, y: 0.0672339163519241d), new NpgsqlTypes.NpgsqlPoint(x: 0.7699200043374601d, y: 0.07379472000801257d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3049183414177462d, y: 0.7659864585528469d), new NpgsqlTypes.NpgsqlPoint(x: 0.14066835829246493d, y: 0.1847732083052951d), new NpgsqlTypes.NpgsqlPoint(x: 0.19907622447332307d, y: 0.5529772630987735d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.557755004537712d, y: 0.8368059713841016d), new NpgsqlTypes.NpgsqlPoint(x: 0.893120730441898d, y: 0.8250304852258453d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914859131993219d, y: 0.446466106067097d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38308834033683614d, y: 0.9691799623610238d), new NpgsqlTypes.NpgsqlPoint(x: 0.121552223903729d, y: 0.6573082928521905d), new NpgsqlTypes.NpgsqlPoint(x: 0.21723332223773573d, y: 0.13208453676699738d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 169,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5850230676009256d, y: 0.32657702137995004d), new NpgsqlTypes.NpgsqlPoint(x: 0.5004277915703249d, y: 0.3421118576014338d), new NpgsqlTypes.NpgsqlPoint(x: 0.6621437616861787d, y: 0.019090013664494476d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15197809533074746d, y: 0.2696800492514554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586834694880529d, y: 0.19551456476918494d), new NpgsqlTypes.NpgsqlPoint(x: 0.08099175356889843d, y: 0.5115232933791074d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11474893897651695d, y: 0.4003886308918725d), new NpgsqlTypes.NpgsqlPoint(x: 0.2951140180036874d, y: 0.24272100534211405d), new NpgsqlTypes.NpgsqlPoint(x: 0.24400524394228706d, y: 0.6044298030345576d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 177,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9655864674534893d, y: 0.4480630029774596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5437499333177158d, y: 0.04214381593741778d), new NpgsqlTypes.NpgsqlPoint(x: 0.9620196584222588d, y: 0.0718365085486089d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 183,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7875532599880675d, y: 0.27931942263314047d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286221075248255d, y: 0.4591186542682756d), new NpgsqlTypes.NpgsqlPoint(x: 0.47079328237662255d, y: 0.47907333068370295d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.110898462448912d, y: 0.759288356174536d), new NpgsqlTypes.NpgsqlPoint(x: 0.38069124490381157d, y: 0.15678245856837048d), new NpgsqlTypes.NpgsqlPoint(x: 0.21639415651484306d, y: 0.8872635582306208d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5367214413732576d, y: 0.6572371905901992d), new NpgsqlTypes.NpgsqlPoint(x: 0.02085519284711923d, y: 0.9080069092872739d), new NpgsqlTypes.NpgsqlPoint(x: 0.8359348995889296d, y: 0.5324769718080465d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5812918919939698d, y: 0.30583801311876524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9760275621360507d, y: 0.8201377361781286d), new NpgsqlTypes.NpgsqlPoint(x: 0.0962261338666075d, y: 0.8472505125768259d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 188,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0469424456806411d, y: 0.8135833159376311d), new NpgsqlTypes.NpgsqlPoint(x: 0.3662018951352465d, y: 0.8405920298888002d), new NpgsqlTypes.NpgsqlPoint(x: 0.4366452705004136d, y: 0.6618522929702215d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 195,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7535602363714134d, y: 0.9561362134502941d), new NpgsqlTypes.NpgsqlPoint(x: 0.002318721599961271d, y: 0.04952573816160133d), new NpgsqlTypes.NpgsqlPoint(x: 0.9953460389251305d, y: 0.7744205602076087d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8489773438813952d, y: 0.7207479912593353d), new NpgsqlTypes.NpgsqlPoint(x: 0.44114103138637584d, y: 0.5418130564009151d), new NpgsqlTypes.NpgsqlPoint(x: 0.9737360567382023d, y: 0.3962576132419663d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9843426595469473d, y: 0.13875500724285106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6020130918690342d, y: 0.4278629900123292d), new NpgsqlTypes.NpgsqlPoint(x: 0.3177837916082812d, y: 0.9768426776640327d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 200,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3117541108649968d, y: 0.6473682177595231d), new NpgsqlTypes.NpgsqlPoint(x: 0.09056816755948238d, y: 0.043694889507898904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8743746824215424d, y: 0.46163708147517724d)),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygone0mi_id", 
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
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
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
    npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
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
    npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygone0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22492894814222164d, y: 0.9842843409013271d), new NpgsqlTypes.NpgsqlPoint(x: 0.8959869007316953d, y: 0.3053958187480319d), new NpgsqlTypes.NpgsqlPoint(x: 0.7222466519823557d, y: 0.14952016911003263d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43992531719446404d, y: 0.03166282808189391d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304897548514752d, y: 0.22904838958035711d), new NpgsqlTypes.NpgsqlPoint(x: 0.2392111239911867d, y: 0.20935218089147622d))));
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1985040353101184d, y: 0.12150269226782995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9939353656985265d, y: 0.8411406232298015d), new NpgsqlTypes.NpgsqlPoint(x: 0.11080053996209871d, y: 0.37220032034202166d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonE0M> models = null;

                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonE0M> models = null;

                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpolygonpolygone0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpolygonpolygone0mi_id", 
                methodParametrName: "npgsqlpolygonpolygone0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 63;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 117;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 169;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[32],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 77, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 177, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 156, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 126, query1, 11, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 55, query1, 93, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 11, query1, 55, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 149, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 183, query1, 169, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 183, 86))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 183, 93))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 55);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[8], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[9], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[10], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[11], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[12], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[13], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[14], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[15], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[16], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[17], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[18], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[19], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[20], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[21], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[22], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[23], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[24], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[25], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[26], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[27], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[28], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[29], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[30], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[31], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[32], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[33], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 86);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[12], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[13], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[14], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[15], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[16], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[17], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[18], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[19], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[20], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[21], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[22], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[23], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[24], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[25], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[26], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[27], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[28], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[29], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[30], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[31], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[32], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[33], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9109167822590589d, y: 0.6379943455472734d), new NpgsqlTypes.NpgsqlPoint(x: 0.22791767104696603d, y: 0.14413113186820015d), new NpgsqlTypes.NpgsqlPoint(x: 0.0012857373103637437d, y: 0.5422811924311735d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4782298610434843d, y: 0.2663295177917685d), new NpgsqlTypes.NpgsqlPoint(x: 0.26511868018934326d, y: 0.03250992017478038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5051370979539542d, y: 0.7442289827637926d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9889097814382325d, y: 0.6948057845811519d), new NpgsqlTypes.NpgsqlPoint(x: 0.8880916711280509d, y: 0.7502357326917123d), new NpgsqlTypes.NpgsqlPoint(x: 0.04800313823181801d, y: 0.10806934098078802d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29429382873158627d, y: 0.0338882567079557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077982675185806d, y: 0.24018093911399163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7270370896702113d, y: 0.820132395114726d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9373208824757985d, y: 0.7374949340071767d), new NpgsqlTypes.NpgsqlPoint(x: 0.3332479951842727d, y: 0.22502053651421272d), new NpgsqlTypes.NpgsqlPoint(x: 0.30735335918629225d, y: 0.7230354275716165d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6848225403036495d, y: 0.6280836260101814d), new NpgsqlTypes.NpgsqlPoint(x: 0.3887296005911751d, y: 0.03389318842465905d), new NpgsqlTypes.NpgsqlPoint(x: 0.4795671218912334d, y: 0.6075265104609865d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4273869601521961d, y: 0.9087859852422303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428306492566859d, y: 0.09929615675303571d), new NpgsqlTypes.NpgsqlPoint(x: 0.7675138916148619d, y: 0.32393151276967236d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6361024050574287d, y: 0.8100818043206333d), new NpgsqlTypes.NpgsqlPoint(x: 0.2936946902714114d, y: 0.46674209513450915d), new NpgsqlTypes.NpgsqlPoint(x: 0.5369548406776432d, y: 0.6375584869283379d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1748278891570152d, y: 0.0848929368501018d), new NpgsqlTypes.NpgsqlPoint(x: 0.827623777596489d, y: 0.35921434322157697d), new NpgsqlTypes.NpgsqlPoint(x: 0.03515207039317769d, y: 0.29942439310910096d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6215061619906715d, y: 0.6582624527353286d), new NpgsqlTypes.NpgsqlPoint(x: 0.20126281328434514d, y: 0.5083100794232843d), new NpgsqlTypes.NpgsqlPoint(x: 0.12346639467446763d, y: 0.8122068749793175d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2731035915433404d, y: 0.9519581421473258d), new NpgsqlTypes.NpgsqlPoint(x: 0.27806673851317343d, y: 0.16905531371962312d), new NpgsqlTypes.NpgsqlPoint(x: 0.9371900850707833d, y: 0.8236308251480443d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4963327356971008d, y: 0.9724094277712714d), new NpgsqlTypes.NpgsqlPoint(x: 0.02345722540811035d, y: 0.9994845826859913d), new NpgsqlTypes.NpgsqlPoint(x: 0.702366802674066d, y: 0.3226662050718935d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31717838668732357d, y: 0.5398816853257901d), new NpgsqlTypes.NpgsqlPoint(x: 0.6832041667130534d, y: 0.9140569738048524d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121262045755887d, y: 0.8788078137320866d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17342177347185583d, y: 0.3163084655921704d), new NpgsqlTypes.NpgsqlPoint(x: 0.7108187619105171d, y: 0.3526611202301684d), new NpgsqlTypes.NpgsqlPoint(x: 0.02073602107361383d, y: 0.503927152269893d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6655262666783374d, y: 0.32784078612362555d), new NpgsqlTypes.NpgsqlPoint(x: 0.31243903024020314d, y: 0.6758171460280334d), new NpgsqlTypes.NpgsqlPoint(x: 0.7512743754371254d, y: 0.9142569304027465d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35774281470084235d, y: 0.6438540582671918d), new NpgsqlTypes.NpgsqlPoint(x: 0.16937002709090154d, y: 0.979379647248583d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881741620009439d, y: 0.9214826465135623d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10854103539549131d, y: 0.09946583410747889d), new NpgsqlTypes.NpgsqlPoint(x: 0.9779428110038056d, y: 0.6895917626139211d), new NpgsqlTypes.NpgsqlPoint(x: 0.25444214399990617d, y: 0.025973942591299704d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24574943516970849d, y: 0.015363266156472433d), new NpgsqlTypes.NpgsqlPoint(x: 0.45864263762018576d, y: 0.7167716175716022d), new NpgsqlTypes.NpgsqlPoint(x: 0.0746260146000074d, y: 0.9278117465064071d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7625758475800613d, y: 0.010593027589338888d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231879750314012d, y: 0.2020639613954731d), new NpgsqlTypes.NpgsqlPoint(x: 0.845832777684248d, y: 0.22256059829809383d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39885831934596905d, y: 0.7243573149210671d), new NpgsqlTypes.NpgsqlPoint(x: 0.19346275378863365d, y: 0.6668362407462537d), new NpgsqlTypes.NpgsqlPoint(x: 0.038317893737672803d, y: 0.6490102169904582d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22492894814222164d, y: 0.9842843409013271d), new NpgsqlTypes.NpgsqlPoint(x: 0.8959869007316953d, y: 0.3053958187480319d), new NpgsqlTypes.NpgsqlPoint(x: 0.7222466519823557d, y: 0.14952016911003263d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6070056477260579d, y: 0.42357362183619596d), new NpgsqlTypes.NpgsqlPoint(x: 0.0783943578051629d, y: 0.2545659521614565d), new NpgsqlTypes.NpgsqlPoint(x: 0.41815525366914574d, y: 0.37301973749869355d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43992531719446404d, y: 0.03166282808189391d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304897548514752d, y: 0.22904838958035711d), new NpgsqlTypes.NpgsqlPoint(x: 0.2392111239911867d, y: 0.20935218089147622d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8802857931350914d, y: 0.6079886583520223d), new NpgsqlTypes.NpgsqlPoint(x: 0.4482946516157398d, y: 0.4044569228438841d), new NpgsqlTypes.NpgsqlPoint(x: 0.7455226172309501d, y: 0.26746653725526137d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6141264956351243d, y: 0.4814179648842932d), new NpgsqlTypes.NpgsqlPoint(x: 0.8400633918002128d, y: 0.9811001791679734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4759533171236646d, y: 0.5409886832862519d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1985040353101184d, y: 0.12150269226782995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9939353656985265d, y: 0.8411406232298015d), new NpgsqlTypes.NpgsqlPoint(x: 0.11080053996209871d, y: 0.37220032034202166d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005536665029967525d, y: 0.7527187470868221d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304741105065109d, y: 0.44581656206035947d), new NpgsqlTypes.NpgsqlPoint(x: 0.46289075384874323d, y: 0.37677866187907283d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6039631141040084d, y: 0.8069612131024438d), new NpgsqlTypes.NpgsqlPoint(x: 0.32455201952841173d, y: 0.9778135710527458d), new NpgsqlTypes.NpgsqlPoint(x: 0.10699576396430843d, y: 0.067280424710905d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9896398088041595d, y: 0.28784049332270667d), new NpgsqlTypes.NpgsqlPoint(x: 0.3100640986876153d, y: 0.3214707455181013d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712792648740431d, y: 0.6687158172054307d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28702414662017806d, y: 0.07530891768145154d), new NpgsqlTypes.NpgsqlPoint(x: 0.242538021830624d, y: 0.13544691552782295d), new NpgsqlTypes.NpgsqlPoint(x: 0.8690189732399497d, y: 0.38388897950800993d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16252189793245375d, y: 0.2898730918503969d), new NpgsqlTypes.NpgsqlPoint(x: 0.823818058284042d, y: 0.23516681394976724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6796929091652425d, y: 0.983582623568654d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48406779577953885d, y: 0.87608697517151d), new NpgsqlTypes.NpgsqlPoint(x: 0.29321764181178533d, y: 0.5114414391165925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7831630154614629d, y: 0.8676028525595907d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8284228295325501d, y: 0.07772601750223052d), new NpgsqlTypes.NpgsqlPoint(x: 0.6634531232284108d, y: 0.06740108757946772d), new NpgsqlTypes.NpgsqlPoint(x: 0.27513814656980007d, y: 0.33091404916961364d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.662834891169112d, y: 0.5230173919806234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914192387367067d, y: 0.49048333940963473d), new NpgsqlTypes.NpgsqlPoint(x: 0.4554417737219144d, y: 0.6483767935972367d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5831335789081196d, y: 0.508619342045313d), new NpgsqlTypes.NpgsqlPoint(x: 0.8507868198489099d, y: 0.9715505963496568d), new NpgsqlTypes.NpgsqlPoint(x: 0.2673145039918351d, y: 0.7834697480538554d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37383356840829485d, y: 0.7158582601995566d), new NpgsqlTypes.NpgsqlPoint(x: 0.4002511246703837d, y: 0.6019637744697596d), new NpgsqlTypes.NpgsqlPoint(x: 0.1661944885408937d, y: 0.05015440415140937d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9664686495433525d, y: 0.404379519283504d), new NpgsqlTypes.NpgsqlPoint(x: 0.06579761288352926d, y: 0.22765567031504252d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132610796201961d, y: 0.5773874415073214d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17420342329453642d, y: 0.69783985344197d), new NpgsqlTypes.NpgsqlPoint(x: 0.40443337005392643d, y: 0.7469250903754855d), new NpgsqlTypes.NpgsqlPoint(x: 0.658347498159873d, y: 0.4457800431298209d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6122405134053093d, y: 0.6864275973897199d), new NpgsqlTypes.NpgsqlPoint(x: 0.48068612932374266d, y: 0.8615538145778552d), new NpgsqlTypes.NpgsqlPoint(x: 0.3775370378793358d, y: 0.6922603780901211d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24265361249523854d, y: 0.7426836188096251d), new NpgsqlTypes.NpgsqlPoint(x: 0.35558490247728636d, y: 0.6637546829595234d), new NpgsqlTypes.NpgsqlPoint(x: 0.08204243651607979d, y: 0.9378705817655498d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29310852789050956d, y: 0.9321318839570543d), new NpgsqlTypes.NpgsqlPoint(x: 0.7179965332094024d, y: 0.9087044862121856d), new NpgsqlTypes.NpgsqlPoint(x: 0.43789269411364473d, y: 0.7743849566026303d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7580467870861705d, y: 0.3419141571972498d), new NpgsqlTypes.NpgsqlPoint(x: 0.06414733900571412d, y: 0.3325190494012217d), new NpgsqlTypes.NpgsqlPoint(x: 0.021529574131570417d, y: 0.9936224465964263d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9168390045873337d, y: 0.39742902009006387d), new NpgsqlTypes.NpgsqlPoint(x: 0.5992353114106587d, y: 0.1951662092280958d), new NpgsqlTypes.NpgsqlPoint(x: 0.6827412402191013d, y: 0.34950395362123643d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4914846444700216d, y: 0.7299228048027147d), new NpgsqlTypes.NpgsqlPoint(x: 0.4981675735229061d, y: 0.9570236762192814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8145776194930646d, y: 0.08509552669255183d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4627640538645129d, y: 0.783559999285597d), new NpgsqlTypes.NpgsqlPoint(x: 0.4222339035864705d, y: 0.9306144960395574d), new NpgsqlTypes.NpgsqlPoint(x: 0.052962911306298266d, y: 0.7608109163533741d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19467073090986675d, y: 0.9103261131618365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9179698259066694d, y: 0.6378730395333362d), new NpgsqlTypes.NpgsqlPoint(x: 0.4097114691303154d, y: 0.40301970350119853d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9680158175570656d, y: 0.8561536127310574d), new NpgsqlTypes.NpgsqlPoint(x: 0.8520414331391428d, y: 0.06535125357628924d), new NpgsqlTypes.NpgsqlPoint(x: 0.08877949522489414d, y: 0.3224577295261484d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05865515249658193d, y: 0.26889306617711906d), new NpgsqlTypes.NpgsqlPoint(x: 0.264909562586899d, y: 0.6438482976537068d), new NpgsqlTypes.NpgsqlPoint(x: 0.016669192213220496d, y: 0.8181897537612294d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18458459885698375d, y: 0.07400197326531543d), new NpgsqlTypes.NpgsqlPoint(x: 0.5524531690693645d, y: 0.02224700608647545d), new NpgsqlTypes.NpgsqlPoint(x: 0.9160373173550428d, y: 0.7170817048161879d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8450116821859607d, y: 0.32492028332858136d), new NpgsqlTypes.NpgsqlPoint(x: 0.5903687254624927d, y: 0.02360098541381417d), new NpgsqlTypes.NpgsqlPoint(x: 0.5109146048857272d, y: 0.6604268786717549d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7429550796184307d, y: 0.9897838084541145d), new NpgsqlTypes.NpgsqlPoint(x: 0.10426916114075402d, y: 0.8605167527705408d), new NpgsqlTypes.NpgsqlPoint(x: 0.5378529004160791d, y: 0.3315283473292766d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11236367841837192d, y: 0.8531039584567058d), new NpgsqlTypes.NpgsqlPoint(x: 0.9878207231774478d, y: 0.020358907842035756d), new NpgsqlTypes.NpgsqlPoint(x: 0.4060840311673528d, y: 0.8543686984619489d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8765842448566797d, y: 0.288599264767581d), new NpgsqlTypes.NpgsqlPoint(x: 0.41376053839326754d, y: 0.26774269996971045d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168558330214712d, y: 0.1372321332880313d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21837612830348163d, y: 0.017579719632604962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4695991069208296d, y: 0.4736358167875033d), new NpgsqlTypes.NpgsqlPoint(x: 0.18269354273651395d, y: 0.8243831867521555d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06139624221323359d, y: 0.522385716049343d), new NpgsqlTypes.NpgsqlPoint(x: 0.6748352576498483d, y: 0.40249610467114894d), new NpgsqlTypes.NpgsqlPoint(x: 0.3168632417979871d, y: 0.9234803320945143d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5655486938239972d, y: 0.5595851696140897d), new NpgsqlTypes.NpgsqlPoint(x: 0.5813347436113301d, y: 0.06798013288778415d), new NpgsqlTypes.NpgsqlPoint(x: 0.7378723704962924d, y: 0.29157257249266877d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6897334776678304d, y: 0.35004970180678696d), new NpgsqlTypes.NpgsqlPoint(x: 0.261939225946209d, y: 0.7006812341740555d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083093965414735d, y: 0.704494036977919d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4077518185589267d, y: 0.28164784378125185d), new NpgsqlTypes.NpgsqlPoint(x: 0.39108294232515395d, y: 0.8944944124044546d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554988534083007d, y: 0.7718863083785144d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.906210826440027d, y: 0.3240789353347159d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029530033883576d, y: 0.0672339163519241d), new NpgsqlTypes.NpgsqlPoint(x: 0.7699200043374601d, y: 0.07379472000801257d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3049183414177462d, y: 0.7659864585528469d), new NpgsqlTypes.NpgsqlPoint(x: 0.14066835829246493d, y: 0.1847732083052951d), new NpgsqlTypes.NpgsqlPoint(x: 0.19907622447332307d, y: 0.5529772630987735d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.557755004537712d, y: 0.8368059713841016d), new NpgsqlTypes.NpgsqlPoint(x: 0.893120730441898d, y: 0.8250304852258453d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914859131993219d, y: 0.446466106067097d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38308834033683614d, y: 0.9691799623610238d), new NpgsqlTypes.NpgsqlPoint(x: 0.121552223903729d, y: 0.6573082928521905d), new NpgsqlTypes.NpgsqlPoint(x: 0.21723332223773573d, y: 0.13208453676699738d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5850230676009256d, y: 0.32657702137995004d), new NpgsqlTypes.NpgsqlPoint(x: 0.5004277915703249d, y: 0.3421118576014338d), new NpgsqlTypes.NpgsqlPoint(x: 0.6621437616861787d, y: 0.019090013664494476d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15197809533074746d, y: 0.2696800492514554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586834694880529d, y: 0.19551456476918494d), new NpgsqlTypes.NpgsqlPoint(x: 0.08099175356889843d, y: 0.5115232933791074d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11474893897651695d, y: 0.4003886308918725d), new NpgsqlTypes.NpgsqlPoint(x: 0.2951140180036874d, y: 0.24272100534211405d), new NpgsqlTypes.NpgsqlPoint(x: 0.24400524394228706d, y: 0.6044298030345576d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9655864674534893d, y: 0.4480630029774596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5437499333177158d, y: 0.04214381593741778d), new NpgsqlTypes.NpgsqlPoint(x: 0.9620196584222588d, y: 0.0718365085486089d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7875532599880675d, y: 0.27931942263314047d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286221075248255d, y: 0.4591186542682756d), new NpgsqlTypes.NpgsqlPoint(x: 0.47079328237662255d, y: 0.47907333068370295d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.110898462448912d, y: 0.759288356174536d), new NpgsqlTypes.NpgsqlPoint(x: 0.38069124490381157d, y: 0.15678245856837048d), new NpgsqlTypes.NpgsqlPoint(x: 0.21639415651484306d, y: 0.8872635582306208d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5367214413732576d, y: 0.6572371905901992d), new NpgsqlTypes.NpgsqlPoint(x: 0.02085519284711923d, y: 0.9080069092872739d), new NpgsqlTypes.NpgsqlPoint(x: 0.8359348995889296d, y: 0.5324769718080465d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5812918919939698d, y: 0.30583801311876524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9760275621360507d, y: 0.8201377361781286d), new NpgsqlTypes.NpgsqlPoint(x: 0.0962261338666075d, y: 0.8472505125768259d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0469424456806411d, y: 0.8135833159376311d), new NpgsqlTypes.NpgsqlPoint(x: 0.3662018951352465d, y: 0.8405920298888002d), new NpgsqlTypes.NpgsqlPoint(x: 0.4366452705004136d, y: 0.6618522929702215d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((195)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7535602363714134d, y: 0.9561362134502941d), new NpgsqlTypes.NpgsqlPoint(x: 0.002318721599961271d, y: 0.04952573816160133d), new NpgsqlTypes.NpgsqlPoint(x: 0.9953460389251305d, y: 0.7744205602076087d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8489773438813952d, y: 0.7207479912593353d), new NpgsqlTypes.NpgsqlPoint(x: 0.44114103138637584d, y: 0.5418130564009151d), new NpgsqlTypes.NpgsqlPoint(x: 0.9737360567382023d, y: 0.3962576132419663d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9843426595469473d, y: 0.13875500724285106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6020130918690342d, y: 0.4278629900123292d), new NpgsqlTypes.NpgsqlPoint(x: 0.3177837916082812d, y: 0.9768426776640327d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((200)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3117541108649968d, y: 0.6473682177595231d), new NpgsqlTypes.NpgsqlPoint(x: 0.09056816755948238d, y: 0.043694889507898904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8743746824215424d, y: 0.46163708147517724d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9109167822590589d, y: 0.6379943455472734d), new NpgsqlTypes.NpgsqlPoint(x: 0.22791767104696603d, y: 0.14413113186820015d), new NpgsqlTypes.NpgsqlPoint(x: 0.0012857373103637437d, y: 0.5422811924311735d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4782298610434843d, y: 0.2663295177917685d), new NpgsqlTypes.NpgsqlPoint(x: 0.26511868018934326d, y: 0.03250992017478038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5051370979539542d, y: 0.7442289827637926d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9889097814382325d, y: 0.6948057845811519d), new NpgsqlTypes.NpgsqlPoint(x: 0.8880916711280509d, y: 0.7502357326917123d), new NpgsqlTypes.NpgsqlPoint(x: 0.04800313823181801d, y: 0.10806934098078802d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29429382873158627d, y: 0.0338882567079557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077982675185806d, y: 0.24018093911399163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7270370896702113d, y: 0.820132395114726d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9373208824757985d, y: 0.7374949340071767d), new NpgsqlTypes.NpgsqlPoint(x: 0.3332479951842727d, y: 0.22502053651421272d), new NpgsqlTypes.NpgsqlPoint(x: 0.30735335918629225d, y: 0.7230354275716165d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6848225403036495d, y: 0.6280836260101814d), new NpgsqlTypes.NpgsqlPoint(x: 0.3887296005911751d, y: 0.03389318842465905d), new NpgsqlTypes.NpgsqlPoint(x: 0.4795671218912334d, y: 0.6075265104609865d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4273869601521961d, y: 0.9087859852422303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428306492566859d, y: 0.09929615675303571d), new NpgsqlTypes.NpgsqlPoint(x: 0.7675138916148619d, y: 0.32393151276967236d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6361024050574287d, y: 0.8100818043206333d), new NpgsqlTypes.NpgsqlPoint(x: 0.2936946902714114d, y: 0.46674209513450915d), new NpgsqlTypes.NpgsqlPoint(x: 0.5369548406776432d, y: 0.6375584869283379d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1748278891570152d, y: 0.0848929368501018d), new NpgsqlTypes.NpgsqlPoint(x: 0.827623777596489d, y: 0.35921434322157697d), new NpgsqlTypes.NpgsqlPoint(x: 0.03515207039317769d, y: 0.29942439310910096d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6215061619906715d, y: 0.6582624527353286d), new NpgsqlTypes.NpgsqlPoint(x: 0.20126281328434514d, y: 0.5083100794232843d), new NpgsqlTypes.NpgsqlPoint(x: 0.12346639467446763d, y: 0.8122068749793175d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2731035915433404d, y: 0.9519581421473258d), new NpgsqlTypes.NpgsqlPoint(x: 0.27806673851317343d, y: 0.16905531371962312d), new NpgsqlTypes.NpgsqlPoint(x: 0.9371900850707833d, y: 0.8236308251480443d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4963327356971008d, y: 0.9724094277712714d), new NpgsqlTypes.NpgsqlPoint(x: 0.02345722540811035d, y: 0.9994845826859913d), new NpgsqlTypes.NpgsqlPoint(x: 0.702366802674066d, y: 0.3226662050718935d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31717838668732357d, y: 0.5398816853257901d), new NpgsqlTypes.NpgsqlPoint(x: 0.6832041667130534d, y: 0.9140569738048524d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121262045755887d, y: 0.8788078137320866d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17342177347185583d, y: 0.3163084655921704d), new NpgsqlTypes.NpgsqlPoint(x: 0.7108187619105171d, y: 0.3526611202301684d), new NpgsqlTypes.NpgsqlPoint(x: 0.02073602107361383d, y: 0.503927152269893d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6655262666783374d, y: 0.32784078612362555d), new NpgsqlTypes.NpgsqlPoint(x: 0.31243903024020314d, y: 0.6758171460280334d), new NpgsqlTypes.NpgsqlPoint(x: 0.7512743754371254d, y: 0.9142569304027465d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35774281470084235d, y: 0.6438540582671918d), new NpgsqlTypes.NpgsqlPoint(x: 0.16937002709090154d, y: 0.979379647248583d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881741620009439d, y: 0.9214826465135623d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10854103539549131d, y: 0.09946583410747889d), new NpgsqlTypes.NpgsqlPoint(x: 0.9779428110038056d, y: 0.6895917626139211d), new NpgsqlTypes.NpgsqlPoint(x: 0.25444214399990617d, y: 0.025973942591299704d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24574943516970849d, y: 0.015363266156472433d), new NpgsqlTypes.NpgsqlPoint(x: 0.45864263762018576d, y: 0.7167716175716022d), new NpgsqlTypes.NpgsqlPoint(x: 0.0746260146000074d, y: 0.9278117465064071d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7625758475800613d, y: 0.010593027589338888d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231879750314012d, y: 0.2020639613954731d), new NpgsqlTypes.NpgsqlPoint(x: 0.845832777684248d, y: 0.22256059829809383d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39885831934596905d, y: 0.7243573149210671d), new NpgsqlTypes.NpgsqlPoint(x: 0.19346275378863365d, y: 0.6668362407462537d), new NpgsqlTypes.NpgsqlPoint(x: 0.038317893737672803d, y: 0.6490102169904582d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22492894814222164d, y: 0.9842843409013271d), new NpgsqlTypes.NpgsqlPoint(x: 0.8959869007316953d, y: 0.3053958187480319d), new NpgsqlTypes.NpgsqlPoint(x: 0.7222466519823557d, y: 0.14952016911003263d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6070056477260579d, y: 0.42357362183619596d), new NpgsqlTypes.NpgsqlPoint(x: 0.0783943578051629d, y: 0.2545659521614565d), new NpgsqlTypes.NpgsqlPoint(x: 0.41815525366914574d, y: 0.37301973749869355d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43992531719446404d, y: 0.03166282808189391d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304897548514752d, y: 0.22904838958035711d), new NpgsqlTypes.NpgsqlPoint(x: 0.2392111239911867d, y: 0.20935218089147622d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8802857931350914d, y: 0.6079886583520223d), new NpgsqlTypes.NpgsqlPoint(x: 0.4482946516157398d, y: 0.4044569228438841d), new NpgsqlTypes.NpgsqlPoint(x: 0.7455226172309501d, y: 0.26746653725526137d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6141264956351243d, y: 0.4814179648842932d), new NpgsqlTypes.NpgsqlPoint(x: 0.8400633918002128d, y: 0.9811001791679734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4759533171236646d, y: 0.5409886832862519d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1985040353101184d, y: 0.12150269226782995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9939353656985265d, y: 0.8411406232298015d), new NpgsqlTypes.NpgsqlPoint(x: 0.11080053996209871d, y: 0.37220032034202166d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005536665029967525d, y: 0.7527187470868221d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304741105065109d, y: 0.44581656206035947d), new NpgsqlTypes.NpgsqlPoint(x: 0.46289075384874323d, y: 0.37677866187907283d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6039631141040084d, y: 0.8069612131024438d), new NpgsqlTypes.NpgsqlPoint(x: 0.32455201952841173d, y: 0.9778135710527458d), new NpgsqlTypes.NpgsqlPoint(x: 0.10699576396430843d, y: 0.067280424710905d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9896398088041595d, y: 0.28784049332270667d), new NpgsqlTypes.NpgsqlPoint(x: 0.3100640986876153d, y: 0.3214707455181013d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712792648740431d, y: 0.6687158172054307d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28702414662017806d, y: 0.07530891768145154d), new NpgsqlTypes.NpgsqlPoint(x: 0.242538021830624d, y: 0.13544691552782295d), new NpgsqlTypes.NpgsqlPoint(x: 0.8690189732399497d, y: 0.38388897950800993d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16252189793245375d, y: 0.2898730918503969d), new NpgsqlTypes.NpgsqlPoint(x: 0.823818058284042d, y: 0.23516681394976724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6796929091652425d, y: 0.983582623568654d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48406779577953885d, y: 0.87608697517151d), new NpgsqlTypes.NpgsqlPoint(x: 0.29321764181178533d, y: 0.5114414391165925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7831630154614629d, y: 0.8676028525595907d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8284228295325501d, y: 0.07772601750223052d), new NpgsqlTypes.NpgsqlPoint(x: 0.6634531232284108d, y: 0.06740108757946772d), new NpgsqlTypes.NpgsqlPoint(x: 0.27513814656980007d, y: 0.33091404916961364d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.662834891169112d, y: 0.5230173919806234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914192387367067d, y: 0.49048333940963473d), new NpgsqlTypes.NpgsqlPoint(x: 0.4554417737219144d, y: 0.6483767935972367d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5831335789081196d, y: 0.508619342045313d), new NpgsqlTypes.NpgsqlPoint(x: 0.8507868198489099d, y: 0.9715505963496568d), new NpgsqlTypes.NpgsqlPoint(x: 0.2673145039918351d, y: 0.7834697480538554d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37383356840829485d, y: 0.7158582601995566d), new NpgsqlTypes.NpgsqlPoint(x: 0.4002511246703837d, y: 0.6019637744697596d), new NpgsqlTypes.NpgsqlPoint(x: 0.1661944885408937d, y: 0.05015440415140937d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9664686495433525d, y: 0.404379519283504d), new NpgsqlTypes.NpgsqlPoint(x: 0.06579761288352926d, y: 0.22765567031504252d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132610796201961d, y: 0.5773874415073214d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17420342329453642d, y: 0.69783985344197d), new NpgsqlTypes.NpgsqlPoint(x: 0.40443337005392643d, y: 0.7469250903754855d), new NpgsqlTypes.NpgsqlPoint(x: 0.658347498159873d, y: 0.4457800431298209d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6122405134053093d, y: 0.6864275973897199d), new NpgsqlTypes.NpgsqlPoint(x: 0.48068612932374266d, y: 0.8615538145778552d), new NpgsqlTypes.NpgsqlPoint(x: 0.3775370378793358d, y: 0.6922603780901211d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24265361249523854d, y: 0.7426836188096251d), new NpgsqlTypes.NpgsqlPoint(x: 0.35558490247728636d, y: 0.6637546829595234d), new NpgsqlTypes.NpgsqlPoint(x: 0.08204243651607979d, y: 0.9378705817655498d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29310852789050956d, y: 0.9321318839570543d), new NpgsqlTypes.NpgsqlPoint(x: 0.7179965332094024d, y: 0.9087044862121856d), new NpgsqlTypes.NpgsqlPoint(x: 0.43789269411364473d, y: 0.7743849566026303d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7580467870861705d, y: 0.3419141571972498d), new NpgsqlTypes.NpgsqlPoint(x: 0.06414733900571412d, y: 0.3325190494012217d), new NpgsqlTypes.NpgsqlPoint(x: 0.021529574131570417d, y: 0.9936224465964263d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9168390045873337d, y: 0.39742902009006387d), new NpgsqlTypes.NpgsqlPoint(x: 0.5992353114106587d, y: 0.1951662092280958d), new NpgsqlTypes.NpgsqlPoint(x: 0.6827412402191013d, y: 0.34950395362123643d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4914846444700216d, y: 0.7299228048027147d), new NpgsqlTypes.NpgsqlPoint(x: 0.4981675735229061d, y: 0.9570236762192814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8145776194930646d, y: 0.08509552669255183d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4627640538645129d, y: 0.783559999285597d), new NpgsqlTypes.NpgsqlPoint(x: 0.4222339035864705d, y: 0.9306144960395574d), new NpgsqlTypes.NpgsqlPoint(x: 0.052962911306298266d, y: 0.7608109163533741d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19467073090986675d, y: 0.9103261131618365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9179698259066694d, y: 0.6378730395333362d), new NpgsqlTypes.NpgsqlPoint(x: 0.4097114691303154d, y: 0.40301970350119853d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9680158175570656d, y: 0.8561536127310574d), new NpgsqlTypes.NpgsqlPoint(x: 0.8520414331391428d, y: 0.06535125357628924d), new NpgsqlTypes.NpgsqlPoint(x: 0.08877949522489414d, y: 0.3224577295261484d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05865515249658193d, y: 0.26889306617711906d), new NpgsqlTypes.NpgsqlPoint(x: 0.264909562586899d, y: 0.6438482976537068d), new NpgsqlTypes.NpgsqlPoint(x: 0.016669192213220496d, y: 0.8181897537612294d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18458459885698375d, y: 0.07400197326531543d), new NpgsqlTypes.NpgsqlPoint(x: 0.5524531690693645d, y: 0.02224700608647545d), new NpgsqlTypes.NpgsqlPoint(x: 0.9160373173550428d, y: 0.7170817048161879d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8450116821859607d, y: 0.32492028332858136d), new NpgsqlTypes.NpgsqlPoint(x: 0.5903687254624927d, y: 0.02360098541381417d), new NpgsqlTypes.NpgsqlPoint(x: 0.5109146048857272d, y: 0.6604268786717549d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7429550796184307d, y: 0.9897838084541145d), new NpgsqlTypes.NpgsqlPoint(x: 0.10426916114075402d, y: 0.8605167527705408d), new NpgsqlTypes.NpgsqlPoint(x: 0.5378529004160791d, y: 0.3315283473292766d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11236367841837192d, y: 0.8531039584567058d), new NpgsqlTypes.NpgsqlPoint(x: 0.9878207231774478d, y: 0.020358907842035756d), new NpgsqlTypes.NpgsqlPoint(x: 0.4060840311673528d, y: 0.8543686984619489d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8765842448566797d, y: 0.288599264767581d), new NpgsqlTypes.NpgsqlPoint(x: 0.41376053839326754d, y: 0.26774269996971045d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168558330214712d, y: 0.1372321332880313d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21837612830348163d, y: 0.017579719632604962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4695991069208296d, y: 0.4736358167875033d), new NpgsqlTypes.NpgsqlPoint(x: 0.18269354273651395d, y: 0.8243831867521555d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06139624221323359d, y: 0.522385716049343d), new NpgsqlTypes.NpgsqlPoint(x: 0.6748352576498483d, y: 0.40249610467114894d), new NpgsqlTypes.NpgsqlPoint(x: 0.3168632417979871d, y: 0.9234803320945143d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5655486938239972d, y: 0.5595851696140897d), new NpgsqlTypes.NpgsqlPoint(x: 0.5813347436113301d, y: 0.06798013288778415d), new NpgsqlTypes.NpgsqlPoint(x: 0.7378723704962924d, y: 0.29157257249266877d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6897334776678304d, y: 0.35004970180678696d), new NpgsqlTypes.NpgsqlPoint(x: 0.261939225946209d, y: 0.7006812341740555d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083093965414735d, y: 0.704494036977919d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4077518185589267d, y: 0.28164784378125185d), new NpgsqlTypes.NpgsqlPoint(x: 0.39108294232515395d, y: 0.8944944124044546d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554988534083007d, y: 0.7718863083785144d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.906210826440027d, y: 0.3240789353347159d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029530033883576d, y: 0.0672339163519241d), new NpgsqlTypes.NpgsqlPoint(x: 0.7699200043374601d, y: 0.07379472000801257d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3049183414177462d, y: 0.7659864585528469d), new NpgsqlTypes.NpgsqlPoint(x: 0.14066835829246493d, y: 0.1847732083052951d), new NpgsqlTypes.NpgsqlPoint(x: 0.19907622447332307d, y: 0.5529772630987735d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.557755004537712d, y: 0.8368059713841016d), new NpgsqlTypes.NpgsqlPoint(x: 0.893120730441898d, y: 0.8250304852258453d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914859131993219d, y: 0.446466106067097d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38308834033683614d, y: 0.9691799623610238d), new NpgsqlTypes.NpgsqlPoint(x: 0.121552223903729d, y: 0.6573082928521905d), new NpgsqlTypes.NpgsqlPoint(x: 0.21723332223773573d, y: 0.13208453676699738d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5850230676009256d, y: 0.32657702137995004d), new NpgsqlTypes.NpgsqlPoint(x: 0.5004277915703249d, y: 0.3421118576014338d), new NpgsqlTypes.NpgsqlPoint(x: 0.6621437616861787d, y: 0.019090013664494476d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15197809533074746d, y: 0.2696800492514554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586834694880529d, y: 0.19551456476918494d), new NpgsqlTypes.NpgsqlPoint(x: 0.08099175356889843d, y: 0.5115232933791074d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11474893897651695d, y: 0.4003886308918725d), new NpgsqlTypes.NpgsqlPoint(x: 0.2951140180036874d, y: 0.24272100534211405d), new NpgsqlTypes.NpgsqlPoint(x: 0.24400524394228706d, y: 0.6044298030345576d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9655864674534893d, y: 0.4480630029774596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5437499333177158d, y: 0.04214381593741778d), new NpgsqlTypes.NpgsqlPoint(x: 0.9620196584222588d, y: 0.0718365085486089d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7875532599880675d, y: 0.27931942263314047d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286221075248255d, y: 0.4591186542682756d), new NpgsqlTypes.NpgsqlPoint(x: 0.47079328237662255d, y: 0.47907333068370295d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.110898462448912d, y: 0.759288356174536d), new NpgsqlTypes.NpgsqlPoint(x: 0.38069124490381157d, y: 0.15678245856837048d), new NpgsqlTypes.NpgsqlPoint(x: 0.21639415651484306d, y: 0.8872635582306208d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5367214413732576d, y: 0.6572371905901992d), new NpgsqlTypes.NpgsqlPoint(x: 0.02085519284711923d, y: 0.9080069092872739d), new NpgsqlTypes.NpgsqlPoint(x: 0.8359348995889296d, y: 0.5324769718080465d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5812918919939698d, y: 0.30583801311876524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9760275621360507d, y: 0.8201377361781286d), new NpgsqlTypes.NpgsqlPoint(x: 0.0962261338666075d, y: 0.8472505125768259d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0469424456806411d, y: 0.8135833159376311d), new NpgsqlTypes.NpgsqlPoint(x: 0.3662018951352465d, y: 0.8405920298888002d), new NpgsqlTypes.NpgsqlPoint(x: 0.4366452705004136d, y: 0.6618522929702215d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((195)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7535602363714134d, y: 0.9561362134502941d), new NpgsqlTypes.NpgsqlPoint(x: 0.002318721599961271d, y: 0.04952573816160133d), new NpgsqlTypes.NpgsqlPoint(x: 0.9953460389251305d, y: 0.7744205602076087d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8489773438813952d, y: 0.7207479912593353d), new NpgsqlTypes.NpgsqlPoint(x: 0.44114103138637584d, y: 0.5418130564009151d), new NpgsqlTypes.NpgsqlPoint(x: 0.9737360567382023d, y: 0.3962576132419663d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9843426595469473d, y: 0.13875500724285106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6020130918690342d, y: 0.4278629900123292d), new NpgsqlTypes.NpgsqlPoint(x: 0.3177837916082812d, y: 0.9768426776640327d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((200)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3117541108649968d, y: 0.6473682177595231d), new NpgsqlTypes.NpgsqlPoint(x: 0.09056816755948238d, y: 0.043694889507898904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8743746824215424d, y: 0.46163708147517724d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
FROM public.binary_npgsqlpolygonpolygone0m m
LEFT JOIN public.binary_npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA), typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA), typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI), typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygonE0MI>();
                var models2 = new List<NpgsqlPolygonpolygonE0MI>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MI>();
                var models2 = new List<NpgsqlPolygonpolygonE0MI>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA), typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

