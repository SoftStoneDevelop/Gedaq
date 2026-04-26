

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
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5923143155779018d, y: 0.46748533923513413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9852370210619642d, y: 0.5169721480953605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8733953701991406d, y: 0.30421615602550944d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04746799091546561d, y: 0.7257860318397492d), new NpgsqlTypes.NpgsqlPoint(x: 0.8827344384045186d, y: 0.22351698488508576d), new NpgsqlTypes.NpgsqlPoint(x: 0.2692125322924058d, y: 0.24699726288644175d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7607598896339428d, y: 0.47900246499210186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5688864170398167d, y: 0.5000693626996994d), new NpgsqlTypes.NpgsqlPoint(x: 0.9733199383346207d, y: 0.6504019224247799d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3813626271722288d, y: 0.8983121252489502d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978453628910115d, y: 0.1264233878430442d), new NpgsqlTypes.NpgsqlPoint(x: 0.083728556308026d, y: 0.4715234761366792d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36174312120603214d, y: 0.2613270866122964d), new NpgsqlTypes.NpgsqlPoint(x: 0.035398335988852336d, y: 0.6182388666554575d), new NpgsqlTypes.NpgsqlPoint(x: 0.4915416004484856d, y: 0.31096701115189074d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.994209330788879d, y: 0.04520843534242569d), new NpgsqlTypes.NpgsqlPoint(x: 0.07386957300638286d, y: 0.1921454256383739d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807624728363733d, y: 0.7060671798101995d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48635548539509843d, y: 0.6842259533360583d), new NpgsqlTypes.NpgsqlPoint(x: 0.8059879123186234d, y: 0.4388620700477104d), new NpgsqlTypes.NpgsqlPoint(x: 0.7578374561107323d, y: 0.4223188155252724d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7356921430064128d, y: 0.9442616910452913d), new NpgsqlTypes.NpgsqlPoint(x: 0.019642969380259445d, y: 0.77218259744264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9914961316849261d, y: 0.9837286975759517d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7636330679102783d, y: 0.5466608814525208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663946494956215d, y: 0.7275808972179874d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599712331994292d, y: 0.7383359265295528d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49016108387417134d, y: 0.12168951755642754d), new NpgsqlTypes.NpgsqlPoint(x: 0.0417948534152518d, y: 0.9105031163115916d), new NpgsqlTypes.NpgsqlPoint(x: 0.49961492118333084d, y: 0.4958817298861492d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.618213599011295d, y: 0.7862189120705001d), new NpgsqlTypes.NpgsqlPoint(x: 0.21779085865628645d, y: 0.19682276593971837d), new NpgsqlTypes.NpgsqlPoint(x: 0.6208291584268393d, y: 0.09091848154516691d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30148186489428497d, y: 0.032047803732533464d), new NpgsqlTypes.NpgsqlPoint(x: 0.9381019813437208d, y: 0.13015624959896988d), new NpgsqlTypes.NpgsqlPoint(x: 0.17295322466226193d, y: 0.17187207662065085d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.534009543938477d, y: 0.6468839012829164d), new NpgsqlTypes.NpgsqlPoint(x: 0.6899112807238069d, y: 0.21940132382758737d), new NpgsqlTypes.NpgsqlPoint(x: 0.5639757060826867d, y: 0.4707308439553455d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16785073574617326d, y: 0.6717662792645323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9729841405291034d, y: 0.6986232053264695d), new NpgsqlTypes.NpgsqlPoint(x: 0.1814291295425705d, y: 0.4903770446327559d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7352326292441074d, y: 0.500093835231234d), new NpgsqlTypes.NpgsqlPoint(x: 0.2964843579226599d, y: 0.5476871410608937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8097409533926744d, y: 0.1930127015960259d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6668332943578741d, y: 0.43932168272934236d), new NpgsqlTypes.NpgsqlPoint(x: 0.01967969181574536d, y: 0.5343104960410131d), new NpgsqlTypes.NpgsqlPoint(x: 0.49539453237853415d, y: 0.7227649232199035d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05272222202944454d, y: 0.1755299457513354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9869049470596468d, y: 0.2392563738411866d), new NpgsqlTypes.NpgsqlPoint(x: 0.7200835089842724d, y: 0.8819471720962225d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4357391500528399d, y: 0.6449852212636422d), new NpgsqlTypes.NpgsqlPoint(x: 0.10035382059071019d, y: 0.7021188262907486d), new NpgsqlTypes.NpgsqlPoint(x: 0.5776340673514553d, y: 0.5749270169998064d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7429641580685679d, y: 0.42537925138622434d), new NpgsqlTypes.NpgsqlPoint(x: 0.8899713286214831d, y: 0.9070920731741218d), new NpgsqlTypes.NpgsqlPoint(x: 0.307822471166061d, y: 0.9717978621582447d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7803253383757571d, y: 0.2549157896693901d), new NpgsqlTypes.NpgsqlPoint(x: 0.647209701828643d, y: 0.992313293340223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1354222064116083d, y: 0.09322036873631301d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07167901813405853d, y: 0.33831455502546703d), new NpgsqlTypes.NpgsqlPoint(x: 0.3381139575649016d, y: 0.15908660969559996d), new NpgsqlTypes.NpgsqlPoint(x: 0.5233879146200945d, y: 0.677470372612471d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3848069573120456d, y: 0.09891740712653341d), new NpgsqlTypes.NpgsqlPoint(x: 0.5071130875734908d, y: 0.08366688563961311d), new NpgsqlTypes.NpgsqlPoint(x: 0.2875312304731027d, y: 0.18088356505346237d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42666842693433804d, y: 0.9649755455951494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9086175944856957d, y: 0.2717899069167925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7841525366399726d, y: 0.5188473323451616d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8675035567111735d, y: 0.1188161394322288d), new NpgsqlTypes.NpgsqlPoint(x: 0.7045012060081598d, y: 0.4349656983916347d), new NpgsqlTypes.NpgsqlPoint(x: 0.6024159325198208d, y: 0.868091210514566d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6672663743976821d, y: 0.8072023968907501d), new NpgsqlTypes.NpgsqlPoint(x: 0.43051853834093456d, y: 0.6555492084177591d), new NpgsqlTypes.NpgsqlPoint(x: 0.30299768385282844d, y: 0.4077414162908627d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4584566803409277d, y: 0.1447951157175964d), new NpgsqlTypes.NpgsqlPoint(x: 0.303895903530064d, y: 0.5019816146288235d), new NpgsqlTypes.NpgsqlPoint(x: 0.8733080959539473d, y: 0.33686419096904896d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7188271068117525d, y: 0.49996565763412804d), new NpgsqlTypes.NpgsqlPoint(x: 0.038813905327098386d, y: 0.12554712893478737d), new NpgsqlTypes.NpgsqlPoint(x: 0.09399923576701807d, y: 0.10429694581031435d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02186132565282972d, y: 0.9068318390728991d), new NpgsqlTypes.NpgsqlPoint(x: 0.4836553632566447d, y: 0.29974395677883925d), new NpgsqlTypes.NpgsqlPoint(x: 0.20645876254810835d, y: 0.04894187960975038d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8536263672413774d, y: 0.9358580539628457d), new NpgsqlTypes.NpgsqlPoint(x: 0.39269912024093157d, y: 0.267720694766692d), new NpgsqlTypes.NpgsqlPoint(x: 0.407077477416369d, y: 0.7622327506261505d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20768478279330327d, y: 0.5390922634289806d), new NpgsqlTypes.NpgsqlPoint(x: 0.01823427844729375d, y: 0.966590659083081d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800546316023766d, y: 0.14578293941698894d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10943968001115523d, y: 0.8342806029198985d), new NpgsqlTypes.NpgsqlPoint(x: 0.16291225069432813d, y: 0.2942969538678176d), new NpgsqlTypes.NpgsqlPoint(x: 0.7079783328420358d, y: 0.7805341189909792d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1694139882568424d, y: 0.17393718312572404d), new NpgsqlTypes.NpgsqlPoint(x: 0.03504166908303652d, y: 0.7674571994484088d), new NpgsqlTypes.NpgsqlPoint(x: 0.49264771996424284d, y: 0.9901830247853408d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6112981820416143d, y: 0.6102136716725126d), new NpgsqlTypes.NpgsqlPoint(x: 0.9184566747986449d, y: 0.9772602381182574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9816401319361678d, y: 0.5034541552166523d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6191397435492442d, y: 0.48634237061033514d), new NpgsqlTypes.NpgsqlPoint(x: 0.2942400343285584d, y: 0.5359962965313175d), new NpgsqlTypes.NpgsqlPoint(x: 0.8468901523854022d, y: 0.4185625125524305d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8822588255986498d, y: 0.6680641091569156d), new NpgsqlTypes.NpgsqlPoint(x: 0.5070613786044067d, y: 0.05535876787291072d), new NpgsqlTypes.NpgsqlPoint(x: 0.7350778377563914d, y: 0.09376554792852343d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7572869644674451d, y: 0.9936500884212929d), new NpgsqlTypes.NpgsqlPoint(x: 0.5573985235545132d, y: 0.552662286106688d), new NpgsqlTypes.NpgsqlPoint(x: 0.6833597624905954d, y: 0.2684309667532587d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5335208119586289d, y: 0.15174533915021782d), new NpgsqlTypes.NpgsqlPoint(x: 0.921021048680803d, y: 0.9161037707230683d), new NpgsqlTypes.NpgsqlPoint(x: 0.33727761194845485d, y: 0.3762536091192018d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4226752259695097d, y: 0.21203396604805425d), new NpgsqlTypes.NpgsqlPoint(x: 0.4468731192917511d, y: 0.5832741817307727d), new NpgsqlTypes.NpgsqlPoint(x: 0.3393219605033798d, y: 0.46544898299089d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9772675272810236d, y: 0.9624168183973706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9206413484058d, y: 0.15889579405989318d), new NpgsqlTypes.NpgsqlPoint(x: 0.4876015653224609d, y: 0.0030185889122233966d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42550220995018795d, y: 0.2822982749631271d), new NpgsqlTypes.NpgsqlPoint(x: 0.01293804546413213d, y: 0.4009888507131931d), new NpgsqlTypes.NpgsqlPoint(x: 0.019404159641043806d, y: 0.9695334048745549d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5194213841445267d, y: 0.8323041542845742d), new NpgsqlTypes.NpgsqlPoint(x: 0.676740705476385d, y: 0.9188601102656182d), new NpgsqlTypes.NpgsqlPoint(x: 0.310873056485962d, y: 0.5411675564006649d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6858657846183114d, y: 0.6481289325317382d), new NpgsqlTypes.NpgsqlPoint(x: 0.9600814296435758d, y: 0.2480819804893476d), new NpgsqlTypes.NpgsqlPoint(x: 0.12532558967610374d, y: 0.15773576886647012d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33424330741428077d, y: 0.35556506803686794d), new NpgsqlTypes.NpgsqlPoint(x: 0.14627005957641526d, y: 0.13728694580784406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9811912874923905d, y: 0.19095474678628144d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5668771486754646d, y: 0.6424950073735215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7829753075317875d, y: 0.6929089984598454d), new NpgsqlTypes.NpgsqlPoint(x: 0.43111803907039925d, y: 0.15858631871015316d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.067500619403559d, y: 0.9466267474757245d), new NpgsqlTypes.NpgsqlPoint(x: 0.7755481556891507d, y: 0.042527924904030345d), new NpgsqlTypes.NpgsqlPoint(x: 0.789714289499864d, y: 0.6054079601604824d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3896180381591777d, y: 0.11162334921461436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9018728077919472d, y: 0.35666762114954387d), new NpgsqlTypes.NpgsqlPoint(x: 0.1207046047871384d, y: 0.3154645608877993d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25667448837497087d, y: 0.529803950704426d), new NpgsqlTypes.NpgsqlPoint(x: 0.4399344774845847d, y: 0.34939356268853694d), new NpgsqlTypes.NpgsqlPoint(x: 0.7674652469912183d, y: 0.7657635565367913d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06843024280649801d, y: 0.46878863079414623d), new NpgsqlTypes.NpgsqlPoint(x: 0.3883115296291323d, y: 0.7380680252005823d), new NpgsqlTypes.NpgsqlPoint(x: 0.02047954207672842d, y: 0.960963051227404d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2659346257336086d, y: 0.27903520030003126d), new NpgsqlTypes.NpgsqlPoint(x: 0.12198762790857776d, y: 0.1590905583461758d), new NpgsqlTypes.NpgsqlPoint(x: 0.7095330264422001d, y: 0.12707122396408688d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9823090738410462d, y: 0.03148868207605893d), new NpgsqlTypes.NpgsqlPoint(x: 0.4983846927935687d, y: 0.98563652587397d), new NpgsqlTypes.NpgsqlPoint(x: 0.9792817695274909d, y: 0.6268007012526762d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12806941993687848d, y: 0.16440511983050454d), new NpgsqlTypes.NpgsqlPoint(x: 0.7933003441865432d, y: 0.34471828801357374d), new NpgsqlTypes.NpgsqlPoint(x: 0.3761253210960579d, y: 0.3301363454810037d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7451345647930243d, y: 0.3946737137219064d), new NpgsqlTypes.NpgsqlPoint(x: 0.17557276120631227d, y: 0.7545818837363205d), new NpgsqlTypes.NpgsqlPoint(x: 0.06230168905600031d, y: 0.7547322842757636d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5655570512164559d, y: 0.9030868170861257d), new NpgsqlTypes.NpgsqlPoint(x: 0.5536887251299947d, y: 0.21006776147471962d), new NpgsqlTypes.NpgsqlPoint(x: 0.13524565839506597d, y: 0.5516644037629186d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34033690769551317d, y: 0.5080413406043849d), new NpgsqlTypes.NpgsqlPoint(x: 0.43507680755140343d, y: 0.0744262290526938d), new NpgsqlTypes.NpgsqlPoint(x: 0.08124774213598696d, y: 0.8189020008636403d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12570425011858266d, y: 0.8867953432669724d), new NpgsqlTypes.NpgsqlPoint(x: 0.37950713402862013d, y: 0.8444105152093606d), new NpgsqlTypes.NpgsqlPoint(x: 0.9369336138609575d, y: 0.45305524712930123d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.839601904543672d, y: 0.07553531151800796d), new NpgsqlTypes.NpgsqlPoint(x: 0.508818215138659d, y: 0.9103650435986606d), new NpgsqlTypes.NpgsqlPoint(x: 0.8700588762006746d, y: 0.6128226632048303d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3534242449848559d, y: 0.9824193431185682d), new NpgsqlTypes.NpgsqlPoint(x: 0.0328166180306938d, y: 0.21470347423204794d), new NpgsqlTypes.NpgsqlPoint(x: 0.3119826698745243d, y: 0.2901358556021426d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4484679256704054d, y: 0.4903016248979952d), new NpgsqlTypes.NpgsqlPoint(x: 0.6848314626597951d, y: 0.2812563470484849d), new NpgsqlTypes.NpgsqlPoint(x: 0.1189175374429714d, y: 0.7875640427486299d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4272802381908918d, y: 0.10983130728183155d), new NpgsqlTypes.NpgsqlPoint(x: 0.14686738083224193d, y: 0.5957091070813653d), new NpgsqlTypes.NpgsqlPoint(x: 0.07484219781922385d, y: 0.6608036305564104d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5971254737538826d, y: 0.09154216042957242d), new NpgsqlTypes.NpgsqlPoint(x: 0.9536604225739643d, y: 0.8076380096972067d), new NpgsqlTypes.NpgsqlPoint(x: 0.7524322094404163d, y: 0.9460977240304279d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.882991001354024d, y: 0.2686716335284225d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612686598647034d, y: 0.8403930208971868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4223150840431127d, y: 0.426444456377146d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38419340991052364d, y: 0.32563352932137624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8449025810373131d, y: 0.9889475584606118d), new NpgsqlTypes.NpgsqlPoint(x: 0.7460560150374108d, y: 0.48588590362112827d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16595655285159527d, y: 0.5339313040812964d), new NpgsqlTypes.NpgsqlPoint(x: 0.25897764671631696d, y: 0.775580243404434d), new NpgsqlTypes.NpgsqlPoint(x: 0.7353657721999577d, y: 0.34935187765527265d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5552525118569708d, y: 0.945908724129584d), new NpgsqlTypes.NpgsqlPoint(x: 0.06638590973253855d, y: 0.9134706212088841d), new NpgsqlTypes.NpgsqlPoint(x: 0.006623101020014399d, y: 0.5199553266986212d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6560403844329478d, y: 0.6272957678674835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5440579875349417d, y: 0.8950857637169107d), new NpgsqlTypes.NpgsqlPoint(x: 0.2865163632400819d, y: 0.7207998979925707d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9363774186562193d, y: 0.6022853673396199d), new NpgsqlTypes.NpgsqlPoint(x: 0.07179993008920427d, y: 0.9786713925466807d), new NpgsqlTypes.NpgsqlPoint(x: 0.06231508806916286d, y: 0.5376474616973936d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7767587015680294d, y: 0.42871986501107007d), new NpgsqlTypes.NpgsqlPoint(x: 0.8073496433560913d, y: 0.1743334639058024d), new NpgsqlTypes.NpgsqlPoint(x: 0.5495714638803152d, y: 0.64757270720489d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13707522121835336d, y: 0.9647300577593989d), new NpgsqlTypes.NpgsqlPoint(x: 0.9719403233491255d, y: 0.626403291990871d), new NpgsqlTypes.NpgsqlPoint(x: 0.269934775946856d, y: 0.7087316931458022d)),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49016108387417134d, y: 0.12168951755642754d), new NpgsqlTypes.NpgsqlPoint(x: 0.0417948534152518d, y: 0.9105031163115916d), new NpgsqlTypes.NpgsqlPoint(x: 0.49961492118333084d, y: 0.4958817298861492d))));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16785073574617326d, y: 0.6717662792645323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9729841405291034d, y: 0.6986232053264695d), new NpgsqlTypes.NpgsqlPoint(x: 0.1814291295425705d, y: 0.4903770446327559d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6668332943578741d, y: 0.43932168272934236d), new NpgsqlTypes.NpgsqlPoint(x: 0.01967969181574536d, y: 0.5343104960410131d), new NpgsqlTypes.NpgsqlPoint(x: 0.49539453237853415d, y: 0.7227649232199035d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7803253383757571d, y: 0.2549157896693901d), new NpgsqlTypes.NpgsqlPoint(x: 0.647209701828643d, y: 0.992313293340223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1354222064116083d, y: 0.09322036873631301d))));
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42666842693433804d, y: 0.9649755455951494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9086175944856957d, y: 0.2717899069167925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7841525366399726d, y: 0.5188473323451616d))));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[4], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[5], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[6], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[7], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[8], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[9], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[10], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[11], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[12], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[4], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[5], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[6], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[7], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[8], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[6], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[7], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[8], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 59, query1, 26, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[5], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[6], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[7], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[8], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[9], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[10], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[11], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[12], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 141, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[7], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[8], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[9], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[10], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[11], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[12], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelBatchAsync(connection, 37, 132))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[7], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[8], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelBatch(connection, 141, 105))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[29], false);
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
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 70);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5923143155779018d, y: 0.46748533923513413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9852370210619642d, y: 0.5169721480953605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8733953701991406d, y: 0.30421615602550944d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04746799091546561d, y: 0.7257860318397492d), new NpgsqlTypes.NpgsqlPoint(x: 0.8827344384045186d, y: 0.22351698488508576d), new NpgsqlTypes.NpgsqlPoint(x: 0.2692125322924058d, y: 0.24699726288644175d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7607598896339428d, y: 0.47900246499210186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5688864170398167d, y: 0.5000693626996994d), new NpgsqlTypes.NpgsqlPoint(x: 0.9733199383346207d, y: 0.6504019224247799d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3813626271722288d, y: 0.8983121252489502d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978453628910115d, y: 0.1264233878430442d), new NpgsqlTypes.NpgsqlPoint(x: 0.083728556308026d, y: 0.4715234761366792d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36174312120603214d, y: 0.2613270866122964d), new NpgsqlTypes.NpgsqlPoint(x: 0.035398335988852336d, y: 0.6182388666554575d), new NpgsqlTypes.NpgsqlPoint(x: 0.4915416004484856d, y: 0.31096701115189074d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.994209330788879d, y: 0.04520843534242569d), new NpgsqlTypes.NpgsqlPoint(x: 0.07386957300638286d, y: 0.1921454256383739d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807624728363733d, y: 0.7060671798101995d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48635548539509843d, y: 0.6842259533360583d), new NpgsqlTypes.NpgsqlPoint(x: 0.8059879123186234d, y: 0.4388620700477104d), new NpgsqlTypes.NpgsqlPoint(x: 0.7578374561107323d, y: 0.4223188155252724d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7356921430064128d, y: 0.9442616910452913d), new NpgsqlTypes.NpgsqlPoint(x: 0.019642969380259445d, y: 0.77218259744264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9914961316849261d, y: 0.9837286975759517d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7636330679102783d, y: 0.5466608814525208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663946494956215d, y: 0.7275808972179874d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599712331994292d, y: 0.7383359265295528d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49016108387417134d, y: 0.12168951755642754d), new NpgsqlTypes.NpgsqlPoint(x: 0.0417948534152518d, y: 0.9105031163115916d), new NpgsqlTypes.NpgsqlPoint(x: 0.49961492118333084d, y: 0.4958817298861492d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.618213599011295d, y: 0.7862189120705001d), new NpgsqlTypes.NpgsqlPoint(x: 0.21779085865628645d, y: 0.19682276593971837d), new NpgsqlTypes.NpgsqlPoint(x: 0.6208291584268393d, y: 0.09091848154516691d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30148186489428497d, y: 0.032047803732533464d), new NpgsqlTypes.NpgsqlPoint(x: 0.9381019813437208d, y: 0.13015624959896988d), new NpgsqlTypes.NpgsqlPoint(x: 0.17295322466226193d, y: 0.17187207662065085d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.534009543938477d, y: 0.6468839012829164d), new NpgsqlTypes.NpgsqlPoint(x: 0.6899112807238069d, y: 0.21940132382758737d), new NpgsqlTypes.NpgsqlPoint(x: 0.5639757060826867d, y: 0.4707308439553455d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16785073574617326d, y: 0.6717662792645323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9729841405291034d, y: 0.6986232053264695d), new NpgsqlTypes.NpgsqlPoint(x: 0.1814291295425705d, y: 0.4903770446327559d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7352326292441074d, y: 0.500093835231234d), new NpgsqlTypes.NpgsqlPoint(x: 0.2964843579226599d, y: 0.5476871410608937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8097409533926744d, y: 0.1930127015960259d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6668332943578741d, y: 0.43932168272934236d), new NpgsqlTypes.NpgsqlPoint(x: 0.01967969181574536d, y: 0.5343104960410131d), new NpgsqlTypes.NpgsqlPoint(x: 0.49539453237853415d, y: 0.7227649232199035d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05272222202944454d, y: 0.1755299457513354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9869049470596468d, y: 0.2392563738411866d), new NpgsqlTypes.NpgsqlPoint(x: 0.7200835089842724d, y: 0.8819471720962225d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4357391500528399d, y: 0.6449852212636422d), new NpgsqlTypes.NpgsqlPoint(x: 0.10035382059071019d, y: 0.7021188262907486d), new NpgsqlTypes.NpgsqlPoint(x: 0.5776340673514553d, y: 0.5749270169998064d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7429641580685679d, y: 0.42537925138622434d), new NpgsqlTypes.NpgsqlPoint(x: 0.8899713286214831d, y: 0.9070920731741218d), new NpgsqlTypes.NpgsqlPoint(x: 0.307822471166061d, y: 0.9717978621582447d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7803253383757571d, y: 0.2549157896693901d), new NpgsqlTypes.NpgsqlPoint(x: 0.647209701828643d, y: 0.992313293340223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1354222064116083d, y: 0.09322036873631301d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07167901813405853d, y: 0.33831455502546703d), new NpgsqlTypes.NpgsqlPoint(x: 0.3381139575649016d, y: 0.15908660969559996d), new NpgsqlTypes.NpgsqlPoint(x: 0.5233879146200945d, y: 0.677470372612471d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3848069573120456d, y: 0.09891740712653341d), new NpgsqlTypes.NpgsqlPoint(x: 0.5071130875734908d, y: 0.08366688563961311d), new NpgsqlTypes.NpgsqlPoint(x: 0.2875312304731027d, y: 0.18088356505346237d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42666842693433804d, y: 0.9649755455951494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9086175944856957d, y: 0.2717899069167925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7841525366399726d, y: 0.5188473323451616d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8675035567111735d, y: 0.1188161394322288d), new NpgsqlTypes.NpgsqlPoint(x: 0.7045012060081598d, y: 0.4349656983916347d), new NpgsqlTypes.NpgsqlPoint(x: 0.6024159325198208d, y: 0.868091210514566d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6672663743976821d, y: 0.8072023968907501d), new NpgsqlTypes.NpgsqlPoint(x: 0.43051853834093456d, y: 0.6555492084177591d), new NpgsqlTypes.NpgsqlPoint(x: 0.30299768385282844d, y: 0.4077414162908627d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4584566803409277d, y: 0.1447951157175964d), new NpgsqlTypes.NpgsqlPoint(x: 0.303895903530064d, y: 0.5019816146288235d), new NpgsqlTypes.NpgsqlPoint(x: 0.8733080959539473d, y: 0.33686419096904896d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7188271068117525d, y: 0.49996565763412804d), new NpgsqlTypes.NpgsqlPoint(x: 0.038813905327098386d, y: 0.12554712893478737d), new NpgsqlTypes.NpgsqlPoint(x: 0.09399923576701807d, y: 0.10429694581031435d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02186132565282972d, y: 0.9068318390728991d), new NpgsqlTypes.NpgsqlPoint(x: 0.4836553632566447d, y: 0.29974395677883925d), new NpgsqlTypes.NpgsqlPoint(x: 0.20645876254810835d, y: 0.04894187960975038d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8536263672413774d, y: 0.9358580539628457d), new NpgsqlTypes.NpgsqlPoint(x: 0.39269912024093157d, y: 0.267720694766692d), new NpgsqlTypes.NpgsqlPoint(x: 0.407077477416369d, y: 0.7622327506261505d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20768478279330327d, y: 0.5390922634289806d), new NpgsqlTypes.NpgsqlPoint(x: 0.01823427844729375d, y: 0.966590659083081d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800546316023766d, y: 0.14578293941698894d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10943968001115523d, y: 0.8342806029198985d), new NpgsqlTypes.NpgsqlPoint(x: 0.16291225069432813d, y: 0.2942969538678176d), new NpgsqlTypes.NpgsqlPoint(x: 0.7079783328420358d, y: 0.7805341189909792d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1694139882568424d, y: 0.17393718312572404d), new NpgsqlTypes.NpgsqlPoint(x: 0.03504166908303652d, y: 0.7674571994484088d), new NpgsqlTypes.NpgsqlPoint(x: 0.49264771996424284d, y: 0.9901830247853408d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6112981820416143d, y: 0.6102136716725126d), new NpgsqlTypes.NpgsqlPoint(x: 0.9184566747986449d, y: 0.9772602381182574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9816401319361678d, y: 0.5034541552166523d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6191397435492442d, y: 0.48634237061033514d), new NpgsqlTypes.NpgsqlPoint(x: 0.2942400343285584d, y: 0.5359962965313175d), new NpgsqlTypes.NpgsqlPoint(x: 0.8468901523854022d, y: 0.4185625125524305d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8822588255986498d, y: 0.6680641091569156d), new NpgsqlTypes.NpgsqlPoint(x: 0.5070613786044067d, y: 0.05535876787291072d), new NpgsqlTypes.NpgsqlPoint(x: 0.7350778377563914d, y: 0.09376554792852343d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7572869644674451d, y: 0.9936500884212929d), new NpgsqlTypes.NpgsqlPoint(x: 0.5573985235545132d, y: 0.552662286106688d), new NpgsqlTypes.NpgsqlPoint(x: 0.6833597624905954d, y: 0.2684309667532587d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5335208119586289d, y: 0.15174533915021782d), new NpgsqlTypes.NpgsqlPoint(x: 0.921021048680803d, y: 0.9161037707230683d), new NpgsqlTypes.NpgsqlPoint(x: 0.33727761194845485d, y: 0.3762536091192018d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4226752259695097d, y: 0.21203396604805425d), new NpgsqlTypes.NpgsqlPoint(x: 0.4468731192917511d, y: 0.5832741817307727d), new NpgsqlTypes.NpgsqlPoint(x: 0.3393219605033798d, y: 0.46544898299089d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9772675272810236d, y: 0.9624168183973706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9206413484058d, y: 0.15889579405989318d), new NpgsqlTypes.NpgsqlPoint(x: 0.4876015653224609d, y: 0.0030185889122233966d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42550220995018795d, y: 0.2822982749631271d), new NpgsqlTypes.NpgsqlPoint(x: 0.01293804546413213d, y: 0.4009888507131931d), new NpgsqlTypes.NpgsqlPoint(x: 0.019404159641043806d, y: 0.9695334048745549d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5194213841445267d, y: 0.8323041542845742d), new NpgsqlTypes.NpgsqlPoint(x: 0.676740705476385d, y: 0.9188601102656182d), new NpgsqlTypes.NpgsqlPoint(x: 0.310873056485962d, y: 0.5411675564006649d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6858657846183114d, y: 0.6481289325317382d), new NpgsqlTypes.NpgsqlPoint(x: 0.9600814296435758d, y: 0.2480819804893476d), new NpgsqlTypes.NpgsqlPoint(x: 0.12532558967610374d, y: 0.15773576886647012d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33424330741428077d, y: 0.35556506803686794d), new NpgsqlTypes.NpgsqlPoint(x: 0.14627005957641526d, y: 0.13728694580784406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9811912874923905d, y: 0.19095474678628144d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5668771486754646d, y: 0.6424950073735215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7829753075317875d, y: 0.6929089984598454d), new NpgsqlTypes.NpgsqlPoint(x: 0.43111803907039925d, y: 0.15858631871015316d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.067500619403559d, y: 0.9466267474757245d), new NpgsqlTypes.NpgsqlPoint(x: 0.7755481556891507d, y: 0.042527924904030345d), new NpgsqlTypes.NpgsqlPoint(x: 0.789714289499864d, y: 0.6054079601604824d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3896180381591777d, y: 0.11162334921461436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9018728077919472d, y: 0.35666762114954387d), new NpgsqlTypes.NpgsqlPoint(x: 0.1207046047871384d, y: 0.3154645608877993d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25667448837497087d, y: 0.529803950704426d), new NpgsqlTypes.NpgsqlPoint(x: 0.4399344774845847d, y: 0.34939356268853694d), new NpgsqlTypes.NpgsqlPoint(x: 0.7674652469912183d, y: 0.7657635565367913d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06843024280649801d, y: 0.46878863079414623d), new NpgsqlTypes.NpgsqlPoint(x: 0.3883115296291323d, y: 0.7380680252005823d), new NpgsqlTypes.NpgsqlPoint(x: 0.02047954207672842d, y: 0.960963051227404d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2659346257336086d, y: 0.27903520030003126d), new NpgsqlTypes.NpgsqlPoint(x: 0.12198762790857776d, y: 0.1590905583461758d), new NpgsqlTypes.NpgsqlPoint(x: 0.7095330264422001d, y: 0.12707122396408688d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9823090738410462d, y: 0.03148868207605893d), new NpgsqlTypes.NpgsqlPoint(x: 0.4983846927935687d, y: 0.98563652587397d), new NpgsqlTypes.NpgsqlPoint(x: 0.9792817695274909d, y: 0.6268007012526762d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12806941993687848d, y: 0.16440511983050454d), new NpgsqlTypes.NpgsqlPoint(x: 0.7933003441865432d, y: 0.34471828801357374d), new NpgsqlTypes.NpgsqlPoint(x: 0.3761253210960579d, y: 0.3301363454810037d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7451345647930243d, y: 0.3946737137219064d), new NpgsqlTypes.NpgsqlPoint(x: 0.17557276120631227d, y: 0.7545818837363205d), new NpgsqlTypes.NpgsqlPoint(x: 0.06230168905600031d, y: 0.7547322842757636d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5655570512164559d, y: 0.9030868170861257d), new NpgsqlTypes.NpgsqlPoint(x: 0.5536887251299947d, y: 0.21006776147471962d), new NpgsqlTypes.NpgsqlPoint(x: 0.13524565839506597d, y: 0.5516644037629186d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34033690769551317d, y: 0.5080413406043849d), new NpgsqlTypes.NpgsqlPoint(x: 0.43507680755140343d, y: 0.0744262290526938d), new NpgsqlTypes.NpgsqlPoint(x: 0.08124774213598696d, y: 0.8189020008636403d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12570425011858266d, y: 0.8867953432669724d), new NpgsqlTypes.NpgsqlPoint(x: 0.37950713402862013d, y: 0.8444105152093606d), new NpgsqlTypes.NpgsqlPoint(x: 0.9369336138609575d, y: 0.45305524712930123d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.839601904543672d, y: 0.07553531151800796d), new NpgsqlTypes.NpgsqlPoint(x: 0.508818215138659d, y: 0.9103650435986606d), new NpgsqlTypes.NpgsqlPoint(x: 0.8700588762006746d, y: 0.6128226632048303d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3534242449848559d, y: 0.9824193431185682d), new NpgsqlTypes.NpgsqlPoint(x: 0.0328166180306938d, y: 0.21470347423204794d), new NpgsqlTypes.NpgsqlPoint(x: 0.3119826698745243d, y: 0.2901358556021426d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4484679256704054d, y: 0.4903016248979952d), new NpgsqlTypes.NpgsqlPoint(x: 0.6848314626597951d, y: 0.2812563470484849d), new NpgsqlTypes.NpgsqlPoint(x: 0.1189175374429714d, y: 0.7875640427486299d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4272802381908918d, y: 0.10983130728183155d), new NpgsqlTypes.NpgsqlPoint(x: 0.14686738083224193d, y: 0.5957091070813653d), new NpgsqlTypes.NpgsqlPoint(x: 0.07484219781922385d, y: 0.6608036305564104d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5971254737538826d, y: 0.09154216042957242d), new NpgsqlTypes.NpgsqlPoint(x: 0.9536604225739643d, y: 0.8076380096972067d), new NpgsqlTypes.NpgsqlPoint(x: 0.7524322094404163d, y: 0.9460977240304279d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.882991001354024d, y: 0.2686716335284225d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612686598647034d, y: 0.8403930208971868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4223150840431127d, y: 0.426444456377146d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38419340991052364d, y: 0.32563352932137624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8449025810373131d, y: 0.9889475584606118d), new NpgsqlTypes.NpgsqlPoint(x: 0.7460560150374108d, y: 0.48588590362112827d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16595655285159527d, y: 0.5339313040812964d), new NpgsqlTypes.NpgsqlPoint(x: 0.25897764671631696d, y: 0.775580243404434d), new NpgsqlTypes.NpgsqlPoint(x: 0.7353657721999577d, y: 0.34935187765527265d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5552525118569708d, y: 0.945908724129584d), new NpgsqlTypes.NpgsqlPoint(x: 0.06638590973253855d, y: 0.9134706212088841d), new NpgsqlTypes.NpgsqlPoint(x: 0.006623101020014399d, y: 0.5199553266986212d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6560403844329478d, y: 0.6272957678674835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5440579875349417d, y: 0.8950857637169107d), new NpgsqlTypes.NpgsqlPoint(x: 0.2865163632400819d, y: 0.7207998979925707d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9363774186562193d, y: 0.6022853673396199d), new NpgsqlTypes.NpgsqlPoint(x: 0.07179993008920427d, y: 0.9786713925466807d), new NpgsqlTypes.NpgsqlPoint(x: 0.06231508806916286d, y: 0.5376474616973936d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7767587015680294d, y: 0.42871986501107007d), new NpgsqlTypes.NpgsqlPoint(x: 0.8073496433560913d, y: 0.1743334639058024d), new NpgsqlTypes.NpgsqlPoint(x: 0.5495714638803152d, y: 0.64757270720489d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13707522121835336d, y: 0.9647300577593989d), new NpgsqlTypes.NpgsqlPoint(x: 0.9719403233491255d, y: 0.626403291990871d), new NpgsqlTypes.NpgsqlPoint(x: 0.269934775946856d, y: 0.7087316931458022d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5923143155779018d, y: 0.46748533923513413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9852370210619642d, y: 0.5169721480953605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8733953701991406d, y: 0.30421615602550944d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04746799091546561d, y: 0.7257860318397492d), new NpgsqlTypes.NpgsqlPoint(x: 0.8827344384045186d, y: 0.22351698488508576d), new NpgsqlTypes.NpgsqlPoint(x: 0.2692125322924058d, y: 0.24699726288644175d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7607598896339428d, y: 0.47900246499210186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5688864170398167d, y: 0.5000693626996994d), new NpgsqlTypes.NpgsqlPoint(x: 0.9733199383346207d, y: 0.6504019224247799d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3813626271722288d, y: 0.8983121252489502d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978453628910115d, y: 0.1264233878430442d), new NpgsqlTypes.NpgsqlPoint(x: 0.083728556308026d, y: 0.4715234761366792d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36174312120603214d, y: 0.2613270866122964d), new NpgsqlTypes.NpgsqlPoint(x: 0.035398335988852336d, y: 0.6182388666554575d), new NpgsqlTypes.NpgsqlPoint(x: 0.4915416004484856d, y: 0.31096701115189074d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.994209330788879d, y: 0.04520843534242569d), new NpgsqlTypes.NpgsqlPoint(x: 0.07386957300638286d, y: 0.1921454256383739d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807624728363733d, y: 0.7060671798101995d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48635548539509843d, y: 0.6842259533360583d), new NpgsqlTypes.NpgsqlPoint(x: 0.8059879123186234d, y: 0.4388620700477104d), new NpgsqlTypes.NpgsqlPoint(x: 0.7578374561107323d, y: 0.4223188155252724d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7356921430064128d, y: 0.9442616910452913d), new NpgsqlTypes.NpgsqlPoint(x: 0.019642969380259445d, y: 0.77218259744264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9914961316849261d, y: 0.9837286975759517d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7636330679102783d, y: 0.5466608814525208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663946494956215d, y: 0.7275808972179874d), new NpgsqlTypes.NpgsqlPoint(x: 0.7599712331994292d, y: 0.7383359265295528d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49016108387417134d, y: 0.12168951755642754d), new NpgsqlTypes.NpgsqlPoint(x: 0.0417948534152518d, y: 0.9105031163115916d), new NpgsqlTypes.NpgsqlPoint(x: 0.49961492118333084d, y: 0.4958817298861492d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.618213599011295d, y: 0.7862189120705001d), new NpgsqlTypes.NpgsqlPoint(x: 0.21779085865628645d, y: 0.19682276593971837d), new NpgsqlTypes.NpgsqlPoint(x: 0.6208291584268393d, y: 0.09091848154516691d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30148186489428497d, y: 0.032047803732533464d), new NpgsqlTypes.NpgsqlPoint(x: 0.9381019813437208d, y: 0.13015624959896988d), new NpgsqlTypes.NpgsqlPoint(x: 0.17295322466226193d, y: 0.17187207662065085d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.534009543938477d, y: 0.6468839012829164d), new NpgsqlTypes.NpgsqlPoint(x: 0.6899112807238069d, y: 0.21940132382758737d), new NpgsqlTypes.NpgsqlPoint(x: 0.5639757060826867d, y: 0.4707308439553455d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16785073574617326d, y: 0.6717662792645323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9729841405291034d, y: 0.6986232053264695d), new NpgsqlTypes.NpgsqlPoint(x: 0.1814291295425705d, y: 0.4903770446327559d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7352326292441074d, y: 0.500093835231234d), new NpgsqlTypes.NpgsqlPoint(x: 0.2964843579226599d, y: 0.5476871410608937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8097409533926744d, y: 0.1930127015960259d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6668332943578741d, y: 0.43932168272934236d), new NpgsqlTypes.NpgsqlPoint(x: 0.01967969181574536d, y: 0.5343104960410131d), new NpgsqlTypes.NpgsqlPoint(x: 0.49539453237853415d, y: 0.7227649232199035d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05272222202944454d, y: 0.1755299457513354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9869049470596468d, y: 0.2392563738411866d), new NpgsqlTypes.NpgsqlPoint(x: 0.7200835089842724d, y: 0.8819471720962225d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4357391500528399d, y: 0.6449852212636422d), new NpgsqlTypes.NpgsqlPoint(x: 0.10035382059071019d, y: 0.7021188262907486d), new NpgsqlTypes.NpgsqlPoint(x: 0.5776340673514553d, y: 0.5749270169998064d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7429641580685679d, y: 0.42537925138622434d), new NpgsqlTypes.NpgsqlPoint(x: 0.8899713286214831d, y: 0.9070920731741218d), new NpgsqlTypes.NpgsqlPoint(x: 0.307822471166061d, y: 0.9717978621582447d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7803253383757571d, y: 0.2549157896693901d), new NpgsqlTypes.NpgsqlPoint(x: 0.647209701828643d, y: 0.992313293340223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1354222064116083d, y: 0.09322036873631301d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07167901813405853d, y: 0.33831455502546703d), new NpgsqlTypes.NpgsqlPoint(x: 0.3381139575649016d, y: 0.15908660969559996d), new NpgsqlTypes.NpgsqlPoint(x: 0.5233879146200945d, y: 0.677470372612471d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3848069573120456d, y: 0.09891740712653341d), new NpgsqlTypes.NpgsqlPoint(x: 0.5071130875734908d, y: 0.08366688563961311d), new NpgsqlTypes.NpgsqlPoint(x: 0.2875312304731027d, y: 0.18088356505346237d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42666842693433804d, y: 0.9649755455951494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9086175944856957d, y: 0.2717899069167925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7841525366399726d, y: 0.5188473323451616d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8675035567111735d, y: 0.1188161394322288d), new NpgsqlTypes.NpgsqlPoint(x: 0.7045012060081598d, y: 0.4349656983916347d), new NpgsqlTypes.NpgsqlPoint(x: 0.6024159325198208d, y: 0.868091210514566d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6672663743976821d, y: 0.8072023968907501d), new NpgsqlTypes.NpgsqlPoint(x: 0.43051853834093456d, y: 0.6555492084177591d), new NpgsqlTypes.NpgsqlPoint(x: 0.30299768385282844d, y: 0.4077414162908627d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4584566803409277d, y: 0.1447951157175964d), new NpgsqlTypes.NpgsqlPoint(x: 0.303895903530064d, y: 0.5019816146288235d), new NpgsqlTypes.NpgsqlPoint(x: 0.8733080959539473d, y: 0.33686419096904896d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7188271068117525d, y: 0.49996565763412804d), new NpgsqlTypes.NpgsqlPoint(x: 0.038813905327098386d, y: 0.12554712893478737d), new NpgsqlTypes.NpgsqlPoint(x: 0.09399923576701807d, y: 0.10429694581031435d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02186132565282972d, y: 0.9068318390728991d), new NpgsqlTypes.NpgsqlPoint(x: 0.4836553632566447d, y: 0.29974395677883925d), new NpgsqlTypes.NpgsqlPoint(x: 0.20645876254810835d, y: 0.04894187960975038d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8536263672413774d, y: 0.9358580539628457d), new NpgsqlTypes.NpgsqlPoint(x: 0.39269912024093157d, y: 0.267720694766692d), new NpgsqlTypes.NpgsqlPoint(x: 0.407077477416369d, y: 0.7622327506261505d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20768478279330327d, y: 0.5390922634289806d), new NpgsqlTypes.NpgsqlPoint(x: 0.01823427844729375d, y: 0.966590659083081d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800546316023766d, y: 0.14578293941698894d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10943968001115523d, y: 0.8342806029198985d), new NpgsqlTypes.NpgsqlPoint(x: 0.16291225069432813d, y: 0.2942969538678176d), new NpgsqlTypes.NpgsqlPoint(x: 0.7079783328420358d, y: 0.7805341189909792d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1694139882568424d, y: 0.17393718312572404d), new NpgsqlTypes.NpgsqlPoint(x: 0.03504166908303652d, y: 0.7674571994484088d), new NpgsqlTypes.NpgsqlPoint(x: 0.49264771996424284d, y: 0.9901830247853408d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6112981820416143d, y: 0.6102136716725126d), new NpgsqlTypes.NpgsqlPoint(x: 0.9184566747986449d, y: 0.9772602381182574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9816401319361678d, y: 0.5034541552166523d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6191397435492442d, y: 0.48634237061033514d), new NpgsqlTypes.NpgsqlPoint(x: 0.2942400343285584d, y: 0.5359962965313175d), new NpgsqlTypes.NpgsqlPoint(x: 0.8468901523854022d, y: 0.4185625125524305d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8822588255986498d, y: 0.6680641091569156d), new NpgsqlTypes.NpgsqlPoint(x: 0.5070613786044067d, y: 0.05535876787291072d), new NpgsqlTypes.NpgsqlPoint(x: 0.7350778377563914d, y: 0.09376554792852343d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7572869644674451d, y: 0.9936500884212929d), new NpgsqlTypes.NpgsqlPoint(x: 0.5573985235545132d, y: 0.552662286106688d), new NpgsqlTypes.NpgsqlPoint(x: 0.6833597624905954d, y: 0.2684309667532587d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5335208119586289d, y: 0.15174533915021782d), new NpgsqlTypes.NpgsqlPoint(x: 0.921021048680803d, y: 0.9161037707230683d), new NpgsqlTypes.NpgsqlPoint(x: 0.33727761194845485d, y: 0.3762536091192018d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4226752259695097d, y: 0.21203396604805425d), new NpgsqlTypes.NpgsqlPoint(x: 0.4468731192917511d, y: 0.5832741817307727d), new NpgsqlTypes.NpgsqlPoint(x: 0.3393219605033798d, y: 0.46544898299089d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9772675272810236d, y: 0.9624168183973706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9206413484058d, y: 0.15889579405989318d), new NpgsqlTypes.NpgsqlPoint(x: 0.4876015653224609d, y: 0.0030185889122233966d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42550220995018795d, y: 0.2822982749631271d), new NpgsqlTypes.NpgsqlPoint(x: 0.01293804546413213d, y: 0.4009888507131931d), new NpgsqlTypes.NpgsqlPoint(x: 0.019404159641043806d, y: 0.9695334048745549d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5194213841445267d, y: 0.8323041542845742d), new NpgsqlTypes.NpgsqlPoint(x: 0.676740705476385d, y: 0.9188601102656182d), new NpgsqlTypes.NpgsqlPoint(x: 0.310873056485962d, y: 0.5411675564006649d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6858657846183114d, y: 0.6481289325317382d), new NpgsqlTypes.NpgsqlPoint(x: 0.9600814296435758d, y: 0.2480819804893476d), new NpgsqlTypes.NpgsqlPoint(x: 0.12532558967610374d, y: 0.15773576886647012d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33424330741428077d, y: 0.35556506803686794d), new NpgsqlTypes.NpgsqlPoint(x: 0.14627005957641526d, y: 0.13728694580784406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9811912874923905d, y: 0.19095474678628144d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5668771486754646d, y: 0.6424950073735215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7829753075317875d, y: 0.6929089984598454d), new NpgsqlTypes.NpgsqlPoint(x: 0.43111803907039925d, y: 0.15858631871015316d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.067500619403559d, y: 0.9466267474757245d), new NpgsqlTypes.NpgsqlPoint(x: 0.7755481556891507d, y: 0.042527924904030345d), new NpgsqlTypes.NpgsqlPoint(x: 0.789714289499864d, y: 0.6054079601604824d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3896180381591777d, y: 0.11162334921461436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9018728077919472d, y: 0.35666762114954387d), new NpgsqlTypes.NpgsqlPoint(x: 0.1207046047871384d, y: 0.3154645608877993d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25667448837497087d, y: 0.529803950704426d), new NpgsqlTypes.NpgsqlPoint(x: 0.4399344774845847d, y: 0.34939356268853694d), new NpgsqlTypes.NpgsqlPoint(x: 0.7674652469912183d, y: 0.7657635565367913d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06843024280649801d, y: 0.46878863079414623d), new NpgsqlTypes.NpgsqlPoint(x: 0.3883115296291323d, y: 0.7380680252005823d), new NpgsqlTypes.NpgsqlPoint(x: 0.02047954207672842d, y: 0.960963051227404d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2659346257336086d, y: 0.27903520030003126d), new NpgsqlTypes.NpgsqlPoint(x: 0.12198762790857776d, y: 0.1590905583461758d), new NpgsqlTypes.NpgsqlPoint(x: 0.7095330264422001d, y: 0.12707122396408688d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9823090738410462d, y: 0.03148868207605893d), new NpgsqlTypes.NpgsqlPoint(x: 0.4983846927935687d, y: 0.98563652587397d), new NpgsqlTypes.NpgsqlPoint(x: 0.9792817695274909d, y: 0.6268007012526762d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12806941993687848d, y: 0.16440511983050454d), new NpgsqlTypes.NpgsqlPoint(x: 0.7933003441865432d, y: 0.34471828801357374d), new NpgsqlTypes.NpgsqlPoint(x: 0.3761253210960579d, y: 0.3301363454810037d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7451345647930243d, y: 0.3946737137219064d), new NpgsqlTypes.NpgsqlPoint(x: 0.17557276120631227d, y: 0.7545818837363205d), new NpgsqlTypes.NpgsqlPoint(x: 0.06230168905600031d, y: 0.7547322842757636d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5655570512164559d, y: 0.9030868170861257d), new NpgsqlTypes.NpgsqlPoint(x: 0.5536887251299947d, y: 0.21006776147471962d), new NpgsqlTypes.NpgsqlPoint(x: 0.13524565839506597d, y: 0.5516644037629186d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34033690769551317d, y: 0.5080413406043849d), new NpgsqlTypes.NpgsqlPoint(x: 0.43507680755140343d, y: 0.0744262290526938d), new NpgsqlTypes.NpgsqlPoint(x: 0.08124774213598696d, y: 0.8189020008636403d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12570425011858266d, y: 0.8867953432669724d), new NpgsqlTypes.NpgsqlPoint(x: 0.37950713402862013d, y: 0.8444105152093606d), new NpgsqlTypes.NpgsqlPoint(x: 0.9369336138609575d, y: 0.45305524712930123d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.839601904543672d, y: 0.07553531151800796d), new NpgsqlTypes.NpgsqlPoint(x: 0.508818215138659d, y: 0.9103650435986606d), new NpgsqlTypes.NpgsqlPoint(x: 0.8700588762006746d, y: 0.6128226632048303d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3534242449848559d, y: 0.9824193431185682d), new NpgsqlTypes.NpgsqlPoint(x: 0.0328166180306938d, y: 0.21470347423204794d), new NpgsqlTypes.NpgsqlPoint(x: 0.3119826698745243d, y: 0.2901358556021426d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4484679256704054d, y: 0.4903016248979952d), new NpgsqlTypes.NpgsqlPoint(x: 0.6848314626597951d, y: 0.2812563470484849d), new NpgsqlTypes.NpgsqlPoint(x: 0.1189175374429714d, y: 0.7875640427486299d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4272802381908918d, y: 0.10983130728183155d), new NpgsqlTypes.NpgsqlPoint(x: 0.14686738083224193d, y: 0.5957091070813653d), new NpgsqlTypes.NpgsqlPoint(x: 0.07484219781922385d, y: 0.6608036305564104d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5971254737538826d, y: 0.09154216042957242d), new NpgsqlTypes.NpgsqlPoint(x: 0.9536604225739643d, y: 0.8076380096972067d), new NpgsqlTypes.NpgsqlPoint(x: 0.7524322094404163d, y: 0.9460977240304279d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.882991001354024d, y: 0.2686716335284225d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612686598647034d, y: 0.8403930208971868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4223150840431127d, y: 0.426444456377146d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38419340991052364d, y: 0.32563352932137624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8449025810373131d, y: 0.9889475584606118d), new NpgsqlTypes.NpgsqlPoint(x: 0.7460560150374108d, y: 0.48588590362112827d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16595655285159527d, y: 0.5339313040812964d), new NpgsqlTypes.NpgsqlPoint(x: 0.25897764671631696d, y: 0.775580243404434d), new NpgsqlTypes.NpgsqlPoint(x: 0.7353657721999577d, y: 0.34935187765527265d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5552525118569708d, y: 0.945908724129584d), new NpgsqlTypes.NpgsqlPoint(x: 0.06638590973253855d, y: 0.9134706212088841d), new NpgsqlTypes.NpgsqlPoint(x: 0.006623101020014399d, y: 0.5199553266986212d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6560403844329478d, y: 0.6272957678674835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5440579875349417d, y: 0.8950857637169107d), new NpgsqlTypes.NpgsqlPoint(x: 0.2865163632400819d, y: 0.7207998979925707d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9363774186562193d, y: 0.6022853673396199d), new NpgsqlTypes.NpgsqlPoint(x: 0.07179993008920427d, y: 0.9786713925466807d), new NpgsqlTypes.NpgsqlPoint(x: 0.06231508806916286d, y: 0.5376474616973936d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7767587015680294d, y: 0.42871986501107007d), new NpgsqlTypes.NpgsqlPoint(x: 0.8073496433560913d, y: 0.1743334639058024d), new NpgsqlTypes.NpgsqlPoint(x: 0.5495714638803152d, y: 0.64757270720489d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13707522121835336d, y: 0.9647300577593989d), new NpgsqlTypes.NpgsqlPoint(x: 0.9719403233491255d, y: 0.626403291990871d), new NpgsqlTypes.NpgsqlPoint(x: 0.269934775946856d, y: 0.7087316931458022d)))));

            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0M>(15);

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
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

