

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
    internal partial interface INpgsqlLineMArraylineMMArrayD1
    {
    }
    
    internal partial class NpgsqlLineMArraylineMMArrayD1 : INpgsqlLineMArraylineMMArrayD1
    {


#region TestData

        private readonly NpgsqlLinelineMMArrayD1E1M[] _testData = new NpgsqlLinelineMMArrayD1E1M[]
        {
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.733257328639084d, b: 0.6655622368520172d, c: 0.5330006651482683d),
new NpgsqlTypes.NpgsqlLine(a: 0.607275436840265d, b: 0.37605971724788256d, c: 0.16994007129268984d),
new NpgsqlTypes.NpgsqlLine(a: 0.5753767857679843d, b: 0.7628290079721973d, c: 0.6544901725734201d),
new NpgsqlTypes.NpgsqlLine(a: 0.2675067334187242d, b: 0.40021084178798116d, c: 0.9935498565140011d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.548849591955004d, b: 0.4262870804281127d, c: 0.571990158825362d),
new NpgsqlTypes.NpgsqlLine(a: 0.036329200063704215d, b: 0.14395771354758047d, c: 0.6580829407493968d),
new NpgsqlTypes.NpgsqlLine(a: 0.6015352468364666d, b: 0.32987230408015633d, c: 0.9639268207844509d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2445062752395919d, b: 0.9998129280326907d, c: 0.8014124063181386d),
new NpgsqlTypes.NpgsqlLine(a: 0.048690219729362494d, b: 0.4161186840715232d, c: 0.3499108566991558d),
new NpgsqlTypes.NpgsqlLine(a: 0.09675436774287005d, b: 0.767396907031323d, c: 0.2047503180564767d),
new NpgsqlTypes.NpgsqlLine(a: 0.32611149481847623d, b: 0.4463665605204249d, c: 0.8681598634183454d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7484580060672289d, b: 0.8719020197447158d, c: 0.9911499944904548d),
new NpgsqlTypes.NpgsqlLine(a: 0.0695457995631632d, b: 0.7293959889544995d, c: 0.26824150717266537d),
new NpgsqlTypes.NpgsqlLine(a: 0.23417730559442107d, b: 0.4556032817244605d, c: 0.9030108133210893d),
new NpgsqlTypes.NpgsqlLine(a: 0.8262954798097403d, b: 0.5309424261419317d, c: 0.6097894690943619d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9724601182855656d, b: 0.9963987678978098d, c: 0.5735141994378615d),
new NpgsqlTypes.NpgsqlLine(a: 0.07351668916148546d, b: 0.11696467798058197d, c: 0.5579160845283423d),
new NpgsqlTypes.NpgsqlLine(a: 0.09027841300775963d, b: 0.8327000088444869d, c: 0.6785976379948833d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.02893969339935154d, b: 0.5874545068638404d, c: 0.47924790502062853d),
new NpgsqlTypes.NpgsqlLine(a: 0.8110644400541036d, b: 0.5503393314994555d, c: 0.4399865701757353d),
new NpgsqlTypes.NpgsqlLine(a: 0.2727199322421874d, b: 0.08885379689962059d, c: 0.6375586419064108d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.27875619051488576d, b: 0.855669318761008d, c: 0.467336466636904d),
new NpgsqlTypes.NpgsqlLine(a: 0.5514495365430966d, b: 0.24602122632773182d, c: 0.029785263464778167d),
new NpgsqlTypes.NpgsqlLine(a: 0.5044979383896164d, b: 0.8704385212234538d, c: 0.14578986677587713d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.37262954283898264d, b: 0.11437327145349563d, c: 0.409943210798265d),
new NpgsqlTypes.NpgsqlLine(a: 0.6377363988710756d, b: 0.23687982842202582d, c: 0.11926271993565385d),
new NpgsqlTypes.NpgsqlLine(a: 0.3273855022741169d, b: 0.08356966471212957d, c: 0.8351960741591253d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4189604166374583d, b: 0.21725878426839518d, c: 0.04384177103556375d),
new NpgsqlTypes.NpgsqlLine(a: 0.17715024816987557d, b: 0.009021472368025196d, c: 0.8949289875062498d),
new NpgsqlTypes.NpgsqlLine(a: 0.8937969637551573d, b: 0.6363058551001145d, c: 0.6880410458451999d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3446274633241938d, b: 0.9423712598376223d, c: 0.7332191592587866d),
new NpgsqlTypes.NpgsqlLine(a: 0.8982051236694425d, b: 0.6707595387401456d, c: 0.44769793469522623d),
new NpgsqlTypes.NpgsqlLine(a: 0.5606770700885056d, b: 0.9457078725535143d, c: 0.7637951874267145d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7110048158882872d, b: 0.5574597966966454d, c: 0.732041591261276d),
new NpgsqlTypes.NpgsqlLine(a: 0.17486877075141993d, b: 0.9186683426198163d, c: 0.3045108989089934d),
new NpgsqlTypes.NpgsqlLine(a: 0.09634075889113725d, b: 0.40346523182611105d, c: 0.6299317176676698d),
new NpgsqlTypes.NpgsqlLine(a: 0.2842638323027892d, b: 0.3128279473391007d, c: 0.12941623113920808d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.20893209134809343d, b: 0.8824515840799837d, c: 0.8645914274270049d),
new NpgsqlTypes.NpgsqlLine(a: 0.7051058221311912d, b: 0.2689464576093715d, c: 0.6103592415014742d),
new NpgsqlTypes.NpgsqlLine(a: 0.21619694469392237d, b: 0.10991519693243557d, c: 0.5424763726056538d),
new NpgsqlTypes.NpgsqlLine(a: 0.18040944349940014d, b: 0.8570333721280228d, c: 0.7259393075340581d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.03949823793889351d, b: 0.3991934447100086d, c: 0.42561039764230146d),
new NpgsqlTypes.NpgsqlLine(a: 0.5416615936416006d, b: 0.6080113833473226d, c: 0.5236642592805513d),
new NpgsqlTypes.NpgsqlLine(a: 0.5647159716819434d, b: 0.4761691545223412d, c: 0.7456484193246753d),
new NpgsqlTypes.NpgsqlLine(a: 0.86329015188774d, b: 0.23056944426872172d, c: 0.6321336583530008d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5989313384592695d, b: 0.6379975491560839d, c: 0.6745482382184139d),
new NpgsqlTypes.NpgsqlLine(a: 0.7244756070057885d, b: 0.30036073264936636d, c: 0.5728034714933529d),
new NpgsqlTypes.NpgsqlLine(a: 0.3483325346081906d, b: 0.6819309082170878d, c: 0.16180277640948504d),
new NpgsqlTypes.NpgsqlLine(a: 0.39612098929084394d, b: 0.458273425395314d, c: 0.732276961353342d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2077590524331181d, b: 0.7283857239371634d, c: 0.19560061636400405d),
new NpgsqlTypes.NpgsqlLine(a: 0.886216853692082d, b: 0.19472711219361694d, c: 0.39331001118374287d),
new NpgsqlTypes.NpgsqlLine(a: 0.9516659690455536d, b: 0.12386693547931815d, c: 0.7403565666132533d),
new NpgsqlTypes.NpgsqlLine(a: 0.8374803854327928d, b: 0.5330679988585536d, c: 0.2684699480357775d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43669556360578177d, b: 0.8638029231673768d, c: 0.12905393482593575d),
new NpgsqlTypes.NpgsqlLine(a: 0.46368463158621664d, b: 0.7013299832772191d, c: 0.0521005581959586d),
new NpgsqlTypes.NpgsqlLine(a: 0.10730111729103964d, b: 0.1100250622958876d, c: 0.05143713892857227d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15474642299367802d, b: 0.874553606807204d, c: 0.49295977565411064d),
new NpgsqlTypes.NpgsqlLine(a: 0.5331881211559951d, b: 0.6118382621505638d, c: 0.74601932447422d),
new NpgsqlTypes.NpgsqlLine(a: 0.22092831564855253d, b: 0.846861654142511d, c: 0.7370715086641463d),
new NpgsqlTypes.NpgsqlLine(a: 0.18681294064475262d, b: 0.11290775727617719d, c: 0.6978235702629025d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7657879266406934d, b: 0.7976725870037105d, c: 0.3890134013576133d),
new NpgsqlTypes.NpgsqlLine(a: 0.784768682949609d, b: 0.2249292158997679d, c: 0.13649103691166042d),
new NpgsqlTypes.NpgsqlLine(a: 0.0073763844357788155d, b: 0.632393695950452d, c: 0.6079770446241525d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.002676045377717373d, b: 0.8393038450481631d, c: 0.49851800732280593d),
new NpgsqlTypes.NpgsqlLine(a: 0.760731714878602d, b: 0.3167677653181106d, c: 0.6091186698227984d),
new NpgsqlTypes.NpgsqlLine(a: 0.6217429057791184d, b: 0.14419120669761942d, c: 0.9189754999885235d),
new NpgsqlTypes.NpgsqlLine(a: 0.4624992559857154d, b: 0.5402956866554555d, c: 0.823722407533519d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6189487320569853d, b: 0.19261729096787406d, c: 0.6055081263230349d),
new NpgsqlTypes.NpgsqlLine(a: 0.4201371038076521d, b: 0.914223269568499d, c: 0.039998552166056855d),
new NpgsqlTypes.NpgsqlLine(a: 0.36729418745290443d, b: 0.7898775526202617d, c: 0.9082462334812967d),
new NpgsqlTypes.NpgsqlLine(a: 0.5688339863583824d, b: 0.029346801202357664d, c: 0.19944322759909272d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4535454566433481d, b: 0.6909472055608511d, c: 0.9747715173121041d),
new NpgsqlTypes.NpgsqlLine(a: 0.1704270103552935d, b: 0.5547446523696911d, c: 0.20598723230671123d),
new NpgsqlTypes.NpgsqlLine(a: 0.020517564824131806d, b: 0.3828432008575454d, c: 0.7915997009876558d),
new NpgsqlTypes.NpgsqlLine(a: 0.30400969274909484d, b: 0.5250673638799568d, c: 0.18479278905688823d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.34031197743822916d, b: 0.29780673335636054d, c: 0.5187144397505886d),
new NpgsqlTypes.NpgsqlLine(a: 0.3650682271301182d, b: 0.8255910920480751d, c: 0.3271944402325593d),
new NpgsqlTypes.NpgsqlLine(a: 0.7811971867396443d, b: 0.09314889678528215d, c: 0.8175491885540507d),
new NpgsqlTypes.NpgsqlLine(a: 0.3499228780785393d, b: 0.49638320985221507d, c: 0.6037590010324132d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.39647816671799074d, b: 0.13741917797358683d, c: 0.05824522787734698d),
new NpgsqlTypes.NpgsqlLine(a: 0.3337856172843773d, b: 0.9067583954523234d, c: 0.5598852923862035d),
new NpgsqlTypes.NpgsqlLine(a: 0.42475737444148154d, b: 0.4158674340689419d, c: 0.6727190939070812d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5661459192852019d, b: 0.059903335111998746d, c: 0.033940532769485054d),
new NpgsqlTypes.NpgsqlLine(a: 0.566974002591161d, b: 0.46268357593323817d, c: 0.6751336115580622d),
new NpgsqlTypes.NpgsqlLine(a: 0.6752214947908163d, b: 0.3274218096564071d, c: 0.9660120514194482d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9637328223348739d, b: 0.4079540128060729d, c: 0.5330641638226824d),
new NpgsqlTypes.NpgsqlLine(a: 0.5499825336593277d, b: 0.16275799831219062d, c: 0.36417451044206695d),
new NpgsqlTypes.NpgsqlLine(a: 0.8299278111616227d, b: 0.09915329432209441d, c: 0.5937390519373518d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7207666806957085d, b: 0.5447394977680508d, c: 0.5810105337434337d),
new NpgsqlTypes.NpgsqlLine(a: 0.5642138189685064d, b: 0.7501598659873404d, c: 0.3981752551556057d),
new NpgsqlTypes.NpgsqlLine(a: 0.572494295797427d, b: 0.7164691260592305d, c: 0.13816466037050168d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7801727818914906d, b: 0.4700996985741459d, c: 0.18076368756046146d),
new NpgsqlTypes.NpgsqlLine(a: 0.03996996846496781d, b: 0.7265921903567083d, c: 0.018330179611953157d),
new NpgsqlTypes.NpgsqlLine(a: 0.9508106640665539d, b: 0.0637709719156696d, c: 0.21985754503693677d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49805992717070324d, b: 0.23937241973980072d, c: 0.758690830427353d),
new NpgsqlTypes.NpgsqlLine(a: 0.47361451090225637d, b: 0.9763142827138666d, c: 0.9058475507368411d),
new NpgsqlTypes.NpgsqlLine(a: 0.6529479189485505d, b: 0.5256558031408604d, c: 0.7358787859896165d),
new NpgsqlTypes.NpgsqlLine(a: 0.36164354525633946d, b: 0.5292312516869598d, c: 0.18836446393616835d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40539003700242215d, b: 0.7610561593576799d, c: 0.2840422673471049d),
new NpgsqlTypes.NpgsqlLine(a: 0.5276087644018828d, b: 0.11510831921013875d, c: 0.9684135471857853d),
new NpgsqlTypes.NpgsqlLine(a: 0.34459697897246955d, b: 0.6569899689129578d, c: 0.030972738815597256d),
new NpgsqlTypes.NpgsqlLine(a: 0.5819959291761913d, b: 0.6662926624456132d, c: 0.2308399406201046d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5808026625708019d, b: 0.6782046474382616d, c: 0.7499577223897319d),
new NpgsqlTypes.NpgsqlLine(a: 0.8575783951278914d, b: 0.3083052372319999d, c: 0.11955224663878627d),
new NpgsqlTypes.NpgsqlLine(a: 0.4271357241020134d, b: 0.8796487083230493d, c: 0.25734673614354475d),
new NpgsqlTypes.NpgsqlLine(a: 0.8872404794426091d, b: 0.8802631224345088d, c: 0.4146468372332961d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1378588591204607d, b: 0.08002937944863941d, c: 0.11223352687442212d),
new NpgsqlTypes.NpgsqlLine(a: 0.4821881313677281d, b: 0.24633951607843785d, c: 0.04683217806883333d),
new NpgsqlTypes.NpgsqlLine(a: 0.8702883932123091d, b: 0.36086806716113584d, c: 0.13284885002975488d),
new NpgsqlTypes.NpgsqlLine(a: 0.8189928706168682d, b: 0.5009138150643121d, c: 0.46337622775609244d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9576233213229571d, b: 0.7637746642519818d, c: 0.6558985315095367d),
new NpgsqlTypes.NpgsqlLine(a: 0.9756735975328623d, b: 0.11698898705522831d, c: 0.05239453117260773d),
new NpgsqlTypes.NpgsqlLine(a: 0.7237481384453499d, b: 0.32573779595806984d, c: 0.41831042189459067d),
new NpgsqlTypes.NpgsqlLine(a: 0.4713625177299987d, b: 0.5410017465201183d, c: 0.9737748091430493d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48804226083841873d, b: 0.5348530955500548d, c: 0.848786020864027d),
new NpgsqlTypes.NpgsqlLine(a: 0.15815493054128615d, b: 0.1296981293485533d, c: 0.8606778638472834d),
new NpgsqlTypes.NpgsqlLine(a: 0.008660720434428115d, b: 0.6078577665287175d, c: 0.6027823080697512d),
new NpgsqlTypes.NpgsqlLine(a: 0.050771584124296165d, b: 0.26338669487759214d, c: 0.02915352928838355d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5243215211258435d, b: 0.9766266037936517d, c: 0.883088647221644d),
new NpgsqlTypes.NpgsqlLine(a: 0.8306131578076592d, b: 0.2952876296172361d, c: 0.5077684202951579d),
new NpgsqlTypes.NpgsqlLine(a: 0.5630135222836871d, b: 0.7084431114337933d, c: 0.823767892154315d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1758253005639463d, b: 0.5554512968813833d, c: 0.6647000515389824d),
new NpgsqlTypes.NpgsqlLine(a: 0.7490349766081297d, b: 0.6937805142869066d, c: 0.6091110902364173d),
new NpgsqlTypes.NpgsqlLine(a: 0.41153140947981226d, b: 0.988716150566032d, c: 0.36456220462096334d),
new NpgsqlTypes.NpgsqlLine(a: 0.20106673999641278d, b: 0.8482068372449277d, c: 0.1434333283992295d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6756330483130265d, b: 0.17413273034655397d, c: 0.6291301740192591d),
new NpgsqlTypes.NpgsqlLine(a: 0.4009091337517281d, b: 0.1878854768722148d, c: 0.11754416691345093d),
new NpgsqlTypes.NpgsqlLine(a: 0.7463746196759488d, b: 0.1286946560205381d, c: 0.886164477256334d),
new NpgsqlTypes.NpgsqlLine(a: 0.24112669827568578d, b: 0.8229174428131625d, c: 0.7582579987128304d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5009649408713407d, b: 0.9109225961741678d, c: 0.949337493492029d),
new NpgsqlTypes.NpgsqlLine(a: 0.1454019648615008d, b: 0.7083516690185604d, c: 0.21190903905472347d),
new NpgsqlTypes.NpgsqlLine(a: 0.6621013811741714d, b: 0.2062471914542131d, c: 0.6667881245835707d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9819076186983912d, b: 0.4505200562764845d, c: 0.9238860061281053d),
new NpgsqlTypes.NpgsqlLine(a: 0.5997776916760394d, b: 0.6731744737373532d, c: 0.9805110864444044d),
new NpgsqlTypes.NpgsqlLine(a: 0.37454570169865775d, b: 0.5695742383121815d, c: 0.14645647971183495d),
new NpgsqlTypes.NpgsqlLine(a: 0.430592110672229d, b: 0.1611666655071895d, c: 0.026217417484119432d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08890790679362814d, b: 0.4025853603051265d, c: 0.5148932938948267d),
new NpgsqlTypes.NpgsqlLine(a: 0.12914427715185217d, b: 0.8136037444620808d, c: 0.4419952591637649d),
new NpgsqlTypes.NpgsqlLine(a: 0.3964938308004289d, b: 0.8939777063170662d, c: 0.262272501766604d),
new NpgsqlTypes.NpgsqlLine(a: 0.760728645360967d, b: 0.9711106546293992d, c: 0.9319571642988291d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7317427123636856d, b: 0.7448834242461561d, c: 0.9630111289415048d),
new NpgsqlTypes.NpgsqlLine(a: 0.5196075126354638d, b: 0.38619494946484d, c: 0.8459231782779225d),
new NpgsqlTypes.NpgsqlLine(a: 0.37242831482465655d, b: 0.9427253394331895d, c: 0.6302907349787921d),
new NpgsqlTypes.NpgsqlLine(a: 0.25236718404158376d, b: 0.2046574437088018d, c: 0.9874698060926808d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.935694627031456d, b: 0.5674814395106891d, c: 0.6538843624917701d),
new NpgsqlTypes.NpgsqlLine(a: 0.7685316844369711d, b: 0.4718358841715239d, c: 0.4321598850814087d),
new NpgsqlTypes.NpgsqlLine(a: 0.2368321179640186d, b: 0.30158908600070267d, c: 0.2658713704167568d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7149618610125735d, b: 0.5229824815003327d, c: 0.6369483546718989d),
new NpgsqlTypes.NpgsqlLine(a: 0.6802814968645319d, b: 0.9299355017819066d, c: 0.18091551145331053d),
new NpgsqlTypes.NpgsqlLine(a: 0.17035548415577895d, b: 0.4369185274246654d, c: 0.3954818364823638d),
new NpgsqlTypes.NpgsqlLine(a: 0.49620936216407796d, b: 0.5354141046138756d, c: 0.36204637636503345d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3123485156573734d, b: 0.06174981810319191d, c: 0.19794871018877858d),
new NpgsqlTypes.NpgsqlLine(a: 0.11188387399049371d, b: 0.250076653618866d, c: 0.9419043810402045d),
new NpgsqlTypes.NpgsqlLine(a: 0.048874827082883154d, b: 0.38319454743747905d, c: 0.8520003197219511d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7949995323271435d, b: 0.9870056510041696d, c: 0.6890369359724808d),
new NpgsqlTypes.NpgsqlLine(a: 0.47715358037832645d, b: 0.5303628964760756d, c: 0.3010803583377203d),
new NpgsqlTypes.NpgsqlLine(a: 0.5327704211475839d, b: 0.07572284466281676d, c: 0.18201191884249135d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6436389445902317d, b: 0.1646189643451874d, c: 0.08757791270049953d),
new NpgsqlTypes.NpgsqlLine(a: 0.8967671929532803d, b: 0.01680855115565627d, c: 0.5499093464838822d),
new NpgsqlTypes.NpgsqlLine(a: 0.931848723370106d, b: 0.3034371241508522d, c: 0.6140279979087212d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5277142952925001d, b: 0.06635235297825715d, c: 0.23827137092733974d),
new NpgsqlTypes.NpgsqlLine(a: 0.19313674350865628d, b: 0.38456905124409746d, c: 0.20214751694150812d),
new NpgsqlTypes.NpgsqlLine(a: 0.5783905010871155d, b: 0.1577257366218846d, c: 0.0005929501674163395d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.961318518033104d, b: 0.8206353212378752d, c: 0.22038195983352027d),
new NpgsqlTypes.NpgsqlLine(a: 0.8159801903096133d, b: 0.3563404537112248d, c: 0.4372291964872971d),
new NpgsqlTypes.NpgsqlLine(a: 0.33522449430527557d, b: 0.8086259966679411d, c: 0.4794345471309508d),
new NpgsqlTypes.NpgsqlLine(a: 0.6671162851450065d, b: 0.133418973026727d, c: 0.9354195920720834d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19025667475435493d, b: 0.21427261437736966d, c: 0.9265071597993966d),
new NpgsqlTypes.NpgsqlLine(a: 0.8604864680415711d, b: 0.44017634828358765d, c: 0.007816136601507373d),
new NpgsqlTypes.NpgsqlLine(a: 0.19341873290373202d, b: 0.5209534620420174d, c: 0.8542780257407513d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.684918767226419d, b: 0.9740015566697433d, c: 0.0023552347454259825d),
new NpgsqlTypes.NpgsqlLine(a: 0.6230938939975806d, b: 0.08881291657928359d, c: 0.33851666337270747d),
new NpgsqlTypes.NpgsqlLine(a: 0.4617334361396047d, b: 0.15005319259947247d, c: 0.4933689670394227d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8940289279539374d, b: 0.8812944404485001d, c: 0.944566058978058d),
new NpgsqlTypes.NpgsqlLine(a: 0.5807058032468795d, b: 0.22543403836424236d, c: 0.7741160082369148d),
new NpgsqlTypes.NpgsqlLine(a: 0.2835290119795806d, b: 0.109925382269908d, c: 0.7947600465359372d),
new NpgsqlTypes.NpgsqlLine(a: 0.547120135051189d, b: 0.0673599147630457d, c: 0.9406833174833971d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9381520699845075d, b: 0.3088827973369932d, c: 0.5941088850358767d),
new NpgsqlTypes.NpgsqlLine(a: 0.8769335679954271d, b: 0.7923124158578317d, c: 0.3066789710464839d),
new NpgsqlTypes.NpgsqlLine(a: 0.047586087227013185d, b: 0.49048829664412796d, c: 0.17532428060929595d),
new NpgsqlTypes.NpgsqlLine(a: 0.5309709643884718d, b: 0.41962602739987653d, c: 0.6373824643091801d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3496443590129996d, b: 0.16154758418629933d, c: 0.8407652945556189d),
new NpgsqlTypes.NpgsqlLine(a: 0.5388556197295216d, b: 0.12367709636281898d, c: 0.6450411054793425d),
new NpgsqlTypes.NpgsqlLine(a: 0.8467077855629854d, b: 0.5719292669988855d, c: 0.6600363301368541d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7427522613834008d, b: 0.8077907283472201d, c: 0.7999482676712111d),
new NpgsqlTypes.NpgsqlLine(a: 0.5897107715094411d, b: 0.6811153020368019d, c: 0.2582090052446193d),
new NpgsqlTypes.NpgsqlLine(a: 0.6345717324420339d, b: 0.8668497489018199d, c: 0.832154120739104d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7183106895085811d, b: 0.7822487637274683d, c: 0.42103124312637064d),
new NpgsqlTypes.NpgsqlLine(a: 0.005552290744571753d, b: 0.06372650620698939d, c: 0.836949300481178d),
new NpgsqlTypes.NpgsqlLine(a: 0.9090940574082332d, b: 0.05836784416543317d, c: 0.2534087314726603d),
new NpgsqlTypes.NpgsqlLine(a: 0.17896081548235487d, b: 0.32625424236836875d, c: 0.3278773902679766d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6274274674763131d, b: 0.10149024131921291d, c: 0.5100850534344166d),
new NpgsqlTypes.NpgsqlLine(a: 0.27938627692165774d, b: 0.6498275212876161d, c: 0.3185086296356545d),
new NpgsqlTypes.NpgsqlLine(a: 0.7009494591280385d, b: 0.640598884740306d, c: 0.2688260168228124d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6126586430949862d, b: 0.5487401802793855d, c: 0.47916848510860865d),
new NpgsqlTypes.NpgsqlLine(a: 0.6870279311965775d, b: 0.2753634705509438d, c: 0.2600281947713615d),
new NpgsqlTypes.NpgsqlLine(a: 0.16030328572825736d, b: 0.017767760235490315d, c: 0.8087143253693114d),
new NpgsqlTypes.NpgsqlLine(a: 0.5725948936016115d, b: 0.9009049631184448d, c: 0.27016184755064354d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.37386387229224116d, b: 0.6113187159901874d, c: 0.4040689606539618d),
new NpgsqlTypes.NpgsqlLine(a: 0.3662918257003317d, b: 0.26072124706613453d, c: 0.37950126414683705d),
new NpgsqlTypes.NpgsqlLine(a: 0.7195955603594942d, b: 0.8379041136639466d, c: 0.4012856286090313d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.42201345600192786d, b: 0.5018842863961227d, c: 0.45685864976164536d),
new NpgsqlTypes.NpgsqlLine(a: 0.04872577501402209d, b: 0.896747964471084d, c: 0.9440191708623931d),
new NpgsqlTypes.NpgsqlLine(a: 0.2686516009477532d, b: 0.586292421456323d, c: 0.5207211522444267d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5147204142962795d, b: 0.4368178204049028d, c: 0.0607521761244888d),
new NpgsqlTypes.NpgsqlLine(a: 0.6971418819648071d, b: 0.7884476637504089d, c: 0.5407461926808719d),
new NpgsqlTypes.NpgsqlLine(a: 0.22257005402213403d, b: 0.580683148523053d, c: 0.5109868352991032d),
new NpgsqlTypes.NpgsqlLine(a: 0.8783576186799338d, b: 0.001259782890827621d, c: 0.008065187430183807d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16967369538871502d, b: 0.26808696144350175d, c: 0.5758086593640599d),
new NpgsqlTypes.NpgsqlLine(a: 0.6931439525119969d, b: 0.6870001114878871d, c: 0.37044070568790344d),
new NpgsqlTypes.NpgsqlLine(a: 0.9768420404689893d, b: 0.17464038650454183d, c: 0.2043295005577701d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4582276058212672d, b: 0.734366901039353d, c: 0.2889186318305387d),
new NpgsqlTypes.NpgsqlLine(a: 0.31693964834257027d, b: 0.16485398657419592d, c: 0.10299426883321006d),
new NpgsqlTypes.NpgsqlLine(a: 0.7473722485030643d, b: 0.38834772022815156d, c: 0.472745405742485d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9291787783201949d, b: 0.6874159115840262d, c: 0.9962272485361124d),
new NpgsqlTypes.NpgsqlLine(a: 0.05888489939303887d, b: 0.9858910018030269d, c: 0.6638558047270464d),
new NpgsqlTypes.NpgsqlLine(a: 0.39419156081646944d, b: 0.5007516257635456d, c: 0.805823621907756d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08047901548427439d, b: 0.1200471605857355d, c: 0.3168059668196753d),
new NpgsqlTypes.NpgsqlLine(a: 0.9922344733368527d, b: 0.4915298589638055d, c: 0.4688915388564878d),
new NpgsqlTypes.NpgsqlLine(a: 0.11070194662156385d, b: 0.7850827728493921d, c: 0.41298258774621555d),
new NpgsqlTypes.NpgsqlLine(a: 0.7982993489260372d, b: 0.43140115174709337d, c: 0.9902291518453337d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22244375821071127d, b: 0.06835358849660644d, c: 0.9163078301778773d),
new NpgsqlTypes.NpgsqlLine(a: 0.6435233968267813d, b: 0.9018884872788341d, c: 0.42528274345204276d),
new NpgsqlTypes.NpgsqlLine(a: 0.29962620748944246d, b: 0.8610710330754753d, c: 0.0018971362658311008d),
new NpgsqlTypes.NpgsqlLine(a: 0.9922745716174645d, b: 0.6519367929930227d, c: 0.8693204779208182d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0035408511714032365d, b: 0.27318813918100715d, c: 0.1227306422459814d),
new NpgsqlTypes.NpgsqlLine(a: 0.6530539572183784d, b: 0.8249450863995837d, c: 0.5140471726804133d),
new NpgsqlTypes.NpgsqlLine(a: 0.497290133809825d, b: 0.9676084359322762d, c: 0.7089372611569151d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8056864937562258d, b: 0.5868516045858994d, c: 0.5557750956417736d),
new NpgsqlTypes.NpgsqlLine(a: 0.9410560819267269d, b: 0.8954240342516103d, c: 0.9046926218160002d),
new NpgsqlTypes.NpgsqlLine(a: 0.7797932005212644d, b: 0.11704552232590859d, c: 0.7703792105064959d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9546228872195976d, b: 0.8593507025370264d, c: 0.28074918102097335d),
new NpgsqlTypes.NpgsqlLine(a: 0.5257749990425139d, b: 0.278823065075131d, c: 0.7929517982193781d),
new NpgsqlTypes.NpgsqlLine(a: 0.4718366776563979d, b: 0.5444793068063106d, c: 0.7985055871004563d),
new NpgsqlTypes.NpgsqlLine(a: 0.14865088511266977d, b: 0.7397528394528387d, c: 0.5667455299268592d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25646599902520484d, b: 0.06038704445914056d, c: 0.8806853182174673d),
new NpgsqlTypes.NpgsqlLine(a: 0.0361334532251435d, b: 0.6895460401933592d, c: 0.14373569265268182d),
new NpgsqlTypes.NpgsqlLine(a: 0.5155123606914653d, b: 0.5345792187726054d, c: 0.6361082181498176d),
new NpgsqlTypes.NpgsqlLine(a: 0.9892616401095972d, b: 0.693409163558472d, c: 0.6201793299639423d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2520224547928671d, b: 0.12260796224774817d, c: 0.5085369840570602d),
new NpgsqlTypes.NpgsqlLine(a: 0.8810443444150506d, b: 0.643179958200749d, c: 0.40612246953152675d),
new NpgsqlTypes.NpgsqlLine(a: 0.3641878060952479d, b: 0.32162276168473947d, c: 0.2444507275212202d),
new NpgsqlTypes.NpgsqlLine(a: 0.1487434125660797d, b: 0.797871203681932d, c: 0.5192985259682972d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3033540661741403d, b: 0.7718869509147931d, c: 0.34839565985589993d),
new NpgsqlTypes.NpgsqlLine(a: 0.09841194242607654d, b: 0.1073788996764582d, c: 0.6383013105052955d),
new NpgsqlTypes.NpgsqlLine(a: 0.4329359575223378d, b: 0.29287372231331177d, c: 0.36265246897620773d),
new NpgsqlTypes.NpgsqlLine(a: 0.17752382098199393d, b: 0.36008475969301024d, c: 0.4665582871195093d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.11872799166568271d, b: 0.07985328652686774d, c: 0.63633038620751d),
new NpgsqlTypes.NpgsqlLine(a: 0.2913476781515506d, b: 0.03634898261233377d, c: 0.937585351474785d),
new NpgsqlTypes.NpgsqlLine(a: 0.8726375300864816d, b: 0.9239411571351142d, c: 0.936489374739922d),
new NpgsqlTypes.NpgsqlLine(a: 0.49013805599801763d, b: 0.06022233989776793d, c: 0.5694280254956207d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4514606151193531d, b: 0.045508277525059704d, c: 0.6505908750335271d),
new NpgsqlTypes.NpgsqlLine(a: 0.9291780685563419d, b: 0.8219479844737502d, c: 0.26246707991865825d),
new NpgsqlTypes.NpgsqlLine(a: 0.6991740357506216d, b: 0.7127814036317516d, c: 0.6826621270518466d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9202157199471311d, b: 0.3453868945336478d, c: 0.013313189327983421d),
new NpgsqlTypes.NpgsqlLine(a: 0.14155868361235813d, b: 0.25284907042773896d, c: 0.4589435120577724d),
new NpgsqlTypes.NpgsqlLine(a: 0.2520828315689281d, b: 0.17823490219500304d, c: 0.6211701665358883d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.34236249964756693d, b: 0.005364316159282789d, c: 0.4672085646745623d),
new NpgsqlTypes.NpgsqlLine(a: 0.48140072789782085d, b: 0.09581669011846017d, c: 0.8836614383396127d),
new NpgsqlTypes.NpgsqlLine(a: 0.15838146465128733d, b: 0.3731157954034702d, c: 0.8262497999272559d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8833097665961915d, b: 0.1221859158953198d, c: 0.4916118842165169d),
new NpgsqlTypes.NpgsqlLine(a: 0.32452337981721435d, b: 0.8124841018231915d, c: 0.7388358141663466d),
new NpgsqlTypes.NpgsqlLine(a: 0.7834995868181115d, b: 0.8623243594002097d, c: 0.4776200265996273d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 181,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3909617842559764d, b: 0.6384201790345032d, c: 0.9984864146422667d),
new NpgsqlTypes.NpgsqlLine(a: 0.06650965205586312d, b: 0.8588231831977268d, c: 0.9897210833096914d),
new NpgsqlTypes.NpgsqlLine(a: 0.688969342985185d, b: 0.03017536472079918d, c: 0.6216510325435277d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4802000321736436d, b: 0.5508456208114242d, c: 0.7374432851582735d),
new NpgsqlTypes.NpgsqlLine(a: 0.4106841487694305d, b: 0.7884825481499003d, c: 0.2626689154107188d),
new NpgsqlTypes.NpgsqlLine(a: 0.5200257455019324d, b: 0.870909670099617d, c: 0.8813871050466099d),
new NpgsqlTypes.NpgsqlLine(a: 0.8880070470748912d, b: 0.7680709079800127d, c: 0.09765961604344886d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 188,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.847957567354069d, b: 0.5262777483830224d, c: 0.7009856243850693d),
new NpgsqlTypes.NpgsqlLine(a: 0.7496658806632782d, b: 0.7788680085735539d, c: 0.20755050465588332d),
new NpgsqlTypes.NpgsqlLine(a: 0.4842247568001441d, b: 0.05402245210345402d, c: 0.5432629270824031d),
new NpgsqlTypes.NpgsqlLine(a: 0.02800230450977359d, b: 0.24979680185828346d, c: 0.44001315293546983d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2419359386635419d, b: 0.7021657491733216d, c: 0.2587366432654017d),
new NpgsqlTypes.NpgsqlLine(a: 0.2209935247449326d, b: 0.9959722019311353d, c: 0.9945911511134895d),
new NpgsqlTypes.NpgsqlLine(a: 0.6371091976157913d, b: 0.47837617353461626d, c: 0.43167531351319277d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd1e1mi_id
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
    npgsqllinelinemmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5989313384592695d, b: 0.6379975491560839d, c: 0.6745482382184139d),
new NpgsqlTypes.NpgsqlLine(a: 0.7244756070057885d, b: 0.30036073264936636d, c: 0.5728034714933529d),
new NpgsqlTypes.NpgsqlLine(a: 0.3483325346081906d, b: 0.6819309082170878d, c: 0.16180277640948504d),
new NpgsqlTypes.NpgsqlLine(a: 0.39612098929084394d, b: 0.458273425395314d, c: 0.732276961353342d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43669556360578177d, b: 0.8638029231673768d, c: 0.12905393482593575d),
new NpgsqlTypes.NpgsqlLine(a: 0.46368463158621664d, b: 0.7013299832772191d, c: 0.0521005581959586d),
new NpgsqlTypes.NpgsqlLine(a: 0.10730111729103964d, b: 0.1100250622958876d, c: 0.05143713892857227d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd1e1mi_id
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
    npgsqllinelinemmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd1e1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable =  ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable = await ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49805992717070324d, b: 0.23937241973980072d, c: 0.758690830427353d),
new NpgsqlTypes.NpgsqlLine(a: 0.47361451090225637d, b: 0.9763142827138666d, c: 0.9058475507368411d),
new NpgsqlTypes.NpgsqlLine(a: 0.6529479189485505d, b: 0.5256558031408604d, c: 0.7358787859896165d),
new NpgsqlTypes.NpgsqlLine(a: 0.36164354525633946d, b: 0.5292312516869598d, c: 0.18836446393616835d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD1E1M> models = null;

                models =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD1E1M> models = null;

                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M), typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M), typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M), typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M), typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 117, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 45, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 95, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 31, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 112, query1, 139, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 76, query1, 160, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 34, query1, 15, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 60, query1, 169, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 15, 169))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 153, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineMArraylineMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineMArraylineMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineMArraylineMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineMArraylineMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 64);
                var models =  ((INpgsqlLineMArraylineMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.binary_npgsqllinelinemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinemmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
FROM public.binary_npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.binary_npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinemmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineMArraylineMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA), typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
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
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
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
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA), typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
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
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
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
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MI), typeof(NpgsqlLinelineMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MI>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MI>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA), typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

