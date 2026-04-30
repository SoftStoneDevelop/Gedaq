

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
    internal partial interface INpgsqlPathSingleTypepath
    {
    }
    
    internal partial class NpgsqlPathSingleTypepath : INpgsqlPathSingleTypepath
    {


#region TestData

        private readonly NpgsqlPathpath0M[] _testData = new NpgsqlPathpath0M[]
        {
            new NpgsqlPathpath0M
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03499665154924758d, y: 0.804820594310963d), new NpgsqlTypes.NpgsqlPoint(x: 0.18458235193319417d, y: 0.6107593965997761d), new NpgsqlTypes.NpgsqlPoint(x: 0.25629909124912165d, y: 0.17401250444749905d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5124550899838742d, y: 0.37755210854222987d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030856044686575d, y: 0.8608199578902372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9307611148630454d, y: 0.6241778846838533d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3032120042657933d, y: 0.5803786128262443d), new NpgsqlTypes.NpgsqlPoint(x: 0.3675417113563815d, y: 0.5982191744164915d), new NpgsqlTypes.NpgsqlPoint(x: 0.781646323049381d, y: 0.7606115854201042d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3627180958075421d, y: 0.2687808251403019d), new NpgsqlTypes.NpgsqlPoint(x: 0.47275031018153924d, y: 0.1397842586389676d), new NpgsqlTypes.NpgsqlPoint(x: 0.3632022554951949d, y: 0.00799529163139101d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.506117408008544d, y: 0.3719072343217633d), new NpgsqlTypes.NpgsqlPoint(x: 0.13671731955670308d, y: 0.8811912035130864d), new NpgsqlTypes.NpgsqlPoint(x: 0.7554795060747177d, y: 0.5979592441220941d)),
},
            new NpgsqlPathpath0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2924197662863588d, y: 0.17480350093694141d), new NpgsqlTypes.NpgsqlPoint(x: 0.007761461623156385d, y: 0.9791687854991431d), new NpgsqlTypes.NpgsqlPoint(x: 0.06694112704191235d, y: 0.3761093640710007d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16283640155542245d, y: 0.5075592310464347d), new NpgsqlTypes.NpgsqlPoint(x: 0.09430473874021084d, y: 0.477549701353045d), new NpgsqlTypes.NpgsqlPoint(x: 0.07155904276832181d, y: 0.08071696672303397d)),
},
            new NpgsqlPathpath0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3863668610798634d, y: 0.11840959876235191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7450206682729763d, y: 0.709143462796651d), new NpgsqlTypes.NpgsqlPoint(x: 0.654259413979562d, y: 0.8641238350639145d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9389887252467173d, y: 0.931360036962909d), new NpgsqlTypes.NpgsqlPoint(x: 0.7294408747243272d, y: 0.6912250075252047d), new NpgsqlTypes.NpgsqlPoint(x: 0.8482623928222476d, y: 0.8626277209462123d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3091134893044878d, y: 0.25413696596811997d), new NpgsqlTypes.NpgsqlPoint(x: 0.5795804238186278d, y: 0.612688086395267d), new NpgsqlTypes.NpgsqlPoint(x: 0.8740557655795685d, y: 0.41513885064649014d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07027784004081228d, y: 0.5006643183659713d), new NpgsqlTypes.NpgsqlPoint(x: 0.7365903652091186d, y: 0.6320524469870952d), new NpgsqlTypes.NpgsqlPoint(x: 0.07930917359022438d, y: 0.7343674094886536d)),
},
            new NpgsqlPathpath0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5014627678041759d, y: 0.37940457316412235d), new NpgsqlTypes.NpgsqlPoint(x: 0.30372276409220933d, y: 0.6535709532625132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5097114293029807d, y: 0.8608195134356726d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5012080436940057d, y: 0.8667893136513207d), new NpgsqlTypes.NpgsqlPoint(x: 0.13258548444193208d, y: 0.568215550208478d), new NpgsqlTypes.NpgsqlPoint(x: 0.6149976481141315d, y: 0.7021037505897995d)),
},
            new NpgsqlPathpath0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7942190355830967d, y: 0.6697368896730762d), new NpgsqlTypes.NpgsqlPoint(x: 0.9248395168322832d, y: 0.8619088754044343d), new NpgsqlTypes.NpgsqlPoint(x: 0.8499413305709002d, y: 0.5180469762552851d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4481867391562122d, y: 0.9119873572533107d), new NpgsqlTypes.NpgsqlPoint(x: 0.6039488786785018d, y: 0.3979660105995976d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799288059930604d, y: 0.28410642738834624d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4651322353118218d, y: 0.630011874752983d), new NpgsqlTypes.NpgsqlPoint(x: 0.74991257815658d, y: 0.034356461446329645d), new NpgsqlTypes.NpgsqlPoint(x: 0.29466820127503024d, y: 0.11579226978919055d)),
},
            new NpgsqlPathpath0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4591841278575831d, y: 0.6735609886127955d), new NpgsqlTypes.NpgsqlPoint(x: 0.629735399324854d, y: 0.5440138417212852d), new NpgsqlTypes.NpgsqlPoint(x: 0.8480614103413945d, y: 0.6303094118834295d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7991429268208929d, y: 0.6873928374902868d), new NpgsqlTypes.NpgsqlPoint(x: 0.7261640405972043d, y: 0.7575144014736539d), new NpgsqlTypes.NpgsqlPoint(x: 0.8477328540076761d, y: 0.4627690118025145d)),
},
            new NpgsqlPathpath0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16136183075308408d, y: 0.8385287853937732d), new NpgsqlTypes.NpgsqlPoint(x: 0.14688641110324052d, y: 0.6975296125165584d), new NpgsqlTypes.NpgsqlPoint(x: 0.4888205477591171d, y: 0.03751031351776357d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2746567040655805d, y: 0.7576654599298046d), new NpgsqlTypes.NpgsqlPoint(x: 0.26042359439324625d, y: 0.912314600473466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7295270592020926d, y: 0.203262036751802d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9136842861066918d, y: 0.1679558368181937d), new NpgsqlTypes.NpgsqlPoint(x: 0.35815346740072596d, y: 0.7687341723046927d), new NpgsqlTypes.NpgsqlPoint(x: 0.08958232193755078d, y: 0.960057384191759d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.675032661774474d, y: 0.946824271515457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626784217293271d, y: 0.7162445934923336d), new NpgsqlTypes.NpgsqlPoint(x: 0.4583449256796748d, y: 0.26188630619746867d)),
},
            new NpgsqlPathpath0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.356211900653446d, y: 0.6232549622764287d), new NpgsqlTypes.NpgsqlPoint(x: 0.41656070866519324d, y: 0.07095676259835249d), new NpgsqlTypes.NpgsqlPoint(x: 0.7408346061698244d, y: 0.3580791272254281d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03183370167972632d, y: 0.33316200193380396d), new NpgsqlTypes.NpgsqlPoint(x: 0.4486775791943297d, y: 0.14207885259564323d), new NpgsqlTypes.NpgsqlPoint(x: 0.303526496558705d, y: 0.768145658965612d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1452609753996632d, y: 0.8408626604180567d), new NpgsqlTypes.NpgsqlPoint(x: 0.21448751738209315d, y: 0.43396113911092415d), new NpgsqlTypes.NpgsqlPoint(x: 0.9498101129195904d, y: 0.07947561596708697d)),
},
            new NpgsqlPathpath0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9908899146963542d, y: 0.19519909032112714d), new NpgsqlTypes.NpgsqlPoint(x: 0.5156255068697472d, y: 0.22933490275281476d), new NpgsqlTypes.NpgsqlPoint(x: 0.9768549334573162d, y: 0.6371175574191967d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9550301448607829d, y: 0.7511489834219013d), new NpgsqlTypes.NpgsqlPoint(x: 0.4475371698079147d, y: 0.4003252655342612d), new NpgsqlTypes.NpgsqlPoint(x: 0.36576215194702155d, y: 0.5398830953135616d)),
},
            new NpgsqlPathpath0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6381021782263984d, y: 0.046810915850073465d), new NpgsqlTypes.NpgsqlPoint(x: 0.2661342416102632d, y: 0.8583492753290843d), new NpgsqlTypes.NpgsqlPoint(x: 0.18967811129829126d, y: 0.7941805482368798d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35096735091375575d, y: 0.9733976252741314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6998379421660694d, y: 0.29806167199640266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5116019574922605d, y: 0.16630188689052472d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4609124020135137d, y: 0.6656092801912609d), new NpgsqlTypes.NpgsqlPoint(x: 0.07881757485269458d, y: 0.4425057089361535d), new NpgsqlTypes.NpgsqlPoint(x: 0.8234950044994787d, y: 0.8975245442648526d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3758860525533543d, y: 0.2200012307183783d), new NpgsqlTypes.NpgsqlPoint(x: 0.25321514197922146d, y: 0.7413238145594813d), new NpgsqlTypes.NpgsqlPoint(x: 0.24884262058626505d, y: 0.3551889906417859d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9878591827364954d, y: 0.6703425263233667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5041802684570574d, y: 0.5103962127962033d), new NpgsqlTypes.NpgsqlPoint(x: 0.6045513841020941d, y: 0.015565439803823855d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.295349787435049d, y: 0.942285093658385d), new NpgsqlTypes.NpgsqlPoint(x: 0.3734848412062657d, y: 0.0630284550910295d), new NpgsqlTypes.NpgsqlPoint(x: 0.08762676390229551d, y: 0.1960947393829776d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4229233269916328d, y: 0.9217485571098338d), new NpgsqlTypes.NpgsqlPoint(x: 0.29407782473994115d, y: 0.5198467429199287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9417002083975893d, y: 0.9116598688634037d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44104968500649d, y: 0.02134358884896248d), new NpgsqlTypes.NpgsqlPoint(x: 0.18408757685038324d, y: 0.973570502951859d), new NpgsqlTypes.NpgsqlPoint(x: 0.20165806696526611d, y: 0.06303670675177564d)),
},
            new NpgsqlPathpath0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8335652259440063d, y: 0.24287433908517653d), new NpgsqlTypes.NpgsqlPoint(x: 0.09645848528216083d, y: 0.7042423145118123d), new NpgsqlTypes.NpgsqlPoint(x: 0.40471127439328614d, y: 0.2841625680162976d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8681580089535671d, y: 0.42895615469443527d), new NpgsqlTypes.NpgsqlPoint(x: 0.77627012613172d, y: 0.4798186433603534d), new NpgsqlTypes.NpgsqlPoint(x: 0.8317939459456035d, y: 0.7321560789378027d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31504620168158726d, y: 0.677167562774502d), new NpgsqlTypes.NpgsqlPoint(x: 0.1333716504860858d, y: 0.21206774450200883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6411293592368544d, y: 0.7309921588825244d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11091613067523842d, y: 0.9656455970496093d), new NpgsqlTypes.NpgsqlPoint(x: 0.5128759547009505d, y: 0.8322383493855937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8107520252971412d, y: 0.518330694466319d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9602542109165475d, y: 0.6039046016655529d), new NpgsqlTypes.NpgsqlPoint(x: 0.9115531517613396d, y: 0.6474873424733572d), new NpgsqlTypes.NpgsqlPoint(x: 0.7990712891879518d, y: 0.6918032702455588d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9918579684973169d, y: 0.14631445666377285d), new NpgsqlTypes.NpgsqlPoint(x: 0.7780781824996515d, y: 0.5165576566741577d), new NpgsqlTypes.NpgsqlPoint(x: 0.6515985722365867d, y: 0.7261698478936459d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41043528024314924d, y: 0.9752344196645708d), new NpgsqlTypes.NpgsqlPoint(x: 0.14698596986210055d, y: 0.5523553403178038d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903602119527939d, y: 0.9635373001265611d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3123491960963617d, y: 0.5119837457708054d), new NpgsqlTypes.NpgsqlPoint(x: 0.5147910760447431d, y: 0.6237894612365751d), new NpgsqlTypes.NpgsqlPoint(x: 0.21869648638124306d, y: 0.3706967778429727d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1884292856871077d, y: 0.529892790206238d), new NpgsqlTypes.NpgsqlPoint(x: 0.8622903346411994d, y: 0.4814601556305341d), new NpgsqlTypes.NpgsqlPoint(x: 0.5104095653819648d, y: 0.674571513715499d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19889132996869918d, y: 0.7708018481276553d), new NpgsqlTypes.NpgsqlPoint(x: 0.23669271190167318d, y: 0.9723290058743822d), new NpgsqlTypes.NpgsqlPoint(x: 0.3464036516550518d, y: 0.9975002558390771d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7606996117076346d, y: 0.41025718897232477d), new NpgsqlTypes.NpgsqlPoint(x: 0.6270835645839352d, y: 0.32835273264866616d), new NpgsqlTypes.NpgsqlPoint(x: 0.35320769733125856d, y: 0.5549734401353159d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41330521287839583d, y: 0.0334884751533433d), new NpgsqlTypes.NpgsqlPoint(x: 0.6383156274080058d, y: 0.013312921094527086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7842608046505113d, y: 0.3789635515122062d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.939119178826389d, y: 0.9866306102433245d), new NpgsqlTypes.NpgsqlPoint(x: 0.939242474477792d, y: 0.335079122695245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5708691298297643d, y: 0.8681546665734158d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07809046763679606d, y: 0.026168712130712923d), new NpgsqlTypes.NpgsqlPoint(x: 0.08470412851631426d, y: 0.7003424250570824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8473946900635584d, y: 0.7048931276025332d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07400925235060707d, y: 0.6949860755306273d), new NpgsqlTypes.NpgsqlPoint(x: 0.8955888187520283d, y: 0.882811172207966d), new NpgsqlTypes.NpgsqlPoint(x: 0.1523318061854666d, y: 0.39993937881113384d)),
},
            new NpgsqlPathpath0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12756026940025134d, y: 0.97523768565922d), new NpgsqlTypes.NpgsqlPoint(x: 0.05984224352300549d, y: 0.16578722589207673d), new NpgsqlTypes.NpgsqlPoint(x: 0.745922718084947d, y: 0.9567039773597326d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3916885560840515d, y: 0.3671898684068302d), new NpgsqlTypes.NpgsqlPoint(x: 0.3957322004452465d, y: 0.05810247499189325d), new NpgsqlTypes.NpgsqlPoint(x: 0.6370328662506191d, y: 0.8875352096125639d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5858292077346524d, y: 0.2863875781263088d), new NpgsqlTypes.NpgsqlPoint(x: 0.1315431536908216d, y: 0.04152445942847227d), new NpgsqlTypes.NpgsqlPoint(x: 0.28160919002038665d, y: 0.1692179024468966d)),
},
            new NpgsqlPathpath0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7691117208134399d, y: 0.57991974875154d), new NpgsqlTypes.NpgsqlPoint(x: 0.786686664861542d, y: 0.2245632247278263d), new NpgsqlTypes.NpgsqlPoint(x: 0.7521544127390185d, y: 0.2123680425240757d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5544331739616162d, y: 0.17811520182094864d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292060983620097d, y: 0.6131953170694724d), new NpgsqlTypes.NpgsqlPoint(x: 0.007790379690101656d, y: 0.19815016163464882d)),
},
            new NpgsqlPathpath0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015276112595295599d, y: 0.3687518797724355d), new NpgsqlTypes.NpgsqlPoint(x: 0.7053141394766528d, y: 0.7808992553390111d), new NpgsqlTypes.NpgsqlPoint(x: 0.08421706716273092d, y: 0.46948690488235d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1258669532022304d, y: 0.3696684575064302d), new NpgsqlTypes.NpgsqlPoint(x: 0.2368260377057635d, y: 0.7914290469954642d), new NpgsqlTypes.NpgsqlPoint(x: 0.5388203725603047d, y: 0.2624768817479506d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9676510468376986d, y: 0.42972931645862666d), new NpgsqlTypes.NpgsqlPoint(x: 0.3793494361745219d, y: 0.04290273495155905d), new NpgsqlTypes.NpgsqlPoint(x: 0.47577824842873573d, y: 0.7842694666043263d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9964573203183545d, y: 0.8131359704132901d), new NpgsqlTypes.NpgsqlPoint(x: 0.8664732941947313d, y: 0.18714356543386956d), new NpgsqlTypes.NpgsqlPoint(x: 0.05490947877947605d, y: 0.6754232493951412d)),
},
            new NpgsqlPathpath0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.562724588114225d, y: 0.9480325821500085d), new NpgsqlTypes.NpgsqlPoint(x: 0.11190299425623529d, y: 0.006939265289452545d), new NpgsqlTypes.NpgsqlPoint(x: 0.14915513886136456d, y: 0.46569969238969344d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5611264729925373d, y: 0.734764347451312d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361586144492367d, y: 0.23376615814424362d), new NpgsqlTypes.NpgsqlPoint(x: 0.05294816435696181d, y: 0.5982364654695477d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13619765605227752d, y: 0.8178053986760185d), new NpgsqlTypes.NpgsqlPoint(x: 0.539284614722645d, y: 0.6393947871024187d), new NpgsqlTypes.NpgsqlPoint(x: 0.36539349723174497d, y: 0.5900008680580888d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4185920957357566d, y: 0.9134815507020604d), new NpgsqlTypes.NpgsqlPoint(x: 0.715698473591636d, y: 0.8062417237329821d), new NpgsqlTypes.NpgsqlPoint(x: 0.9442259980446596d, y: 0.0534300519887726d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18007964001407895d, y: 0.7920681771107236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7822600731749659d, y: 0.5810322276097891d), new NpgsqlTypes.NpgsqlPoint(x: 0.6935551274900222d, y: 0.6130176445303361d)),
},
            new NpgsqlPathpath0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03379107967107653d, y: 0.9786183361566113d), new NpgsqlTypes.NpgsqlPoint(x: 0.022893525464766085d, y: 0.25140759617593533d), new NpgsqlTypes.NpgsqlPoint(x: 0.30738531898636945d, y: 0.46428608331542054d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8527119758413458d, y: 0.5839014850028449d), new NpgsqlTypes.NpgsqlPoint(x: 0.9375584458863357d, y: 0.0026220881623477688d), new NpgsqlTypes.NpgsqlPoint(x: 0.9663022074923076d, y: 0.6084916723323112d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.772198108807845d, y: 0.786804329828887d), new NpgsqlTypes.NpgsqlPoint(x: 0.2239935618083282d, y: 0.6229894388850515d), new NpgsqlTypes.NpgsqlPoint(x: 0.8383576903554257d, y: 0.7368421603383772d)),
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5012080436940057d, y: 0.8667893136513207d), new NpgsqlTypes.NpgsqlPoint(x: 0.13258548444193208d, y: 0.568215550208478d), new NpgsqlTypes.NpgsqlPoint(x: 0.6149976481141315d, y: 0.7021037505897995d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4651322353118218d, y: 0.630011874752983d), new NpgsqlTypes.NpgsqlPoint(x: 0.74991257815658d, y: 0.034356461446329645d), new NpgsqlTypes.NpgsqlPoint(x: 0.29466820127503024d, y: 0.11579226978919055d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7991429268208929d, y: 0.6873928374902868d), new NpgsqlTypes.NpgsqlPoint(x: 0.7261640405972043d, y: 0.7575144014736539d), new NpgsqlTypes.NpgsqlPoint(x: 0.8477328540076761d, y: 0.4627690118025145d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.675032661774474d, y: 0.946824271515457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626784217293271d, y: 0.7162445934923336d), new NpgsqlTypes.NpgsqlPoint(x: 0.4583449256796748d, y: 0.26188630619746867d))));
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1452609753996632d, y: 0.8408626604180567d), new NpgsqlTypes.NpgsqlPoint(x: 0.21448751738209315d, y: 0.43396113911092415d), new NpgsqlTypes.NpgsqlPoint(x: 0.9498101129195904d, y: 0.07947561596708697d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9550301448607829d, y: 0.7511489834219013d), new NpgsqlTypes.NpgsqlPoint(x: 0.4475371698079147d, y: 0.4003252655342612d), new NpgsqlTypes.NpgsqlPoint(x: 0.36576215194702155d, y: 0.5398830953135616d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpath0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPath), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpathpath0mi_id", 
                methodParametrName: "npgsqlpathpath0mi_id", 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[29], false);
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
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[29], false);
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
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[29], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 111, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 3, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 16, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 3, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 28, query1, 3, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 90, query1, 35, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 102, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 52, query1, 32, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 98, 44))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[29], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 64, 102))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPathpath0M.AssertModel(models[0],_testData[7], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPathpath0M.AssertModel(models[0],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03499665154924758d, y: 0.804820594310963d), new NpgsqlTypes.NpgsqlPoint(x: 0.18458235193319417d, y: 0.6107593965997761d), new NpgsqlTypes.NpgsqlPoint(x: 0.25629909124912165d, y: 0.17401250444749905d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5124550899838742d, y: 0.37755210854222987d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030856044686575d, y: 0.8608199578902372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9307611148630454d, y: 0.6241778846838533d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3032120042657933d, y: 0.5803786128262443d), new NpgsqlTypes.NpgsqlPoint(x: 0.3675417113563815d, y: 0.5982191744164915d), new NpgsqlTypes.NpgsqlPoint(x: 0.781646323049381d, y: 0.7606115854201042d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3627180958075421d, y: 0.2687808251403019d), new NpgsqlTypes.NpgsqlPoint(x: 0.47275031018153924d, y: 0.1397842586389676d), new NpgsqlTypes.NpgsqlPoint(x: 0.3632022554951949d, y: 0.00799529163139101d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.506117408008544d, y: 0.3719072343217633d), new NpgsqlTypes.NpgsqlPoint(x: 0.13671731955670308d, y: 0.8811912035130864d), new NpgsqlTypes.NpgsqlPoint(x: 0.7554795060747177d, y: 0.5979592441220941d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2924197662863588d, y: 0.17480350093694141d), new NpgsqlTypes.NpgsqlPoint(x: 0.007761461623156385d, y: 0.9791687854991431d), new NpgsqlTypes.NpgsqlPoint(x: 0.06694112704191235d, y: 0.3761093640710007d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16283640155542245d, y: 0.5075592310464347d), new NpgsqlTypes.NpgsqlPoint(x: 0.09430473874021084d, y: 0.477549701353045d), new NpgsqlTypes.NpgsqlPoint(x: 0.07155904276832181d, y: 0.08071696672303397d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3863668610798634d, y: 0.11840959876235191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7450206682729763d, y: 0.709143462796651d), new NpgsqlTypes.NpgsqlPoint(x: 0.654259413979562d, y: 0.8641238350639145d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9389887252467173d, y: 0.931360036962909d), new NpgsqlTypes.NpgsqlPoint(x: 0.7294408747243272d, y: 0.6912250075252047d), new NpgsqlTypes.NpgsqlPoint(x: 0.8482623928222476d, y: 0.8626277209462123d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3091134893044878d, y: 0.25413696596811997d), new NpgsqlTypes.NpgsqlPoint(x: 0.5795804238186278d, y: 0.612688086395267d), new NpgsqlTypes.NpgsqlPoint(x: 0.8740557655795685d, y: 0.41513885064649014d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07027784004081228d, y: 0.5006643183659713d), new NpgsqlTypes.NpgsqlPoint(x: 0.7365903652091186d, y: 0.6320524469870952d), new NpgsqlTypes.NpgsqlPoint(x: 0.07930917359022438d, y: 0.7343674094886536d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5014627678041759d, y: 0.37940457316412235d), new NpgsqlTypes.NpgsqlPoint(x: 0.30372276409220933d, y: 0.6535709532625132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5097114293029807d, y: 0.8608195134356726d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5012080436940057d, y: 0.8667893136513207d), new NpgsqlTypes.NpgsqlPoint(x: 0.13258548444193208d, y: 0.568215550208478d), new NpgsqlTypes.NpgsqlPoint(x: 0.6149976481141315d, y: 0.7021037505897995d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7942190355830967d, y: 0.6697368896730762d), new NpgsqlTypes.NpgsqlPoint(x: 0.9248395168322832d, y: 0.8619088754044343d), new NpgsqlTypes.NpgsqlPoint(x: 0.8499413305709002d, y: 0.5180469762552851d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4481867391562122d, y: 0.9119873572533107d), new NpgsqlTypes.NpgsqlPoint(x: 0.6039488786785018d, y: 0.3979660105995976d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799288059930604d, y: 0.28410642738834624d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4651322353118218d, y: 0.630011874752983d), new NpgsqlTypes.NpgsqlPoint(x: 0.74991257815658d, y: 0.034356461446329645d), new NpgsqlTypes.NpgsqlPoint(x: 0.29466820127503024d, y: 0.11579226978919055d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4591841278575831d, y: 0.6735609886127955d), new NpgsqlTypes.NpgsqlPoint(x: 0.629735399324854d, y: 0.5440138417212852d), new NpgsqlTypes.NpgsqlPoint(x: 0.8480614103413945d, y: 0.6303094118834295d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7991429268208929d, y: 0.6873928374902868d), new NpgsqlTypes.NpgsqlPoint(x: 0.7261640405972043d, y: 0.7575144014736539d), new NpgsqlTypes.NpgsqlPoint(x: 0.8477328540076761d, y: 0.4627690118025145d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16136183075308408d, y: 0.8385287853937732d), new NpgsqlTypes.NpgsqlPoint(x: 0.14688641110324052d, y: 0.6975296125165584d), new NpgsqlTypes.NpgsqlPoint(x: 0.4888205477591171d, y: 0.03751031351776357d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2746567040655805d, y: 0.7576654599298046d), new NpgsqlTypes.NpgsqlPoint(x: 0.26042359439324625d, y: 0.912314600473466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7295270592020926d, y: 0.203262036751802d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9136842861066918d, y: 0.1679558368181937d), new NpgsqlTypes.NpgsqlPoint(x: 0.35815346740072596d, y: 0.7687341723046927d), new NpgsqlTypes.NpgsqlPoint(x: 0.08958232193755078d, y: 0.960057384191759d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.675032661774474d, y: 0.946824271515457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626784217293271d, y: 0.7162445934923336d), new NpgsqlTypes.NpgsqlPoint(x: 0.4583449256796748d, y: 0.26188630619746867d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.356211900653446d, y: 0.6232549622764287d), new NpgsqlTypes.NpgsqlPoint(x: 0.41656070866519324d, y: 0.07095676259835249d), new NpgsqlTypes.NpgsqlPoint(x: 0.7408346061698244d, y: 0.3580791272254281d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03183370167972632d, y: 0.33316200193380396d), new NpgsqlTypes.NpgsqlPoint(x: 0.4486775791943297d, y: 0.14207885259564323d), new NpgsqlTypes.NpgsqlPoint(x: 0.303526496558705d, y: 0.768145658965612d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1452609753996632d, y: 0.8408626604180567d), new NpgsqlTypes.NpgsqlPoint(x: 0.21448751738209315d, y: 0.43396113911092415d), new NpgsqlTypes.NpgsqlPoint(x: 0.9498101129195904d, y: 0.07947561596708697d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9908899146963542d, y: 0.19519909032112714d), new NpgsqlTypes.NpgsqlPoint(x: 0.5156255068697472d, y: 0.22933490275281476d), new NpgsqlTypes.NpgsqlPoint(x: 0.9768549334573162d, y: 0.6371175574191967d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9550301448607829d, y: 0.7511489834219013d), new NpgsqlTypes.NpgsqlPoint(x: 0.4475371698079147d, y: 0.4003252655342612d), new NpgsqlTypes.NpgsqlPoint(x: 0.36576215194702155d, y: 0.5398830953135616d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6381021782263984d, y: 0.046810915850073465d), new NpgsqlTypes.NpgsqlPoint(x: 0.2661342416102632d, y: 0.8583492753290843d), new NpgsqlTypes.NpgsqlPoint(x: 0.18967811129829126d, y: 0.7941805482368798d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35096735091375575d, y: 0.9733976252741314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6998379421660694d, y: 0.29806167199640266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5116019574922605d, y: 0.16630188689052472d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4609124020135137d, y: 0.6656092801912609d), new NpgsqlTypes.NpgsqlPoint(x: 0.07881757485269458d, y: 0.4425057089361535d), new NpgsqlTypes.NpgsqlPoint(x: 0.8234950044994787d, y: 0.8975245442648526d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3758860525533543d, y: 0.2200012307183783d), new NpgsqlTypes.NpgsqlPoint(x: 0.25321514197922146d, y: 0.7413238145594813d), new NpgsqlTypes.NpgsqlPoint(x: 0.24884262058626505d, y: 0.3551889906417859d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9878591827364954d, y: 0.6703425263233667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5041802684570574d, y: 0.5103962127962033d), new NpgsqlTypes.NpgsqlPoint(x: 0.6045513841020941d, y: 0.015565439803823855d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.295349787435049d, y: 0.942285093658385d), new NpgsqlTypes.NpgsqlPoint(x: 0.3734848412062657d, y: 0.0630284550910295d), new NpgsqlTypes.NpgsqlPoint(x: 0.08762676390229551d, y: 0.1960947393829776d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4229233269916328d, y: 0.9217485571098338d), new NpgsqlTypes.NpgsqlPoint(x: 0.29407782473994115d, y: 0.5198467429199287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9417002083975893d, y: 0.9116598688634037d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44104968500649d, y: 0.02134358884896248d), new NpgsqlTypes.NpgsqlPoint(x: 0.18408757685038324d, y: 0.973570502951859d), new NpgsqlTypes.NpgsqlPoint(x: 0.20165806696526611d, y: 0.06303670675177564d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8335652259440063d, y: 0.24287433908517653d), new NpgsqlTypes.NpgsqlPoint(x: 0.09645848528216083d, y: 0.7042423145118123d), new NpgsqlTypes.NpgsqlPoint(x: 0.40471127439328614d, y: 0.2841625680162976d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8681580089535671d, y: 0.42895615469443527d), new NpgsqlTypes.NpgsqlPoint(x: 0.77627012613172d, y: 0.4798186433603534d), new NpgsqlTypes.NpgsqlPoint(x: 0.8317939459456035d, y: 0.7321560789378027d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31504620168158726d, y: 0.677167562774502d), new NpgsqlTypes.NpgsqlPoint(x: 0.1333716504860858d, y: 0.21206774450200883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6411293592368544d, y: 0.7309921588825244d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11091613067523842d, y: 0.9656455970496093d), new NpgsqlTypes.NpgsqlPoint(x: 0.5128759547009505d, y: 0.8322383493855937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8107520252971412d, y: 0.518330694466319d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9602542109165475d, y: 0.6039046016655529d), new NpgsqlTypes.NpgsqlPoint(x: 0.9115531517613396d, y: 0.6474873424733572d), new NpgsqlTypes.NpgsqlPoint(x: 0.7990712891879518d, y: 0.6918032702455588d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9918579684973169d, y: 0.14631445666377285d), new NpgsqlTypes.NpgsqlPoint(x: 0.7780781824996515d, y: 0.5165576566741577d), new NpgsqlTypes.NpgsqlPoint(x: 0.6515985722365867d, y: 0.7261698478936459d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41043528024314924d, y: 0.9752344196645708d), new NpgsqlTypes.NpgsqlPoint(x: 0.14698596986210055d, y: 0.5523553403178038d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903602119527939d, y: 0.9635373001265611d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3123491960963617d, y: 0.5119837457708054d), new NpgsqlTypes.NpgsqlPoint(x: 0.5147910760447431d, y: 0.6237894612365751d), new NpgsqlTypes.NpgsqlPoint(x: 0.21869648638124306d, y: 0.3706967778429727d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1884292856871077d, y: 0.529892790206238d), new NpgsqlTypes.NpgsqlPoint(x: 0.8622903346411994d, y: 0.4814601556305341d), new NpgsqlTypes.NpgsqlPoint(x: 0.5104095653819648d, y: 0.674571513715499d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19889132996869918d, y: 0.7708018481276553d), new NpgsqlTypes.NpgsqlPoint(x: 0.23669271190167318d, y: 0.9723290058743822d), new NpgsqlTypes.NpgsqlPoint(x: 0.3464036516550518d, y: 0.9975002558390771d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7606996117076346d, y: 0.41025718897232477d), new NpgsqlTypes.NpgsqlPoint(x: 0.6270835645839352d, y: 0.32835273264866616d), new NpgsqlTypes.NpgsqlPoint(x: 0.35320769733125856d, y: 0.5549734401353159d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41330521287839583d, y: 0.0334884751533433d), new NpgsqlTypes.NpgsqlPoint(x: 0.6383156274080058d, y: 0.013312921094527086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7842608046505113d, y: 0.3789635515122062d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.939119178826389d, y: 0.9866306102433245d), new NpgsqlTypes.NpgsqlPoint(x: 0.939242474477792d, y: 0.335079122695245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5708691298297643d, y: 0.8681546665734158d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07809046763679606d, y: 0.026168712130712923d), new NpgsqlTypes.NpgsqlPoint(x: 0.08470412851631426d, y: 0.7003424250570824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8473946900635584d, y: 0.7048931276025332d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07400925235060707d, y: 0.6949860755306273d), new NpgsqlTypes.NpgsqlPoint(x: 0.8955888187520283d, y: 0.882811172207966d), new NpgsqlTypes.NpgsqlPoint(x: 0.1523318061854666d, y: 0.39993937881113384d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12756026940025134d, y: 0.97523768565922d), new NpgsqlTypes.NpgsqlPoint(x: 0.05984224352300549d, y: 0.16578722589207673d), new NpgsqlTypes.NpgsqlPoint(x: 0.745922718084947d, y: 0.9567039773597326d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3916885560840515d, y: 0.3671898684068302d), new NpgsqlTypes.NpgsqlPoint(x: 0.3957322004452465d, y: 0.05810247499189325d), new NpgsqlTypes.NpgsqlPoint(x: 0.6370328662506191d, y: 0.8875352096125639d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5858292077346524d, y: 0.2863875781263088d), new NpgsqlTypes.NpgsqlPoint(x: 0.1315431536908216d, y: 0.04152445942847227d), new NpgsqlTypes.NpgsqlPoint(x: 0.28160919002038665d, y: 0.1692179024468966d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7691117208134399d, y: 0.57991974875154d), new NpgsqlTypes.NpgsqlPoint(x: 0.786686664861542d, y: 0.2245632247278263d), new NpgsqlTypes.NpgsqlPoint(x: 0.7521544127390185d, y: 0.2123680425240757d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5544331739616162d, y: 0.17811520182094864d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292060983620097d, y: 0.6131953170694724d), new NpgsqlTypes.NpgsqlPoint(x: 0.007790379690101656d, y: 0.19815016163464882d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015276112595295599d, y: 0.3687518797724355d), new NpgsqlTypes.NpgsqlPoint(x: 0.7053141394766528d, y: 0.7808992553390111d), new NpgsqlTypes.NpgsqlPoint(x: 0.08421706716273092d, y: 0.46948690488235d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1258669532022304d, y: 0.3696684575064302d), new NpgsqlTypes.NpgsqlPoint(x: 0.2368260377057635d, y: 0.7914290469954642d), new NpgsqlTypes.NpgsqlPoint(x: 0.5388203725603047d, y: 0.2624768817479506d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9676510468376986d, y: 0.42972931645862666d), new NpgsqlTypes.NpgsqlPoint(x: 0.3793494361745219d, y: 0.04290273495155905d), new NpgsqlTypes.NpgsqlPoint(x: 0.47577824842873573d, y: 0.7842694666043263d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9964573203183545d, y: 0.8131359704132901d), new NpgsqlTypes.NpgsqlPoint(x: 0.8664732941947313d, y: 0.18714356543386956d), new NpgsqlTypes.NpgsqlPoint(x: 0.05490947877947605d, y: 0.6754232493951412d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.562724588114225d, y: 0.9480325821500085d), new NpgsqlTypes.NpgsqlPoint(x: 0.11190299425623529d, y: 0.006939265289452545d), new NpgsqlTypes.NpgsqlPoint(x: 0.14915513886136456d, y: 0.46569969238969344d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5611264729925373d, y: 0.734764347451312d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361586144492367d, y: 0.23376615814424362d), new NpgsqlTypes.NpgsqlPoint(x: 0.05294816435696181d, y: 0.5982364654695477d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13619765605227752d, y: 0.8178053986760185d), new NpgsqlTypes.NpgsqlPoint(x: 0.539284614722645d, y: 0.6393947871024187d), new NpgsqlTypes.NpgsqlPoint(x: 0.36539349723174497d, y: 0.5900008680580888d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4185920957357566d, y: 0.9134815507020604d), new NpgsqlTypes.NpgsqlPoint(x: 0.715698473591636d, y: 0.8062417237329821d), new NpgsqlTypes.NpgsqlPoint(x: 0.9442259980446596d, y: 0.0534300519887726d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18007964001407895d, y: 0.7920681771107236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7822600731749659d, y: 0.5810322276097891d), new NpgsqlTypes.NpgsqlPoint(x: 0.6935551274900222d, y: 0.6130176445303361d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03379107967107653d, y: 0.9786183361566113d), new NpgsqlTypes.NpgsqlPoint(x: 0.022893525464766085d, y: 0.25140759617593533d), new NpgsqlTypes.NpgsqlPoint(x: 0.30738531898636945d, y: 0.46428608331542054d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8527119758413458d, y: 0.5839014850028449d), new NpgsqlTypes.NpgsqlPoint(x: 0.9375584458863357d, y: 0.0026220881623477688d), new NpgsqlTypes.NpgsqlPoint(x: 0.9663022074923076d, y: 0.6084916723323112d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.772198108807845d, y: 0.786804329828887d), new NpgsqlTypes.NpgsqlPoint(x: 0.2239935618083282d, y: 0.6229894388850515d), new NpgsqlTypes.NpgsqlPoint(x: 0.8383576903554257d, y: 0.7368421603383772d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03499665154924758d, y: 0.804820594310963d), new NpgsqlTypes.NpgsqlPoint(x: 0.18458235193319417d, y: 0.6107593965997761d), new NpgsqlTypes.NpgsqlPoint(x: 0.25629909124912165d, y: 0.17401250444749905d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5124550899838742d, y: 0.37755210854222987d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030856044686575d, y: 0.8608199578902372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9307611148630454d, y: 0.6241778846838533d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3032120042657933d, y: 0.5803786128262443d), new NpgsqlTypes.NpgsqlPoint(x: 0.3675417113563815d, y: 0.5982191744164915d), new NpgsqlTypes.NpgsqlPoint(x: 0.781646323049381d, y: 0.7606115854201042d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3627180958075421d, y: 0.2687808251403019d), new NpgsqlTypes.NpgsqlPoint(x: 0.47275031018153924d, y: 0.1397842586389676d), new NpgsqlTypes.NpgsqlPoint(x: 0.3632022554951949d, y: 0.00799529163139101d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.506117408008544d, y: 0.3719072343217633d), new NpgsqlTypes.NpgsqlPoint(x: 0.13671731955670308d, y: 0.8811912035130864d), new NpgsqlTypes.NpgsqlPoint(x: 0.7554795060747177d, y: 0.5979592441220941d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2924197662863588d, y: 0.17480350093694141d), new NpgsqlTypes.NpgsqlPoint(x: 0.007761461623156385d, y: 0.9791687854991431d), new NpgsqlTypes.NpgsqlPoint(x: 0.06694112704191235d, y: 0.3761093640710007d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16283640155542245d, y: 0.5075592310464347d), new NpgsqlTypes.NpgsqlPoint(x: 0.09430473874021084d, y: 0.477549701353045d), new NpgsqlTypes.NpgsqlPoint(x: 0.07155904276832181d, y: 0.08071696672303397d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3863668610798634d, y: 0.11840959876235191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7450206682729763d, y: 0.709143462796651d), new NpgsqlTypes.NpgsqlPoint(x: 0.654259413979562d, y: 0.8641238350639145d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9389887252467173d, y: 0.931360036962909d), new NpgsqlTypes.NpgsqlPoint(x: 0.7294408747243272d, y: 0.6912250075252047d), new NpgsqlTypes.NpgsqlPoint(x: 0.8482623928222476d, y: 0.8626277209462123d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3091134893044878d, y: 0.25413696596811997d), new NpgsqlTypes.NpgsqlPoint(x: 0.5795804238186278d, y: 0.612688086395267d), new NpgsqlTypes.NpgsqlPoint(x: 0.8740557655795685d, y: 0.41513885064649014d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07027784004081228d, y: 0.5006643183659713d), new NpgsqlTypes.NpgsqlPoint(x: 0.7365903652091186d, y: 0.6320524469870952d), new NpgsqlTypes.NpgsqlPoint(x: 0.07930917359022438d, y: 0.7343674094886536d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5014627678041759d, y: 0.37940457316412235d), new NpgsqlTypes.NpgsqlPoint(x: 0.30372276409220933d, y: 0.6535709532625132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5097114293029807d, y: 0.8608195134356726d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5012080436940057d, y: 0.8667893136513207d), new NpgsqlTypes.NpgsqlPoint(x: 0.13258548444193208d, y: 0.568215550208478d), new NpgsqlTypes.NpgsqlPoint(x: 0.6149976481141315d, y: 0.7021037505897995d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7942190355830967d, y: 0.6697368896730762d), new NpgsqlTypes.NpgsqlPoint(x: 0.9248395168322832d, y: 0.8619088754044343d), new NpgsqlTypes.NpgsqlPoint(x: 0.8499413305709002d, y: 0.5180469762552851d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4481867391562122d, y: 0.9119873572533107d), new NpgsqlTypes.NpgsqlPoint(x: 0.6039488786785018d, y: 0.3979660105995976d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799288059930604d, y: 0.28410642738834624d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4651322353118218d, y: 0.630011874752983d), new NpgsqlTypes.NpgsqlPoint(x: 0.74991257815658d, y: 0.034356461446329645d), new NpgsqlTypes.NpgsqlPoint(x: 0.29466820127503024d, y: 0.11579226978919055d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4591841278575831d, y: 0.6735609886127955d), new NpgsqlTypes.NpgsqlPoint(x: 0.629735399324854d, y: 0.5440138417212852d), new NpgsqlTypes.NpgsqlPoint(x: 0.8480614103413945d, y: 0.6303094118834295d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7991429268208929d, y: 0.6873928374902868d), new NpgsqlTypes.NpgsqlPoint(x: 0.7261640405972043d, y: 0.7575144014736539d), new NpgsqlTypes.NpgsqlPoint(x: 0.8477328540076761d, y: 0.4627690118025145d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16136183075308408d, y: 0.8385287853937732d), new NpgsqlTypes.NpgsqlPoint(x: 0.14688641110324052d, y: 0.6975296125165584d), new NpgsqlTypes.NpgsqlPoint(x: 0.4888205477591171d, y: 0.03751031351776357d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2746567040655805d, y: 0.7576654599298046d), new NpgsqlTypes.NpgsqlPoint(x: 0.26042359439324625d, y: 0.912314600473466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7295270592020926d, y: 0.203262036751802d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9136842861066918d, y: 0.1679558368181937d), new NpgsqlTypes.NpgsqlPoint(x: 0.35815346740072596d, y: 0.7687341723046927d), new NpgsqlTypes.NpgsqlPoint(x: 0.08958232193755078d, y: 0.960057384191759d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.675032661774474d, y: 0.946824271515457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626784217293271d, y: 0.7162445934923336d), new NpgsqlTypes.NpgsqlPoint(x: 0.4583449256796748d, y: 0.26188630619746867d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.356211900653446d, y: 0.6232549622764287d), new NpgsqlTypes.NpgsqlPoint(x: 0.41656070866519324d, y: 0.07095676259835249d), new NpgsqlTypes.NpgsqlPoint(x: 0.7408346061698244d, y: 0.3580791272254281d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03183370167972632d, y: 0.33316200193380396d), new NpgsqlTypes.NpgsqlPoint(x: 0.4486775791943297d, y: 0.14207885259564323d), new NpgsqlTypes.NpgsqlPoint(x: 0.303526496558705d, y: 0.768145658965612d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1452609753996632d, y: 0.8408626604180567d), new NpgsqlTypes.NpgsqlPoint(x: 0.21448751738209315d, y: 0.43396113911092415d), new NpgsqlTypes.NpgsqlPoint(x: 0.9498101129195904d, y: 0.07947561596708697d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9908899146963542d, y: 0.19519909032112714d), new NpgsqlTypes.NpgsqlPoint(x: 0.5156255068697472d, y: 0.22933490275281476d), new NpgsqlTypes.NpgsqlPoint(x: 0.9768549334573162d, y: 0.6371175574191967d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9550301448607829d, y: 0.7511489834219013d), new NpgsqlTypes.NpgsqlPoint(x: 0.4475371698079147d, y: 0.4003252655342612d), new NpgsqlTypes.NpgsqlPoint(x: 0.36576215194702155d, y: 0.5398830953135616d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6381021782263984d, y: 0.046810915850073465d), new NpgsqlTypes.NpgsqlPoint(x: 0.2661342416102632d, y: 0.8583492753290843d), new NpgsqlTypes.NpgsqlPoint(x: 0.18967811129829126d, y: 0.7941805482368798d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35096735091375575d, y: 0.9733976252741314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6998379421660694d, y: 0.29806167199640266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5116019574922605d, y: 0.16630188689052472d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4609124020135137d, y: 0.6656092801912609d), new NpgsqlTypes.NpgsqlPoint(x: 0.07881757485269458d, y: 0.4425057089361535d), new NpgsqlTypes.NpgsqlPoint(x: 0.8234950044994787d, y: 0.8975245442648526d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3758860525533543d, y: 0.2200012307183783d), new NpgsqlTypes.NpgsqlPoint(x: 0.25321514197922146d, y: 0.7413238145594813d), new NpgsqlTypes.NpgsqlPoint(x: 0.24884262058626505d, y: 0.3551889906417859d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9878591827364954d, y: 0.6703425263233667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5041802684570574d, y: 0.5103962127962033d), new NpgsqlTypes.NpgsqlPoint(x: 0.6045513841020941d, y: 0.015565439803823855d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.295349787435049d, y: 0.942285093658385d), new NpgsqlTypes.NpgsqlPoint(x: 0.3734848412062657d, y: 0.0630284550910295d), new NpgsqlTypes.NpgsqlPoint(x: 0.08762676390229551d, y: 0.1960947393829776d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4229233269916328d, y: 0.9217485571098338d), new NpgsqlTypes.NpgsqlPoint(x: 0.29407782473994115d, y: 0.5198467429199287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9417002083975893d, y: 0.9116598688634037d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44104968500649d, y: 0.02134358884896248d), new NpgsqlTypes.NpgsqlPoint(x: 0.18408757685038324d, y: 0.973570502951859d), new NpgsqlTypes.NpgsqlPoint(x: 0.20165806696526611d, y: 0.06303670675177564d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8335652259440063d, y: 0.24287433908517653d), new NpgsqlTypes.NpgsqlPoint(x: 0.09645848528216083d, y: 0.7042423145118123d), new NpgsqlTypes.NpgsqlPoint(x: 0.40471127439328614d, y: 0.2841625680162976d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8681580089535671d, y: 0.42895615469443527d), new NpgsqlTypes.NpgsqlPoint(x: 0.77627012613172d, y: 0.4798186433603534d), new NpgsqlTypes.NpgsqlPoint(x: 0.8317939459456035d, y: 0.7321560789378027d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31504620168158726d, y: 0.677167562774502d), new NpgsqlTypes.NpgsqlPoint(x: 0.1333716504860858d, y: 0.21206774450200883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6411293592368544d, y: 0.7309921588825244d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11091613067523842d, y: 0.9656455970496093d), new NpgsqlTypes.NpgsqlPoint(x: 0.5128759547009505d, y: 0.8322383493855937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8107520252971412d, y: 0.518330694466319d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9602542109165475d, y: 0.6039046016655529d), new NpgsqlTypes.NpgsqlPoint(x: 0.9115531517613396d, y: 0.6474873424733572d), new NpgsqlTypes.NpgsqlPoint(x: 0.7990712891879518d, y: 0.6918032702455588d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9918579684973169d, y: 0.14631445666377285d), new NpgsqlTypes.NpgsqlPoint(x: 0.7780781824996515d, y: 0.5165576566741577d), new NpgsqlTypes.NpgsqlPoint(x: 0.6515985722365867d, y: 0.7261698478936459d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41043528024314924d, y: 0.9752344196645708d), new NpgsqlTypes.NpgsqlPoint(x: 0.14698596986210055d, y: 0.5523553403178038d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903602119527939d, y: 0.9635373001265611d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3123491960963617d, y: 0.5119837457708054d), new NpgsqlTypes.NpgsqlPoint(x: 0.5147910760447431d, y: 0.6237894612365751d), new NpgsqlTypes.NpgsqlPoint(x: 0.21869648638124306d, y: 0.3706967778429727d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1884292856871077d, y: 0.529892790206238d), new NpgsqlTypes.NpgsqlPoint(x: 0.8622903346411994d, y: 0.4814601556305341d), new NpgsqlTypes.NpgsqlPoint(x: 0.5104095653819648d, y: 0.674571513715499d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19889132996869918d, y: 0.7708018481276553d), new NpgsqlTypes.NpgsqlPoint(x: 0.23669271190167318d, y: 0.9723290058743822d), new NpgsqlTypes.NpgsqlPoint(x: 0.3464036516550518d, y: 0.9975002558390771d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7606996117076346d, y: 0.41025718897232477d), new NpgsqlTypes.NpgsqlPoint(x: 0.6270835645839352d, y: 0.32835273264866616d), new NpgsqlTypes.NpgsqlPoint(x: 0.35320769733125856d, y: 0.5549734401353159d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41330521287839583d, y: 0.0334884751533433d), new NpgsqlTypes.NpgsqlPoint(x: 0.6383156274080058d, y: 0.013312921094527086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7842608046505113d, y: 0.3789635515122062d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.939119178826389d, y: 0.9866306102433245d), new NpgsqlTypes.NpgsqlPoint(x: 0.939242474477792d, y: 0.335079122695245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5708691298297643d, y: 0.8681546665734158d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07809046763679606d, y: 0.026168712130712923d), new NpgsqlTypes.NpgsqlPoint(x: 0.08470412851631426d, y: 0.7003424250570824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8473946900635584d, y: 0.7048931276025332d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07400925235060707d, y: 0.6949860755306273d), new NpgsqlTypes.NpgsqlPoint(x: 0.8955888187520283d, y: 0.882811172207966d), new NpgsqlTypes.NpgsqlPoint(x: 0.1523318061854666d, y: 0.39993937881113384d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12756026940025134d, y: 0.97523768565922d), new NpgsqlTypes.NpgsqlPoint(x: 0.05984224352300549d, y: 0.16578722589207673d), new NpgsqlTypes.NpgsqlPoint(x: 0.745922718084947d, y: 0.9567039773597326d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3916885560840515d, y: 0.3671898684068302d), new NpgsqlTypes.NpgsqlPoint(x: 0.3957322004452465d, y: 0.05810247499189325d), new NpgsqlTypes.NpgsqlPoint(x: 0.6370328662506191d, y: 0.8875352096125639d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5858292077346524d, y: 0.2863875781263088d), new NpgsqlTypes.NpgsqlPoint(x: 0.1315431536908216d, y: 0.04152445942847227d), new NpgsqlTypes.NpgsqlPoint(x: 0.28160919002038665d, y: 0.1692179024468966d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7691117208134399d, y: 0.57991974875154d), new NpgsqlTypes.NpgsqlPoint(x: 0.786686664861542d, y: 0.2245632247278263d), new NpgsqlTypes.NpgsqlPoint(x: 0.7521544127390185d, y: 0.2123680425240757d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5544331739616162d, y: 0.17811520182094864d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292060983620097d, y: 0.6131953170694724d), new NpgsqlTypes.NpgsqlPoint(x: 0.007790379690101656d, y: 0.19815016163464882d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015276112595295599d, y: 0.3687518797724355d), new NpgsqlTypes.NpgsqlPoint(x: 0.7053141394766528d, y: 0.7808992553390111d), new NpgsqlTypes.NpgsqlPoint(x: 0.08421706716273092d, y: 0.46948690488235d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1258669532022304d, y: 0.3696684575064302d), new NpgsqlTypes.NpgsqlPoint(x: 0.2368260377057635d, y: 0.7914290469954642d), new NpgsqlTypes.NpgsqlPoint(x: 0.5388203725603047d, y: 0.2624768817479506d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9676510468376986d, y: 0.42972931645862666d), new NpgsqlTypes.NpgsqlPoint(x: 0.3793494361745219d, y: 0.04290273495155905d), new NpgsqlTypes.NpgsqlPoint(x: 0.47577824842873573d, y: 0.7842694666043263d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9964573203183545d, y: 0.8131359704132901d), new NpgsqlTypes.NpgsqlPoint(x: 0.8664732941947313d, y: 0.18714356543386956d), new NpgsqlTypes.NpgsqlPoint(x: 0.05490947877947605d, y: 0.6754232493951412d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.562724588114225d, y: 0.9480325821500085d), new NpgsqlTypes.NpgsqlPoint(x: 0.11190299425623529d, y: 0.006939265289452545d), new NpgsqlTypes.NpgsqlPoint(x: 0.14915513886136456d, y: 0.46569969238969344d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5611264729925373d, y: 0.734764347451312d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361586144492367d, y: 0.23376615814424362d), new NpgsqlTypes.NpgsqlPoint(x: 0.05294816435696181d, y: 0.5982364654695477d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13619765605227752d, y: 0.8178053986760185d), new NpgsqlTypes.NpgsqlPoint(x: 0.539284614722645d, y: 0.6393947871024187d), new NpgsqlTypes.NpgsqlPoint(x: 0.36539349723174497d, y: 0.5900008680580888d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4185920957357566d, y: 0.9134815507020604d), new NpgsqlTypes.NpgsqlPoint(x: 0.715698473591636d, y: 0.8062417237329821d), new NpgsqlTypes.NpgsqlPoint(x: 0.9442259980446596d, y: 0.0534300519887726d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18007964001407895d, y: 0.7920681771107236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7822600731749659d, y: 0.5810322276097891d), new NpgsqlTypes.NpgsqlPoint(x: 0.6935551274900222d, y: 0.6130176445303361d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03379107967107653d, y: 0.9786183361566113d), new NpgsqlTypes.NpgsqlPoint(x: 0.022893525464766085d, y: 0.25140759617593533d), new NpgsqlTypes.NpgsqlPoint(x: 0.30738531898636945d, y: 0.46428608331542054d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8527119758413458d, y: 0.5839014850028449d), new NpgsqlTypes.NpgsqlPoint(x: 0.9375584458863357d, y: 0.0026220881623477688d), new NpgsqlTypes.NpgsqlPoint(x: 0.9663022074923076d, y: 0.6084916723323112d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.772198108807845d, y: 0.786804329828887d), new NpgsqlTypes.NpgsqlPoint(x: 0.2239935618083282d, y: 0.6229894388850515d), new NpgsqlTypes.NpgsqlPoint(x: 0.8383576903554257d, y: 0.7368421603383772d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpath0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpath0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0m m
LEFT JOIN public.binary_npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0M>(15);

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
                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpath0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpath0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpath0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpath0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpath0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpath0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

