

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

        private readonly NpgsqlPolygonpolygon0M[] _testData = new NpgsqlPolygonpolygon0M[]
        {
            new NpgsqlPolygonpolygon0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3268771892128327d, y: 0.9957699809413665d), new NpgsqlTypes.NpgsqlPoint(x: 0.8559806199158562d, y: 0.9446759764193617d), new NpgsqlTypes.NpgsqlPoint(x: 0.7098088359263354d, y: 0.6704091655538696d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6615934705842919d, y: 0.8177793758012998d), new NpgsqlTypes.NpgsqlPoint(x: 0.8819682463935296d, y: 0.34015279144800625d), new NpgsqlTypes.NpgsqlPoint(x: 0.050057172415369d, y: 0.14432825355047096d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48171094942153503d, y: 0.8135455192964506d), new NpgsqlTypes.NpgsqlPoint(x: 0.6113697820713015d, y: 0.562305747971842d), new NpgsqlTypes.NpgsqlPoint(x: 0.18009082637041762d, y: 0.6724438675301695d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17579768146592978d, y: 0.3632120730910552d), new NpgsqlTypes.NpgsqlPoint(x: 0.14740072318490616d, y: 0.33811860693998863d), new NpgsqlTypes.NpgsqlPoint(x: 0.46426905216463055d, y: 0.09728389312315633d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9533498795196778d, y: 0.23111728358482597d), new NpgsqlTypes.NpgsqlPoint(x: 0.48789066646113766d, y: 0.3219520561149751d), new NpgsqlTypes.NpgsqlPoint(x: 0.3147714126890664d, y: 0.4708788872367603d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9610890715903746d, y: 0.20375940675398652d), new NpgsqlTypes.NpgsqlPoint(x: 0.21835659834972854d, y: 0.4229740684221003d), new NpgsqlTypes.NpgsqlPoint(x: 0.7580618759683702d, y: 0.11857772734675864d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5581793870292507d, y: 0.08599001105851634d), new NpgsqlTypes.NpgsqlPoint(x: 0.2989323672989763d, y: 0.05858808339990973d), new NpgsqlTypes.NpgsqlPoint(x: 0.8536526497641455d, y: 0.07912403187491046d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.049157663080545366d, y: 0.34603743756906036d), new NpgsqlTypes.NpgsqlPoint(x: 0.20601599626282685d, y: 0.6570230179685569d), new NpgsqlTypes.NpgsqlPoint(x: 0.1806637826597226d, y: 0.3786042597280034d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5311950642818174d, y: 0.46123679872331025d), new NpgsqlTypes.NpgsqlPoint(x: 0.17521593782435507d, y: 0.39600320343996753d), new NpgsqlTypes.NpgsqlPoint(x: 0.4027680900406727d, y: 0.9320109359459399d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08489308499808679d, y: 0.7522397645365769d), new NpgsqlTypes.NpgsqlPoint(x: 0.004543886056824209d, y: 0.9496743360807515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5888395578270824d, y: 0.4920590791530014d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3183526988153146d, y: 0.45906053118426315d), new NpgsqlTypes.NpgsqlPoint(x: 0.25686761790625323d, y: 0.6138782393734874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8497626678833108d, y: 0.8374987275447814d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6297429872819341d, y: 0.6603859360301717d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927528555387697d, y: 0.31662488526638066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5140843583575178d, y: 0.35440089408752773d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4553311841743838d, y: 0.18828966180026563d), new NpgsqlTypes.NpgsqlPoint(x: 0.6582338534010389d, y: 0.5472604230039247d), new NpgsqlTypes.NpgsqlPoint(x: 0.10136318830398905d, y: 0.8637389658102175d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8564530188537083d, y: 0.9868594899514865d), new NpgsqlTypes.NpgsqlPoint(x: 0.6920968616973263d, y: 0.987350152541338d), new NpgsqlTypes.NpgsqlPoint(x: 0.7407241629829305d, y: 0.19123993064065758d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47738895232954637d, y: 0.5687098594727475d), new NpgsqlTypes.NpgsqlPoint(x: 0.36532449136993284d, y: 0.47679263201495614d), new NpgsqlTypes.NpgsqlPoint(x: 0.07186897016374405d, y: 0.9889748578798643d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2976637565228101d, y: 0.8410549030027511d), new NpgsqlTypes.NpgsqlPoint(x: 0.010759463463269725d, y: 0.3945021153405873d), new NpgsqlTypes.NpgsqlPoint(x: 0.2852178894283204d, y: 0.15740553110229727d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1559271033353442d, y: 0.8239833838004443d), new NpgsqlTypes.NpgsqlPoint(x: 0.1337921447359276d, y: 0.6729497697260266d), new NpgsqlTypes.NpgsqlPoint(x: 0.23524839937333553d, y: 0.886611145617319d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4422329540356146d, y: 0.02332659201388132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6695493639527681d, y: 0.5152571154355521d), new NpgsqlTypes.NpgsqlPoint(x: 0.7095316239404587d, y: 0.5909228170974045d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21399824953454205d, y: 0.5844762786572326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7177099742379517d, y: 0.1452263359813718d), new NpgsqlTypes.NpgsqlPoint(x: 0.857347016306001d, y: 0.8498977994234685d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18471396561380637d, y: 0.06620302798433308d), new NpgsqlTypes.NpgsqlPoint(x: 0.09772938553215171d, y: 0.8495179239751027d), new NpgsqlTypes.NpgsqlPoint(x: 0.09939205787395744d, y: 0.8104996189617315d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3788281040465702d, y: 0.42234950490979484d), new NpgsqlTypes.NpgsqlPoint(x: 0.28916058400554223d, y: 0.9009162735807652d), new NpgsqlTypes.NpgsqlPoint(x: 0.3354068400049023d, y: 0.34199460482795574d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.027371663817338354d, y: 0.11767063565390723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6706834042118099d, y: 0.2444488296439784d), new NpgsqlTypes.NpgsqlPoint(x: 0.04554000996234031d, y: 0.891525214212173d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11491419019903326d, y: 0.7094563154166513d), new NpgsqlTypes.NpgsqlPoint(x: 0.654032675751299d, y: 0.29484468538175657d), new NpgsqlTypes.NpgsqlPoint(x: 0.461474255073302d, y: 0.3907008660861109d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6429134153368753d, y: 0.36918606702213896d), new NpgsqlTypes.NpgsqlPoint(x: 0.18140721230501422d, y: 0.07259504913374226d), new NpgsqlTypes.NpgsqlPoint(x: 0.33219541841225064d, y: 0.10129025894412735d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5728885981864925d, y: 0.005958667006803031d), new NpgsqlTypes.NpgsqlPoint(x: 0.24001969589435523d, y: 0.6101150562193428d), new NpgsqlTypes.NpgsqlPoint(x: 0.9147171414956744d, y: 0.7126982858395038d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2650278251379611d, y: 0.3622144579085066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5629457580275421d, y: 0.14173358420035853d), new NpgsqlTypes.NpgsqlPoint(x: 0.19906502680317328d, y: 0.592098968883341d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07767243240554345d, y: 0.3306331398044102d), new NpgsqlTypes.NpgsqlPoint(x: 0.46564700923006286d, y: 0.7333607932921702d), new NpgsqlTypes.NpgsqlPoint(x: 0.2669879908664188d, y: 0.3492822684408815d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8877854998013893d, y: 0.5475686505182992d), new NpgsqlTypes.NpgsqlPoint(x: 0.99186378749879d, y: 0.7560897655714462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6989472268324322d, y: 0.15521990592175117d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48289683953915685d, y: 0.7205069869257886d), new NpgsqlTypes.NpgsqlPoint(x: 0.05732411069311971d, y: 0.18528796529660796d), new NpgsqlTypes.NpgsqlPoint(x: 0.4857654070899572d, y: 0.06929292754342531d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028234263556119243d, y: 0.7715142084649996d), new NpgsqlTypes.NpgsqlPoint(x: 0.28925677449513654d, y: 0.6178999043095788d), new NpgsqlTypes.NpgsqlPoint(x: 0.23344517107740714d, y: 0.4648681983008167d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07830316768746182d, y: 0.2138962842984199d), new NpgsqlTypes.NpgsqlPoint(x: 0.5193835926320722d, y: 0.5011303959263292d), new NpgsqlTypes.NpgsqlPoint(x: 0.6556103035299045d, y: 0.03512886486010558d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12037753791314632d, y: 0.9090645479634792d), new NpgsqlTypes.NpgsqlPoint(x: 0.12856270426408734d, y: 0.2434145396479287d), new NpgsqlTypes.NpgsqlPoint(x: 0.3772895671638531d, y: 0.7112396493680069d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3928138469465504d, y: 0.24576098868982088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3153634892533411d, y: 0.12134094116367689d), new NpgsqlTypes.NpgsqlPoint(x: 0.920179496472718d, y: 0.6927966936541626d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26386084115992425d, y: 0.06632001561436385d), new NpgsqlTypes.NpgsqlPoint(x: 0.3801158791816769d, y: 0.9620383446906763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5531150400506921d, y: 0.41793059451546033d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9628728829832983d, y: 0.8362818498808771d), new NpgsqlTypes.NpgsqlPoint(x: 0.0612378016710331d, y: 0.6605935444760734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6855598775063095d, y: 0.4361775514163331d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08624933613837205d, y: 0.7011826233547326d), new NpgsqlTypes.NpgsqlPoint(x: 0.1563305294930355d, y: 0.2027945336629169d), new NpgsqlTypes.NpgsqlPoint(x: 0.9444543279173911d, y: 0.5767731564148274d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.009961189462394326d, y: 0.013727239326651652d), new NpgsqlTypes.NpgsqlPoint(x: 0.3329724534841907d, y: 0.19699281381823375d), new NpgsqlTypes.NpgsqlPoint(x: 0.4936832484342941d, y: 0.6742196363254541d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7714082562768254d, y: 0.5091851413701285d), new NpgsqlTypes.NpgsqlPoint(x: 0.4937707879796863d, y: 0.18699191983317498d), new NpgsqlTypes.NpgsqlPoint(x: 0.8717398002153462d, y: 0.15601270261703382d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5362696584658447d, y: 0.29767648765465937d), new NpgsqlTypes.NpgsqlPoint(x: 0.6985895426438455d, y: 0.17640782628210516d), new NpgsqlTypes.NpgsqlPoint(x: 0.7106785909528031d, y: 0.5394375860352979d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3135821643000256d, y: 0.4306479086241811d), new NpgsqlTypes.NpgsqlPoint(x: 0.39848900652542096d, y: 0.941939781658163d), new NpgsqlTypes.NpgsqlPoint(x: 0.770141077142308d, y: 0.7546822910247787d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.52697809511516d, y: 0.6408015922209944d), new NpgsqlTypes.NpgsqlPoint(x: 0.47108124336113943d, y: 0.34612797690915187d), new NpgsqlTypes.NpgsqlPoint(x: 0.754027741462201d, y: 0.8836437517688042d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9211393999059456d, y: 0.6672935385938323d), new NpgsqlTypes.NpgsqlPoint(x: 0.8273747964088385d, y: 0.09408288482189486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4030796531416061d, y: 0.911930957385644d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3188299512529641d, y: 0.971707498435188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9533447881735247d, y: 0.8041183359403035d), new NpgsqlTypes.NpgsqlPoint(x: 0.47749958750745747d, y: 0.12445190435842002d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6103227785644169d, y: 0.40874715944229334d), new NpgsqlTypes.NpgsqlPoint(x: 0.6037893922375875d, y: 0.8293821918985811d), new NpgsqlTypes.NpgsqlPoint(x: 0.5369071257537213d, y: 0.2971312991330095d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9243637291594071d, y: 0.4908644479505305d), new NpgsqlTypes.NpgsqlPoint(x: 0.08184809800772752d, y: 0.34387120680889094d), new NpgsqlTypes.NpgsqlPoint(x: 0.4430589383820286d, y: 0.8735807751284319d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.432990100292304d, y: 0.8515384797346052d), new NpgsqlTypes.NpgsqlPoint(x: 0.908619455150657d, y: 0.7154001066174712d), new NpgsqlTypes.NpgsqlPoint(x: 0.6126810698066874d, y: 0.18071272789987736d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14645826787477068d, y: 0.15794711753753643d), new NpgsqlTypes.NpgsqlPoint(x: 0.48667046491751886d, y: 0.0917490938312816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5368983417293228d, y: 0.09003371805261029d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9597410685615707d, y: 0.27746477973136907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7401936897055156d, y: 0.3779245068028656d), new NpgsqlTypes.NpgsqlPoint(x: 0.26557439430970486d, y: 0.943125671476761d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4477069148166458d, y: 0.8662597083102216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5878508896471415d, y: 0.3429427214499363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6251185827342042d, y: 0.3074892773620599d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9690056223515379d, y: 0.29472664098087753d), new NpgsqlTypes.NpgsqlPoint(x: 0.03502595240575124d, y: 0.9035401325304712d), new NpgsqlTypes.NpgsqlPoint(x: 0.6481696961925761d, y: 0.9551723405930881d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.052427607083513794d, y: 0.030298122349910916d), new NpgsqlTypes.NpgsqlPoint(x: 0.7844811663120836d, y: 0.785976952474065d), new NpgsqlTypes.NpgsqlPoint(x: 0.26225180449480456d, y: 0.8593646589921693d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3392696291463727d, y: 0.7776365321373437d), new NpgsqlTypes.NpgsqlPoint(x: 0.2088256448423389d, y: 0.3512727844964376d), new NpgsqlTypes.NpgsqlPoint(x: 0.15653199708914534d, y: 0.8956068871136298d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8477858020283657d, y: 0.04273248770772253d), new NpgsqlTypes.NpgsqlPoint(x: 0.05884669046304736d, y: 0.7566778647122313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318085692793959d, y: 0.23323430682876467d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7126977224955933d, y: 0.01573008673912213d), new NpgsqlTypes.NpgsqlPoint(x: 0.2979701937379372d, y: 0.93957456849604d), new NpgsqlTypes.NpgsqlPoint(x: 0.30523223306077185d, y: 0.011465675252389729d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4306148889300272d, y: 0.3849563517454214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8928949698114329d, y: 0.10464240840687133d), new NpgsqlTypes.NpgsqlPoint(x: 0.32654773574568274d, y: 0.7200116172855949d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06617860102834217d, y: 0.19071922331878377d), new NpgsqlTypes.NpgsqlPoint(x: 0.3399066362886918d, y: 0.12243379695261924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337060249480836d, y: 0.01751560401985841d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5776413410147938d, y: 0.32511661598488983d), new NpgsqlTypes.NpgsqlPoint(x: 0.7460891740746216d, y: 0.5712515889142264d), new NpgsqlTypes.NpgsqlPoint(x: 0.32602586326295946d, y: 0.36785266341297207d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2668885019059225d, y: 0.05509345167016644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8393660633645171d, y: 0.49878087089844014d), new NpgsqlTypes.NpgsqlPoint(x: 0.34464078340739546d, y: 0.2273086076822317d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12991103161623785d, y: 0.9703695048798451d), new NpgsqlTypes.NpgsqlPoint(x: 0.744007132030738d, y: 0.7604403970967707d), new NpgsqlTypes.NpgsqlPoint(x: 0.4098906597954334d, y: 0.6847423433152438d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7060519736080234d, y: 0.7251666233126688d), new NpgsqlTypes.NpgsqlPoint(x: 0.15981193859928022d, y: 0.9529658900691294d), new NpgsqlTypes.NpgsqlPoint(x: 0.9802966495425419d, y: 0.0688761141384221d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21723407938731687d, y: 0.6330131642669424d), new NpgsqlTypes.NpgsqlPoint(x: 0.08143540542132188d, y: 0.6593523246756653d), new NpgsqlTypes.NpgsqlPoint(x: 0.22059471683973375d, y: 0.7357114551588511d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10912126937332522d, y: 0.3882243037745853d), new NpgsqlTypes.NpgsqlPoint(x: 0.6211399646800355d, y: 0.531593923439143d), new NpgsqlTypes.NpgsqlPoint(x: 0.9807995270387176d, y: 0.6487996463174371d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3585305063845089d, y: 0.2041179578872282d), new NpgsqlTypes.NpgsqlPoint(x: 0.9815529446528504d, y: 0.34399768165315703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7241683368263985d, y: 0.23539011421712852d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8415284927758822d, y: 0.3088037052529188d), new NpgsqlTypes.NpgsqlPoint(x: 0.3915907275119106d, y: 0.5437659219388072d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510505238278171d, y: 0.44460529027229667d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36209893183908204d, y: 0.2859359723610668d), new NpgsqlTypes.NpgsqlPoint(x: 0.9050074508150344d, y: 0.08097555155964853d), new NpgsqlTypes.NpgsqlPoint(x: 0.1072717433063618d, y: 0.11266551848198669d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5280502174629784d, y: 0.33413403931079255d), new NpgsqlTypes.NpgsqlPoint(x: 0.24572490120869928d, y: 0.16793998188371217d), new NpgsqlTypes.NpgsqlPoint(x: 0.6502570858549298d, y: 0.7940369000574501d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6444421373567061d, y: 0.007077099670661835d), new NpgsqlTypes.NpgsqlPoint(x: 0.3536518137229213d, y: 0.6646742295105849d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606736499549057d, y: 0.2859888427123436d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27896035436395805d, y: 0.6526288763387615d), new NpgsqlTypes.NpgsqlPoint(x: 0.035806970095655255d, y: 0.02126699910674046d), new NpgsqlTypes.NpgsqlPoint(x: 0.3675572861566946d, y: 0.20807952000700036d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01808947552564244d, y: 0.9580092354433104d), new NpgsqlTypes.NpgsqlPoint(x: 0.29963536246872713d, y: 0.2671987235156451d), new NpgsqlTypes.NpgsqlPoint(x: 0.8760044065845163d, y: 0.27619905078145535d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4130547558908798d, y: 0.4524103530441155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6086146222355701d, y: 0.8365831013140914d), new NpgsqlTypes.NpgsqlPoint(x: 0.06079300843764268d, y: 0.050787194508330136d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.876818577308707d, y: 0.9772542641230646d), new NpgsqlTypes.NpgsqlPoint(x: 0.2802868957521163d, y: 0.5885193841819449d), new NpgsqlTypes.NpgsqlPoint(x: 0.4673702850433048d, y: 0.8844686312964354d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7657763573659095d, y: 0.3721225365438692d), new NpgsqlTypes.NpgsqlPoint(x: 0.1253873429429445d, y: 0.40873404805646596d), new NpgsqlTypes.NpgsqlPoint(x: 0.8857927154355334d, y: 0.06597680126733196d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2765125869668217d, y: 0.4603057630129791d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440602955585303d, y: 0.8857836359388299d), new NpgsqlTypes.NpgsqlPoint(x: 0.1522886891605485d, y: 0.3819460692650507d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35295505681384065d, y: 0.43044032077937733d), new NpgsqlTypes.NpgsqlPoint(x: 0.18704200394529635d, y: 0.6632821849304122d), new NpgsqlTypes.NpgsqlPoint(x: 0.5721199252204187d, y: 0.6923130006687843d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9288097352833533d, y: 0.7582073556738657d), new NpgsqlTypes.NpgsqlPoint(x: 0.18009669234779357d, y: 0.175078012855728d), new NpgsqlTypes.NpgsqlPoint(x: 0.4662857633339341d, y: 0.056913328490903914d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 164,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9790587154721306d, y: 0.06562418368149092d), new NpgsqlTypes.NpgsqlPoint(x: 0.18054071662309745d, y: 0.317472470943033d), new NpgsqlTypes.NpgsqlPoint(x: 0.39027375892291594d, y: 0.7645308343002869d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5855117229947632d, y: 0.7140205043888663d), new NpgsqlTypes.NpgsqlPoint(x: 0.5252185875138381d, y: 0.7176151428634089d), new NpgsqlTypes.NpgsqlPoint(x: 0.3660906930382418d, y: 0.22498161792159765d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5349976535821938d, y: 0.39810325641962374d), new NpgsqlTypes.NpgsqlPoint(x: 0.7143944445230256d, y: 0.9429343956816764d), new NpgsqlTypes.NpgsqlPoint(x: 0.7614214105264774d, y: 0.2010219293094364d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3567633565294208d, y: 0.5147533394119309d), new NpgsqlTypes.NpgsqlPoint(x: 0.02249959362918974d, y: 0.5570723850219991d), new NpgsqlTypes.NpgsqlPoint(x: 0.5817700014669626d, y: 0.8045048574003709d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 169,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.921718523837797d, y: 0.5677204889856196d), new NpgsqlTypes.NpgsqlPoint(x: 0.32492919510134444d, y: 0.8484280727988794d), new NpgsqlTypes.NpgsqlPoint(x: 0.3863526468219056d, y: 0.16956015583606843d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.944402991662938d, y: 0.8433129882430758d), new NpgsqlTypes.NpgsqlPoint(x: 0.8505663813545217d, y: 0.024594917066147914d), new NpgsqlTypes.NpgsqlPoint(x: 0.9156186717928734d, y: 0.5023508415050395d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8830880290615769d, y: 0.11886749925265472d), new NpgsqlTypes.NpgsqlPoint(x: 0.04278334276325013d, y: 0.9355371108212692d), new NpgsqlTypes.NpgsqlPoint(x: 0.04784893953646441d, y: 0.35632411585651014d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 172,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5506464949782831d, y: 0.4755296235644664d), new NpgsqlTypes.NpgsqlPoint(x: 0.764993198938647d, y: 0.16180768048626326d), new NpgsqlTypes.NpgsqlPoint(x: 0.9563222837557454d, y: 0.3491215266630183d)),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
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
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2976637565228101d, y: 0.8410549030027511d), new NpgsqlTypes.NpgsqlPoint(x: 0.010759463463269725d, y: 0.3945021153405873d), new NpgsqlTypes.NpgsqlPoint(x: 0.2852178894283204d, y: 0.15740553110229727d))));
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
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3788281040465702d, y: 0.42234950490979484d), new NpgsqlTypes.NpgsqlPoint(x: 0.28916058400554223d, y: 0.9009162735807652d), new NpgsqlTypes.NpgsqlPoint(x: 0.3354068400049023d, y: 0.34199460482795574d))));
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8877854998013893d, y: 0.5475686505182992d), new NpgsqlTypes.NpgsqlPoint(x: 0.99186378749879d, y: 0.7560897655714462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6989472268324322d, y: 0.15521990592175117d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpolygonpolygon0mi_id
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
                parametrName: "npgsqlpolygonpolygon0mi_id", 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
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
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
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
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[34], false);
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 6, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 21, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 167, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 87, query1, 164, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 147, query1, 147, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 59, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 12, query1, 44, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 110, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 112, 41))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[34], false);
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
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 37, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[34], false);
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
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[30], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[31], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[32], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[33], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[30], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[31], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[32], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[33], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3268771892128327d, y: 0.9957699809413665d), new NpgsqlTypes.NpgsqlPoint(x: 0.8559806199158562d, y: 0.9446759764193617d), new NpgsqlTypes.NpgsqlPoint(x: 0.7098088359263354d, y: 0.6704091655538696d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6615934705842919d, y: 0.8177793758012998d), new NpgsqlTypes.NpgsqlPoint(x: 0.8819682463935296d, y: 0.34015279144800625d), new NpgsqlTypes.NpgsqlPoint(x: 0.050057172415369d, y: 0.14432825355047096d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48171094942153503d, y: 0.8135455192964506d), new NpgsqlTypes.NpgsqlPoint(x: 0.6113697820713015d, y: 0.562305747971842d), new NpgsqlTypes.NpgsqlPoint(x: 0.18009082637041762d, y: 0.6724438675301695d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17579768146592978d, y: 0.3632120730910552d), new NpgsqlTypes.NpgsqlPoint(x: 0.14740072318490616d, y: 0.33811860693998863d), new NpgsqlTypes.NpgsqlPoint(x: 0.46426905216463055d, y: 0.09728389312315633d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9533498795196778d, y: 0.23111728358482597d), new NpgsqlTypes.NpgsqlPoint(x: 0.48789066646113766d, y: 0.3219520561149751d), new NpgsqlTypes.NpgsqlPoint(x: 0.3147714126890664d, y: 0.4708788872367603d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9610890715903746d, y: 0.20375940675398652d), new NpgsqlTypes.NpgsqlPoint(x: 0.21835659834972854d, y: 0.4229740684221003d), new NpgsqlTypes.NpgsqlPoint(x: 0.7580618759683702d, y: 0.11857772734675864d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5581793870292507d, y: 0.08599001105851634d), new NpgsqlTypes.NpgsqlPoint(x: 0.2989323672989763d, y: 0.05858808339990973d), new NpgsqlTypes.NpgsqlPoint(x: 0.8536526497641455d, y: 0.07912403187491046d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.049157663080545366d, y: 0.34603743756906036d), new NpgsqlTypes.NpgsqlPoint(x: 0.20601599626282685d, y: 0.6570230179685569d), new NpgsqlTypes.NpgsqlPoint(x: 0.1806637826597226d, y: 0.3786042597280034d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5311950642818174d, y: 0.46123679872331025d), new NpgsqlTypes.NpgsqlPoint(x: 0.17521593782435507d, y: 0.39600320343996753d), new NpgsqlTypes.NpgsqlPoint(x: 0.4027680900406727d, y: 0.9320109359459399d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08489308499808679d, y: 0.7522397645365769d), new NpgsqlTypes.NpgsqlPoint(x: 0.004543886056824209d, y: 0.9496743360807515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5888395578270824d, y: 0.4920590791530014d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3183526988153146d, y: 0.45906053118426315d), new NpgsqlTypes.NpgsqlPoint(x: 0.25686761790625323d, y: 0.6138782393734874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8497626678833108d, y: 0.8374987275447814d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6297429872819341d, y: 0.6603859360301717d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927528555387697d, y: 0.31662488526638066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5140843583575178d, y: 0.35440089408752773d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4553311841743838d, y: 0.18828966180026563d), new NpgsqlTypes.NpgsqlPoint(x: 0.6582338534010389d, y: 0.5472604230039247d), new NpgsqlTypes.NpgsqlPoint(x: 0.10136318830398905d, y: 0.8637389658102175d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8564530188537083d, y: 0.9868594899514865d), new NpgsqlTypes.NpgsqlPoint(x: 0.6920968616973263d, y: 0.987350152541338d), new NpgsqlTypes.NpgsqlPoint(x: 0.7407241629829305d, y: 0.19123993064065758d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47738895232954637d, y: 0.5687098594727475d), new NpgsqlTypes.NpgsqlPoint(x: 0.36532449136993284d, y: 0.47679263201495614d), new NpgsqlTypes.NpgsqlPoint(x: 0.07186897016374405d, y: 0.9889748578798643d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2976637565228101d, y: 0.8410549030027511d), new NpgsqlTypes.NpgsqlPoint(x: 0.010759463463269725d, y: 0.3945021153405873d), new NpgsqlTypes.NpgsqlPoint(x: 0.2852178894283204d, y: 0.15740553110229727d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1559271033353442d, y: 0.8239833838004443d), new NpgsqlTypes.NpgsqlPoint(x: 0.1337921447359276d, y: 0.6729497697260266d), new NpgsqlTypes.NpgsqlPoint(x: 0.23524839937333553d, y: 0.886611145617319d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4422329540356146d, y: 0.02332659201388132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6695493639527681d, y: 0.5152571154355521d), new NpgsqlTypes.NpgsqlPoint(x: 0.7095316239404587d, y: 0.5909228170974045d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21399824953454205d, y: 0.5844762786572326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7177099742379517d, y: 0.1452263359813718d), new NpgsqlTypes.NpgsqlPoint(x: 0.857347016306001d, y: 0.8498977994234685d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18471396561380637d, y: 0.06620302798433308d), new NpgsqlTypes.NpgsqlPoint(x: 0.09772938553215171d, y: 0.8495179239751027d), new NpgsqlTypes.NpgsqlPoint(x: 0.09939205787395744d, y: 0.8104996189617315d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3788281040465702d, y: 0.42234950490979484d), new NpgsqlTypes.NpgsqlPoint(x: 0.28916058400554223d, y: 0.9009162735807652d), new NpgsqlTypes.NpgsqlPoint(x: 0.3354068400049023d, y: 0.34199460482795574d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.027371663817338354d, y: 0.11767063565390723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6706834042118099d, y: 0.2444488296439784d), new NpgsqlTypes.NpgsqlPoint(x: 0.04554000996234031d, y: 0.891525214212173d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11491419019903326d, y: 0.7094563154166513d), new NpgsqlTypes.NpgsqlPoint(x: 0.654032675751299d, y: 0.29484468538175657d), new NpgsqlTypes.NpgsqlPoint(x: 0.461474255073302d, y: 0.3907008660861109d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6429134153368753d, y: 0.36918606702213896d), new NpgsqlTypes.NpgsqlPoint(x: 0.18140721230501422d, y: 0.07259504913374226d), new NpgsqlTypes.NpgsqlPoint(x: 0.33219541841225064d, y: 0.10129025894412735d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5728885981864925d, y: 0.005958667006803031d), new NpgsqlTypes.NpgsqlPoint(x: 0.24001969589435523d, y: 0.6101150562193428d), new NpgsqlTypes.NpgsqlPoint(x: 0.9147171414956744d, y: 0.7126982858395038d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2650278251379611d, y: 0.3622144579085066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5629457580275421d, y: 0.14173358420035853d), new NpgsqlTypes.NpgsqlPoint(x: 0.19906502680317328d, y: 0.592098968883341d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07767243240554345d, y: 0.3306331398044102d), new NpgsqlTypes.NpgsqlPoint(x: 0.46564700923006286d, y: 0.7333607932921702d), new NpgsqlTypes.NpgsqlPoint(x: 0.2669879908664188d, y: 0.3492822684408815d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8877854998013893d, y: 0.5475686505182992d), new NpgsqlTypes.NpgsqlPoint(x: 0.99186378749879d, y: 0.7560897655714462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6989472268324322d, y: 0.15521990592175117d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48289683953915685d, y: 0.7205069869257886d), new NpgsqlTypes.NpgsqlPoint(x: 0.05732411069311971d, y: 0.18528796529660796d), new NpgsqlTypes.NpgsqlPoint(x: 0.4857654070899572d, y: 0.06929292754342531d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028234263556119243d, y: 0.7715142084649996d), new NpgsqlTypes.NpgsqlPoint(x: 0.28925677449513654d, y: 0.6178999043095788d), new NpgsqlTypes.NpgsqlPoint(x: 0.23344517107740714d, y: 0.4648681983008167d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07830316768746182d, y: 0.2138962842984199d), new NpgsqlTypes.NpgsqlPoint(x: 0.5193835926320722d, y: 0.5011303959263292d), new NpgsqlTypes.NpgsqlPoint(x: 0.6556103035299045d, y: 0.03512886486010558d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12037753791314632d, y: 0.9090645479634792d), new NpgsqlTypes.NpgsqlPoint(x: 0.12856270426408734d, y: 0.2434145396479287d), new NpgsqlTypes.NpgsqlPoint(x: 0.3772895671638531d, y: 0.7112396493680069d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3928138469465504d, y: 0.24576098868982088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3153634892533411d, y: 0.12134094116367689d), new NpgsqlTypes.NpgsqlPoint(x: 0.920179496472718d, y: 0.6927966936541626d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26386084115992425d, y: 0.06632001561436385d), new NpgsqlTypes.NpgsqlPoint(x: 0.3801158791816769d, y: 0.9620383446906763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5531150400506921d, y: 0.41793059451546033d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9628728829832983d, y: 0.8362818498808771d), new NpgsqlTypes.NpgsqlPoint(x: 0.0612378016710331d, y: 0.6605935444760734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6855598775063095d, y: 0.4361775514163331d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08624933613837205d, y: 0.7011826233547326d), new NpgsqlTypes.NpgsqlPoint(x: 0.1563305294930355d, y: 0.2027945336629169d), new NpgsqlTypes.NpgsqlPoint(x: 0.9444543279173911d, y: 0.5767731564148274d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.009961189462394326d, y: 0.013727239326651652d), new NpgsqlTypes.NpgsqlPoint(x: 0.3329724534841907d, y: 0.19699281381823375d), new NpgsqlTypes.NpgsqlPoint(x: 0.4936832484342941d, y: 0.6742196363254541d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7714082562768254d, y: 0.5091851413701285d), new NpgsqlTypes.NpgsqlPoint(x: 0.4937707879796863d, y: 0.18699191983317498d), new NpgsqlTypes.NpgsqlPoint(x: 0.8717398002153462d, y: 0.15601270261703382d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5362696584658447d, y: 0.29767648765465937d), new NpgsqlTypes.NpgsqlPoint(x: 0.6985895426438455d, y: 0.17640782628210516d), new NpgsqlTypes.NpgsqlPoint(x: 0.7106785909528031d, y: 0.5394375860352979d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3135821643000256d, y: 0.4306479086241811d), new NpgsqlTypes.NpgsqlPoint(x: 0.39848900652542096d, y: 0.941939781658163d), new NpgsqlTypes.NpgsqlPoint(x: 0.770141077142308d, y: 0.7546822910247787d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.52697809511516d, y: 0.6408015922209944d), new NpgsqlTypes.NpgsqlPoint(x: 0.47108124336113943d, y: 0.34612797690915187d), new NpgsqlTypes.NpgsqlPoint(x: 0.754027741462201d, y: 0.8836437517688042d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9211393999059456d, y: 0.6672935385938323d), new NpgsqlTypes.NpgsqlPoint(x: 0.8273747964088385d, y: 0.09408288482189486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4030796531416061d, y: 0.911930957385644d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3188299512529641d, y: 0.971707498435188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9533447881735247d, y: 0.8041183359403035d), new NpgsqlTypes.NpgsqlPoint(x: 0.47749958750745747d, y: 0.12445190435842002d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6103227785644169d, y: 0.40874715944229334d), new NpgsqlTypes.NpgsqlPoint(x: 0.6037893922375875d, y: 0.8293821918985811d), new NpgsqlTypes.NpgsqlPoint(x: 0.5369071257537213d, y: 0.2971312991330095d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9243637291594071d, y: 0.4908644479505305d), new NpgsqlTypes.NpgsqlPoint(x: 0.08184809800772752d, y: 0.34387120680889094d), new NpgsqlTypes.NpgsqlPoint(x: 0.4430589383820286d, y: 0.8735807751284319d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.432990100292304d, y: 0.8515384797346052d), new NpgsqlTypes.NpgsqlPoint(x: 0.908619455150657d, y: 0.7154001066174712d), new NpgsqlTypes.NpgsqlPoint(x: 0.6126810698066874d, y: 0.18071272789987736d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14645826787477068d, y: 0.15794711753753643d), new NpgsqlTypes.NpgsqlPoint(x: 0.48667046491751886d, y: 0.0917490938312816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5368983417293228d, y: 0.09003371805261029d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9597410685615707d, y: 0.27746477973136907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7401936897055156d, y: 0.3779245068028656d), new NpgsqlTypes.NpgsqlPoint(x: 0.26557439430970486d, y: 0.943125671476761d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4477069148166458d, y: 0.8662597083102216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5878508896471415d, y: 0.3429427214499363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6251185827342042d, y: 0.3074892773620599d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9690056223515379d, y: 0.29472664098087753d), new NpgsqlTypes.NpgsqlPoint(x: 0.03502595240575124d, y: 0.9035401325304712d), new NpgsqlTypes.NpgsqlPoint(x: 0.6481696961925761d, y: 0.9551723405930881d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.052427607083513794d, y: 0.030298122349910916d), new NpgsqlTypes.NpgsqlPoint(x: 0.7844811663120836d, y: 0.785976952474065d), new NpgsqlTypes.NpgsqlPoint(x: 0.26225180449480456d, y: 0.8593646589921693d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3392696291463727d, y: 0.7776365321373437d), new NpgsqlTypes.NpgsqlPoint(x: 0.2088256448423389d, y: 0.3512727844964376d), new NpgsqlTypes.NpgsqlPoint(x: 0.15653199708914534d, y: 0.8956068871136298d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8477858020283657d, y: 0.04273248770772253d), new NpgsqlTypes.NpgsqlPoint(x: 0.05884669046304736d, y: 0.7566778647122313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318085692793959d, y: 0.23323430682876467d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7126977224955933d, y: 0.01573008673912213d), new NpgsqlTypes.NpgsqlPoint(x: 0.2979701937379372d, y: 0.93957456849604d), new NpgsqlTypes.NpgsqlPoint(x: 0.30523223306077185d, y: 0.011465675252389729d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4306148889300272d, y: 0.3849563517454214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8928949698114329d, y: 0.10464240840687133d), new NpgsqlTypes.NpgsqlPoint(x: 0.32654773574568274d, y: 0.7200116172855949d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06617860102834217d, y: 0.19071922331878377d), new NpgsqlTypes.NpgsqlPoint(x: 0.3399066362886918d, y: 0.12243379695261924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337060249480836d, y: 0.01751560401985841d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5776413410147938d, y: 0.32511661598488983d), new NpgsqlTypes.NpgsqlPoint(x: 0.7460891740746216d, y: 0.5712515889142264d), new NpgsqlTypes.NpgsqlPoint(x: 0.32602586326295946d, y: 0.36785266341297207d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2668885019059225d, y: 0.05509345167016644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8393660633645171d, y: 0.49878087089844014d), new NpgsqlTypes.NpgsqlPoint(x: 0.34464078340739546d, y: 0.2273086076822317d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12991103161623785d, y: 0.9703695048798451d), new NpgsqlTypes.NpgsqlPoint(x: 0.744007132030738d, y: 0.7604403970967707d), new NpgsqlTypes.NpgsqlPoint(x: 0.4098906597954334d, y: 0.6847423433152438d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7060519736080234d, y: 0.7251666233126688d), new NpgsqlTypes.NpgsqlPoint(x: 0.15981193859928022d, y: 0.9529658900691294d), new NpgsqlTypes.NpgsqlPoint(x: 0.9802966495425419d, y: 0.0688761141384221d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21723407938731687d, y: 0.6330131642669424d), new NpgsqlTypes.NpgsqlPoint(x: 0.08143540542132188d, y: 0.6593523246756653d), new NpgsqlTypes.NpgsqlPoint(x: 0.22059471683973375d, y: 0.7357114551588511d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10912126937332522d, y: 0.3882243037745853d), new NpgsqlTypes.NpgsqlPoint(x: 0.6211399646800355d, y: 0.531593923439143d), new NpgsqlTypes.NpgsqlPoint(x: 0.9807995270387176d, y: 0.6487996463174371d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3585305063845089d, y: 0.2041179578872282d), new NpgsqlTypes.NpgsqlPoint(x: 0.9815529446528504d, y: 0.34399768165315703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7241683368263985d, y: 0.23539011421712852d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8415284927758822d, y: 0.3088037052529188d), new NpgsqlTypes.NpgsqlPoint(x: 0.3915907275119106d, y: 0.5437659219388072d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510505238278171d, y: 0.44460529027229667d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36209893183908204d, y: 0.2859359723610668d), new NpgsqlTypes.NpgsqlPoint(x: 0.9050074508150344d, y: 0.08097555155964853d), new NpgsqlTypes.NpgsqlPoint(x: 0.1072717433063618d, y: 0.11266551848198669d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5280502174629784d, y: 0.33413403931079255d), new NpgsqlTypes.NpgsqlPoint(x: 0.24572490120869928d, y: 0.16793998188371217d), new NpgsqlTypes.NpgsqlPoint(x: 0.6502570858549298d, y: 0.7940369000574501d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6444421373567061d, y: 0.007077099670661835d), new NpgsqlTypes.NpgsqlPoint(x: 0.3536518137229213d, y: 0.6646742295105849d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606736499549057d, y: 0.2859888427123436d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27896035436395805d, y: 0.6526288763387615d), new NpgsqlTypes.NpgsqlPoint(x: 0.035806970095655255d, y: 0.02126699910674046d), new NpgsqlTypes.NpgsqlPoint(x: 0.3675572861566946d, y: 0.20807952000700036d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01808947552564244d, y: 0.9580092354433104d), new NpgsqlTypes.NpgsqlPoint(x: 0.29963536246872713d, y: 0.2671987235156451d), new NpgsqlTypes.NpgsqlPoint(x: 0.8760044065845163d, y: 0.27619905078145535d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4130547558908798d, y: 0.4524103530441155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6086146222355701d, y: 0.8365831013140914d), new NpgsqlTypes.NpgsqlPoint(x: 0.06079300843764268d, y: 0.050787194508330136d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.876818577308707d, y: 0.9772542641230646d), new NpgsqlTypes.NpgsqlPoint(x: 0.2802868957521163d, y: 0.5885193841819449d), new NpgsqlTypes.NpgsqlPoint(x: 0.4673702850433048d, y: 0.8844686312964354d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7657763573659095d, y: 0.3721225365438692d), new NpgsqlTypes.NpgsqlPoint(x: 0.1253873429429445d, y: 0.40873404805646596d), new NpgsqlTypes.NpgsqlPoint(x: 0.8857927154355334d, y: 0.06597680126733196d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2765125869668217d, y: 0.4603057630129791d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440602955585303d, y: 0.8857836359388299d), new NpgsqlTypes.NpgsqlPoint(x: 0.1522886891605485d, y: 0.3819460692650507d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35295505681384065d, y: 0.43044032077937733d), new NpgsqlTypes.NpgsqlPoint(x: 0.18704200394529635d, y: 0.6632821849304122d), new NpgsqlTypes.NpgsqlPoint(x: 0.5721199252204187d, y: 0.6923130006687843d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9288097352833533d, y: 0.7582073556738657d), new NpgsqlTypes.NpgsqlPoint(x: 0.18009669234779357d, y: 0.175078012855728d), new NpgsqlTypes.NpgsqlPoint(x: 0.4662857633339341d, y: 0.056913328490903914d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9790587154721306d, y: 0.06562418368149092d), new NpgsqlTypes.NpgsqlPoint(x: 0.18054071662309745d, y: 0.317472470943033d), new NpgsqlTypes.NpgsqlPoint(x: 0.39027375892291594d, y: 0.7645308343002869d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5855117229947632d, y: 0.7140205043888663d), new NpgsqlTypes.NpgsqlPoint(x: 0.5252185875138381d, y: 0.7176151428634089d), new NpgsqlTypes.NpgsqlPoint(x: 0.3660906930382418d, y: 0.22498161792159765d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5349976535821938d, y: 0.39810325641962374d), new NpgsqlTypes.NpgsqlPoint(x: 0.7143944445230256d, y: 0.9429343956816764d), new NpgsqlTypes.NpgsqlPoint(x: 0.7614214105264774d, y: 0.2010219293094364d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3567633565294208d, y: 0.5147533394119309d), new NpgsqlTypes.NpgsqlPoint(x: 0.02249959362918974d, y: 0.5570723850219991d), new NpgsqlTypes.NpgsqlPoint(x: 0.5817700014669626d, y: 0.8045048574003709d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.921718523837797d, y: 0.5677204889856196d), new NpgsqlTypes.NpgsqlPoint(x: 0.32492919510134444d, y: 0.8484280727988794d), new NpgsqlTypes.NpgsqlPoint(x: 0.3863526468219056d, y: 0.16956015583606843d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.944402991662938d, y: 0.8433129882430758d), new NpgsqlTypes.NpgsqlPoint(x: 0.8505663813545217d, y: 0.024594917066147914d), new NpgsqlTypes.NpgsqlPoint(x: 0.9156186717928734d, y: 0.5023508415050395d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8830880290615769d, y: 0.11886749925265472d), new NpgsqlTypes.NpgsqlPoint(x: 0.04278334276325013d, y: 0.9355371108212692d), new NpgsqlTypes.NpgsqlPoint(x: 0.04784893953646441d, y: 0.35632411585651014d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5506464949782831d, y: 0.4755296235644664d), new NpgsqlTypes.NpgsqlPoint(x: 0.764993198938647d, y: 0.16180768048626326d), new NpgsqlTypes.NpgsqlPoint(x: 0.9563222837557454d, y: 0.3491215266630183d)))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3268771892128327d, y: 0.9957699809413665d), new NpgsqlTypes.NpgsqlPoint(x: 0.8559806199158562d, y: 0.9446759764193617d), new NpgsqlTypes.NpgsqlPoint(x: 0.7098088359263354d, y: 0.6704091655538696d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6615934705842919d, y: 0.8177793758012998d), new NpgsqlTypes.NpgsqlPoint(x: 0.8819682463935296d, y: 0.34015279144800625d), new NpgsqlTypes.NpgsqlPoint(x: 0.050057172415369d, y: 0.14432825355047096d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48171094942153503d, y: 0.8135455192964506d), new NpgsqlTypes.NpgsqlPoint(x: 0.6113697820713015d, y: 0.562305747971842d), new NpgsqlTypes.NpgsqlPoint(x: 0.18009082637041762d, y: 0.6724438675301695d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17579768146592978d, y: 0.3632120730910552d), new NpgsqlTypes.NpgsqlPoint(x: 0.14740072318490616d, y: 0.33811860693998863d), new NpgsqlTypes.NpgsqlPoint(x: 0.46426905216463055d, y: 0.09728389312315633d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9533498795196778d, y: 0.23111728358482597d), new NpgsqlTypes.NpgsqlPoint(x: 0.48789066646113766d, y: 0.3219520561149751d), new NpgsqlTypes.NpgsqlPoint(x: 0.3147714126890664d, y: 0.4708788872367603d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9610890715903746d, y: 0.20375940675398652d), new NpgsqlTypes.NpgsqlPoint(x: 0.21835659834972854d, y: 0.4229740684221003d), new NpgsqlTypes.NpgsqlPoint(x: 0.7580618759683702d, y: 0.11857772734675864d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5581793870292507d, y: 0.08599001105851634d), new NpgsqlTypes.NpgsqlPoint(x: 0.2989323672989763d, y: 0.05858808339990973d), new NpgsqlTypes.NpgsqlPoint(x: 0.8536526497641455d, y: 0.07912403187491046d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.049157663080545366d, y: 0.34603743756906036d), new NpgsqlTypes.NpgsqlPoint(x: 0.20601599626282685d, y: 0.6570230179685569d), new NpgsqlTypes.NpgsqlPoint(x: 0.1806637826597226d, y: 0.3786042597280034d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5311950642818174d, y: 0.46123679872331025d), new NpgsqlTypes.NpgsqlPoint(x: 0.17521593782435507d, y: 0.39600320343996753d), new NpgsqlTypes.NpgsqlPoint(x: 0.4027680900406727d, y: 0.9320109359459399d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08489308499808679d, y: 0.7522397645365769d), new NpgsqlTypes.NpgsqlPoint(x: 0.004543886056824209d, y: 0.9496743360807515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5888395578270824d, y: 0.4920590791530014d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3183526988153146d, y: 0.45906053118426315d), new NpgsqlTypes.NpgsqlPoint(x: 0.25686761790625323d, y: 0.6138782393734874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8497626678833108d, y: 0.8374987275447814d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6297429872819341d, y: 0.6603859360301717d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927528555387697d, y: 0.31662488526638066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5140843583575178d, y: 0.35440089408752773d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4553311841743838d, y: 0.18828966180026563d), new NpgsqlTypes.NpgsqlPoint(x: 0.6582338534010389d, y: 0.5472604230039247d), new NpgsqlTypes.NpgsqlPoint(x: 0.10136318830398905d, y: 0.8637389658102175d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8564530188537083d, y: 0.9868594899514865d), new NpgsqlTypes.NpgsqlPoint(x: 0.6920968616973263d, y: 0.987350152541338d), new NpgsqlTypes.NpgsqlPoint(x: 0.7407241629829305d, y: 0.19123993064065758d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47738895232954637d, y: 0.5687098594727475d), new NpgsqlTypes.NpgsqlPoint(x: 0.36532449136993284d, y: 0.47679263201495614d), new NpgsqlTypes.NpgsqlPoint(x: 0.07186897016374405d, y: 0.9889748578798643d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2976637565228101d, y: 0.8410549030027511d), new NpgsqlTypes.NpgsqlPoint(x: 0.010759463463269725d, y: 0.3945021153405873d), new NpgsqlTypes.NpgsqlPoint(x: 0.2852178894283204d, y: 0.15740553110229727d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1559271033353442d, y: 0.8239833838004443d), new NpgsqlTypes.NpgsqlPoint(x: 0.1337921447359276d, y: 0.6729497697260266d), new NpgsqlTypes.NpgsqlPoint(x: 0.23524839937333553d, y: 0.886611145617319d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4422329540356146d, y: 0.02332659201388132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6695493639527681d, y: 0.5152571154355521d), new NpgsqlTypes.NpgsqlPoint(x: 0.7095316239404587d, y: 0.5909228170974045d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21399824953454205d, y: 0.5844762786572326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7177099742379517d, y: 0.1452263359813718d), new NpgsqlTypes.NpgsqlPoint(x: 0.857347016306001d, y: 0.8498977994234685d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18471396561380637d, y: 0.06620302798433308d), new NpgsqlTypes.NpgsqlPoint(x: 0.09772938553215171d, y: 0.8495179239751027d), new NpgsqlTypes.NpgsqlPoint(x: 0.09939205787395744d, y: 0.8104996189617315d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3788281040465702d, y: 0.42234950490979484d), new NpgsqlTypes.NpgsqlPoint(x: 0.28916058400554223d, y: 0.9009162735807652d), new NpgsqlTypes.NpgsqlPoint(x: 0.3354068400049023d, y: 0.34199460482795574d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.027371663817338354d, y: 0.11767063565390723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6706834042118099d, y: 0.2444488296439784d), new NpgsqlTypes.NpgsqlPoint(x: 0.04554000996234031d, y: 0.891525214212173d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11491419019903326d, y: 0.7094563154166513d), new NpgsqlTypes.NpgsqlPoint(x: 0.654032675751299d, y: 0.29484468538175657d), new NpgsqlTypes.NpgsqlPoint(x: 0.461474255073302d, y: 0.3907008660861109d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6429134153368753d, y: 0.36918606702213896d), new NpgsqlTypes.NpgsqlPoint(x: 0.18140721230501422d, y: 0.07259504913374226d), new NpgsqlTypes.NpgsqlPoint(x: 0.33219541841225064d, y: 0.10129025894412735d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5728885981864925d, y: 0.005958667006803031d), new NpgsqlTypes.NpgsqlPoint(x: 0.24001969589435523d, y: 0.6101150562193428d), new NpgsqlTypes.NpgsqlPoint(x: 0.9147171414956744d, y: 0.7126982858395038d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2650278251379611d, y: 0.3622144579085066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5629457580275421d, y: 0.14173358420035853d), new NpgsqlTypes.NpgsqlPoint(x: 0.19906502680317328d, y: 0.592098968883341d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07767243240554345d, y: 0.3306331398044102d), new NpgsqlTypes.NpgsqlPoint(x: 0.46564700923006286d, y: 0.7333607932921702d), new NpgsqlTypes.NpgsqlPoint(x: 0.2669879908664188d, y: 0.3492822684408815d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8877854998013893d, y: 0.5475686505182992d), new NpgsqlTypes.NpgsqlPoint(x: 0.99186378749879d, y: 0.7560897655714462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6989472268324322d, y: 0.15521990592175117d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48289683953915685d, y: 0.7205069869257886d), new NpgsqlTypes.NpgsqlPoint(x: 0.05732411069311971d, y: 0.18528796529660796d), new NpgsqlTypes.NpgsqlPoint(x: 0.4857654070899572d, y: 0.06929292754342531d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028234263556119243d, y: 0.7715142084649996d), new NpgsqlTypes.NpgsqlPoint(x: 0.28925677449513654d, y: 0.6178999043095788d), new NpgsqlTypes.NpgsqlPoint(x: 0.23344517107740714d, y: 0.4648681983008167d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07830316768746182d, y: 0.2138962842984199d), new NpgsqlTypes.NpgsqlPoint(x: 0.5193835926320722d, y: 0.5011303959263292d), new NpgsqlTypes.NpgsqlPoint(x: 0.6556103035299045d, y: 0.03512886486010558d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12037753791314632d, y: 0.9090645479634792d), new NpgsqlTypes.NpgsqlPoint(x: 0.12856270426408734d, y: 0.2434145396479287d), new NpgsqlTypes.NpgsqlPoint(x: 0.3772895671638531d, y: 0.7112396493680069d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3928138469465504d, y: 0.24576098868982088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3153634892533411d, y: 0.12134094116367689d), new NpgsqlTypes.NpgsqlPoint(x: 0.920179496472718d, y: 0.6927966936541626d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26386084115992425d, y: 0.06632001561436385d), new NpgsqlTypes.NpgsqlPoint(x: 0.3801158791816769d, y: 0.9620383446906763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5531150400506921d, y: 0.41793059451546033d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9628728829832983d, y: 0.8362818498808771d), new NpgsqlTypes.NpgsqlPoint(x: 0.0612378016710331d, y: 0.6605935444760734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6855598775063095d, y: 0.4361775514163331d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08624933613837205d, y: 0.7011826233547326d), new NpgsqlTypes.NpgsqlPoint(x: 0.1563305294930355d, y: 0.2027945336629169d), new NpgsqlTypes.NpgsqlPoint(x: 0.9444543279173911d, y: 0.5767731564148274d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.009961189462394326d, y: 0.013727239326651652d), new NpgsqlTypes.NpgsqlPoint(x: 0.3329724534841907d, y: 0.19699281381823375d), new NpgsqlTypes.NpgsqlPoint(x: 0.4936832484342941d, y: 0.6742196363254541d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7714082562768254d, y: 0.5091851413701285d), new NpgsqlTypes.NpgsqlPoint(x: 0.4937707879796863d, y: 0.18699191983317498d), new NpgsqlTypes.NpgsqlPoint(x: 0.8717398002153462d, y: 0.15601270261703382d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5362696584658447d, y: 0.29767648765465937d), new NpgsqlTypes.NpgsqlPoint(x: 0.6985895426438455d, y: 0.17640782628210516d), new NpgsqlTypes.NpgsqlPoint(x: 0.7106785909528031d, y: 0.5394375860352979d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3135821643000256d, y: 0.4306479086241811d), new NpgsqlTypes.NpgsqlPoint(x: 0.39848900652542096d, y: 0.941939781658163d), new NpgsqlTypes.NpgsqlPoint(x: 0.770141077142308d, y: 0.7546822910247787d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.52697809511516d, y: 0.6408015922209944d), new NpgsqlTypes.NpgsqlPoint(x: 0.47108124336113943d, y: 0.34612797690915187d), new NpgsqlTypes.NpgsqlPoint(x: 0.754027741462201d, y: 0.8836437517688042d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9211393999059456d, y: 0.6672935385938323d), new NpgsqlTypes.NpgsqlPoint(x: 0.8273747964088385d, y: 0.09408288482189486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4030796531416061d, y: 0.911930957385644d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3188299512529641d, y: 0.971707498435188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9533447881735247d, y: 0.8041183359403035d), new NpgsqlTypes.NpgsqlPoint(x: 0.47749958750745747d, y: 0.12445190435842002d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6103227785644169d, y: 0.40874715944229334d), new NpgsqlTypes.NpgsqlPoint(x: 0.6037893922375875d, y: 0.8293821918985811d), new NpgsqlTypes.NpgsqlPoint(x: 0.5369071257537213d, y: 0.2971312991330095d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9243637291594071d, y: 0.4908644479505305d), new NpgsqlTypes.NpgsqlPoint(x: 0.08184809800772752d, y: 0.34387120680889094d), new NpgsqlTypes.NpgsqlPoint(x: 0.4430589383820286d, y: 0.8735807751284319d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.432990100292304d, y: 0.8515384797346052d), new NpgsqlTypes.NpgsqlPoint(x: 0.908619455150657d, y: 0.7154001066174712d), new NpgsqlTypes.NpgsqlPoint(x: 0.6126810698066874d, y: 0.18071272789987736d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14645826787477068d, y: 0.15794711753753643d), new NpgsqlTypes.NpgsqlPoint(x: 0.48667046491751886d, y: 0.0917490938312816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5368983417293228d, y: 0.09003371805261029d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9597410685615707d, y: 0.27746477973136907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7401936897055156d, y: 0.3779245068028656d), new NpgsqlTypes.NpgsqlPoint(x: 0.26557439430970486d, y: 0.943125671476761d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4477069148166458d, y: 0.8662597083102216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5878508896471415d, y: 0.3429427214499363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6251185827342042d, y: 0.3074892773620599d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9690056223515379d, y: 0.29472664098087753d), new NpgsqlTypes.NpgsqlPoint(x: 0.03502595240575124d, y: 0.9035401325304712d), new NpgsqlTypes.NpgsqlPoint(x: 0.6481696961925761d, y: 0.9551723405930881d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.052427607083513794d, y: 0.030298122349910916d), new NpgsqlTypes.NpgsqlPoint(x: 0.7844811663120836d, y: 0.785976952474065d), new NpgsqlTypes.NpgsqlPoint(x: 0.26225180449480456d, y: 0.8593646589921693d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3392696291463727d, y: 0.7776365321373437d), new NpgsqlTypes.NpgsqlPoint(x: 0.2088256448423389d, y: 0.3512727844964376d), new NpgsqlTypes.NpgsqlPoint(x: 0.15653199708914534d, y: 0.8956068871136298d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8477858020283657d, y: 0.04273248770772253d), new NpgsqlTypes.NpgsqlPoint(x: 0.05884669046304736d, y: 0.7566778647122313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318085692793959d, y: 0.23323430682876467d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7126977224955933d, y: 0.01573008673912213d), new NpgsqlTypes.NpgsqlPoint(x: 0.2979701937379372d, y: 0.93957456849604d), new NpgsqlTypes.NpgsqlPoint(x: 0.30523223306077185d, y: 0.011465675252389729d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4306148889300272d, y: 0.3849563517454214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8928949698114329d, y: 0.10464240840687133d), new NpgsqlTypes.NpgsqlPoint(x: 0.32654773574568274d, y: 0.7200116172855949d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06617860102834217d, y: 0.19071922331878377d), new NpgsqlTypes.NpgsqlPoint(x: 0.3399066362886918d, y: 0.12243379695261924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337060249480836d, y: 0.01751560401985841d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5776413410147938d, y: 0.32511661598488983d), new NpgsqlTypes.NpgsqlPoint(x: 0.7460891740746216d, y: 0.5712515889142264d), new NpgsqlTypes.NpgsqlPoint(x: 0.32602586326295946d, y: 0.36785266341297207d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2668885019059225d, y: 0.05509345167016644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8393660633645171d, y: 0.49878087089844014d), new NpgsqlTypes.NpgsqlPoint(x: 0.34464078340739546d, y: 0.2273086076822317d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12991103161623785d, y: 0.9703695048798451d), new NpgsqlTypes.NpgsqlPoint(x: 0.744007132030738d, y: 0.7604403970967707d), new NpgsqlTypes.NpgsqlPoint(x: 0.4098906597954334d, y: 0.6847423433152438d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7060519736080234d, y: 0.7251666233126688d), new NpgsqlTypes.NpgsqlPoint(x: 0.15981193859928022d, y: 0.9529658900691294d), new NpgsqlTypes.NpgsqlPoint(x: 0.9802966495425419d, y: 0.0688761141384221d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21723407938731687d, y: 0.6330131642669424d), new NpgsqlTypes.NpgsqlPoint(x: 0.08143540542132188d, y: 0.6593523246756653d), new NpgsqlTypes.NpgsqlPoint(x: 0.22059471683973375d, y: 0.7357114551588511d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10912126937332522d, y: 0.3882243037745853d), new NpgsqlTypes.NpgsqlPoint(x: 0.6211399646800355d, y: 0.531593923439143d), new NpgsqlTypes.NpgsqlPoint(x: 0.9807995270387176d, y: 0.6487996463174371d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3585305063845089d, y: 0.2041179578872282d), new NpgsqlTypes.NpgsqlPoint(x: 0.9815529446528504d, y: 0.34399768165315703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7241683368263985d, y: 0.23539011421712852d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8415284927758822d, y: 0.3088037052529188d), new NpgsqlTypes.NpgsqlPoint(x: 0.3915907275119106d, y: 0.5437659219388072d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510505238278171d, y: 0.44460529027229667d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36209893183908204d, y: 0.2859359723610668d), new NpgsqlTypes.NpgsqlPoint(x: 0.9050074508150344d, y: 0.08097555155964853d), new NpgsqlTypes.NpgsqlPoint(x: 0.1072717433063618d, y: 0.11266551848198669d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5280502174629784d, y: 0.33413403931079255d), new NpgsqlTypes.NpgsqlPoint(x: 0.24572490120869928d, y: 0.16793998188371217d), new NpgsqlTypes.NpgsqlPoint(x: 0.6502570858549298d, y: 0.7940369000574501d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6444421373567061d, y: 0.007077099670661835d), new NpgsqlTypes.NpgsqlPoint(x: 0.3536518137229213d, y: 0.6646742295105849d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606736499549057d, y: 0.2859888427123436d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27896035436395805d, y: 0.6526288763387615d), new NpgsqlTypes.NpgsqlPoint(x: 0.035806970095655255d, y: 0.02126699910674046d), new NpgsqlTypes.NpgsqlPoint(x: 0.3675572861566946d, y: 0.20807952000700036d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01808947552564244d, y: 0.9580092354433104d), new NpgsqlTypes.NpgsqlPoint(x: 0.29963536246872713d, y: 0.2671987235156451d), new NpgsqlTypes.NpgsqlPoint(x: 0.8760044065845163d, y: 0.27619905078145535d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4130547558908798d, y: 0.4524103530441155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6086146222355701d, y: 0.8365831013140914d), new NpgsqlTypes.NpgsqlPoint(x: 0.06079300843764268d, y: 0.050787194508330136d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.876818577308707d, y: 0.9772542641230646d), new NpgsqlTypes.NpgsqlPoint(x: 0.2802868957521163d, y: 0.5885193841819449d), new NpgsqlTypes.NpgsqlPoint(x: 0.4673702850433048d, y: 0.8844686312964354d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7657763573659095d, y: 0.3721225365438692d), new NpgsqlTypes.NpgsqlPoint(x: 0.1253873429429445d, y: 0.40873404805646596d), new NpgsqlTypes.NpgsqlPoint(x: 0.8857927154355334d, y: 0.06597680126733196d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2765125869668217d, y: 0.4603057630129791d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440602955585303d, y: 0.8857836359388299d), new NpgsqlTypes.NpgsqlPoint(x: 0.1522886891605485d, y: 0.3819460692650507d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35295505681384065d, y: 0.43044032077937733d), new NpgsqlTypes.NpgsqlPoint(x: 0.18704200394529635d, y: 0.6632821849304122d), new NpgsqlTypes.NpgsqlPoint(x: 0.5721199252204187d, y: 0.6923130006687843d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9288097352833533d, y: 0.7582073556738657d), new NpgsqlTypes.NpgsqlPoint(x: 0.18009669234779357d, y: 0.175078012855728d), new NpgsqlTypes.NpgsqlPoint(x: 0.4662857633339341d, y: 0.056913328490903914d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9790587154721306d, y: 0.06562418368149092d), new NpgsqlTypes.NpgsqlPoint(x: 0.18054071662309745d, y: 0.317472470943033d), new NpgsqlTypes.NpgsqlPoint(x: 0.39027375892291594d, y: 0.7645308343002869d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5855117229947632d, y: 0.7140205043888663d), new NpgsqlTypes.NpgsqlPoint(x: 0.5252185875138381d, y: 0.7176151428634089d), new NpgsqlTypes.NpgsqlPoint(x: 0.3660906930382418d, y: 0.22498161792159765d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5349976535821938d, y: 0.39810325641962374d), new NpgsqlTypes.NpgsqlPoint(x: 0.7143944445230256d, y: 0.9429343956816764d), new NpgsqlTypes.NpgsqlPoint(x: 0.7614214105264774d, y: 0.2010219293094364d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3567633565294208d, y: 0.5147533394119309d), new NpgsqlTypes.NpgsqlPoint(x: 0.02249959362918974d, y: 0.5570723850219991d), new NpgsqlTypes.NpgsqlPoint(x: 0.5817700014669626d, y: 0.8045048574003709d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.921718523837797d, y: 0.5677204889856196d), new NpgsqlTypes.NpgsqlPoint(x: 0.32492919510134444d, y: 0.8484280727988794d), new NpgsqlTypes.NpgsqlPoint(x: 0.3863526468219056d, y: 0.16956015583606843d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.944402991662938d, y: 0.8433129882430758d), new NpgsqlTypes.NpgsqlPoint(x: 0.8505663813545217d, y: 0.024594917066147914d), new NpgsqlTypes.NpgsqlPoint(x: 0.9156186717928734d, y: 0.5023508415050395d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8830880290615769d, y: 0.11886749925265472d), new NpgsqlTypes.NpgsqlPoint(x: 0.04278334276325013d, y: 0.9355371108212692d), new NpgsqlTypes.NpgsqlPoint(x: 0.04784893953646441d, y: 0.35632411585651014d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5506464949782831d, y: 0.4755296235644664d), new NpgsqlTypes.NpgsqlPoint(x: 0.764993198938647d, y: 0.16180768048626326d), new NpgsqlTypes.NpgsqlPoint(x: 0.9563222837557454d, y: 0.3491215266630183d)))));//Value

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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
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
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
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
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
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
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MI),
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
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
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
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
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
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
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
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygon0M),
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
FROM public.binary_npgsqlpolygonpolygon0m m
LEFT JOIN public.binary_npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
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
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
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
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
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
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
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
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
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
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI), typeof(NpgsqlPolygonpolygon0MI)],
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
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
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

