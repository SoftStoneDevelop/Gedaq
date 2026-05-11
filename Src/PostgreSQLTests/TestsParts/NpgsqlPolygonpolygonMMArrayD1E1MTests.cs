

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
    internal partial interface INpgsqlPolygonMArraypolygonMMArrayD1
    {
    }
    
    internal partial class NpgsqlPolygonMArraypolygonMMArrayD1 : INpgsqlPolygonMArraypolygonMMArrayD1
    {


#region TestData

        private readonly NpgsqlPolygonpolygonMMArrayD1E1M[] _testData = new NpgsqlPolygonpolygonMMArrayD1E1M[]
        {
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03641109492872652d, y: 0.06039914910767419d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560519322857695d, y: 0.9912132924958746d), new NpgsqlTypes.NpgsqlPoint(x: 0.5134427720636984d, y: 0.6161479689530742d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5339900387175301d, y: 0.32772040551373394d), new NpgsqlTypes.NpgsqlPoint(x: 0.02244531559366214d, y: 0.5364983634444438d), new NpgsqlTypes.NpgsqlPoint(x: 0.39346088063381457d, y: 0.6017576850918505d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6102429391611741d, y: 0.48433774113544514d), new NpgsqlTypes.NpgsqlPoint(x: 0.2577711506267789d, y: 0.8916796401066895d), new NpgsqlTypes.NpgsqlPoint(x: 0.47067172318827044d, y: 0.405366209576995d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9133852212671613d, y: 0.14667573937228606d), new NpgsqlTypes.NpgsqlPoint(x: 0.01330010121378955d, y: 0.5890395996622554d), new NpgsqlTypes.NpgsqlPoint(x: 0.8226213105163861d, y: 0.16470722887382994d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.050720136653594206d, y: 0.3795110260439465d), new NpgsqlTypes.NpgsqlPoint(x: 0.5643093693972052d, y: 0.9929199089350557d), new NpgsqlTypes.NpgsqlPoint(x: 0.340352705702045d, y: 0.4836847080458355d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6727505456050177d, y: 0.22985171972270424d), new NpgsqlTypes.NpgsqlPoint(x: 0.26895775237812924d, y: 0.8119132846913808d), new NpgsqlTypes.NpgsqlPoint(x: 0.5250477157073491d, y: 0.1280420393123508d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9503966862489556d, y: 0.5333903400553337d), new NpgsqlTypes.NpgsqlPoint(x: 0.8599634898349097d, y: 0.216277704360073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5925763630601727d, y: 0.324078586417064d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5201964340555606d, y: 0.23204435836402648d), new NpgsqlTypes.NpgsqlPoint(x: 0.8995778852425312d, y: 0.5661576613293557d), new NpgsqlTypes.NpgsqlPoint(x: 0.2495211973365813d, y: 0.34899732187166244d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07757052001303999d, y: 0.5919137083737112d), new NpgsqlTypes.NpgsqlPoint(x: 0.5588825360095917d, y: 0.6744042308730697d), new NpgsqlTypes.NpgsqlPoint(x: 0.09926863349056292d, y: 0.7691211739799443d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.919806688163853d, y: 0.7777095871421403d), new NpgsqlTypes.NpgsqlPoint(x: 0.012014707082309672d, y: 0.14690295426275657d), new NpgsqlTypes.NpgsqlPoint(x: 0.40010831319869566d, y: 0.8658546364934093d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09393712817152333d, y: 0.2558601938320001d), new NpgsqlTypes.NpgsqlPoint(x: 0.171794930587011d, y: 0.7948866495504843d), new NpgsqlTypes.NpgsqlPoint(x: 0.4715578276329394d, y: 0.35638951698845156d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7592265689918796d, y: 0.7996020969597137d), new NpgsqlTypes.NpgsqlPoint(x: 0.8582109132012288d, y: 0.9246938594209544d), new NpgsqlTypes.NpgsqlPoint(x: 0.13895276433772497d, y: 0.3473533062148839d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5541749546089462d, y: 0.8565410803169364d), new NpgsqlTypes.NpgsqlPoint(x: 0.25257475947711727d, y: 0.2374077744592168d), new NpgsqlTypes.NpgsqlPoint(x: 0.45955568850035544d, y: 0.7123867455828892d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3581867398569166d, y: 0.4254318822772528d), new NpgsqlTypes.NpgsqlPoint(x: 0.5767813402682704d, y: 0.6098795063090273d), new NpgsqlTypes.NpgsqlPoint(x: 0.5451809626301675d, y: 0.6624543512732944d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9324103692043754d, y: 0.42709763248388766d), new NpgsqlTypes.NpgsqlPoint(x: 0.082241601577005d, y: 0.8162616896391339d), new NpgsqlTypes.NpgsqlPoint(x: 0.924020133741797d, y: 0.31162978680951103d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4482512126487518d, y: 0.1396459245178101d), new NpgsqlTypes.NpgsqlPoint(x: 0.2297910245327741d, y: 0.16481907274697127d), new NpgsqlTypes.NpgsqlPoint(x: 0.7364530029313824d, y: 0.3604858106601717d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8023946721975385d, y: 0.13549263506665643d), new NpgsqlTypes.NpgsqlPoint(x: 0.5479190791353362d, y: 0.06438112434146537d), new NpgsqlTypes.NpgsqlPoint(x: 0.8802580125446026d, y: 0.01262611482365239d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7833469261054452d, y: 0.1422501889252381d), new NpgsqlTypes.NpgsqlPoint(x: 0.5291118846794923d, y: 0.183189697304743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747587648810867d, y: 0.9150253629869352d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48891488038477204d, y: 0.8902547374996153d), new NpgsqlTypes.NpgsqlPoint(x: 0.8222617459605231d, y: 0.1860352907663524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5242888513392965d, y: 0.1232089856916001d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2674608347814512d, y: 0.40226478535914223d), new NpgsqlTypes.NpgsqlPoint(x: 0.7990672732016628d, y: 0.971619415693671d), new NpgsqlTypes.NpgsqlPoint(x: 0.909807328339829d, y: 0.606067161541379d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8705351929797184d, y: 0.1835152527445847d), new NpgsqlTypes.NpgsqlPoint(x: 0.6017138826724385d, y: 0.7369611474086966d), new NpgsqlTypes.NpgsqlPoint(x: 0.12279719234018305d, y: 0.6075008169318585d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05998749872189657d, y: 0.3843003752075713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9179480433722538d, y: 0.26611712721407665d), new NpgsqlTypes.NpgsqlPoint(x: 0.7861059937288601d, y: 0.8132453574635515d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21716996555079404d, y: 0.9135020994870936d), new NpgsqlTypes.NpgsqlPoint(x: 0.3969218438966243d, y: 0.08037550594843434d), new NpgsqlTypes.NpgsqlPoint(x: 0.4501433094045194d, y: 0.7992200477112082d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5986741730148222d, y: 0.4463375067881221d), new NpgsqlTypes.NpgsqlPoint(x: 0.606961417820386d, y: 0.5318972110574468d), new NpgsqlTypes.NpgsqlPoint(x: 0.08507132959647434d, y: 0.23522158750402422d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8463884944794772d, y: 0.831426438894732d), new NpgsqlTypes.NpgsqlPoint(x: 0.11895834788192972d, y: 0.5292615151320204d), new NpgsqlTypes.NpgsqlPoint(x: 0.20012232054789048d, y: 0.7282671470533281d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3910596796049981d, y: 0.4045718550359946d), new NpgsqlTypes.NpgsqlPoint(x: 0.8787542660967113d, y: 0.9950134538945742d), new NpgsqlTypes.NpgsqlPoint(x: 0.38493071279907487d, y: 0.1975734867092247d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19962806120707866d, y: 0.8128825337374994d), new NpgsqlTypes.NpgsqlPoint(x: 0.6019470001370442d, y: 0.8290720121897072d), new NpgsqlTypes.NpgsqlPoint(x: 0.3204388746073201d, y: 0.7020344325132764d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6219350499492752d, y: 0.9485560676100077d), new NpgsqlTypes.NpgsqlPoint(x: 0.20736465016101213d, y: 0.8569376384660958d), new NpgsqlTypes.NpgsqlPoint(x: 0.8311086239737703d, y: 0.37533330953777677d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8797439074920006d, y: 0.5990145638021445d), new NpgsqlTypes.NpgsqlPoint(x: 0.8358825607173139d, y: 0.40580649692567317d), new NpgsqlTypes.NpgsqlPoint(x: 0.8016449208938969d, y: 0.5149221106031076d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5759623404371178d, y: 0.9213141324243862d), new NpgsqlTypes.NpgsqlPoint(x: 0.16219159964235907d, y: 0.5642492221367137d), new NpgsqlTypes.NpgsqlPoint(x: 0.5317895055027902d, y: 0.7101204234963179d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39567477840298915d, y: 0.185130474004076d), new NpgsqlTypes.NpgsqlPoint(x: 0.7775064477407356d, y: 0.5275301446634381d), new NpgsqlTypes.NpgsqlPoint(x: 0.8064850037617458d, y: 0.5022410340434812d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9082588493635416d, y: 0.7311872670463754d), new NpgsqlTypes.NpgsqlPoint(x: 0.20950666711834887d, y: 0.5983129045679804d), new NpgsqlTypes.NpgsqlPoint(x: 0.8042959656251111d, y: 0.08278713837366414d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6770968450404341d, y: 0.6325507082068624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8461801276545317d, y: 0.7350596235160316d), new NpgsqlTypes.NpgsqlPoint(x: 0.3096364055451568d, y: 0.5222835548538823d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4954221434549231d, y: 0.5992787394039846d), new NpgsqlTypes.NpgsqlPoint(x: 0.25513594423650854d, y: 0.3976666254359802d), new NpgsqlTypes.NpgsqlPoint(x: 0.7677796311435259d, y: 0.9270692761725599d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10795698294324985d, y: 0.3252875220649458d), new NpgsqlTypes.NpgsqlPoint(x: 0.9822793433883458d, y: 0.45119692607699435d), new NpgsqlTypes.NpgsqlPoint(x: 0.4184832047026882d, y: 0.08748129266991611d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13067061019029202d, y: 0.0009871805056499428d), new NpgsqlTypes.NpgsqlPoint(x: 0.6114474871938501d, y: 0.5654183934924116d), new NpgsqlTypes.NpgsqlPoint(x: 0.12942723756608054d, y: 0.332151174509299d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8240027443913553d, y: 0.8186672616462036d), new NpgsqlTypes.NpgsqlPoint(x: 0.20428942908692904d, y: 0.3953083032722221d), new NpgsqlTypes.NpgsqlPoint(x: 0.10897588878509534d, y: 0.6386877838019032d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5339578411093d, y: 0.198843401954374d), new NpgsqlTypes.NpgsqlPoint(x: 0.3240320173466006d, y: 0.7319856305430992d), new NpgsqlTypes.NpgsqlPoint(x: 0.26310327040130965d, y: 0.6016224264822342d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1773261411510434d, y: 0.7519196725612728d), new NpgsqlTypes.NpgsqlPoint(x: 0.40624661723135236d, y: 0.1901130892523153d), new NpgsqlTypes.NpgsqlPoint(x: 0.2466756385272708d, y: 0.161119274275909d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8138420907606359d, y: 0.8197826036968573d), new NpgsqlTypes.NpgsqlPoint(x: 0.7478085601701313d, y: 0.8220195917125966d), new NpgsqlTypes.NpgsqlPoint(x: 0.1325300670505246d, y: 0.05534648742206838d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4483374826199802d, y: 0.2607086615656944d), new NpgsqlTypes.NpgsqlPoint(x: 0.10644951172532913d, y: 0.09555429694825546d), new NpgsqlTypes.NpgsqlPoint(x: 0.9806315259073523d, y: 0.8387538835440669d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6869269005706482d, y: 0.3685206440944072d), new NpgsqlTypes.NpgsqlPoint(x: 0.27280590369024926d, y: 0.4301336780399413d), new NpgsqlTypes.NpgsqlPoint(x: 0.8381467105859701d, y: 0.23957674008166596d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07449213344665684d, y: 0.4907671363858269d), new NpgsqlTypes.NpgsqlPoint(x: 0.49289167856699945d, y: 0.23369974911426494d), new NpgsqlTypes.NpgsqlPoint(x: 0.060520151170504244d, y: 0.08612780156821442d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8132669796250477d, y: 0.528122684014864d), new NpgsqlTypes.NpgsqlPoint(x: 0.0984715578131602d, y: 0.07209253618777933d), new NpgsqlTypes.NpgsqlPoint(x: 0.1035913733097027d, y: 0.5038764967851694d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5682281615741187d, y: 0.2130978169827964d), new NpgsqlTypes.NpgsqlPoint(x: 0.9305920366598902d, y: 0.3772701765346216d), new NpgsqlTypes.NpgsqlPoint(x: 0.53568577698237d, y: 0.5998614263592157d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18352243957718017d, y: 0.5149872773685431d), new NpgsqlTypes.NpgsqlPoint(x: 0.05382980484224098d, y: 0.13248901457462314d), new NpgsqlTypes.NpgsqlPoint(x: 0.44636847397942014d, y: 0.7839472970587473d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7074803874570592d, y: 0.3643257265662534d), new NpgsqlTypes.NpgsqlPoint(x: 0.056187401653983726d, y: 0.0771346492521291d), new NpgsqlTypes.NpgsqlPoint(x: 0.619149365547941d, y: 0.5545190270867976d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9118754509731856d, y: 0.3433517980529941d), new NpgsqlTypes.NpgsqlPoint(x: 0.7841364802448385d, y: 0.47441273117482485d), new NpgsqlTypes.NpgsqlPoint(x: 0.8365661762781009d, y: 0.9661234714339679d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7194819058836368d, y: 0.7729294582216552d), new NpgsqlTypes.NpgsqlPoint(x: 0.3383918284789814d, y: 0.09939843600478093d), new NpgsqlTypes.NpgsqlPoint(x: 0.9893426193687307d, y: 0.18694455898243267d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8490374486274177d, y: 0.31930362836825144d), new NpgsqlTypes.NpgsqlPoint(x: 0.3823520838542017d, y: 0.642900595637768d), new NpgsqlTypes.NpgsqlPoint(x: 0.9986328588750001d, y: 0.9268703985746392d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10908219639190386d, y: 0.8122128569307989d), new NpgsqlTypes.NpgsqlPoint(x: 0.3853381752789292d, y: 0.7032976110501574d), new NpgsqlTypes.NpgsqlPoint(x: 0.6886110261693633d, y: 0.11953897465260888d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7449834124736465d, y: 0.6158183238144591d), new NpgsqlTypes.NpgsqlPoint(x: 0.5517910251592649d, y: 0.5469286848381121d), new NpgsqlTypes.NpgsqlPoint(x: 0.004685853724951672d, y: 0.8310965547937235d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2658754296651813d, y: 0.628348765712317d), new NpgsqlTypes.NpgsqlPoint(x: 0.23434432242077763d, y: 0.9746659294094735d), new NpgsqlTypes.NpgsqlPoint(x: 0.37065055791810564d, y: 0.16333271941115624d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37537246122736845d, y: 0.5137171005432593d), new NpgsqlTypes.NpgsqlPoint(x: 0.990088561484869d, y: 0.5686562540481721d), new NpgsqlTypes.NpgsqlPoint(x: 0.09146409605138672d, y: 0.7495239918026478d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4330825968201335d, y: 0.9845727865827075d), new NpgsqlTypes.NpgsqlPoint(x: 0.5031668116080165d, y: 0.26589039620030064d), new NpgsqlTypes.NpgsqlPoint(x: 0.8899967016665357d, y: 0.43402839808671834d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2136236453402104d, y: 0.27025115891947116d), new NpgsqlTypes.NpgsqlPoint(x: 0.7002401281654308d, y: 0.586046259040777d), new NpgsqlTypes.NpgsqlPoint(x: 0.5991855548104004d, y: 0.9818645370102648d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5161148455476018d, y: 0.30190106234151093d), new NpgsqlTypes.NpgsqlPoint(x: 0.05916501306588584d, y: 0.49582479799966017d), new NpgsqlTypes.NpgsqlPoint(x: 0.050053428649312615d, y: 0.0318994457312326d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48823627548011383d, y: 0.08843994547820355d), new NpgsqlTypes.NpgsqlPoint(x: 0.43031737419212057d, y: 0.3916127052247087d), new NpgsqlTypes.NpgsqlPoint(x: 0.9392395512388052d, y: 0.25973569598490853d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012980900622511005d, y: 0.7698949640637273d), new NpgsqlTypes.NpgsqlPoint(x: 0.12192609666731424d, y: 0.561253131944974d), new NpgsqlTypes.NpgsqlPoint(x: 0.10286143583906249d, y: 0.6828868454096716d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9218648292040251d, y: 0.7948698129793673d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836923373421041d, y: 0.9357204545307424d), new NpgsqlTypes.NpgsqlPoint(x: 0.4853430693400381d, y: 0.35792935863657893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7222174310427292d, y: 0.7480963334416715d), new NpgsqlTypes.NpgsqlPoint(x: 0.37603817948666907d, y: 0.6397140674236375d), new NpgsqlTypes.NpgsqlPoint(x: 0.9268311196691715d, y: 0.8524611678477618d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6332516843380375d, y: 0.43379943796379383d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552232544086195d, y: 0.9505287612091522d), new NpgsqlTypes.NpgsqlPoint(x: 0.21372465472931368d, y: 0.2354202132512021d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7291079219198305d, y: 0.8096009342246706d), new NpgsqlTypes.NpgsqlPoint(x: 0.2168722284064949d, y: 0.026168992311208616d), new NpgsqlTypes.NpgsqlPoint(x: 0.1525383470350512d, y: 0.7010531318635497d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08487474678352125d, y: 0.3750660262704374d), new NpgsqlTypes.NpgsqlPoint(x: 0.3826072902466433d, y: 0.6794900017105533d), new NpgsqlTypes.NpgsqlPoint(x: 0.6507650971787023d, y: 0.8270855467748761d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44842867146513943d, y: 0.899319840822544d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928604095778161d, y: 0.465717499101182d), new NpgsqlTypes.NpgsqlPoint(x: 0.15422586302504826d, y: 0.21748367690886095d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48970083942735354d, y: 0.9840471120449706d), new NpgsqlTypes.NpgsqlPoint(x: 0.5338333146108906d, y: 0.8143287049787262d), new NpgsqlTypes.NpgsqlPoint(x: 0.028082973305723735d, y: 0.9220343507307858d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31598662818847234d, y: 0.8530809611687238d), new NpgsqlTypes.NpgsqlPoint(x: 0.9007900842184167d, y: 0.5489976685218521d), new NpgsqlTypes.NpgsqlPoint(x: 0.8902193206592173d, y: 0.34671103123824265d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.861078415307143d, y: 0.7838933758470328d), new NpgsqlTypes.NpgsqlPoint(x: 0.3824310387739187d, y: 0.7183257600139562d), new NpgsqlTypes.NpgsqlPoint(x: 0.32728019874708303d, y: 0.5682888444945217d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9210282029813038d, y: 0.12990769785142842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8672917914947856d, y: 0.032307007731677495d), new NpgsqlTypes.NpgsqlPoint(x: 0.7174874859015787d, y: 0.369992898260039d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2877047431542469d, y: 0.9989938113984939d), new NpgsqlTypes.NpgsqlPoint(x: 0.029805134325282978d, y: 0.5955820149614001d), new NpgsqlTypes.NpgsqlPoint(x: 0.2199372841046d, y: 0.3325997014514198d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3464520548549487d, y: 0.5891741264656734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4351468320206159d, y: 0.4752384666271161d), new NpgsqlTypes.NpgsqlPoint(x: 0.6959499313443344d, y: 0.9746489648332832d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37091666577724025d, y: 0.023835362096631063d), new NpgsqlTypes.NpgsqlPoint(x: 0.08400089413142875d, y: 0.7986239701200414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4965941101480913d, y: 0.5494196567696283d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9487474162746825d, y: 0.7622761282160327d), new NpgsqlTypes.NpgsqlPoint(x: 0.27399165879520504d, y: 0.1705800403884945d), new NpgsqlTypes.NpgsqlPoint(x: 0.8296434706443213d, y: 0.7341557332207365d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09246588309421744d, y: 0.5635878730297115d), new NpgsqlTypes.NpgsqlPoint(x: 0.4512196625901219d, y: 0.20980745106940846d), new NpgsqlTypes.NpgsqlPoint(x: 0.10963068611139937d, y: 0.7030069653536949d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3935061546373496d, y: 0.16401907620157086d), new NpgsqlTypes.NpgsqlPoint(x: 0.33442483976123916d, y: 0.5945229734458883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7783993694172264d, y: 0.7063194813449727d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7286482653637498d, y: 0.3973060606378629d), new NpgsqlTypes.NpgsqlPoint(x: 0.005762932130796816d, y: 0.2473266477206345d), new NpgsqlTypes.NpgsqlPoint(x: 0.7944094023934088d, y: 0.2868225988509562d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8530894671347593d, y: 0.10276088222807289d), new NpgsqlTypes.NpgsqlPoint(x: 0.7999318160036206d, y: 0.4805700106345674d), new NpgsqlTypes.NpgsqlPoint(x: 0.9086823866814788d, y: 0.9346686029284155d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.70741558770974d, y: 0.6089644779367511d), new NpgsqlTypes.NpgsqlPoint(x: 0.24113672097031558d, y: 0.6943061668164772d), new NpgsqlTypes.NpgsqlPoint(x: 0.8589444801070052d, y: 0.6297951254044675d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5079366262681068d, y: 0.3190496964104039d), new NpgsqlTypes.NpgsqlPoint(x: 0.49976612698178846d, y: 0.5550668623684466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869270280553541d, y: 0.5297729460674853d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08450117614279151d, y: 0.10530319812797984d), new NpgsqlTypes.NpgsqlPoint(x: 0.8783065438133787d, y: 0.663424941202454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4914743703355854d, y: 0.512940252957798d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22847300470645215d, y: 0.1243075135449303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8572565294207507d, y: 0.7442932373076854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236220696734953d, y: 0.2892232870564234d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5882475267840379d, y: 0.4495419587100483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9078391246103569d, y: 0.6913395902738552d), new NpgsqlTypes.NpgsqlPoint(x: 0.10242549464536743d, y: 0.6657402041204259d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3888375676003606d, y: 0.3578183332050263d), new NpgsqlTypes.NpgsqlPoint(x: 0.9959682939903779d, y: 0.9494201189780195d), new NpgsqlTypes.NpgsqlPoint(x: 0.9567767389245123d, y: 0.10804897032012795d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5198484220026545d, y: 0.46596013030751215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668239487795724d, y: 0.7792763285856666d), new NpgsqlTypes.NpgsqlPoint(x: 0.21702894064070943d, y: 0.4778237559110077d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9733682207152562d, y: 0.17731877300343069d), new NpgsqlTypes.NpgsqlPoint(x: 0.7023356354911915d, y: 0.620981240878141d), new NpgsqlTypes.NpgsqlPoint(x: 0.46024605182269174d, y: 0.7821736390376682d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8876410528100835d, y: 0.1742564671129594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8844697922989458d, y: 0.49454438890048313d), new NpgsqlTypes.NpgsqlPoint(x: 0.30176207248857345d, y: 0.4834879575232096d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4790247908934864d, y: 0.045702947047969955d), new NpgsqlTypes.NpgsqlPoint(x: 0.6471599088389226d, y: 0.9506435170924742d), new NpgsqlTypes.NpgsqlPoint(x: 0.600488097573149d, y: 0.31833406703586453d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6521019449197109d, y: 0.35631262376138617d), new NpgsqlTypes.NpgsqlPoint(x: 0.4086009638592869d, y: 0.5537944803911368d), new NpgsqlTypes.NpgsqlPoint(x: 0.3939788151019976d, y: 0.031306377573487976d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3857287715890976d, y: 0.5566838469297477d), new NpgsqlTypes.NpgsqlPoint(x: 0.7727688545440685d, y: 0.0864533632300647d), new NpgsqlTypes.NpgsqlPoint(x: 0.2561990740999659d, y: 0.750525506626731d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9099847886935649d, y: 0.5841706577583528d), new NpgsqlTypes.NpgsqlPoint(x: 0.14514527375910025d, y: 0.8020006615905073d), new NpgsqlTypes.NpgsqlPoint(x: 0.9676199189415124d, y: 0.16247393647862018d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21874752515673856d, y: 0.6515430601306902d), new NpgsqlTypes.NpgsqlPoint(x: 0.2646973993608447d, y: 0.29208795193515813d), new NpgsqlTypes.NpgsqlPoint(x: 0.6104480974742275d, y: 0.782725086588742d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5018638580067002d, y: 0.8538153128186019d), new NpgsqlTypes.NpgsqlPoint(x: 0.2354196142870547d, y: 0.6957281006342381d), new NpgsqlTypes.NpgsqlPoint(x: 0.06826169643599145d, y: 0.07942034714652058d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22039990633133677d, y: 0.5447731046516778d), new NpgsqlTypes.NpgsqlPoint(x: 0.23829139901778562d, y: 0.8072994975979513d), new NpgsqlTypes.NpgsqlPoint(x: 0.6568467668927003d, y: 0.3939731810357223d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7439823226880423d, y: 0.7722325123320178d), new NpgsqlTypes.NpgsqlPoint(x: 0.4119571050331392d, y: 0.27870222736799743d), new NpgsqlTypes.NpgsqlPoint(x: 0.4831254680990017d, y: 0.8353661624034286d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4332922021053285d, y: 0.29506067632189736d), new NpgsqlTypes.NpgsqlPoint(x: 0.9203803845598036d, y: 0.43593115955212447d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936347044997798d, y: 0.2564107160749902d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7315355999388559d, y: 0.9238598263399886d), new NpgsqlTypes.NpgsqlPoint(x: 0.8797344047274257d, y: 0.1447403177696306d), new NpgsqlTypes.NpgsqlPoint(x: 0.916736396608297d, y: 0.48421886679570314d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4540197241285304d, y: 0.16698988168014361d), new NpgsqlTypes.NpgsqlPoint(x: 0.3366578364209477d, y: 0.9402505052960197d), new NpgsqlTypes.NpgsqlPoint(x: 0.9904831271110468d, y: 0.4255287977184028d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3137789351439848d, y: 0.21820934719603036d), new NpgsqlTypes.NpgsqlPoint(x: 0.7589257723192242d, y: 0.7189642330918539d), new NpgsqlTypes.NpgsqlPoint(x: 0.8127717074391044d, y: 0.6585947199452463d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3873396959795845d, y: 0.40134731494745823d), new NpgsqlTypes.NpgsqlPoint(x: 0.756614175357064d, y: 0.09279818144376206d), new NpgsqlTypes.NpgsqlPoint(x: 0.05428415266509312d, y: 0.17898418048178732d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14177974291790052d, y: 0.12652374297399238d), new NpgsqlTypes.NpgsqlPoint(x: 0.8015845469803893d, y: 0.38041385126244975d), new NpgsqlTypes.NpgsqlPoint(x: 0.20244233470828288d, y: 0.11479983530289228d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08837620457775086d, y: 0.8511473473620795d), new NpgsqlTypes.NpgsqlPoint(x: 0.02061940198798551d, y: 0.8099863152330489d), new NpgsqlTypes.NpgsqlPoint(x: 0.07299519148088873d, y: 0.3783895273526514d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8837929308969082d, y: 0.4335510147088163d), new NpgsqlTypes.NpgsqlPoint(x: 0.4556634271391221d, y: 0.290873823834528d), new NpgsqlTypes.NpgsqlPoint(x: 0.48117645706125955d, y: 0.05794477903898354d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9744947643265429d, y: 0.29405927233703644d), new NpgsqlTypes.NpgsqlPoint(x: 0.9244153709157958d, y: 0.14858443865949356d), new NpgsqlTypes.NpgsqlPoint(x: 0.0035407230109705257d, y: 0.654138862243678d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6942406075904273d, y: 0.13496524607199545d), new NpgsqlTypes.NpgsqlPoint(x: 0.08017488891317737d, y: 0.8363025137687635d), new NpgsqlTypes.NpgsqlPoint(x: 0.985912870137261d, y: 0.135005941129137d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7581627103761482d, y: 0.14719002352804578d), new NpgsqlTypes.NpgsqlPoint(x: 0.29085128675915517d, y: 0.1904846455343414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4647596153614282d, y: 0.38545816735996163d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17288402429485927d, y: 0.3776724046055351d), new NpgsqlTypes.NpgsqlPoint(x: 0.426608837961427d, y: 0.7644500698077733d), new NpgsqlTypes.NpgsqlPoint(x: 0.5542255360135935d, y: 0.3312316825763384d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.507388460619208d, y: 0.25448207798521694d), new NpgsqlTypes.NpgsqlPoint(x: 0.626494363609934d, y: 0.4086093388887837d), new NpgsqlTypes.NpgsqlPoint(x: 0.42425355883195504d, y: 0.6225740726612307d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15918868654062646d, y: 0.7770221043429671d), new NpgsqlTypes.NpgsqlPoint(x: 0.14953706796905253d, y: 0.30077594079344716d), new NpgsqlTypes.NpgsqlPoint(x: 0.7020141789690302d, y: 0.12296653634873744d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9900425333207725d, y: 0.20615922904853246d), new NpgsqlTypes.NpgsqlPoint(x: 0.6093033854307447d, y: 0.4314382570764549d), new NpgsqlTypes.NpgsqlPoint(x: 0.4219162287532615d, y: 0.842695388344217d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06565565928538697d, y: 0.2691797431507449d), new NpgsqlTypes.NpgsqlPoint(x: 0.808542572560778d, y: 0.603788319184435d), new NpgsqlTypes.NpgsqlPoint(x: 0.2398180575547143d, y: 0.8331794216835131d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8243264869355813d, y: 0.31053742515043725d), new NpgsqlTypes.NpgsqlPoint(x: 0.1510256303710379d, y: 0.3648942372325512d), new NpgsqlTypes.NpgsqlPoint(x: 0.573643403253444d, y: 0.7040522484237717d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9334245617110479d, y: 0.7080466356821771d), new NpgsqlTypes.NpgsqlPoint(x: 0.11831712472335232d, y: 0.7785202027513908d), new NpgsqlTypes.NpgsqlPoint(x: 0.6234157786496459d, y: 0.5037835834508892d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8648743524257524d, y: 0.7459537458841078d), new NpgsqlTypes.NpgsqlPoint(x: 0.3447339403055114d, y: 0.7658954492937463d), new NpgsqlTypes.NpgsqlPoint(x: 0.08817898571367278d, y: 0.2741677005724319d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.844566684921568d, y: 0.056060215831365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5345677855844324d, y: 0.07569704414575806d), new NpgsqlTypes.NpgsqlPoint(x: 0.5929439785781413d, y: 0.8151185095869699d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20032888208573518d, y: 0.6402249199615487d), new NpgsqlTypes.NpgsqlPoint(x: 0.639593989625253d, y: 0.6642942978515269d), new NpgsqlTypes.NpgsqlPoint(x: 0.7956798242559995d, y: 0.6490766974823252d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12836412756552573d, y: 0.8395154257602326d), new NpgsqlTypes.NpgsqlPoint(x: 0.12151099450716885d, y: 0.2321148044350536d), new NpgsqlTypes.NpgsqlPoint(x: 0.8659471644079061d, y: 0.01909446994553754d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8713510307861172d, y: 0.6698352747353268d), new NpgsqlTypes.NpgsqlPoint(x: 0.04461885776099417d, y: 0.0408877054612633d), new NpgsqlTypes.NpgsqlPoint(x: 0.25415164467511964d, y: 0.4227722451403202d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5571755157568758d, y: 0.7245638212450377d), new NpgsqlTypes.NpgsqlPoint(x: 0.28903402066221606d, y: 0.8943346122983706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8604319195811392d, y: 0.05691184811429306d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24144171497492495d, y: 0.1557634750867728d), new NpgsqlTypes.NpgsqlPoint(x: 0.06981865154477818d, y: 0.6812034695146585d), new NpgsqlTypes.NpgsqlPoint(x: 0.999553880694618d, y: 0.35600714549020085d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9618301934987094d, y: 0.8650649954495103d), new NpgsqlTypes.NpgsqlPoint(x: 0.8475436973012527d, y: 0.2639508210385195d), new NpgsqlTypes.NpgsqlPoint(x: 0.28103096742212486d, y: 0.24137172014669717d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.722287768770547d, y: 0.7592525246610118d), new NpgsqlTypes.NpgsqlPoint(x: 0.7494351956318793d, y: 0.6451282957785895d), new NpgsqlTypes.NpgsqlPoint(x: 0.08437999631705417d, y: 0.5027922755516454d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6441377877259366d, y: 0.7267099296989892d), new NpgsqlTypes.NpgsqlPoint(x: 0.726362709222268d, y: 0.482965625333738d), new NpgsqlTypes.NpgsqlPoint(x: 0.17231321544880107d, y: 0.7297989373550379d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47779478298287836d, y: 0.5653369096963179d), new NpgsqlTypes.NpgsqlPoint(x: 0.7163047962451363d, y: 0.19740651096315054d), new NpgsqlTypes.NpgsqlPoint(x: 0.4925936359514206d, y: 0.1936163696731128d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9493862633665794d, y: 0.32094102585870043d), new NpgsqlTypes.NpgsqlPoint(x: 0.1924942997037712d, y: 0.9869855689320562d), new NpgsqlTypes.NpgsqlPoint(x: 0.6735706019797588d, y: 0.11137503349608913d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5347276982473522d, y: 0.03916147938388714d), new NpgsqlTypes.NpgsqlPoint(x: 0.03244826953250968d, y: 0.23692490762519558d), new NpgsqlTypes.NpgsqlPoint(x: 0.9675002391530668d, y: 0.3963784826551501d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8066447366180325d, y: 0.9795670908035754d), new NpgsqlTypes.NpgsqlPoint(x: 0.9844016662525001d, y: 0.6266089286791211d), new NpgsqlTypes.NpgsqlPoint(x: 0.2310918484229525d, y: 0.3206183822127403d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3562701939843631d, y: 0.11929775419378386d), new NpgsqlTypes.NpgsqlPoint(x: 0.3984939689913394d, y: 0.5115143742721072d), new NpgsqlTypes.NpgsqlPoint(x: 0.5050246812055458d, y: 0.7588107679251893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6300417514917228d, y: 0.7296014277452382d), new NpgsqlTypes.NpgsqlPoint(x: 0.31515938736867877d, y: 0.8111309324466482d), new NpgsqlTypes.NpgsqlPoint(x: 0.46366240181228147d, y: 0.9046274884265812d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1730202290244539d, y: 0.8393843852616294d), new NpgsqlTypes.NpgsqlPoint(x: 0.1643417605197588d, y: 0.4101324039286862d), new NpgsqlTypes.NpgsqlPoint(x: 0.2880959168872492d, y: 0.5375694055838409d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10847149574303216d, y: 0.9791554360380135d), new NpgsqlTypes.NpgsqlPoint(x: 0.6443629055538114d, y: 0.4800868191284082d), new NpgsqlTypes.NpgsqlPoint(x: 0.22586232692001507d, y: 0.3363854241957829d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08024375138576623d, y: 0.23833082918381354d), new NpgsqlTypes.NpgsqlPoint(x: 0.25693760798538434d, y: 0.8910946555322795d), new NpgsqlTypes.NpgsqlPoint(x: 0.9466655552762493d, y: 0.9523987039659733d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14940658556310926d, y: 0.2766742627350416d), new NpgsqlTypes.NpgsqlPoint(x: 0.9155716089529251d, y: 0.22907433974467795d), new NpgsqlTypes.NpgsqlPoint(x: 0.20294911563135265d, y: 0.8112370906074863d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7117356092598621d, y: 0.5092560787546133d), new NpgsqlTypes.NpgsqlPoint(x: 0.46594776271851535d, y: 0.33875387824103487d), new NpgsqlTypes.NpgsqlPoint(x: 0.3337847711765294d, y: 0.8805137555222662d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12773841070045933d, y: 0.14602330228146343d), new NpgsqlTypes.NpgsqlPoint(x: 0.3378264142108296d, y: 0.03762036523027579d), new NpgsqlTypes.NpgsqlPoint(x: 0.2183374617701882d, y: 0.35230273738102846d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40246415920261114d, y: 0.8482484453784919d), new NpgsqlTypes.NpgsqlPoint(x: 0.8558428566085516d, y: 0.24983449831603266d), new NpgsqlTypes.NpgsqlPoint(x: 0.48505840629526864d, y: 0.04444374743901924d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4990410446807738d, y: 0.9391570493571931d), new NpgsqlTypes.NpgsqlPoint(x: 0.4677940236120428d, y: 0.8920947151121137d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499840359093308d, y: 0.029236456368842312d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09199077289971114d, y: 0.3471343409480626d), new NpgsqlTypes.NpgsqlPoint(x: 0.612797910434519d, y: 0.5850713671154862d), new NpgsqlTypes.NpgsqlPoint(x: 0.8820710390963863d, y: 0.4562508214799642d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1338962215658308d, y: 0.4480359272447909d), new NpgsqlTypes.NpgsqlPoint(x: 0.9368413612706784d, y: 0.020680104172456137d), new NpgsqlTypes.NpgsqlPoint(x: 0.12437111123681233d, y: 0.8117071926049196d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9006647418969185d, y: 0.9960447146532907d), new NpgsqlTypes.NpgsqlPoint(x: 0.14931689266161152d, y: 0.3467709174045943d), new NpgsqlTypes.NpgsqlPoint(x: 0.2806687672897936d, y: 0.9098499963553721d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016987661791550535d, y: 0.293409029802821d), new NpgsqlTypes.NpgsqlPoint(x: 0.7795697446521482d, y: 0.5901783047403575d), new NpgsqlTypes.NpgsqlPoint(x: 0.8840521753773591d, y: 0.6863247039694257d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19655062364650255d, y: 0.34623565410538115d), new NpgsqlTypes.NpgsqlPoint(x: 0.1570503642674531d, y: 0.8323665664905204d), new NpgsqlTypes.NpgsqlPoint(x: 0.7019228016275348d, y: 0.007785865012722937d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8937853733154919d, y: 0.0847485962225184d), new NpgsqlTypes.NpgsqlPoint(x: 0.21270127686089402d, y: 0.8255693984320249d), new NpgsqlTypes.NpgsqlPoint(x: 0.2620026845669099d, y: 0.63844546231674d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31328257645032176d, y: 0.9513186465494321d), new NpgsqlTypes.NpgsqlPoint(x: 0.20188373488875833d, y: 0.8239502788224954d), new NpgsqlTypes.NpgsqlPoint(x: 0.9134073847369836d, y: 0.6851939833727019d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.866499229943729d, y: 0.31608258534531397d), new NpgsqlTypes.NpgsqlPoint(x: 0.7374804340515365d, y: 0.5485097607371209d), new NpgsqlTypes.NpgsqlPoint(x: 0.7738799421655879d, y: 0.8934868999716759d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6881497504782892d, y: 0.5845916503366902d), new NpgsqlTypes.NpgsqlPoint(x: 0.21597475213771278d, y: 0.6175000724467868d), new NpgsqlTypes.NpgsqlPoint(x: 0.701857464008841d, y: 0.971844487638285d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24512790471902202d, y: 0.7733604877843809d), new NpgsqlTypes.NpgsqlPoint(x: 0.9904430121213509d, y: 0.7401653953675802d), new NpgsqlTypes.NpgsqlPoint(x: 0.790431543596702d, y: 0.46641811879797324d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8145190292912405d, y: 0.5059566643435038d), new NpgsqlTypes.NpgsqlPoint(x: 0.714613122740223d, y: 0.3525716250190176d), new NpgsqlTypes.NpgsqlPoint(x: 0.44188258947509285d, y: 0.9854003671876151d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7144533109657394d, y: 0.7767170475672597d), new NpgsqlTypes.NpgsqlPoint(x: 0.7080187206116791d, y: 0.9924007909951406d), new NpgsqlTypes.NpgsqlPoint(x: 0.2819527321441948d, y: 0.13482943494459887d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25997312981735177d, y: 0.08664553594264157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5910231904430584d, y: 0.08901292678652561d), new NpgsqlTypes.NpgsqlPoint(x: 0.1798067373081934d, y: 0.2431833441398915d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5683449252592565d, y: 0.6601577519333444d), new NpgsqlTypes.NpgsqlPoint(x: 0.6955887425563694d, y: 0.2462998553794188d), new NpgsqlTypes.NpgsqlPoint(x: 0.4182657339289926d, y: 0.39428295860734297d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7417433579196252d, y: 0.8970093197333313d), new NpgsqlTypes.NpgsqlPoint(x: 0.37428160086388595d, y: 0.6490997037410003d), new NpgsqlTypes.NpgsqlPoint(x: 0.9810460079860747d, y: 0.0028339537710770912d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7623663419809688d, y: 0.42184781615492917d), new NpgsqlTypes.NpgsqlPoint(x: 0.00010535988494830839d, y: 0.7998301504556917d), new NpgsqlTypes.NpgsqlPoint(x: 0.41312203579353135d, y: 0.9818461523823426d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9300637483965415d, y: 0.1353451421968559d), new NpgsqlTypes.NpgsqlPoint(x: 0.931040377612816d, y: 0.17602740391940785d), new NpgsqlTypes.NpgsqlPoint(x: 0.3190753843928037d, y: 0.42756214730281006d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8989648109988332d, y: 0.4718166592346248d), new NpgsqlTypes.NpgsqlPoint(x: 0.18230910860185257d, y: 0.4316504128972779d), new NpgsqlTypes.NpgsqlPoint(x: 0.4890646941495643d, y: 0.20662686445658007d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3803714055024454d, y: 0.9958800479033298d), new NpgsqlTypes.NpgsqlPoint(x: 0.8526561847151827d, y: 0.6026291968309127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470451141882585d, y: 0.8442625609121007d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8788947467976228d, y: 0.8679838786124418d), new NpgsqlTypes.NpgsqlPoint(x: 0.0034220343938843323d, y: 0.18011674341944583d), new NpgsqlTypes.NpgsqlPoint(x: 0.37041031191115625d, y: 0.2222349579117835d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9169823098325078d, y: 0.7005245771909764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6709469068408159d, y: 0.027393434095394853d), new NpgsqlTypes.NpgsqlPoint(x: 0.4987144568467451d, y: 0.5077150784181051d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7003455048401204d, y: 0.7128328682472854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030610866142038d, y: 0.7294087586202593d), new NpgsqlTypes.NpgsqlPoint(x: 0.18142693985895542d, y: 0.781799998090052d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3761930596377252d, y: 0.4481927667270733d), new NpgsqlTypes.NpgsqlPoint(x: 0.004288254080521137d, y: 0.9153273561286281d), new NpgsqlTypes.NpgsqlPoint(x: 0.9998840108791492d, y: 0.15166395964555612d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5579479679254832d, y: 0.5411072968498774d), new NpgsqlTypes.NpgsqlPoint(x: 0.8967190194990281d, y: 0.8135149532975517d), new NpgsqlTypes.NpgsqlPoint(x: 0.24983139830765577d, y: 0.2805963352609898d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8335236932994835d, y: 0.029167299491606458d), new NpgsqlTypes.NpgsqlPoint(x: 0.23679383368781504d, y: 0.1599135351255777d), new NpgsqlTypes.NpgsqlPoint(x: 0.04572302283980989d, y: 0.4019336192163856d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17069315700658327d, y: 0.9990149922175943d), new NpgsqlTypes.NpgsqlPoint(x: 0.9179607041392791d, y: 0.7224520740690632d), new NpgsqlTypes.NpgsqlPoint(x: 0.1548852834448725d, y: 0.555836792235499d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15632327556237013d, y: 0.16281489700467533d), new NpgsqlTypes.NpgsqlPoint(x: 0.5483681894496374d, y: 0.7404700363846652d), new NpgsqlTypes.NpgsqlPoint(x: 0.10923979893579949d, y: 0.5935775165422045d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.014321142681345767d, y: 0.16667870474940494d), new NpgsqlTypes.NpgsqlPoint(x: 0.25128365375802997d, y: 0.8788330896638792d), new NpgsqlTypes.NpgsqlPoint(x: 0.14461985253888943d, y: 0.47407081035279186d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8840951252178038d, y: 0.8093733306503624d), new NpgsqlTypes.NpgsqlPoint(x: 0.7208407860917374d, y: 0.5685969111906924d), new NpgsqlTypes.NpgsqlPoint(x: 0.960794831780573d, y: 0.8926412170898484d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5818228920319142d, y: 0.47682647074309004d), new NpgsqlTypes.NpgsqlPoint(x: 0.8834883630846666d, y: 0.0679447496653135d), new NpgsqlTypes.NpgsqlPoint(x: 0.1002192991012053d, y: 0.8353265857561267d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10954812722028728d, y: 0.779618691357775d), new NpgsqlTypes.NpgsqlPoint(x: 0.24639258411966602d, y: 0.6836793529680194d), new NpgsqlTypes.NpgsqlPoint(x: 0.8417522135191873d, y: 0.4280089595296055d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.003153605322349873d, y: 0.3317958103205746d), new NpgsqlTypes.NpgsqlPoint(x: 0.2654966501678043d, y: 0.9312898273765031d), new NpgsqlTypes.NpgsqlPoint(x: 0.5166732107842739d, y: 0.08046653539208737d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7361114998015111d, y: 0.6579116314476893d), new NpgsqlTypes.NpgsqlPoint(x: 0.33311435615872975d, y: 0.7504789006526044d), new NpgsqlTypes.NpgsqlPoint(x: 0.8161900733617486d, y: 0.31151429940700714d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4060135118907797d, y: 0.7239771529484397d), new NpgsqlTypes.NpgsqlPoint(x: 0.02704539138291462d, y: 0.8813011176389283d), new NpgsqlTypes.NpgsqlPoint(x: 0.6665836333162598d, y: 0.45046278508198434d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03736491968757649d, y: 0.6180453657845333d), new NpgsqlTypes.NpgsqlPoint(x: 0.4635347912827191d, y: 0.00021474676767019307d), new NpgsqlTypes.NpgsqlPoint(x: 0.24716422337592447d, y: 0.5786612079053157d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6078156247136867d, y: 0.02564571469225796d), new NpgsqlTypes.NpgsqlPoint(x: 0.09026830050587031d, y: 0.5607251169119241d), new NpgsqlTypes.NpgsqlPoint(x: 0.6718903143861287d, y: 0.6627912681339612d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.019837689314074924d, y: 0.907718596974062d), new NpgsqlTypes.NpgsqlPoint(x: 0.1721996998002755d, y: 0.5095546424573346d), new NpgsqlTypes.NpgsqlPoint(x: 0.5816210273762821d, y: 0.6183562905598292d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47851639071326524d, y: 0.5026074097004523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5343501003361995d, y: 0.6248205594008983d), new NpgsqlTypes.NpgsqlPoint(x: 0.48441387400441127d, y: 0.7136608686985476d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02449909795381433d, y: 0.28925263305437143d), new NpgsqlTypes.NpgsqlPoint(x: 0.8442561322201263d, y: 0.4638603668928053d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843719450734733d, y: 0.880843285731812d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7613429273951479d, y: 0.9263264484576507d), new NpgsqlTypes.NpgsqlPoint(x: 0.027765104466000556d, y: 0.8589055226031486d), new NpgsqlTypes.NpgsqlPoint(x: 0.6830967200727655d, y: 0.5929132299071511d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4876824375106552d, y: 0.8241861791656987d), new NpgsqlTypes.NpgsqlPoint(x: 0.8998735791155643d, y: 0.08650479322591331d), new NpgsqlTypes.NpgsqlPoint(x: 0.29495258136869573d, y: 0.021682010850804012d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32899127007994233d, y: 0.47549263786383766d), new NpgsqlTypes.NpgsqlPoint(x: 0.35006677159419364d, y: 0.29831070714983077d), new NpgsqlTypes.NpgsqlPoint(x: 0.6554439275391898d, y: 0.3376039327363466d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7301022985817858d, y: 0.8765358235382877d), new NpgsqlTypes.NpgsqlPoint(x: 0.4741047629900482d, y: 0.2524561299688115d), new NpgsqlTypes.NpgsqlPoint(x: 0.10140333400763102d, y: 0.9767537201017716d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9219032797724058d, y: 0.2656978938854342d), new NpgsqlTypes.NpgsqlPoint(x: 0.3861812748827801d, y: 0.7180423613625587d), new NpgsqlTypes.NpgsqlPoint(x: 0.6558424955233851d, y: 0.7412293863789975d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7345398851470155d, y: 0.5750075823509994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7845348439814238d, y: 0.12124330897951174d), new NpgsqlTypes.NpgsqlPoint(x: 0.591666381515493d, y: 0.02496132418660202d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6274098262300032d, y: 0.43034119505626456d), new NpgsqlTypes.NpgsqlPoint(x: 0.4477475094162544d, y: 0.9010883734574767d), new NpgsqlTypes.NpgsqlPoint(x: 0.41417871878283063d, y: 0.32645801094357285d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8244046206202784d, y: 0.7302946297849727d), new NpgsqlTypes.NpgsqlPoint(x: 0.4845549270044428d, y: 0.8661328926267973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6867319633008051d, y: 0.8859947535770507d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7317651234651765d, y: 0.6275520055375984d), new NpgsqlTypes.NpgsqlPoint(x: 0.13460965499746935d, y: 0.2308732890414631d), new NpgsqlTypes.NpgsqlPoint(x: 0.9216602783320066d, y: 0.7376808453757636d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3256754454699886d, y: 0.5977705650824858d), new NpgsqlTypes.NpgsqlPoint(x: 0.05889382731973347d, y: 0.8025933399363258d), new NpgsqlTypes.NpgsqlPoint(x: 0.2754853905525405d, y: 0.27874888954265475d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6592627169347712d, y: 0.3077513496435902d), new NpgsqlTypes.NpgsqlPoint(x: 0.0821716940281425d, y: 0.37613341707632497d), new NpgsqlTypes.NpgsqlPoint(x: 0.7275263356945846d, y: 0.204519016302954d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5657147718213654d, y: 0.8183591038980962d), new NpgsqlTypes.NpgsqlPoint(x: 0.8115583768812895d, y: 0.39060377990485373d), new NpgsqlTypes.NpgsqlPoint(x: 0.9362573131229273d, y: 0.24349118904485312d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8082622816282999d, y: 0.6226741271819364d), new NpgsqlTypes.NpgsqlPoint(x: 0.8864976838291085d, y: 0.7731789240813981d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359104363284555d, y: 0.30605842036725717d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7736329610182912d, y: 0.32646458871308914d), new NpgsqlTypes.NpgsqlPoint(x: 0.2858716702354087d, y: 0.22078345603881389d), new NpgsqlTypes.NpgsqlPoint(x: 3.4238154426158296E-05d, y: 0.954985266578166d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7858223525449204d, y: 0.05149827670546525d), new NpgsqlTypes.NpgsqlPoint(x: 0.33314317358368417d, y: 0.40379873349885187d), new NpgsqlTypes.NpgsqlPoint(x: 0.9241949631765967d, y: 0.42817035472497467d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7758929023058142d, y: 0.24582969561932322d), new NpgsqlTypes.NpgsqlPoint(x: 0.20788702514538104d, y: 0.01246364882379436d), new NpgsqlTypes.NpgsqlPoint(x: 0.2746832446645112d, y: 0.6058275870893302d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6313416099525627d, y: 0.20845873279526128d), new NpgsqlTypes.NpgsqlPoint(x: 0.06509529130211456d, y: 0.3465089679592165d), new NpgsqlTypes.NpgsqlPoint(x: 0.6273072861787493d, y: 0.29043553445876613d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5931215484051666d, y: 0.9732030254656796d), new NpgsqlTypes.NpgsqlPoint(x: 0.2190909177654583d, y: 0.9018434006738868d), new NpgsqlTypes.NpgsqlPoint(x: 0.8869419958526803d, y: 0.6608640190137658d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9047129372784336d, y: 0.2674470440732569d), new NpgsqlTypes.NpgsqlPoint(x: 0.08204848739530468d, y: 0.22797264638872639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5046097336357076d, y: 0.7163174360975115d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41077093163457934d, y: 0.41088558820943544d), new NpgsqlTypes.NpgsqlPoint(x: 0.0020541221438933333d, y: 0.4139998624521062d), new NpgsqlTypes.NpgsqlPoint(x: 0.3972815488136213d, y: 0.042975212576338295d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11814988457168796d, y: 0.5910144641639659d), new NpgsqlTypes.NpgsqlPoint(x: 0.4962656208754763d, y: 0.4284171052367347d), new NpgsqlTypes.NpgsqlPoint(x: 0.45418205339522366d, y: 0.7095933684124167d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6686529396794492d, y: 0.8192299220397415d), new NpgsqlTypes.NpgsqlPoint(x: 0.968162310460448d, y: 0.6559638563185808d), new NpgsqlTypes.NpgsqlPoint(x: 0.05976247837838011d, y: 0.07133111751524257d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5870621942668055d, y: 0.3779210252405404d), new NpgsqlTypes.NpgsqlPoint(x: 0.2309173907133324d, y: 0.8799186971267721d), new NpgsqlTypes.NpgsqlPoint(x: 0.6514531701199904d, y: 0.9415365226779427d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8729518177954978d, y: 0.39517135190274066d), new NpgsqlTypes.NpgsqlPoint(x: 0.9219556207548867d, y: 0.0031836278813553998d), new NpgsqlTypes.NpgsqlPoint(x: 0.5741669233162972d, y: 0.20539247333090505d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7974275930627319d, y: 0.7170426791888063d), new NpgsqlTypes.NpgsqlPoint(x: 0.9075672700160488d, y: 0.8014841598670291d), new NpgsqlTypes.NpgsqlPoint(x: 0.28362163206049984d, y: 0.8226265758206519d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8990153160071693d, y: 0.6961876703321721d), new NpgsqlTypes.NpgsqlPoint(x: 0.5990789154791715d, y: 0.607188354148159d), new NpgsqlTypes.NpgsqlPoint(x: 0.22907711593614188d, y: 0.23228833968539853d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4960374339347019d, y: 0.2600459555180502d), new NpgsqlTypes.NpgsqlPoint(x: 0.10079238769738108d, y: 0.8787650611439466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6388459069183751d, y: 0.34027808834819373d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3547608993504443d, y: 0.3269383600309691d), new NpgsqlTypes.NpgsqlPoint(x: 0.6667496080162456d, y: 0.031781436944980146d), new NpgsqlTypes.NpgsqlPoint(x: 0.25392520395202556d, y: 0.8854272319442412d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5239498331639201d, y: 0.6213213675025421d), new NpgsqlTypes.NpgsqlPoint(x: 0.07098385792315098d, y: 0.197469898687197d), new NpgsqlTypes.NpgsqlPoint(x: 0.4081532967173077d, y: 0.1180884111867807d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8960464977911161d, y: 0.6589744542275164d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172502251635429d, y: 0.3427552821481846d), new NpgsqlTypes.NpgsqlPoint(x: 0.10954797837594576d, y: 0.9575512716582085d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5870901449905285d, y: 0.6262824974538653d), new NpgsqlTypes.NpgsqlPoint(x: 0.03263248938818786d, y: 0.8119416690131308d), new NpgsqlTypes.NpgsqlPoint(x: 0.5416888085295551d, y: 0.21000989790596614d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33620212612691913d, y: 0.52774767983994d), new NpgsqlTypes.NpgsqlPoint(x: 0.9280413542246242d, y: 0.1810029572219798d), new NpgsqlTypes.NpgsqlPoint(x: 0.6742340814632353d, y: 0.8699522819404701d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41820880176479014d, y: 0.905933753606018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8950128753142856d, y: 0.8843974617658914d), new NpgsqlTypes.NpgsqlPoint(x: 0.9018177369886833d, y: 0.9149923688828462d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6486703104959964d, y: 0.3102569847146561d), new NpgsqlTypes.NpgsqlPoint(x: 0.45825931892584093d, y: 0.8685278658234438d), new NpgsqlTypes.NpgsqlPoint(x: 0.5604608720698779d, y: 0.054843964588111915d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4761597523734392d, y: 0.23196100345080428d), new NpgsqlTypes.NpgsqlPoint(x: 0.9231619295993096d, y: 0.39412809394344517d), new NpgsqlTypes.NpgsqlPoint(x: 0.8460696867137147d, y: 0.5562525345924552d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0679283610968816d, y: 0.9868908989323518d), new NpgsqlTypes.NpgsqlPoint(x: 0.3373201772503305d, y: 0.007219971683993687d), new NpgsqlTypes.NpgsqlPoint(x: 0.20669515175144237d, y: 0.46827134551207006d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2654613436869241d, y: 0.07048997473939167d), new NpgsqlTypes.NpgsqlPoint(x: 0.3402907348615367d, y: 0.6391710492344518d), new NpgsqlTypes.NpgsqlPoint(x: 0.8064864587891262d, y: 0.19898110447313688d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5126200965232903d, y: 0.1398361193012123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9337303512174976d, y: 0.7759447635272382d), new NpgsqlTypes.NpgsqlPoint(x: 0.0626384959916404d, y: 0.7630257708892441d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6441128966686385d, y: 0.9236400309069208d), new NpgsqlTypes.NpgsqlPoint(x: 0.3412631076074978d, y: 0.39807085763653194d), new NpgsqlTypes.NpgsqlPoint(x: 0.6872849524611221d, y: 0.02902132388604084d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9818371517014851d, y: 0.6440057125970148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6279235844091675d, y: 0.38336455994518837d), new NpgsqlTypes.NpgsqlPoint(x: 0.1163273298259988d, y: 0.14250567084541754d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5571443158624653d, y: 0.8429519555189595d), new NpgsqlTypes.NpgsqlPoint(x: 0.020724849752772667d, y: 0.3382303484472742d), new NpgsqlTypes.NpgsqlPoint(x: 0.5662300032147386d, y: 0.8204478260902278d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.974475719926648d, y: 0.6705788612426006d), new NpgsqlTypes.NpgsqlPoint(x: 0.76979607101425d, y: 0.17962740654111553d), new NpgsqlTypes.NpgsqlPoint(x: 0.09301998331757433d, y: 0.7758489636050911d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2843264166639571d, y: 0.10149638892979396d), new NpgsqlTypes.NpgsqlPoint(x: 0.867079323893834d, y: 0.8350242484555578d), new NpgsqlTypes.NpgsqlPoint(x: 0.25544107420563766d, y: 0.9296567944547551d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9677753219882761d, y: 0.517326026911106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5631542978168267d, y: 0.10159279602514248d), new NpgsqlTypes.NpgsqlPoint(x: 0.2954418492037584d, y: 0.4849251246788415d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.905170850097275d, y: 0.5171892928851305d), new NpgsqlTypes.NpgsqlPoint(x: 0.5266340765376148d, y: 0.8551744626883766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5860796872931081d, y: 0.20591602063839143d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8795725137030402d, y: 0.8909423181910164d), new NpgsqlTypes.NpgsqlPoint(x: 0.833977530129049d, y: 0.07106892193884762d), new NpgsqlTypes.NpgsqlPoint(x: 0.0928663851131325d, y: 0.3208909322795416d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16975428967175965d, y: 0.4853466326876741d), new NpgsqlTypes.NpgsqlPoint(x: 0.8662880155335966d, y: 0.1543330597237048d), new NpgsqlTypes.NpgsqlPoint(x: 0.21456135317455893d, y: 0.8372663895215778d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5374339261395701d, y: 0.1719470074385101d), new NpgsqlTypes.NpgsqlPoint(x: 0.024004178702585866d, y: 0.7256019861257327d), new NpgsqlTypes.NpgsqlPoint(x: 0.257232131488799d, y: 0.021743889487428336d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10758389263519741d, y: 0.9105116136070722d), new NpgsqlTypes.NpgsqlPoint(x: 0.5542934964859726d, y: 0.8815087523200505d), new NpgsqlTypes.NpgsqlPoint(x: 0.4123641893096711d, y: 0.014862090788074878d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48669266875825967d, y: 0.040908742422143596d), new NpgsqlTypes.NpgsqlPoint(x: 0.729033921509094d, y: 0.8741442361042948d), new NpgsqlTypes.NpgsqlPoint(x: 0.2085533674588158d, y: 0.23661662873567346d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44056207799255154d, y: 0.23940651695262272d), new NpgsqlTypes.NpgsqlPoint(x: 0.3743053949748858d, y: 0.28142914579501477d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211294800553383d, y: 0.24328102408266827d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2634834335515459d, y: 0.20724042835381595d), new NpgsqlTypes.NpgsqlPoint(x: 0.3721293201450505d, y: 0.4932303556257329d), new NpgsqlTypes.NpgsqlPoint(x: 0.08552499947675074d, y: 0.8320048130796199d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26310715741671087d, y: 0.3744359453356064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5197675252011538d, y: 0.37290159579825133d), new NpgsqlTypes.NpgsqlPoint(x: 0.12476950193534475d, y: 0.9385697896258235d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.314699462151803d, y: 0.016392815178919995d), new NpgsqlTypes.NpgsqlPoint(x: 0.47043381497312475d, y: 0.7399377894636351d), new NpgsqlTypes.NpgsqlPoint(x: 0.1804011531972194d, y: 0.6043581686884615d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27922112405051813d, y: 0.9591368402725797d), new NpgsqlTypes.NpgsqlPoint(x: 0.6817842429098457d, y: 0.6283691297594363d), new NpgsqlTypes.NpgsqlPoint(x: 0.44982380094177565d, y: 0.7426237306242862d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49802898706094356d, y: 0.5016595984548353d), new NpgsqlTypes.NpgsqlPoint(x: 0.056993173973746925d, y: 0.9394461498392161d), new NpgsqlTypes.NpgsqlPoint(x: 0.7197110477272816d, y: 0.8009475505811916d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03159859339124593d, y: 0.9366610866613085d), new NpgsqlTypes.NpgsqlPoint(x: 0.9311857761074972d, y: 0.14021295834696657d), new NpgsqlTypes.NpgsqlPoint(x: 0.2929497681020834d, y: 0.04910537999756914d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2721293745505289d, y: 0.6284091660370079d), new NpgsqlTypes.NpgsqlPoint(x: 0.21034793226139425d, y: 0.5335334222182719d), new NpgsqlTypes.NpgsqlPoint(x: 0.9622242590251332d, y: 0.04904340209789759d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4928539249191084d, y: 0.20255062560113524d), new NpgsqlTypes.NpgsqlPoint(x: 0.39675816197146685d, y: 0.8960585134144478d), new NpgsqlTypes.NpgsqlPoint(x: 0.4246832707524515d, y: 0.49919536820163235d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8043524322764468d, y: 0.6649069534212925d), new NpgsqlTypes.NpgsqlPoint(x: 0.328460487389891d, y: 0.9297567056997856d), new NpgsqlTypes.NpgsqlPoint(x: 0.11735610184321976d, y: 0.2575746958169698d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4689755415263529d, y: 0.04853295646726519d), new NpgsqlTypes.NpgsqlPoint(x: 0.5626155481634284d, y: 0.47244037536825556d), new NpgsqlTypes.NpgsqlPoint(x: 0.7532291248101317d, y: 0.6147675120118027d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4522594927207426d, y: 0.8209646769645341d), new NpgsqlTypes.NpgsqlPoint(x: 0.6987876690846094d, y: 0.4560889524501406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6884989443897289d, y: 0.11153830849143276d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7388566428335109d, y: 0.6382939174319422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9574584001919767d, y: 0.8296675386549079d), new NpgsqlTypes.NpgsqlPoint(x: 0.12027659835477411d, y: 0.15259906199973527d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5309730632578514d, y: 0.07439341389073018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7277982176522083d, y: 0.7944008769797823d), new NpgsqlTypes.NpgsqlPoint(x: 0.20398575658833462d, y: 0.8827916300271335d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7734671020458155d, y: 0.36997067396112826d), new NpgsqlTypes.NpgsqlPoint(x: 0.1726998271725746d, y: 0.009190568480624162d), new NpgsqlTypes.NpgsqlPoint(x: 0.9020849964199004d, y: 0.3746943240975451d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7735988936469352d, y: 0.8922370426615718d), new NpgsqlTypes.NpgsqlPoint(x: 0.4167895194136453d, y: 0.6596324043091458d), new NpgsqlTypes.NpgsqlPoint(x: 0.32142000013118033d, y: 0.34122419046557173d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8283507605467987d, y: 0.785837517971382d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304616615333445d, y: 0.5493248360065186d), new NpgsqlTypes.NpgsqlPoint(x: 0.13057186671456844d, y: 0.6337479923649166d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30538944282085d, y: 0.133062826971165d), new NpgsqlTypes.NpgsqlPoint(x: 0.9828505912000357d, y: 0.6205584675687859d), new NpgsqlTypes.NpgsqlPoint(x: 0.9796769185721059d, y: 0.4316845986553778d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012009680158788005d, y: 0.8481651297766232d), new NpgsqlTypes.NpgsqlPoint(x: 0.3226047664143983d, y: 0.5785328025115166d), new NpgsqlTypes.NpgsqlPoint(x: 0.6597268323911742d, y: 0.16752392260567017d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08933641736421427d, y: 0.962075509596724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8238223523867082d, y: 0.9767507382734449d), new NpgsqlTypes.NpgsqlPoint(x: 0.5485111432167606d, y: 0.9176051450982395d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5897931053237482d, y: 0.6218675577667511d), new NpgsqlTypes.NpgsqlPoint(x: 0.9052037210094146d, y: 0.8056356547878079d), new NpgsqlTypes.NpgsqlPoint(x: 0.4686072238910919d, y: 0.7135262040730801d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5514173806300686d, y: 0.7416658804597709d), new NpgsqlTypes.NpgsqlPoint(x: 0.9868683104838901d, y: 0.5169733277963253d), new NpgsqlTypes.NpgsqlPoint(x: 0.4604732926357382d, y: 0.3985734727018586d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3957843621176018d, y: 0.7028114971775621d), new NpgsqlTypes.NpgsqlPoint(x: 0.9210379371595393d, y: 0.5022093625397663d), new NpgsqlTypes.NpgsqlPoint(x: 0.38455344490755683d, y: 0.02551087613245695d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07786986434969012d, y: 0.16379981881112748d), new NpgsqlTypes.NpgsqlPoint(x: 0.4564927607817648d, y: 0.08690013311032685d), new NpgsqlTypes.NpgsqlPoint(x: 0.9243905299981285d, y: 0.23799809947684447d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7611202323585793d, y: 0.6742756765303832d), new NpgsqlTypes.NpgsqlPoint(x: 0.7268146839446645d, y: 0.5331852461901705d), new NpgsqlTypes.NpgsqlPoint(x: 0.04080556640149058d, y: 0.7584568671209374d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29144615119346706d, y: 0.6726987017937055d), new NpgsqlTypes.NpgsqlPoint(x: 0.07599127394518423d, y: 0.1622117660518082d), new NpgsqlTypes.NpgsqlPoint(x: 0.39449006948483645d, y: 0.5373512270768502d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32703824982125407d, y: 0.7871398269493244d), new NpgsqlTypes.NpgsqlPoint(x: 0.028746180566580515d, y: 0.02330694327773697d), new NpgsqlTypes.NpgsqlPoint(x: 0.6424597377438847d, y: 0.46290786079552704d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6753193233719667d, y: 0.5644312595850112d), new NpgsqlTypes.NpgsqlPoint(x: 0.022246988837826276d, y: 0.44508626557250786d), new NpgsqlTypes.NpgsqlPoint(x: 0.8368743226380952d, y: 0.41908239508132206d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.555316729949116d, y: 0.3960049172159148d), new NpgsqlTypes.NpgsqlPoint(x: 0.9402399448975757d, y: 0.6890251096608373d), new NpgsqlTypes.NpgsqlPoint(x: 0.6642702812268106d, y: 0.2110280394853994d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5127994677973747d, y: 0.3706216299026569d), new NpgsqlTypes.NpgsqlPoint(x: 0.2532577067733658d, y: 0.9317947795812386d), new NpgsqlTypes.NpgsqlPoint(x: 0.6578153105298563d, y: 0.7323287058945641d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4058484566881494d, y: 0.8314891392995934d), new NpgsqlTypes.NpgsqlPoint(x: 0.6353787500889835d, y: 0.5313764853808506d), new NpgsqlTypes.NpgsqlPoint(x: 0.12727575665736368d, y: 0.6719318486752225d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 178,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6612209794792325d, y: 0.9648861653413919d), new NpgsqlTypes.NpgsqlPoint(x: 0.10745739571355539d, y: 0.9529423689969636d), new NpgsqlTypes.NpgsqlPoint(x: 0.4255274603234054d, y: 0.3821894555627079d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42499754206168305d, y: 0.11473942166600815d), new NpgsqlTypes.NpgsqlPoint(x: 0.6544092206496658d, y: 0.470008877640527d), new NpgsqlTypes.NpgsqlPoint(x: 0.1558056546768688d, y: 0.5201411223156109d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5403352850562619d, y: 0.017171821210226645d), new NpgsqlTypes.NpgsqlPoint(x: 0.9965529767068293d, y: 0.0765100989866635d), new NpgsqlTypes.NpgsqlPoint(x: 0.4681618594675476d, y: 0.06737436898440785d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8157691745350876d, y: 0.6267090450670144d), new NpgsqlTypes.NpgsqlPoint(x: 0.9387076519667246d, y: 0.5064591732830022d), new NpgsqlTypes.NpgsqlPoint(x: 0.35611396095982006d, y: 0.7498643052158708d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1806367715211059d, y: 0.7845902382742486d), new NpgsqlTypes.NpgsqlPoint(x: 0.7867696457329215d, y: 0.4197580941982114d), new NpgsqlTypes.NpgsqlPoint(x: 0.48474438794047536d, y: 0.698935317302605d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4935350671278137d, y: 0.7400445097977713d), new NpgsqlTypes.NpgsqlPoint(x: 0.3773696436288647d, y: 0.9232013211040422d), new NpgsqlTypes.NpgsqlPoint(x: 0.8197000360286049d, y: 0.9060009736127329d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1584311669077183d, y: 0.36076207915171576d), new NpgsqlTypes.NpgsqlPoint(x: 0.242554090534025d, y: 0.10474599606985568d), new NpgsqlTypes.NpgsqlPoint(x: 0.32244371702145647d, y: 0.04352466628105667d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07272868402189425d, y: 0.1430610889293178d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004891130757918d, y: 0.9897216603441249d), new NpgsqlTypes.NpgsqlPoint(x: 0.6751299425045332d, y: 0.8197408716425075d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02866821149317722d, y: 0.6867495244871138d), new NpgsqlTypes.NpgsqlPoint(x: 0.17955356512758158d, y: 0.4779447766015291d), new NpgsqlTypes.NpgsqlPoint(x: 0.9620646889199085d, y: 0.8201961813923906d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3405733162716027d, y: 0.9432027173361565d), new NpgsqlTypes.NpgsqlPoint(x: 0.26658558527243637d, y: 0.12905631346050295d), new NpgsqlTypes.NpgsqlPoint(x: 0.6669921337783377d, y: 0.6734486607740047d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7323286470359786d, y: 0.17490181974017682d), new NpgsqlTypes.NpgsqlPoint(x: 0.41788353849858306d, y: 0.08871196165816764d), new NpgsqlTypes.NpgsqlPoint(x: 0.4213500567500458d, y: 0.3213755177971883d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 183,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3893675331435774d, y: 0.04976295612681014d), new NpgsqlTypes.NpgsqlPoint(x: 0.5938017931862274d, y: 0.7278419163206331d), new NpgsqlTypes.NpgsqlPoint(x: 0.12064314116224895d, y: 0.7523661747957601d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7931393374867851d, y: 0.9239549237473178d), new NpgsqlTypes.NpgsqlPoint(x: 0.6092957327536066d, y: 0.5894130066536044d), new NpgsqlTypes.NpgsqlPoint(x: 0.3567977746498209d, y: 0.6029937545969793d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9757890269703564d, y: 0.21651072402012483d), new NpgsqlTypes.NpgsqlPoint(x: 0.6940389054699027d, y: 0.15747580897606617d), new NpgsqlTypes.NpgsqlPoint(x: 0.059236190155853796d, y: 0.25233880823050137d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5709858196899465d, y: 0.11860873818126894d), new NpgsqlTypes.NpgsqlPoint(x: 0.7033023714656371d, y: 0.44457569255498386d), new NpgsqlTypes.NpgsqlPoint(x: 0.7970705789487292d, y: 0.34040534743836803d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5918197960318367d, y: 0.5681093287902718d), new NpgsqlTypes.NpgsqlPoint(x: 0.1797644091362186d, y: 0.9193383437032405d), new NpgsqlTypes.NpgsqlPoint(x: 0.359029213661494d, y: 0.5001681857660285d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6448390480262839d, y: 0.41249051050304975d), new NpgsqlTypes.NpgsqlPoint(x: 0.8266043318393059d, y: 0.4556644646177721d), new NpgsqlTypes.NpgsqlPoint(x: 0.8105340693929329d, y: 0.5936740949302733d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9929447575565414d, y: 0.011771725832248281d), new NpgsqlTypes.NpgsqlPoint(x: 0.8179267404747185d, y: 0.1834480537004637d), new NpgsqlTypes.NpgsqlPoint(x: 0.23352941088883827d, y: 0.9162498865568836d)),
},
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 186,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.704432749177257d, y: 0.5046669186871178d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868599808830754d, y: 0.1806813913741544d), new NpgsqlTypes.NpgsqlPoint(x: 0.17821039212083478d, y: 0.1785679782352505d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5413506433030149d, y: 0.659795891478799d), new NpgsqlTypes.NpgsqlPoint(x: 0.14565832185968697d, y: 0.3655169912542643d), new NpgsqlTypes.NpgsqlPoint(x: 0.5514909665406089d, y: 0.49077665253737224d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3449593299382089d, y: 0.07095206305207857d), new NpgsqlTypes.NpgsqlPoint(x: 0.6523970506171938d, y: 0.438664643661584d), new NpgsqlTypes.NpgsqlPoint(x: 0.7080675410417726d, y: 0.7582258099558654d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5467646122552557d, y: 0.581338731808466d), new NpgsqlTypes.NpgsqlPoint(x: 0.12080336708070116d, y: 0.5253208102215803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5861971428904088d, y: 0.6543195689451016d)),
},
    ModelInner = new NpgsqlPolygonpolygonMMArrayD1E1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.80006410761383d, y: 0.19408554616535145d), new NpgsqlTypes.NpgsqlPoint(x: 0.3845320556840983d, y: 0.5949239619848622d), new NpgsqlTypes.NpgsqlPoint(x: 0.015287830438461936d, y: 0.51129243567875d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36643540194008495d, y: 0.25475957713786157d), new NpgsqlTypes.NpgsqlPoint(x: 0.40758722871468245d, y: 0.5676923118523968d), new NpgsqlTypes.NpgsqlPoint(x: 0.26579306161400584d, y: 0.7681749584123027d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4534416140530888d, y: 0.6999302880209531d), new NpgsqlTypes.NpgsqlPoint(x: 0.4253227223506152d, y: 0.0705220676844509d), new NpgsqlTypes.NpgsqlPoint(x: 0.13440989643324497d, y: 0.2555435559695284d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD1E1M
{
    Id = 195,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8299122947298891d, y: 0.9813208159550437d), new NpgsqlTypes.NpgsqlPoint(x: 0.8100729620222149d, y: 0.04923716346224527d), new NpgsqlTypes.NpgsqlPoint(x: 0.3198794858079468d, y: 0.07247080556637497d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2606520227701733d, y: 0.4072958835076962d), new NpgsqlTypes.NpgsqlPoint(x: 0.8827258608228367d, y: 0.08066925438139161d), new NpgsqlTypes.NpgsqlPoint(x: 0.01822895035647798d, y: 0.029227951626938253d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12817623431876002d, y: 0.3456513845900766d), new NpgsqlTypes.NpgsqlPoint(x: 0.4039500903060754d, y: 0.9178276754010125d), new NpgsqlTypes.NpgsqlPoint(x: 0.31220973381325756d, y: 0.8155193696830113d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8898566627819727d, y: 0.9230091878109268d), new NpgsqlTypes.NpgsqlPoint(x: 0.23011323280881701d, y: 0.4138694440198031d), new NpgsqlTypes.NpgsqlPoint(x: 0.3056391042829266d, y: 0.12765900394894691d)),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
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

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd1e1mi_id
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
    npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5759623404371178d, y: 0.9213141324243862d), new NpgsqlTypes.NpgsqlPoint(x: 0.16219159964235907d, y: 0.5642492221367137d), new NpgsqlTypes.NpgsqlPoint(x: 0.5317895055027902d, y: 0.7101204234963179d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39567477840298915d, y: 0.185130474004076d), new NpgsqlTypes.NpgsqlPoint(x: 0.7775064477407356d, y: 0.5275301446634381d), new NpgsqlTypes.NpgsqlPoint(x: 0.8064850037617458d, y: 0.5022410340434812d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9082588493635416d, y: 0.7311872670463754d), new NpgsqlTypes.NpgsqlPoint(x: 0.20950666711834887d, y: 0.5983129045679804d), new NpgsqlTypes.NpgsqlPoint(x: 0.8042959656251111d, y: 0.08278713837366414d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07449213344665684d, y: 0.4907671363858269d), new NpgsqlTypes.NpgsqlPoint(x: 0.49289167856699945d, y: 0.23369974911426494d), new NpgsqlTypes.NpgsqlPoint(x: 0.060520151170504244d, y: 0.08612780156821442d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8132669796250477d, y: 0.528122684014864d), new NpgsqlTypes.NpgsqlPoint(x: 0.0984715578131602d, y: 0.07209253618777933d), new NpgsqlTypes.NpgsqlPoint(x: 0.1035913733097027d, y: 0.5038764967851694d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5682281615741187d, y: 0.2130978169827964d), new NpgsqlTypes.NpgsqlPoint(x: 0.9305920366598902d, y: 0.3772701765346216d), new NpgsqlTypes.NpgsqlPoint(x: 0.53568577698237d, y: 0.5998614263592157d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd1e1mi_id
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
    npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmmarrayd1e1mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6332516843380375d, y: 0.43379943796379383d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552232544086195d, y: 0.9505287612091522d), new NpgsqlTypes.NpgsqlPoint(x: 0.21372465472931368d, y: 0.2354202132512021d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7291079219198305d, y: 0.8096009342246706d), new NpgsqlTypes.NpgsqlPoint(x: 0.2168722284064949d, y: 0.026168992311208616d), new NpgsqlTypes.NpgsqlPoint(x: 0.1525383470350512d, y: 0.7010531318635497d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08487474678352125d, y: 0.3750660262704374d), new NpgsqlTypes.NpgsqlPoint(x: 0.3826072902466433d, y: 0.6794900017105533d), new NpgsqlTypes.NpgsqlPoint(x: 0.6507650971787023d, y: 0.8270855467748761d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44842867146513943d, y: 0.899319840822544d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928604095778161d, y: 0.465717499101182d), new NpgsqlTypes.NpgsqlPoint(x: 0.15422586302504826d, y: 0.21748367690886095d)),
}));
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9487474162746825d, y: 0.7622761282160327d), new NpgsqlTypes.NpgsqlPoint(x: 0.27399165879520504d, y: 0.1705800403884945d), new NpgsqlTypes.NpgsqlPoint(x: 0.8296434706443213d, y: 0.7341557332207365d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09246588309421744d, y: 0.5635878730297115d), new NpgsqlTypes.NpgsqlPoint(x: 0.4512196625901219d, y: 0.20980745106940846d), new NpgsqlTypes.NpgsqlPoint(x: 0.10963068611139937d, y: 0.7030069653536949d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3935061546373496d, y: 0.16401907620157086d), new NpgsqlTypes.NpgsqlPoint(x: 0.33442483976123916d, y: 0.5945229734458883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7783993694172264d, y: 0.7063194813449727d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7286482653637498d, y: 0.3973060606378629d), new NpgsqlTypes.NpgsqlPoint(x: 0.005762932130796816d, y: 0.2473266477206345d), new NpgsqlTypes.NpgsqlPoint(x: 0.7944094023934088d, y: 0.2868225988509562d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22847300470645215d, y: 0.1243075135449303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8572565294207507d, y: 0.7442932373076854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236220696734953d, y: 0.2892232870564234d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5882475267840379d, y: 0.4495419587100483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9078391246103569d, y: 0.6913395902738552d), new NpgsqlTypes.NpgsqlPoint(x: 0.10242549464536743d, y: 0.6657402041204259d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3888375676003606d, y: 0.3578183332050263d), new NpgsqlTypes.NpgsqlPoint(x: 0.9959682939903779d, y: 0.9494201189780195d), new NpgsqlTypes.NpgsqlPoint(x: 0.9567767389245123d, y: 0.10804897032012795d)),
}));
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD1E1M> models = null;

                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD1E1M> models = null;

                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 139;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 37;
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 157, query1, 170, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 126, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 9, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 170, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 183, query1, 170, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 9, query1, 153, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 61, query1, 163, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 157, query1, 147, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 80, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 118, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 18);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MI),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonmmarrayd1e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
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
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI), typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MI>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD1E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD1))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

