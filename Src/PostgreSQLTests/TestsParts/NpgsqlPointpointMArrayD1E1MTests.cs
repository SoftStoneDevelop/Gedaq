

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
    internal partial interface INpgsqlPointMArraypointMArrayD1
    {
    }
    
    internal partial class NpgsqlPointMArraypointMArrayD1 : INpgsqlPointMArraypointMArrayD1
    {


#region TestData

        private readonly NpgsqlPointpointMArrayD1E1M[] _testData = new NpgsqlPointpointMArrayD1E1M[]
        {
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17711525716960186d, y: 0.5642294353260445d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7865838448987917d, y: 0.6815766148621445d),
new NpgsqlTypes.NpgsqlPoint(x: 0.90278763744485d, y: 0.7070167066680699d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47130664010669554d, y: 0.6187496454633753d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5509659623122302d, y: 0.18490431908448146d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1708952514209049d, y: 0.1547618678202871d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5672699324703095d, y: 0.13616172545950223d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08265705985979366d, y: 0.03152186214931807d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37875073843299123d, y: 0.8683443125553866d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48531531876909817d, y: 0.867344238095326d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6021054230166291d, y: 0.2631375511675964d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24159455048034795d, y: 0.30286302924029107d),
new NpgsqlTypes.NpgsqlPoint(x: 0.838111234127014d, y: 0.5068728633019234d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4620708335715963d, y: 0.31914185601309253d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43825847372282145d, y: 0.1973235879970332d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7964552270041679d, y: 0.03860146179609614d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35132026894306256d, y: 0.23827547042520736d),
new NpgsqlTypes.NpgsqlPoint(x: 0.148381550339177d, y: 0.18135442686645697d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8938882432080097d, y: 0.11397748225137516d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06820849800882756d, y: 0.7868115046626806d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20306297433641285d, y: 0.6937422277151316d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7007335718431033d, y: 0.3943539024008538d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31458488036483656d, y: 0.2523223694251009d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8639150512892382d, y: 0.7460998551552581d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5277653941168017d, y: 0.3821618745316363d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8160061556448133d, y: 0.5968107266792886d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7266327182757512d, y: 0.3028444499032332d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10635811050726773d, y: 0.2454935066924765d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36125414901237185d, y: 0.004568778661259154d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9632399836762109d, y: 0.9941215479882681d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10878322049189004d, y: 0.09637227049768815d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7684023502424594d, y: 0.05309682618859157d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5429357981302908d, y: 0.55327039093487d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6861384286714544d, y: 0.27882018009519716d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5096235700973691d, y: 0.20121973325423603d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30225670868389387d, y: 0.5860377833500829d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7301782677660604d, y: 0.09258628310333505d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4442147888006568d, y: 0.8028566450138478d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9781420315896767d, y: 0.4053272891831401d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9466689182600367d, y: 0.911067548541185d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3077272613159252d, y: 0.025970463729107496d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11707828618654159d, y: 0.9415896964353261d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3959773234325391d, y: 0.8396212121855352d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37380263953771964d, y: 0.2876280343407204d),
new NpgsqlTypes.NpgsqlPoint(x: 0.012229538098093906d, y: 0.2767136522255442d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4310457418256649d, y: 0.3231201810727885d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4461347882995381d, y: 0.43832710739702474d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6522784704052096d, y: 0.7159381667562861d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18452862969435124d, y: 0.8076941765528287d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12038564288838238d, y: 0.27071961119456645d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13803346547408324d, y: 0.05856856142448286d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2263845848450079d, y: 0.24897922358293278d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8736016658008439d, y: 0.49807866866794237d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8647047432404376d, y: 0.07625611175501601d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13992070488991093d, y: 0.7964255309055922d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48912311645918327d, y: 0.8912368259733041d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4419999091800382d, y: 0.44186935930262006d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5830504068669397d, y: 0.787953838309123d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6909144018033263d, y: 0.7786299403228267d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9499681018515095d, y: 0.44018730341220025d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39471376748726894d, y: 0.7320097201108345d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7901840496981901d, y: 0.5839833502262965d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9199300358073643d, y: 0.45751855774238015d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5606224574381273d, y: 0.8403024565842355d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.957454925504926d, y: 0.5211546038413755d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4525987197073692d, y: 0.9014213275613765d),
new NpgsqlTypes.NpgsqlPoint(x: 0.026396719425745174d, y: 0.6046323024508607d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5901178523297879d, y: 0.3413556600916614d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7322873193188402d, y: 0.11815832189495312d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3187689486557894d, y: 0.9080838828600792d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1373470063427512d, y: 0.6870344034854347d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8160082013474503d, y: 0.582260131015129d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21194666473701507d, y: 0.5823702092269891d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8180536232021339d, y: 0.3768594152222138d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44057057904516583d, y: 0.8005695265851254d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9983914002506421d, y: 0.8353589232026847d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7287943028522156d, y: 0.9380345306171801d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32648499659459496d, y: 0.7079902226359006d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07280883965691443d, y: 0.0668133322642851d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15236228482265535d, y: 0.7389073700493642d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5908916748770451d, y: 0.9794583132957646d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8294833264361186d, y: 0.18101577782278178d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7965036594054773d, y: 0.8902868272697825d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.028234170063861974d, y: 0.2619038979354532d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5862441373323202d, y: 0.04209324879973042d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8655639866340912d, y: 0.5311485633179627d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7346627563661924d, y: 0.02777804587390864d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9010898313882707d, y: 0.45310758272667695d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6730916891649349d, y: 0.26325537940930976d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47192923938797504d, y: 0.034895536160398866d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37305583671324694d, y: 0.3115816184957172d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9607444991313576d, y: 0.8991061476287893d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8883733798828887d, y: 0.7004033256409836d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02783148897563692d, y: 0.09742103077663156d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13678162607179112d, y: 0.14847230771009579d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2541196863794327d, y: 0.9766823666890913d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5908563500830383d, y: 0.13236182172250366d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9536902641161424d, y: 0.11834850126718788d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15430836756305877d, y: 0.6617110732352682d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3858092923268287d, y: 0.38568943286349333d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2669329901992712d, y: 0.5045414877199279d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5383686696912399d, y: 0.7169193951558435d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19919612624090866d, y: 0.4058247840027094d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8880296116648221d, y: 0.5741404258224522d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7835407656249158d, y: 0.4545998615874448d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1401135689834918d, y: 0.6236659508481559d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3419736720885196d, y: 0.8144909062265449d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.001777639661574515d, y: 0.476947130415621d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2999949952388091d, y: 0.7548286195734952d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26349842768875065d, y: 0.3334021050360598d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8221107365606241d, y: 0.09965144156877981d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0051418600270450865d, y: 0.8902488192030573d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2892761100667649d, y: 0.8303993982816467d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8965497544516223d, y: 0.9308699832096842d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.715382234085444d, y: 0.9950411053278807d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5492505703637381d, y: 0.09438206808963212d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5077010967335307d, y: 0.09537502183424285d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04937588075198185d, y: 0.3634816410485443d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5295704034686061d, y: 0.10141397665546059d),
new NpgsqlTypes.NpgsqlPoint(x: 0.988548304705085d, y: 0.27358624842041057d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.699607065563646d, y: 0.6145966568698557d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6382944280850952d, y: 0.8739418801808466d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16884679192503482d, y: 0.6595705929476624d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24674238049206865d, y: 0.45791046323339646d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.705838541431323d, y: 0.3338340283716432d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14304601914801118d, y: 0.789293935111176d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5753892942997331d, y: 0.8277575788404007d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9885521023045993d, y: 0.46592626485428523d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9850922325224456d, y: 0.33744839026924767d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5066250990086175d, y: 0.6958381778635533d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5312115746260251d, y: 0.3440084230209457d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.977997692958288d, y: 0.5062634891109976d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9089313710259423d, y: 0.37449240665005834d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6127707721016452d, y: 0.028702691804260327d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13484372745024542d, y: 0.7243252397213388d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.335072302632458d, y: 0.2715429834316523d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3834132986104669d, y: 0.6861696239131637d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9446353752653025d, y: 0.11148583789460242d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0379694517729432d, y: 0.5670687933671105d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9914192668512029d, y: 0.5093231594708618d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2228103829730882d, y: 0.679899953407484d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1265617886069791d, y: 0.1496189695526604d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9549456703439115d, y: 0.7053053829306816d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8296008418430533d, y: 0.4082282149904476d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6543357599121002d, y: 0.7345162212074321d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5499725568611749d, y: 0.21449545970132422d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.898118653446121d, y: 0.45179769135697057d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8975006114497962d, y: 0.4694255577600557d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8900199894333645d, y: 0.7725430462945712d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.641357627355145d, y: 0.03683200338938475d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3714208916841d, y: 0.28017603735099583d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7188216742754108d, y: 0.2511336226019675d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7246083595664035d, y: 0.8645578167679143d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8055533081966901d, y: 0.33999968600858277d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09926661438928952d, y: 0.9498066608522562d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8691380885888967d, y: 0.586316554397749d),
new NpgsqlTypes.NpgsqlPoint(x: 0.993761227550894d, y: 0.12497081624780215d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6608729132470199d, y: 0.72682414196397d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13038183371400502d, y: 0.4367385620307518d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5056547646490365d, y: 0.6086577235611278d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3063761669002232d, y: 0.08175620896998714d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6607643290378454d, y: 0.7706589322094629d),
new NpgsqlTypes.NpgsqlPoint(x: 0.952846377876446d, y: 0.22629113876207874d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9679708750936584d, y: 0.05021078627792597d),
new NpgsqlTypes.NpgsqlPoint(x: 0.925161415661751d, y: 0.6741831142851421d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39911795813576045d, y: 0.31091495970846184d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9867963031360779d, y: 0.8295317746453919d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3610291284416577d, y: 0.46934970985222924d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7734940576438589d, y: 0.06995999473432268d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5448394415847785d, y: 0.8945599653479062d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07909198272830098d, y: 0.8622703866865964d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39697367487928437d, y: 0.897082863779406d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5476705045322905d, y: 0.4123348661336561d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3026758895960918d, y: 0.5320584349407972d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9726709465411727d, y: 0.03142391632950625d),
new NpgsqlTypes.NpgsqlPoint(x: 0.879187810136515d, y: 0.4406104324375778d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8570081152212018d, y: 0.555015952456184d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2996604159307089d, y: 0.3483215300225505d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06464344269545974d, y: 0.23243262403577547d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35297882109171685d, y: 0.36805926328069105d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38654605158620303d, y: 0.5423647405285736d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6580131530003773d, y: 0.4346312487089562d),
new NpgsqlTypes.NpgsqlPoint(x: 0.771268398185155d, y: 0.14199225307149954d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14505185167540768d, y: 0.8824362368442591d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09846207315944866d, y: 0.08129462285535727d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48604589931063424d, y: 0.7093328418988553d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07204542589892027d, y: 0.28057212999296544d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6859032483363229d, y: 0.7822583359385881d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20951313012663708d, y: 0.6818429858935512d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05614613911002342d, y: 0.23682558907638762d),
new NpgsqlTypes.NpgsqlPoint(x: 0.395930807205239d, y: 0.6433532610339572d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4785621743310935d, y: 0.3826389747640504d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6771798879933464d, y: 0.46242557352299585d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2035817332246308d, y: 0.2828556661117837d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7262145403756335d, y: 0.22740975450195045d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4558709285094329d, y: 0.5715109074356026d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28178205374923304d, y: 0.6769352046532515d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19823931127116334d, y: 0.8550853758304663d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1607111677815649d, y: 0.3150801896806641d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3991882310836873d, y: 0.08993401945892954d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8546216169332909d, y: 0.2916853291316196d),
new NpgsqlTypes.NpgsqlPoint(x: 0.028201667115657525d, y: 0.9310153615443905d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13086231924232972d, y: 0.2890553636128117d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.27554668194175636d, y: 0.7155245112400522d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14949178234449556d, y: 0.894413770636611d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7428993112391693d, y: 0.7436463251645533d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8499808509684035d, y: 0.6707242224090415d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.74877736616512d, y: 0.8605026726368243d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7797614201322994d, y: 0.30123807194178687d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23394240595214988d, y: 0.6935712532382328d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4295555182703893d, y: 0.17155182405354275d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8286706429896727d, y: 0.028801082929414634d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7943953843905315d, y: 0.6102484170243071d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2034463708735298d, y: 0.6867206396801099d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16281904362843191d, y: 0.8024793269751486d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4340940163474504d, y: 0.8070525347745212d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7030763358621878d, y: 0.7971705800112603d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6602586584791225d, y: 0.9558685756518656d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5655148566648467d, y: 0.47300039263133586d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5188888370686965d, y: 0.8851982489018811d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14784170766220217d, y: 0.4392113270794378d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33997229651458316d, y: 0.8155473968112356d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36164656367905035d, y: 0.8103043394645416d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4380078662219763d, y: 0.5046687818508818d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39860286302134396d, y: 0.2507247625141269d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8211764533677519d, y: 0.5130386790512288d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02295513631845747d, y: 0.6483690745133727d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17595257198285352d, y: 0.30521452021325235d),
new NpgsqlTypes.NpgsqlPoint(x: 0.381987294447506d, y: 0.6727858938858219d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6631581250632927d, y: 0.9343200189161438d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5290314601324235d, y: 0.198862685401206d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7893477318883758d, y: 0.5596643102562533d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6507912086028802d, y: 0.5268842434962114d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4900998264168499d, y: 0.5060834169753675d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3743368288900626d, y: 0.38041153598428035d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46265113059328566d, y: 0.8103992672081163d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4470620654524079d, y: 0.6616058162816335d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16660848641518633d, y: 0.16211100779759036d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6326745733556698d, y: 0.3493972107032234d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14255221235027316d, y: 0.004679299845048335d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15372205543427941d, y: 0.7749358333263308d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8016444711767552d, y: 0.46838257593093036d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3264315066505338d, y: 0.10225907025233372d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8471518567918457d, y: 0.6660462411479303d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5449536896524989d, y: 0.4195905631338326d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6192167462969762d, y: 0.21723256669340263d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7987488411747764d, y: 0.28897122362189265d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9078217060154838d, y: 0.5319825258581206d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2362449185535891d, y: 0.29548876716750394d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2754279749491825d, y: 0.7428331842435975d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4262504160745114d, y: 0.049915720529264185d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29127463811640575d, y: 0.7329245113335604d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8894983090361218d, y: 0.8837772878103424d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36885746915807793d, y: 0.0070923629752223105d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01922089841515684d, y: 0.2854215256591115d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8627947100351646d, y: 0.9716287452735679d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4297069065786344d, y: 0.9062719929692941d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1508100321641025d, y: 0.481931716926718d),
},
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44167283315595995d, y: 0.6843413219816843d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9808678292911001d, y: 0.6749344535915024d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1258123102534795d, y: 0.22907587281309072d),
},
    ModelInner = new NpgsqlPointpointMArrayD11MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5021196301257902d, y: 0.1868893469706039d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39714574423136495d, y: 0.9272615061162176d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6654280715978123d, y: 0.10617811786816511d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6687287474721566d, y: 0.31856802091891256d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02959294824821823d, y: 0.19145472835471733d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7876071301278271d, y: 0.4411515849434309d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6495854424062237d, y: 0.4972971163351181d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD1E1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7336767039453492d, y: 0.9112547631342295d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0927846454635175d, y: 0.4721985220224121d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8821709031425826d, y: 0.33927706419036974d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmarrayd11mi(
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
INSERT INTO public.npgsqlpointpointmarrayd11mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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

                changedRows =  ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmarrayd11mi_id
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)), 
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
                methodParametrName: "npgsqlpointpointmarrayd11mi_id", 
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
                changedRows =  ((INpgsqlPointMArraypointMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointMArraypointMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmarrayd11mi_id
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
    npgsqlpointpointmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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

                    nullable =  ((INpgsqlPointMArraypointMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((INpgsqlPointMArraypointMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((INpgsqlPointMArraypointMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37380263953771964d, y: 0.2876280343407204d),
new NpgsqlTypes.NpgsqlPoint(x: 0.012229538098093906d, y: 0.2767136522255442d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4310457418256649d, y: 0.3231201810727885d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4461347882995381d, y: 0.43832710739702474d),
}));
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

                    nullable = await ((INpgsqlPointMArraypointMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmarrayd11mi_id
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
    npgsqlpointpointmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
                methodParametrName: "npgsqlpointpointmarrayd11mi_id", 
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
                nullable =  ((INpgsqlPointMArraypointMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7901840496981901d, y: 0.5839833502262965d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9199300358073643d, y: 0.45751855774238015d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5606224574381273d, y: 0.8403024565842355d),
}));
                nullable =  ((INpgsqlPointMArraypointMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((INpgsqlPointMArraypointMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8180536232021339d, y: 0.3768594152222138d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44057057904516583d, y: 0.8005695265851254d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9983914002506421d, y: 0.8353589232026847d),
}));
                nullable = await ((INpgsqlPointMArraypointMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMArrayD1E1M> models = null;

                models =  ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMArrayD1E1M> models = null;

                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointMArraypointMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD1E1M), typeof(FlatNpgsqlPointpointMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                ((INpgsqlPointMArraypointMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointMArraypointMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmarrayd11mi mi ON mi.id = m.npgsqlpointpointmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointMArraypointMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD1E1M), typeof(FlatNpgsqlPointpointMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                ((INpgsqlPointMArraypointMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmarrayd11mi mi ON mi.id = m.npgsqlpointpointmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointMArraypointMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD1E1M), typeof(FlatNpgsqlPointpointMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                await((INpgsqlPointMArraypointMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointMArraypointMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 165;
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
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmarrayd11mi mi ON mi.id = m.npgsqlpointpointmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
                var models = await((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD1E1M), typeof(FlatNpgsqlPointpointMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                await((INpgsqlPointMArraypointMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 81, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 69, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 156, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 74, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointMArraypointMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 32, query1, 5, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                await ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 165, query1, 69, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 130, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
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
FROM public.npgsqlpointpointmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD1E1M>();
                 ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 169, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd1e1m m
LEFT JOIN public.npgsqlpointpointmarrayd11mi mi ON mi.id = m.npgsqlpointpointmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
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
                var models = await((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 32, 21))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointMArraypointMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 121, 137))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointMArraypointMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointMArraypointMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointMArraypointMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointMArraypointMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 36);
                var models =  ((INpgsqlPointMArraypointMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlPointpointMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                NpgsqlPointpointMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.binary_npgsqlpointpointmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMArrayD11MIWA),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMArrayD11MI),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointmarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1))]
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
FROM public.binary_npgsqlpointpointmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpointpointmarrayd11mi mi ON mi.id = m.npgsqlpointpointmarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointmarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models =  ((INpgsqlPointMArraypointMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD11MIWA), typeof(NpgsqlPointpointMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointMArrayD11MIWA>();
                var models2 = new List<NpgsqlPointpointMArrayD11MIWA>();
                await ((INpgsqlPointMArraypointMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMArrayD11MIWA>();
                var models2 = new List<NpgsqlPointpointMArrayD11MIWA>();
                ((INpgsqlPointMArraypointMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmarrayd11mi
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
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmarrayd11mi
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
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD11MIWA), typeof(NpgsqlPointpointMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1))]
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
                var models1 = new List<NpgsqlPointpointMArrayD11MIWA>();
                var models2 = new List<NpgsqlPointpointMArrayD11MIWA>();
                await ((INpgsqlPointMArraypointMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMArrayD11MIWA>();
                var models2 = new List<NpgsqlPointpointMArrayD11MIWA>();
                ((INpgsqlPointMArraypointMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1))]
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
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmarrayd11mi
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
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmarrayd11mi
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
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD11MI), typeof(NpgsqlPointpointMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointMArrayD11MI>();
                var models2 = new List<NpgsqlPointpointMArrayD11MI>();
                await ((INpgsqlPointMArraypointMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMArrayD11MI>();
                var models2 = new List<NpgsqlPointpointMArrayD11MI>();
                ((INpgsqlPointMArraypointMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD11MIWA), typeof(NpgsqlPointpointMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1))]
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
                var models1 = new List<NpgsqlPointpointMArrayD11MIWA>();
                var models2 = new List<NpgsqlPointpointMArrayD11MIWA>();
                await ((INpgsqlPointMArraypointMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMArrayD11MIWA>();
                var models2 = new List<NpgsqlPointpointMArrayD11MIWA>();
                ((INpgsqlPointMArraypointMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD1))]
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
                var models = await ((INpgsqlPointMArraypointMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

