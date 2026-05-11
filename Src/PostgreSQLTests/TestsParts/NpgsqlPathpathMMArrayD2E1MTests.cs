

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
    internal partial interface INpgsqlPathMArraypathMMArrayD2
    {
    }
    
    internal partial class NpgsqlPathMArraypathMMArrayD2 : INpgsqlPathMArraypathMMArrayD2
    {


#region TestData

        private readonly NpgsqlPathpathMMArrayD2E1M[] _testData = new NpgsqlPathpathMMArrayD2E1M[]
        {
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5862285234001061d, y: 0.8838829762105123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7717430348687137d, y: 0.8865425371605392d), new NpgsqlTypes.NpgsqlPoint(x: 0.41375325291228937d, y: 0.5263964952341151d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40637263213741104d, y: 0.7337210772412117d), new NpgsqlTypes.NpgsqlPoint(x: 0.22988418994066195d, y: 0.09077268181567921d), new NpgsqlTypes.NpgsqlPoint(x: 0.2920514412033124d, y: 0.9380038615527493d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7733825995266087d, y: 0.8583437698122018d), new NpgsqlTypes.NpgsqlPoint(x: 0.620451776697603d, y: 0.44299293934217465d), new NpgsqlTypes.NpgsqlPoint(x: 0.4759854738605649d, y: 0.41245102080453333d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1169375383197433d, y: 0.39695864145488224d), new NpgsqlTypes.NpgsqlPoint(x: 0.9975450634900915d, y: 0.19483109272921106d), new NpgsqlTypes.NpgsqlPoint(x: 0.17026494623780997d, y: 0.8779277544178147d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39870944531206165d, y: 0.9972348647437362d), new NpgsqlTypes.NpgsqlPoint(x: 0.3825368615589402d, y: 0.9701602082329899d), new NpgsqlTypes.NpgsqlPoint(x: 0.447142273531941d, y: 0.26072836659497955d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1512268195526053d, y: 0.6627356973994011d), new NpgsqlTypes.NpgsqlPoint(x: 0.5737788868317466d, y: 0.5262979584227663d), new NpgsqlTypes.NpgsqlPoint(x: 0.9043307121206152d, y: 0.12020535534914378d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.802797724535675d, y: 0.7259005137033002d), new NpgsqlTypes.NpgsqlPoint(x: 0.0704939589127569d, y: 0.5323272766121142d), new NpgsqlTypes.NpgsqlPoint(x: 0.24325222582132855d, y: 0.5542770993468678d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9166035766443443d, y: 0.03858880408278831d), new NpgsqlTypes.NpgsqlPoint(x: 0.9472606264839892d, y: 0.5838110682548896d), new NpgsqlTypes.NpgsqlPoint(x: 0.519560731148312d, y: 0.09099057334546845d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11506940676336763d, y: 0.9524737502299077d), new NpgsqlTypes.NpgsqlPoint(x: 0.48867853966482877d, y: 0.6257128350312903d), new NpgsqlTypes.NpgsqlPoint(x: 0.18098058522837157d, y: 0.49652764982116826d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20397969164828889d, y: 0.8627691876525946d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658866606002319d, y: 0.8766739740175991d), new NpgsqlTypes.NpgsqlPoint(x: 0.292275430139888d, y: 0.8699246221668846d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5952024374503743d, y: 0.2650830760670738d), new NpgsqlTypes.NpgsqlPoint(x: 0.8770064948564426d, y: 0.27749642289581256d), new NpgsqlTypes.NpgsqlPoint(x: 0.27714303336715485d, y: 0.6641287063620301d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32858306903041d, y: 0.5912550272268038d), new NpgsqlTypes.NpgsqlPoint(x: 0.7675122972183687d, y: 0.27998321192805653d), new NpgsqlTypes.NpgsqlPoint(x: 0.9382882337416261d, y: 0.722030994603551d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5560371734762595d, y: 0.6554788290738643d), new NpgsqlTypes.NpgsqlPoint(x: 0.05957435756218854d, y: 0.7464744289054297d), new NpgsqlTypes.NpgsqlPoint(x: 0.6076588814851529d, y: 0.9468142106408332d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14070472980532034d, y: 0.19727813438173158d), new NpgsqlTypes.NpgsqlPoint(x: 0.665204773023215d, y: 0.10101216760923093d), new NpgsqlTypes.NpgsqlPoint(x: 0.24516023221934824d, y: 0.9838425915598432d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008077605265061849d, y: 0.14194269986926267d), new NpgsqlTypes.NpgsqlPoint(x: 0.98953210393d, y: 0.3548682563030474d), new NpgsqlTypes.NpgsqlPoint(x: 0.3700724525603757d, y: 0.4559628887792453d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6139087119485217d, y: 0.5591353819993521d), new NpgsqlTypes.NpgsqlPoint(x: 0.9082263825407461d, y: 0.6273599826345326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5877767322179857d, y: 0.13789044751140533d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28624722421800364d, y: 0.6911596021810632d), new NpgsqlTypes.NpgsqlPoint(x: 0.22674978294093162d, y: 0.41940204820429194d), new NpgsqlTypes.NpgsqlPoint(x: 0.09911230797437165d, y: 0.33377647542465017d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9390015483431695d, y: 0.7202649120125512d), new NpgsqlTypes.NpgsqlPoint(x: 0.9187238469268217d, y: 0.6300172192652342d), new NpgsqlTypes.NpgsqlPoint(x: 0.3543244943260079d, y: 0.010794956927464794d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13041566132307691d, y: 0.5787512362364378d), new NpgsqlTypes.NpgsqlPoint(x: 0.12484040701478316d, y: 0.6869653352822076d), new NpgsqlTypes.NpgsqlPoint(x: 0.44908869576257526d, y: 0.5990019390003001d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42359215990073606d, y: 0.8891335505079134d), new NpgsqlTypes.NpgsqlPoint(x: 0.012202224972233666d, y: 0.8796626571788962d), new NpgsqlTypes.NpgsqlPoint(x: 0.2164386745471346d, y: 0.8306611866391627d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8404881950196619d, y: 0.42708100284684536d), new NpgsqlTypes.NpgsqlPoint(x: 0.4476580922399267d, y: 0.7663593456757903d), new NpgsqlTypes.NpgsqlPoint(x: 0.9087001510374791d, y: 0.5432013466242448d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23513205671311188d, y: 0.10752465169837777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7148645806252226d, y: 0.9733538976267913d), new NpgsqlTypes.NpgsqlPoint(x: 0.6258051418929533d, y: 0.23151918308684694d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.744861216875141d, y: 0.4962833378995216d), new NpgsqlTypes.NpgsqlPoint(x: 0.3513186227380841d, y: 0.305507003649794d), new NpgsqlTypes.NpgsqlPoint(x: 0.8109941536119816d, y: 0.2159686480013432d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9510088350659629d, y: 0.4372430547035603d), new NpgsqlTypes.NpgsqlPoint(x: 0.41204507023794334d, y: 0.12089102624152914d), new NpgsqlTypes.NpgsqlPoint(x: 0.21564335116417577d, y: 0.589413620374879d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07382355987135114d, y: 0.7394261198823946d), new NpgsqlTypes.NpgsqlPoint(x: 0.9267200561249288d, y: 0.40722619976393715d), new NpgsqlTypes.NpgsqlPoint(x: 0.2564071825670423d, y: 0.35538621324202935d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2901608710551391d, y: 0.5777554564392996d), new NpgsqlTypes.NpgsqlPoint(x: 0.9722841101551222d, y: 0.8542116326026578d), new NpgsqlTypes.NpgsqlPoint(x: 0.7576050586299989d, y: 0.29915291264527155d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5442257860692711d, y: 0.5371549877343876d), new NpgsqlTypes.NpgsqlPoint(x: 0.4409394014265904d, y: 0.1857587877578336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5692018387939437d, y: 0.5577574518646542d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6427885674591717d, y: 0.7370838207794851d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025157572725294d, y: 0.6931594882027338d), new NpgsqlTypes.NpgsqlPoint(x: 0.8110483627595891d, y: 0.9478784236817076d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6370482400446417d, y: 0.034188133147240896d), new NpgsqlTypes.NpgsqlPoint(x: 0.022600338884329108d, y: 0.5364676153178363d), new NpgsqlTypes.NpgsqlPoint(x: 0.20866704768990207d, y: 0.0775705710557194d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5782520601732607d, y: 0.25393910136842734d), new NpgsqlTypes.NpgsqlPoint(x: 0.9536293357238028d, y: 0.41035445569045914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5899056899913804d, y: 0.06727078657132335d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.753581502495437d, y: 0.38398847302371164d), new NpgsqlTypes.NpgsqlPoint(x: 0.05737646312694045d, y: 0.8377789302673417d), new NpgsqlTypes.NpgsqlPoint(x: 0.5524435947459961d, y: 0.5324413111723423d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8117877856532528d, y: 0.5079250302718866d), new NpgsqlTypes.NpgsqlPoint(x: 0.07607166104031471d, y: 0.6275003813258971d), new NpgsqlTypes.NpgsqlPoint(x: 0.1848922099982474d, y: 0.6007964911932934d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7090163672977274d, y: 0.8260534898629833d), new NpgsqlTypes.NpgsqlPoint(x: 0.9724030677398937d, y: 0.2741799267466901d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060330152726829d, y: 0.42700289661203306d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.829692814071071d, y: 0.21330739053035086d), new NpgsqlTypes.NpgsqlPoint(x: 0.06815106974284912d, y: 0.8906625338855247d), new NpgsqlTypes.NpgsqlPoint(x: 0.016884110182384005d, y: 0.3418853198469448d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.052913179584191505d, y: 0.44738737520808103d), new NpgsqlTypes.NpgsqlPoint(x: 0.3806641853489827d, y: 0.44157686077941927d), new NpgsqlTypes.NpgsqlPoint(x: 0.20710604258791288d, y: 0.4004032582343965d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28303941653891274d, y: 0.3140303713796716d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712933123217614d, y: 0.30220647498577224d), new NpgsqlTypes.NpgsqlPoint(x: 0.47316548415024773d, y: 0.537450268399862d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2465219018860786d, y: 0.983242372139848d), new NpgsqlTypes.NpgsqlPoint(x: 0.3064357009813503d, y: 0.9502322843933209d), new NpgsqlTypes.NpgsqlPoint(x: 0.326949347747332d, y: 0.06534992040587306d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2945216196256082d, y: 0.5498596385594327d), new NpgsqlTypes.NpgsqlPoint(x: 0.7268869164249954d, y: 0.13692801535188626d), new NpgsqlTypes.NpgsqlPoint(x: 0.7514682986577116d, y: 0.3536149215441099d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04865178281042015d, y: 0.814992617557703d), new NpgsqlTypes.NpgsqlPoint(x: 0.48044641129921595d, y: 0.9021347304830909d), new NpgsqlTypes.NpgsqlPoint(x: 0.031617507535310785d, y: 0.9229802803634143d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48187076469503676d, y: 0.7129913928802483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9519781314373718d, y: 0.2299439650620404d), new NpgsqlTypes.NpgsqlPoint(x: 0.6564805401210975d, y: 0.8648122463774679d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4346624693173009d, y: 0.3112792375532094d), new NpgsqlTypes.NpgsqlPoint(x: 0.45362897910729616d, y: 0.9535430765730554d), new NpgsqlTypes.NpgsqlPoint(x: 0.35335077826675887d, y: 0.4364607055902582d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014922372328996514d, y: 0.0420033249698043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9627733726246003d, y: 0.2957123783217488d), new NpgsqlTypes.NpgsqlPoint(x: 0.15570474261568357d, y: 0.6150396624802444d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10250324772098374d, y: 0.8405642894812956d), new NpgsqlTypes.NpgsqlPoint(x: 0.5510601021257147d, y: 0.5006097154064716d), new NpgsqlTypes.NpgsqlPoint(x: 0.6385833238459874d, y: 0.667264584732596d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4306711977457347d, y: 0.9413162410093632d), new NpgsqlTypes.NpgsqlPoint(x: 0.22404079605754967d, y: 0.7091473933699577d), new NpgsqlTypes.NpgsqlPoint(x: 0.5390801091554704d, y: 0.2991820410640561d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7006783839960274d, y: 0.2880471683592557d), new NpgsqlTypes.NpgsqlPoint(x: 0.1327667323930708d, y: 0.9921083032100934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9298628334918854d, y: 0.23501661168530108d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4237722028613138d, y: 0.9430983424365517d), new NpgsqlTypes.NpgsqlPoint(x: 0.9000260716942607d, y: 0.6705644772987008d), new NpgsqlTypes.NpgsqlPoint(x: 0.7473478516078848d, y: 0.5129155010027965d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46626390320018907d, y: 0.9604964165072397d), new NpgsqlTypes.NpgsqlPoint(x: 0.15581200119609495d, y: 0.6146693997709768d), new NpgsqlTypes.NpgsqlPoint(x: 0.5294049754232876d, y: 0.8633041155420823d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8586050736078942d, y: 0.2958037366248023d), new NpgsqlTypes.NpgsqlPoint(x: 0.5626115897550695d, y: 0.0486144196398941d), new NpgsqlTypes.NpgsqlPoint(x: 0.0239051914962648d, y: 0.6587420538631195d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08510795408984195d, y: 0.10050305886111743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9843219074723794d, y: 0.4777193845302238d), new NpgsqlTypes.NpgsqlPoint(x: 0.5134282429730741d, y: 0.9759544326365592d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33092415678579035d, y: 0.8078935146295034d), new NpgsqlTypes.NpgsqlPoint(x: 0.321829747007885d, y: 0.9924554353679464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7788847535167797d, y: 0.135602178380142d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9247507869555006d, y: 0.8782259986768918d), new NpgsqlTypes.NpgsqlPoint(x: 0.10612207928362094d, y: 0.25179172838710906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7684249102084397d, y: 0.8894860412121087d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5444404904407529d, y: 0.6532579144306532d), new NpgsqlTypes.NpgsqlPoint(x: 0.2646800634687646d, y: 0.03377867790697209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5340012626585482d, y: 0.6591464347806464d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5344895554444519d, y: 0.7732483132386953d), new NpgsqlTypes.NpgsqlPoint(x: 0.4838416430495125d, y: 0.2820891023017926d), new NpgsqlTypes.NpgsqlPoint(x: 0.857524490642359d, y: 0.836930144295744d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46545788633315843d, y: 0.8465367632757492d), new NpgsqlTypes.NpgsqlPoint(x: 0.20805641701671207d, y: 0.5506672101665724d), new NpgsqlTypes.NpgsqlPoint(x: 0.1629180537977637d, y: 0.32130638166691705d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1836818173659691d, y: 0.013206240853426143d), new NpgsqlTypes.NpgsqlPoint(x: 0.6265225443520759d, y: 0.12117532185767421d), new NpgsqlTypes.NpgsqlPoint(x: 0.8493023640748747d, y: 0.764000089331655d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9544761268312439d, y: 0.0742113139522802d), new NpgsqlTypes.NpgsqlPoint(x: 0.9464333840987096d, y: 0.09968536205058287d), new NpgsqlTypes.NpgsqlPoint(x: 0.1815021574176786d, y: 0.9225754982428682d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4542710188522272d, y: 0.20355840455952823d), new NpgsqlTypes.NpgsqlPoint(x: 0.49886573343053653d, y: 0.7264710980573915d), new NpgsqlTypes.NpgsqlPoint(x: 0.26951604871199386d, y: 0.10137636876567846d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9277693253765532d, y: 0.3922780006953114d), new NpgsqlTypes.NpgsqlPoint(x: 0.6004163243188496d, y: 0.2794992156996483d), new NpgsqlTypes.NpgsqlPoint(x: 0.12282394600635616d, y: 0.8792682822255627d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9245140960973646d, y: 0.13788284368124548d), new NpgsqlTypes.NpgsqlPoint(x: 0.336168918598842d, y: 0.5238176989449195d), new NpgsqlTypes.NpgsqlPoint(x: 0.20394950812923385d, y: 0.8117132677733674d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9124384296302926d, y: 0.6102837620887118d), new NpgsqlTypes.NpgsqlPoint(x: 0.7239843523481762d, y: 0.5647258549203098d), new NpgsqlTypes.NpgsqlPoint(x: 0.23520563510192816d, y: 0.7247649079669108d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6352792665754926d, y: 0.26763249667585254d), new NpgsqlTypes.NpgsqlPoint(x: 0.29295897863255715d, y: 0.27505231931557206d), new NpgsqlTypes.NpgsqlPoint(x: 0.45381483955444135d, y: 0.05412497645150771d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7628805098885701d, y: 0.13651437455556803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7840091679909833d, y: 0.157608564652173d), new NpgsqlTypes.NpgsqlPoint(x: 0.4633637808092008d, y: 0.4167485512932003d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8542829416771422d, y: 0.5171176110328979d), new NpgsqlTypes.NpgsqlPoint(x: 0.37018302013949345d, y: 0.9744926307726954d), new NpgsqlTypes.NpgsqlPoint(x: 0.020554167935418977d, y: 0.3114886702015579d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2792620205644163d, y: 0.2800723095873786d), new NpgsqlTypes.NpgsqlPoint(x: 0.18813764613698192d, y: 0.5233455783823133d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361035189756655d, y: 0.22614830938668318d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6376773557306937d, y: 0.028471309033391456d), new NpgsqlTypes.NpgsqlPoint(x: 0.2713282304888337d, y: 0.7752156852610866d), new NpgsqlTypes.NpgsqlPoint(x: 0.8427040532869415d, y: 0.5969277129712555d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7633591411034484d, y: 0.7843966679898844d), new NpgsqlTypes.NpgsqlPoint(x: 0.44848218454189215d, y: 0.46837138145328194d), new NpgsqlTypes.NpgsqlPoint(x: 0.8544567618157491d, y: 0.5632993369349596d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6410110384242529d, y: 0.007134912318102482d), new NpgsqlTypes.NpgsqlPoint(x: 0.8730935635644118d, y: 0.03297843625967378d), new NpgsqlTypes.NpgsqlPoint(x: 0.7840057620692097d, y: 0.622333387469246d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3254469549793739d, y: 0.42744853353383927d), new NpgsqlTypes.NpgsqlPoint(x: 0.5234220196994107d, y: 0.3876287037904953d), new NpgsqlTypes.NpgsqlPoint(x: 0.6057417077691726d, y: 0.724692694871936d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38584512923352177d, y: 0.7194027047234777d), new NpgsqlTypes.NpgsqlPoint(x: 0.43144234833237505d, y: 0.8901012132629907d), new NpgsqlTypes.NpgsqlPoint(x: 0.4309746877109495d, y: 0.9785653709758656d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9506588646049284d, y: 0.33013622404982623d), new NpgsqlTypes.NpgsqlPoint(x: 0.6371149667957281d, y: 0.9410043674712238d), new NpgsqlTypes.NpgsqlPoint(x: 0.24203551742637008d, y: 0.49611059834621973d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3768311381450298d, y: 0.5591622096598956d), new NpgsqlTypes.NpgsqlPoint(x: 0.27200894086909555d, y: 0.7959810126923239d), new NpgsqlTypes.NpgsqlPoint(x: 0.7645794162429389d, y: 0.056220923349839746d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37260762935714276d, y: 0.6243842305840716d), new NpgsqlTypes.NpgsqlPoint(x: 0.7088544167915725d, y: 0.9808626589650956d), new NpgsqlTypes.NpgsqlPoint(x: 0.9365426673119741d, y: 0.8282880042236082d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9224297154112173d, y: 0.8801763145946948d), new NpgsqlTypes.NpgsqlPoint(x: 0.32005277974437274d, y: 0.5716291300422754d), new NpgsqlTypes.NpgsqlPoint(x: 0.08830658932502433d, y: 0.6879446464034521d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5146452732353592d, y: 0.46028522972637753d), new NpgsqlTypes.NpgsqlPoint(x: 0.39758071800573636d, y: 0.6784974239067204d), new NpgsqlTypes.NpgsqlPoint(x: 0.046650026811831946d, y: 0.32523708036301513d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5292694153828522d, y: 0.5061964478161636d), new NpgsqlTypes.NpgsqlPoint(x: 0.9053621536931733d, y: 0.2028906678404493d), new NpgsqlTypes.NpgsqlPoint(x: 0.7094273906436811d, y: 0.9903342687967561d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6134373329657726d, y: 0.164115060651837d), new NpgsqlTypes.NpgsqlPoint(x: 0.34026428683197885d, y: 0.49223118224244267d), new NpgsqlTypes.NpgsqlPoint(x: 0.5844631272094151d, y: 0.9211873785013499d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14065392121387044d, y: 0.37736840851756603d), new NpgsqlTypes.NpgsqlPoint(x: 0.420787902674875d, y: 0.9770540632910767d), new NpgsqlTypes.NpgsqlPoint(x: 0.55491242669604d, y: 0.15738154509186075d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9974920677827209d, y: 0.5677306224645379d), new NpgsqlTypes.NpgsqlPoint(x: 0.06096916096316185d, y: 0.4723997329430426d), new NpgsqlTypes.NpgsqlPoint(x: 0.5301201087020931d, y: 0.8835924378978968d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23807316796186329d, y: 0.03879056073140397d), new NpgsqlTypes.NpgsqlPoint(x: 0.9363065014461159d, y: 0.9787961018312179d), new NpgsqlTypes.NpgsqlPoint(x: 0.543768724765232d, y: 0.37035601733592816d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.943179496406314d, y: 0.9937192956654772d), new NpgsqlTypes.NpgsqlPoint(x: 0.8952384208772332d, y: 0.5832173662237112d), new NpgsqlTypes.NpgsqlPoint(x: 0.13974979165807466d, y: 0.5062946641277113d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07329506214459869d, y: 0.600247282850362d), new NpgsqlTypes.NpgsqlPoint(x: 0.5024237289575771d, y: 0.7624341741688851d), new NpgsqlTypes.NpgsqlPoint(x: 0.06574543559154078d, y: 0.5235303183449078d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6960442485964788d, y: 0.21975942127312764d), new NpgsqlTypes.NpgsqlPoint(x: 0.9343674640658712d, y: 0.2656857591710442d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495573582098245d, y: 0.6860207031539072d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.826456321491012d, y: 0.050527414302219076d), new NpgsqlTypes.NpgsqlPoint(x: 0.8659879619210334d, y: 0.3977722701498203d), new NpgsqlTypes.NpgsqlPoint(x: 0.21746589204004152d, y: 0.5112780035821937d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5662215156515601d, y: 0.8193205693200741d), new NpgsqlTypes.NpgsqlPoint(x: 0.13461960618371294d, y: 0.24065549561532773d), new NpgsqlTypes.NpgsqlPoint(x: 0.7695981541566097d, y: 0.28176859160367895d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07711449789841618d, y: 0.33209041855811716d), new NpgsqlTypes.NpgsqlPoint(x: 0.07708075971146366d, y: 0.6370614532652621d), new NpgsqlTypes.NpgsqlPoint(x: 0.5482598052165151d, y: 0.31188248020624876d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34445307150949445d, y: 0.73623538884202d), new NpgsqlTypes.NpgsqlPoint(x: 0.967032114677046d, y: 0.06100016152346488d), new NpgsqlTypes.NpgsqlPoint(x: 0.4348885849429185d, y: 0.34734027742799345d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4052899008279207d, y: 0.9772201480227364d), new NpgsqlTypes.NpgsqlPoint(x: 0.8168440784444756d, y: 0.20555565487590177d), new NpgsqlTypes.NpgsqlPoint(x: 0.6222617486611468d, y: 0.7973175554778911d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4831258436359209d, y: 0.6171426159573513d), new NpgsqlTypes.NpgsqlPoint(x: 0.14164150028733025d, y: 0.13306506836307053d), new NpgsqlTypes.NpgsqlPoint(x: 0.293589589965099d, y: 0.11644933740700592d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2566269552557704d, y: 0.42765020828857125d), new NpgsqlTypes.NpgsqlPoint(x: 0.7197985518401109d, y: 0.6279678313136418d), new NpgsqlTypes.NpgsqlPoint(x: 0.03365722813329097d, y: 0.2023640735639164d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9358284482735276d, y: 0.3767785902106163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7297444477259281d, y: 0.7938658671743073d), new NpgsqlTypes.NpgsqlPoint(x: 0.8387449816908247d, y: 0.7735663179432484d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.699937850982847d, y: 0.9912829731795254d), new NpgsqlTypes.NpgsqlPoint(x: 0.36567477178903984d, y: 0.5351958459518598d), new NpgsqlTypes.NpgsqlPoint(x: 0.4967652355557255d, y: 0.4324019546385369d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17235686378516946d, y: 0.14404356356447112d), new NpgsqlTypes.NpgsqlPoint(x: 0.22226376624348698d, y: 0.8602958418353933d), new NpgsqlTypes.NpgsqlPoint(x: 0.7213445097404716d, y: 0.9472820067734119d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46575475930829613d, y: 0.19408667239518862d), new NpgsqlTypes.NpgsqlPoint(x: 0.6972944201519364d, y: 0.32793970006429474d), new NpgsqlTypes.NpgsqlPoint(x: 0.13455092855143547d, y: 0.007769727915476032d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5272081065181018d, y: 0.42947913419512185d), new NpgsqlTypes.NpgsqlPoint(x: 0.7344104912447175d, y: 0.9498846427829476d), new NpgsqlTypes.NpgsqlPoint(x: 0.06837109803429686d, y: 0.6906732688545276d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5181232332455648d, y: 0.8288484362187382d), new NpgsqlTypes.NpgsqlPoint(x: 0.7835761125281574d, y: 0.26979086571068833d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836608554454579d, y: 0.03213705156257385d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11947575149710887d, y: 0.03066016825888973d), new NpgsqlTypes.NpgsqlPoint(x: 0.36833506009782047d, y: 0.3080457931184216d), new NpgsqlTypes.NpgsqlPoint(x: 0.6484369176480158d, y: 0.3730893003364123d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0763828669772516d, y: 0.8063795053583996d), new NpgsqlTypes.NpgsqlPoint(x: 0.6953852530400884d, y: 0.8642438848953533d), new NpgsqlTypes.NpgsqlPoint(x: 0.010067362864519147d, y: 0.4266193938911129d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8833837134123961d, y: 0.0023119413433069225d), new NpgsqlTypes.NpgsqlPoint(x: 0.22515628968075008d, y: 0.7426914093436006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7882709135506429d, y: 0.8889580580615393d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1996102362921487d, y: 0.4423950798152759d), new NpgsqlTypes.NpgsqlPoint(x: 0.4975058966719965d, y: 0.3474359756000397d), new NpgsqlTypes.NpgsqlPoint(x: 0.26788385858653063d, y: 0.3329353220972955d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21077676184714622d, y: 0.11112707046263037d), new NpgsqlTypes.NpgsqlPoint(x: 0.4277169455986024d, y: 0.7036357305315009d), new NpgsqlTypes.NpgsqlPoint(x: 0.6805506344816239d, y: 0.7435409334456498d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44376544658331996d, y: 0.3033570785608122d), new NpgsqlTypes.NpgsqlPoint(x: 0.1326458400327305d, y: 0.11490301298662298d), new NpgsqlTypes.NpgsqlPoint(x: 0.4336873547571497d, y: 0.12392579980303187d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7088656444288814d, y: 0.15261203030497594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8473442340753088d, y: 0.1945176322637786d), new NpgsqlTypes.NpgsqlPoint(x: 0.31514311166241604d, y: 0.387222917506288d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6261650705208471d, y: 0.8374373019579409d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166624080561813d, y: 0.8504960995300488d), new NpgsqlTypes.NpgsqlPoint(x: 0.9531976383233284d, y: 0.09327931512938725d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19314809679892464d, y: 0.06455162221955613d), new NpgsqlTypes.NpgsqlPoint(x: 0.6865223983419408d, y: 0.9530736196341969d), new NpgsqlTypes.NpgsqlPoint(x: 0.5705155161190147d, y: 0.9604774740559431d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2867937630787575d, y: 0.8343246155206318d), new NpgsqlTypes.NpgsqlPoint(x: 0.952527363818964d, y: 0.891070956094825d), new NpgsqlTypes.NpgsqlPoint(x: 0.3038481206303576d, y: 0.6733647483835122d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9418262818321759d, y: 0.18578362109918378d), new NpgsqlTypes.NpgsqlPoint(x: 0.9008319775383041d, y: 0.8918166605842911d), new NpgsqlTypes.NpgsqlPoint(x: 0.03847282874877056d, y: 0.7915185101015847d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6900563604897886d, y: 0.6242189887239832d), new NpgsqlTypes.NpgsqlPoint(x: 0.7271245123778682d, y: 0.2403513215400528d), new NpgsqlTypes.NpgsqlPoint(x: 0.3961684389302581d, y: 0.041213514880643176d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6962676958278345d, y: 0.9343616776943573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5245089483626011d, y: 0.9335056424519464d), new NpgsqlTypes.NpgsqlPoint(x: 0.10827900426601322d, y: 0.3680101217455801d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2952867202832671d, y: 0.984519109896513d), new NpgsqlTypes.NpgsqlPoint(x: 0.3238843744359491d, y: 0.13246559151763038d), new NpgsqlTypes.NpgsqlPoint(x: 0.009655956379272745d, y: 0.40258362559446403d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9781236071300853d, y: 0.9266756017536228d), new NpgsqlTypes.NpgsqlPoint(x: 0.5691981206675197d, y: 0.6499354982402913d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024639293179066213d, y: 0.644778510435208d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8465477371928403d, y: 0.3296925498118961d), new NpgsqlTypes.NpgsqlPoint(x: 0.4442167663179115d, y: 0.2290395687756408d), new NpgsqlTypes.NpgsqlPoint(x: 0.7402580786733184d, y: 0.19468550795005202d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5608523619120969d, y: 0.5543215785133653d), new NpgsqlTypes.NpgsqlPoint(x: 0.08795866540577513d, y: 0.19477353318133295d), new NpgsqlTypes.NpgsqlPoint(x: 0.4689523479495966d, y: 0.2368645707326037d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20731055649672137d, y: 0.8957154688901185d), new NpgsqlTypes.NpgsqlPoint(x: 0.4133337508829956d, y: 0.379342623555442d), new NpgsqlTypes.NpgsqlPoint(x: 0.42900780716781706d, y: 0.5706492235793175d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8622442946078254d, y: 0.9833402555160092d), new NpgsqlTypes.NpgsqlPoint(x: 0.39831369435164743d, y: 0.722814101685011d), new NpgsqlTypes.NpgsqlPoint(x: 0.7086776857919145d, y: 0.11252073735934665d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10218937250877358d, y: 0.7981247181165266d), new NpgsqlTypes.NpgsqlPoint(x: 0.584584509832194d, y: 0.11600901277278675d), new NpgsqlTypes.NpgsqlPoint(x: 0.31081203958694703d, y: 0.06873669393574644d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4875675622949449d, y: 0.20996799096723218d), new NpgsqlTypes.NpgsqlPoint(x: 0.9996113559974585d, y: 0.9018617265360853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5748860914677312d, y: 0.48284658960050064d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46506070689098544d, y: 0.011560489665340179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9546336322113529d, y: 0.7566817645526128d), new NpgsqlTypes.NpgsqlPoint(x: 0.40938176293132156d, y: 0.48892413838195614d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37555548121240856d, y: 0.9511703476960981d), new NpgsqlTypes.NpgsqlPoint(x: 0.17513552203611127d, y: 0.4625918533982222d), new NpgsqlTypes.NpgsqlPoint(x: 0.2042664000639699d, y: 0.37426162675237773d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8733390277270134d, y: 0.7948443512976876d), new NpgsqlTypes.NpgsqlPoint(x: 0.6086717074985493d, y: 0.8619096614793863d), new NpgsqlTypes.NpgsqlPoint(x: 0.8717608537610253d, y: 0.31658819977163655d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6042818984625554d, y: 0.5846364529694511d), new NpgsqlTypes.NpgsqlPoint(x: 0.2039809438013569d, y: 0.17182790146445182d), new NpgsqlTypes.NpgsqlPoint(x: 0.9256304145417767d, y: 0.9039486575897376d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1480518034210978d, y: 0.30493778246341563d), new NpgsqlTypes.NpgsqlPoint(x: 0.32670761901738077d, y: 0.42830564539562455d), new NpgsqlTypes.NpgsqlPoint(x: 0.07603243795734371d, y: 0.5159587225740934d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07101321685086748d, y: 0.07360617049504747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936475356507784d, y: 0.9866130009376488d), new NpgsqlTypes.NpgsqlPoint(x: 0.6047162294790819d, y: 0.24414738475771414d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48195325246569565d, y: 0.22941786826980726d), new NpgsqlTypes.NpgsqlPoint(x: 0.9226696516733173d, y: 0.12757998172998253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304321601070772d, y: 0.6645870924553218d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11856381119889292d, y: 0.8816763553660159d), new NpgsqlTypes.NpgsqlPoint(x: 0.38571202590782117d, y: 0.7079809629304954d), new NpgsqlTypes.NpgsqlPoint(x: 0.4437827311971737d, y: 0.07125640267237443d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3511604248192477d, y: 0.14744988910965962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4739285090358898d, y: 0.4131523200976792d), new NpgsqlTypes.NpgsqlPoint(x: 0.03687642819749004d, y: 0.4319134695714626d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16257171926934244d, y: 0.1330224184607539d), new NpgsqlTypes.NpgsqlPoint(x: 0.7791473710282856d, y: 0.03817298968329119d), new NpgsqlTypes.NpgsqlPoint(x: 0.35691235560507295d, y: 0.7251594015474049d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4851831346577319d, y: 0.9770132863975747d), new NpgsqlTypes.NpgsqlPoint(x: 0.9157620279235006d, y: 0.395991581939264d), new NpgsqlTypes.NpgsqlPoint(x: 0.3558482817614017d, y: 0.6741056220990546d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9958161640379422d, y: 0.5544464814852931d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194329838187608d, y: 0.057809926039535164d), new NpgsqlTypes.NpgsqlPoint(x: 0.032945514183182145d, y: 0.31012448909116774d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38336266087875337d, y: 0.5045799698380999d), new NpgsqlTypes.NpgsqlPoint(x: 0.07916172483217543d, y: 0.37506134021451354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9203937781591202d, y: 0.8649452880330076d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13021159622815592d, y: 0.1390292986467866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5145463383889305d, y: 0.8271431904916449d), new NpgsqlTypes.NpgsqlPoint(x: 0.6415521037191495d, y: 0.8399040350582339d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4558555157023215d, y: 0.6609217351752177d), new NpgsqlTypes.NpgsqlPoint(x: 0.7221966774688054d, y: 0.4479874271777733d), new NpgsqlTypes.NpgsqlPoint(x: 0.017920603791985457d, y: 0.5179280701783351d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3522405437240076d, y: 0.8625635378972655d), new NpgsqlTypes.NpgsqlPoint(x: 0.7395347220331137d, y: 0.0088715164192682d), new NpgsqlTypes.NpgsqlPoint(x: 0.39790780702433204d, y: 0.5593516371073946d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7356154245459642d, y: 0.0015804737934209667d), new NpgsqlTypes.NpgsqlPoint(x: 0.41918163644622863d, y: 0.5817061461082899d), new NpgsqlTypes.NpgsqlPoint(x: 0.6758538278219755d, y: 0.14319687331740194d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6382469953502006d, y: 0.01359029626788455d), new NpgsqlTypes.NpgsqlPoint(x: 0.980681655756d, y: 0.028235240072951973d), new NpgsqlTypes.NpgsqlPoint(x: 0.05654724215296747d, y: 0.32539820938822583d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9803946260104874d, y: 0.9367112104160314d), new NpgsqlTypes.NpgsqlPoint(x: 0.11602787476199972d, y: 0.1575179550132182d), new NpgsqlTypes.NpgsqlPoint(x: 0.6807518060644239d, y: 0.8284841954020367d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5183895504246465d, y: 0.1712115752280754d), new NpgsqlTypes.NpgsqlPoint(x: 0.9709931076350989d, y: 0.4665081606942654d), new NpgsqlTypes.NpgsqlPoint(x: 0.801464793620215d, y: 0.7580479368457447d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13183740286154966d, y: 0.6299028553740353d), new NpgsqlTypes.NpgsqlPoint(x: 0.44707874175285134d, y: 0.7879186120073813d), new NpgsqlTypes.NpgsqlPoint(x: 0.3434605833200074d, y: 0.18889197852887607d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8630808156914589d, y: 0.019845515648817647d), new NpgsqlTypes.NpgsqlPoint(x: 0.0255107603482726d, y: 0.44326834447078234d), new NpgsqlTypes.NpgsqlPoint(x: 0.36647124465258396d, y: 0.3038895973587301d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34549381977030447d, y: 0.879868078887207d), new NpgsqlTypes.NpgsqlPoint(x: 0.8548059167202291d, y: 0.12326315028295931d), new NpgsqlTypes.NpgsqlPoint(x: 0.9487716949853562d, y: 0.27841724084640374d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9072911365058802d, y: 0.7293061354503722d), new NpgsqlTypes.NpgsqlPoint(x: 0.19776854433801205d, y: 0.5497389123511344d), new NpgsqlTypes.NpgsqlPoint(x: 0.5368936553537971d, y: 0.6488519325200485d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.467511466546949d, y: 0.6035289166054716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8263166866517243d, y: 0.7920935816899672d), new NpgsqlTypes.NpgsqlPoint(x: 0.9746766487828089d, y: 0.7186551551313105d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2867599391102422d, y: 0.9322536554285695d), new NpgsqlTypes.NpgsqlPoint(x: 0.8653886545664656d, y: 0.7487720701787354d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470582181028595d, y: 0.7895091157713473d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6406625152073837d, y: 0.7962349513003926d), new NpgsqlTypes.NpgsqlPoint(x: 0.590690916056475d, y: 0.012551933962415052d), new NpgsqlTypes.NpgsqlPoint(x: 0.09807507909125668d, y: 0.0032561431685835807d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20905445279240853d, y: 0.06426741817601067d), new NpgsqlTypes.NpgsqlPoint(x: 0.41034470595069994d, y: 0.29862462543670776d), new NpgsqlTypes.NpgsqlPoint(x: 0.7077752702292855d, y: 0.2727208716698055d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26964807666355595d, y: 0.7359283954079214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8397358462749458d, y: 0.523956165143781d), new NpgsqlTypes.NpgsqlPoint(x: 0.9408071598596623d, y: 0.41857235067347354d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.792083216540332d, y: 0.3504495219633955d), new NpgsqlTypes.NpgsqlPoint(x: 0.530073828824889d, y: 0.10707667970105139d), new NpgsqlTypes.NpgsqlPoint(x: 0.9923841911606082d, y: 0.2650507462918016d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04051391788120162d, y: 0.4656909298037287d), new NpgsqlTypes.NpgsqlPoint(x: 0.7702305425252488d, y: 0.6163188312151794d), new NpgsqlTypes.NpgsqlPoint(x: 0.45399898657587234d, y: 0.8094392922264179d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7331571360571003d, y: 0.8380838166655076d), new NpgsqlTypes.NpgsqlPoint(x: 0.32878143998426257d, y: 0.09070587421466958d), new NpgsqlTypes.NpgsqlPoint(x: 0.7738544881019989d, y: 0.15709436763824602d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8168702504857432d, y: 0.3236733725070786d), new NpgsqlTypes.NpgsqlPoint(x: 0.42881950404851d, y: 0.3420427016434514d), new NpgsqlTypes.NpgsqlPoint(x: 0.6529118437887004d, y: 0.942441943797422d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9974739619664388d, y: 0.9707689948223314d), new NpgsqlTypes.NpgsqlPoint(x: 0.7964142485528867d, y: 0.23333325831531604d), new NpgsqlTypes.NpgsqlPoint(x: 0.5516209836248323d, y: 0.047306330136550945d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5627895135502444d, y: 0.3383959809317768d), new NpgsqlTypes.NpgsqlPoint(x: 0.3533653331912837d, y: 0.10590954879877412d), new NpgsqlTypes.NpgsqlPoint(x: 0.9656508640166863d, y: 0.6970126528586363d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7489063238045124d, y: 0.21575975281971949d), new NpgsqlTypes.NpgsqlPoint(x: 0.47806597900423065d, y: 0.2814593158661054d), new NpgsqlTypes.NpgsqlPoint(x: 0.5199575510755086d, y: 0.7995228447880296d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.771976962845306d, y: 0.9726687132508782d), new NpgsqlTypes.NpgsqlPoint(x: 0.3910422503410742d, y: 0.7586318164003492d), new NpgsqlTypes.NpgsqlPoint(x: 0.6762167087174201d, y: 0.11032004973073473d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5876826127918894d, y: 0.6562173205352918d), new NpgsqlTypes.NpgsqlPoint(x: 0.8354490587750909d, y: 0.3076011418819192d), new NpgsqlTypes.NpgsqlPoint(x: 0.9236985287108231d, y: 0.47321041256701624d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2604316535235801d, y: 0.09937045092622832d), new NpgsqlTypes.NpgsqlPoint(x: 0.39956999229479084d, y: 0.3705014707110925d), new NpgsqlTypes.NpgsqlPoint(x: 0.14245824379671002d, y: 0.9952252746431959d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5769478977748194d, y: 0.5751396329482844d), new NpgsqlTypes.NpgsqlPoint(x: 0.030379572545451095d, y: 0.24962386923567836d), new NpgsqlTypes.NpgsqlPoint(x: 0.8870644445260092d, y: 0.7855464318809149d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.323462889226074d, y: 0.9513864337860026d), new NpgsqlTypes.NpgsqlPoint(x: 0.08190563021854413d, y: 0.1120136396024356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9463441267751292d, y: 0.4894256696014321d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8242448704952234d, y: 0.7853178774773633d), new NpgsqlTypes.NpgsqlPoint(x: 0.834455823471546d, y: 0.5116750749892002d), new NpgsqlTypes.NpgsqlPoint(x: 0.2620702416161934d, y: 0.5898019918695726d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4304411506224489d, y: 0.8021701300242644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7270461703442685d, y: 0.20340055194547213d), new NpgsqlTypes.NpgsqlPoint(x: 0.065717628418696d, y: 0.7775659325200868d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8593672891175755d, y: 0.3018765647164754d), new NpgsqlTypes.NpgsqlPoint(x: 0.6027908328414627d, y: 0.12711933851396973d), new NpgsqlTypes.NpgsqlPoint(x: 0.0031559054493592864d, y: 0.339823891528958d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9108932665013877d, y: 0.8481436048755082d), new NpgsqlTypes.NpgsqlPoint(x: 0.5807213144554322d, y: 0.9260322499509659d), new NpgsqlTypes.NpgsqlPoint(x: 0.9495184101025324d, y: 0.10286847611717931d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7551377944828779d, y: 0.043257990563614124d), new NpgsqlTypes.NpgsqlPoint(x: 0.4767369891999943d, y: 0.5782831370060458d), new NpgsqlTypes.NpgsqlPoint(x: 0.8188051025702408d, y: 0.7484141708473075d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12028137119592541d, y: 0.27556815227055154d), new NpgsqlTypes.NpgsqlPoint(x: 0.09303563288674499d, y: 0.0043450299713889695d), new NpgsqlTypes.NpgsqlPoint(x: 0.18752543366075336d, y: 0.5207895906915978d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8932787392669203d, y: 0.24452679216896556d), new NpgsqlTypes.NpgsqlPoint(x: 0.07273575589797632d, y: 0.7295109476524945d), new NpgsqlTypes.NpgsqlPoint(x: 0.5740396301799428d, y: 0.6053336797485649d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1572107273461788d, y: 0.30348791826590793d), new NpgsqlTypes.NpgsqlPoint(x: 0.18058660376458058d, y: 0.6671842157481871d), new NpgsqlTypes.NpgsqlPoint(x: 0.9283000248513994d, y: 0.08848477579133629d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7098152946186149d, y: 0.23657110421531546d), new NpgsqlTypes.NpgsqlPoint(x: 0.668073166843377d, y: 0.6582169708345305d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236977830809878d, y: 0.5270325218296101d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6150820053090347d, y: 0.2776205872887566d), new NpgsqlTypes.NpgsqlPoint(x: 0.5158063809026681d, y: 0.42151986910889727d), new NpgsqlTypes.NpgsqlPoint(x: 0.9794516554682065d, y: 0.3935637750698965d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4351747209256117d, y: 0.656319278406049d), new NpgsqlTypes.NpgsqlPoint(x: 0.9308466506220545d, y: 0.447981206302279d), new NpgsqlTypes.NpgsqlPoint(x: 0.9057146255567698d, y: 0.8930724464938858d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3596648628786847d, y: 0.2432447434577033d), new NpgsqlTypes.NpgsqlPoint(x: 0.9467333409024804d, y: 0.5595778100127131d), new NpgsqlTypes.NpgsqlPoint(x: 0.4902332786010043d, y: 0.29382355719584463d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8986829287107585d, y: 0.12428375070834619d), new NpgsqlTypes.NpgsqlPoint(x: 0.4825859918737524d, y: 0.6565969626060052d), new NpgsqlTypes.NpgsqlPoint(x: 0.014289858824914958d, y: 0.12062737548892288d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9947017968482397d, y: 0.07596557027953799d), new NpgsqlTypes.NpgsqlPoint(x: 0.30947985820487656d, y: 0.29659445631732406d), new NpgsqlTypes.NpgsqlPoint(x: 0.35396968113415206d, y: 0.014177921127165982d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28221426476233236d, y: 0.937423271209241d), new NpgsqlTypes.NpgsqlPoint(x: 0.48893983857801016d, y: 0.6958730632937166d), new NpgsqlTypes.NpgsqlPoint(x: 0.8772080750420284d, y: 0.3050649909411832d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.936939817342224d, y: 0.5480399942235699d), new NpgsqlTypes.NpgsqlPoint(x: 0.7391550925305379d, y: 0.6773019677826794d), new NpgsqlTypes.NpgsqlPoint(x: 0.1543034639006129d, y: 0.37032819597107836d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5157743118392765d, y: 0.7535116915048198d), new NpgsqlTypes.NpgsqlPoint(x: 0.43438120537180946d, y: 0.678556939966793d), new NpgsqlTypes.NpgsqlPoint(x: 0.6636845149026172d, y: 0.6984054768817136d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3241918619949833d, y: 0.4746171836043743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483204216966669d, y: 0.8986212084687405d), new NpgsqlTypes.NpgsqlPoint(x: 0.3670512088686899d, y: 0.8333215654553748d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8007814224720734d, y: 0.22511699644544558d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019229764886387d, y: 0.9891357152311064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5528462605063058d, y: 0.8277380887622439d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4477797243452949d, y: 0.9637279261835212d), new NpgsqlTypes.NpgsqlPoint(x: 0.603636254434157d, y: 0.6171546667448847d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867742503201503d, y: 0.06466274913563574d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7195493893144372d, y: 0.9094786281293095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6360564115171498d, y: 0.9650653124152662d), new NpgsqlTypes.NpgsqlPoint(x: 0.06147553804346262d, y: 0.5744270714722601d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.561894072119761d, y: 0.003274638910029104d), new NpgsqlTypes.NpgsqlPoint(x: 0.020163362440462573d, y: 0.7887381291594932d), new NpgsqlTypes.NpgsqlPoint(x: 0.16866396830235753d, y: 0.7479572331265651d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12267067667806308d, y: 0.3638271736031785d), new NpgsqlTypes.NpgsqlPoint(x: 0.6146266812828635d, y: 0.9336099235209886d), new NpgsqlTypes.NpgsqlPoint(x: 0.30585765129777454d, y: 0.24139346985697374d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9629568025465093d, y: 0.325432561311788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7612863222137944d, y: 0.943975867867346d), new NpgsqlTypes.NpgsqlPoint(x: 0.3793070214501212d, y: 0.7665876859074124d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6104995971723566d, y: 0.9240767203939562d), new NpgsqlTypes.NpgsqlPoint(x: 0.6221556978142881d, y: 0.8661276463080746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6963830510063664d, y: 0.22196081349187458d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.027608730754794197d, y: 0.31521611014088324d), new NpgsqlTypes.NpgsqlPoint(x: 0.9589305340239134d, y: 0.5322406043175198d), new NpgsqlTypes.NpgsqlPoint(x: 0.5989121456843444d, y: 0.32609439283209385d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8226744896654908d, y: 0.760384531577817d), new NpgsqlTypes.NpgsqlPoint(x: 0.13295601542256041d, y: 0.35979863360690145d), new NpgsqlTypes.NpgsqlPoint(x: 0.4594347572013847d, y: 0.40730877623039574d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05591919816783719d, y: 0.1363380232393261d), new NpgsqlTypes.NpgsqlPoint(x: 0.636340931548323d, y: 0.7964766018010281d), new NpgsqlTypes.NpgsqlPoint(x: 0.5000955005875946d, y: 0.47538067020464925d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39213751751796855d, y: 0.3681128067667264d), new NpgsqlTypes.NpgsqlPoint(x: 0.27510946503884337d, y: 0.0025831964947649055d), new NpgsqlTypes.NpgsqlPoint(x: 0.10867151797524577d, y: 0.5838978680154685d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1890713488902619d, y: 0.18186378370210432d), new NpgsqlTypes.NpgsqlPoint(x: 0.9005972576285955d, y: 0.4205837745260982d), new NpgsqlTypes.NpgsqlPoint(x: 0.44928754334313126d, y: 0.5214572173069801d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6278330420629488d, y: 0.4310599338407587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5548903664640013d, y: 0.21347744774941135d), new NpgsqlTypes.NpgsqlPoint(x: 0.09382453651249201d, y: 0.42120991301828103d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016935400692904445d, y: 0.20078018944130627d), new NpgsqlTypes.NpgsqlPoint(x: 0.32719765137504997d, y: 0.1668504044381095d), new NpgsqlTypes.NpgsqlPoint(x: 0.4558885578142513d, y: 0.5464680081696208d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9288504071721981d, y: 0.5123606712082662d), new NpgsqlTypes.NpgsqlPoint(x: 0.7395598197956226d, y: 0.17473546215787994d), new NpgsqlTypes.NpgsqlPoint(x: 0.44486921329901874d, y: 0.4529935430461315d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42583169250537656d, y: 0.4729703207795608d), new NpgsqlTypes.NpgsqlPoint(x: 0.6740222483454097d, y: 0.4309521785978033d), new NpgsqlTypes.NpgsqlPoint(x: 0.23706240515346855d, y: 0.5583219439245359d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44977256288529666d, y: 0.746325254062089d), new NpgsqlTypes.NpgsqlPoint(x: 0.23927406733997636d, y: 0.07548251365140324d), new NpgsqlTypes.NpgsqlPoint(x: 0.3106814321433019d, y: 0.6430307083340234d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44940931354452474d, y: 0.5634887731903164d), new NpgsqlTypes.NpgsqlPoint(x: 0.9619204715813757d, y: 0.7736646949178371d), new NpgsqlTypes.NpgsqlPoint(x: 0.39435490784323113d, y: 0.879249987190743d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5652925872344398d, y: 0.46663353014721387d), new NpgsqlTypes.NpgsqlPoint(x: 0.4685277191809396d, y: 0.5273941729389391d), new NpgsqlTypes.NpgsqlPoint(x: 0.9738532092887248d, y: 0.8205275409114728d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7884661289174701d, y: 0.08544357859779961d), new NpgsqlTypes.NpgsqlPoint(x: 0.06375612746853276d, y: 0.5831651442428687d), new NpgsqlTypes.NpgsqlPoint(x: 0.09473724016058505d, y: 0.762410856504016d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013165033479672017d, y: 0.5181817441781903d), new NpgsqlTypes.NpgsqlPoint(x: 0.26148212486837197d, y: 0.25029795777371777d), new NpgsqlTypes.NpgsqlPoint(x: 0.8652338274759779d, y: 0.9076238183733056d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11579337359215247d, y: 0.9630673792593054d), new NpgsqlTypes.NpgsqlPoint(x: 0.5793869707949624d, y: 0.3602499651087099d), new NpgsqlTypes.NpgsqlPoint(x: 0.8930371581250184d, y: 0.21990244354287591d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2722489166608184d, y: 0.48869402407815443d), new NpgsqlTypes.NpgsqlPoint(x: 0.21859500445882274d, y: 0.0016989095345119054d), new NpgsqlTypes.NpgsqlPoint(x: 0.40698437046465386d, y: 0.19145658516055186d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17238583854845424d, y: 0.2666119018475782d), new NpgsqlTypes.NpgsqlPoint(x: 0.5598435371298806d, y: 0.9441943435682078d), new NpgsqlTypes.NpgsqlPoint(x: 0.42680797637469126d, y: 0.7136331593333463d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3054593310708382d, y: 0.9975390598259601d), new NpgsqlTypes.NpgsqlPoint(x: 0.8073882643089129d, y: 0.8330375637564384d), new NpgsqlTypes.NpgsqlPoint(x: 0.15631535083345527d, y: 0.7965049545636078d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9407911171506901d, y: 0.9462963467870452d), new NpgsqlTypes.NpgsqlPoint(x: 0.033086378801522986d, y: 0.08291146225427837d), new NpgsqlTypes.NpgsqlPoint(x: 0.021658403049255814d, y: 0.9660433181621801d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35606827189293977d, y: 0.6277899320493961d), new NpgsqlTypes.NpgsqlPoint(x: 0.8525134438376077d, y: 0.3057654368651249d), new NpgsqlTypes.NpgsqlPoint(x: 0.5487908400062608d, y: 0.42351886605390776d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22308783748838623d, y: 0.2685313603182097d), new NpgsqlTypes.NpgsqlPoint(x: 0.3467664191909201d, y: 0.2490259588041327d), new NpgsqlTypes.NpgsqlPoint(x: 0.9614568049796542d, y: 0.4896647663512468d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.268208912077462d, y: 0.25604104366773006d), new NpgsqlTypes.NpgsqlPoint(x: 0.5610096164732198d, y: 0.7462542335443797d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638499130746085d, y: 0.6558725591990989d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6971610313633494d, y: 0.31909440138783085d), new NpgsqlTypes.NpgsqlPoint(x: 0.1891633294246876d, y: 0.14034224147512486d), new NpgsqlTypes.NpgsqlPoint(x: 0.8841867669888102d, y: 0.49797332036737396d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8874006104433657d, y: 0.1901017681853292d), new NpgsqlTypes.NpgsqlPoint(x: 0.15585883061486105d, y: 0.5327459820927816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8091399006699075d, y: 0.5009442799520211d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7025332481278368d, y: 0.25142695739492815d), new NpgsqlTypes.NpgsqlPoint(x: 0.1436178031868124d, y: 0.6058170076020343d), new NpgsqlTypes.NpgsqlPoint(x: 0.7785070136986313d, y: 0.661743843644579d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3956273128096308d, y: 0.8203840110687731d), new NpgsqlTypes.NpgsqlPoint(x: 0.6391902943307551d, y: 0.8663276400365723d), new NpgsqlTypes.NpgsqlPoint(x: 0.4362715449393364d, y: 0.30705494202314454d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8520197069426693d, y: 0.261773168352626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6769443198418033d, y: 0.336775354484815d), new NpgsqlTypes.NpgsqlPoint(x: 0.5253102729834535d, y: 0.6489130832320567d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7427782864232041d, y: 0.38498339186010255d), new NpgsqlTypes.NpgsqlPoint(x: 0.2784690012277603d, y: 0.47366689044514665d), new NpgsqlTypes.NpgsqlPoint(x: 0.8798673181010853d, y: 0.5613830639373265d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15890724780697296d, y: 0.4773057732096866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5392082251087771d, y: 0.9476399338043913d), new NpgsqlTypes.NpgsqlPoint(x: 0.032976059352370135d, y: 0.2965557202422683d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7636449935277138d, y: 0.5948071552645071d), new NpgsqlTypes.NpgsqlPoint(x: 0.8261916607283639d, y: 0.5224840077275589d), new NpgsqlTypes.NpgsqlPoint(x: 0.9438073314454762d, y: 0.7646068039103774d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1183387671210604d, y: 0.5832921238816869d), new NpgsqlTypes.NpgsqlPoint(x: 0.2371808574883698d, y: 0.12792129620096604d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513539418155125d, y: 0.4236033682391387d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7138373569872059d, y: 0.4782076672487696d), new NpgsqlTypes.NpgsqlPoint(x: 0.3242822494177937d, y: 0.27276805925366165d), new NpgsqlTypes.NpgsqlPoint(x: 0.8851648134848883d, y: 0.3264680539883241d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6174092451765082d, y: 0.01751922262332728d), new NpgsqlTypes.NpgsqlPoint(x: 0.2702898084787101d, y: 0.10769645417003415d), new NpgsqlTypes.NpgsqlPoint(x: 0.46112692338153616d, y: 0.06440406240613006d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17446675299442949d, y: 0.8652960120187153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9144385305415957d, y: 0.06682520621602539d), new NpgsqlTypes.NpgsqlPoint(x: 0.27067245736137924d, y: 0.0006205853126196592d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9481964250882952d, y: 0.8751756737254666d), new NpgsqlTypes.NpgsqlPoint(x: 0.49901347031817056d, y: 0.5555768462363633d), new NpgsqlTypes.NpgsqlPoint(x: 0.5762280600100703d, y: 0.7571739880097396d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.966661760281327d, y: 0.6665407959548009d), new NpgsqlTypes.NpgsqlPoint(x: 0.4229678313669405d, y: 0.9598990781793808d), new NpgsqlTypes.NpgsqlPoint(x: 0.9268642534702507d, y: 0.8447695598070469d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7091398265899124d, y: 0.09941840040367245d), new NpgsqlTypes.NpgsqlPoint(x: 0.04850833982568281d, y: 0.5886380848058479d), new NpgsqlTypes.NpgsqlPoint(x: 0.04315941404553214d, y: 0.3228669955069624d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3679367723651926d, y: 0.41695534132555645d), new NpgsqlTypes.NpgsqlPoint(x: 0.17142996565434465d, y: 0.5169871877240068d), new NpgsqlTypes.NpgsqlPoint(x: 0.3905929885580558d, y: 0.4510260879235044d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29003933616914934d, y: 0.26010953253250335d), new NpgsqlTypes.NpgsqlPoint(x: 0.32543723971145266d, y: 0.4353059335332651d), new NpgsqlTypes.NpgsqlPoint(x: 0.6212336864012352d, y: 0.025956920546697404d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31930388299712154d, y: 0.5377567027790113d), new NpgsqlTypes.NpgsqlPoint(x: 0.1345541055625602d, y: 0.6293876976090392d), new NpgsqlTypes.NpgsqlPoint(x: 0.868735023180874d, y: 0.3633120412090839d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3108120280499075d, y: 0.4068168517021178d), new NpgsqlTypes.NpgsqlPoint(x: 0.29956544253739026d, y: 0.5984255372088177d), new NpgsqlTypes.NpgsqlPoint(x: 0.4552934540353418d, y: 0.22931364245080543d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9343534708791905d, y: 0.32603628224056d), new NpgsqlTypes.NpgsqlPoint(x: 0.21835002251776559d, y: 0.16525341557026918d), new NpgsqlTypes.NpgsqlPoint(x: 0.8640318275319522d, y: 0.19270088769267624d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8838201125002106d, y: 0.7969072880381078d), new NpgsqlTypes.NpgsqlPoint(x: 0.7305837139959761d, y: 0.014590978883520456d), new NpgsqlTypes.NpgsqlPoint(x: 0.7560112310500104d, y: 0.20784517459045593d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.729150110334346d, y: 0.6680480232997125d), new NpgsqlTypes.NpgsqlPoint(x: 0.1315632449059092d, y: 0.6688390236996019d), new NpgsqlTypes.NpgsqlPoint(x: 0.4586209465534363d, y: 0.8057945634679285d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8838555987207533d, y: 0.5059859318865001d), new NpgsqlTypes.NpgsqlPoint(x: 0.5000669777186343d, y: 0.6172799179080941d), new NpgsqlTypes.NpgsqlPoint(x: 0.4002302254934791d, y: 0.012878196306009282d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17172857554386767d, y: 0.14707843935278797d), new NpgsqlTypes.NpgsqlPoint(x: 0.177087435618144d, y: 0.08945078620503033d), new NpgsqlTypes.NpgsqlPoint(x: 0.7031811235760891d, y: 0.6239901503942976d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.53901073225241d, y: 0.06535040559766925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7646737907555053d, y: 0.16024523924173517d), new NpgsqlTypes.NpgsqlPoint(x: 0.4581245296567329d, y: 0.9590057951014205d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26009365474205337d, y: 0.4445092762414615d), new NpgsqlTypes.NpgsqlPoint(x: 0.38737681606587004d, y: 0.5355869695560123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531319872728731d, y: 0.1430687813718282d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18065626690245673d, y: 0.0017418556104975558d), new NpgsqlTypes.NpgsqlPoint(x: 0.6262065127953843d, y: 0.9077989209686687d), new NpgsqlTypes.NpgsqlPoint(x: 0.2834517893335944d, y: 0.8570130510825346d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5617655927292283d, y: 0.2895597365962792d), new NpgsqlTypes.NpgsqlPoint(x: 0.6184717941195245d, y: 0.13688649705000333d), new NpgsqlTypes.NpgsqlPoint(x: 0.946500609200194d, y: 0.4132430829407996d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7363515839725567d, y: 0.21342576400707913d), new NpgsqlTypes.NpgsqlPoint(x: 0.6483737125167285d, y: 0.7415537298803111d), new NpgsqlTypes.NpgsqlPoint(x: 0.9186219667688913d, y: 0.8575553371213425d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9271228739547458d, y: 0.1430044727276344d), new NpgsqlTypes.NpgsqlPoint(x: 0.7228170456892469d, y: 0.38325707280169974d), new NpgsqlTypes.NpgsqlPoint(x: 0.753505845562687d, y: 0.01826975526316532d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6977372357139012d, y: 0.39772889074249496d), new NpgsqlTypes.NpgsqlPoint(x: 0.7217677205971879d, y: 0.9762309697373045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8480420756681876d, y: 0.3004322249069292d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5067896463905543d, y: 0.6770478524214569d), new NpgsqlTypes.NpgsqlPoint(x: 0.08612365067530259d, y: 0.34593357689517035d), new NpgsqlTypes.NpgsqlPoint(x: 0.061443652163298834d, y: 0.892708465903035d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5924157245537965d, y: 0.1173755791017771d), new NpgsqlTypes.NpgsqlPoint(x: 0.14151056897421843d, y: 0.5112679770495383d), new NpgsqlTypes.NpgsqlPoint(x: 0.6497350586686251d, y: 0.23564302518071134d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5890810932256103d, y: 0.3942657895588805d), new NpgsqlTypes.NpgsqlPoint(x: 0.48655166542806816d, y: 0.08759146673050988d), new NpgsqlTypes.NpgsqlPoint(x: 0.4651700968961131d, y: 0.22300463238806745d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7235204815946128d, y: 0.8598615356974468d), new NpgsqlTypes.NpgsqlPoint(x: 0.03521499578060261d, y: 0.6347689190356184d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936591387417568d, y: 0.6994195138076493d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31731300147706165d, y: 0.3801033325253357d), new NpgsqlTypes.NpgsqlPoint(x: 0.32309895969339486d, y: 0.42367130161398314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6331700486347253d, y: 0.4092085843544956d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28641462993939937d, y: 0.6265462580743365d), new NpgsqlTypes.NpgsqlPoint(x: 0.7854088750106094d, y: 0.7072133957923712d), new NpgsqlTypes.NpgsqlPoint(x: 0.6986336212031417d, y: 0.15337443691153696d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9401234837664667d, y: 0.7572641968846793d), new NpgsqlTypes.NpgsqlPoint(x: 0.211964517226244d, y: 0.35675845402708495d), new NpgsqlTypes.NpgsqlPoint(x: 0.04482255178730643d, y: 0.49724367025667193d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5112713782734085d, y: 0.45890765281089774d), new NpgsqlTypes.NpgsqlPoint(x: 0.8455544247546828d, y: 0.42910928000600446d), new NpgsqlTypes.NpgsqlPoint(x: 0.3308215214384983d, y: 0.6678265826115527d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3397015200083864d, y: 0.5424731521998618d), new NpgsqlTypes.NpgsqlPoint(x: 0.7055574716222945d, y: 0.987237526281952d), new NpgsqlTypes.NpgsqlPoint(x: 0.6887557032978465d, y: 0.6532778030380871d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40625339840201113d, y: 0.8946137323884479d), new NpgsqlTypes.NpgsqlPoint(x: 0.1591620660121893d, y: 0.28324401738032035d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638250017870281d, y: 0.12303026511303317d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9811791824233929d, y: 0.015990207638241105d), new NpgsqlTypes.NpgsqlPoint(x: 0.07529570017018083d, y: 0.11027036979462945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7420163617584219d, y: 0.7534908691338399d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2687670164471757d, y: 0.5472073888533631d), new NpgsqlTypes.NpgsqlPoint(x: 0.5899841109997592d, y: 0.687668257186795d), new NpgsqlTypes.NpgsqlPoint(x: 0.0393907258292453d, y: 0.4831069123474053d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4260742982707282d, y: 0.13698179373391062d), new NpgsqlTypes.NpgsqlPoint(x: 0.24629364175478163d, y: 0.7842463852336975d), new NpgsqlTypes.NpgsqlPoint(x: 0.7297033852962311d, y: 0.8292516176065118d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10772412064029913d, y: 0.42942329657347744d), new NpgsqlTypes.NpgsqlPoint(x: 0.3092062290799077d, y: 0.8427575641353379d), new NpgsqlTypes.NpgsqlPoint(x: 0.5519489151929293d, y: 0.508565453406831d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.843226068680842d, y: 0.968661501927539d), new NpgsqlTypes.NpgsqlPoint(x: 0.44069508506275157d, y: 0.3789356298749845d), new NpgsqlTypes.NpgsqlPoint(x: 0.0071237055229855795d, y: 0.9514812374667088d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8979858367872595d, y: 0.8526266227260619d), new NpgsqlTypes.NpgsqlPoint(x: 0.2685254626305632d, y: 0.5773162960683006d), new NpgsqlTypes.NpgsqlPoint(x: 0.21782693587125967d, y: 0.8124453575355848d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36355608971453346d, y: 0.750019898164101d), new NpgsqlTypes.NpgsqlPoint(x: 0.31872925871955504d, y: 0.3000890011395645d), new NpgsqlTypes.NpgsqlPoint(x: 0.3440714822234221d, y: 0.1747586579406727d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03450446299245402d, y: 0.6816618466652814d), new NpgsqlTypes.NpgsqlPoint(x: 0.34895873641143715d, y: 0.42137825546344787d), new NpgsqlTypes.NpgsqlPoint(x: 0.7981226742177344d, y: 0.7039580173033958d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7369915219559897d, y: 0.6692861319325955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9316913644958225d, y: 0.7427422087787947d), new NpgsqlTypes.NpgsqlPoint(x: 0.014105415510296204d, y: 0.333881474901047d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004542480440226315d, y: 0.7376090749985766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5036920875158902d, y: 0.0033309705855262273d), new NpgsqlTypes.NpgsqlPoint(x: 0.6146201437025364d, y: 0.7296079240506006d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06425076391489881d, y: 0.43625699845861043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9810501010376601d, y: 0.9588165099146084d), new NpgsqlTypes.NpgsqlPoint(x: 0.7775790241875707d, y: 0.8779637653557064d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6955314245808193d, y: 0.040298354940423d), new NpgsqlTypes.NpgsqlPoint(x: 0.49446573648376435d, y: 0.5788379953147283d), new NpgsqlTypes.NpgsqlPoint(x: 0.18643077979279d, y: 0.1756893841054067d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05728204888642441d, y: 0.3954060120578271d), new NpgsqlTypes.NpgsqlPoint(x: 0.12889507854947635d, y: 0.7108715954329162d), new NpgsqlTypes.NpgsqlPoint(x: 0.870695687579229d, y: 0.23675778449427198d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8117241711542041d, y: 0.3470255807720929d), new NpgsqlTypes.NpgsqlPoint(x: 0.18705877062785747d, y: 0.8153239457693978d), new NpgsqlTypes.NpgsqlPoint(x: 0.7933170312467429d, y: 0.42042610601268926d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6551081420111943d, y: 0.4257999226662731d), new NpgsqlTypes.NpgsqlPoint(x: 0.5682282669336481d, y: 0.8245263228507619d), new NpgsqlTypes.NpgsqlPoint(x: 0.8783679179837945d, y: 0.8152635187256485d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2680388601940418d, y: 0.5653450763911154d), new NpgsqlTypes.NpgsqlPoint(x: 0.0027233593920228394d, y: 0.8336641643533934d), new NpgsqlTypes.NpgsqlPoint(x: 0.6780074919242005d, y: 0.42265686088325116d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1979335076881963d, y: 0.6543283990359282d), new NpgsqlTypes.NpgsqlPoint(x: 0.40938422741599656d, y: 0.12084174231661271d), new NpgsqlTypes.NpgsqlPoint(x: 0.5138841838925386d, y: 0.46383644776864896d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5334796481658548d, y: 0.04832068425380376d), new NpgsqlTypes.NpgsqlPoint(x: 0.18610238911200483d, y: 0.7481779217534102d), new NpgsqlTypes.NpgsqlPoint(x: 0.7458768477624852d, y: 0.40766329397217616d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4980043106034303d, y: 0.3107292033578304d), new NpgsqlTypes.NpgsqlPoint(x: 0.7765120305380252d, y: 0.6924930355717537d), new NpgsqlTypes.NpgsqlPoint(x: 0.0681433324998797d, y: 0.6277367865324704d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5799774086739009d, y: 0.8717191171289606d), new NpgsqlTypes.NpgsqlPoint(x: 0.06872693345266945d, y: 0.00501107481601637d), new NpgsqlTypes.NpgsqlPoint(x: 0.8900808352053102d, y: 0.7197534260010338d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9361603872758655d, y: 0.22987578876705494d), new NpgsqlTypes.NpgsqlPoint(x: 0.17756308846463686d, y: 0.30409780197080094d), new NpgsqlTypes.NpgsqlPoint(x: 0.4944130028511554d, y: 0.6865465641510855d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012452016618100914d, y: 0.7930522931418347d), new NpgsqlTypes.NpgsqlPoint(x: 0.05159743637984615d, y: 0.6441443753529132d), new NpgsqlTypes.NpgsqlPoint(x: 0.18964466398389135d, y: 0.21098105393685807d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0025486909644016897d, y: 0.7647311642721519d), new NpgsqlTypes.NpgsqlPoint(x: 0.8923236984557369d, y: 0.987193518045534d), new NpgsqlTypes.NpgsqlPoint(x: 0.7964253837545034d, y: 0.8379982983173658d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06779582957607866d, y: 0.10603712922312758d), new NpgsqlTypes.NpgsqlPoint(x: 0.9116461927499399d, y: 0.2266188727960574d), new NpgsqlTypes.NpgsqlPoint(x: 0.6673344156948122d, y: 0.5461968106356995d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12839164860614038d, y: 0.8548247543766849d), new NpgsqlTypes.NpgsqlPoint(x: 0.9568666029865329d, y: 0.8709142028832513d), new NpgsqlTypes.NpgsqlPoint(x: 0.6829630085580607d, y: 0.21961066876649837d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5893049443022014d, y: 0.33179844481495924d), new NpgsqlTypes.NpgsqlPoint(x: 0.22477323136671634d, y: 0.16561782346739096d), new NpgsqlTypes.NpgsqlPoint(x: 0.6406694512860237d, y: 0.38496143493424617d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6743249278668763d, y: 0.21961361526503542d), new NpgsqlTypes.NpgsqlPoint(x: 0.21767008356583317d, y: 0.9092123584582343d), new NpgsqlTypes.NpgsqlPoint(x: 0.8743036948478412d, y: 0.6912177824019731d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4442721746082551d, y: 0.776781489654891d), new NpgsqlTypes.NpgsqlPoint(x: 0.47285380022163725d, y: 0.9673108233094976d), new NpgsqlTypes.NpgsqlPoint(x: 0.08511552100657471d, y: 0.43133188316746196d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16139874681734168d, y: 0.061425421590179385d), new NpgsqlTypes.NpgsqlPoint(x: 0.6036206199483974d, y: 0.5843679232544974d), new NpgsqlTypes.NpgsqlPoint(x: 0.5544479278713125d, y: 0.6462094197637986d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021673147120244485d, y: 0.09947177386882744d), new NpgsqlTypes.NpgsqlPoint(x: 0.5560737664528687d, y: 0.8436928596841331d), new NpgsqlTypes.NpgsqlPoint(x: 0.568785262969337d, y: 0.8112929836694472d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.666993793949673d, y: 0.5099873406121765d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832332849650964d, y: 0.2961079972558198d), new NpgsqlTypes.NpgsqlPoint(x: 0.8311067213806622d, y: 0.7183030391339816d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8682239292822141d, y: 0.5150262970090395d), new NpgsqlTypes.NpgsqlPoint(x: 0.07335174997176097d, y: 0.35236015820737066d), new NpgsqlTypes.NpgsqlPoint(x: 0.9667349385573912d, y: 0.301080845842738d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7671489511676838d, y: 0.12490730391439853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8449035667086309d, y: 0.6033201891417275d), new NpgsqlTypes.NpgsqlPoint(x: 0.04019277064877058d, y: 0.6531342027780486d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7348861021518865d, y: 0.8775385334407562d), new NpgsqlTypes.NpgsqlPoint(x: 0.4630061762464206d, y: 0.351041415829043d), new NpgsqlTypes.NpgsqlPoint(x: 0.741937020065934d, y: 0.2754299220309461d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8866203545687988d, y: 0.8613880030494461d), new NpgsqlTypes.NpgsqlPoint(x: 0.8519117710957695d, y: 0.0988902373181858d), new NpgsqlTypes.NpgsqlPoint(x: 0.9094120405181724d, y: 0.6488465054634825d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.481640031544744d, y: 0.7630969374602379d), new NpgsqlTypes.NpgsqlPoint(x: 0.4247693743838111d, y: 0.7455437949159901d), new NpgsqlTypes.NpgsqlPoint(x: 0.8013127734996649d, y: 0.7490287953213703d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26272638311157204d, y: 0.3160767250666693d), new NpgsqlTypes.NpgsqlPoint(x: 0.5078320324094956d, y: 0.46686590174503884d), new NpgsqlTypes.NpgsqlPoint(x: 0.4172740208358289d, y: 0.8584347584978448d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4270523428747104d, y: 0.26823393154908537d), new NpgsqlTypes.NpgsqlPoint(x: 0.3898614411237825d, y: 0.5578444182700607d), new NpgsqlTypes.NpgsqlPoint(x: 0.11025331874272937d, y: 0.1326529446737854d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02948357550543812d, y: 0.35300409552430045d), new NpgsqlTypes.NpgsqlPoint(x: 0.17981910731746098d, y: 0.42988371081654253d), new NpgsqlTypes.NpgsqlPoint(x: 0.9838177897335829d, y: 0.8700999131356091d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5833507165284105d, y: 0.8011404289616941d), new NpgsqlTypes.NpgsqlPoint(x: 0.8077986643512809d, y: 0.6331861240557671d), new NpgsqlTypes.NpgsqlPoint(x: 0.3540009166372776d, y: 0.7073481403484577d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8821540719403843d, y: 0.0947021721817024d), new NpgsqlTypes.NpgsqlPoint(x: 0.25393583006525844d, y: 0.14950364749483247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8735244703617878d, y: 0.8957934547785267d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.321090821830767d, y: 0.6757140225636832d), new NpgsqlTypes.NpgsqlPoint(x: 0.2478161943137568d, y: 0.5377387965882151d), new NpgsqlTypes.NpgsqlPoint(x: 0.4090539456923842d, y: 0.6270817180643982d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.032894721504983515d, y: 0.9754873414586337d), new NpgsqlTypes.NpgsqlPoint(x: 0.7785965487196185d, y: 0.6962882179470794d), new NpgsqlTypes.NpgsqlPoint(x: 0.7121665008217035d, y: 0.5513165541437863d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.734339202984819d, y: 0.8831769209665262d), new NpgsqlTypes.NpgsqlPoint(x: 0.6058729007155639d, y: 0.7108584945735198d), new NpgsqlTypes.NpgsqlPoint(x: 0.5572541729831293d, y: 0.08178926440744871d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4444795783580908d, y: 0.18462464424510905d), new NpgsqlTypes.NpgsqlPoint(x: 0.39536798106935533d, y: 0.1466817412468423d), new NpgsqlTypes.NpgsqlPoint(x: 0.1171700943376307d, y: 0.6023324757364341d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33633278789645704d, y: 0.7987676263777301d), new NpgsqlTypes.NpgsqlPoint(x: 0.972818578562618d, y: 0.5178488778194686d), new NpgsqlTypes.NpgsqlPoint(x: 0.3432203957612996d, y: 0.33244801879026764d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29872779566911667d, y: 0.8323174179438078d), new NpgsqlTypes.NpgsqlPoint(x: 0.4999465564120683d, y: 0.1721542084023845d), new NpgsqlTypes.NpgsqlPoint(x: 0.8494721861270464d, y: 0.6899267863723908d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4750179053253575d, y: 0.10002920594835807d), new NpgsqlTypes.NpgsqlPoint(x: 0.4068742520114793d, y: 0.28467244223579447d), new NpgsqlTypes.NpgsqlPoint(x: 0.22296820996566225d, y: 0.8488061121290938d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1690868232868309d, y: 0.5567106731213858d), new NpgsqlTypes.NpgsqlPoint(x: 0.1298606775312907d, y: 0.9702380686304104d), new NpgsqlTypes.NpgsqlPoint(x: 0.7333397612919316d, y: 0.9432510957029271d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10220926933814545d, y: 0.5709556867025091d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005366740053707186d, y: 0.5528833977844955d), new NpgsqlTypes.NpgsqlPoint(x: 0.5179813516216515d, y: 0.290885755419391d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18422164168451705d, y: 0.9707006251786227d), new NpgsqlTypes.NpgsqlPoint(x: 0.24240814717632486d, y: 0.7406695469538729d), new NpgsqlTypes.NpgsqlPoint(x: 0.6225403208530464d, y: 0.9229577871344132d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19267223167556413d, y: 0.15686631015535846d), new NpgsqlTypes.NpgsqlPoint(x: 0.03515587732561687d, y: 0.5267895825487546d), new NpgsqlTypes.NpgsqlPoint(x: 0.8649480398849809d, y: 0.7089069134026443d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18842325383944947d, y: 0.2792656909535197d), new NpgsqlTypes.NpgsqlPoint(x: 0.8586705563695943d, y: 0.8056476253006019d), new NpgsqlTypes.NpgsqlPoint(x: 0.40212042616409094d, y: 0.7188158940032304d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2830633524585492d, y: 0.9900276007799074d), new NpgsqlTypes.NpgsqlPoint(x: 0.8787456923582171d, y: 0.7794309062724644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276285721005893d, y: 0.06473296403111373d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5662696872954689d, y: 0.158635609514866d), new NpgsqlTypes.NpgsqlPoint(x: 0.3221696118683939d, y: 0.0330011644116488d), new NpgsqlTypes.NpgsqlPoint(x: 0.32090581785504835d, y: 0.16395160127192465d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14447037828928d, y: 0.5882767197847047d), new NpgsqlTypes.NpgsqlPoint(x: 0.9289554898127366d, y: 0.1604838300713448d), new NpgsqlTypes.NpgsqlPoint(x: 0.8584215885554769d, y: 0.676617673437039d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9941425503677102d, y: 0.5831002449517506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8993864200020143d, y: 0.14386336059115745d), new NpgsqlTypes.NpgsqlPoint(x: 0.2704331077059905d, y: 0.9908530629736139d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6260930079730064d, y: 0.4801348645046425d), new NpgsqlTypes.NpgsqlPoint(x: 0.31708401396949326d, y: 0.8940702121990798d), new NpgsqlTypes.NpgsqlPoint(x: 0.7600076721978577d, y: 0.44315804025819994d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43962938814511054d, y: 0.5494258326750612d), new NpgsqlTypes.NpgsqlPoint(x: 0.03626912450408071d, y: 0.44389765092469124d), new NpgsqlTypes.NpgsqlPoint(x: 0.5337995544872197d, y: 0.5607047506886278d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12858760757024323d, y: 0.6437124950263168d), new NpgsqlTypes.NpgsqlPoint(x: 0.8523750830854159d, y: 0.25869863588631226d), new NpgsqlTypes.NpgsqlPoint(x: 0.8842714011193399d, y: 0.378683980367418d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8423545818221102d, y: 0.5981593345769242d), new NpgsqlTypes.NpgsqlPoint(x: 0.7987869902324587d, y: 0.9244054148432601d), new NpgsqlTypes.NpgsqlPoint(x: 0.0748955447377152d, y: 0.694624128775182d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.746033244053442d, y: 0.5162573823223451d), new NpgsqlTypes.NpgsqlPoint(x: 0.7532859901811032d, y: 0.42843230440567837d), new NpgsqlTypes.NpgsqlPoint(x: 0.42521455844330913d, y: 0.8629574855126657d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5104694844573748d, y: 0.7001817634215609d), new NpgsqlTypes.NpgsqlPoint(x: 0.17529247958783167d, y: 0.01229400004029002d), new NpgsqlTypes.NpgsqlPoint(x: 0.7623851545735464d, y: 0.5658608092840817d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30352670228189693d, y: 0.11811844179222508d), new NpgsqlTypes.NpgsqlPoint(x: 0.4687486662379007d, y: 0.3236972116133038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5605438086828752d, y: 0.6602579044182475d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5187230884205299d, y: 0.783645481960828d), new NpgsqlTypes.NpgsqlPoint(x: 0.06522779593873607d, y: 0.9914329126818477d), new NpgsqlTypes.NpgsqlPoint(x: 0.49331888033370963d, y: 0.5445863028333449d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.048248284291688925d, y: 0.4544855217840903d), new NpgsqlTypes.NpgsqlPoint(x: 0.9126467960665571d, y: 0.49928307255319426d), new NpgsqlTypes.NpgsqlPoint(x: 0.7105058995516889d, y: 0.6345098277896244d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7677555360036183d, y: 0.25985095260499d), new NpgsqlTypes.NpgsqlPoint(x: 0.10034274015733813d, y: 0.5482894833884632d), new NpgsqlTypes.NpgsqlPoint(x: 0.8800719233528049d, y: 0.8704556631468237d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 179,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9833581747474862d, y: 0.05551420069841051d), new NpgsqlTypes.NpgsqlPoint(x: 0.006620317695647859d, y: 0.5085624283136971d), new NpgsqlTypes.NpgsqlPoint(x: 0.46141633588640596d, y: 0.9929422314818241d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.648035719913841d, y: 0.5876029678726385d), new NpgsqlTypes.NpgsqlPoint(x: 0.668473067835556d, y: 0.29819947879885944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6817127224601235d, y: 0.7679949918133678d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41317505228116636d, y: 0.6415049707075252d), new NpgsqlTypes.NpgsqlPoint(x: 0.08881409467987966d, y: 0.9169197163197075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6627558931312933d, y: 0.7382227282490565d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6974795310498517d, y: 0.8147085283539584d), new NpgsqlTypes.NpgsqlPoint(x: 0.734187387503828d, y: 0.2645206821022499d), new NpgsqlTypes.NpgsqlPoint(x: 0.07385063205391162d, y: 0.16850718463040604d)), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08510795408984195d, y: 0.10050305886111743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9843219074723794d, y: 0.4777193845302238d), new NpgsqlTypes.NpgsqlPoint(x: 0.5134282429730741d, y: 0.9759544326365592d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33092415678579035d, y: 0.8078935146295034d), new NpgsqlTypes.NpgsqlPoint(x: 0.321829747007885d, y: 0.9924554353679464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7788847535167797d, y: 0.135602178380142d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9247507869555006d, y: 0.8782259986768918d), new NpgsqlTypes.NpgsqlPoint(x: 0.10612207928362094d, y: 0.25179172838710906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7684249102084397d, y: 0.8894860412121087d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5444404904407529d, y: 0.6532579144306532d), new NpgsqlTypes.NpgsqlPoint(x: 0.2646800634687646d, y: 0.03377867790697209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5340012626585482d, y: 0.6591464347806464d)), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6352792665754926d, y: 0.26763249667585254d), new NpgsqlTypes.NpgsqlPoint(x: 0.29295897863255715d, y: 0.27505231931557206d), new NpgsqlTypes.NpgsqlPoint(x: 0.45381483955444135d, y: 0.05412497645150771d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7628805098885701d, y: 0.13651437455556803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7840091679909833d, y: 0.157608564652173d), new NpgsqlTypes.NpgsqlPoint(x: 0.4633637808092008d, y: 0.4167485512932003d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8542829416771422d, y: 0.5171176110328979d), new NpgsqlTypes.NpgsqlPoint(x: 0.37018302013949345d, y: 0.9744926307726954d), new NpgsqlTypes.NpgsqlPoint(x: 0.020554167935418977d, y: 0.3114886702015579d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2792620205644163d, y: 0.2800723095873786d), new NpgsqlTypes.NpgsqlPoint(x: 0.18813764613698192d, y: 0.5233455783823133d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361035189756655d, y: 0.22614830938668318d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38584512923352177d, y: 0.7194027047234777d), new NpgsqlTypes.NpgsqlPoint(x: 0.43144234833237505d, y: 0.8901012132629907d), new NpgsqlTypes.NpgsqlPoint(x: 0.4309746877109495d, y: 0.9785653709758656d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9506588646049284d, y: 0.33013622404982623d), new NpgsqlTypes.NpgsqlPoint(x: 0.6371149667957281d, y: 0.9410043674712238d), new NpgsqlTypes.NpgsqlPoint(x: 0.24203551742637008d, y: 0.49611059834621973d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3768311381450298d, y: 0.5591622096598956d), new NpgsqlTypes.NpgsqlPoint(x: 0.27200894086909555d, y: 0.7959810126923239d), new NpgsqlTypes.NpgsqlPoint(x: 0.7645794162429389d, y: 0.056220923349839746d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37260762935714276d, y: 0.6243842305840716d), new NpgsqlTypes.NpgsqlPoint(x: 0.7088544167915725d, y: 0.9808626589650956d), new NpgsqlTypes.NpgsqlPoint(x: 0.9365426673119741d, y: 0.8282880042236082d)), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07711449789841618d, y: 0.33209041855811716d), new NpgsqlTypes.NpgsqlPoint(x: 0.07708075971146366d, y: 0.6370614532652621d), new NpgsqlTypes.NpgsqlPoint(x: 0.5482598052165151d, y: 0.31188248020624876d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34445307150949445d, y: 0.73623538884202d), new NpgsqlTypes.NpgsqlPoint(x: 0.967032114677046d, y: 0.06100016152346488d), new NpgsqlTypes.NpgsqlPoint(x: 0.4348885849429185d, y: 0.34734027742799345d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4052899008279207d, y: 0.9772201480227364d), new NpgsqlTypes.NpgsqlPoint(x: 0.8168440784444756d, y: 0.20555565487590177d), new NpgsqlTypes.NpgsqlPoint(x: 0.6222617486611468d, y: 0.7973175554778911d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4831258436359209d, y: 0.6171426159573513d), new NpgsqlTypes.NpgsqlPoint(x: 0.14164150028733025d, y: 0.13306506836307053d), new NpgsqlTypes.NpgsqlPoint(x: 0.293589589965099d, y: 0.11644933740700592d)), }, }));
                nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44376544658331996d, y: 0.3033570785608122d), new NpgsqlTypes.NpgsqlPoint(x: 0.1326458400327305d, y: 0.11490301298662298d), new NpgsqlTypes.NpgsqlPoint(x: 0.4336873547571497d, y: 0.12392579980303187d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7088656444288814d, y: 0.15261203030497594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8473442340753088d, y: 0.1945176322637786d), new NpgsqlTypes.NpgsqlPoint(x: 0.31514311166241604d, y: 0.387222917506288d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6261650705208471d, y: 0.8374373019579409d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166624080561813d, y: 0.8504960995300488d), new NpgsqlTypes.NpgsqlPoint(x: 0.9531976383233284d, y: 0.09327931512938725d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19314809679892464d, y: 0.06455162221955613d), new NpgsqlTypes.NpgsqlPoint(x: 0.6865223983419408d, y: 0.9530736196341969d), new NpgsqlTypes.NpgsqlPoint(x: 0.5705155161190147d, y: 0.9604774740559431d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1480518034210978d, y: 0.30493778246341563d), new NpgsqlTypes.NpgsqlPoint(x: 0.32670761901738077d, y: 0.42830564539562455d), new NpgsqlTypes.NpgsqlPoint(x: 0.07603243795734371d, y: 0.5159587225740934d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07101321685086748d, y: 0.07360617049504747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936475356507784d, y: 0.9866130009376488d), new NpgsqlTypes.NpgsqlPoint(x: 0.6047162294790819d, y: 0.24414738475771414d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48195325246569565d, y: 0.22941786826980726d), new NpgsqlTypes.NpgsqlPoint(x: 0.9226696516733173d, y: 0.12757998172998253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304321601070772d, y: 0.6645870924553218d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11856381119889292d, y: 0.8816763553660159d), new NpgsqlTypes.NpgsqlPoint(x: 0.38571202590782117d, y: 0.7079809629304954d), new NpgsqlTypes.NpgsqlPoint(x: 0.4437827311971737d, y: 0.07125640267237443d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD2E1M> models = null;

                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD2E1M> models = null;

                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 25;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 100, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 59, query1, 165, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 6, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 43, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 25, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 86, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 15, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 73, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 6, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 66, 121))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 147);
                var models =  ((INpgsqlPathMArraypathMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
FROM public.binary_npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathMArraypathMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI), typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

