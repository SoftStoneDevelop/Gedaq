

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
    internal partial interface INpgsqlCircleArraycircleArray
    {
    }
    
    internal partial class NpgsqlCircleArraycircleArray : INpgsqlCircleArraycircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray1M[] _testData = new NpgsqlCirclecircleArray1M[]
        {
            new NpgsqlCirclecircleArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8522643058073298d, y: 0.5381132395113938d), radius: 0.14245585788536974d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.645558606362379d, y: 0.07285890314606813d), radius: 0.2679256887613065d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6569589085477737d, y: 0.5981385887309969d), radius: 0.21313346644261422d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6364171411406904d, y: 0.11485921060404103d), radius: 0.7011570529985782d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5751459997960061d, y: 0.4937264945304357d), radius: 0.5607368367559256d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1377881060855085d, y: 0.12444713625570658d), radius: 0.5801536918752757d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7339931897063356d, y: 0.9481978258303726d), radius: 0.6181495444373534d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6283032600004208d, y: 0.6973945866471084d), radius: 0.295522753505871d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14860797123003922d, y: 0.4016494232302966d), radius: 0.16011113811522437d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34206380748713205d, y: 0.24665117603365516d), radius: 0.22334059206989942d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4654156906915814d, y: 0.19974435894623455d), radius: 0.12063199644564104d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15776558988698852d, y: 0.6419124704840555d), radius: 0.7985088950908297d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8498857966924456d, y: 0.5306755456903968d), radius: 0.4026449980239628d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08752451291678143d, y: 0.9488574538250987d), radius: 0.9015369054585649d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2927263650851465d, y: 0.6015930164603216d), radius: 0.5026342731735838d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6151619477998062d, y: 0.2301817414043681d), radius: 0.8811868385031421d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.008378369927692031d, y: 0.0036990614312927272d), radius: 0.6431721999665772d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10829099803588615d, y: 0.37379643893259995d), radius: 0.08732345242775641d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2119348742798075d, y: 0.7140884664894201d), radius: 0.5409320206260063d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6793913681513658d, y: 0.9454178636934718d), radius: 0.9296071693998117d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2452443600398515d, y: 0.46054968954787556d), radius: 0.34763692344457d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6617681047479052d, y: 0.4943699316423831d), radius: 0.7247078023905538d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17484954297455757d, y: 0.9581628513326469d), radius: 0.10960322923376697d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03727702245835263d, y: 0.8297956930435674d), radius: 0.3030592943999344d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5809969688024786d, y: 0.06249515012340778d), radius: 0.7155058831242763d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9334421756680301d, y: 0.2158095159968264d), radius: 0.7525647388705131d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7041428975664982d, y: 0.4563360364171428d), radius: 0.8789585290139104d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14275568623120927d, y: 0.14236037727216233d), radius: 0.7834335727086563d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7856485099520345d, y: 0.849112398202514d), radius: 0.4442477261434795d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8642214091341459d, y: 0.2523862187719704d), radius: 0.17880167374643485d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23933048544627966d, y: 0.45085356234153606d), radius: 0.1655189088425677d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3540460291351799d, y: 0.7568312603083707d), radius: 0.7311378914555684d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26308687572520006d, y: 0.12951224588551968d), radius: 0.8956009377211843d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7458164933406283d, y: 0.8380586811530876d), radius: 0.3400250538919506d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9716433297919473d, y: 0.3563225348158222d), radius: 0.5355968954075987d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14227147009557894d, y: 0.6900471457170833d), radius: 0.26742363591675766d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5294337762236043d, y: 0.2621586640165041d), radius: 0.8457075421081474d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13779836900891018d, y: 0.7471295482543007d), radius: 0.9329304876965661d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33859536224481435d, y: 0.7704751614170269d), radius: 0.1425830101653941d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9860832867815801d, y: 0.9781327584904411d), radius: 0.259363386933144d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5397757315675508d, y: 0.7382692350879209d), radius: 0.2200707320209202d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5969406578253049d, y: 0.15371466960315372d), radius: 0.10915629033898278d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.059971733356278034d, y: 0.7691598920731709d), radius: 0.22034264332269493d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29461760739241727d, y: 0.9965609746433208d), radius: 0.9108642595275682d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9099358961643624d, y: 0.10576897299445642d), radius: 0.7962276748824416d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6661063913887124d, y: 0.016156144971076647d), radius: 0.9840397213562188d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.094136537594247d, y: 0.008710502744090354d), radius: 0.6051907327911895d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24363333708688906d, y: 0.9380443097074502d), radius: 0.9164162823674147d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35446208402702584d, y: 0.013121524127197914d), radius: 0.47670805916018766d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48088496545376236d, y: 0.10393496068757502d), radius: 0.7288798112362765d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8426324253069853d, y: 0.3592235336281059d), radius: 0.1339891231193303d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18411588178373062d, y: 0.31122550577857533d), radius: 0.22214149481432632d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3517828909049544d, y: 0.5735605431761004d), radius: 0.9828316718699236d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05894409195050765d, y: 0.901669666287462d), radius: 0.2871471721512444d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7935199101625725d, y: 0.7021871839373568d), radius: 0.07857303063621479d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07123086851514637d, y: 0.8651591496409292d), radius: 0.29885899773669833d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08003872072264795d, y: 0.9965734186767469d), radius: 0.514142389850923d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31144537466886446d, y: 0.6308153018325695d), radius: 0.008658678617754823d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1598035865432368d, y: 0.17058250744991388d), radius: 0.5347329209980769d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8298027629306238d, y: 0.3264169403571118d), radius: 0.39878026606012584d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19876022379153047d, y: 0.042156663633959646d), radius: 0.95373848533271d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9055715061538285d, y: 0.018707471459511682d), radius: 0.36186670364469453d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9490083346299d, y: 0.39726730417453693d), radius: 0.8207761382937188d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9209419042321322d, y: 0.5506775408016727d), radius: 0.12306639154782029d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.921290212596289d, y: 0.24410894535125727d), radius: 0.919843147908558d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19998930039892515d, y: 0.8561355977299866d), radius: 0.8086743398718846d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.015659144412243253d, y: 0.9094384006770868d), radius: 0.7231345917085427d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07447235826815635d, y: 0.9800634207061242d), radius: 0.5067319830846773d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9670714474438754d, y: 0.06021903660838468d), radius: 0.14667219223975092d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7293182721383554d, y: 0.4429103896357447d), radius: 0.4847837940412576d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44561814305175806d, y: 0.22783322266435413d), radius: 0.210714449370085d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42964308040603894d, y: 0.7746205281808219d), radius: 0.8249130783460371d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09057423458639069d, y: 0.6591981329442053d), radius: 0.05404816455167527d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6929432103488491d, y: 0.20542698161477446d), radius: 0.16914995013215706d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9869223102280023d, y: 0.5037381685418257d), radius: 0.2733819956019726d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5787587009944316d, y: 0.3450768267102581d), radius: 0.7827234672420227d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15748772063294025d, y: 0.8643015453802075d), radius: 0.555915942059196d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.973222643637229d, y: 0.2799001995261984d), radius: 0.0008723821724292424d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02116189626510767d, y: 0.3766980424971744d), radius: 0.30309972576382094d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3644886113017457d, y: 0.31532119796985913d), radius: 0.4738992711326716d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.839850504867826d, y: 0.20056912320412523d), radius: 0.6043375617337794d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7333355320132682d, y: 0.26406616169751673d), radius: 0.44608357886840055d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3402250742555062d, y: 0.25596449850256475d), radius: 0.8680919662495086d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.586262842458382d, y: 0.4249719063102908d), radius: 0.4301697159205261d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7394860856142796d, y: 0.3108477599864592d), radius: 0.12247987966503393d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6463967275025535d, y: 0.11446320223951345d), radius: 0.9237838724642574d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3684394333758775d, y: 0.17069454154633346d), radius: 0.41785489387079133d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1333535726578451d, y: 0.36088616461225553d), radius: 0.759772454339542d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8845962200881363d, y: 0.5896453411115696d), radius: 0.5048883430050101d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9973451661928224d, y: 0.6854713986732249d), radius: 0.5258275935344725d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4184114188886331d, y: 0.6931623547751807d), radius: 0.8393840005333523d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8083417634697145d, y: 0.5609392875286233d), radius: 0.4152558421793415d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5124678643614358d, y: 0.8353115049234986d), radius: 0.4330397409052804d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6171695120901067d, y: 0.7453790659507606d), radius: 0.761029631392731d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7435268763671513d, y: 0.26264057906303273d), radius: 0.51789576782046d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6586648171035522d, y: 0.007902810856698195d), radius: 0.5274036915434875d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30999729221286d, y: 0.7487350838037502d), radius: 0.4826441582501442d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4041676100390542d, y: 0.3601577814203505d), radius: 0.3060496822184221d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6957655358830271d, y: 0.4003121815061338d), radius: 0.998045722042928d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18931524692032198d, y: 0.07644244869134575d), radius: 0.12755592409844707d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9438603320429892d, y: 0.17262503173538646d), radius: 0.36193144668139177d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1328682528710059d, y: 0.8413064863062106d), radius: 0.7791184359537209d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10507611647291282d, y: 0.911331165299194d), radius: 0.8667807621358715d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1189502794737719d, y: 0.8366963867839998d), radius: 0.48707749468803396d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5081227331728032d, y: 0.9183952248318588d), radius: 0.8783799205600762d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5006834778176841d, y: 0.3785461465959611d), radius: 0.2663043288642025d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.139327830237981d, y: 0.24200107275127325d), radius: 0.212413595676873d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15685355731148065d, y: 0.5443973303161309d), radius: 0.47022926778812824d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6993342158582997d, y: 0.6936152705169554d), radius: 0.9124614779213317d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5133325950411373d, y: 0.11896148142472518d), radius: 0.8782815794320258d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11134302061709045d, y: 0.3333896365083454d), radius: 0.3345315958964883d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.022646529409965144d, y: 0.33265499663399756d), radius: 0.32648537890716955d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09181144245848749d, y: 0.07765754616510168d), radius: 0.09442964407872956d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9353218314264364d, y: 0.9227210077240905d), radius: 0.5947376247407701d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8100583230266742d, y: 0.12199520048741874d), radius: 0.7452887821737253d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2702744176018721d, y: 0.5086611308627391d), radius: 0.11567946995393774d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07841155950241274d, y: 0.6386139783563709d), radius: 0.5361658617386283d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4030367306849484d, y: 0.6295474285186067d), radius: 0.5477059250500802d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1430815856364558d, y: 0.8207641797565491d), radius: 0.33860107499620584d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10618929020172263d, y: 0.6834461986149171d), radius: 0.26449942287611017d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8451730575055925d, y: 0.6182313863137d), radius: 0.9423745725277127d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26303878751354504d, y: 0.3860504747841784d), radius: 0.9339549033850921d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08094902798464254d, y: 0.03067305964964895d), radius: 0.3889170783411916d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.703750228583679d, y: 0.8360542931749534d), radius: 0.9590219012726783d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.267049285332984d, y: 0.983564255896243d), radius: 0.27597184504460837d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1426997198011214d, y: 0.04939582001604104d), radius: 0.7374394120719394d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8572049638999917d, y: 0.3780755591186882d), radius: 0.9522659708332374d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.742409405361912d, y: 0.1238331232003641d), radius: 0.7928198051954813d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.598482145958903d, y: 0.8089253730294583d), radius: 0.20606755086689554d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18055872959111352d, y: 0.6129276089719181d), radius: 0.22988546221489503d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.009935080265224161d, y: 0.9862958907156766d), radius: 0.3133173938003736d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.524317998440042d, y: 0.10233606728571254d), radius: 0.9072002369814391d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2555658059760364d, y: 0.7051194368688605d), radius: 0.6002872575291223d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44098181522234303d, y: 0.019103599873559474d), radius: 0.9845630588833786d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0898433262391094d, y: 0.23893066595628498d), radius: 0.6186285412093615d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21116976309052438d, y: 0.9603760900086893d), radius: 0.08751970362245554d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7619571789333492d, y: 0.028928749843057155d), radius: 0.039814302350039354d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8190183780826938d, y: 0.19264995445915478d), radius: 0.30407800894288906d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9392450732028931d, y: 0.6748673325028358d), radius: 0.734187183014423d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6843342512661595d, y: 0.00767244373337439d), radius: 0.37925629850407605d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00028550720786946204d, y: 0.7329567924120106d), radius: 0.3244875884073737d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9142564213974728d, y: 0.6334738521846746d), radius: 0.2856735556201345d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.276757604575278d, y: 0.09683451689432965d), radius: 0.5848396068137306d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08007566541158484d, y: 0.34032634259556627d), radius: 0.40054069979085327d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25103661963705726d, y: 0.3803084327906058d), radius: 0.03751813139355609d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5386596195549644d, y: 0.6097774607331327d), radius: 0.028423254777745877d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09004385604255383d, y: 0.3072770468781787d), radius: 0.5758461669831642d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5428325201148646d, y: 0.18954530261446745d), radius: 0.8712527694058744d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3808112381721488d, y: 0.6669730384613586d), radius: 0.8073433034070236d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.998426219455247d, y: 0.8614922985421475d), radius: 0.4891081305112761d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3578484702241672d, y: 0.9063132701263671d), radius: 0.6415301825562263d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33624819525461247d, y: 0.3484989329617325d), radius: 0.17300898002444465d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9252093807211941d, y: 0.38603343549517666d), radius: 0.13653502174496301d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7039967754582941d, y: 0.5256220017900554d), radius: 0.4486076316820392d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8944191944998747d, y: 0.45827781294273695d), radius: 0.546915501993752d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04454453574683781d, y: 0.36305076405714887d), radius: 0.26061407222224464d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6799714593773238d, y: 0.8775986463831618d), radius: 0.7388205662129671d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30781133017206663d, y: 0.2702413175930113d), radius: 0.5735445967563321d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9412094717563939d, y: 0.5000681403719202d), radius: 0.3103550494962911d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3485556721763404d, y: 0.396732041120051d), radius: 0.8693894836432238d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8536612050343085d, y: 0.634156323025475d), radius: 0.3477848594619546d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2151904033988533d, y: 0.44868335581961716d), radius: 0.10698857553449892d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.588386671612312d, y: 0.6456871225384598d), radius: 0.11613425576303782d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3836078359457228d, y: 0.9124812832741263d), radius: 0.03994187101572233d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2907755064963483d, y: 0.8630790271311625d), radius: 0.6027136061393249d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4466976959860368d, y: 0.4713011576652175d), radius: 0.7598294714526611d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.708537458974118d, y: 0.4242007554837115d), radius: 0.7025803868414106d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09740807546217112d, y: 0.006731265208504089d), radius: 0.25223972181747556d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43137094637542783d, y: 0.14637696683309398d), radius: 0.38135419884697996d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46670060297611415d, y: 0.5428940927333189d), radius: 0.1543386706854849d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5294924121360729d, y: 0.28817922004029817d), radius: 0.6902302557145321d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09176417069798104d, y: 0.8716776322253182d), radius: 0.6035866266880916d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.406052168131561d, y: 0.2094606682696052d), radius: 0.47522305644208085d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.048206420262910665d, y: 0.7602440174163231d), radius: 0.9988800546598096d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9881905415890961d, y: 0.7623664795714875d), radius: 0.7233016678355869d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8573809831508391d, y: 0.07844722425671169d), radius: 0.612085803301862d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3827553727020885d, y: 0.33099753053864545d), radius: 0.9068088273269191d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9519423204947333d, y: 0.5564706989463837d), radius: 0.11192526774347367d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7340482558705826d, y: 0.6285579924174056d), radius: 0.7849984743934255d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9941366022422382d, y: 0.06259924910236303d), radius: 0.2252033751181739d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2825349721024992d, y: 0.5202353349899254d), radius: 0.011765084955093097d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5910689725250187d, y: 0.26528213310510274d), radius: 0.3937554100819435d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08092848150270926d, y: 0.9345104619346557d), radius: 0.9508545766651629d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6490830899517609d, y: 0.5268290145943708d), radius: 0.6941698965683831d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8721305970107456d, y: 0.8810577454982571d), radius: 0.41963727113201144d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08279593819472086d, y: 0.5119028988704694d), radius: 0.275655561410175d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12106418227571614d, y: 0.18722303281765773d), radius: 0.5752151481755089d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4010508960632505d, y: 0.02477694050597301d), radius: 0.6333245389337814d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020359770526584442d, y: 0.4073296660936211d), radius: 0.3545091790652405d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8029634711274605d, y: 0.6508332324657492d), radius: 0.3308549664370042d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10475252419730274d, y: 0.21449091950136667d), radius: 0.6335007651828541d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.538379109539478d, y: 0.37531842223421996d), radius: 0.7296273617031291d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8929829507853745d, y: 0.5740817424595739d), radius: 0.4903866079983342d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2358813767149951d, y: 0.5447783926522957d), radius: 0.6272123100289554d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47762847983977597d, y: 0.10159702065136988d), radius: 0.966320449772121d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9575645431219468d, y: 0.45227555805354747d), radius: 0.20555525782413409d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8359018122707648d, y: 0.3276830224970869d), radius: 0.9544264833487894d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.538565616126448d, y: 0.9959275587837476d), radius: 0.15009251994449035d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06705399823431846d, y: 0.8553861104783675d), radius: 0.2835918802469245d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9496799049728889d, y: 0.5375475334763209d), radius: 0.479672891884769d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.581004988876168d, y: 0.22436744997664193d), radius: 0.38869410794564285d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4822824579879422d, y: 0.011498524820491407d), radius: 0.12987252191628396d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4985892116635454d, y: 0.6891754609302303d), radius: 0.758169446583554d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17843360901797545d, y: 0.307511237793752d), radius: 0.9050001775024108d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.941242157736607d, y: 0.5282715752314482d), radius: 0.8879541267811513d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6696281311595772d, y: 0.6881630725866063d), radius: 0.7853203330628917d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9424588638304776d, y: 0.6663251029942481d), radius: 0.03783788568480928d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45717544843229563d, y: 0.13327972511412378d), radius: 0.25788655340939803d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16321282487903688d, y: 0.3604845565265068d), radius: 0.08125097650636093d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6462181334583822d, y: 0.11912530542267952d), radius: 0.9629925101612321d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5045753874332554d, y: 0.8640650647779019d), radius: 0.3418575801715462d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9715642270813662d, y: 0.9935462196402541d), radius: 0.006002007706084278d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6058665441652974d, y: 0.9649145743523043d), radius: 0.4033651242983174d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21564405378129614d, y: 0.9779334273121318d), radius: 0.8000800647372263d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7332710419541465d, y: 0.7587268733331667d), radius: 0.2440513657099953d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8532021758798377d, y: 0.17826093983985236d), radius: 0.2199829810065811d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1399905329538459d, y: 0.7875142968373683d), radius: 0.7356768644891775d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8584908920573739d, y: 0.8181884784208304d), radius: 0.9423133462550494d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10007648691671867d, y: 0.5069731197670483d), radius: 0.23289945656019972d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28189190620010063d, y: 0.5493883672857017d), radius: 0.1126487995396862d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8817691933235321d, y: 0.891210945586813d), radius: 0.7149725966746225d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32098444914002155d, y: 0.8102946158797687d), radius: 0.35653961694302727d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4356711551589466d, y: 0.7848338939850562d), radius: 0.1390233883808084d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6027565174729054d, y: 0.1825732220624362d), radius: 0.9338533251311193d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7453581476489465d, y: 0.43755919924091d), radius: 0.8514196205021093d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9834139857806304d, y: 0.4559454928284653d), radius: 0.25853143448319404d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7619178079216127d, y: 0.21578731464887002d), radius: 0.7382322058866715d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3078590935872991d, y: 0.7442449564449702d), radius: 0.26154945460775403d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6702515853794594d, y: 0.629757957383971d), radius: 0.7774113339473376d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47931898024873076d, y: 0.7509965398243025d), radius: 0.826290114806369d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4019685549734183d, y: 0.5938018102816004d), radius: 0.8558656523123077d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9107417947313569d, y: 0.6609722232629959d), radius: 0.9779302808797783d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5010265105332405d, y: 0.9656208744067829d), radius: 0.44400771968229913d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7027429438828742d, y: 0.16700774138210817d), radius: 0.11277628119786187d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9096079200900837d, y: 0.6407467261457395d), radius: 0.8508273103510829d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.73354186595657d, y: 0.7910713246677924d), radius: 0.8155264501167488d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8425846397126362d, y: 0.8485975057787924d), radius: 0.9958633161367952d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020221445894731294d, y: 0.8515469315906677d), radius: 0.985777874471097d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9977460027542912d, y: 0.26262760888238323d), radius: 0.033293749147364715d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7727620926741123d, y: 0.7690875045321189d), radius: 0.21552464665103532d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48905452320144027d, y: 0.40219260157050485d), radius: 0.09551604368651034d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10717421292816143d, y: 0.19814193095314114d), radius: 0.9047362100306705d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5204528305083442d, y: 0.24261016845581207d), radius: 0.15852775553926102d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6827467550771698d, y: 0.96289410923649d), radius: 0.4761151011364638d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03323856332675157d, y: 0.36974464319916d), radius: 0.5995344405457695d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8588757221847358d, y: 0.6697290902321225d), radius: 0.9600282234578442d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5555083221079394d, y: 0.17219912822344674d), radius: 0.8405822990575471d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22697875493737119d, y: 0.5568425464755848d), radius: 0.40714514743504615d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3394466317207727d, y: 0.2729555001532774d), radius: 0.9236481626539684d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5242230045795565d, y: 0.3146839105519825d), radius: 0.004683967184034965d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34517327391373165d, y: 0.33557207621573915d), radius: 0.786899864611029d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6945721640484275d, y: 0.1844673209412674d), radius: 0.5125239102467642d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6125460793124069d, y: 0.24693148651576402d), radius: 0.6003715793048439d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.703024733663996d, y: 0.8638411744960218d), radius: 0.984545712863429d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9830940114056629d, y: 0.5913774059580167d), radius: 0.9033965440825225d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09754790326325713d, y: 0.09629503150426688d), radius: 0.4798081321706186d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7683100387002553d, y: 0.20636521079831516d), radius: 0.9086444610241218d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.51718195883487d, y: 0.900146528763048d), radius: 0.09818088977206607d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8460600527197305d, y: 0.11635483514362843d), radius: 0.11431488319057315d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11069021551309255d, y: 0.9806936787951034d), radius: 0.7642119190631577d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06925253615110227d, y: 0.23195294149531054d), radius: 0.5913305832413565d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6679048491090752d, y: 0.11055977735508915d), radius: 0.7913465941792652d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3034522726540746d, y: 0.1404687676366032d), radius: 0.3820420018152312d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7695421045131423d, y: 0.6271426325336564d), radius: 0.4043365540114463d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40886688102535973d, y: 0.8022585185161241d), radius: 0.6994721672792381d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26188756178680317d, y: 0.562832044000055d), radius: 0.6012348842245482d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8426324253069853d, y: 0.3592235336281059d), radius: 0.1339891231193303d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18411588178373062d, y: 0.31122550577857533d), radius: 0.22214149481432632d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3517828909049544d, y: 0.5735605431761004d), radius: 0.9828316718699236d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9670714474438754d, y: 0.06021903660838468d), radius: 0.14667219223975092d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7293182721383554d, y: 0.4429103896357447d), radius: 0.4847837940412576d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44561814305175806d, y: 0.22783322266435413d), radius: 0.210714449370085d),
}));
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.973222643637229d, y: 0.2799001995261984d), radius: 0.0008723821724292424d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02116189626510767d, y: 0.3766980424971744d), radius: 0.30309972576382094d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3644886113017457d, y: 0.31532119796985913d), radius: 0.4738992711326716d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.839850504867826d, y: 0.20056912320412523d), radius: 0.6043375617337794d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6463967275025535d, y: 0.11446320223951345d), radius: 0.9237838724642574d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3684394333758775d, y: 0.17069454154633346d), radius: 0.41785489387079133d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1333535726578451d, y: 0.36088616461225553d), radius: 0.759772454339542d),
}));
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 80;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[34], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 146, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 139, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 46, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 16, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 37, query1, 80, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 23, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 4, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 109, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 54, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatch(connection, 86, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models = await ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[29], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[30], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[31], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[32], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[33], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[29], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[30], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[31], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[32], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[33], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray1m m
LEFT JOIN public.binary_npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI), typeof(NpgsqlCirclecircleArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleArray1MI>();
                var models2 = new List<NpgsqlCirclecircleArray1MI>();
                await ((INpgsqlCircleArraycircleArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MI>();
                var models2 = new List<NpgsqlCirclecircleArray1MI>();
                ((INpgsqlCircleArraycircleArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleArraycircleArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

