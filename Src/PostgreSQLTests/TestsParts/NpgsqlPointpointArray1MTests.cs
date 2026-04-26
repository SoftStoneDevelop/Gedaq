

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
    internal partial interface INpgsqlPointArraypointArray
    {
    }
    
    internal partial class NpgsqlPointArraypointArray : INpgsqlPointArraypointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray1M[] _testData = new NpgsqlPointpointArray1M[]
        {
            new NpgsqlPointpointArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9260978062835169d, y: 0.6944311445396031d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9018696685861927d, y: 0.8547921641560624d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9057608748996678d, y: 0.03861150659837553d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9517973687071279d, y: 0.04725029292144223d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6177871391369537d, y: 0.9652573665492491d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9262912434649109d, y: 0.26969670273962976d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06258185820186879d, y: 0.2234684031889539d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7429811320133862d, y: 0.15343916886218278d),
new NpgsqlTypes.NpgsqlPoint(x: 0.803732161222311d, y: 0.18267787715659733d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5228211064854695d, y: 0.007175600374825231d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7503359260401686d, y: 0.0525813829121623d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7397304735362997d, y: 0.33007053891549d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43473114578924466d, y: 0.3073348963693193d),
new NpgsqlTypes.NpgsqlPoint(x: 0.739185192425033d, y: 0.4987731060604109d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9036189349260944d, y: 0.8720995699049895d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8109482347669255d, y: 0.570265581376935d),
new NpgsqlTypes.NpgsqlPoint(x: 0.846809135320779d, y: 0.6451449253670681d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9570791882556651d, y: 0.8238672091186755d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8611294168660092d, y: 0.8824531866895198d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9724690016650388d, y: 0.01913202716050111d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6934900898889473d, y: 0.47412377249671933d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9997776211481554d, y: 0.0861330172612802d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5456488027184422d, y: 0.3908352695390852d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22251823218648303d, y: 0.4409673959984505d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8421702318886732d, y: 0.27150877628598435d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22698449629056228d, y: 0.81843586507456d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9773960100568047d, y: 0.6798325896336125d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04881812828286003d, y: 0.05416911823271775d),
new NpgsqlTypes.NpgsqlPoint(x: 0.012164872527536952d, y: 0.803934996459072d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.753802103124939d, y: 0.5148037713935701d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7763937479639934d, y: 0.7160411219046167d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1469887074804277d, y: 0.583010473653453d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8996486025001508d, y: 0.43032301326828093d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5057703394495847d, y: 0.45724011348993787d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8515354286868959d, y: 0.17969280265375998d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5193404753014899d, y: 0.903292600842204d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7732668102617188d, y: 0.7203338180626314d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4242330279860358d, y: 0.24840369951853902d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44349743968169253d, y: 0.5724258798403076d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8197704752667182d, y: 0.026278833995020845d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44301574482177375d, y: 0.2478888316727884d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24418908166564257d, y: 0.7784425396103949d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7445475417780876d, y: 0.30091109220921397d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20480258308552957d, y: 0.2638619089726578d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43690494601946495d, y: 0.6264310023958268d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22902298357873985d, y: 0.5545623407376562d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25791684013823624d, y: 0.5418606692547524d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8938175777227163d, y: 0.8998822532321746d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6857943925014145d, y: 0.5213493494295837d),
new NpgsqlTypes.NpgsqlPoint(x: 0.875983602984104d, y: 0.9109121059612048d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48950947770329045d, y: 0.7331395367212885d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8800629526949408d, y: 0.7967185405850933d),
new NpgsqlTypes.NpgsqlPoint(x: 0.890961664000843d, y: 0.49939912417980814d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9300665108136351d, y: 0.18240001722083676d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15588986917326675d, y: 0.6073400705814227d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.264225881571436d, y: 0.5564598868521813d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6175161520753162d, y: 0.690830847396216d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6979944776973459d, y: 0.5327548034136939d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7994122349614661d, y: 0.757729582093234d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0609292772890192d, y: 0.14767549786364864d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34500960655009494d, y: 0.32635944307856724d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43229639224768746d, y: 0.3617935546335136d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6782357560954841d, y: 0.021469436119898377d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32571347482321267d, y: 0.4601691234798284d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3160297673007033d, y: 0.5375816122092443d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9971181079793268d, y: 0.436858657457195d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12053885057534375d, y: 0.6424859842962721d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0721857674065931d, y: 0.5471347007351406d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8847530044786954d, y: 0.7068032225957127d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9795063366111457d, y: 0.40302606833664456d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7172595694986793d, y: 0.1237143505581707d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8348664625072056d, y: 0.4016369372138695d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22685282689510078d, y: 0.7093918465119935d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7409364064370909d, y: 0.44633926443372396d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7960781148999201d, y: 0.8167945777075333d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5586353658129597d, y: 0.270339346720604d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.188047297666039d, y: 0.3391996274774266d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3419085149829668d, y: 0.06073862031194477d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7320575679567562d, y: 0.3188594944014177d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07141773763629233d, y: 0.19210172753402444d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7857838582143827d, y: 0.9052192458840412d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8514675928145174d, y: 0.7781804135088702d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1637048404567576d, y: 0.6620575042137873d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41583947299996293d, y: 0.7750699100972708d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7876854535584997d, y: 0.6655458665869407d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6329392531286552d, y: 0.31714914255364945d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3204893270639032d, y: 0.18329928413880825d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4359286786057961d, y: 0.6132677279199231d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4953838652373046d, y: 0.37252282940948833d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9549559442465209d, y: 0.8046145342337947d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4699330929197777d, y: 0.3638912373037242d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2887545412307527d, y: 0.10480886099924869d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31223836601182553d, y: 0.9681740451186657d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26646113783665426d, y: 0.49600726548770735d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6766510104973975d, y: 0.2055163353946028d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15898088124377663d, y: 0.8084961565602704d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9575532457884437d, y: 0.44573125657745216d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6395058480778036d, y: 0.765141704455161d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10371773347439828d, y: 0.7199737958527747d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9391407720783785d, y: 0.4319749012314974d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33927294782938167d, y: 0.043544201569869156d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07065134783661253d, y: 0.5072522476967066d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27994429030638557d, y: 0.9777702674539943d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20170777359983805d, y: 0.3779078060819345d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5746624173898485d, y: 0.5346384354725913d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5325464331679278d, y: 0.06451251893684429d),
new NpgsqlTypes.NpgsqlPoint(x: 0.755322865021492d, y: 0.4140836356434975d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1319950146046952d, y: 0.5607600296284281d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8845767671499396d, y: 0.0025776441820598572d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03762080156458403d, y: 0.1888174868881176d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7618881465643946d, y: 0.8078600713056607d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1641641789587195d, y: 0.8234065845792627d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4321458238447372d, y: 0.41401833345725925d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02873740367160349d, y: 0.3038128269807555d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4097418625437087d, y: 0.2957646453142564d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7995685716882516d, y: 0.6078940199704966d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5257256941066207d, y: 0.665846679775718d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37172685366383806d, y: 0.3318789236096302d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5786621723853946d, y: 0.33140652520937564d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9264801597867457d, y: 0.7436470405879773d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4384636267567682d, y: 0.9986920774544321d),
new NpgsqlTypes.NpgsqlPoint(x: 0.443263292654812d, y: 0.5718826990317074d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33308484160622d, y: 0.1957115368680813d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3668147997871405d, y: 0.24306913107081662d),
new NpgsqlTypes.NpgsqlPoint(x: 0.82728158776362d, y: 0.3665844952450924d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6754855838772144d, y: 0.06024763136012301d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04611470083528124d, y: 0.63175085271164d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.768576944931969d, y: 0.2961067843813273d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28816791708915535d, y: 0.31282212807098864d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29808658730259563d, y: 0.47704702679936617d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20345543375099218d, y: 0.6748505145313047d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5065442546949889d, y: 0.1903899919742974d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25436775621839525d, y: 0.19534825247549037d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.383354743391781d, y: 0.9273992641077362d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36906995991797187d, y: 0.9730595937160841d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2798088091478773d, y: 0.7269292227512913d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9911599401026766d, y: 0.8538557904827088d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5616291253184306d, y: 0.4641073179287343d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4572351201174938d, y: 0.6032844063934564d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6170093146063489d, y: 0.2152754446605426d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15417234588194484d, y: 0.8338109303403087d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2732787279000364d, y: 0.43814985474527657d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4927973181074109d, y: 0.14638667778519587d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37838951815295585d, y: 0.3345423366372934d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28037216596954406d, y: 0.4034122418198689d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05083821612749595d, y: 0.13028178590762496d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8775281191885723d, y: 0.31797532278173357d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4818715669853605d, y: 0.8735150719279436d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5633838645544661d, y: 0.7619250148770876d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7576790307095471d, y: 0.6787769280639561d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8484496712580459d, y: 0.36012792214805933d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8383361342454597d, y: 0.16596386286504883d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4609119981778709d, y: 0.25655234163653795d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1941484029978795d, y: 0.1483930850370765d),
new NpgsqlTypes.NpgsqlPoint(x: 0.020539927446126205d, y: 0.7812543960053286d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9625295718342304d, y: 0.33054472609399543d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6084014079089912d, y: 0.43267878595473175d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3075725723037155d, y: 0.9675259928648279d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6104700932449784d, y: 0.18416659363075627d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4715100835893523d, y: 0.5140997385350704d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5169824747474028d, y: 0.10701798183094857d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9917891534770343d, y: 0.7382238493735123d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04302597150840304d, y: 0.4135947321679917d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24921153201962065d, y: 0.6558541224551083d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10315034024489744d, y: 0.6357580513714521d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.010364545299911376d, y: 0.6882754967474363d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03463187140914237d, y: 0.4152009517614964d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3454727235608107d, y: 0.6510240858324529d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14128848727478116d, y: 0.8725348604907978d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6123778521931711d, y: 0.04942755024770573d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9553491055271566d, y: 0.16395893469088219d),
new NpgsqlTypes.NpgsqlPoint(x: 0.531946746554084d, y: 0.06295935652233253d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6803883299965406d, y: 0.8268265546129364d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1876079456280767d, y: 0.7685015903519635d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6301579196969636d, y: 0.8955564189728554d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18323015381911067d, y: 0.05312990665858586d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4678797896170622d, y: 0.4313513444688394d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3836862391479574d, y: 0.9473958106650098d),
new NpgsqlTypes.NpgsqlPoint(x: 0.00663123161983914d, y: 0.6100977862615232d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9746295813699352d, y: 0.3087079243794938d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22349689480418866d, y: 0.27212672775805846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6371295683107356d, y: 0.1847327110180309d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27339760752971964d, y: 0.07715864610138767d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4483340979228302d, y: 0.9765213939625332d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7992101601902778d, y: 0.7317258773923193d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4742810081104678d, y: 0.022480107735927013d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1349634096276897d, y: 0.9818688090953588d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7710629241233437d, y: 0.4352169002053924d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5746632337830376d, y: 0.0007810432877323192d),
new NpgsqlTypes.NpgsqlPoint(x: 0.942268719326062d, y: 0.01145633588668793d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.023113731617839695d, y: 0.9814111252720037d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1951367041661729d, y: 0.8232094343026721d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4942188860035094d, y: 0.2651894996569554d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3282971281292215d, y: 0.47640133147147046d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8626611491543795d, y: 0.09145679745229163d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6920887461355664d, y: 0.4930456021490097d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06585705773380779d, y: 0.564307089110851d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26536031294700724d, y: 0.674554311029694d),
new NpgsqlTypes.NpgsqlPoint(x: 0.031822415979658625d, y: 0.994292835084394d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2146792316649878d, y: 0.45969158864595905d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46360849979487917d, y: 0.0946633523561714d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8817926120097247d, y: 0.286495853977913d),
new NpgsqlTypes.NpgsqlPoint(x: 0.910539435088634d, y: 0.5017450748581647d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7704532167462783d, y: 0.8612473274326538d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8990969518665846d, y: 0.5366311233740628d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6033228019687233d, y: 0.32205768752079056d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5129015707715537d, y: 0.3766697909010587d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8866298036522442d, y: 0.38865855741113964d),
new NpgsqlTypes.NpgsqlPoint(x: 0.555024197691935d, y: 0.9778489285023044d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5076129635759679d, y: 0.5100611399282874d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4466997662918045d, y: 0.09095658871770285d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2402650921989289d, y: 0.6300243101431929d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17806999111961663d, y: 0.4263293331185749d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6034303140885577d, y: 0.5412332095956508d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47116346422828215d, y: 0.4890402067067313d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.487697541237902d, y: 0.967841480751412d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07740658323801752d, y: 0.5564979629224137d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40649408490337746d, y: 0.9197223616864649d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22592924113469648d, y: 0.27256661283412587d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07691085587544444d, y: 0.6351607272862688d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04996950035546022d, y: 0.6970186097798022d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6946828325168615d, y: 0.962315102532146d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41869409786331824d, y: 0.6505318261430231d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27830635681957894d, y: 0.6269163987683314d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9394779448825754d, y: 0.9822366741200265d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35899667981664973d, y: 0.11178284587184828d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6684063848562892d, y: 0.9945774978212837d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3186445711576007d, y: 0.9366962510309809d),
new NpgsqlTypes.NpgsqlPoint(x: 0.904877644173804d, y: 0.9090897694266572d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21164719739100746d, y: 0.6689448245843425d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2383186591345947d, y: 0.7567695764815477d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7695621327175824d, y: 0.9609476589668722d),
new NpgsqlTypes.NpgsqlPoint(x: 0.060133731824640324d, y: 0.33110830633452715d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07267985657858977d, y: 0.30102649453529284d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40863737018723845d, y: 0.5036136930191527d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6545382937716487d, y: 0.967614464265013d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9085192698127486d, y: 0.38941344607803985d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
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

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0609292772890192d, y: 0.14767549786364864d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34500960655009494d, y: 0.32635944307856724d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43229639224768746d, y: 0.3617935546335136d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6782357560954841d, y: 0.021469436119898377d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4359286786057961d, y: 0.6132677279199231d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4953838652373046d, y: 0.37252282940948833d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9549559442465209d, y: 0.8046145342337947d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4699330929197777d, y: 0.3638912373037242d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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

                var models = await ((INpgsqlPointArraypointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlPointArraypointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPointArraypointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[2], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[3], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[4], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[5], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[24],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[25],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[26],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[29], false);
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

                var models =  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 84, query1, 99, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 53, query1, 53, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelBatchAsync(connection, 109, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[1], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[2], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[3], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[4], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[5], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[24],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[25],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[26],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[27],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[28],_testData[29], false);
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
                var models =  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelBatch(connection, 17, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[3], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[4], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[5], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[24],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[25],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 41);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1m m
LEFT JOIN public.binary_npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1M>(15);

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
                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

