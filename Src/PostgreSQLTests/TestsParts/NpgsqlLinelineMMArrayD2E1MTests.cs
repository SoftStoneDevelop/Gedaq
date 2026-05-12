

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
    internal partial interface INpgsqlLineMArraylineMMArrayD2
    {
    }
    
    internal partial class NpgsqlLineMArraylineMMArrayD2 : INpgsqlLineMArraylineMMArrayD2
    {


#region TestData

        private readonly NpgsqlLinelineMMArrayD2E1M[] _testData = new NpgsqlLinelineMMArrayD2E1M[]
        {
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5600898130397208d, b: 0.061413900030730106d, c: 0.4289660406799586d), new NpgsqlTypes.NpgsqlLine(a: 0.8184471279341727d, b: 0.6051674007668887d, c: 0.26365262357925945d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.027971084784963796d, b: 0.7290175324659589d, c: 0.5449760513432811d), new NpgsqlTypes.NpgsqlLine(a: 0.7659975289467982d, b: 0.30019639056657255d, c: 0.0015331827781978058d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.518162011067433d, b: 0.2852023000020677d, c: 0.8458777883821198d), new NpgsqlTypes.NpgsqlLine(a: 0.3871252240116302d, b: 0.8836523465359308d, c: 0.8373079937345471d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9153905974229555d, b: 0.01950935485629024d, c: 0.37307384255891385d), new NpgsqlTypes.NpgsqlLine(a: 0.9354828896930898d, b: 0.1931567030481044d, c: 0.9863043921498608d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6730545899871113d, b: 0.4004527414022936d, c: 0.7271182241071164d), new NpgsqlTypes.NpgsqlLine(a: 0.5987733720761732d, b: 0.10228402775108514d, c: 0.4331076083712d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9249462699076029d, b: 0.4853953177757089d, c: 0.8550722615199282d), new NpgsqlTypes.NpgsqlLine(a: 0.3298736217791517d, b: 0.17838591656915292d, c: 0.10446769476062856d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3604460901673706d, b: 0.565924307261174d, c: 0.23889540436399181d), new NpgsqlTypes.NpgsqlLine(a: 0.03289950099253003d, b: 0.9758114884032751d, c: 0.03800846806965985d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.686878165635131d, b: 0.9072824864516384d, c: 0.5113107155115455d), new NpgsqlTypes.NpgsqlLine(a: 0.6138411060762615d, b: 0.49710807209633034d, c: 0.529534374989481d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8926521841287981d, b: 0.5442382499395679d, c: 0.6931204721548061d), new NpgsqlTypes.NpgsqlLine(a: 0.4434048853540574d, b: 0.8747622061020026d, c: 0.13311937990287293d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.49856482337155705d, b: 0.7721617690813714d, c: 0.5313955359000958d), new NpgsqlTypes.NpgsqlLine(a: 0.6606802387895229d, b: 0.5399661576236277d, c: 0.519610007294426d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7579213901710096d, b: 0.8425312167586292d, c: 0.23622509939634573d), new NpgsqlTypes.NpgsqlLine(a: 0.5806488256306134d, b: 0.22346053991362336d, c: 0.9028296327696929d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.12458351443393234d, b: 0.20532736556560283d, c: 0.7581160942218861d), new NpgsqlTypes.NpgsqlLine(a: 0.7423317103284447d, b: 0.30135314134934865d, c: 0.12645483743559827d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.25835387459980086d, b: 0.4787115601294202d, c: 0.2782916632065606d), new NpgsqlTypes.NpgsqlLine(a: 0.72536756332334d, b: 0.9861738065522554d, c: 0.14685478007261643d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8403539767022461d, b: 0.5187251134924298d, c: 0.0651618136868849d), new NpgsqlTypes.NpgsqlLine(a: 0.03251501505720189d, b: 0.21489193992608624d, c: 0.26055632590962896d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.596970182153156d, b: 0.3735014275006109d, c: 0.9074541786585449d), new NpgsqlTypes.NpgsqlLine(a: 0.633652599788336d, b: 0.3765819805063719d, c: 0.06322838424126787d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9194928676225945d, b: 0.024006988288676423d, c: 0.43728484091890674d), new NpgsqlTypes.NpgsqlLine(a: 0.8182796090212797d, b: 0.5539884869052328d, c: 0.34665025400415217d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9136827979204858d, b: 0.9496109669734356d, c: 0.5187973949352404d), new NpgsqlTypes.NpgsqlLine(a: 0.5955100326098887d, b: 0.5212472735594096d, c: 0.4330188533965793d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8093967087244172d, b: 0.15560346348355192d, c: 0.4672779831597974d), new NpgsqlTypes.NpgsqlLine(a: 0.23575501365070395d, b: 0.6046894543701749d, c: 0.5943478967430958d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9628744075172491d, b: 0.8464575159483979d, c: 0.5251528486262489d), new NpgsqlTypes.NpgsqlLine(a: 0.7473551851011362d, b: 0.7044240804916776d, c: 0.7169609165056403d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.965679411361523d, b: 0.826880289316768d, c: 0.539517903334902d), new NpgsqlTypes.NpgsqlLine(a: 0.783343837058449d, b: 0.6036931882183741d, c: 0.22519807143158965d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4780499153987834d, b: 0.34505830714902974d, c: 0.7729319610835633d), new NpgsqlTypes.NpgsqlLine(a: 0.28066807565013996d, b: 0.6096602161298601d, c: 0.20517975391774912d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.19943047977214734d, b: 0.6491448587816874d, c: 0.9424361700158053d), new NpgsqlTypes.NpgsqlLine(a: 0.6910909120784762d, b: 0.1570060863130005d, c: 0.2251014939626229d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9910397951785892d, b: 0.4565013545080284d, c: 0.6145164604036871d), new NpgsqlTypes.NpgsqlLine(a: 0.5405240491951984d, b: 0.9004434041081667d, c: 0.884656905723315d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8766117593075158d, b: 0.19924245333637103d, c: 0.5452160294869619d), new NpgsqlTypes.NpgsqlLine(a: 0.4210814038152928d, b: 0.5242269454555184d, c: 0.4911526159468268d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.16971220554358246d, b: 0.7765135780008529d, c: 0.022864786593254194d), new NpgsqlTypes.NpgsqlLine(a: 0.9111474505474751d, b: 0.30036639009257293d, c: 0.9852947167861841d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4017187904127406d, b: 0.8759595992000214d, c: 0.11127185207839785d), new NpgsqlTypes.NpgsqlLine(a: 0.4104274866483195d, b: 0.5090856599213299d, c: 0.4540469101240665d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.623936934581853d, b: 0.05754019851599823d, c: 0.3020947811541156d), new NpgsqlTypes.NpgsqlLine(a: 0.957148236568181d, b: 0.609515929601453d, c: 0.9215980732729117d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6149910227534391d, b: 0.8082033422576232d, c: 0.8622802100658965d), new NpgsqlTypes.NpgsqlLine(a: 0.5754709133656613d, b: 0.576939490155285d, c: 0.9229954081015805d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.1873787857676923d, b: 0.5122729207452519d, c: 0.0404348106522604d), new NpgsqlTypes.NpgsqlLine(a: 0.4042512845688523d, b: 0.5487406822842846d, c: 0.1690369775956274d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8442725321171557d, b: 0.08690400081435024d, c: 0.8018439889705533d), new NpgsqlTypes.NpgsqlLine(a: 0.011069007049220536d, b: 0.15459489346794697d, c: 0.24436359556858067d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.643463511786925d, b: 0.7067996911068586d, c: 0.5157336509304897d), new NpgsqlTypes.NpgsqlLine(a: 0.35393785781192877d, b: 0.9236814553440018d, c: 0.4741453530886187d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6782981612069762d, b: 0.6218471995798427d, c: 0.47771749552060394d), new NpgsqlTypes.NpgsqlLine(a: 0.7016415158662066d, b: 0.8226886280973098d, c: 0.8246458957432197d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.26580768186576453d, b: 0.905927654554073d, c: 0.6743496465897817d), new NpgsqlTypes.NpgsqlLine(a: 0.5990384583530926d, b: 0.1708172869979836d, c: 0.863365925397868d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.30066343694243125d, b: 0.8547772298144759d, c: 0.9398724713501441d), new NpgsqlTypes.NpgsqlLine(a: 0.7050598820951381d, b: 0.3592048466904967d, c: 0.016473478200126346d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.1843813646627105d, b: 0.19708455995718055d, c: 0.7766176114486764d), new NpgsqlTypes.NpgsqlLine(a: 0.09710999899688355d, b: 0.1038423382870779d, c: 0.62826499683908d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8526992839515882d, b: 0.927935708449419d, c: 0.8469643525367607d), new NpgsqlTypes.NpgsqlLine(a: 0.521064789140521d, b: 0.9836639540688409d, c: 0.8808223877125078d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3792583702769049d, b: 0.40991180826819795d, c: 0.1255907889610347d), new NpgsqlTypes.NpgsqlLine(a: 0.5499010960354305d, b: 0.38156597312756957d, c: 0.5741159990431023d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.23580346575033784d, b: 0.5197241546343243d, c: 0.6789035074596884d), new NpgsqlTypes.NpgsqlLine(a: 0.8534484110983438d, b: 0.38442639939965584d, c: 0.8280011583133265d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.511799654256861d, b: 0.12375453780728252d, c: 0.12664890339977142d), new NpgsqlTypes.NpgsqlLine(a: 0.42791106081165886d, b: 0.5341410149323506d, c: 0.6344285358820508d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.779184998053557d, b: 0.337240665785299d, c: 0.4551461846472521d), new NpgsqlTypes.NpgsqlLine(a: 0.09713147013310652d, b: 0.049558966424467554d, c: 0.08799328552617824d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.011437892318141074d, b: 0.6708009072824934d, c: 0.9764219973897404d), new NpgsqlTypes.NpgsqlLine(a: 0.8684498605744952d, b: 0.21174139704598482d, c: 0.5951223343468497d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6662052243836425d, b: 0.7532190544766868d, c: 0.005951440977899791d), new NpgsqlTypes.NpgsqlLine(a: 0.8512294354667632d, b: 0.8435805662332638d, c: 0.5828563115673983d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2501966371036912d, b: 0.4730394437723334d, c: 0.33662969799503706d), new NpgsqlTypes.NpgsqlLine(a: 0.6992896918805894d, b: 0.5516200161632822d, c: 0.9955797854002544d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.854598210365838d, b: 0.24722088069349357d, c: 0.46673563134955265d), new NpgsqlTypes.NpgsqlLine(a: 0.425519456986556d, b: 0.22248569852653677d, c: 0.6930780300230849d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9864746305812222d, b: 0.32629789938780995d, c: 0.32872722915823693d), new NpgsqlTypes.NpgsqlLine(a: 0.8394021940094996d, b: 0.5017763729125339d, c: 0.414911408390535d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7551871975758442d, b: 0.23220699329752992d, c: 0.9638131931148586d), new NpgsqlTypes.NpgsqlLine(a: 0.11128154307525062d, b: 0.9075117934521616d, c: 0.37025335772454626d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.774162934826676d, b: 0.36358411602835916d, c: 0.27556914246266273d), new NpgsqlTypes.NpgsqlLine(a: 0.8948386447018054d, b: 0.5705465313680536d, c: 0.2975042460117632d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.06777965806984321d, b: 0.05404114588217701d, c: 0.41195227466150064d), new NpgsqlTypes.NpgsqlLine(a: 0.20602668358549248d, b: 0.8195392370595981d, c: 0.984880382242997d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.004196647279296917d, b: 0.42422767004115725d, c: 0.3829278461163701d), new NpgsqlTypes.NpgsqlLine(a: 0.19565623698195378d, b: 0.239520619993835d, c: 0.030510877669834402d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.45130296496114775d, b: 0.38173545570393963d, c: 0.1394422761230084d), new NpgsqlTypes.NpgsqlLine(a: 0.5621773658683658d, b: 0.6272552067900157d, c: 0.01935272196124571d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.12456096834200026d, b: 0.9890709633604772d, c: 0.34357073386677517d), new NpgsqlTypes.NpgsqlLine(a: 0.044321862025150094d, b: 0.47835904668037543d, c: 0.31070233838051264d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.23481048568164598d, b: 0.4578966666927473d, c: 0.2113868466433947d), new NpgsqlTypes.NpgsqlLine(a: 0.26333332839005386d, b: 0.6766002017411488d, c: 0.7677741604233146d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7732222272620001d, b: 0.31032154416618685d, c: 0.16187300363915735d), new NpgsqlTypes.NpgsqlLine(a: 0.7421441992722907d, b: 0.7959294277135374d, c: 0.1590485420450951d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5704748938351514d, b: 0.9926595180586378d, c: 0.9924893654547354d), new NpgsqlTypes.NpgsqlLine(a: 0.2127306174504483d, b: 0.07996080758656599d, c: 0.1059958555884759d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.39857678008462116d, b: 0.25239628415587323d, c: 0.10822061343375744d), new NpgsqlTypes.NpgsqlLine(a: 0.13490810812835863d, b: 0.9311030824615687d, c: 0.779435217927676d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9315844371864506d, b: 0.3972056321957056d, c: 0.41880751628086166d), new NpgsqlTypes.NpgsqlLine(a: 0.25212507999328193d, b: 0.9143324196652807d, c: 0.5150771151616335d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.42272825044363804d, b: 0.6872444427165989d, c: 0.3232468517485595d), new NpgsqlTypes.NpgsqlLine(a: 0.616639969558686d, b: 0.744003828632411d, c: 0.3228231122964942d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.41678701332125867d, b: 0.20881872849474736d, c: 0.6250530232700282d), new NpgsqlTypes.NpgsqlLine(a: 0.4695235352431937d, b: 0.8027737125737338d, c: 0.686676928896994d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.12678660441092404d, b: 0.8422326269363862d, c: 0.019490244317400762d), new NpgsqlTypes.NpgsqlLine(a: 0.18383891487053705d, b: 0.4006908085779842d, c: 0.14440619325915005d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.32750055172978443d, b: 0.540704582842195d, c: 0.04099364749596601d), new NpgsqlTypes.NpgsqlLine(a: 0.4291762111482973d, b: 0.15542575402446146d, c: 0.9429139860422612d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6327492381796597d, b: 0.9609289628331998d, c: 0.8069919494930534d), new NpgsqlTypes.NpgsqlLine(a: 0.10625516240857924d, b: 0.44253213455666385d, c: 0.6231255483327794d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7707037262740468d, b: 0.601277991206192d, c: 0.8950852706749879d), new NpgsqlTypes.NpgsqlLine(a: 0.7324778028648937d, b: 0.7710434974560297d, c: 0.3708926255640599d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5911299609278473d, b: 0.6158236093726046d, c: 0.35137748947066827d), new NpgsqlTypes.NpgsqlLine(a: 0.8293345568014915d, b: 0.18733711893333382d, c: 0.3277006467735738d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.1933721831402363d, b: 0.12584843402269597d, c: 0.8216237627608208d), new NpgsqlTypes.NpgsqlLine(a: 0.7116569486066187d, b: 0.684469353151316d, c: 0.7435843342359887d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3439058975771595d, b: 0.6048610111854341d, c: 0.31816689661328323d), new NpgsqlTypes.NpgsqlLine(a: 0.9331627225211038d, b: 0.09556643850298208d, c: 0.7935546599190437d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.054157767645119814d, b: 0.36425407240475804d, c: 0.23168375567351251d), new NpgsqlTypes.NpgsqlLine(a: 0.07345313159170741d, b: 0.9455935396669588d, c: 0.275410910435925d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8865799236650209d, b: 0.6174430542451544d, c: 0.6268896057948483d), new NpgsqlTypes.NpgsqlLine(a: 0.8666031868732019d, b: 0.268011553231286d, c: 0.6446009321097508d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.20672597281702232d, b: 0.7397172111041048d, c: 0.3564499645655834d), new NpgsqlTypes.NpgsqlLine(a: 0.587475181922162d, b: 0.40513810538865824d, c: 0.8166905650339986d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6742720919787172d, b: 0.9716530103942822d, c: 0.2125915092895062d), new NpgsqlTypes.NpgsqlLine(a: 0.2775787391302561d, b: 0.5958930732082159d, c: 0.42114432379816946d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.46698870396685144d, b: 0.5306790782697522d, c: 0.6743280219370837d), new NpgsqlTypes.NpgsqlLine(a: 0.35055364646736253d, b: 0.3233806235456329d, c: 0.6019919848168341d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.1449922965553706d, b: 0.8586446451844374d, c: 0.8388472664739858d), new NpgsqlTypes.NpgsqlLine(a: 0.3769296994715067d, b: 0.5841131490899688d, c: 0.5228597087345586d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.38968768295851963d, b: 0.9106670601670898d, c: 0.635209772771949d), new NpgsqlTypes.NpgsqlLine(a: 0.25038602410074107d, b: 0.4947173193340123d, c: 0.8645317646834979d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8921731220051589d, b: 0.14319425242462425d, c: 0.6738657665165163d), new NpgsqlTypes.NpgsqlLine(a: 0.7807047553290272d, b: 0.07506378159780258d, c: 0.3871740270372309d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9778728652585297d, b: 0.9760778786311286d, c: 0.15927248825954088d), new NpgsqlTypes.NpgsqlLine(a: 0.35503592152221986d, b: 0.9875986866382314d, c: 0.2786646807985834d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.22333974116431188d, b: 0.1025075339296262d, c: 0.38978959435787597d), new NpgsqlTypes.NpgsqlLine(a: 0.1328184156007065d, b: 0.30061150450592333d, c: 0.5111111214116852d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9696814424538571d, b: 0.5403480514891413d, c: 0.09542947089619713d), new NpgsqlTypes.NpgsqlLine(a: 0.9394493133395346d, b: 0.560729888251119d, c: 0.6625698165357049d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.31242326014522304d, b: 0.8731676765601948d, c: 0.7060834727523674d), new NpgsqlTypes.NpgsqlLine(a: 0.9974416315220908d, b: 0.2949291673796046d, c: 0.9117548647042953d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.31328008291734954d, b: 0.13720830480483404d, c: 0.5624141266773328d), new NpgsqlTypes.NpgsqlLine(a: 0.7918291658119727d, b: 0.1259412810745104d, c: 0.2975149298283636d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6976547891450248d, b: 0.24948186419852914d, c: 0.49048805963403286d), new NpgsqlTypes.NpgsqlLine(a: 0.04087590985705736d, b: 0.6947919009301049d, c: 0.3659224654906741d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3339629309525337d, b: 0.34196827325544643d, c: 0.4548252621277734d), new NpgsqlTypes.NpgsqlLine(a: 0.8419786022584441d, b: 0.7402195664031994d, c: 0.4521312364135809d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.14473223579485606d, b: 0.7791978317738597d, c: 0.10916675124364295d), new NpgsqlTypes.NpgsqlLine(a: 0.7326000456609576d, b: 0.05406252938960798d, c: 0.5231603453566512d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.2971994291951704d, b: 0.6524616779651925d, c: 0.7592258780990292d), new NpgsqlTypes.NpgsqlLine(a: 0.19681608922269933d, b: 0.46597797592094614d, c: 0.05531624081355091d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9370567552423681d, b: 0.36769863718224916d, c: 0.12310566409372159d), new NpgsqlTypes.NpgsqlLine(a: 0.9397672299125132d, b: 0.1885179540557348d, c: 0.9747013316627683d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6043253873736787d, b: 0.1992400870255313d, c: 0.4344051597604015d), new NpgsqlTypes.NpgsqlLine(a: 0.23893115961596856d, b: 0.5864423747553579d, c: 0.4697639254076226d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9380728379080564d, b: 0.9861288185457372d, c: 0.9357976582629031d), new NpgsqlTypes.NpgsqlLine(a: 0.6368001962946476d, b: 0.015856404101282306d, c: 0.54594500195493d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8803006182461134d, b: 0.22296503460849026d, c: 0.5841112952397561d), new NpgsqlTypes.NpgsqlLine(a: 0.2763007259701652d, b: 0.08606136419280053d, c: 0.22578613051474905d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.716776589808592d, b: 0.17288912623870223d, c: 0.9077527021564092d), new NpgsqlTypes.NpgsqlLine(a: 0.5850405807729825d, b: 0.18611732051883934d, c: 0.17652169116177263d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7622823317115909d, b: 0.1659957883379808d, c: 0.8358450442179958d), new NpgsqlTypes.NpgsqlLine(a: 0.7266775876938311d, b: 0.9561891271098665d, c: 0.13808256447666267d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7266168653456468d, b: 0.8728233425375588d, c: 0.5116871705933074d), new NpgsqlTypes.NpgsqlLine(a: 0.2475637426280488d, b: 0.1503303194394433d, c: 0.7569498104832549d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3949709007817307d, b: 0.9135548007887854d, c: 0.9941993853848234d), new NpgsqlTypes.NpgsqlLine(a: 0.25535113189123415d, b: 0.8257887244445418d, c: 0.14976125009695973d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.18894922810823545d, b: 0.026653336031050467d, c: 0.038581718623558636d), new NpgsqlTypes.NpgsqlLine(a: 0.5079346474253975d, b: 0.4687663704974049d, c: 0.586316576777488d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.16837935651264557d, b: 0.31547949504962525d, c: 0.8972290335119786d), new NpgsqlTypes.NpgsqlLine(a: 0.6213354527372339d, b: 0.21437460734338287d, c: 0.892760258870258d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6143998018998544d, b: 0.5453530949438147d, c: 0.009309393916227315d), new NpgsqlTypes.NpgsqlLine(a: 0.7836436481563992d, b: 0.9380445515116885d, c: 0.08431435269330056d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.03116593108481991d, b: 0.132688234745442d, c: 0.9705937929506251d), new NpgsqlTypes.NpgsqlLine(a: 0.09630502582239941d, b: 0.5547256989291373d, c: 0.6718171991005969d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4843806519119277d, b: 0.8661786391308058d, c: 0.4040475950226051d), new NpgsqlTypes.NpgsqlLine(a: 0.644088843052381d, b: 0.43441544190060144d, c: 0.6562989233493279d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5533795323149499d, b: 0.011998043234094369d, c: 0.09560277090352165d), new NpgsqlTypes.NpgsqlLine(a: 0.05794270542562763d, b: 0.0404086079827185d, c: 0.22197067923074887d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.24729734536966264d, b: 0.1460194799985861d, c: 0.31112312863146685d), new NpgsqlTypes.NpgsqlLine(a: 0.322786004639668d, b: 0.5248873546201197d, c: 0.9793905319838976d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.2012664331075108d, b: 0.0005509247694385211d, c: 0.08263392619296328d), new NpgsqlTypes.NpgsqlLine(a: 0.26425868603059055d, b: 0.34515280361282497d, c: 0.5053738915509716d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8159668574116616d, b: 0.6100614686436157d, c: 0.16200504712147323d), new NpgsqlTypes.NpgsqlLine(a: 0.1344314197265548d, b: 0.8120055732686606d, c: 0.9441855000191789d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.06945815898708307d, b: 0.45497158943908544d, c: 0.6484743885424498d), new NpgsqlTypes.NpgsqlLine(a: 0.9842914697319052d, b: 0.044492937073614014d, c: 0.30244674304961616d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.40609286962429714d, b: 0.030923700129019238d, c: 0.7986454335833114d), new NpgsqlTypes.NpgsqlLine(a: 0.8330708394565238d, b: 0.6349810102545507d, c: 0.2161571823996571d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.190667445451555d, b: 0.005124997645150509d, c: 0.5345578526907553d), new NpgsqlTypes.NpgsqlLine(a: 0.517303697055556d, b: 0.9549136969319768d, c: 0.04216579011128574d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6227876228470349d, b: 0.5934350090014351d, c: 0.4238208208744739d), new NpgsqlTypes.NpgsqlLine(a: 0.07126122523212564d, b: 0.9536522193291807d, c: 0.8515847571141869d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.17184293700572983d, b: 0.8409937833199348d, c: 0.28565888326235755d), new NpgsqlTypes.NpgsqlLine(a: 0.5411573812495515d, b: 0.91780300336412d, c: 0.9094042058902089d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.280042115691308d, b: 0.270007616840665d, c: 0.5516762838871058d), new NpgsqlTypes.NpgsqlLine(a: 0.7562713879229751d, b: 0.8979355988447479d, c: 0.7472340277084595d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.21090433438593592d, b: 0.7697577609293421d, c: 0.18643449410616897d), new NpgsqlTypes.NpgsqlLine(a: 0.5380091522234755d, b: 0.3712694777666633d, c: 0.4477026988192483d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6014942985589851d, b: 0.39551378027140405d, c: 0.7140012626542019d), new NpgsqlTypes.NpgsqlLine(a: 0.6337816214992372d, b: 0.7006148980445179d, c: 0.5936116924586127d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.0010556278512124928d, b: 0.7238889784998043d, c: 0.4144987861393473d), new NpgsqlTypes.NpgsqlLine(a: 0.9781976437080938d, b: 0.8619247886616824d, c: 0.3563946205338162d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.38146768926944563d, b: 0.9720409826483387d, c: 0.36629749538921375d), new NpgsqlTypes.NpgsqlLine(a: 0.17418498709610686d, b: 0.6208506693981277d, c: 0.37821420141896045d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4015883508721114d, b: 0.11972785950296738d, c: 0.1318603437409377d), new NpgsqlTypes.NpgsqlLine(a: 0.8925110261774588d, b: 0.9833769364498318d, c: 0.36689673825694913d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4953118541275713d, b: 0.36527513675551115d, c: 0.509546340810256d), new NpgsqlTypes.NpgsqlLine(a: 0.08151362545786822d, b: 0.500402340531663d, c: 0.48617762758046024d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.21403967385452904d, b: 0.5501497106138253d, c: 0.6048009903666562d), new NpgsqlTypes.NpgsqlLine(a: 0.49417160873927835d, b: 0.32642933521417483d, c: 0.788988091526954d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5637038534838891d, b: 0.4729435511558626d, c: 0.8345250396198954d), new NpgsqlTypes.NpgsqlLine(a: 0.34326539204274464d, b: 0.8977537871333662d, c: 0.5614978000020544d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8082484535109626d, b: 0.9381323556046991d, c: 0.19032505416955214d), new NpgsqlTypes.NpgsqlLine(a: 0.12309423454332602d, b: 0.628405637404759d, c: 0.29716824139801623d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.23754520498385934d, b: 0.9446598455327971d, c: 0.08611341053941957d), new NpgsqlTypes.NpgsqlLine(a: 0.14592466116349545d, b: 0.5792145494172548d, c: 0.2222438340031554d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.18670000874205317d, b: 0.7083176141309736d, c: 0.7205914230364386d), new NpgsqlTypes.NpgsqlLine(a: 0.5687265615059292d, b: 0.735209584370226d, c: 0.6608830051825338d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.17559358611166476d, b: 0.8084992474480286d, c: 0.6011060922982528d), new NpgsqlTypes.NpgsqlLine(a: 0.982109118788122d, b: 0.47079411228374324d, c: 0.8367935410880797d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3164660064771644d, b: 0.7090386497815946d, c: 0.8763395171670647d), new NpgsqlTypes.NpgsqlLine(a: 0.11009772281550956d, b: 0.670534009285593d, c: 0.8115740585150545d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8752893716199055d, b: 0.07294050444429834d, c: 0.6943808095587337d), new NpgsqlTypes.NpgsqlLine(a: 0.21341869497782406d, b: 0.2513243617121824d, c: 0.5011273366560508d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7432204556243502d, b: 0.8847942255439779d, c: 0.6130174731153079d), new NpgsqlTypes.NpgsqlLine(a: 0.03811086762720339d, b: 0.8152956256607554d, c: 0.622263719082343d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.12092273108776475d, b: 0.6457710150848811d, c: 0.6232974976495557d), new NpgsqlTypes.NpgsqlLine(a: 0.7405138257498916d, b: 0.5379936917787217d, c: 0.9935980268408907d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7107683853228846d, b: 0.6015774567142937d, c: 0.7359279759538186d), new NpgsqlTypes.NpgsqlLine(a: 0.23397501431082268d, b: 0.6789101398939965d, c: 0.16973790924956178d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.949842977108172d, b: 0.7723201962539333d, c: 0.39053162389884755d), new NpgsqlTypes.NpgsqlLine(a: 0.3839442803349469d, b: 0.6110524421620382d, c: 0.8400706273516707d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9915607693690147d, b: 0.5348579153412982d, c: 0.02471117898830899d), new NpgsqlTypes.NpgsqlLine(a: 0.9677036909705314d, b: 0.24341371730173067d, c: 0.3379757654832036d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.18589578484438563d, b: 0.615928221828628d, c: 0.4147971750500543d), new NpgsqlTypes.NpgsqlLine(a: 0.07948264252364934d, b: 0.19811884185287398d, c: 0.9697778834279678d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.21075455117481734d, b: 0.981214725088672d, c: 0.6544226799469851d), new NpgsqlTypes.NpgsqlLine(a: 0.5328081079862227d, b: 0.07135938591043367d, c: 0.8106551783277383d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5571533960417855d, b: 0.584776000448027d, c: 0.5037901077895997d), new NpgsqlTypes.NpgsqlLine(a: 0.7000169006776437d, b: 0.19465773692819965d, c: 0.7279638748197018d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.23747087491694197d, b: 0.1400883162098776d, c: 0.26847509098782063d), new NpgsqlTypes.NpgsqlLine(a: 0.7960320413589596d, b: 0.07731679330281305d, c: 0.6170601662780183d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.04497831439366384d, b: 0.5873026973242156d, c: 0.15221467421200163d), new NpgsqlTypes.NpgsqlLine(a: 0.041681115680133995d, b: 0.5687764088774683d, c: 0.3367672770795961d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.22558011908327436d, b: 0.788324928906668d, c: 0.8690755212807153d), new NpgsqlTypes.NpgsqlLine(a: 0.5507135240787642d, b: 0.15905294354963218d, c: 0.18679649703441226d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.052428254432497656d, b: 0.49103838868756333d, c: 0.017517631085335217d), new NpgsqlTypes.NpgsqlLine(a: 0.827170434451759d, b: 0.9424366178694644d, c: 0.3294463174812551d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.06905170095492197d, b: 0.5490707912156437d, c: 0.1817772528211733d), new NpgsqlTypes.NpgsqlLine(a: 0.7214010095623715d, b: 0.17560235654561362d, c: 0.8029010936541703d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8140487812441667d, b: 0.7762143177951596d, c: 0.013734487281791607d), new NpgsqlTypes.NpgsqlLine(a: 0.3697350257200661d, b: 0.36402032399778317d, c: 0.9992564590455126d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.10349746770173629d, b: 0.36986033060490464d, c: 0.4045923747774196d), new NpgsqlTypes.NpgsqlLine(a: 0.7682279593317601d, b: 0.48726957841736596d, c: 0.6833238817760049d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.13879138643699052d, b: 0.8079564480103363d, c: 0.49579674037419696d), new NpgsqlTypes.NpgsqlLine(a: 0.7695425483648402d, b: 0.8679411288697476d, c: 0.3896128235396744d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9693707522966045d, b: 0.806294528089762d, c: 0.5175235049330864d), new NpgsqlTypes.NpgsqlLine(a: 0.20239474524384105d, b: 0.20799391528483857d, c: 0.5484564238452507d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2498366312240785d, b: 0.9330786526974062d, c: 0.5515999715983472d), new NpgsqlTypes.NpgsqlLine(a: 0.1708774886088822d, b: 0.9122786440711681d, c: 0.7974302296424259d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5647993332758187d, b: 0.2503397298761577d, c: 0.033300800791732366d), new NpgsqlTypes.NpgsqlLine(a: 0.5911993095298992d, b: 0.7085985602800837d, c: 0.09910154809679694d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7177197235128844d, b: 0.4827936359308016d, c: 0.652227718330121d), new NpgsqlTypes.NpgsqlLine(a: 0.011367235205698933d, b: 0.30459223947606606d, c: 0.8905033015553512d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.33446360786531526d, b: 0.3022638635896905d, c: 0.7156332130619911d), new NpgsqlTypes.NpgsqlLine(a: 0.9172228112045233d, b: 0.23203567914115186d, c: 0.5393154532057041d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9225397325058761d, b: 0.6211956452867144d, c: 0.6242954356196709d), new NpgsqlTypes.NpgsqlLine(a: 0.814977254843135d, b: 0.1281447700276992d, c: 0.7168608129022543d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4822929779117575d, b: 0.5356857568084722d, c: 0.6274768700428759d), new NpgsqlTypes.NpgsqlLine(a: 0.09285203901478256d, b: 0.7534432146209368d, c: 0.19406255713320752d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9752143074119048d, b: 0.535575043567737d, c: 0.836424843215882d), new NpgsqlTypes.NpgsqlLine(a: 0.3017108358076349d, b: 0.45583425561575086d, c: 0.004089682195000055d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8790109553022557d, b: 0.5682126823836549d, c: 0.07590264763045296d), new NpgsqlTypes.NpgsqlLine(a: 0.12039245801037024d, b: 0.6988919469917386d, c: 0.7448236107055675d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8631135330658362d, b: 0.3705166932228996d, c: 0.9046483965551264d), new NpgsqlTypes.NpgsqlLine(a: 0.06515983927997793d, b: 0.9303233970659637d, c: 0.08834929358320864d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8016443323497628d, b: 0.08734368462045805d, c: 0.9989166718676481d), new NpgsqlTypes.NpgsqlLine(a: 0.3168954941862213d, b: 0.6839264946455276d, c: 0.9575974595848522d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8945425603911675d, b: 0.8190998407130524d, c: 0.5495233537573898d), new NpgsqlTypes.NpgsqlLine(a: 0.8192772871436242d, b: 0.2897778945240451d, c: 0.9840282152240111d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4965378486557904d, b: 0.5536443492635221d, c: 0.32750688213859014d), new NpgsqlTypes.NpgsqlLine(a: 0.09232053733932388d, b: 0.08692391249047315d, c: 0.10373205298634824d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 180,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.14714166857295785d, b: 0.21616262137900044d, c: 0.13409743050323908d), new NpgsqlTypes.NpgsqlLine(a: 0.16457910802265152d, b: 0.1910740139696081d, c: 0.5166405124280342d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8322080190137443d, b: 0.5277667611547017d, c: 0.968741587931263d), new NpgsqlTypes.NpgsqlLine(a: 0.1852445200299222d, b: 0.43700916493289244d, c: 0.9068840268076057d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5035061894411076d, b: 0.5804374608941617d, c: 0.0007506161194903438d), new NpgsqlTypes.NpgsqlLine(a: 0.4723793793319091d, b: 0.18417636049365838d, c: 0.10443871516228742d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9980159999830184d, b: 0.20644431354623904d, c: 0.8450887623431341d), new NpgsqlTypes.NpgsqlLine(a: 0.45808680242893074d, b: 0.4279915959008225d, c: 0.7603282323395256d), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
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

                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3792583702769049d, b: 0.40991180826819795d, c: 0.1255907889610347d), new NpgsqlTypes.NpgsqlLine(a: 0.5499010960354305d, b: 0.38156597312756957d, c: 0.5741159990431023d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.23580346575033784d, b: 0.5197241546343243d, c: 0.6789035074596884d), new NpgsqlTypes.NpgsqlLine(a: 0.8534484110983438d, b: 0.38442639939965584d, c: 0.8280011583133265d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.011437892318141074d, b: 0.6708009072824934d, c: 0.9764219973897404d), new NpgsqlTypes.NpgsqlLine(a: 0.8684498605744952d, b: 0.21174139704598482d, c: 0.5951223343468497d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6662052243836425d, b: 0.7532190544766868d, c: 0.005951440977899791d), new NpgsqlTypes.NpgsqlLine(a: 0.8512294354667632d, b: 0.8435805662332638d, c: 0.5828563115673983d), }, }));
                nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.004196647279296917d, b: 0.42422767004115725d, c: 0.3829278461163701d), new NpgsqlTypes.NpgsqlLine(a: 0.19565623698195378d, b: 0.239520619993835d, c: 0.030510877669834402d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.45130296496114775d, b: 0.38173545570393963d, c: 0.1394422761230084d), new NpgsqlTypes.NpgsqlLine(a: 0.5621773658683658d, b: 0.6272552067900157d, c: 0.01935272196124571d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD2E1M> models = null;

                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD2E1M> models = null;

                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 47;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 88;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 157;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 142, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 131, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 56, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 150, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 142, query1, 142, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 150, query1, 49, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 140, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 157, query1, 140, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 169, 102))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 124, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineMArraylineMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineMArraylineMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 102);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineMArraylineMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineMArraylineMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 169);
                var models =  ((INpgsqlLineMArraylineMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
FROM public.binary_npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.binary_npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models =  ((INpgsqlLineMArraylineMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI), typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

