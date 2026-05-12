

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
    internal partial interface INpgsqlBoxMArrayboxMMArrayD2
    {
    }
    
    internal partial class NpgsqlBoxMArrayboxMMArrayD2 : INpgsqlBoxMArrayboxMMArrayD2
    {


#region TestData

        private readonly NpgsqlBoxboxMMArrayD2E1M[] _testData = new NpgsqlBoxboxMMArrayD2E1M[]
        {
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5552475458905239d,right: 0.5984919945889414d,bottom: 0.34298965351937505d,left: 0.25738582896368434d), new NpgsqlTypes.NpgsqlBox(top: 0.8994215552329885d,right: 0.7561772678609198d,bottom: 0.8955322271097687d,left: 0.15895919024015348d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7944379515049469d,right: 0.5229456559716342d,bottom: 0.5296628924758967d,left: 0.4557016386316324d), new NpgsqlTypes.NpgsqlBox(top: 0.8274563030617533d,right: 0.5710321168702414d,bottom: 0.20972745755880462d,left: 0.023671155647502218d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5772943061710458d,right: 0.7776391008599448d,bottom: 0.14761380513482492d,left: 0.7292291941318169d), new NpgsqlTypes.NpgsqlBox(top: 0.9477662070657407d,right: 0.9664834623379933d,bottom: 0.7400667982513254d,left: 0.5321336917430247d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8046323832147989d,right: 0.7567096606454742d,bottom: 0.381732629587202d,left: 0.48523643589438126d), new NpgsqlTypes.NpgsqlBox(top: 0.6437272935149383d,right: 0.26892373352062304d,bottom: 0.5453200163096787d,left: 0.16732176192802872d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.40088155009314097d,right: 0.8868078324062524d,bottom: 0.22549447314977578d,left: 0.7087047752288774d), new NpgsqlTypes.NpgsqlBox(top: 0.9026939890834189d,right: 0.3946705994524533d,bottom: 0.583228127839529d,left: 0.14388725710660089d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7981941959093964d,right: 0.49481628426633273d,bottom: 0.7641179172419563d,left: 0.4897322568602118d), new NpgsqlTypes.NpgsqlBox(top: 0.7711759634226134d,right: 0.7101128308084663d,bottom: 0.6129349105646598d,left: 0.35659860843566804d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.29831699346280527d,right: 0.8003074790894055d,bottom: 0.13281830520521287d,left: 0.6920881967277114d), new NpgsqlTypes.NpgsqlBox(top: 0.5994891081899861d,right: 0.5741186309775138d,bottom: 0.5822105879402679d,left: 0.5252536201384181d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8103414512491889d,right: 0.44125386478036943d,bottom: 0.4592900927569207d,left: 0.10817570220092032d), new NpgsqlTypes.NpgsqlBox(top: 0.624063984950389d,right: 0.5376744690599956d,bottom: 0.3307231966946559d,left: 0.30371641771886904d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3137397237324486d,right: 0.3228607722944141d,bottom: 0.3026533478179424d,left: 0.05723055098774976d), new NpgsqlTypes.NpgsqlBox(top: 0.5854552153486765d,right: 0.5232557516420027d,bottom: 0.26901817960206964d,left: 0.19514479969242704d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.511135380833746d,right: 0.956556279856433d,bottom: 0.1619940700004262d,left: 0.6293202597749523d), new NpgsqlTypes.NpgsqlBox(top: 0.7457700650995247d,right: 0.9575114241434463d,bottom: 0.3312610751469114d,left: 0.5430994361577014d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7152089052406096d,right: 0.68766361855526d,bottom: 0.4265241979723341d,left: 0.19863900434378345d), new NpgsqlTypes.NpgsqlBox(top: 0.9514204715046147d,right: 0.8727107216272512d,bottom: 0.3560108567794191d,left: 0.5886709762676797d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.30570640376979263d,right: 0.5906124318113294d,bottom: 0.13297581199219244d,left: 0.4827214693003493d), new NpgsqlTypes.NpgsqlBox(top: 0.8361163566320934d,right: 0.8980085533624481d,bottom: 0.087612819760854d,left: 0.3573589669713001d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8967787781900517d,right: 0.07697860471478091d,bottom: 0.12367056464441406d,left: 0.043579198982181655d), new NpgsqlTypes.NpgsqlBox(top: 0.9662779179350778d,right: 0.861808919217236d,bottom: 0.8877716697298991d,left: 0.6565220847875439d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5797586834362446d,right: 0.970639436774119d,bottom: 0.34347301918720996d,left: 0.9495610350101028d), new NpgsqlTypes.NpgsqlBox(top: 0.3437440783413288d,right: 0.9780706430733465d,bottom: 0.1411268148535787d,left: 0.786379989869004d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6899042578925593d,right: 0.46301282209243133d,bottom: 0.13890411266594538d,left: 0.434964766097226d), new NpgsqlTypes.NpgsqlBox(top: 0.7189599702898536d,right: 0.8838116352265509d,bottom: 0.6108641796659977d,left: 0.1413644175279224d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9493126847700448d,right: 0.3561198185754372d,bottom: 0.7387415679709154d,left: 0.3014454937735339d), new NpgsqlTypes.NpgsqlBox(top: 0.330901851085016d,right: 0.7231236582410064d,bottom: 0.02952685938208488d,left: 0.5717458716362501d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5265170850734088d,right: 0.4800293052463389d,bottom: 0.41625928270663104d,left: 0.3050400276244445d), new NpgsqlTypes.NpgsqlBox(top: 0.5424168294927336d,right: 0.875981394958453d,bottom: 0.49258536998701774d,left: 0.28019928861936894d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9283467158172604d,right: 0.25502976313182324d,bottom: 0.8056141298006669d,left: 0.1947149233905665d), new NpgsqlTypes.NpgsqlBox(top: 0.5677950311120592d,right: 0.5550574195555045d,bottom: 0.3617889445701441d,left: 0.38164134754618684d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5964057941495653d,right: 0.7091524630194125d,bottom: 0.14982606571679924d,left: 0.33871282618406273d), new NpgsqlTypes.NpgsqlBox(top: 0.9346798792922826d,right: 0.45198912272719294d,bottom: 0.28220630842803707d,left: 0.1344693953990046d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8331148261177898d,right: 0.8372463568716617d,bottom: 0.21907329010399113d,left: 0.5664366987934276d), new NpgsqlTypes.NpgsqlBox(top: 0.9585936256273954d,right: 0.42462140456067643d,bottom: 0.9414406548728493d,left: 0.000874661346785266d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.2378983359336394d,right: 0.7085719773902789d,bottom: 0.016460400683336873d,left: 0.4791206348187935d), new NpgsqlTypes.NpgsqlBox(top: 0.8845021767859559d,right: 0.9188759497793414d,bottom: 0.8535807097919665d,left: 0.14707427816808893d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9492369647531176d,right: 0.4031049419305608d,bottom: 0.07386522066431611d,left: 0.3355586628142293d), new NpgsqlTypes.NpgsqlBox(top: 0.5952004823414935d,right: 0.9476055560311573d,bottom: 0.4070892783847154d,left: 0.6153920023821599d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8128104726555498d,right: 0.9809537916242047d,bottom: 0.7042855520939058d,left: 0.7127021100517857d), new NpgsqlTypes.NpgsqlBox(top: 0.866352879972507d,right: 0.6321632147427524d,bottom: 0.7969481684425146d,left: 0.34516596175838943d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.30760287843370804d,right: 0.7191919556188568d,bottom: 0.12056644474806621d,left: 0.5085017320321511d), new NpgsqlTypes.NpgsqlBox(top: 0.9891348184828046d,right: 0.29991086792383126d,bottom: 0.8501147655696428d,left: 0.2519738720847583d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5811437790039216d,right: 0.47825726731112983d,bottom: 0.05413777379780538d,left: 0.38148491259293604d), new NpgsqlTypes.NpgsqlBox(top: 0.915317795249926d,right: 0.7956084040223611d,bottom: 0.23208859432287854d,left: 0.5155984484325644d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.796074308319506d,right: 0.6600609005705763d,bottom: 0.08150444058650075d,left: 0.16890995830082467d), new NpgsqlTypes.NpgsqlBox(top: 0.9878988855749531d,right: 0.6521123991197277d,bottom: 0.7825708054418153d,left: 0.2570719906525343d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.602283794533471d,right: 0.7478147769059366d,bottom: 0.421338344980274d,left: 0.5703964996873171d), new NpgsqlTypes.NpgsqlBox(top: 0.36700548499715835d,right: 0.36497872201827364d,bottom: 0.0014447929458112352d,left: 0.05658874584226692d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7891089623915866d,right: 0.9350146920062867d,bottom: 0.3462354574933376d,left: 0.16120583601645433d), new NpgsqlTypes.NpgsqlBox(top: 0.4840539510176426d,right: 0.882037845929774d,bottom: 0.10004910584705495d,left: 0.6909242913760094d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9620191823423873d,right: 0.8846120414884886d,bottom: 0.5047940637065181d,left: 0.6897455200951149d), new NpgsqlTypes.NpgsqlBox(top: 0.9363495555917332d,right: 0.20938300246681973d,bottom: 0.025615680509348593d,left: 0.0715135942459012d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6986330554228278d,right: 0.3740792521211319d,bottom: 0.15644552617224494d,left: 0.20138925298489152d), new NpgsqlTypes.NpgsqlBox(top: 0.510598317830035d,right: 0.843345378257883d,bottom: 0.052109398579764044d,left: 0.14578184756285184d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7807659372684843d,right: 0.5584474600484715d,bottom: 0.46189948931599456d,left: 0.5042994220174412d), new NpgsqlTypes.NpgsqlBox(top: 0.8437551837399218d,right: 0.5971249852845375d,bottom: 0.19335181525159595d,left: 0.4459178666772363d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8737881420834296d,right: 0.14632562175694808d,bottom: 0.38634633100917315d,left: 0.10042492518802848d), new NpgsqlTypes.NpgsqlBox(top: 0.19570577389473143d,right: 0.4003585314106731d,bottom: 0.10243324432310075d,left: 0.12730931545236657d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8936275672230586d,right: 0.670362883513878d,bottom: 0.32364513757492774d,left: 0.29640346472943124d), new NpgsqlTypes.NpgsqlBox(top: 0.8504624027309494d,right: 0.670275074950263d,bottom: 0.04529465181621917d,left: 0.3416114665749159d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5322906584310269d,right: 0.9174616909675519d,bottom: 0.18815107687062027d,left: 0.25326040023633223d), new NpgsqlTypes.NpgsqlBox(top: 0.9574433743937503d,right: 0.9335135756910322d,bottom: 0.6768095313818733d,left: 0.07485666112387057d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.40062680699458675d,right: 0.20708681155948516d,bottom: 0.16931198351279386d,left: 0.08180666982632667d), new NpgsqlTypes.NpgsqlBox(top: 0.9348148536123448d,right: 0.6971825479767573d,bottom: 0.3542798855225566d,left: 0.5876713303546852d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7040257348095172d,right: 0.8947162767163028d,bottom: 0.01619837014935921d,left: 0.06777539459995952d), new NpgsqlTypes.NpgsqlBox(top: 0.9074519741486082d,right: 0.30552288343860123d,bottom: 0.6130359880952639d,left: 0.19203509745023806d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.39873918514830575d,right: 0.7613949955927398d,bottom: 0.05062180716872011d,left: 0.6455989296902418d), new NpgsqlTypes.NpgsqlBox(top: 0.9433348557232594d,right: 0.7565064607968407d,bottom: 0.13500342905052687d,left: 0.110119167829412d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6654100285590834d,right: 0.6545725516213757d,bottom: 0.5387010624295149d,left: 0.3137911634436502d), new NpgsqlTypes.NpgsqlBox(top: 0.6082890614840564d,right: 0.5565066572854588d,bottom: 0.4000603491189232d,left: 0.03142812424114305d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9853559740157422d,right: 0.3451861588386951d,bottom: 0.5031538824139192d,left: 0.2502765347495991d), new NpgsqlTypes.NpgsqlBox(top: 0.9627544519290744d,right: 0.4463970510554327d,bottom: 0.1846292108712848d,left: 0.4012274388732727d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6683680277592944d,right: 0.9610040180796559d,bottom: 0.4566471149304553d,left: 0.8548737740942818d), new NpgsqlTypes.NpgsqlBox(top: 0.9013527303772401d,right: 0.3299483478119105d,bottom: 0.06471394562707855d,left: 0.1508850992418267d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5172405627370156d,right: 0.7312564344452777d,bottom: 0.08646986109175825d,left: 0.3881662622963452d), new NpgsqlTypes.NpgsqlBox(top: 0.6127514801026109d,right: 0.6595224762435924d,bottom: 0.4873472519017691d,left: 0.061391193156579704d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5519761650128816d,right: 0.952808153700791d,bottom: 0.43957329000715806d,left: 0.8023812649405054d), new NpgsqlTypes.NpgsqlBox(top: 0.7550952321528175d,right: 0.9450926621973422d,bottom: 0.44952173888932945d,left: 0.597647661866573d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5802900362366059d,right: 0.36672150110157054d,bottom: 0.20573254878132585d,left: 0.33873285988583346d), new NpgsqlTypes.NpgsqlBox(top: 0.5203410149529852d,right: 0.653411058495643d,bottom: 0.44625038063062183d,left: 0.3477849628931653d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5805312076788937d,right: 0.23769758379028538d,bottom: 0.503541077947702d,left: 0.005836369853958745d), new NpgsqlTypes.NpgsqlBox(top: 0.8426958895513592d,right: 0.4844406077030089d,bottom: 0.07959480511267925d,left: 0.42657450054000545d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9132502773677671d,right: 0.7023745516954645d,bottom: 0.7866511087593785d,left: 0.6465464229810384d), new NpgsqlTypes.NpgsqlBox(top: 0.5829636509154702d,right: 0.5912047008289874d,bottom: 0.23879409971545829d,left: 0.27022403938526784d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9055813938281381d,right: 0.25478448288449074d,bottom: 0.8399225867595151d,left: 0.18645365118217427d), new NpgsqlTypes.NpgsqlBox(top: 0.7219369406946943d,right: 0.8256996341107591d,bottom: 0.6487779650351829d,left: 0.6983394051842567d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9041562326242324d,right: 0.9113812067700504d,bottom: 0.43320539780606093d,left: 0.03289815662325879d), new NpgsqlTypes.NpgsqlBox(top: 0.781747432665758d,right: 0.5834243953340238d,bottom: 0.12533237821367593d,left: 0.02014371808378279d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.898970516722852d,right: 0.34716305623417965d,bottom: 0.5805845147440526d,left: 0.19869826697167337d), new NpgsqlTypes.NpgsqlBox(top: 0.3077353972598085d,right: 0.5066424665917222d,bottom: 0.21657584720226908d,left: 0.4387496491042352d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.39644235247878035d,right: 0.6783311880402052d,bottom: 0.12722095819251678d,left: 0.08426082645624866d), new NpgsqlTypes.NpgsqlBox(top: 0.6264361670205879d,right: 0.3042446661116488d,bottom: 0.4629871650918951d,left: 0.05398381155394727d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6439957373352015d,right: 0.4816503525926886d,bottom: 0.33758713262823004d,left: 0.20533433497535913d), new NpgsqlTypes.NpgsqlBox(top: 0.14150958200597152d,right: 0.7409710719434003d,bottom: 0.1162613228661249d,left: 0.21678386235110736d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5422860994396672d,right: 0.9980467441479607d,bottom: 0.08017711911694925d,left: 0.8992565665052104d), new NpgsqlTypes.NpgsqlBox(top: 0.5471757015542871d,right: 0.8574226903369028d,bottom: 0.13429959466671026d,left: 0.43118115615761177d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8469217461336039d,right: 0.9800263459518184d,bottom: 0.7919677217334378d,left: 0.9643629123471981d), new NpgsqlTypes.NpgsqlBox(top: 0.599071451915598d,right: 0.5942082280384735d,bottom: 0.22412799584489895d,left: 0.3486587262438705d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4094209617748168d,right: 0.6525374140307655d,bottom: 0.2259138475024396d,left: 0.360598645589046d), new NpgsqlTypes.NpgsqlBox(top: 0.912600885007326d,right: 0.08222131193833393d,bottom: 0.8489348634867862d,left: 0.0430501033303099d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.997936244595615d,right: 0.9603133701020772d,bottom: 0.7517091492152468d,left: 0.1530139951201107d), new NpgsqlTypes.NpgsqlBox(top: 0.9574619824955598d,right: 0.9094796847142652d,bottom: 0.10715288173321913d,left: 0.3319772390719785d), }, },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4419579192254198d,right: 0.7705913871622405d,bottom: 0.21475765769534616d,left: 0.6955694367360823d), new NpgsqlTypes.NpgsqlBox(top: 0.8892779551093977d,right: 0.2882146876302685d,bottom: 0.7654701186764753d,left: 0.11218120570293322d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9756265759335936d,right: 0.9252744597653627d,bottom: 0.24518886353858915d,left: 0.41864036366027124d), new NpgsqlTypes.NpgsqlBox(top: 0.8465186354369678d,right: 0.9087290225958682d,bottom: 0.10008527276706103d,left: 0.6598534973220204d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9868309785422258d,right: 0.7076964423463391d,bottom: 0.4302426011625805d,left: 0.6509769954870264d), new NpgsqlTypes.NpgsqlBox(top: 0.8442959528098829d,right: 0.740934317043858d,bottom: 0.5785610366356194d,left: 0.5553678949387085d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7757486033827928d,right: 0.5342957153207941d,bottom: 0.6293428841357072d,left: 0.5281085274161373d), new NpgsqlTypes.NpgsqlBox(top: 0.8433094796278374d,right: 0.8710012344127875d,bottom: 0.5936927368361429d,left: 0.19176154312197002d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7770674049706731d,right: 0.710146705826922d,bottom: 0.5929572051829716d,left: 0.6160571171358303d), new NpgsqlTypes.NpgsqlBox(top: 0.291860215592047d,right: 0.3521558731911927d,bottom: 0.2508742782942519d,left: 0.12370165051783599d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.3478385167617568d,right: 0.6394379169754172d,bottom: 0.32058605972608056d,left: 0.5561670480370168d), new NpgsqlTypes.NpgsqlBox(top: 0.9637127428890376d,right: 0.8909577716059791d,bottom: 0.8186670762270266d,left: 0.4573044248951098d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4104798899138179d,right: 0.7289950628255031d,bottom: 0.20778830564183337d,left: 0.27615455244665943d), new NpgsqlTypes.NpgsqlBox(top: 0.9502940693293457d,right: 0.41524091542260066d,bottom: 0.13254566412669178d,left: 0.061959788240579794d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9532956263294141d,right: 0.13467177382949524d,bottom: 0.13197197236587355d,left: 0.11029391351790097d), new NpgsqlTypes.NpgsqlBox(top: 0.9046569204320523d,right: 0.6554732956682278d,bottom: 0.8785319223874856d,left: 0.2820887089884556d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9030578453967133d,right: 0.9351603519528787d,bottom: 0.3632292209641085d,left: 0.6875432384381958d), new NpgsqlTypes.NpgsqlBox(top: 0.6808392600783675d,right: 0.27773289772561927d,bottom: 0.007532378329527689d,left: 0.2480424747358576d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7364671433955953d,right: 0.8690366572508181d,bottom: 0.6618873005202776d,left: 0.6338937259904597d), new NpgsqlTypes.NpgsqlBox(top: 0.7501087269583755d,right: 0.8643374410490088d,bottom: 0.35710309061179557d,left: 0.6859527893581835d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6082416053145973d,right: 0.4433318837113671d,bottom: 0.4033632602750076d,left: 0.06216864609075268d), new NpgsqlTypes.NpgsqlBox(top: 0.6043818008006542d,right: 0.7262505642016731d,bottom: 0.479458071212581d,left: 0.3087828444381565d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4493023038396725d,right: 0.1292073570649116d,bottom: 0.09927231841077d,left: 0.0907483136333902d), new NpgsqlTypes.NpgsqlBox(top: 0.7796754873323657d,right: 0.800304719703573d,bottom: 0.5887294195964683d,left: 0.2979021902074095d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4498859502505348d,right: 0.910411531569595d,bottom: 0.10703779579080874d,left: 0.2267865346604142d), new NpgsqlTypes.NpgsqlBox(top: 0.8408802291856565d,right: 0.8139910854719037d,bottom: 0.39464545270478835d,left: 0.09766560795146262d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.781751291952073d,right: 0.2684726661636708d,bottom: 0.5292606237552526d,left: 0.11991893900982276d), new NpgsqlTypes.NpgsqlBox(top: 0.8543001312934372d,right: 0.6303962483063834d,bottom: 0.2566236510856085d,left: 0.5018966027026615d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9046498996648358d,right: 0.20263391152785704d,bottom: 0.8864433826348157d,left: 0.07583479125107673d), new NpgsqlTypes.NpgsqlBox(top: 0.10591585866717201d,right: 0.17520916265623065d,bottom: 0.06325592440663541d,left: 0.029255592616632575d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5083166178320636d,right: 0.9937244846741587d,bottom: 0.22950977230173164d,left: 0.6391063366396166d), new NpgsqlTypes.NpgsqlBox(top: 0.9737612180094242d,right: 0.9925213706994124d,bottom: 0.43367240441099586d,left: 0.5165279583061131d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9671738412188543d,right: 0.6899519382682818d,bottom: 0.6122349694807225d,left: 0.28881696326603523d), new NpgsqlTypes.NpgsqlBox(top: 0.6365875538121768d,right: 0.9395227800722703d,bottom: 0.2506375100509586d,left: 0.5818649687702092d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.28815629279285004d,right: 0.3286991338455021d,bottom: 0.002348592087667356d,left: 0.255277107174242d), new NpgsqlTypes.NpgsqlBox(top: 0.8426714320449866d,right: 0.983527255206466d,bottom: 0.45691786474755736d,left: 0.0059612858966680005d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8580276798597767d,right: 0.6522755843211827d,bottom: 0.7658867287830048d,left: 0.002536547300973191d), new NpgsqlTypes.NpgsqlBox(top: 0.5823365424011784d,right: 0.8366092978137134d,bottom: 0.51156656093472d,left: 0.6047217771823689d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4285765623201446d,right: 0.9595749237528087d,bottom: 0.08091343858469935d,left: 0.7234080450577686d), new NpgsqlTypes.NpgsqlBox(top: 0.7243171526155597d,right: 0.8409391251041778d,bottom: 0.5494013941962755d,left: 0.7668809207734525d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.44311977674420844d,right: 0.6634815946077599d,bottom: 0.40830892753744763d,left: 0.4516362255856493d), new NpgsqlTypes.NpgsqlBox(top: 0.7631507996917593d,right: 0.7381612012223808d,bottom: 0.42798582133767493d,left: 0.3860540876837153d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6587736777101648d,right: 0.8813264792502264d,bottom: 0.13045759173729077d,left: 0.18980776765184026d), new NpgsqlTypes.NpgsqlBox(top: 0.33395145253085445d,right: 0.9387355094680129d,bottom: 0.19798542844030798d,left: 0.8603037932970603d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6675972730850922d,right: 0.9905051369539293d,bottom: 0.2396635846494921d,left: 0.36745503798246937d), new NpgsqlTypes.NpgsqlBox(top: 0.7900328402166849d,right: 0.81819212119219d,bottom: 0.13103761754763588d,left: 0.5251395084261998d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6314276539377407d,right: 0.9643966051205046d,bottom: 0.31059930357736043d,left: 0.9263808527440484d), new NpgsqlTypes.NpgsqlBox(top: 0.7492808306229343d,right: 0.9183285961919362d,bottom: 0.22531892385280805d,left: 0.8448118641570308d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7509135187905459d,right: 0.1379383138694209d,bottom: 0.40018628926058075d,left: 0.040105615919236226d), new NpgsqlTypes.NpgsqlBox(top: 0.2001430246667093d,right: 0.7978591499866329d,bottom: 0.03164523176810752d,left: 0.470378596143171d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.3667775733088333d,right: 0.24703572135648033d,bottom: 0.057425647434751315d,left: 0.17921861897359248d), new NpgsqlTypes.NpgsqlBox(top: 0.6158059985446438d,right: 0.941921433221718d,bottom: 0.09885039304643095d,left: 0.3136685603780207d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5140845784754263d,right: 0.5679456937435842d,bottom: 0.2983243505462515d,left: 0.1758579680469169d), new NpgsqlTypes.NpgsqlBox(top: 0.7491558620575187d,right: 0.8844563180930304d,bottom: 0.3648206075651419d,left: 0.3718700155562632d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5048700583464305d,right: 0.2824941536612696d,bottom: 0.486476092710051d,left: 0.18333058977385308d), new NpgsqlTypes.NpgsqlBox(top: 0.4647578852096069d,right: 0.640581977958814d,bottom: 0.2499532871435759d,left: 0.20670422111560105d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.26529225308137894d,right: 0.7961244873936673d,bottom: 0.1729287441318924d,left: 0.2532549980756015d), new NpgsqlTypes.NpgsqlBox(top: 0.754051561596276d,right: 0.9702397188223559d,bottom: 0.5083221108657935d,left: 0.5226526352412366d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.44929774442857995d,right: 0.961980415444581d,bottom: 0.3751939894648014d,left: 0.6785788929346793d), new NpgsqlTypes.NpgsqlBox(top: 0.3853079126058315d,right: 0.9445100652500745d,bottom: 0.1544907627909029d,left: 0.9418905664413368d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6980898201176421d,right: 0.5990646572836441d,bottom: 0.05530332270434912d,left: 0.41696076486212696d), new NpgsqlTypes.NpgsqlBox(top: 0.4883671738722464d,right: 0.5066255964020466d,bottom: 0.23528130592882657d,left: 0.2034480982250617d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5613390057810653d,right: 0.42025489211241496d,bottom: 0.25688362771653195d,left: 0.19329892328196996d), new NpgsqlTypes.NpgsqlBox(top: 0.7951743298122155d,right: 0.7693041077664883d,bottom: 0.7682613085497189d,left: 0.2782019113159858d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3906139385869982d,right: 0.5261981906388735d,bottom: 0.3687026962154404d,left: 0.47274235399245024d), new NpgsqlTypes.NpgsqlBox(top: 0.7927073342028346d,right: 0.831045297152948d,bottom: 0.5808533326215495d,left: 0.04696202423288576d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5046212771847444d,right: 0.8489251550877218d,bottom: 0.07384091751825295d,left: 0.7134124906677398d), new NpgsqlTypes.NpgsqlBox(top: 0.5137383647420805d,right: 0.15287850125543345d,bottom: 0.46505252764992555d,left: 0.03077935884548022d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.938768075868748d,right: 0.23977620517259846d,bottom: 0.5979565076985653d,left: 0.2356557468414523d), new NpgsqlTypes.NpgsqlBox(top: 0.3147401505055073d,right: 0.7771176573895712d,bottom: 0.2155631870679513d,left: 0.43897537469429193d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9808147206929312d,right: 0.7884621426288573d,bottom: 0.8406553950728045d,left: 0.422418896676358d), new NpgsqlTypes.NpgsqlBox(top: 0.7223805415725877d,right: 0.8707678538131765d,bottom: 0.2634160944313976d,left: 0.8476807709301809d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9469230303475809d,right: 0.7452733552792896d,bottom: 0.21285278430867582d,left: 0.1318573410813656d), new NpgsqlTypes.NpgsqlBox(top: 0.2148430917890224d,right: 0.2124359073986175d,bottom: 0.2118434921737129d,left: 0.18696301089112366d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5320948965901563d,right: 0.8711291271983793d,bottom: 0.034778489464273754d,left: 0.6899368955141104d), new NpgsqlTypes.NpgsqlBox(top: 0.9070504399991118d,right: 0.6983612030274279d,bottom: 0.30291497002101897d,left: 0.18801071913861012d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5812671439431417d,right: 0.6768388351804218d,bottom: 0.1215108314114165d,left: 0.2052729401455612d), new NpgsqlTypes.NpgsqlBox(top: 0.9217402690107567d,right: 0.8119461157348484d,bottom: 0.8521216021478463d,left: 0.4069477237806062d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.39278999395548786d,right: 0.6146954173548328d,bottom: 0.3356738576732935d,left: 0.4276619623111617d), new NpgsqlTypes.NpgsqlBox(top: 0.8632620425491533d,right: 0.6669642333524141d,bottom: 0.5977651982256508d,left: 0.609535760922891d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5527246681757191d,right: 0.203131786254777d,bottom: 0.3286920172548675d,left: 0.09579738355463419d), new NpgsqlTypes.NpgsqlBox(top: 0.9669138263691515d,right: 0.5655802921508845d,bottom: 0.3916412971512371d,left: 0.35946021632724734d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8067007155450799d,right: 0.8612609182510288d,bottom: 0.43572290820760873d,left: 0.5586112158067682d), new NpgsqlTypes.NpgsqlBox(top: 0.5362352305446617d,right: 0.5519276254474083d,bottom: 0.2548460216309777d,left: 0.09747411888790125d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7319543425431271d,right: 0.3113055595154415d,bottom: 0.6306315447641354d,left: 0.14238102170788036d), new NpgsqlTypes.NpgsqlBox(top: 0.9103908542759078d,right: 0.3230214485963342d,bottom: 0.2879574439645839d,left: 0.05689151957751504d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4293344044127545d,right: 0.7463548888170533d,bottom: 0.12525403624885068d,left: 0.1422957024832492d), new NpgsqlTypes.NpgsqlBox(top: 0.9644899731054006d,right: 0.7913724052253683d,bottom: 0.36417886971735725d,left: 0.2987870151007004d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.2591070738560194d,right: 0.9872160241415175d,bottom: 0.19021620571001696d,left: 0.3636678310937116d), new NpgsqlTypes.NpgsqlBox(top: 0.23252607782378376d,right: 0.5449073442944548d,bottom: 0.04841179938101925d,left: 0.2972607545196352d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.985828245895232d,right: 0.6499046497564891d,bottom: 0.3418804858951219d,left: 0.23107703118891565d), new NpgsqlTypes.NpgsqlBox(top: 0.7714206267351935d,right: 0.9385867144560486d,bottom: 0.5042979591725117d,left: 0.3335240754227905d), }, },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5732952087007149d,right: 0.9995898403644211d,bottom: 0.17821682317385767d,left: 0.40141611627268836d), new NpgsqlTypes.NpgsqlBox(top: 0.2474960673709855d,right: 0.9944710830998117d,bottom: 0.19167327109715593d,left: 0.5830391660494977d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4638418176447243d,right: 0.9128646211627955d,bottom: 0.04181273566804544d,left: 0.2122456620320432d), new NpgsqlTypes.NpgsqlBox(top: 0.6505195727693677d,right: 0.7128408843473465d,bottom: 0.10850682402548661d,left: 0.4220070514204006d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8664080353568665d,right: 0.2548061028559616d,bottom: 0.37205172193803004d,left: 0.19575050545759898d), new NpgsqlTypes.NpgsqlBox(top: 0.3700623490314715d,right: 0.8259902139898259d,bottom: 0.256419897109858d,left: 0.21319614299290246d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.28918233887882505d,right: 0.7992030790152509d,bottom: 0.03834735748924489d,left: 0.5778311836530167d), new NpgsqlTypes.NpgsqlBox(top: 0.6128451849649482d,right: 0.6837546009365212d,bottom: 0.022861771130473718d,left: 0.6657979210558794d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8981460882508088d,right: 0.43710555017389185d,bottom: 0.8341787782527804d,left: 0.1564421443103169d), new NpgsqlTypes.NpgsqlBox(top: 0.8805061745565316d,right: 0.618798738999415d,bottom: 0.8334182051646374d,left: 0.006407284044823491d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.956711909042088d,right: 0.21500520249180932d,bottom: 0.25375930622923737d,left: 0.20031863732421284d), new NpgsqlTypes.NpgsqlBox(top: 0.6293204472420456d,right: 0.7016461182405712d,bottom: 0.06573464076935931d,left: 0.04483261167173813d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7444184220489968d,right: 0.8071484334830256d,bottom: 0.5055161699509046d,left: 0.0861536061612409d), new NpgsqlTypes.NpgsqlBox(top: 0.7743203916464292d,right: 0.7375063359633721d,bottom: 0.0563793838013944d,left: 0.11291901737858712d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.46568019811551487d,right: 0.8825726266789379d,bottom: 0.10498185705040597d,left: 0.44411054977938713d), new NpgsqlTypes.NpgsqlBox(top: 0.34967274188007014d,right: 0.6547392537563658d,bottom: 0.3136439190974756d,left: 0.3283496642416708d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5212518338885583d,right: 0.8066928044414552d,bottom: 0.0840035230655547d,left: 0.5664721754808995d), new NpgsqlTypes.NpgsqlBox(top: 0.9812913994988937d,right: 0.8582770614331441d,bottom: 0.7648669357021252d,left: 0.34953450817341947d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.40676001826251074d,right: 0.2562557466913251d,bottom: 0.03883913413439066d,left: 0.04746040245319216d), new NpgsqlTypes.NpgsqlBox(top: 0.512429136830417d,right: 0.6673935987249653d,bottom: 0.4256632792852827d,left: 0.28511148734220526d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7221356757890564d,right: 0.9864701725532669d,bottom: 0.0574685487788299d,left: 0.016611578159203444d), new NpgsqlTypes.NpgsqlBox(top: 0.7426087940030189d,right: 0.12645040375234795d,bottom: 0.5195370044343567d,left: 0.07398746115811095d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9556777491574074d,right: 0.39729442318715524d,bottom: 0.7813164913948694d,left: 0.15122543298191515d), new NpgsqlTypes.NpgsqlBox(top: 0.6844669470154959d,right: 0.8528425791148676d,bottom: 0.49603061685499983d,left: 0.08987646813748851d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9179460250683142d,right: 0.7271183880225836d,bottom: 0.9075724131704019d,left: 0.22983344949081508d), new NpgsqlTypes.NpgsqlBox(top: 0.5107656865662976d,right: 0.477919066864695d,bottom: 0.23888287335872416d,left: 0.16365846329422995d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8544159278509081d,right: 0.8389174185024575d,bottom: 0.6947117962247936d,left: 0.6217685020891879d), new NpgsqlTypes.NpgsqlBox(top: 0.8072511886096262d,right: 0.02718109216304665d,bottom: 0.0325161050070083d,left: 0.014442967932484674d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.47785947625075254d,right: 0.9894312461778414d,bottom: 0.07990863035215567d,left: 0.1856090467068625d), new NpgsqlTypes.NpgsqlBox(top: 0.3421924330697871d,right: 0.2932378534165543d,bottom: 0.28084556796923676d,left: 0.21183310197422356d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7218926488437015d,right: 0.7658669241535682d,bottom: 0.6859639936816097d,left: 0.5605273950640861d), new NpgsqlTypes.NpgsqlBox(top: 0.9150715942483704d,right: 0.4979970209116047d,bottom: 0.7766302132507173d,left: 0.14436159938021842d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7749773892734236d,right: 0.4329830832226905d,bottom: 0.5323531302243822d,left: 0.04770500744905937d), new NpgsqlTypes.NpgsqlBox(top: 0.5095670941339017d,right: 0.4342784037884969d,bottom: 0.45974108664807745d,left: 0.364291454543869d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.720531739000936d,right: 0.6669318461966756d,bottom: 0.26206085658629386d,left: 0.5648777077738133d), new NpgsqlTypes.NpgsqlBox(top: 0.5095210941575952d,right: 0.9012018403170016d,bottom: 0.18370082431908386d,left: 0.391428801324161d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.2822902840705087d,right: 0.5570352866324327d,bottom: 0.1431324426669408d,left: 0.22112116788149583d), new NpgsqlTypes.NpgsqlBox(top: 0.3813775604232129d,right: 0.9204879236120932d,bottom: 0.30982388737803457d,left: 0.5655863385655888d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6039921927209849d,right: 0.1308898718933984d,bottom: 0.6023919746826416d,left: 0.026047628561200242d), new NpgsqlTypes.NpgsqlBox(top: 0.7545882392452943d,right: 0.762636581274247d,bottom: 0.11030695053074158d,left: 0.47727533158554836d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6479057673142905d,right: 0.7192289399754969d,bottom: 0.47864946842750644d,left: 0.5448038653766073d), new NpgsqlTypes.NpgsqlBox(top: 0.3481020648767421d,right: 0.7081857129475227d,bottom: 0.32002668492149644d,left: 0.09174902161211718d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5127791138900183d,right: 0.8949385779580952d,bottom: 0.1312714229118762d,left: 0.8046557524803468d), new NpgsqlTypes.NpgsqlBox(top: 0.6689344180081215d,right: 0.7677416491646282d,bottom: 0.06264737426948219d,left: 0.26816355779208756d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8026761255093977d,right: 0.5071073527708685d,bottom: 0.7205652655870417d,left: 0.18053438528551102d), new NpgsqlTypes.NpgsqlBox(top: 0.365751689798292d,right: 0.47744708562463367d,bottom: 0.0979093517252847d,left: 0.420542007656872d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9907140302245712d,right: 0.1755373795591073d,bottom: 0.10457229262166468d,left: 0.07688277643591901d), new NpgsqlTypes.NpgsqlBox(top: 0.2788768471176979d,right: 0.5728639024051593d,bottom: 0.017226158192351404d,left: 0.07902006634558223d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.647961963479479d,right: 0.8031002481098715d,bottom: 0.6112759645132699d,left: 0.017503252137978875d), new NpgsqlTypes.NpgsqlBox(top: 0.959832879793431d,right: 0.9673140311744087d,bottom: 0.5031437030619759d,left: 0.9234758579855775d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9836653641009333d,right: 0.3253840394329316d,bottom: 0.9783291822743494d,left: 0.26582204100280526d), new NpgsqlTypes.NpgsqlBox(top: 0.7774890659941637d,right: 0.8615917588133054d,bottom: 0.43644350236272667d,left: 0.06558595505828468d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8087894614704818d,right: 0.4193896387835243d,bottom: 0.016676208068025167d,left: 0.03988395865175276d), new NpgsqlTypes.NpgsqlBox(top: 0.2832353477185502d,right: 0.9615437227492072d,bottom: 0.20780759213957778d,left: 0.32671076944276467d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6124053895858607d,right: 0.3047678013046884d,bottom: 0.4794817811529276d,left: 0.2695916589956914d), new NpgsqlTypes.NpgsqlBox(top: 0.9903698503258579d,right: 0.820858892674228d,bottom: 0.4161984037381472d,left: 0.4858413847386247d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9974655436227065d,right: 0.46548145947025366d,bottom: 0.5183898150280646d,left: 0.3276353597680469d), new NpgsqlTypes.NpgsqlBox(top: 0.47972282762981644d,right: 0.8674775054163422d,bottom: 0.11850278281006099d,left: 0.1937651395329394d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9930275199732055d,right: 0.7118358024113111d,bottom: 0.52561729306798d,left: 0.5048655955991862d), new NpgsqlTypes.NpgsqlBox(top: 0.6334168391031885d,right: 0.9819384274065396d,bottom: 0.5615628967025994d,left: 0.3609565756329495d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4145304752157336d,right: 0.9312443265682977d,bottom: 0.10856190604132243d,left: 0.6841115868394806d), new NpgsqlTypes.NpgsqlBox(top: 0.9546806600396582d,right: 0.5764876598674216d,bottom: 0.7740610212500713d,left: 0.4086157334676719d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6762868902888763d,right: 0.900080058163189d,bottom: 0.28369333726972046d,left: 0.5910657913796401d), new NpgsqlTypes.NpgsqlBox(top: 0.8341445955878753d,right: 0.9686379619711228d,bottom: 0.0017425811060338692d,left: 0.4219425736458834d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3014321863674878d,right: 0.4399593857486459d,bottom: 0.2286171281369611d,left: 0.3346723477946052d), new NpgsqlTypes.NpgsqlBox(top: 0.901772301691941d,right: 0.7018885478065099d,bottom: 0.8929470920850938d,left: 0.2534961253966068d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.78823106696703d,right: 0.9178916352248485d,bottom: 0.3225857317024676d,left: 0.05816830466009648d), new NpgsqlTypes.NpgsqlBox(top: 0.7263934714753477d,right: 0.8887206421160833d,bottom: 0.4167815049186864d,left: 0.07681326368926789d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.3515999873540029d,right: 0.39397811792681026d,bottom: 0.0038897779822097966d,left: 0.2938154738615726d), new NpgsqlTypes.NpgsqlBox(top: 0.3946462382459194d,right: 0.7255579399016558d,bottom: 0.3709970296473689d,left: 0.1797080859603244d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8464955595434785d,right: 0.7932492262687753d,bottom: 0.7832231748361167d,left: 0.09534503778342207d), new NpgsqlTypes.NpgsqlBox(top: 0.8514880156898691d,right: 0.8543442910664119d,bottom: 0.4583778365843971d,left: 0.5951313375451862d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.4207908789559571d,right: 0.8715056692925706d,bottom: 0.3049878172980104d,left: 0.35491893602017666d), new NpgsqlTypes.NpgsqlBox(top: 0.6913253390836207d,right: 0.7837451038720975d,bottom: 0.04022561892719523d,left: 0.2332434860636997d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8451416712100116d,right: 0.27932558230398163d,bottom: 0.7267603681181581d,left: 0.012843153383145012d), new NpgsqlTypes.NpgsqlBox(top: 0.4112879018087877d,right: 0.9862336914698d,bottom: 0.1933523884470284d,left: 0.3715506920902434d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9143247481444721d,right: 0.9733193841391197d,bottom: 0.4152496861311338d,left: 0.8384514309638871d), new NpgsqlTypes.NpgsqlBox(top: 0.36651869012782745d,right: 0.7383647548699919d,bottom: 0.22514038372921086d,left: 0.009568773761095217d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9445565374620478d,right: 0.6714561212708637d,bottom: 0.27314293386225164d,left: 0.07939784449261733d), new NpgsqlTypes.NpgsqlBox(top: 0.4539523292750546d,right: 0.35404393014393176d,bottom: 0.02270184572299605d,left: 0.2687289966656734d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9763171211629743d,right: 0.6688658581302919d,bottom: 0.15516531305241155d,left: 0.16905900129660656d), new NpgsqlTypes.NpgsqlBox(top: 0.8372892283501493d,right: 0.8668258638851384d,bottom: 0.5718460852521763d,left: 0.25787899478573395d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.29343827055467264d,right: 0.8035719814759525d,bottom: 0.20547240374817777d,left: 0.13325571937073377d), new NpgsqlTypes.NpgsqlBox(top: 0.5547174708524697d,right: 0.3080809879484897d,bottom: 0.34701670407269436d,left: 0.22815104769537076d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.32725582639212036d,right: 0.7232799059181145d,bottom: 0.25832690261533164d,left: 0.18528300154480382d), new NpgsqlTypes.NpgsqlBox(top: 0.9675403053889781d,right: 0.23519255510398085d,bottom: 0.3853681519796932d,left: 0.014008902340643226d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.722417485404497d,right: 0.9940175051222632d,bottom: 0.07103400647226465d,left: 0.23360997585389376d), new NpgsqlTypes.NpgsqlBox(top: 0.7218998268600706d,right: 0.5081701120803103d,bottom: 0.35515156030107875d,left: 0.12064435584838396d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6047218697847502d,right: 0.9742641986244677d,bottom: 0.5456932552766574d,left: 0.6643821706347625d), new NpgsqlTypes.NpgsqlBox(top: 0.9862167237555324d,right: 0.7764379268767387d,bottom: 0.8429633688222626d,left: 0.09812265321656599d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4766565304587205d,right: 0.4849739166043108d,bottom: 0.4529528316431871d,left: 0.1039965087242758d), new NpgsqlTypes.NpgsqlBox(top: 0.6527010698347171d,right: 0.7848417789929519d,bottom: 0.2392425609465625d,left: 0.24109501301460357d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9769361278267649d,right: 0.6349647394268787d,bottom: 0.5243200813473285d,left: 0.4929382167856602d), new NpgsqlTypes.NpgsqlBox(top: 0.261113143171704d,right: 0.04711792955076266d,bottom: 0.23388378705749657d,left: 0.027123014883513208d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.24315011218760663d,right: 0.8482433141829683d,bottom: 0.14842329014968803d,left: 0.467155560594781d), new NpgsqlTypes.NpgsqlBox(top: 0.665651874680099d,right: 0.8917159433797855d,bottom: 0.20164223659602643d,left: 0.6960255289466281d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7359696520450862d,right: 0.6462044009613755d,bottom: 0.3595951737248658d,left: 0.31968379359904553d), new NpgsqlTypes.NpgsqlBox(top: 0.7350056577122982d,right: 0.705632736656605d,bottom: 0.24133924979257648d,left: 0.1218191302989734d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.2981992128965024d,right: 0.2824549516467858d,bottom: 0.023429784924185126d,left: 0.2553126072512596d), new NpgsqlTypes.NpgsqlBox(top: 0.21826317702412912d,right: 0.7649138524553408d,bottom: 0.0035326076566599696d,left: 0.1645250167027258d), }, },
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7999707532237511d,right: 0.3674759145304295d,bottom: 0.7210700825116619d,left: 0.1271345623545752d), new NpgsqlTypes.NpgsqlBox(top: 0.5010476571952542d,right: 0.9930601639099066d,bottom: 0.4404845039297207d,left: 0.7653727837865262d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.9141739572479873d,right: 0.7378180798180534d,bottom: 0.9033549721980705d,left: 0.6887980856073588d), new NpgsqlTypes.NpgsqlBox(top: 0.2827840976039706d,right: 0.6944341742058097d,bottom: 0.07230418415162454d,left: 0.3300030747755056d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.7229790407808797d,right: 0.3077906879852086d,bottom: 0.414219687374236d,left: 0.0522686909144604d), new NpgsqlTypes.NpgsqlBox(top: 0.7024759306652397d,right: 0.9795847206467388d,bottom: 0.4830049609892295d,left: 0.49162601806792383d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5924652364219078d,right: 0.4469979494795744d,bottom: 0.2800552306213706d,left: 0.12521353802285262d), new NpgsqlTypes.NpgsqlBox(top: 0.8426216431966926d,right: 0.9476240282010403d,bottom: 0.6684960205583d,left: 0.7207563665701198d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5566333339569456d,right: 0.4590227021603557d,bottom: 0.5310142729973226d,left: 0.2869191710366882d), new NpgsqlTypes.NpgsqlBox(top: 0.7795717698668362d,right: 0.9779331046946838d,bottom: 0.577803109888666d,left: 0.6167063460738765d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7856983276269515d,right: 0.6253910711099425d,bottom: 0.18476882274745154d,left: 0.40624714677082663d), new NpgsqlTypes.NpgsqlBox(top: 0.6284286523480466d,right: 0.738479274653432d,bottom: 0.25009187095982466d,left: 0.30363181579599297d), }, },
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8652279304775737d,right: 0.6468035715881962d,bottom: 0.5777159225612559d,left: 0.15474232050782155d), new NpgsqlTypes.NpgsqlBox(top: 0.1471419740488833d,right: 0.9588640475681766d,bottom: 0.07517106467709844d,left: 0.11584160573571167d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.49443867298768884d,right: 0.9901903572438533d,bottom: 0.13913255699698002d,left: 0.4324746643913219d), new NpgsqlTypes.NpgsqlBox(top: 0.8841954710032629d,right: 0.8282033913893463d,bottom: 0.8346035083813742d,left: 0.45541050488747936d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 168,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.38906288949677625d,right: 0.8013267365989934d,bottom: 0.14908920114889967d,left: 0.6736381496150666d), new NpgsqlTypes.NpgsqlBox(top: 0.5099144625864447d,right: 0.6803007266693655d,bottom: 0.26558779885920003d,left: 0.39159675333971544d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5880799733672403d,right: 0.7347491208864839d,bottom: 0.5766919322754513d,left: 0.07054696184593878d), new NpgsqlTypes.NpgsqlBox(top: 0.8665935440214082d,right: 0.5678074653160702d,bottom: 0.8236023525640084d,left: 0.12011785059512281d), }, },
    ModelInner = new NpgsqlBoxboxMMArrayD2E1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.45318155906288027d,right: 0.7986325582170304d,bottom: 0.1752722547397274d,left: 0.14002709139361547d), new NpgsqlTypes.NpgsqlBox(top: 0.8747581247916346d,right: 0.9466098634675373d,bottom: 0.6699929349466237d,left: 0.4268405941149145d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.6967748362687902d,right: 0.3144052634924682d,bottom: 0.2559211088139316d,left: 0.0050231885148809274d), new NpgsqlTypes.NpgsqlBox(top: 0.23804229075605177d,right: 0.5215876228448648d,bottom: 0.20515586436909683d,left: 0.1994203815473774d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxMMArrayD2E1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.11457845903527242d,right: 0.7519503649898935d,bottom: 0.015834537607221755d,left: 0.033050329195639994d), new NpgsqlTypes.NpgsqlBox(top: 0.9816420617602006d,right: 0.6033010647967748d,bottom: 0.14207355888345874d,left: 0.45059968193674893d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.90630353993271d,right: 0.8904449418820772d,bottom: 0.5109689153369662d,left: 0.04396567885422842d), new NpgsqlTypes.NpgsqlBox(top: 0.7815655405867983d,right: 0.9176542161582735d,bottom: 0.38752669111726756d,left: 0.21223372098765958d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.49096142336546533d,right: 0.45098317563074697d,bottom: 0.4717443530080725d,left: 0.02627341432415853d), new NpgsqlTypes.NpgsqlBox(top: 0.7737296088339575d,right: 0.25947086039801914d,bottom: 0.6144213238022747d,left: 0.06961511389205488d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.8426161422073003d,right: 0.29666655142863385d,bottom: 0.6140441419976224d,left: 0.03998408725873159d), new NpgsqlTypes.NpgsqlBox(top: 0.7179365553921497d,right: 0.8798876230518219d,bottom: 0.6332140294997299d,left: 0.3340706125686259d), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd2e1mi_id
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
    npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5811437790039216d,right: 0.47825726731112983d,bottom: 0.05413777379780538d,left: 0.38148491259293604d), new NpgsqlTypes.NpgsqlBox(top: 0.915317795249926d,right: 0.7956084040223611d,bottom: 0.23208859432287854d,left: 0.5155984484325644d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.796074308319506d,right: 0.6600609005705763d,bottom: 0.08150444058650075d,left: 0.16890995830082467d), new NpgsqlTypes.NpgsqlBox(top: 0.9878988855749531d,right: 0.6521123991197277d,bottom: 0.7825708054418153d,left: 0.2570719906525343d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.8936275672230586d,right: 0.670362883513878d,bottom: 0.32364513757492774d,left: 0.29640346472943124d), new NpgsqlTypes.NpgsqlBox(top: 0.8504624027309494d,right: 0.670275074950263d,bottom: 0.04529465181621917d,left: 0.3416114665749159d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5322906584310269d,right: 0.9174616909675519d,bottom: 0.18815107687062027d,left: 0.25326040023633223d), new NpgsqlTypes.NpgsqlBox(top: 0.9574433743937503d,right: 0.9335135756910322d,bottom: 0.6768095313818733d,left: 0.07485666112387057d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.5802900362366059d,right: 0.36672150110157054d,bottom: 0.20573254878132585d,left: 0.33873285988583346d), new NpgsqlTypes.NpgsqlBox(top: 0.5203410149529852d,right: 0.653411058495643d,bottom: 0.44625038063062183d,left: 0.3477849628931653d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.5805312076788937d,right: 0.23769758379028538d,bottom: 0.503541077947702d,left: 0.005836369853958745d), new NpgsqlTypes.NpgsqlBox(top: 0.8426958895513592d,right: 0.4844406077030089d,bottom: 0.07959480511267925d,left: 0.42657450054000545d), }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxmmarrayd2e1mi_id
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
    npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9041562326242324d,right: 0.9113812067700504d,bottom: 0.43320539780606093d,left: 0.03289815662325879d), new NpgsqlTypes.NpgsqlBox(top: 0.781747432665758d,right: 0.5834243953340238d,bottom: 0.12533237821367593d,left: 0.02014371808378279d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.898970516722852d,right: 0.34716305623417965d,bottom: 0.5805845147440526d,left: 0.19869826697167337d), new NpgsqlTypes.NpgsqlBox(top: 0.3077353972598085d,right: 0.5066424665917222d,bottom: 0.21657584720226908d,left: 0.4387496491042352d), }, }));
                nullable =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[,] nullable = null;
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.9868309785422258d,right: 0.7076964423463391d,bottom: 0.4302426011625805d,left: 0.6509769954870264d), new NpgsqlTypes.NpgsqlBox(top: 0.8442959528098829d,right: 0.740934317043858d,bottom: 0.5785610366356194d,left: 0.5553678949387085d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.7757486033827928d,right: 0.5342957153207941d,bottom: 0.6293428841357072d,left: 0.5281085274161373d), new NpgsqlTypes.NpgsqlBox(top: 0.8433094796278374d,right: 0.8710012344127875d,bottom: 0.5936927368361429d,left: 0.19176154312197002d), }, }));
                nullable = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[,] { { new NpgsqlTypes.NpgsqlBox(top: 0.6082416053145973d,right: 0.4433318837113671d,bottom: 0.4033632602750076d,left: 0.06216864609075268d), new NpgsqlTypes.NpgsqlBox(top: 0.6043818008006542d,right: 0.7262505642016731d,bottom: 0.479458071212581d,left: 0.3087828444381565d), }, { new NpgsqlTypes.NpgsqlBox(top: 0.4493023038396725d,right: 0.1292073570649116d,bottom: 0.09927231841077d,left: 0.0907483136333902d), new NpgsqlTypes.NpgsqlBox(top: 0.7796754873323657d,right: 0.800304719703573d,bottom: 0.5887294195964683d,left: 0.2979021902074095d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD2E1M> models = null;

                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxMMArrayD2E1M> models = null;

                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 33;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M), typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 73, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 86, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 116, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 91, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 129, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 38, query1, 142, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 150, query1, 166, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
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
FROM public.npgsqlboxboxmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxMMArrayD2E1M>();
                 ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 129, query1, 27, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
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
                var models = await((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 76, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxMArrayboxMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 143, 143))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxMArrayboxMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxMArrayboxMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxMArrayboxMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxMArrayboxMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 131);
                var models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                NpgsqlBoxboxMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
FROM public.binary_npgsqlboxboxmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlboxboxmmarrayd2e1mi mi ON mi.id = m.npgsqlboxboxmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxMArrayboxMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models =  ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA), typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA), typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
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
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI), typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MI>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA), typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                await ((INpgsqlBoxMArrayboxMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlBoxboxMMArrayD2E1MIWA>();
                ((INpgsqlBoxMArrayboxMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxMArrayboxMMArrayD2))]
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
                var models = await ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxMArrayboxMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

