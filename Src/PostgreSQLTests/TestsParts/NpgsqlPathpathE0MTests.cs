

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

        private readonly NpgsqlPathpathE0M[] _testData = new NpgsqlPathpathE0M[]
        {
            new NpgsqlPathpathE0M
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9560380313347197d, y: 0.8024234300428668d), new NpgsqlTypes.NpgsqlPoint(x: 0.5632383754645234d, y: 0.2822530603557689d), new NpgsqlTypes.NpgsqlPoint(x: 0.29506757018921737d, y: 0.10302918050894694d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015882990530094454d, y: 0.6325163605974335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6840231889055965d, y: 0.6160748141272416d), new NpgsqlTypes.NpgsqlPoint(x: 0.13860161273788973d, y: 0.6803072292170946d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8354685769859929d, y: 0.4018165225680834d), new NpgsqlTypes.NpgsqlPoint(x: 0.6483359470024709d, y: 0.9956262841149032d), new NpgsqlTypes.NpgsqlPoint(x: 0.09817365150371637d, y: 0.8243196410576105d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41341537677348805d, y: 0.10550965059948136d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348042310526728d, y: 0.6008279016041915d), new NpgsqlTypes.NpgsqlPoint(x: 0.922685486886141d, y: 0.39515383120261616d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2579110544939188d, y: 0.6536147729291667d), new NpgsqlTypes.NpgsqlPoint(x: 0.3813064678982424d, y: 0.628275833860685d), new NpgsqlTypes.NpgsqlPoint(x: 0.47166004266728845d, y: 0.8777884430153335d)),
},
            new NpgsqlPathpathE0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8356352701859182d, y: 0.5646916856561421d), new NpgsqlTypes.NpgsqlPoint(x: 0.5115477493736272d, y: 0.6130155285936967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8541852561538267d, y: 0.5890650064829097d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45632489498013273d, y: 0.3641056898100008d), new NpgsqlTypes.NpgsqlPoint(x: 0.7582943125966677d, y: 0.509144113983515d), new NpgsqlTypes.NpgsqlPoint(x: 0.007399616437315681d, y: 0.3000343613823553d)),
},
            new NpgsqlPathpathE0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23945411026293628d, y: 0.35531694318042883d), new NpgsqlTypes.NpgsqlPoint(x: 0.496455588659912d, y: 0.2224288304971772d), new NpgsqlTypes.NpgsqlPoint(x: 0.4910647830064022d, y: 0.5280899608891477d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7043330964412058d, y: 0.20819848784518302d), new NpgsqlTypes.NpgsqlPoint(x: 0.16969771570255465d, y: 0.40591758960361835d), new NpgsqlTypes.NpgsqlPoint(x: 0.0035716254449968954d, y: 0.05915721695137799d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6767124334999443d, y: 0.33926425508519964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4013366416774473d, y: 0.37925146895120965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6678296801569135d, y: 0.021882523262105824d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6019335343350917d, y: 0.35148035977976844d), new NpgsqlTypes.NpgsqlPoint(x: 0.27933551975086746d, y: 0.26517258846791203d), new NpgsqlTypes.NpgsqlPoint(x: 0.32669080253945515d, y: 0.006571338844853725d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8878234149010089d, y: 0.8864894711421559d), new NpgsqlTypes.NpgsqlPoint(x: 0.43439765834775357d, y: 0.3970589279447264d), new NpgsqlTypes.NpgsqlPoint(x: 0.06329976732650511d, y: 0.20393803240523434d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09233275419800613d, y: 0.3476212353911019d), new NpgsqlTypes.NpgsqlPoint(x: 0.03352909224945988d, y: 0.03959895372232025d), new NpgsqlTypes.NpgsqlPoint(x: 0.3106917227748206d, y: 0.2729922638274951d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5914963036762906d, y: 0.7289420228698514d), new NpgsqlTypes.NpgsqlPoint(x: 0.37456654091620567d, y: 0.5450275670610353d), new NpgsqlTypes.NpgsqlPoint(x: 0.10955405696133191d, y: 0.0806814358985376d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5870777791088029d, y: 0.8463938098476094d), new NpgsqlTypes.NpgsqlPoint(x: 0.9554313861084107d, y: 0.21655295211273007d), new NpgsqlTypes.NpgsqlPoint(x: 0.004753567488267274d, y: 0.4971633703797783d)),
},
            new NpgsqlPathpathE0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6293162959930186d, y: 0.4702091991130285d), new NpgsqlTypes.NpgsqlPoint(x: 0.053957771439414715d, y: 0.19741329906786442d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843417269331082d, y: 0.47756592813630405d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015928004840648713d, y: 0.4672603043263701d), new NpgsqlTypes.NpgsqlPoint(x: 0.8782004116729856d, y: 0.976229809871464d), new NpgsqlTypes.NpgsqlPoint(x: 0.603419563144027d, y: 0.609425484489139d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2098631690904893d, y: 0.6536271893895085d), new NpgsqlTypes.NpgsqlPoint(x: 0.6840073055962542d, y: 0.9172644228810956d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129528830785204d, y: 0.5498072922218641d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26954438658136737d, y: 0.36262512728030194d), new NpgsqlTypes.NpgsqlPoint(x: 0.1596086353786894d, y: 0.5494591925456733d), new NpgsqlTypes.NpgsqlPoint(x: 0.7839835736037973d, y: 0.9379823776863987d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0495738941873195d, y: 0.9893216083223129d), new NpgsqlTypes.NpgsqlPoint(x: 0.13185901052722615d, y: 0.9053975212544295d), new NpgsqlTypes.NpgsqlPoint(x: 0.5489593003948839d, y: 0.34349060148299004d)),
},
            new NpgsqlPathpathE0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13046970125238888d, y: 0.7650577258846657d), new NpgsqlTypes.NpgsqlPoint(x: 0.18944986801325137d, y: 0.46680869879058307d), new NpgsqlTypes.NpgsqlPoint(x: 0.3241819802585194d, y: 0.08896774355435055d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5869612507204756d, y: 0.5009372751682252d), new NpgsqlTypes.NpgsqlPoint(x: 0.671774306295613d, y: 0.11676318509638295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7334051605018781d, y: 0.6591126533546378d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26231273280805145d, y: 0.18061598867475992d), new NpgsqlTypes.NpgsqlPoint(x: 0.6345874627822138d, y: 0.6016002793465306d), new NpgsqlTypes.NpgsqlPoint(x: 0.21721928563906123d, y: 0.536902748776576d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08723310305132204d, y: 0.4490263397646227d), new NpgsqlTypes.NpgsqlPoint(x: 0.40956065992080526d, y: 0.44397341123877976d), new NpgsqlTypes.NpgsqlPoint(x: 0.007805259448557034d, y: 0.2079150176878819d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4918843646929648d, y: 0.2614749647974125d), new NpgsqlTypes.NpgsqlPoint(x: 0.49036968987163554d, y: 0.7147700135166798d), new NpgsqlTypes.NpgsqlPoint(x: 0.2526175686559753d, y: 0.47242403757906626d)),
},
            new NpgsqlPathpathE0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9873509953223406d, y: 0.7477587137826057d), new NpgsqlTypes.NpgsqlPoint(x: 0.08754667071328204d, y: 0.6018306938010934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8484071544558921d, y: 0.008215937653532124d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5264786030071597d, y: 0.40585383404534003d), new NpgsqlTypes.NpgsqlPoint(x: 0.4282095194464859d, y: 0.7796750227336645d), new NpgsqlTypes.NpgsqlPoint(x: 0.01154467727514441d, y: 0.04062357352635526d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12475248928508931d, y: 0.3707348959883715d), new NpgsqlTypes.NpgsqlPoint(x: 0.534887201084414d, y: 0.697440781960977d), new NpgsqlTypes.NpgsqlPoint(x: 0.556912350471009d, y: 0.10017867044948559d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4232842733569607d, y: 0.34611892207267725d), new NpgsqlTypes.NpgsqlPoint(x: 0.29803418781349145d, y: 0.9739506092031609d), new NpgsqlTypes.NpgsqlPoint(x: 0.38426522300683186d, y: 0.5137732880243019d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9006385853459026d, y: 0.29832066587990735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8494820684080934d, y: 0.09654843632771082d), new NpgsqlTypes.NpgsqlPoint(x: 0.844903422344068d, y: 0.8121649408683947d)),
},
            new NpgsqlPathpathE0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6230413145193346d, y: 0.8219441369017688d), new NpgsqlTypes.NpgsqlPoint(x: 0.3981976102649186d, y: 0.6576874230555224d), new NpgsqlTypes.NpgsqlPoint(x: 0.4027604143081822d, y: 0.40232925657551566d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7381047302213299d, y: 0.39869372430565664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7528138353231324d, y: 0.9479828463214064d), new NpgsqlTypes.NpgsqlPoint(x: 0.3108883782985703d, y: 0.9688817458690447d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8489977726302095d, y: 0.5390718745834043d), new NpgsqlTypes.NpgsqlPoint(x: 0.20846154153623597d, y: 0.6960826113941072d), new NpgsqlTypes.NpgsqlPoint(x: 0.43158202360180464d, y: 0.21554391237807813d)),
},
            new NpgsqlPathpathE0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9592815958619416d, y: 0.9565785407841962d), new NpgsqlTypes.NpgsqlPoint(x: 0.9256938364198638d, y: 0.3288130211622752d), new NpgsqlTypes.NpgsqlPoint(x: 0.5616075434726752d, y: 0.696520915517851d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9708992694938575d, y: 0.16215846879508256d), new NpgsqlTypes.NpgsqlPoint(x: 0.08165466789931075d, y: 0.4809066956198734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144288975917734d, y: 0.35935722632804334d)),
},
            new NpgsqlPathpathE0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7565986525539145d, y: 0.10588554018510055d), new NpgsqlTypes.NpgsqlPoint(x: 0.4468189547634287d, y: 0.8807227748412326d), new NpgsqlTypes.NpgsqlPoint(x: 0.47401331166182104d, y: 0.21970040171588812d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7967964041426769d, y: 0.04418461949316177d), new NpgsqlTypes.NpgsqlPoint(x: 0.967973532168394d, y: 0.2765094073627856d), new NpgsqlTypes.NpgsqlPoint(x: 0.6612307065963106d, y: 0.24034492923824968d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7176545625956516d, y: 0.10097848762014938d), new NpgsqlTypes.NpgsqlPoint(x: 0.8253294169889246d, y: 0.49692612315340146d), new NpgsqlTypes.NpgsqlPoint(x: 0.5716077449087968d, y: 0.9111718123535696d)),
},
            new NpgsqlPathpathE0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11618718059854682d, y: 0.5658996196580783d), new NpgsqlTypes.NpgsqlPoint(x: 0.3935964814390377d, y: 0.3045037527621359d), new NpgsqlTypes.NpgsqlPoint(x: 0.5602331463204623d, y: 0.11929915351994047d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0720063051934271d, y: 0.4624885511504334d), new NpgsqlTypes.NpgsqlPoint(x: 0.23206309494974564d, y: 0.857620114195001d), new NpgsqlTypes.NpgsqlPoint(x: 0.6990770254582577d, y: 0.2508044928150912d)),
},
            new NpgsqlPathpathE0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6935883580595109d, y: 0.07769323695888675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8604525887957778d, y: 0.08310964902344986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5693100367925408d, y: 0.5595597910369717d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7567308761485062d, y: 0.2357590055779869d), new NpgsqlTypes.NpgsqlPoint(x: 0.6630689914566682d, y: 0.7755484050428263d), new NpgsqlTypes.NpgsqlPoint(x: 0.42038976722304777d, y: 0.2916489566888746d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4578434534600889d, y: 0.8649308879451308d), new NpgsqlTypes.NpgsqlPoint(x: 0.7611715715294886d, y: 0.5603388711076247d), new NpgsqlTypes.NpgsqlPoint(x: 0.3333232922513719d, y: 0.29800932527851554d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.568917233513545d, y: 0.7788822721669094d), new NpgsqlTypes.NpgsqlPoint(x: 0.6358579758506825d, y: 0.18103852218819938d), new NpgsqlTypes.NpgsqlPoint(x: 0.06200511893711702d, y: 0.046997442660358435d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34553665646696574d, y: 0.5485680484177172d), new NpgsqlTypes.NpgsqlPoint(x: 0.0687292961587671d, y: 0.26946192525152846d), new NpgsqlTypes.NpgsqlPoint(x: 0.9060802810119476d, y: 0.062374249073579024d)),
},
            new NpgsqlPathpathE0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6230019369742772d, y: 0.15467033250835738d), new NpgsqlTypes.NpgsqlPoint(x: 0.7747763354772346d, y: 0.6591251182999006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7893435742399616d, y: 0.4033233117395768d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.845509770736668d, y: 0.01975354030787868d), new NpgsqlTypes.NpgsqlPoint(x: 0.17420765678362715d, y: 0.9018644173265344d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354113974875102d, y: 0.3810176508358367d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6006218101689941d, y: 0.8793238855405981d), new NpgsqlTypes.NpgsqlPoint(x: 0.423211699363917d, y: 0.06980615357948539d), new NpgsqlTypes.NpgsqlPoint(x: 0.637023866669936d, y: 0.24678083380466054d)),
},
            new NpgsqlPathpathE0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6167886601065987d, y: 0.9423577552729243d), new NpgsqlTypes.NpgsqlPoint(x: 0.14842640092050885d, y: 0.6173530320108882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5800807071624936d, y: 0.8905581362315178d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9734639788329211d, y: 0.571999689204494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728037092210806d, y: 0.9120664202149397d), new NpgsqlTypes.NpgsqlPoint(x: 0.2104562105227591d, y: 0.7291729559764897d)),
},
            new NpgsqlPathpathE0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8403281948806732d, y: 0.6856754170862559d), new NpgsqlTypes.NpgsqlPoint(x: 0.3498850462424802d, y: 0.4016202337017045d), new NpgsqlTypes.NpgsqlPoint(x: 0.6704002454229735d, y: 0.28675942023595435d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2303138440822584d, y: 0.7327460069099829d), new NpgsqlTypes.NpgsqlPoint(x: 0.5160278932981448d, y: 0.3919394120583556d), new NpgsqlTypes.NpgsqlPoint(x: 0.42706040287181124d, y: 0.11058914394065522d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7979188909728241d, y: 0.89599897267959d), new NpgsqlTypes.NpgsqlPoint(x: 0.24290083027158282d, y: 0.4487132216510339d), new NpgsqlTypes.NpgsqlPoint(x: 0.22902670148563775d, y: 0.5106460862252528d)),
},
            new NpgsqlPathpathE0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9413892777519189d, y: 0.6340121836166313d), new NpgsqlTypes.NpgsqlPoint(x: 0.12429022673206536d, y: 0.504166602984255d), new NpgsqlTypes.NpgsqlPoint(x: 0.4131466086655059d, y: 0.3683787500444188d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5881613886582051d, y: 0.7799515965803818d), new NpgsqlTypes.NpgsqlPoint(x: 0.12386776821297518d, y: 0.026820170944816035d), new NpgsqlTypes.NpgsqlPoint(x: 0.31126594144089037d, y: 0.9434635046355454d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3737724621757429d, y: 0.4263209799615487d), new NpgsqlTypes.NpgsqlPoint(x: 0.9617955531801733d, y: 0.8288076166804063d), new NpgsqlTypes.NpgsqlPoint(x: 0.2949063081891611d, y: 0.27018725214862194d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6392272315849814d, y: 0.6829458639898732d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512803422540115d, y: 0.06448091254698474d), new NpgsqlTypes.NpgsqlPoint(x: 0.5196735772511857d, y: 0.24752613463054196d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4236080503492834d, y: 0.8577889748419818d), new NpgsqlTypes.NpgsqlPoint(x: 0.8051545683059745d, y: 0.733893108594696d), new NpgsqlTypes.NpgsqlPoint(x: 0.9988103942497136d, y: 0.9577443165529412d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01877835655480542d, y: 0.9151190431266802d), new NpgsqlTypes.NpgsqlPoint(x: 0.8362124341515299d, y: 0.25857992256111983d), new NpgsqlTypes.NpgsqlPoint(x: 0.19620571939162368d, y: 0.6594982550146044d)),
},
            new NpgsqlPathpathE0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.041004152347226874d, y: 0.5495371003735058d), new NpgsqlTypes.NpgsqlPoint(x: 0.7187594094893175d, y: 0.9916969392934473d), new NpgsqlTypes.NpgsqlPoint(x: 0.5293066376001704d, y: 0.9360140350512179d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2489495932364304d, y: 0.1746334871527625d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301596348490496d, y: 0.648122941867777d), new NpgsqlTypes.NpgsqlPoint(x: 0.09185225372921046d, y: 0.44093278090420673d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04784779910661063d, y: 0.26364819947371376d), new NpgsqlTypes.NpgsqlPoint(x: 0.18818866198422046d, y: 0.22658435162721902d), new NpgsqlTypes.NpgsqlPoint(x: 0.15128376843162716d, y: 0.839375027003722d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3508036050986503d, y: 0.46791924724978806d), new NpgsqlTypes.NpgsqlPoint(x: 0.3243737789305813d, y: 0.4258158854042954d), new NpgsqlTypes.NpgsqlPoint(x: 0.16444555801317284d, y: 0.9482786315792581d)),
},
            new NpgsqlPathpathE0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8522158000161137d, y: 0.6740012154882491d), new NpgsqlTypes.NpgsqlPoint(x: 0.9511717147988767d, y: 0.8162271592700032d), new NpgsqlTypes.NpgsqlPoint(x: 0.7140972869511795d, y: 0.4194219137719942d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9262007772997566d, y: 0.9276826628655376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9116797536796698d, y: 0.4412931723798249d), new NpgsqlTypes.NpgsqlPoint(x: 0.8258519168547275d, y: 0.17176218499082296d)),
},
            new NpgsqlPathpathE0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02691145573759446d, y: 0.2714068925743932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5279925569956586d, y: 0.1640580458879335d), new NpgsqlTypes.NpgsqlPoint(x: 0.457133549957486d, y: 0.2731747676337055d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41454539474702756d, y: 0.7887995127181332d), new NpgsqlTypes.NpgsqlPoint(x: 0.12325287607323121d, y: 0.043436621727601654d), new NpgsqlTypes.NpgsqlPoint(x: 0.30882387839696346d, y: 0.8892867567281165d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9435166614787517d, y: 0.6901687421752005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5381289677730938d, y: 0.7916636316047649d), new NpgsqlTypes.NpgsqlPoint(x: 0.28380033592784903d, y: 0.5113174199243473d)),
},
            new NpgsqlPathpathE0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21428209583464242d, y: 0.14170402169818486d), new NpgsqlTypes.NpgsqlPoint(x: 0.5172422856435854d, y: 0.2779672335716522d), new NpgsqlTypes.NpgsqlPoint(x: 0.7671761664670878d, y: 0.9571491661732678d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09392177828780801d, y: 0.9760643840675555d), new NpgsqlTypes.NpgsqlPoint(x: 0.3417296181428493d, y: 0.9869780076501462d), new NpgsqlTypes.NpgsqlPoint(x: 0.02037722414286336d, y: 0.29663636439088015d)),
},
            new NpgsqlPathpathE0M
{
    Id = 153,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07374929192748181d, y: 0.16277030652401614d), new NpgsqlTypes.NpgsqlPoint(x: 0.2778673234447461d, y: 0.885498348005595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7597746396355164d, y: 0.9329700687216091d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5168392635192586d, y: 0.488619696102511d), new NpgsqlTypes.NpgsqlPoint(x: 0.8861145033758285d, y: 0.8635053269079257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7441536119561423d, y: 0.06984767028735417d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 159,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3449520620073855d, y: 0.25888163891668614d), new NpgsqlTypes.NpgsqlPoint(x: 0.9096042730971616d, y: 0.205019207789651d), new NpgsqlTypes.NpgsqlPoint(x: 0.3621948379996187d, y: 0.09271260810738835d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07590824649740424d, y: 0.46140677835501953d), new NpgsqlTypes.NpgsqlPoint(x: 0.6816494441512453d, y: 0.8557205122549348d), new NpgsqlTypes.NpgsqlPoint(x: 0.48981609553792005d, y: 0.6012163521466195d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5986189724353652d, y: 0.7993148301381912d), new NpgsqlTypes.NpgsqlPoint(x: 0.362214940714902d, y: 0.8251614477503436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5702808232498179d, y: 0.7955410398135585d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8474360352260636d, y: 0.7024985617175538d), new NpgsqlTypes.NpgsqlPoint(x: 0.8572087002574043d, y: 0.28003401540733874d), new NpgsqlTypes.NpgsqlPoint(x: 0.899896997463514d, y: 0.776936889341422d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6830266488162118d, y: 0.70759787876535d), new NpgsqlTypes.NpgsqlPoint(x: 0.3951586182204577d, y: 0.13884589933078706d), new NpgsqlTypes.NpgsqlPoint(x: 0.3299192233832603d, y: 0.6202374376827158d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34658637575067497d, y: 0.14776095496308506d), new NpgsqlTypes.NpgsqlPoint(x: 0.2271631134456802d, y: 0.9498199075404754d), new NpgsqlTypes.NpgsqlPoint(x: 0.8238445285856412d, y: 0.9759909628827134d)),
},
            new NpgsqlPathpathE0M
{
    Id = 166,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9945385426826264d, y: 0.3654216028017754d), new NpgsqlTypes.NpgsqlPoint(x: 0.22521989905217432d, y: 0.9860480262729373d), new NpgsqlTypes.NpgsqlPoint(x: 0.146067092293527d, y: 0.11989118601139226d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6856150783477263d, y: 0.9677335139501528d), new NpgsqlTypes.NpgsqlPoint(x: 0.4464199860815996d, y: 0.2363512053749366d), new NpgsqlTypes.NpgsqlPoint(x: 0.40237304389485606d, y: 0.21977889004571316d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9951752344814004d, y: 0.5153111498069014d), new NpgsqlTypes.NpgsqlPoint(x: 0.24036832369103467d, y: 0.7480541685640786d), new NpgsqlTypes.NpgsqlPoint(x: 0.05427984214478587d, y: 0.8684364136318915d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5135206902321202d, y: 0.332218108244445d), new NpgsqlTypes.NpgsqlPoint(x: 0.18269230045677887d, y: 0.46070655429063945d), new NpgsqlTypes.NpgsqlPoint(x: 0.9350283577160541d, y: 0.22675092922981743d)),
},
            new NpgsqlPathpathE0M
{
    Id = 168,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9146027234854657d, y: 0.715597622424504d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412349787310335d, y: 0.7976204520750813d), new NpgsqlTypes.NpgsqlPoint(x: 0.2609397169371629d, y: 0.708000754111313d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2741053277809429d, y: 0.05924636731160993d), new NpgsqlTypes.NpgsqlPoint(x: 0.9021258792743253d, y: 0.01340060295948109d), new NpgsqlTypes.NpgsqlPoint(x: 0.4272864332247934d, y: 0.5964788862290487d)),
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
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
INSERT INTO public.npgsqlpathpathe0m(
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
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5870777791088029d, y: 0.8463938098476094d), new NpgsqlTypes.NpgsqlPoint(x: 0.9554313861084107d, y: 0.21655295211273007d), new NpgsqlTypes.NpgsqlPoint(x: 0.004753567488267274d, y: 0.4971633703797783d))));
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
                Assert.That(nullable, Is.Null);
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
INSERT INTO public.npgsqlpathpathe0m(
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
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0495738941873195d, y: 0.9893216083223129d), new NpgsqlTypes.NpgsqlPoint(x: 0.13185901052722615d, y: 0.9053975212544295d), new NpgsqlTypes.NpgsqlPoint(x: 0.5489593003948839d, y: 0.34349060148299004d))));
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4918843646929648d, y: 0.2614749647974125d), new NpgsqlTypes.NpgsqlPoint(x: 0.49036968987163554d, y: 0.7147700135166798d), new NpgsqlTypes.NpgsqlPoint(x: 0.2526175686559753d, y: 0.47242403757906626d))));
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
                List<NpgsqlPathpathE0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[31],_testData[34], false);
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
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 64, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 143, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 145, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 119, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 18, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 159, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 12, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 72, query1, 27, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 18, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[31],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 143, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[32],_testData[34], false);
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
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 93);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[18], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[19], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[20], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[21], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[22], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[23], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[24], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[10],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[11],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[12],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[13],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[14],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[15],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 44);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[7], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[8], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[9], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[10], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[11], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[12], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[13], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[14], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[15], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[16], false);
                NpgsqlPathpathE0M.AssertModel(models[10],_testData[17], false);
                NpgsqlPathpathE0M.AssertModel(models[11],_testData[18], false);
                NpgsqlPathpathE0M.AssertModel(models[12],_testData[19], false);
                NpgsqlPathpathE0M.AssertModel(models[13],_testData[20], false);
                NpgsqlPathpathE0M.AssertModel(models[14],_testData[21], false);
                NpgsqlPathpathE0M.AssertModel(models[15],_testData[22], false);
                NpgsqlPathpathE0M.AssertModel(models[16],_testData[23], false);
                NpgsqlPathpathE0M.AssertModel(models[17],_testData[24], false);
                NpgsqlPathpathE0M.AssertModel(models[18],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[19],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[20],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[21],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[22],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[23],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[24],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[25],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[26],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[27],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9560380313347197d, y: 0.8024234300428668d), new NpgsqlTypes.NpgsqlPoint(x: 0.5632383754645234d, y: 0.2822530603557689d), new NpgsqlTypes.NpgsqlPoint(x: 0.29506757018921737d, y: 0.10302918050894694d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015882990530094454d, y: 0.6325163605974335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6840231889055965d, y: 0.6160748141272416d), new NpgsqlTypes.NpgsqlPoint(x: 0.13860161273788973d, y: 0.6803072292170946d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8354685769859929d, y: 0.4018165225680834d), new NpgsqlTypes.NpgsqlPoint(x: 0.6483359470024709d, y: 0.9956262841149032d), new NpgsqlTypes.NpgsqlPoint(x: 0.09817365150371637d, y: 0.8243196410576105d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41341537677348805d, y: 0.10550965059948136d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348042310526728d, y: 0.6008279016041915d), new NpgsqlTypes.NpgsqlPoint(x: 0.922685486886141d, y: 0.39515383120261616d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2579110544939188d, y: 0.6536147729291667d), new NpgsqlTypes.NpgsqlPoint(x: 0.3813064678982424d, y: 0.628275833860685d), new NpgsqlTypes.NpgsqlPoint(x: 0.47166004266728845d, y: 0.8777884430153335d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8356352701859182d, y: 0.5646916856561421d), new NpgsqlTypes.NpgsqlPoint(x: 0.5115477493736272d, y: 0.6130155285936967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8541852561538267d, y: 0.5890650064829097d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45632489498013273d, y: 0.3641056898100008d), new NpgsqlTypes.NpgsqlPoint(x: 0.7582943125966677d, y: 0.509144113983515d), new NpgsqlTypes.NpgsqlPoint(x: 0.007399616437315681d, y: 0.3000343613823553d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23945411026293628d, y: 0.35531694318042883d), new NpgsqlTypes.NpgsqlPoint(x: 0.496455588659912d, y: 0.2224288304971772d), new NpgsqlTypes.NpgsqlPoint(x: 0.4910647830064022d, y: 0.5280899608891477d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7043330964412058d, y: 0.20819848784518302d), new NpgsqlTypes.NpgsqlPoint(x: 0.16969771570255465d, y: 0.40591758960361835d), new NpgsqlTypes.NpgsqlPoint(x: 0.0035716254449968954d, y: 0.05915721695137799d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6767124334999443d, y: 0.33926425508519964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4013366416774473d, y: 0.37925146895120965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6678296801569135d, y: 0.021882523262105824d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6019335343350917d, y: 0.35148035977976844d), new NpgsqlTypes.NpgsqlPoint(x: 0.27933551975086746d, y: 0.26517258846791203d), new NpgsqlTypes.NpgsqlPoint(x: 0.32669080253945515d, y: 0.006571338844853725d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8878234149010089d, y: 0.8864894711421559d), new NpgsqlTypes.NpgsqlPoint(x: 0.43439765834775357d, y: 0.3970589279447264d), new NpgsqlTypes.NpgsqlPoint(x: 0.06329976732650511d, y: 0.20393803240523434d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09233275419800613d, y: 0.3476212353911019d), new NpgsqlTypes.NpgsqlPoint(x: 0.03352909224945988d, y: 0.03959895372232025d), new NpgsqlTypes.NpgsqlPoint(x: 0.3106917227748206d, y: 0.2729922638274951d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5914963036762906d, y: 0.7289420228698514d), new NpgsqlTypes.NpgsqlPoint(x: 0.37456654091620567d, y: 0.5450275670610353d), new NpgsqlTypes.NpgsqlPoint(x: 0.10955405696133191d, y: 0.0806814358985376d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5870777791088029d, y: 0.8463938098476094d), new NpgsqlTypes.NpgsqlPoint(x: 0.9554313861084107d, y: 0.21655295211273007d), new NpgsqlTypes.NpgsqlPoint(x: 0.004753567488267274d, y: 0.4971633703797783d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6293162959930186d, y: 0.4702091991130285d), new NpgsqlTypes.NpgsqlPoint(x: 0.053957771439414715d, y: 0.19741329906786442d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843417269331082d, y: 0.47756592813630405d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015928004840648713d, y: 0.4672603043263701d), new NpgsqlTypes.NpgsqlPoint(x: 0.8782004116729856d, y: 0.976229809871464d), new NpgsqlTypes.NpgsqlPoint(x: 0.603419563144027d, y: 0.609425484489139d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2098631690904893d, y: 0.6536271893895085d), new NpgsqlTypes.NpgsqlPoint(x: 0.6840073055962542d, y: 0.9172644228810956d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129528830785204d, y: 0.5498072922218641d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26954438658136737d, y: 0.36262512728030194d), new NpgsqlTypes.NpgsqlPoint(x: 0.1596086353786894d, y: 0.5494591925456733d), new NpgsqlTypes.NpgsqlPoint(x: 0.7839835736037973d, y: 0.9379823776863987d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0495738941873195d, y: 0.9893216083223129d), new NpgsqlTypes.NpgsqlPoint(x: 0.13185901052722615d, y: 0.9053975212544295d), new NpgsqlTypes.NpgsqlPoint(x: 0.5489593003948839d, y: 0.34349060148299004d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13046970125238888d, y: 0.7650577258846657d), new NpgsqlTypes.NpgsqlPoint(x: 0.18944986801325137d, y: 0.46680869879058307d), new NpgsqlTypes.NpgsqlPoint(x: 0.3241819802585194d, y: 0.08896774355435055d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5869612507204756d, y: 0.5009372751682252d), new NpgsqlTypes.NpgsqlPoint(x: 0.671774306295613d, y: 0.11676318509638295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7334051605018781d, y: 0.6591126533546378d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26231273280805145d, y: 0.18061598867475992d), new NpgsqlTypes.NpgsqlPoint(x: 0.6345874627822138d, y: 0.6016002793465306d), new NpgsqlTypes.NpgsqlPoint(x: 0.21721928563906123d, y: 0.536902748776576d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08723310305132204d, y: 0.4490263397646227d), new NpgsqlTypes.NpgsqlPoint(x: 0.40956065992080526d, y: 0.44397341123877976d), new NpgsqlTypes.NpgsqlPoint(x: 0.007805259448557034d, y: 0.2079150176878819d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4918843646929648d, y: 0.2614749647974125d), new NpgsqlTypes.NpgsqlPoint(x: 0.49036968987163554d, y: 0.7147700135166798d), new NpgsqlTypes.NpgsqlPoint(x: 0.2526175686559753d, y: 0.47242403757906626d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9873509953223406d, y: 0.7477587137826057d), new NpgsqlTypes.NpgsqlPoint(x: 0.08754667071328204d, y: 0.6018306938010934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8484071544558921d, y: 0.008215937653532124d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5264786030071597d, y: 0.40585383404534003d), new NpgsqlTypes.NpgsqlPoint(x: 0.4282095194464859d, y: 0.7796750227336645d), new NpgsqlTypes.NpgsqlPoint(x: 0.01154467727514441d, y: 0.04062357352635526d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12475248928508931d, y: 0.3707348959883715d), new NpgsqlTypes.NpgsqlPoint(x: 0.534887201084414d, y: 0.697440781960977d), new NpgsqlTypes.NpgsqlPoint(x: 0.556912350471009d, y: 0.10017867044948559d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4232842733569607d, y: 0.34611892207267725d), new NpgsqlTypes.NpgsqlPoint(x: 0.29803418781349145d, y: 0.9739506092031609d), new NpgsqlTypes.NpgsqlPoint(x: 0.38426522300683186d, y: 0.5137732880243019d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9006385853459026d, y: 0.29832066587990735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8494820684080934d, y: 0.09654843632771082d), new NpgsqlTypes.NpgsqlPoint(x: 0.844903422344068d, y: 0.8121649408683947d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6230413145193346d, y: 0.8219441369017688d), new NpgsqlTypes.NpgsqlPoint(x: 0.3981976102649186d, y: 0.6576874230555224d), new NpgsqlTypes.NpgsqlPoint(x: 0.4027604143081822d, y: 0.40232925657551566d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7381047302213299d, y: 0.39869372430565664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7528138353231324d, y: 0.9479828463214064d), new NpgsqlTypes.NpgsqlPoint(x: 0.3108883782985703d, y: 0.9688817458690447d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8489977726302095d, y: 0.5390718745834043d), new NpgsqlTypes.NpgsqlPoint(x: 0.20846154153623597d, y: 0.6960826113941072d), new NpgsqlTypes.NpgsqlPoint(x: 0.43158202360180464d, y: 0.21554391237807813d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9592815958619416d, y: 0.9565785407841962d), new NpgsqlTypes.NpgsqlPoint(x: 0.9256938364198638d, y: 0.3288130211622752d), new NpgsqlTypes.NpgsqlPoint(x: 0.5616075434726752d, y: 0.696520915517851d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9708992694938575d, y: 0.16215846879508256d), new NpgsqlTypes.NpgsqlPoint(x: 0.08165466789931075d, y: 0.4809066956198734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144288975917734d, y: 0.35935722632804334d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7565986525539145d, y: 0.10588554018510055d), new NpgsqlTypes.NpgsqlPoint(x: 0.4468189547634287d, y: 0.8807227748412326d), new NpgsqlTypes.NpgsqlPoint(x: 0.47401331166182104d, y: 0.21970040171588812d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7967964041426769d, y: 0.04418461949316177d), new NpgsqlTypes.NpgsqlPoint(x: 0.967973532168394d, y: 0.2765094073627856d), new NpgsqlTypes.NpgsqlPoint(x: 0.6612307065963106d, y: 0.24034492923824968d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7176545625956516d, y: 0.10097848762014938d), new NpgsqlTypes.NpgsqlPoint(x: 0.8253294169889246d, y: 0.49692612315340146d), new NpgsqlTypes.NpgsqlPoint(x: 0.5716077449087968d, y: 0.9111718123535696d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11618718059854682d, y: 0.5658996196580783d), new NpgsqlTypes.NpgsqlPoint(x: 0.3935964814390377d, y: 0.3045037527621359d), new NpgsqlTypes.NpgsqlPoint(x: 0.5602331463204623d, y: 0.11929915351994047d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0720063051934271d, y: 0.4624885511504334d), new NpgsqlTypes.NpgsqlPoint(x: 0.23206309494974564d, y: 0.857620114195001d), new NpgsqlTypes.NpgsqlPoint(x: 0.6990770254582577d, y: 0.2508044928150912d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6935883580595109d, y: 0.07769323695888675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8604525887957778d, y: 0.08310964902344986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5693100367925408d, y: 0.5595597910369717d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7567308761485062d, y: 0.2357590055779869d), new NpgsqlTypes.NpgsqlPoint(x: 0.6630689914566682d, y: 0.7755484050428263d), new NpgsqlTypes.NpgsqlPoint(x: 0.42038976722304777d, y: 0.2916489566888746d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4578434534600889d, y: 0.8649308879451308d), new NpgsqlTypes.NpgsqlPoint(x: 0.7611715715294886d, y: 0.5603388711076247d), new NpgsqlTypes.NpgsqlPoint(x: 0.3333232922513719d, y: 0.29800932527851554d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.568917233513545d, y: 0.7788822721669094d), new NpgsqlTypes.NpgsqlPoint(x: 0.6358579758506825d, y: 0.18103852218819938d), new NpgsqlTypes.NpgsqlPoint(x: 0.06200511893711702d, y: 0.046997442660358435d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34553665646696574d, y: 0.5485680484177172d), new NpgsqlTypes.NpgsqlPoint(x: 0.0687292961587671d, y: 0.26946192525152846d), new NpgsqlTypes.NpgsqlPoint(x: 0.9060802810119476d, y: 0.062374249073579024d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6230019369742772d, y: 0.15467033250835738d), new NpgsqlTypes.NpgsqlPoint(x: 0.7747763354772346d, y: 0.6591251182999006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7893435742399616d, y: 0.4033233117395768d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.845509770736668d, y: 0.01975354030787868d), new NpgsqlTypes.NpgsqlPoint(x: 0.17420765678362715d, y: 0.9018644173265344d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354113974875102d, y: 0.3810176508358367d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6006218101689941d, y: 0.8793238855405981d), new NpgsqlTypes.NpgsqlPoint(x: 0.423211699363917d, y: 0.06980615357948539d), new NpgsqlTypes.NpgsqlPoint(x: 0.637023866669936d, y: 0.24678083380466054d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6167886601065987d, y: 0.9423577552729243d), new NpgsqlTypes.NpgsqlPoint(x: 0.14842640092050885d, y: 0.6173530320108882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5800807071624936d, y: 0.8905581362315178d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9734639788329211d, y: 0.571999689204494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728037092210806d, y: 0.9120664202149397d), new NpgsqlTypes.NpgsqlPoint(x: 0.2104562105227591d, y: 0.7291729559764897d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8403281948806732d, y: 0.6856754170862559d), new NpgsqlTypes.NpgsqlPoint(x: 0.3498850462424802d, y: 0.4016202337017045d), new NpgsqlTypes.NpgsqlPoint(x: 0.6704002454229735d, y: 0.28675942023595435d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2303138440822584d, y: 0.7327460069099829d), new NpgsqlTypes.NpgsqlPoint(x: 0.5160278932981448d, y: 0.3919394120583556d), new NpgsqlTypes.NpgsqlPoint(x: 0.42706040287181124d, y: 0.11058914394065522d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7979188909728241d, y: 0.89599897267959d), new NpgsqlTypes.NpgsqlPoint(x: 0.24290083027158282d, y: 0.4487132216510339d), new NpgsqlTypes.NpgsqlPoint(x: 0.22902670148563775d, y: 0.5106460862252528d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9413892777519189d, y: 0.6340121836166313d), new NpgsqlTypes.NpgsqlPoint(x: 0.12429022673206536d, y: 0.504166602984255d), new NpgsqlTypes.NpgsqlPoint(x: 0.4131466086655059d, y: 0.3683787500444188d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5881613886582051d, y: 0.7799515965803818d), new NpgsqlTypes.NpgsqlPoint(x: 0.12386776821297518d, y: 0.026820170944816035d), new NpgsqlTypes.NpgsqlPoint(x: 0.31126594144089037d, y: 0.9434635046355454d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3737724621757429d, y: 0.4263209799615487d), new NpgsqlTypes.NpgsqlPoint(x: 0.9617955531801733d, y: 0.8288076166804063d), new NpgsqlTypes.NpgsqlPoint(x: 0.2949063081891611d, y: 0.27018725214862194d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6392272315849814d, y: 0.6829458639898732d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512803422540115d, y: 0.06448091254698474d), new NpgsqlTypes.NpgsqlPoint(x: 0.5196735772511857d, y: 0.24752613463054196d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4236080503492834d, y: 0.8577889748419818d), new NpgsqlTypes.NpgsqlPoint(x: 0.8051545683059745d, y: 0.733893108594696d), new NpgsqlTypes.NpgsqlPoint(x: 0.9988103942497136d, y: 0.9577443165529412d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01877835655480542d, y: 0.9151190431266802d), new NpgsqlTypes.NpgsqlPoint(x: 0.8362124341515299d, y: 0.25857992256111983d), new NpgsqlTypes.NpgsqlPoint(x: 0.19620571939162368d, y: 0.6594982550146044d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.041004152347226874d, y: 0.5495371003735058d), new NpgsqlTypes.NpgsqlPoint(x: 0.7187594094893175d, y: 0.9916969392934473d), new NpgsqlTypes.NpgsqlPoint(x: 0.5293066376001704d, y: 0.9360140350512179d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2489495932364304d, y: 0.1746334871527625d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301596348490496d, y: 0.648122941867777d), new NpgsqlTypes.NpgsqlPoint(x: 0.09185225372921046d, y: 0.44093278090420673d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04784779910661063d, y: 0.26364819947371376d), new NpgsqlTypes.NpgsqlPoint(x: 0.18818866198422046d, y: 0.22658435162721902d), new NpgsqlTypes.NpgsqlPoint(x: 0.15128376843162716d, y: 0.839375027003722d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3508036050986503d, y: 0.46791924724978806d), new NpgsqlTypes.NpgsqlPoint(x: 0.3243737789305813d, y: 0.4258158854042954d), new NpgsqlTypes.NpgsqlPoint(x: 0.16444555801317284d, y: 0.9482786315792581d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8522158000161137d, y: 0.6740012154882491d), new NpgsqlTypes.NpgsqlPoint(x: 0.9511717147988767d, y: 0.8162271592700032d), new NpgsqlTypes.NpgsqlPoint(x: 0.7140972869511795d, y: 0.4194219137719942d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9262007772997566d, y: 0.9276826628655376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9116797536796698d, y: 0.4412931723798249d), new NpgsqlTypes.NpgsqlPoint(x: 0.8258519168547275d, y: 0.17176218499082296d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02691145573759446d, y: 0.2714068925743932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5279925569956586d, y: 0.1640580458879335d), new NpgsqlTypes.NpgsqlPoint(x: 0.457133549957486d, y: 0.2731747676337055d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41454539474702756d, y: 0.7887995127181332d), new NpgsqlTypes.NpgsqlPoint(x: 0.12325287607323121d, y: 0.043436621727601654d), new NpgsqlTypes.NpgsqlPoint(x: 0.30882387839696346d, y: 0.8892867567281165d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9435166614787517d, y: 0.6901687421752005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5381289677730938d, y: 0.7916636316047649d), new NpgsqlTypes.NpgsqlPoint(x: 0.28380033592784903d, y: 0.5113174199243473d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21428209583464242d, y: 0.14170402169818486d), new NpgsqlTypes.NpgsqlPoint(x: 0.5172422856435854d, y: 0.2779672335716522d), new NpgsqlTypes.NpgsqlPoint(x: 0.7671761664670878d, y: 0.9571491661732678d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09392177828780801d, y: 0.9760643840675555d), new NpgsqlTypes.NpgsqlPoint(x: 0.3417296181428493d, y: 0.9869780076501462d), new NpgsqlTypes.NpgsqlPoint(x: 0.02037722414286336d, y: 0.29663636439088015d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07374929192748181d, y: 0.16277030652401614d), new NpgsqlTypes.NpgsqlPoint(x: 0.2778673234447461d, y: 0.885498348005595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7597746396355164d, y: 0.9329700687216091d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5168392635192586d, y: 0.488619696102511d), new NpgsqlTypes.NpgsqlPoint(x: 0.8861145033758285d, y: 0.8635053269079257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7441536119561423d, y: 0.06984767028735417d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3449520620073855d, y: 0.25888163891668614d), new NpgsqlTypes.NpgsqlPoint(x: 0.9096042730971616d, y: 0.205019207789651d), new NpgsqlTypes.NpgsqlPoint(x: 0.3621948379996187d, y: 0.09271260810738835d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07590824649740424d, y: 0.46140677835501953d), new NpgsqlTypes.NpgsqlPoint(x: 0.6816494441512453d, y: 0.8557205122549348d), new NpgsqlTypes.NpgsqlPoint(x: 0.48981609553792005d, y: 0.6012163521466195d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5986189724353652d, y: 0.7993148301381912d), new NpgsqlTypes.NpgsqlPoint(x: 0.362214940714902d, y: 0.8251614477503436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5702808232498179d, y: 0.7955410398135585d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8474360352260636d, y: 0.7024985617175538d), new NpgsqlTypes.NpgsqlPoint(x: 0.8572087002574043d, y: 0.28003401540733874d), new NpgsqlTypes.NpgsqlPoint(x: 0.899896997463514d, y: 0.776936889341422d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6830266488162118d, y: 0.70759787876535d), new NpgsqlTypes.NpgsqlPoint(x: 0.3951586182204577d, y: 0.13884589933078706d), new NpgsqlTypes.NpgsqlPoint(x: 0.3299192233832603d, y: 0.6202374376827158d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34658637575067497d, y: 0.14776095496308506d), new NpgsqlTypes.NpgsqlPoint(x: 0.2271631134456802d, y: 0.9498199075404754d), new NpgsqlTypes.NpgsqlPoint(x: 0.8238445285856412d, y: 0.9759909628827134d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9945385426826264d, y: 0.3654216028017754d), new NpgsqlTypes.NpgsqlPoint(x: 0.22521989905217432d, y: 0.9860480262729373d), new NpgsqlTypes.NpgsqlPoint(x: 0.146067092293527d, y: 0.11989118601139226d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6856150783477263d, y: 0.9677335139501528d), new NpgsqlTypes.NpgsqlPoint(x: 0.4464199860815996d, y: 0.2363512053749366d), new NpgsqlTypes.NpgsqlPoint(x: 0.40237304389485606d, y: 0.21977889004571316d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9951752344814004d, y: 0.5153111498069014d), new NpgsqlTypes.NpgsqlPoint(x: 0.24036832369103467d, y: 0.7480541685640786d), new NpgsqlTypes.NpgsqlPoint(x: 0.05427984214478587d, y: 0.8684364136318915d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5135206902321202d, y: 0.332218108244445d), new NpgsqlTypes.NpgsqlPoint(x: 0.18269230045677887d, y: 0.46070655429063945d), new NpgsqlTypes.NpgsqlPoint(x: 0.9350283577160541d, y: 0.22675092922981743d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9146027234854657d, y: 0.715597622424504d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412349787310335d, y: 0.7976204520750813d), new NpgsqlTypes.NpgsqlPoint(x: 0.2609397169371629d, y: 0.708000754111313d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2741053277809429d, y: 0.05924636731160993d), new NpgsqlTypes.NpgsqlPoint(x: 0.9021258792743253d, y: 0.01340060295948109d), new NpgsqlTypes.NpgsqlPoint(x: 0.4272864332247934d, y: 0.5964788862290487d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9560380313347197d, y: 0.8024234300428668d), new NpgsqlTypes.NpgsqlPoint(x: 0.5632383754645234d, y: 0.2822530603557689d), new NpgsqlTypes.NpgsqlPoint(x: 0.29506757018921737d, y: 0.10302918050894694d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015882990530094454d, y: 0.6325163605974335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6840231889055965d, y: 0.6160748141272416d), new NpgsqlTypes.NpgsqlPoint(x: 0.13860161273788973d, y: 0.6803072292170946d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8354685769859929d, y: 0.4018165225680834d), new NpgsqlTypes.NpgsqlPoint(x: 0.6483359470024709d, y: 0.9956262841149032d), new NpgsqlTypes.NpgsqlPoint(x: 0.09817365150371637d, y: 0.8243196410576105d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41341537677348805d, y: 0.10550965059948136d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348042310526728d, y: 0.6008279016041915d), new NpgsqlTypes.NpgsqlPoint(x: 0.922685486886141d, y: 0.39515383120261616d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2579110544939188d, y: 0.6536147729291667d), new NpgsqlTypes.NpgsqlPoint(x: 0.3813064678982424d, y: 0.628275833860685d), new NpgsqlTypes.NpgsqlPoint(x: 0.47166004266728845d, y: 0.8777884430153335d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8356352701859182d, y: 0.5646916856561421d), new NpgsqlTypes.NpgsqlPoint(x: 0.5115477493736272d, y: 0.6130155285936967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8541852561538267d, y: 0.5890650064829097d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45632489498013273d, y: 0.3641056898100008d), new NpgsqlTypes.NpgsqlPoint(x: 0.7582943125966677d, y: 0.509144113983515d), new NpgsqlTypes.NpgsqlPoint(x: 0.007399616437315681d, y: 0.3000343613823553d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23945411026293628d, y: 0.35531694318042883d), new NpgsqlTypes.NpgsqlPoint(x: 0.496455588659912d, y: 0.2224288304971772d), new NpgsqlTypes.NpgsqlPoint(x: 0.4910647830064022d, y: 0.5280899608891477d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7043330964412058d, y: 0.20819848784518302d), new NpgsqlTypes.NpgsqlPoint(x: 0.16969771570255465d, y: 0.40591758960361835d), new NpgsqlTypes.NpgsqlPoint(x: 0.0035716254449968954d, y: 0.05915721695137799d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6767124334999443d, y: 0.33926425508519964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4013366416774473d, y: 0.37925146895120965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6678296801569135d, y: 0.021882523262105824d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6019335343350917d, y: 0.35148035977976844d), new NpgsqlTypes.NpgsqlPoint(x: 0.27933551975086746d, y: 0.26517258846791203d), new NpgsqlTypes.NpgsqlPoint(x: 0.32669080253945515d, y: 0.006571338844853725d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8878234149010089d, y: 0.8864894711421559d), new NpgsqlTypes.NpgsqlPoint(x: 0.43439765834775357d, y: 0.3970589279447264d), new NpgsqlTypes.NpgsqlPoint(x: 0.06329976732650511d, y: 0.20393803240523434d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09233275419800613d, y: 0.3476212353911019d), new NpgsqlTypes.NpgsqlPoint(x: 0.03352909224945988d, y: 0.03959895372232025d), new NpgsqlTypes.NpgsqlPoint(x: 0.3106917227748206d, y: 0.2729922638274951d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5914963036762906d, y: 0.7289420228698514d), new NpgsqlTypes.NpgsqlPoint(x: 0.37456654091620567d, y: 0.5450275670610353d), new NpgsqlTypes.NpgsqlPoint(x: 0.10955405696133191d, y: 0.0806814358985376d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5870777791088029d, y: 0.8463938098476094d), new NpgsqlTypes.NpgsqlPoint(x: 0.9554313861084107d, y: 0.21655295211273007d), new NpgsqlTypes.NpgsqlPoint(x: 0.004753567488267274d, y: 0.4971633703797783d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6293162959930186d, y: 0.4702091991130285d), new NpgsqlTypes.NpgsqlPoint(x: 0.053957771439414715d, y: 0.19741329906786442d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843417269331082d, y: 0.47756592813630405d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015928004840648713d, y: 0.4672603043263701d), new NpgsqlTypes.NpgsqlPoint(x: 0.8782004116729856d, y: 0.976229809871464d), new NpgsqlTypes.NpgsqlPoint(x: 0.603419563144027d, y: 0.609425484489139d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2098631690904893d, y: 0.6536271893895085d), new NpgsqlTypes.NpgsqlPoint(x: 0.6840073055962542d, y: 0.9172644228810956d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129528830785204d, y: 0.5498072922218641d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26954438658136737d, y: 0.36262512728030194d), new NpgsqlTypes.NpgsqlPoint(x: 0.1596086353786894d, y: 0.5494591925456733d), new NpgsqlTypes.NpgsqlPoint(x: 0.7839835736037973d, y: 0.9379823776863987d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0495738941873195d, y: 0.9893216083223129d), new NpgsqlTypes.NpgsqlPoint(x: 0.13185901052722615d, y: 0.9053975212544295d), new NpgsqlTypes.NpgsqlPoint(x: 0.5489593003948839d, y: 0.34349060148299004d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13046970125238888d, y: 0.7650577258846657d), new NpgsqlTypes.NpgsqlPoint(x: 0.18944986801325137d, y: 0.46680869879058307d), new NpgsqlTypes.NpgsqlPoint(x: 0.3241819802585194d, y: 0.08896774355435055d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5869612507204756d, y: 0.5009372751682252d), new NpgsqlTypes.NpgsqlPoint(x: 0.671774306295613d, y: 0.11676318509638295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7334051605018781d, y: 0.6591126533546378d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26231273280805145d, y: 0.18061598867475992d), new NpgsqlTypes.NpgsqlPoint(x: 0.6345874627822138d, y: 0.6016002793465306d), new NpgsqlTypes.NpgsqlPoint(x: 0.21721928563906123d, y: 0.536902748776576d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08723310305132204d, y: 0.4490263397646227d), new NpgsqlTypes.NpgsqlPoint(x: 0.40956065992080526d, y: 0.44397341123877976d), new NpgsqlTypes.NpgsqlPoint(x: 0.007805259448557034d, y: 0.2079150176878819d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4918843646929648d, y: 0.2614749647974125d), new NpgsqlTypes.NpgsqlPoint(x: 0.49036968987163554d, y: 0.7147700135166798d), new NpgsqlTypes.NpgsqlPoint(x: 0.2526175686559753d, y: 0.47242403757906626d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9873509953223406d, y: 0.7477587137826057d), new NpgsqlTypes.NpgsqlPoint(x: 0.08754667071328204d, y: 0.6018306938010934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8484071544558921d, y: 0.008215937653532124d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5264786030071597d, y: 0.40585383404534003d), new NpgsqlTypes.NpgsqlPoint(x: 0.4282095194464859d, y: 0.7796750227336645d), new NpgsqlTypes.NpgsqlPoint(x: 0.01154467727514441d, y: 0.04062357352635526d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12475248928508931d, y: 0.3707348959883715d), new NpgsqlTypes.NpgsqlPoint(x: 0.534887201084414d, y: 0.697440781960977d), new NpgsqlTypes.NpgsqlPoint(x: 0.556912350471009d, y: 0.10017867044948559d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4232842733569607d, y: 0.34611892207267725d), new NpgsqlTypes.NpgsqlPoint(x: 0.29803418781349145d, y: 0.9739506092031609d), new NpgsqlTypes.NpgsqlPoint(x: 0.38426522300683186d, y: 0.5137732880243019d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9006385853459026d, y: 0.29832066587990735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8494820684080934d, y: 0.09654843632771082d), new NpgsqlTypes.NpgsqlPoint(x: 0.844903422344068d, y: 0.8121649408683947d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6230413145193346d, y: 0.8219441369017688d), new NpgsqlTypes.NpgsqlPoint(x: 0.3981976102649186d, y: 0.6576874230555224d), new NpgsqlTypes.NpgsqlPoint(x: 0.4027604143081822d, y: 0.40232925657551566d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7381047302213299d, y: 0.39869372430565664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7528138353231324d, y: 0.9479828463214064d), new NpgsqlTypes.NpgsqlPoint(x: 0.3108883782985703d, y: 0.9688817458690447d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8489977726302095d, y: 0.5390718745834043d), new NpgsqlTypes.NpgsqlPoint(x: 0.20846154153623597d, y: 0.6960826113941072d), new NpgsqlTypes.NpgsqlPoint(x: 0.43158202360180464d, y: 0.21554391237807813d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9592815958619416d, y: 0.9565785407841962d), new NpgsqlTypes.NpgsqlPoint(x: 0.9256938364198638d, y: 0.3288130211622752d), new NpgsqlTypes.NpgsqlPoint(x: 0.5616075434726752d, y: 0.696520915517851d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9708992694938575d, y: 0.16215846879508256d), new NpgsqlTypes.NpgsqlPoint(x: 0.08165466789931075d, y: 0.4809066956198734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144288975917734d, y: 0.35935722632804334d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7565986525539145d, y: 0.10588554018510055d), new NpgsqlTypes.NpgsqlPoint(x: 0.4468189547634287d, y: 0.8807227748412326d), new NpgsqlTypes.NpgsqlPoint(x: 0.47401331166182104d, y: 0.21970040171588812d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7967964041426769d, y: 0.04418461949316177d), new NpgsqlTypes.NpgsqlPoint(x: 0.967973532168394d, y: 0.2765094073627856d), new NpgsqlTypes.NpgsqlPoint(x: 0.6612307065963106d, y: 0.24034492923824968d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7176545625956516d, y: 0.10097848762014938d), new NpgsqlTypes.NpgsqlPoint(x: 0.8253294169889246d, y: 0.49692612315340146d), new NpgsqlTypes.NpgsqlPoint(x: 0.5716077449087968d, y: 0.9111718123535696d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11618718059854682d, y: 0.5658996196580783d), new NpgsqlTypes.NpgsqlPoint(x: 0.3935964814390377d, y: 0.3045037527621359d), new NpgsqlTypes.NpgsqlPoint(x: 0.5602331463204623d, y: 0.11929915351994047d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0720063051934271d, y: 0.4624885511504334d), new NpgsqlTypes.NpgsqlPoint(x: 0.23206309494974564d, y: 0.857620114195001d), new NpgsqlTypes.NpgsqlPoint(x: 0.6990770254582577d, y: 0.2508044928150912d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6935883580595109d, y: 0.07769323695888675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8604525887957778d, y: 0.08310964902344986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5693100367925408d, y: 0.5595597910369717d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7567308761485062d, y: 0.2357590055779869d), new NpgsqlTypes.NpgsqlPoint(x: 0.6630689914566682d, y: 0.7755484050428263d), new NpgsqlTypes.NpgsqlPoint(x: 0.42038976722304777d, y: 0.2916489566888746d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4578434534600889d, y: 0.8649308879451308d), new NpgsqlTypes.NpgsqlPoint(x: 0.7611715715294886d, y: 0.5603388711076247d), new NpgsqlTypes.NpgsqlPoint(x: 0.3333232922513719d, y: 0.29800932527851554d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.568917233513545d, y: 0.7788822721669094d), new NpgsqlTypes.NpgsqlPoint(x: 0.6358579758506825d, y: 0.18103852218819938d), new NpgsqlTypes.NpgsqlPoint(x: 0.06200511893711702d, y: 0.046997442660358435d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34553665646696574d, y: 0.5485680484177172d), new NpgsqlTypes.NpgsqlPoint(x: 0.0687292961587671d, y: 0.26946192525152846d), new NpgsqlTypes.NpgsqlPoint(x: 0.9060802810119476d, y: 0.062374249073579024d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6230019369742772d, y: 0.15467033250835738d), new NpgsqlTypes.NpgsqlPoint(x: 0.7747763354772346d, y: 0.6591251182999006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7893435742399616d, y: 0.4033233117395768d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.845509770736668d, y: 0.01975354030787868d), new NpgsqlTypes.NpgsqlPoint(x: 0.17420765678362715d, y: 0.9018644173265344d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354113974875102d, y: 0.3810176508358367d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6006218101689941d, y: 0.8793238855405981d), new NpgsqlTypes.NpgsqlPoint(x: 0.423211699363917d, y: 0.06980615357948539d), new NpgsqlTypes.NpgsqlPoint(x: 0.637023866669936d, y: 0.24678083380466054d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6167886601065987d, y: 0.9423577552729243d), new NpgsqlTypes.NpgsqlPoint(x: 0.14842640092050885d, y: 0.6173530320108882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5800807071624936d, y: 0.8905581362315178d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9734639788329211d, y: 0.571999689204494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728037092210806d, y: 0.9120664202149397d), new NpgsqlTypes.NpgsqlPoint(x: 0.2104562105227591d, y: 0.7291729559764897d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8403281948806732d, y: 0.6856754170862559d), new NpgsqlTypes.NpgsqlPoint(x: 0.3498850462424802d, y: 0.4016202337017045d), new NpgsqlTypes.NpgsqlPoint(x: 0.6704002454229735d, y: 0.28675942023595435d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2303138440822584d, y: 0.7327460069099829d), new NpgsqlTypes.NpgsqlPoint(x: 0.5160278932981448d, y: 0.3919394120583556d), new NpgsqlTypes.NpgsqlPoint(x: 0.42706040287181124d, y: 0.11058914394065522d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7979188909728241d, y: 0.89599897267959d), new NpgsqlTypes.NpgsqlPoint(x: 0.24290083027158282d, y: 0.4487132216510339d), new NpgsqlTypes.NpgsqlPoint(x: 0.22902670148563775d, y: 0.5106460862252528d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9413892777519189d, y: 0.6340121836166313d), new NpgsqlTypes.NpgsqlPoint(x: 0.12429022673206536d, y: 0.504166602984255d), new NpgsqlTypes.NpgsqlPoint(x: 0.4131466086655059d, y: 0.3683787500444188d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5881613886582051d, y: 0.7799515965803818d), new NpgsqlTypes.NpgsqlPoint(x: 0.12386776821297518d, y: 0.026820170944816035d), new NpgsqlTypes.NpgsqlPoint(x: 0.31126594144089037d, y: 0.9434635046355454d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3737724621757429d, y: 0.4263209799615487d), new NpgsqlTypes.NpgsqlPoint(x: 0.9617955531801733d, y: 0.8288076166804063d), new NpgsqlTypes.NpgsqlPoint(x: 0.2949063081891611d, y: 0.27018725214862194d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6392272315849814d, y: 0.6829458639898732d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512803422540115d, y: 0.06448091254698474d), new NpgsqlTypes.NpgsqlPoint(x: 0.5196735772511857d, y: 0.24752613463054196d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4236080503492834d, y: 0.8577889748419818d), new NpgsqlTypes.NpgsqlPoint(x: 0.8051545683059745d, y: 0.733893108594696d), new NpgsqlTypes.NpgsqlPoint(x: 0.9988103942497136d, y: 0.9577443165529412d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01877835655480542d, y: 0.9151190431266802d), new NpgsqlTypes.NpgsqlPoint(x: 0.8362124341515299d, y: 0.25857992256111983d), new NpgsqlTypes.NpgsqlPoint(x: 0.19620571939162368d, y: 0.6594982550146044d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.041004152347226874d, y: 0.5495371003735058d), new NpgsqlTypes.NpgsqlPoint(x: 0.7187594094893175d, y: 0.9916969392934473d), new NpgsqlTypes.NpgsqlPoint(x: 0.5293066376001704d, y: 0.9360140350512179d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2489495932364304d, y: 0.1746334871527625d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301596348490496d, y: 0.648122941867777d), new NpgsqlTypes.NpgsqlPoint(x: 0.09185225372921046d, y: 0.44093278090420673d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04784779910661063d, y: 0.26364819947371376d), new NpgsqlTypes.NpgsqlPoint(x: 0.18818866198422046d, y: 0.22658435162721902d), new NpgsqlTypes.NpgsqlPoint(x: 0.15128376843162716d, y: 0.839375027003722d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3508036050986503d, y: 0.46791924724978806d), new NpgsqlTypes.NpgsqlPoint(x: 0.3243737789305813d, y: 0.4258158854042954d), new NpgsqlTypes.NpgsqlPoint(x: 0.16444555801317284d, y: 0.9482786315792581d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8522158000161137d, y: 0.6740012154882491d), new NpgsqlTypes.NpgsqlPoint(x: 0.9511717147988767d, y: 0.8162271592700032d), new NpgsqlTypes.NpgsqlPoint(x: 0.7140972869511795d, y: 0.4194219137719942d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9262007772997566d, y: 0.9276826628655376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9116797536796698d, y: 0.4412931723798249d), new NpgsqlTypes.NpgsqlPoint(x: 0.8258519168547275d, y: 0.17176218499082296d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02691145573759446d, y: 0.2714068925743932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5279925569956586d, y: 0.1640580458879335d), new NpgsqlTypes.NpgsqlPoint(x: 0.457133549957486d, y: 0.2731747676337055d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41454539474702756d, y: 0.7887995127181332d), new NpgsqlTypes.NpgsqlPoint(x: 0.12325287607323121d, y: 0.043436621727601654d), new NpgsqlTypes.NpgsqlPoint(x: 0.30882387839696346d, y: 0.8892867567281165d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9435166614787517d, y: 0.6901687421752005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5381289677730938d, y: 0.7916636316047649d), new NpgsqlTypes.NpgsqlPoint(x: 0.28380033592784903d, y: 0.5113174199243473d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21428209583464242d, y: 0.14170402169818486d), new NpgsqlTypes.NpgsqlPoint(x: 0.5172422856435854d, y: 0.2779672335716522d), new NpgsqlTypes.NpgsqlPoint(x: 0.7671761664670878d, y: 0.9571491661732678d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09392177828780801d, y: 0.9760643840675555d), new NpgsqlTypes.NpgsqlPoint(x: 0.3417296181428493d, y: 0.9869780076501462d), new NpgsqlTypes.NpgsqlPoint(x: 0.02037722414286336d, y: 0.29663636439088015d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07374929192748181d, y: 0.16277030652401614d), new NpgsqlTypes.NpgsqlPoint(x: 0.2778673234447461d, y: 0.885498348005595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7597746396355164d, y: 0.9329700687216091d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5168392635192586d, y: 0.488619696102511d), new NpgsqlTypes.NpgsqlPoint(x: 0.8861145033758285d, y: 0.8635053269079257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7441536119561423d, y: 0.06984767028735417d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3449520620073855d, y: 0.25888163891668614d), new NpgsqlTypes.NpgsqlPoint(x: 0.9096042730971616d, y: 0.205019207789651d), new NpgsqlTypes.NpgsqlPoint(x: 0.3621948379996187d, y: 0.09271260810738835d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07590824649740424d, y: 0.46140677835501953d), new NpgsqlTypes.NpgsqlPoint(x: 0.6816494441512453d, y: 0.8557205122549348d), new NpgsqlTypes.NpgsqlPoint(x: 0.48981609553792005d, y: 0.6012163521466195d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5986189724353652d, y: 0.7993148301381912d), new NpgsqlTypes.NpgsqlPoint(x: 0.362214940714902d, y: 0.8251614477503436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5702808232498179d, y: 0.7955410398135585d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8474360352260636d, y: 0.7024985617175538d), new NpgsqlTypes.NpgsqlPoint(x: 0.8572087002574043d, y: 0.28003401540733874d), new NpgsqlTypes.NpgsqlPoint(x: 0.899896997463514d, y: 0.776936889341422d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6830266488162118d, y: 0.70759787876535d), new NpgsqlTypes.NpgsqlPoint(x: 0.3951586182204577d, y: 0.13884589933078706d), new NpgsqlTypes.NpgsqlPoint(x: 0.3299192233832603d, y: 0.6202374376827158d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34658637575067497d, y: 0.14776095496308506d), new NpgsqlTypes.NpgsqlPoint(x: 0.2271631134456802d, y: 0.9498199075404754d), new NpgsqlTypes.NpgsqlPoint(x: 0.8238445285856412d, y: 0.9759909628827134d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9945385426826264d, y: 0.3654216028017754d), new NpgsqlTypes.NpgsqlPoint(x: 0.22521989905217432d, y: 0.9860480262729373d), new NpgsqlTypes.NpgsqlPoint(x: 0.146067092293527d, y: 0.11989118601139226d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6856150783477263d, y: 0.9677335139501528d), new NpgsqlTypes.NpgsqlPoint(x: 0.4464199860815996d, y: 0.2363512053749366d), new NpgsqlTypes.NpgsqlPoint(x: 0.40237304389485606d, y: 0.21977889004571316d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9951752344814004d, y: 0.5153111498069014d), new NpgsqlTypes.NpgsqlPoint(x: 0.24036832369103467d, y: 0.7480541685640786d), new NpgsqlTypes.NpgsqlPoint(x: 0.05427984214478587d, y: 0.8684364136318915d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5135206902321202d, y: 0.332218108244445d), new NpgsqlTypes.NpgsqlPoint(x: 0.18269230045677887d, y: 0.46070655429063945d), new NpgsqlTypes.NpgsqlPoint(x: 0.9350283577160541d, y: 0.22675092922981743d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9146027234854657d, y: 0.715597622424504d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412349787310335d, y: 0.7976204520750813d), new NpgsqlTypes.NpgsqlPoint(x: 0.2609397169371629d, y: 0.708000754111313d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2741053277809429d, y: 0.05924636731160993d), new NpgsqlTypes.NpgsqlPoint(x: 0.9021258792743253d, y: 0.01340060295948109d), new NpgsqlTypes.NpgsqlPoint(x: 0.4272864332247934d, y: 0.5964788862290487d)))));

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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
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
            queryMapType: typeof(NpgsqlPathpathE0M),
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
FROM public.binary_npgsqlpathpathe0m m
LEFT JOIN public.binary_npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
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
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
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
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI), typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpath0MI>();
                var models2 = new List<NpgsqlPathpath0MI>();
                await ((INpgsqlPathSingleTypepath)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MI>();
                var models2 = new List<NpgsqlPathpath0MI>();
                ((INpgsqlPathSingleTypepath)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model2, expectedModel, false);
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
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

