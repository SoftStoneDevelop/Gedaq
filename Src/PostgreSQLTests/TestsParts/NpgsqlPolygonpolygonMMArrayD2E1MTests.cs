

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
    internal partial interface INpgsqlPolygonMArraypolygonMMArrayD2
    {
    }
    
    internal partial class NpgsqlPolygonMArraypolygonMMArrayD2 : INpgsqlPolygonMArraypolygonMMArrayD2
    {


#region TestData

        private readonly NpgsqlPolygonpolygonMMArrayD2E1M[] _testData = new NpgsqlPolygonpolygonMMArrayD2E1M[]
        {
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7264140493399689d, y: 0.18099656197024638d), new NpgsqlTypes.NpgsqlPoint(x: 0.8448361392868756d, y: 0.9562605116361746d), new NpgsqlTypes.NpgsqlPoint(x: 0.1527321243120413d, y: 0.40054275563884334d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3311866756975913d, y: 0.9181262165222033d), new NpgsqlTypes.NpgsqlPoint(x: 0.018678987602795405d, y: 0.39316317764016784d), new NpgsqlTypes.NpgsqlPoint(x: 0.8837198769917222d, y: 0.6242274910858886d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02492893869674928d, y: 0.6763675729828508d), new NpgsqlTypes.NpgsqlPoint(x: 0.1931698798162984d, y: 0.835036239293154d), new NpgsqlTypes.NpgsqlPoint(x: 0.0579233088365968d, y: 0.6016057529948785d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.384604082026092d, y: 0.7655978594214081d), new NpgsqlTypes.NpgsqlPoint(x: 0.2501068585767966d, y: 0.18913713129018783d), new NpgsqlTypes.NpgsqlPoint(x: 0.5589458301576047d, y: 0.8202535699013886d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18866479067692277d, y: 0.14316885643661326d), new NpgsqlTypes.NpgsqlPoint(x: 0.667914657356278d, y: 0.3741342523873702d), new NpgsqlTypes.NpgsqlPoint(x: 0.5133285710481552d, y: 0.5968824175493979d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4517967758864131d, y: 0.504595634921314d), new NpgsqlTypes.NpgsqlPoint(x: 0.640744228832598d, y: 0.35933987254862665d), new NpgsqlTypes.NpgsqlPoint(x: 0.7444172498094509d, y: 0.904319527792464d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6832741550098874d, y: 0.8234643497580948d), new NpgsqlTypes.NpgsqlPoint(x: 0.44162306125484374d, y: 0.1046644269923257d), new NpgsqlTypes.NpgsqlPoint(x: 0.5545960362801069d, y: 0.9254613270923571d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.723829278311966d, y: 0.7429387034988175d), new NpgsqlTypes.NpgsqlPoint(x: 0.9147265746860203d, y: 0.6844884131148609d), new NpgsqlTypes.NpgsqlPoint(x: 0.8256818148362893d, y: 0.9800983707191678d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5579892919554799d, y: 0.8078369673190351d), new NpgsqlTypes.NpgsqlPoint(x: 0.9202581735766294d, y: 0.8195703526314135d), new NpgsqlTypes.NpgsqlPoint(x: 0.646594784024579d, y: 0.9510760918087026d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7057826011519592d, y: 0.7281636832056769d), new NpgsqlTypes.NpgsqlPoint(x: 0.9818587764830456d, y: 0.9547468783312478d), new NpgsqlTypes.NpgsqlPoint(x: 0.9885554658588612d, y: 0.4404675226587731d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5367113465102757d, y: 0.16787094549431314d), new NpgsqlTypes.NpgsqlPoint(x: 0.16699418143167466d, y: 0.9989659270502644d), new NpgsqlTypes.NpgsqlPoint(x: 0.2554527395165991d, y: 0.02767767407923538d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8557446437558728d, y: 0.031480318906963234d), new NpgsqlTypes.NpgsqlPoint(x: 0.20443739298961505d, y: 0.38187750918633023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9555374411510642d, y: 0.9887650840172063d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07472762932312127d, y: 0.42849102454944066d), new NpgsqlTypes.NpgsqlPoint(x: 0.6073424617776699d, y: 0.5763882767038906d), new NpgsqlTypes.NpgsqlPoint(x: 0.75961784593629d, y: 0.6647668790477755d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.667950967191817d, y: 0.9156870212326285d), new NpgsqlTypes.NpgsqlPoint(x: 0.13553425457183665d, y: 0.01694578890927323d), new NpgsqlTypes.NpgsqlPoint(x: 0.0994271008612666d, y: 0.6102077551623809d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.044355026496238126d, y: 0.44286275108713946d), new NpgsqlTypes.NpgsqlPoint(x: 0.1387178827666521d, y: 0.9181300255491307d), new NpgsqlTypes.NpgsqlPoint(x: 0.9681100297353494d, y: 0.668965723034746d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36699045002446584d, y: 0.03145028518631976d), new NpgsqlTypes.NpgsqlPoint(x: 0.6642971512360808d, y: 0.4363371038935533d), new NpgsqlTypes.NpgsqlPoint(x: 0.332961146047249d, y: 0.18159656332710195d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6436185000304051d, y: 0.1390236266642083d), new NpgsqlTypes.NpgsqlPoint(x: 0.6743450987645461d, y: 0.2493103302925901d), new NpgsqlTypes.NpgsqlPoint(x: 0.746096053885326d, y: 0.09490130550821896d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.814392856813087d, y: 0.3187610879478754d), new NpgsqlTypes.NpgsqlPoint(x: 0.16533497942379394d, y: 0.9130407323506772d), new NpgsqlTypes.NpgsqlPoint(x: 0.5636280280977505d, y: 0.23164397184827368d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07565813477633365d, y: 0.1591923041019746d), new NpgsqlTypes.NpgsqlPoint(x: 0.7467162969794598d, y: 0.8747157592200178d), new NpgsqlTypes.NpgsqlPoint(x: 0.17705988176841203d, y: 0.07553125370825464d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6009076857784186d, y: 0.4456350515953623d), new NpgsqlTypes.NpgsqlPoint(x: 0.10733455418153792d, y: 0.48684307052066567d), new NpgsqlTypes.NpgsqlPoint(x: 0.9822953205617911d, y: 0.7584857583879577d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.055643513178325166d, y: 0.23849946047216086d), new NpgsqlTypes.NpgsqlPoint(x: 0.6367131287993635d, y: 0.1414808552480913d), new NpgsqlTypes.NpgsqlPoint(x: 0.0012398234302986033d, y: 0.46245648648750715d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06131368186188002d, y: 0.1866092277174335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6986753673018825d, y: 0.13360022203755495d), new NpgsqlTypes.NpgsqlPoint(x: 0.0038689189318937833d, y: 0.13476931829383276d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8105346548674057d, y: 0.8206629001112828d), new NpgsqlTypes.NpgsqlPoint(x: 0.9761427782124826d, y: 0.5874121507509873d), new NpgsqlTypes.NpgsqlPoint(x: 0.08849894920884327d, y: 0.6263115728681367d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9997527304424042d, y: 0.049086298767837766d), new NpgsqlTypes.NpgsqlPoint(x: 0.1276040280703109d, y: 0.4080318605580766d), new NpgsqlTypes.NpgsqlPoint(x: 0.7861716933635544d, y: 0.9443975515266955d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4454290757563103d, y: 0.7329233650890506d), new NpgsqlTypes.NpgsqlPoint(x: 0.6880323531990457d, y: 0.9389269002276807d), new NpgsqlTypes.NpgsqlPoint(x: 0.23837261546623845d, y: 0.486480575822107d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4772413052760751d, y: 0.5473033112494254d), new NpgsqlTypes.NpgsqlPoint(x: 0.23190269041667022d, y: 0.9216048554756187d), new NpgsqlTypes.NpgsqlPoint(x: 0.21989754023131125d, y: 0.5257473287513481d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9997174121377004d, y: 0.15597644119825427d), new NpgsqlTypes.NpgsqlPoint(x: 0.2049534241318305d, y: 0.5840095864645851d), new NpgsqlTypes.NpgsqlPoint(x: 0.6647353468813312d, y: 0.18174035220942986d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4528325050480053d, y: 0.2682156028865539d), new NpgsqlTypes.NpgsqlPoint(x: 0.49293961706470735d, y: 0.9399568970818816d), new NpgsqlTypes.NpgsqlPoint(x: 0.9563991149545898d, y: 0.8016235842808273d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16025371038490843d, y: 0.2916204728991022d), new NpgsqlTypes.NpgsqlPoint(x: 0.5754837320621813d, y: 0.6610172003133498d), new NpgsqlTypes.NpgsqlPoint(x: 0.4397576443550232d, y: 0.381827529291476d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19447200691500688d, y: 0.5680960384763282d), new NpgsqlTypes.NpgsqlPoint(x: 0.4709740370308585d, y: 0.7610784041454403d), new NpgsqlTypes.NpgsqlPoint(x: 0.19699585423176724d, y: 0.20231053322114645d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25656686544883534d, y: 0.7823522432655463d), new NpgsqlTypes.NpgsqlPoint(x: 0.3825801462192706d, y: 0.5245344908893445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9377419402024001d, y: 0.46725348813895506d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5831054183492623d, y: 0.91912508923021d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455811675796866d, y: 0.3517662906005926d), new NpgsqlTypes.NpgsqlPoint(x: 0.9431769344293909d, y: 0.9631586685643263d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18604039810256834d, y: 0.1625637732502322d), new NpgsqlTypes.NpgsqlPoint(x: 0.8081978287779412d, y: 0.042088063512932594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982079515460588d, y: 0.6009167869767486d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4638063784893608d, y: 0.14785767120793036d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848419447284792d, y: 0.523351131089615d), new NpgsqlTypes.NpgsqlPoint(x: 0.392146615706247d, y: 0.2519945938167524d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4388768256335932d, y: 0.19996868315966376d), new NpgsqlTypes.NpgsqlPoint(x: 0.4749778700308548d, y: 0.48203567568909855d), new NpgsqlTypes.NpgsqlPoint(x: 0.4062463775794415d, y: 0.6418909964606507d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05177021240018009d, y: 0.9352961220090334d), new NpgsqlTypes.NpgsqlPoint(x: 0.25928142630900597d, y: 0.6842748029986706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9277322697076975d, y: 0.6301562843844469d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9901986969054579d, y: 0.6406236246710727d), new NpgsqlTypes.NpgsqlPoint(x: 0.9636886503393693d, y: 0.9407632026827961d), new NpgsqlTypes.NpgsqlPoint(x: 0.3163010898070783d, y: 0.6754776657162833d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7318272763615725d, y: 0.6145932964395665d), new NpgsqlTypes.NpgsqlPoint(x: 0.6752566686742418d, y: 0.6906844534717542d), new NpgsqlTypes.NpgsqlPoint(x: 0.14581344175067046d, y: 0.08806122377120973d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1721123193870565d, y: 0.05930400266980651d), new NpgsqlTypes.NpgsqlPoint(x: 0.8816318403012222d, y: 0.6143878683329841d), new NpgsqlTypes.NpgsqlPoint(x: 0.1867958417895551d, y: 0.8489660257318773d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8275884874930157d, y: 0.5915491013600429d), new NpgsqlTypes.NpgsqlPoint(x: 0.454676745527014d, y: 0.5159043197950448d), new NpgsqlTypes.NpgsqlPoint(x: 0.13932926857863637d, y: 0.9914046689285425d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0553289537214775d, y: 0.1816132490519492d), new NpgsqlTypes.NpgsqlPoint(x: 0.3447588781105252d, y: 0.5460662638698293d), new NpgsqlTypes.NpgsqlPoint(x: 0.48528023533872666d, y: 0.1510139983284695d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4057857643720668d, y: 0.7298605460059626d), new NpgsqlTypes.NpgsqlPoint(x: 0.7166579702212343d, y: 0.7171893906092642d), new NpgsqlTypes.NpgsqlPoint(x: 0.7199559490074249d, y: 0.625705294007067d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9284029180358689d, y: 0.04770850224571499d), new NpgsqlTypes.NpgsqlPoint(x: 0.09677230391101721d, y: 0.14391027186151506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8758968070127956d, y: 0.7221858264822071d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3118991236609796d, y: 0.29955365629604147d), new NpgsqlTypes.NpgsqlPoint(x: 0.9179084911801995d, y: 0.7452472550320589d), new NpgsqlTypes.NpgsqlPoint(x: 0.13068018234897605d, y: 0.24646907016029518d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0353123335574842d, y: 0.49190025757805655d), new NpgsqlTypes.NpgsqlPoint(x: 0.589296882135672d, y: 0.9909618279978727d), new NpgsqlTypes.NpgsqlPoint(x: 0.3617356396648099d, y: 0.17144021977261215d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.820236220304854d, y: 0.19675944332911843d), new NpgsqlTypes.NpgsqlPoint(x: 0.9107143842078192d, y: 0.694096995775429d), new NpgsqlTypes.NpgsqlPoint(x: 0.6035484933766759d, y: 0.6726480591732602d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8566561174517178d, y: 0.41945905755025614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194380900723001d, y: 0.8367323826255298d), new NpgsqlTypes.NpgsqlPoint(x: 0.32450874187481027d, y: 0.11225334396131992d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8962389224229036d, y: 0.0644803204897717d), new NpgsqlTypes.NpgsqlPoint(x: 0.6622491284975777d, y: 0.15955349738379443d), new NpgsqlTypes.NpgsqlPoint(x: 0.15557643480159633d, y: 0.7641451158102807d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7063413970218513d, y: 0.9699755566153008d), new NpgsqlTypes.NpgsqlPoint(x: 0.5596260275515679d, y: 0.817381449889443d), new NpgsqlTypes.NpgsqlPoint(x: 0.9129691956183854d, y: 0.7261664792195771d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5751430379520105d, y: 0.3729518569511945d), new NpgsqlTypes.NpgsqlPoint(x: 0.32377942186820763d, y: 0.1866584075508596d), new NpgsqlTypes.NpgsqlPoint(x: 0.9303591088792225d, y: 0.7272380882476728d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01445087070227069d, y: 0.5269392008753971d), new NpgsqlTypes.NpgsqlPoint(x: 0.17521407452937032d, y: 0.7095597564668806d), new NpgsqlTypes.NpgsqlPoint(x: 0.6142105114671165d, y: 0.43782731727558755d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33649690358538953d, y: 0.08530177959414431d), new NpgsqlTypes.NpgsqlPoint(x: 0.439074471003851d, y: 0.4950455389401739d), new NpgsqlTypes.NpgsqlPoint(x: 0.6158901839129108d, y: 0.4848741744450604d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8201024742509047d, y: 0.7995065823806256d), new NpgsqlTypes.NpgsqlPoint(x: 0.8490679075199914d, y: 0.7258187875956493d), new NpgsqlTypes.NpgsqlPoint(x: 0.02884572631532467d, y: 0.0682427701625542d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.960096711243478d, y: 0.8309705996109019d), new NpgsqlTypes.NpgsqlPoint(x: 0.350919020059261d, y: 0.49163985798472654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8615454331038852d, y: 0.5784140583644675d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6286545186366022d, y: 0.021635835956253735d), new NpgsqlTypes.NpgsqlPoint(x: 0.6427739691413706d, y: 0.08032616805542048d), new NpgsqlTypes.NpgsqlPoint(x: 0.3968864214689264d, y: 0.42001992973279845d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6530121108279199d, y: 0.8656614796406827d), new NpgsqlTypes.NpgsqlPoint(x: 0.004845009367769548d, y: 0.7726349528906787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9643295284504845d, y: 0.5674570457873859d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8973901043041064d, y: 0.3538498216277217d), new NpgsqlTypes.NpgsqlPoint(x: 0.15303564578661d, y: 0.20859733554784532d), new NpgsqlTypes.NpgsqlPoint(x: 0.998797164547442d, y: 0.6140096842614253d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25852164852611403d, y: 0.5231156441803484d), new NpgsqlTypes.NpgsqlPoint(x: 0.013808533220967645d, y: 0.05250041185370247d), new NpgsqlTypes.NpgsqlPoint(x: 0.13051487911734372d, y: 0.4585648903484123d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7961844877638922d, y: 0.3892460924359259d), new NpgsqlTypes.NpgsqlPoint(x: 0.47536698454112836d, y: 0.3709739174327109d), new NpgsqlTypes.NpgsqlPoint(x: 0.42382335230518775d, y: 0.17447521921467912d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28621555670443966d, y: 0.6881406052868672d), new NpgsqlTypes.NpgsqlPoint(x: 0.21245931007986563d, y: 0.1315659632283881d), new NpgsqlTypes.NpgsqlPoint(x: 0.0539651761457256d, y: 0.5526304340530063d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19988943027327288d, y: 0.08752828606692864d), new NpgsqlTypes.NpgsqlPoint(x: 0.42656149127985843d, y: 0.7856216511928842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8411230900177865d, y: 0.6041254067925713d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2490723883606869d, y: 0.7629652818056878d), new NpgsqlTypes.NpgsqlPoint(x: 0.9231585083730435d, y: 0.47540280783134903d), new NpgsqlTypes.NpgsqlPoint(x: 0.6534714627353942d, y: 0.040211328790893175d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8322609968780639d, y: 0.48531081515451646d), new NpgsqlTypes.NpgsqlPoint(x: 0.3928505933284713d, y: 0.6800982379435654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8253727694869478d, y: 0.120337682645281d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.814688726380302d, y: 0.08662212049204276d), new NpgsqlTypes.NpgsqlPoint(x: 0.5710200986521451d, y: 0.3519482243996248d), new NpgsqlTypes.NpgsqlPoint(x: 0.4571338671153383d, y: 0.7814251062397439d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005521462601944971d, y: 0.6880818954571671d), new NpgsqlTypes.NpgsqlPoint(x: 0.5086021175430404d, y: 0.36678823177776754d), new NpgsqlTypes.NpgsqlPoint(x: 0.42050714810948464d, y: 0.5824573818471003d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0056682156155211105d, y: 0.8763428317337426d), new NpgsqlTypes.NpgsqlPoint(x: 0.7540200512995872d, y: 0.3811937501244108d), new NpgsqlTypes.NpgsqlPoint(x: 0.25767301266126574d, y: 0.6640106551401753d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3940687458285135d, y: 0.9449797037314597d), new NpgsqlTypes.NpgsqlPoint(x: 0.8200482365823841d, y: 0.6638120773342865d), new NpgsqlTypes.NpgsqlPoint(x: 0.45233553464267995d, y: 0.9709695173785846d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8091370066653317d, y: 0.5936800757757884d), new NpgsqlTypes.NpgsqlPoint(x: 0.7779724683655962d, y: 0.6200581181748426d), new NpgsqlTypes.NpgsqlPoint(x: 0.9813529563699808d, y: 0.03711555559229063d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35291265701341945d, y: 0.3903938929003682d), new NpgsqlTypes.NpgsqlPoint(x: 0.15583103096030027d, y: 0.15263005255959317d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623217561432375d, y: 0.8698575533575943d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8758083132272028d, y: 0.7756774057705107d), new NpgsqlTypes.NpgsqlPoint(x: 0.5509657554774527d, y: 0.7015182087111188d), new NpgsqlTypes.NpgsqlPoint(x: 0.8044873735323682d, y: 0.6519223865945263d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7482505184114189d, y: 0.23651187987287714d), new NpgsqlTypes.NpgsqlPoint(x: 0.9321299649550524d, y: 0.7806108689626999d), new NpgsqlTypes.NpgsqlPoint(x: 0.857214780415706d, y: 0.3357178490312581d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9861794062794575d, y: 0.23511174523089307d), new NpgsqlTypes.NpgsqlPoint(x: 0.5458788146573815d, y: 0.32307640337457444d), new NpgsqlTypes.NpgsqlPoint(x: 0.0819322703943256d, y: 0.484188448531366d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8784029518829064d, y: 0.07331722128224805d), new NpgsqlTypes.NpgsqlPoint(x: 0.610670986591844d, y: 0.2944333805657784d), new NpgsqlTypes.NpgsqlPoint(x: 0.0944723184926366d, y: 0.9430919015836823d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1926980986982837d, y: 0.5026968218808879d), new NpgsqlTypes.NpgsqlPoint(x: 0.10717179747334171d, y: 0.06293271250073751d), new NpgsqlTypes.NpgsqlPoint(x: 0.0745642244506538d, y: 0.4760520458839953d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.487105261086053d, y: 0.6582360951934413d), new NpgsqlTypes.NpgsqlPoint(x: 0.3803939338065194d, y: 0.4005524290587009d), new NpgsqlTypes.NpgsqlPoint(x: 0.4841267845895567d, y: 0.8952249868313361d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2980580821760662d, y: 0.2056192028026287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9884725693672256d, y: 0.45332284789686583d), new NpgsqlTypes.NpgsqlPoint(x: 0.8483147413321883d, y: 0.7022385107666886d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6441889005822371d, y: 0.23463614995837445d), new NpgsqlTypes.NpgsqlPoint(x: 0.10343692317859476d, y: 0.6807445957497421d), new NpgsqlTypes.NpgsqlPoint(x: 0.06601170605057605d, y: 0.9951738396880228d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9037416061799733d, y: 0.26853661019599506d), new NpgsqlTypes.NpgsqlPoint(x: 0.917024559432196d, y: 0.7929346174197246d), new NpgsqlTypes.NpgsqlPoint(x: 0.40481143351432713d, y: 0.14103277470866937d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8453211486192873d, y: 0.22283566785220832d), new NpgsqlTypes.NpgsqlPoint(x: 0.7600823439243553d, y: 0.48410461110756076d), new NpgsqlTypes.NpgsqlPoint(x: 0.9107867596597209d, y: 0.47904143681342215d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6111637119089725d, y: 0.297537685584237d), new NpgsqlTypes.NpgsqlPoint(x: 0.2662975923262243d, y: 0.7384833693701602d), new NpgsqlTypes.NpgsqlPoint(x: 0.4611312023352424d, y: 0.723640160299838d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7492643814937479d, y: 0.31607777459886455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4974156208693269d, y: 0.7508114200332778d), new NpgsqlTypes.NpgsqlPoint(x: 0.963540604280513d, y: 0.7911638990835486d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2879291384319227d, y: 0.36253386519041986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5086122231425523d, y: 0.9701609741139539d), new NpgsqlTypes.NpgsqlPoint(x: 0.8342014578603901d, y: 0.7313585946081458d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33879280205100604d, y: 0.6510001717473857d), new NpgsqlTypes.NpgsqlPoint(x: 0.7926333086937147d, y: 0.808553403165277d), new NpgsqlTypes.NpgsqlPoint(x: 0.983722288863016d, y: 0.5548867618366935d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9006067014712325d, y: 0.770672482053496d), new NpgsqlTypes.NpgsqlPoint(x: 0.15944204260175332d, y: 0.3872802589027533d), new NpgsqlTypes.NpgsqlPoint(x: 0.9702642453352766d, y: 0.08770610129427059d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.338026542222459d, y: 0.534910490633529d), new NpgsqlTypes.NpgsqlPoint(x: 0.3448408884441281d, y: 0.004769181079232854d), new NpgsqlTypes.NpgsqlPoint(x: 0.27760159835405884d, y: 0.5742242497728435d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34542607104945966d, y: 0.09770957835962679d), new NpgsqlTypes.NpgsqlPoint(x: 0.5474705232535549d, y: 0.1538228870551379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6104667137227717d, y: 0.05373254418820894d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16198582972532904d, y: 0.12385496354173275d), new NpgsqlTypes.NpgsqlPoint(x: 0.008575211297045304d, y: 0.6536873648955007d), new NpgsqlTypes.NpgsqlPoint(x: 0.10175307883538176d, y: 0.7481256905722649d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4456190584754731d, y: 0.4942055700635075d), new NpgsqlTypes.NpgsqlPoint(x: 0.45760950666927247d, y: 0.8594268783133151d), new NpgsqlTypes.NpgsqlPoint(x: 0.8625963805507548d, y: 0.5217178003777767d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20116192057757887d, y: 0.8165189744341965d), new NpgsqlTypes.NpgsqlPoint(x: 0.25982756968250087d, y: 0.9384405382805715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5248868737223846d, y: 0.09948829539700788d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9488530278948198d, y: 0.007124150986102862d), new NpgsqlTypes.NpgsqlPoint(x: 0.23730082598073998d, y: 0.5991254526541893d), new NpgsqlTypes.NpgsqlPoint(x: 0.5362923169035131d, y: 0.5645202947059849d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2882196715715247d, y: 0.23638022916305146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079593114326685d, y: 0.45885377932301075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9248711372523105d, y: 0.9950363625517826d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25624090720696946d, y: 0.7215562077085269d), new NpgsqlTypes.NpgsqlPoint(x: 0.062370626789939765d, y: 0.45635529255140816d), new NpgsqlTypes.NpgsqlPoint(x: 0.1307524703708255d, y: 0.5107535673559399d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4992643154685721d, y: 0.7160363905044509d), new NpgsqlTypes.NpgsqlPoint(x: 0.80225477111743d, y: 0.29550777160659913d), new NpgsqlTypes.NpgsqlPoint(x: 0.03853121649700986d, y: 0.281606497531636d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1993135462368233d, y: 0.9611180851405813d), new NpgsqlTypes.NpgsqlPoint(x: 0.25830197354797824d, y: 0.5424134681140989d), new NpgsqlTypes.NpgsqlPoint(x: 0.5234687858967834d, y: 0.3986035633470495d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.377834828786889d, y: 0.04292984960361623d), new NpgsqlTypes.NpgsqlPoint(x: 0.3802213307862432d, y: 0.08032738522286287d), new NpgsqlTypes.NpgsqlPoint(x: 0.26157111309848735d, y: 0.008116282493445315d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33026608753077913d, y: 0.2207891385513543d), new NpgsqlTypes.NpgsqlPoint(x: 0.9716872509565782d, y: 0.11089703788674132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328426193764068d, y: 0.3154280211304321d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7586906875922709d, y: 0.32161767110966566d), new NpgsqlTypes.NpgsqlPoint(x: 0.4986538408165623d, y: 0.14927244242473958d), new NpgsqlTypes.NpgsqlPoint(x: 0.7174665380370778d, y: 0.23698548251614604d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9964146773761569d, y: 0.39395869737625777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7529190837237801d, y: 0.8378221088849995d), new NpgsqlTypes.NpgsqlPoint(x: 0.44746834206713126d, y: 0.4434106525009639d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3818657919456335d, y: 0.4895106734950614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7934427561529163d, y: 0.10956690692809157d), new NpgsqlTypes.NpgsqlPoint(x: 0.1532696023384169d, y: 0.4190050205300193d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11117069204140784d, y: 0.9588106043022037d), new NpgsqlTypes.NpgsqlPoint(x: 0.049107471022010296d, y: 0.07441192683766218d), new NpgsqlTypes.NpgsqlPoint(x: 0.22627316194019997d, y: 0.1691572749688245d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3499482389159605d, y: 0.256563844521441d), new NpgsqlTypes.NpgsqlPoint(x: 0.8608863186448114d, y: 0.5256481198659654d), new NpgsqlTypes.NpgsqlPoint(x: 0.49527486399959153d, y: 0.9409096944609082d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14925735639589788d, y: 0.09801659009369024d), new NpgsqlTypes.NpgsqlPoint(x: 0.8991037843944001d, y: 0.23235802031761355d), new NpgsqlTypes.NpgsqlPoint(x: 0.2716713728096669d, y: 0.8518000753857293d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6646047200880116d, y: 0.6098343457398184d), new NpgsqlTypes.NpgsqlPoint(x: 0.6341970659874702d, y: 0.8009256486469117d), new NpgsqlTypes.NpgsqlPoint(x: 0.584668214521242d, y: 0.4222080428279995d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.671570595631468d, y: 0.07970418071714735d), new NpgsqlTypes.NpgsqlPoint(x: 0.28720918871771906d, y: 0.43239148990354404d), new NpgsqlTypes.NpgsqlPoint(x: 0.6907905550100921d, y: 0.0675986028986435d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0096274136688963d, y: 0.4556812357084933d), new NpgsqlTypes.NpgsqlPoint(x: 0.7587545243899217d, y: 0.7938686350145598d), new NpgsqlTypes.NpgsqlPoint(x: 0.954862123101687d, y: 0.8284038312538077d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5773325030518462d, y: 0.4897649964718307d), new NpgsqlTypes.NpgsqlPoint(x: 0.9545613907427601d, y: 0.4201251356483784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987966500344241d, y: 0.8310937680571402d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7036867748559028d, y: 0.018136535760478578d), new NpgsqlTypes.NpgsqlPoint(x: 0.9768658838418078d, y: 0.551227003012739d), new NpgsqlTypes.NpgsqlPoint(x: 0.8392569910016996d, y: 0.3558873403475691d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43915205916752076d, y: 0.7767947550151983d), new NpgsqlTypes.NpgsqlPoint(x: 0.434725305320003d, y: 0.5154002389255752d), new NpgsqlTypes.NpgsqlPoint(x: 0.5738720713948209d, y: 0.06235650276146332d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08747518403147514d, y: 0.6286278330529981d), new NpgsqlTypes.NpgsqlPoint(x: 0.9092989418048454d, y: 0.7876566552075328d), new NpgsqlTypes.NpgsqlPoint(x: 0.1844450905384527d, y: 0.4101125261835944d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25780986547854834d, y: 0.9758500881048078d), new NpgsqlTypes.NpgsqlPoint(x: 0.6254516183142542d, y: 0.12869087183113037d), new NpgsqlTypes.NpgsqlPoint(x: 0.9743860878825097d, y: 0.889923943362797d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.952314797858175d, y: 0.30101650999640406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9770096580286305d, y: 0.5200990671310053d), new NpgsqlTypes.NpgsqlPoint(x: 0.27770224702756985d, y: 0.02361711256533383d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6629444347938017d, y: 0.3740401573926604d), new NpgsqlTypes.NpgsqlPoint(x: 0.21229569104102242d, y: 0.19862772572794507d), new NpgsqlTypes.NpgsqlPoint(x: 0.32011736805004465d, y: 0.8791566093890073d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17643505260107817d, y: 0.22061206310625947d), new NpgsqlTypes.NpgsqlPoint(x: 0.39610160874980527d, y: 0.8567657024965287d), new NpgsqlTypes.NpgsqlPoint(x: 0.3434803061395514d, y: 0.9555202913086357d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9990293621652871d, y: 0.0539634319787613d), new NpgsqlTypes.NpgsqlPoint(x: 0.5870259353018036d, y: 0.7411502661105541d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481976825272711d, y: 0.9625849212576699d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9614914278945904d, y: 0.9536417165251496d), new NpgsqlTypes.NpgsqlPoint(x: 0.1335452593402392d, y: 0.08350389821258786d), new NpgsqlTypes.NpgsqlPoint(x: 0.18642464393415115d, y: 0.3740551268689918d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7601458996257933d, y: 0.5798916536290185d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668496192540478d, y: 0.8289172068072063d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432974749322732d, y: 0.16267159685288002d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5984385591823678d, y: 0.07379116874148728d), new NpgsqlTypes.NpgsqlPoint(x: 0.7897799802959623d, y: 0.5599015209042577d), new NpgsqlTypes.NpgsqlPoint(x: 0.0969114518424874d, y: 0.801439894167104d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4962115598690927d, y: 0.24916340669189618d), new NpgsqlTypes.NpgsqlPoint(x: 0.42112002705553364d, y: 0.9438103479824959d), new NpgsqlTypes.NpgsqlPoint(x: 0.6420069713703562d, y: 0.5919140940582629d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49358596568763735d, y: 0.10380102973454719d), new NpgsqlTypes.NpgsqlPoint(x: 0.022274432534838073d, y: 0.11494269737625151d), new NpgsqlTypes.NpgsqlPoint(x: 0.42062303444129745d, y: 0.7289123936480493d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9414546420407073d, y: 0.0663096436183499d), new NpgsqlTypes.NpgsqlPoint(x: 0.9012961863793253d, y: 0.6874228106947645d), new NpgsqlTypes.NpgsqlPoint(x: 0.1321313304435996d, y: 0.30074652659516865d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6165415875884854d, y: 0.8412100923294472d), new NpgsqlTypes.NpgsqlPoint(x: 0.6271453212507472d, y: 0.03676556652711627d), new NpgsqlTypes.NpgsqlPoint(x: 0.4242410087112237d, y: 0.6546901815571633d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6123377371535804d, y: 0.6114480403499748d), new NpgsqlTypes.NpgsqlPoint(x: 0.316880511253135d, y: 0.23685362565709478d), new NpgsqlTypes.NpgsqlPoint(x: 0.1572603756793196d, y: 0.35379550323096864d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6419001911484429d, y: 0.07450832145005637d), new NpgsqlTypes.NpgsqlPoint(x: 0.11873626470220722d, y: 0.49984884416961517d), new NpgsqlTypes.NpgsqlPoint(x: 0.04385296692111196d, y: 0.7834331277321748d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0374240447689681d, y: 0.566678589628603d), new NpgsqlTypes.NpgsqlPoint(x: 0.7027931181516343d, y: 0.5872924098431159d), new NpgsqlTypes.NpgsqlPoint(x: 0.06587627442626887d, y: 0.12171682755613522d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7561008666291493d, y: 0.9165369047193846d), new NpgsqlTypes.NpgsqlPoint(x: 0.5256995291459744d, y: 0.3899919936309555d), new NpgsqlTypes.NpgsqlPoint(x: 0.9259778845955583d, y: 0.5396824973158564d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3885525419875132d, y: 0.41675720434009245d), new NpgsqlTypes.NpgsqlPoint(x: 0.008099153576935136d, y: 0.026923098541774104d), new NpgsqlTypes.NpgsqlPoint(x: 0.26887763211961124d, y: 0.03842427088144518d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4845127128208716d, y: 0.4885051579183983d), new NpgsqlTypes.NpgsqlPoint(x: 0.6949158974221485d, y: 0.7049986282320471d), new NpgsqlTypes.NpgsqlPoint(x: 0.7446898736232581d, y: 0.9692056801636967d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3109585014237394d, y: 0.3111036030076718d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138230183029846d, y: 0.4718622218412122d), new NpgsqlTypes.NpgsqlPoint(x: 0.9593307779787826d, y: 0.19453967775807757d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23934495993212912d, y: 0.3693211296882366d), new NpgsqlTypes.NpgsqlPoint(x: 0.4716236967843369d, y: 0.7873663096385117d), new NpgsqlTypes.NpgsqlPoint(x: 0.6354472811856805d, y: 0.3049195961926394d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.024714274379859735d, y: 0.7772694045692933d), new NpgsqlTypes.NpgsqlPoint(x: 0.20678096097959553d, y: 0.36983527016506623d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663599810947289d, y: 0.5437844803702068d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.057603005052657474d, y: 0.9699587559602542d), new NpgsqlTypes.NpgsqlPoint(x: 0.629624505943128d, y: 0.024898711295236686d), new NpgsqlTypes.NpgsqlPoint(x: 0.3553696921775755d, y: 0.9091091423388755d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6891631113829052d, y: 0.34103568340595214d), new NpgsqlTypes.NpgsqlPoint(x: 0.925446704377894d, y: 0.3511497037282628d), new NpgsqlTypes.NpgsqlPoint(x: 0.5978299800770411d, y: 0.8706613115287611d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2895140377589177d, y: 0.28416033594564094d), new NpgsqlTypes.NpgsqlPoint(x: 0.2617155130477087d, y: 0.5682547840978915d), new NpgsqlTypes.NpgsqlPoint(x: 0.3731040199777764d, y: 0.19407360459785794d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23568229943622143d, y: 0.968020351592949d), new NpgsqlTypes.NpgsqlPoint(x: 0.7689583378665811d, y: 0.32022770610991513d), new NpgsqlTypes.NpgsqlPoint(x: 0.7934041165913923d, y: 0.26717008309188794d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.411645463433881d, y: 0.1457671846090589d), new NpgsqlTypes.NpgsqlPoint(x: 0.6689471461311003d, y: 0.3714165200072008d), new NpgsqlTypes.NpgsqlPoint(x: 0.3781498005451027d, y: 0.01936167035931846d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44827808197736874d, y: 0.34753716323371675d), new NpgsqlTypes.NpgsqlPoint(x: 0.28186233935051985d, y: 0.4581037136853219d), new NpgsqlTypes.NpgsqlPoint(x: 0.34971073244060613d, y: 0.7985279647551261d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8006415975638482d, y: 0.6906297286573663d), new NpgsqlTypes.NpgsqlPoint(x: 0.7064177954368941d, y: 0.603421738381988d), new NpgsqlTypes.NpgsqlPoint(x: 0.6469687297068656d, y: 0.9882589678191508d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8961942034701915d, y: 0.11275967922114949d), new NpgsqlTypes.NpgsqlPoint(x: 0.15086115574567727d, y: 0.005145091105454802d), new NpgsqlTypes.NpgsqlPoint(x: 0.9916180212951807d, y: 0.7864086348463728d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9543282245495881d, y: 0.8320647060154776d), new NpgsqlTypes.NpgsqlPoint(x: 0.4588032586033828d, y: 0.10215418350530214d), new NpgsqlTypes.NpgsqlPoint(x: 0.1819702654636537d, y: 0.6769513518235752d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24127342222185255d, y: 0.4321118702695729d), new NpgsqlTypes.NpgsqlPoint(x: 0.8600810550604435d, y: 0.6774332067437988d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292394645741944d, y: 0.7921844224145197d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4077067986148206d, y: 0.6531070143319709d), new NpgsqlTypes.NpgsqlPoint(x: 0.5330207769262766d, y: 0.47205526622019844d), new NpgsqlTypes.NpgsqlPoint(x: 0.20081628961687292d, y: 0.2350287453477461d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11026805381568605d, y: 0.8094315684561522d), new NpgsqlTypes.NpgsqlPoint(x: 0.35022202130829616d, y: 0.17562817378864926d), new NpgsqlTypes.NpgsqlPoint(x: 0.41186736595817963d, y: 0.12696305688758547d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8124811256541257d, y: 0.19609836689871984d), new NpgsqlTypes.NpgsqlPoint(x: 0.2758249431783334d, y: 0.4916769506168115d), new NpgsqlTypes.NpgsqlPoint(x: 0.19849677140808142d, y: 0.7408904404437839d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21385147724794973d, y: 0.23017494271622152d), new NpgsqlTypes.NpgsqlPoint(x: 0.5048620645092895d, y: 0.25473195614200606d), new NpgsqlTypes.NpgsqlPoint(x: 0.9490357049993571d, y: 0.6494377144259235d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.549676918368761d, y: 0.6611748027530899d), new NpgsqlTypes.NpgsqlPoint(x: 0.2477011435561931d, y: 0.42163359280293866d), new NpgsqlTypes.NpgsqlPoint(x: 0.4121677456913334d, y: 0.0817911167502996d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.570031650202595d, y: 0.37228170394850946d), new NpgsqlTypes.NpgsqlPoint(x: 0.3257779350118578d, y: 0.3500967513533636d), new NpgsqlTypes.NpgsqlPoint(x: 0.23368355098754345d, y: 0.9701174979820781d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5377738743199383d, y: 0.581775164441769d), new NpgsqlTypes.NpgsqlPoint(x: 0.17144935385548477d, y: 0.3690922310642557d), new NpgsqlTypes.NpgsqlPoint(x: 0.3496441198580095d, y: 0.7364633145123092d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.876676799670094d, y: 0.914914022507367d), new NpgsqlTypes.NpgsqlPoint(x: 0.506626703162687d, y: 0.3149068343580764d), new NpgsqlTypes.NpgsqlPoint(x: 0.755648501274766d, y: 0.5384359673401704d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10374282297581183d, y: 0.9952981235693147d), new NpgsqlTypes.NpgsqlPoint(x: 0.9045192865396191d, y: 0.6023252436103368d), new NpgsqlTypes.NpgsqlPoint(x: 0.9316985389856973d, y: 0.45543327980303006d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7664524923068272d, y: 0.3616156677932111d), new NpgsqlTypes.NpgsqlPoint(x: 0.20855241912748868d, y: 0.5406764298476477d), new NpgsqlTypes.NpgsqlPoint(x: 0.2914291066684467d, y: 0.02667227073004219d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07581303363405045d, y: 0.9976055253948904d), new NpgsqlTypes.NpgsqlPoint(x: 0.19770163854064193d, y: 0.3324543785622345d), new NpgsqlTypes.NpgsqlPoint(x: 0.7875685114629887d, y: 0.64681235296455d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3535840980016709d, y: 0.33805664043498407d), new NpgsqlTypes.NpgsqlPoint(x: 0.9348249154454927d, y: 0.013763588360446999d), new NpgsqlTypes.NpgsqlPoint(x: 0.5393365671483589d, y: 0.386220256792809d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47255648590849864d, y: 0.8005655174023834d), new NpgsqlTypes.NpgsqlPoint(x: 0.3271478981053957d, y: 0.18010977547441975d), new NpgsqlTypes.NpgsqlPoint(x: 0.9480409920417101d, y: 0.9395061112596772d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13357451458049185d, y: 0.6002377834811703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945749757995168d, y: 0.8319503856913598d), new NpgsqlTypes.NpgsqlPoint(x: 0.05462889405812488d, y: 0.20264501813123104d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.759463647681026d, y: 0.7931672894186728d), new NpgsqlTypes.NpgsqlPoint(x: 0.14491549070468057d, y: 0.14234813930770585d), new NpgsqlTypes.NpgsqlPoint(x: 0.05985418650785146d, y: 0.7752197043426176d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21236921751734095d, y: 0.3101197268859006d), new NpgsqlTypes.NpgsqlPoint(x: 0.17335561980448932d, y: 0.6510867676606474d), new NpgsqlTypes.NpgsqlPoint(x: 0.9246137275989446d, y: 0.7117959041067293d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7484353952865397d, y: 0.4967876122432199d), new NpgsqlTypes.NpgsqlPoint(x: 0.4649474213321786d, y: 0.8937505851304027d), new NpgsqlTypes.NpgsqlPoint(x: 0.21963788062454526d, y: 0.6438909336347248d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39775022711497987d, y: 0.1275985420942648d), new NpgsqlTypes.NpgsqlPoint(x: 0.4411646084226375d, y: 0.6869982151200347d), new NpgsqlTypes.NpgsqlPoint(x: 0.3243092078813876d, y: 0.6922577341718459d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6159474778644571d, y: 0.9562774342135019d), new NpgsqlTypes.NpgsqlPoint(x: 0.07933382530070288d, y: 0.8138198966581309d), new NpgsqlTypes.NpgsqlPoint(x: 0.04151424402430792d, y: 0.5544115144001945d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.783158433702267d, y: 0.19267784825422174d), new NpgsqlTypes.NpgsqlPoint(x: 0.5921868821506975d, y: 0.13647502607183493d), new NpgsqlTypes.NpgsqlPoint(x: 0.11011493537741657d, y: 0.2898644379619968d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.034546484546820744d, y: 0.7343962934495607d), new NpgsqlTypes.NpgsqlPoint(x: 0.16283732282372676d, y: 0.9052499045495755d), new NpgsqlTypes.NpgsqlPoint(x: 0.8450138739360756d, y: 0.03203115451789551d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03959018557704219d, y: 0.7202208224901516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9178153148847369d, y: 0.6253579271478816d), new NpgsqlTypes.NpgsqlPoint(x: 0.09720999692617494d, y: 0.17994358810285893d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05083670167433396d, y: 0.2301986285113502d), new NpgsqlTypes.NpgsqlPoint(x: 0.7557360832674114d, y: 0.5142753450797884d), new NpgsqlTypes.NpgsqlPoint(x: 0.2627263306767119d, y: 0.18307642096574395d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14272720737320255d, y: 0.8347081062687568d), new NpgsqlTypes.NpgsqlPoint(x: 0.17601282974661614d, y: 0.26513145982726427d), new NpgsqlTypes.NpgsqlPoint(x: 0.17280035448424913d, y: 0.1702579479308115d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06690656561081687d, y: 0.5972306628794344d), new NpgsqlTypes.NpgsqlPoint(x: 0.3671579778323826d, y: 0.42270603538919815d), new NpgsqlTypes.NpgsqlPoint(x: 0.23564459100763224d, y: 0.35725573032168345d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3631608399655408d, y: 0.7761696531824928d), new NpgsqlTypes.NpgsqlPoint(x: 0.9679404930334402d, y: 0.11574869807069466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6796107927220904d, y: 0.9501217023793279d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5138597893255811d, y: 0.8944396650247982d), new NpgsqlTypes.NpgsqlPoint(x: 0.2670088082065025d, y: 0.9921977239853419d), new NpgsqlTypes.NpgsqlPoint(x: 0.651978420293751d, y: 0.7015149640891456d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04881018176134677d, y: 0.37440240980427d), new NpgsqlTypes.NpgsqlPoint(x: 0.5842829281035505d, y: 0.2819009583262443d), new NpgsqlTypes.NpgsqlPoint(x: 0.02061537657057988d, y: 0.9221778860767196d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.88865229034456d, y: 0.6932686041383828d), new NpgsqlTypes.NpgsqlPoint(x: 0.8572709456512169d, y: 0.7423478591449265d), new NpgsqlTypes.NpgsqlPoint(x: 0.5952503387437157d, y: 0.4952491923449356d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.804172021083368d, y: 0.8007654326869952d), new NpgsqlTypes.NpgsqlPoint(x: 0.04819418257861752d, y: 0.33533405789763915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8476003573502894d, y: 0.9727709749933446d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8417883590312313d, y: 0.9675734790327253d), new NpgsqlTypes.NpgsqlPoint(x: 0.7758711698567895d, y: 0.7547894621716748d), new NpgsqlTypes.NpgsqlPoint(x: 0.7080304439727209d, y: 0.8307530754304943d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7875685206400884d, y: 0.45365302757775194d), new NpgsqlTypes.NpgsqlPoint(x: 0.07875841034725894d, y: 0.15923167020652795d), new NpgsqlTypes.NpgsqlPoint(x: 0.6901772320997895d, y: 0.3973039723727071d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43027886141075544d, y: 0.08722393838593845d), new NpgsqlTypes.NpgsqlPoint(x: 0.34953330653018755d, y: 0.7759557873989305d), new NpgsqlTypes.NpgsqlPoint(x: 0.07927425510667663d, y: 0.8203306708554237d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7420199818990534d, y: 0.9976269504465356d), new NpgsqlTypes.NpgsqlPoint(x: 0.09497992487644291d, y: 0.7511638223985688d), new NpgsqlTypes.NpgsqlPoint(x: 0.837584640894699d, y: 0.8424040123072103d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8338971752061789d, y: 0.4270904193213385d), new NpgsqlTypes.NpgsqlPoint(x: 0.6936487415832914d, y: 0.16732396047312015d), new NpgsqlTypes.NpgsqlPoint(x: 0.5681269984612921d, y: 0.380233604309581d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37437180657658264d, y: 0.09757349408456695d), new NpgsqlTypes.NpgsqlPoint(x: 0.27938347280794595d, y: 0.1549168671492549d), new NpgsqlTypes.NpgsqlPoint(x: 0.9880282083678983d, y: 0.41134918840749013d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9071833925923724d, y: 0.19503338298753647d), new NpgsqlTypes.NpgsqlPoint(x: 0.6068911649469149d, y: 0.8041622957362369d), new NpgsqlTypes.NpgsqlPoint(x: 0.7283516004664641d, y: 0.6967991546522394d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3100438886372956d, y: 0.5914314165658664d), new NpgsqlTypes.NpgsqlPoint(x: 0.10306875660124604d, y: 0.974819956146443d), new NpgsqlTypes.NpgsqlPoint(x: 0.31245530196440463d, y: 0.8934869096241753d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.335453606031912d, y: 0.19965738539286781d), new NpgsqlTypes.NpgsqlPoint(x: 0.4947542212331839d, y: 0.7009150205577126d), new NpgsqlTypes.NpgsqlPoint(x: 0.43694960071256217d, y: 0.8984563229536051d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35913652091482473d, y: 0.704758745839953d), new NpgsqlTypes.NpgsqlPoint(x: 0.3518793384883093d, y: 0.7143734237965694d), new NpgsqlTypes.NpgsqlPoint(x: 0.06478176994114426d, y: 0.39157811648280927d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9899857544364116d, y: 0.8599678046662687d), new NpgsqlTypes.NpgsqlPoint(x: 0.3889362073526561d, y: 0.6510083761750218d), new NpgsqlTypes.NpgsqlPoint(x: 0.5992825164350004d, y: 0.8223332299327429d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5845956764261803d, y: 0.2345076221530218d), new NpgsqlTypes.NpgsqlPoint(x: 0.7691242626055741d, y: 0.2848601908731577d), new NpgsqlTypes.NpgsqlPoint(x: 0.9894673491998073d, y: 0.47842142723369074d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4072722079554987d, y: 0.8838055017743739d), new NpgsqlTypes.NpgsqlPoint(x: 0.1739430695774491d, y: 0.15400787266407956d), new NpgsqlTypes.NpgsqlPoint(x: 0.47193919045575583d, y: 0.3194394692463507d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5666211297434279d, y: 0.06689350752298007d), new NpgsqlTypes.NpgsqlPoint(x: 0.5535300456500912d, y: 0.5475269959167762d), new NpgsqlTypes.NpgsqlPoint(x: 0.24707737861197843d, y: 0.6304037341254901d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49682817708563776d, y: 0.003634259938530837d), new NpgsqlTypes.NpgsqlPoint(x: 0.04442344894186423d, y: 0.27797524862155387d), new NpgsqlTypes.NpgsqlPoint(x: 0.30614112041243313d, y: 0.9624646197687594d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5639203405085194d, y: 0.7834836862897796d), new NpgsqlTypes.NpgsqlPoint(x: 0.5133612984300697d, y: 0.43697840415344846d), new NpgsqlTypes.NpgsqlPoint(x: 0.21367105785338236d, y: 0.9804120755566884d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5763253681229774d, y: 0.9859664939381413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9217927596612693d, y: 0.7159659604481574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5076622755854789d, y: 0.8478192617996386d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9340383245711495d, y: 0.35278162589934103d), new NpgsqlTypes.NpgsqlPoint(x: 0.5157974028062524d, y: 0.8943758078666021d), new NpgsqlTypes.NpgsqlPoint(x: 0.29200654491721223d, y: 0.3970638761155053d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22528605579795846d, y: 0.5041565219815116d), new NpgsqlTypes.NpgsqlPoint(x: 0.30681623512785416d, y: 0.49418813324916677d), new NpgsqlTypes.NpgsqlPoint(x: 0.941373444183185d, y: 0.7809174385496336d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9476183059854648d, y: 0.99646237799563d), new NpgsqlTypes.NpgsqlPoint(x: 0.7726642321094173d, y: 0.12328017320401607d), new NpgsqlTypes.NpgsqlPoint(x: 0.24758186057166787d, y: 0.6831756318984402d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8696868855743293d, y: 0.1484424255187834d), new NpgsqlTypes.NpgsqlPoint(x: 0.2671401416250012d, y: 0.4747512473506039d), new NpgsqlTypes.NpgsqlPoint(x: 0.17652838050432418d, y: 0.30843488131042585d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3873448979522335d, y: 0.9848231898779256d), new NpgsqlTypes.NpgsqlPoint(x: 0.5230181343574555d, y: 0.5531512943380777d), new NpgsqlTypes.NpgsqlPoint(x: 0.4258191583084727d, y: 0.34720379179205774d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33899619935363123d, y: 0.8460882278401042d), new NpgsqlTypes.NpgsqlPoint(x: 0.12534818397581582d, y: 0.08133296693604208d), new NpgsqlTypes.NpgsqlPoint(x: 0.44287578223962343d, y: 0.28369009761540687d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9485322417305011d, y: 0.05426593277482783d), new NpgsqlTypes.NpgsqlPoint(x: 0.08864355487292053d, y: 0.6569429155184143d), new NpgsqlTypes.NpgsqlPoint(x: 0.014076612566196745d, y: 0.9753147441322667d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4385133833987527d, y: 0.19404258910856753d), new NpgsqlTypes.NpgsqlPoint(x: 0.17929683549269404d, y: 0.4866706988781372d), new NpgsqlTypes.NpgsqlPoint(x: 0.18046442567694732d, y: 0.9263159280203662d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27112851489748135d, y: 0.6061276765038192d), new NpgsqlTypes.NpgsqlPoint(x: 0.6147984965392587d, y: 0.20842924332661406d), new NpgsqlTypes.NpgsqlPoint(x: 0.08791444770511325d, y: 0.48888909905369016d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8519199372789142d, y: 0.1589564132633401d), new NpgsqlTypes.NpgsqlPoint(x: 0.7219767812726511d, y: 0.7051278394304905d), new NpgsqlTypes.NpgsqlPoint(x: 0.3439593064862787d, y: 0.13055414389370779d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6104253072723237d, y: 0.03870876971365389d), new NpgsqlTypes.NpgsqlPoint(x: 0.6379831343143142d, y: 0.402944164352834d), new NpgsqlTypes.NpgsqlPoint(x: 0.25945711068854915d, y: 0.49857361437001646d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18209911212634156d, y: 0.7083854940496156d), new NpgsqlTypes.NpgsqlPoint(x: 0.05800637266597641d, y: 0.34930144101578686d), new NpgsqlTypes.NpgsqlPoint(x: 0.6113709589218094d, y: 0.9693600824353463d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5896228832844826d, y: 0.9354265136935658d), new NpgsqlTypes.NpgsqlPoint(x: 0.33720693774718d, y: 0.49837229744618994d), new NpgsqlTypes.NpgsqlPoint(x: 0.6595008402278556d, y: 0.860080644518253d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5392788149185272d, y: 0.7576180081848951d), new NpgsqlTypes.NpgsqlPoint(x: 0.2120783213488473d, y: 0.7290401855253105d), new NpgsqlTypes.NpgsqlPoint(x: 0.7744460077422143d, y: 0.9493685053982869d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6775851424060968d, y: 0.8268163905060338d), new NpgsqlTypes.NpgsqlPoint(x: 0.5731219012414984d, y: 0.973715584377208d), new NpgsqlTypes.NpgsqlPoint(x: 0.8223913205222645d, y: 0.6021097323619162d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8624558313962406d, y: 0.4932662207184475d), new NpgsqlTypes.NpgsqlPoint(x: 0.9667207763733123d, y: 0.165131397354911d), new NpgsqlTypes.NpgsqlPoint(x: 0.5547753795337685d, y: 0.5201392536999719d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30924341238400554d, y: 0.5016607675799548d), new NpgsqlTypes.NpgsqlPoint(x: 0.13224102054970988d, y: 0.4910511249465003d), new NpgsqlTypes.NpgsqlPoint(x: 0.6089712661485154d, y: 0.7676037119751964d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8120875792104634d, y: 0.23218142636754846d), new NpgsqlTypes.NpgsqlPoint(x: 0.10292016972746099d, y: 0.957088640388347d), new NpgsqlTypes.NpgsqlPoint(x: 0.23944486707791157d, y: 0.6710106260163808d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29523701370797184d, y: 0.8943890486562764d), new NpgsqlTypes.NpgsqlPoint(x: 0.7682194187265861d, y: 0.15095778408058913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9120471529344205d, y: 0.31153148485636384d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.822731465472932d, y: 0.427415043368481d), new NpgsqlTypes.NpgsqlPoint(x: 0.08773929444068829d, y: 0.17122763494052873d), new NpgsqlTypes.NpgsqlPoint(x: 0.992641906792746d, y: 0.3652849990269489d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2773610462632794d, y: 0.8783084091222606d), new NpgsqlTypes.NpgsqlPoint(x: 0.7241899010420131d, y: 0.9622565125184256d), new NpgsqlTypes.NpgsqlPoint(x: 0.3967510308168557d, y: 0.0899453679247264d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6191815394784402d, y: 0.2265708799445909d), new NpgsqlTypes.NpgsqlPoint(x: 0.5667549078810679d, y: 0.037019044314746896d), new NpgsqlTypes.NpgsqlPoint(x: 0.743629038970774d, y: 0.2558639115913016d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05024456613913786d, y: 0.6640332457864292d), new NpgsqlTypes.NpgsqlPoint(x: 0.36876165679586526d, y: 0.28315365110679835d), new NpgsqlTypes.NpgsqlPoint(x: 0.2171539717173525d, y: 0.9922482439583099d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32772591070089496d, y: 0.6539115217428725d), new NpgsqlTypes.NpgsqlPoint(x: 0.050767341025692025d, y: 0.6148771509213509d), new NpgsqlTypes.NpgsqlPoint(x: 0.719406801800131d, y: 0.18836958881209442d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.633783484424691d, y: 0.13809259916953742d), new NpgsqlTypes.NpgsqlPoint(x: 0.8239849374446054d, y: 0.3218386293658534d), new NpgsqlTypes.NpgsqlPoint(x: 0.0361599786276503d, y: 0.5634551481714515d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08757280421880609d, y: 0.41036858730285874d), new NpgsqlTypes.NpgsqlPoint(x: 0.31474665757018416d, y: 0.8083349379005694d), new NpgsqlTypes.NpgsqlPoint(x: 0.22221782051688577d, y: 0.23887756148652506d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28236002021227546d, y: 0.9098582227140242d), new NpgsqlTypes.NpgsqlPoint(x: 0.37777567185869043d, y: 0.9567423518421323d), new NpgsqlTypes.NpgsqlPoint(x: 0.14161662818004872d, y: 0.6871454642279501d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38502916532824694d, y: 0.8121159977080029d), new NpgsqlTypes.NpgsqlPoint(x: 0.5923893343725891d, y: 0.2943756300843401d), new NpgsqlTypes.NpgsqlPoint(x: 0.2825645123815109d, y: 0.46461980936944103d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30432685436886164d, y: 0.19624157145799082d), new NpgsqlTypes.NpgsqlPoint(x: 0.27218223272510733d, y: 0.6197230325358284d), new NpgsqlTypes.NpgsqlPoint(x: 0.9082347142798252d, y: 0.13441261480613365d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5435482160464017d, y: 0.4546797112001254d), new NpgsqlTypes.NpgsqlPoint(x: 0.9833116499560483d, y: 0.25630800401994414d), new NpgsqlTypes.NpgsqlPoint(x: 0.5696568478926476d, y: 0.36662298758880596d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36994598942976986d, y: 0.45006424379917176d), new NpgsqlTypes.NpgsqlPoint(x: 0.40591760976599867d, y: 0.699367880381746d), new NpgsqlTypes.NpgsqlPoint(x: 0.831673421243552d, y: 0.48620695489394106d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8028173418530657d, y: 0.9843736315610364d), new NpgsqlTypes.NpgsqlPoint(x: 0.29950842426154645d, y: 0.9126323227391077d), new NpgsqlTypes.NpgsqlPoint(x: 0.28200827141936147d, y: 0.6397814732241334d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15680329031940898d, y: 0.6033452701853275d), new NpgsqlTypes.NpgsqlPoint(x: 0.7406583677981514d, y: 0.06416278750075743d), new NpgsqlTypes.NpgsqlPoint(x: 0.20822501204754706d, y: 0.029530214854178616d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5874595642126701d, y: 0.6216412376326595d), new NpgsqlTypes.NpgsqlPoint(x: 0.9416431336779029d, y: 0.5523743386618701d), new NpgsqlTypes.NpgsqlPoint(x: 0.41452028403307717d, y: 0.41619194061513165d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24106289630065736d, y: 0.4757729116562591d), new NpgsqlTypes.NpgsqlPoint(x: 0.3803242912093763d, y: 0.5389894661692736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5237167039227565d, y: 0.3212814647865405d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6109123754674749d, y: 0.4528450990573114d), new NpgsqlTypes.NpgsqlPoint(x: 0.8974494739238709d, y: 0.9792940608879362d), new NpgsqlTypes.NpgsqlPoint(x: 0.9775936796317595d, y: 0.6344845284214153d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6021348292932134d, y: 0.10012105788795822d), new NpgsqlTypes.NpgsqlPoint(x: 0.1603605879121589d, y: 0.6706564028954191d), new NpgsqlTypes.NpgsqlPoint(x: 0.4664347476372672d, y: 0.3714283173072652d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09969016550891185d, y: 0.11510998051865529d), new NpgsqlTypes.NpgsqlPoint(x: 0.30632127615062366d, y: 0.1778441925110884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9087000151944474d, y: 0.5190859024450758d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7943393930694488d, y: 0.6516887262907682d), new NpgsqlTypes.NpgsqlPoint(x: 0.6997493565964393d, y: 0.4076898687553061d), new NpgsqlTypes.NpgsqlPoint(x: 0.39602518297846556d, y: 0.11515567490035117d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41453873233367555d, y: 0.5258560260024674d), new NpgsqlTypes.NpgsqlPoint(x: 0.08763088942392183d, y: 0.3274149647847763d), new NpgsqlTypes.NpgsqlPoint(x: 0.4578534683314619d, y: 0.8495396198733323d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6627581140732567d, y: 0.7640888464959117d), new NpgsqlTypes.NpgsqlPoint(x: 0.5734540144510404d, y: 0.563485798748176d), new NpgsqlTypes.NpgsqlPoint(x: 0.04429764438344175d, y: 0.7686561921294979d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5607334799685476d, y: 0.6173741026750375d), new NpgsqlTypes.NpgsqlPoint(x: 0.216996501633413d, y: 0.9707589567774889d), new NpgsqlTypes.NpgsqlPoint(x: 0.14219515747455902d, y: 0.61870052369794d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7215206894162111d, y: 0.6900662051839174d), new NpgsqlTypes.NpgsqlPoint(x: 0.5619034860411665d, y: 0.23025709204817357d), new NpgsqlTypes.NpgsqlPoint(x: 0.2787385147324162d, y: 0.6936084124418079d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5089449656120119d, y: 0.930032131214037d), new NpgsqlTypes.NpgsqlPoint(x: 0.49304413763786104d, y: 0.27466005677860006d), new NpgsqlTypes.NpgsqlPoint(x: 0.3624013757468284d, y: 0.505341784910786d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09823624099656525d, y: 0.3545252040343859d), new NpgsqlTypes.NpgsqlPoint(x: 0.7653852799870795d, y: 0.6524380817314056d), new NpgsqlTypes.NpgsqlPoint(x: 0.808734924323826d, y: 0.4126619475451637d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9833083650151434d, y: 0.7384037933014269d), new NpgsqlTypes.NpgsqlPoint(x: 0.7331737940296285d, y: 0.7483113958081298d), new NpgsqlTypes.NpgsqlPoint(x: 0.6928389738989997d, y: 0.794658175763508d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48159334725552405d, y: 0.17007493454726996d), new NpgsqlTypes.NpgsqlPoint(x: 0.8070747140690264d, y: 0.2674512899609941d), new NpgsqlTypes.NpgsqlPoint(x: 0.2731150965542809d, y: 0.3819670718653132d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16711237322592076d, y: 0.5309001309756102d), new NpgsqlTypes.NpgsqlPoint(x: 0.3736549854870991d, y: 0.2667390490966033d), new NpgsqlTypes.NpgsqlPoint(x: 0.02806945090584767d, y: 0.5697400637342261d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20081609170630843d, y: 0.009229781442256946d), new NpgsqlTypes.NpgsqlPoint(x: 0.3285443387068149d, y: 0.20396224178205624d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318256832751384d, y: 0.16438437487245072d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6587721857838779d, y: 0.971782325557358d), new NpgsqlTypes.NpgsqlPoint(x: 0.07019902937312561d, y: 0.8313746947618851d), new NpgsqlTypes.NpgsqlPoint(x: 0.9551666982687983d, y: 0.12688531498456546d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8460121574006217d, y: 0.6856758093497296d), new NpgsqlTypes.NpgsqlPoint(x: 0.5037495868867347d, y: 0.6596969110824443d), new NpgsqlTypes.NpgsqlPoint(x: 0.024832337347427846d, y: 0.24306353373329737d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36962661042770895d, y: 0.8866692614117829d), new NpgsqlTypes.NpgsqlPoint(x: 0.26646658267439227d, y: 0.8398888806101086d), new NpgsqlTypes.NpgsqlPoint(x: 0.6385444662162999d, y: 0.20267164837297036d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30951065339121697d, y: 0.36741452040591016d), new NpgsqlTypes.NpgsqlPoint(x: 0.35811569448836367d, y: 0.282898374398896d), new NpgsqlTypes.NpgsqlPoint(x: 0.06738531918790225d, y: 0.9541592110994881d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8030200393693393d, y: 0.30618375121028873d), new NpgsqlTypes.NpgsqlPoint(x: 0.6416569573917823d, y: 0.2649085666398946d), new NpgsqlTypes.NpgsqlPoint(x: 0.4517730438360571d, y: 0.037970738816182625d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07817207389846137d, y: 0.6548916702748285d), new NpgsqlTypes.NpgsqlPoint(x: 0.24095558434040876d, y: 0.0007959854780955622d), new NpgsqlTypes.NpgsqlPoint(x: 5.085509700908375E-05d, y: 0.5377855451962015d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05397301950385025d, y: 0.020405026592609565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6071306634247586d, y: 0.16914457811733052d), new NpgsqlTypes.NpgsqlPoint(x: 0.46727814326184347d, y: 0.5645452550369692d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8569455333197459d, y: 0.3922132344935504d), new NpgsqlTypes.NpgsqlPoint(x: 0.34323065570515043d, y: 0.21143046422926015d), new NpgsqlTypes.NpgsqlPoint(x: 0.8265021828825942d, y: 0.9648301533581296d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2792613817287939d, y: 0.8252546454084587d), new NpgsqlTypes.NpgsqlPoint(x: 0.6725626635220022d, y: 0.15000938426405286d), new NpgsqlTypes.NpgsqlPoint(x: 0.2655488682696353d, y: 0.8138861131360449d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.854951687089496d, y: 0.4994750968425573d), new NpgsqlTypes.NpgsqlPoint(x: 0.9728789175715526d, y: 0.9298891094044576d), new NpgsqlTypes.NpgsqlPoint(x: 0.618059717614642d, y: 0.6172089738779563d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6240748395320705d, y: 0.7284294721372779d), new NpgsqlTypes.NpgsqlPoint(x: 0.24979664333954377d, y: 0.048583018032627656d), new NpgsqlTypes.NpgsqlPoint(x: 0.8774773825438608d, y: 0.8374920220393254d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8302549179917926d, y: 0.7436629510720609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9161144140069752d, y: 0.0995317830434368d), new NpgsqlTypes.NpgsqlPoint(x: 0.7405953935313251d, y: 0.3254957111567466d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10825004363428437d, y: 0.07964291061233342d), new NpgsqlTypes.NpgsqlPoint(x: 0.9627194504565255d, y: 0.09531751581701708d), new NpgsqlTypes.NpgsqlPoint(x: 0.9212855405104459d, y: 0.5039422218805688d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09847395641259149d, y: 0.4647342427583684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5980754519095612d, y: 0.6499791653062602d), new NpgsqlTypes.NpgsqlPoint(x: 0.3241755898001436d, y: 0.6058634466472763d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14027290033130557d, y: 0.7202333440069113d), new NpgsqlTypes.NpgsqlPoint(x: 0.14962958054036357d, y: 0.174864719401972d), new NpgsqlTypes.NpgsqlPoint(x: 0.4068812165174177d, y: 0.7697783329656883d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29993851811085204d, y: 0.9283203034226545d), new NpgsqlTypes.NpgsqlPoint(x: 0.799536419248993d, y: 0.11092872211908855d), new NpgsqlTypes.NpgsqlPoint(x: 0.08381598808814184d, y: 0.8399322710240373d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7464923104189802d, y: 0.3984265606300802d), new NpgsqlTypes.NpgsqlPoint(x: 0.39903904023563475d, y: 0.4873780258559187d), new NpgsqlTypes.NpgsqlPoint(x: 0.35982092034943014d, y: 0.36598471542922595d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2763329737689586d, y: 0.17201597905067012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671414063935736d, y: 0.9563809381193045d), new NpgsqlTypes.NpgsqlPoint(x: 0.04920965185618231d, y: 0.5104888115665501d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9694400988277359d, y: 0.5597912567608124d), new NpgsqlTypes.NpgsqlPoint(x: 0.7163597198161286d, y: 0.8811725603740747d), new NpgsqlTypes.NpgsqlPoint(x: 0.5341065088921767d, y: 0.36237101388956694d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8471981085251d, y: 0.8337227089418504d), new NpgsqlTypes.NpgsqlPoint(x: 0.6595176027617383d, y: 0.5765110554351276d), new NpgsqlTypes.NpgsqlPoint(x: 0.7269131533808438d, y: 0.7175003586416456d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28322632948620374d, y: 0.40705493388299985d), new NpgsqlTypes.NpgsqlPoint(x: 0.21471331263265148d, y: 0.26209649437384297d), new NpgsqlTypes.NpgsqlPoint(x: 0.5057853523652192d, y: 0.8001185184900279d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12004528580968132d, y: 0.7019193767315988d), new NpgsqlTypes.NpgsqlPoint(x: 0.5676267484485593d, y: 0.05040040525871481d), new NpgsqlTypes.NpgsqlPoint(x: 0.2746595464276753d, y: 0.8409253995310836d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10156565390739924d, y: 0.7065296438227308d), new NpgsqlTypes.NpgsqlPoint(x: 0.698469831496809d, y: 0.6543868320757318d), new NpgsqlTypes.NpgsqlPoint(x: 0.46843680843355384d, y: 0.3451684529332224d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.846771695380092d, y: 0.7995923860996595d), new NpgsqlTypes.NpgsqlPoint(x: 0.5033912181969873d, y: 0.9127942310929514d), new NpgsqlTypes.NpgsqlPoint(x: 0.09797827825476557d, y: 0.05740792911391546d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9208070357398432d, y: 0.9066120302436416d), new NpgsqlTypes.NpgsqlPoint(x: 0.6833818942971954d, y: 0.8195874081575723d), new NpgsqlTypes.NpgsqlPoint(x: 0.955937631409595d, y: 0.6548793148668896d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9440295763337478d, y: 0.5843387722513602d), new NpgsqlTypes.NpgsqlPoint(x: 0.8857880671003798d, y: 0.5695996240277182d), new NpgsqlTypes.NpgsqlPoint(x: 0.5243547685781386d, y: 0.7348807708451724d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22798481198772214d, y: 0.8203539778789974d), new NpgsqlTypes.NpgsqlPoint(x: 0.0763826393682282d, y: 0.8792754110615703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7824106449702343d, y: 0.32091794070759727d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5546070097450432d, y: 0.15341889475162662d), new NpgsqlTypes.NpgsqlPoint(x: 0.9505105375684043d, y: 0.4113026100282561d), new NpgsqlTypes.NpgsqlPoint(x: 0.5044767428201914d, y: 0.310400541080302d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.743420807720689d, y: 0.9374592012271572d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307679260236651d, y: 0.7193086405851672d), new NpgsqlTypes.NpgsqlPoint(x: 0.8451788156091801d, y: 0.32769326848487d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8390933671239081d, y: 0.3309227826903549d), new NpgsqlTypes.NpgsqlPoint(x: 0.6563904102678445d, y: 0.3731017923394372d), new NpgsqlTypes.NpgsqlPoint(x: 0.8682497518322968d, y: 0.91984346745735d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5041265659980788d, y: 0.830408017980116d), new NpgsqlTypes.NpgsqlPoint(x: 0.5347035560149169d, y: 0.27250553933260047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5064873093557545d, y: 0.9387637689824144d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27961545415649836d, y: 0.4686943923142677d), new NpgsqlTypes.NpgsqlPoint(x: 0.8327424418579765d, y: 0.21220159497301994d), new NpgsqlTypes.NpgsqlPoint(x: 0.4992877526480768d, y: 0.5403123841012644d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6476484278204928d, y: 0.5264380266629948d), new NpgsqlTypes.NpgsqlPoint(x: 0.30971638399221757d, y: 0.4163870780703277d), new NpgsqlTypes.NpgsqlPoint(x: 0.010762119838616302d, y: 0.11795578449184718d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4676108565946554d, y: 0.6788647441044207d), new NpgsqlTypes.NpgsqlPoint(x: 0.8654079195507222d, y: 0.8368892097744263d), new NpgsqlTypes.NpgsqlPoint(x: 0.5081143100407908d, y: 0.6467238337493834d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08264374350069659d, y: 0.4089577979542056d), new NpgsqlTypes.NpgsqlPoint(x: 0.4645232429776738d, y: 0.7977361568303046d), new NpgsqlTypes.NpgsqlPoint(x: 0.03872919262117669d, y: 0.9479916126021855d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.887322094675863d, y: 0.7385880379300267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6229316789001488d, y: 0.1374104673032427d), new NpgsqlTypes.NpgsqlPoint(x: 0.6603409577876154d, y: 0.7664270687143099d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08464999827968367d, y: 0.8325251981323009d), new NpgsqlTypes.NpgsqlPoint(x: 0.4337186152121675d, y: 0.014506815817177388d), new NpgsqlTypes.NpgsqlPoint(x: 0.8736104560675589d, y: 0.30571340417576187d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.007947668769552996d, y: 0.07495441680471149d), new NpgsqlTypes.NpgsqlPoint(x: 0.9732169339356476d, y: 0.40419156009081714d), new NpgsqlTypes.NpgsqlPoint(x: 0.44212030113143796d, y: 0.9023473094148224d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4039397298067592d, y: 0.7100807286249039d), new NpgsqlTypes.NpgsqlPoint(x: 0.37819593955673136d, y: 0.24305274825021672d), new NpgsqlTypes.NpgsqlPoint(x: 0.4863112369182324d, y: 0.8487273904578528d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9554006462076021d, y: 0.7636685079163595d), new NpgsqlTypes.NpgsqlPoint(x: 0.9282529039396396d, y: 0.4232541104888824d), new NpgsqlTypes.NpgsqlPoint(x: 0.7034955978891734d, y: 0.8424998505399598d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8433981616620582d, y: 0.5452776955257937d), new NpgsqlTypes.NpgsqlPoint(x: 0.5774204640911399d, y: 0.5706873727141947d), new NpgsqlTypes.NpgsqlPoint(x: 0.10854370542796765d, y: 0.38028674160800857d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6572940797889919d, y: 0.2671774229277286d), new NpgsqlTypes.NpgsqlPoint(x: 0.4762715003624445d, y: 0.7958351018363636d), new NpgsqlTypes.NpgsqlPoint(x: 0.5656899692363829d, y: 0.9253077798159071d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.583304084372074d, y: 0.31590132615522293d), new NpgsqlTypes.NpgsqlPoint(x: 0.4009457122226049d, y: 0.30987739652728064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7904443253674487d, y: 0.5790379232556826d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3086032380792254d, y: 0.5836425364404778d), new NpgsqlTypes.NpgsqlPoint(x: 0.07299024346544025d, y: 0.12335586218061179d), new NpgsqlTypes.NpgsqlPoint(x: 0.09281034142312405d, y: 0.13689678789458992d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7857281072060844d, y: 0.8646681073605369d), new NpgsqlTypes.NpgsqlPoint(x: 0.32640684598035885d, y: 0.600981077100448d), new NpgsqlTypes.NpgsqlPoint(x: 0.13766414124324833d, y: 0.9468482994221569d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6679479595431176d, y: 0.1653658463916099d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495291165487163d, y: 0.07281086599734632d), new NpgsqlTypes.NpgsqlPoint(x: 0.4331143446863024d, y: 0.5100524457644966d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22415347273534392d, y: 0.22217214110420536d), new NpgsqlTypes.NpgsqlPoint(x: 0.09664615255227882d, y: 0.5006514140328414d), new NpgsqlTypes.NpgsqlPoint(x: 0.2072293611176047d, y: 0.7960739536943499d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4757753388742211d, y: 0.2190082194415467d), new NpgsqlTypes.NpgsqlPoint(x: 0.8718624682367463d, y: 0.38424247420845925d), new NpgsqlTypes.NpgsqlPoint(x: 0.572563500648735d, y: 0.21914870071334758d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12079416996856462d, y: 0.4618545467067938d), new NpgsqlTypes.NpgsqlPoint(x: 0.4428723906290081d, y: 0.43231457123871053d), new NpgsqlTypes.NpgsqlPoint(x: 0.36570928196283026d, y: 0.5857936114731167d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10986255420839397d, y: 0.26977681070269854d), new NpgsqlTypes.NpgsqlPoint(x: 0.5046481099374905d, y: 0.9990320010758367d), new NpgsqlTypes.NpgsqlPoint(x: 0.5789484243664098d, y: 0.9592762956004757d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9072303084825712d, y: 0.4568982152276191d), new NpgsqlTypes.NpgsqlPoint(x: 0.8045592723001461d, y: 0.20659353254507373d), new NpgsqlTypes.NpgsqlPoint(x: 0.9814067220434195d, y: 0.32125592651711266d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7350271086570521d, y: 0.6337190854078906d), new NpgsqlTypes.NpgsqlPoint(x: 0.6239188095666952d, y: 0.3440233026207662d), new NpgsqlTypes.NpgsqlPoint(x: 0.3616537250662134d, y: 0.894541813541204d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3469307960274831d, y: 0.9282140487972563d), new NpgsqlTypes.NpgsqlPoint(x: 0.9899827026744072d, y: 0.9044993238526642d), new NpgsqlTypes.NpgsqlPoint(x: 0.10794914115421217d, y: 0.9004888261261083d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12585653678061903d, y: 0.045333470406169085d), new NpgsqlTypes.NpgsqlPoint(x: 0.9450237978442928d, y: 0.002439560722361067d), new NpgsqlTypes.NpgsqlPoint(x: 0.5163689088968687d, y: 0.1486048582327043d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4620204467374964d, y: 0.5235103685276543d), new NpgsqlTypes.NpgsqlPoint(x: 0.08067140119696925d, y: 0.594972811864987d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552677717639921d, y: 0.9257930148022697d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5936086618840476d, y: 0.6311202969288864d), new NpgsqlTypes.NpgsqlPoint(x: 0.9600043715764282d, y: 0.15813034853139118d), new NpgsqlTypes.NpgsqlPoint(x: 0.495433063757418d, y: 0.8264658859320391d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3732980377092877d, y: 0.6595286012572142d), new NpgsqlTypes.NpgsqlPoint(x: 0.08031589762716196d, y: 0.2985432434531522d), new NpgsqlTypes.NpgsqlPoint(x: 0.13855599913427097d, y: 0.5584038002220286d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9807333762145984d, y: 0.03866947949195432d), new NpgsqlTypes.NpgsqlPoint(x: 0.6563128483183129d, y: 0.5244622570559541d), new NpgsqlTypes.NpgsqlPoint(x: 0.9337377941708301d, y: 0.3217528675044744d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11478561714324453d, y: 0.6247383500621704d), new NpgsqlTypes.NpgsqlPoint(x: 0.5450821434141222d, y: 0.30752684577974565d), new NpgsqlTypes.NpgsqlPoint(x: 0.7485567087869537d, y: 0.1663718275687961d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42050531932115986d, y: 0.861279577433922d), new NpgsqlTypes.NpgsqlPoint(x: 0.995623931617186d, y: 0.1641935843020289d), new NpgsqlTypes.NpgsqlPoint(x: 0.4549697592394699d, y: 0.20968018390117227d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0004973311680290804d, y: 0.034575267779378804d), new NpgsqlTypes.NpgsqlPoint(x: 0.8649526383105028d, y: 0.7979658125105836d), new NpgsqlTypes.NpgsqlPoint(x: 0.932940571320506d, y: 0.6135740355139675d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26653911298211563d, y: 0.12176096192268615d), new NpgsqlTypes.NpgsqlPoint(x: 0.4940129891980375d, y: 0.16728155660501298d), new NpgsqlTypes.NpgsqlPoint(x: 0.8575348896483593d, y: 0.7910926963241154d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5928916971064337d, y: 0.9262769077445926d), new NpgsqlTypes.NpgsqlPoint(x: 0.4879009037759391d, y: 0.635277825068247d), new NpgsqlTypes.NpgsqlPoint(x: 0.00467203413054762d, y: 0.08428235107891369d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0042843877171195865d, y: 0.7129532990057406d), new NpgsqlTypes.NpgsqlPoint(x: 0.2077257758759099d, y: 0.6907752004620192d), new NpgsqlTypes.NpgsqlPoint(x: 0.02862840615816442d, y: 0.28987067622066365d)), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
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

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd2e1mi_id
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
    npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18604039810256834d, y: 0.1625637732502322d), new NpgsqlTypes.NpgsqlPoint(x: 0.8081978287779412d, y: 0.042088063512932594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982079515460588d, y: 0.6009167869767486d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4638063784893608d, y: 0.14785767120793036d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848419447284792d, y: 0.523351131089615d), new NpgsqlTypes.NpgsqlPoint(x: 0.392146615706247d, y: 0.2519945938167524d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4388768256335932d, y: 0.19996868315966376d), new NpgsqlTypes.NpgsqlPoint(x: 0.4749778700308548d, y: 0.48203567568909855d), new NpgsqlTypes.NpgsqlPoint(x: 0.4062463775794415d, y: 0.6418909964606507d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05177021240018009d, y: 0.9352961220090334d), new NpgsqlTypes.NpgsqlPoint(x: 0.25928142630900597d, y: 0.6842748029986706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9277322697076975d, y: 0.6301562843844469d)), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0353123335574842d, y: 0.49190025757805655d), new NpgsqlTypes.NpgsqlPoint(x: 0.589296882135672d, y: 0.9909618279978727d), new NpgsqlTypes.NpgsqlPoint(x: 0.3617356396648099d, y: 0.17144021977261215d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.820236220304854d, y: 0.19675944332911843d), new NpgsqlTypes.NpgsqlPoint(x: 0.9107143842078192d, y: 0.694096995775429d), new NpgsqlTypes.NpgsqlPoint(x: 0.6035484933766759d, y: 0.6726480591732602d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8566561174517178d, y: 0.41945905755025614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194380900723001d, y: 0.8367323826255298d), new NpgsqlTypes.NpgsqlPoint(x: 0.32450874187481027d, y: 0.11225334396131992d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8962389224229036d, y: 0.0644803204897717d), new NpgsqlTypes.NpgsqlPoint(x: 0.6622491284975777d, y: 0.15955349738379443d), new NpgsqlTypes.NpgsqlPoint(x: 0.15557643480159633d, y: 0.7641451158102807d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8201024742509047d, y: 0.7995065823806256d), new NpgsqlTypes.NpgsqlPoint(x: 0.8490679075199914d, y: 0.7258187875956493d), new NpgsqlTypes.NpgsqlPoint(x: 0.02884572631532467d, y: 0.0682427701625542d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.960096711243478d, y: 0.8309705996109019d), new NpgsqlTypes.NpgsqlPoint(x: 0.350919020059261d, y: 0.49163985798472654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8615454331038852d, y: 0.5784140583644675d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6286545186366022d, y: 0.021635835956253735d), new NpgsqlTypes.NpgsqlPoint(x: 0.6427739691413706d, y: 0.08032616805542048d), new NpgsqlTypes.NpgsqlPoint(x: 0.3968864214689264d, y: 0.42001992973279845d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6530121108279199d, y: 0.8656614796406827d), new NpgsqlTypes.NpgsqlPoint(x: 0.004845009367769548d, y: 0.7726349528906787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9643295284504845d, y: 0.5674570457873859d)), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005521462601944971d, y: 0.6880818954571671d), new NpgsqlTypes.NpgsqlPoint(x: 0.5086021175430404d, y: 0.36678823177776754d), new NpgsqlTypes.NpgsqlPoint(x: 0.42050714810948464d, y: 0.5824573818471003d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0056682156155211105d, y: 0.8763428317337426d), new NpgsqlTypes.NpgsqlPoint(x: 0.7540200512995872d, y: 0.3811937501244108d), new NpgsqlTypes.NpgsqlPoint(x: 0.25767301266126574d, y: 0.6640106551401753d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3940687458285135d, y: 0.9449797037314597d), new NpgsqlTypes.NpgsqlPoint(x: 0.8200482365823841d, y: 0.6638120773342865d), new NpgsqlTypes.NpgsqlPoint(x: 0.45233553464267995d, y: 0.9709695173785846d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8091370066653317d, y: 0.5936800757757884d), new NpgsqlTypes.NpgsqlPoint(x: 0.7779724683655962d, y: 0.6200581181748426d), new NpgsqlTypes.NpgsqlPoint(x: 0.9813529563699808d, y: 0.03711555559229063d)), }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd2e1mi_id
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
    npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8784029518829064d, y: 0.07331722128224805d), new NpgsqlTypes.NpgsqlPoint(x: 0.610670986591844d, y: 0.2944333805657784d), new NpgsqlTypes.NpgsqlPoint(x: 0.0944723184926366d, y: 0.9430919015836823d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1926980986982837d, y: 0.5026968218808879d), new NpgsqlTypes.NpgsqlPoint(x: 0.10717179747334171d, y: 0.06293271250073751d), new NpgsqlTypes.NpgsqlPoint(x: 0.0745642244506538d, y: 0.4760520458839953d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.487105261086053d, y: 0.6582360951934413d), new NpgsqlTypes.NpgsqlPoint(x: 0.3803939338065194d, y: 0.4005524290587009d), new NpgsqlTypes.NpgsqlPoint(x: 0.4841267845895567d, y: 0.8952249868313361d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2980580821760662d, y: 0.2056192028026287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9884725693672256d, y: 0.45332284789686583d), new NpgsqlTypes.NpgsqlPoint(x: 0.8483147413321883d, y: 0.7022385107666886d)), }, }));
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[,] nullable = null;
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20116192057757887d, y: 0.8165189744341965d), new NpgsqlTypes.NpgsqlPoint(x: 0.25982756968250087d, y: 0.9384405382805715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5248868737223846d, y: 0.09948829539700788d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9488530278948198d, y: 0.007124150986102862d), new NpgsqlTypes.NpgsqlPoint(x: 0.23730082598073998d, y: 0.5991254526541893d), new NpgsqlTypes.NpgsqlPoint(x: 0.5362923169035131d, y: 0.5645202947059849d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2882196715715247d, y: 0.23638022916305146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079593114326685d, y: 0.45885377932301075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9248711372523105d, y: 0.9950363625517826d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25624090720696946d, y: 0.7215562077085269d), new NpgsqlTypes.NpgsqlPoint(x: 0.062370626789939765d, y: 0.45635529255140816d), new NpgsqlTypes.NpgsqlPoint(x: 0.1307524703708255d, y: 0.5107535673559399d)), }, }));
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0096274136688963d, y: 0.4556812357084933d), new NpgsqlTypes.NpgsqlPoint(x: 0.7587545243899217d, y: 0.7938686350145598d), new NpgsqlTypes.NpgsqlPoint(x: 0.954862123101687d, y: 0.8284038312538077d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5773325030518462d, y: 0.4897649964718307d), new NpgsqlTypes.NpgsqlPoint(x: 0.9545613907427601d, y: 0.4201251356483784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987966500344241d, y: 0.8310937680571402d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7036867748559028d, y: 0.018136535760478578d), new NpgsqlTypes.NpgsqlPoint(x: 0.9768658838418078d, y: 0.551227003012739d), new NpgsqlTypes.NpgsqlPoint(x: 0.8392569910016996d, y: 0.3558873403475691d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43915205916752076d, y: 0.7767947550151983d), new NpgsqlTypes.NpgsqlPoint(x: 0.434725305320003d, y: 0.5154002389255752d), new NpgsqlTypes.NpgsqlPoint(x: 0.5738720713948209d, y: 0.06235650276146332d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD2E1M> models = null;

                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD2E1M> models = null;

                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 106;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 153;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 65, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 153, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 153, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 125, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 49, query1, 65, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 146, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 31, query1, 146, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 154, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 12, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 73, 46))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 146);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI), typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

