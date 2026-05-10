

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
    internal partial interface INpgsqlPathSingleTypepath
    {
    }
    
    internal partial class NpgsqlPathSingleTypepath : INpgsqlPathSingleTypepath
    {


#region TestData

        private readonly NpgsqlPathpath0M[] _testData = new NpgsqlPathpath0M[]
        {
            new NpgsqlPathpath0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1384995200950282d, y: 0.5252533379055196d), new NpgsqlTypes.NpgsqlPoint(x: 0.4598215542579537d, y: 0.9644666177891673d), new NpgsqlTypes.NpgsqlPoint(x: 0.29519547835075177d, y: 0.05924478896337926d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8479615231470851d, y: 0.6291298478361824d), new NpgsqlTypes.NpgsqlPoint(x: 0.9468266653414035d, y: 0.057772955036834106d), new NpgsqlTypes.NpgsqlPoint(x: 0.9754945590606792d, y: 0.18096804385360243d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7350290410565198d, y: 0.8845762881467716d), new NpgsqlTypes.NpgsqlPoint(x: 0.9974374038754376d, y: 0.878373030274475d), new NpgsqlTypes.NpgsqlPoint(x: 0.17321265609241365d, y: 0.11157401299159464d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5535473154609128d, y: 0.10644811647736874d), new NpgsqlTypes.NpgsqlPoint(x: 0.2924448588377757d, y: 0.9881136664319986d), new NpgsqlTypes.NpgsqlPoint(x: 0.6249133223559027d, y: 0.49219952934084577d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49904417889770336d, y: 0.22603153458078062d), new NpgsqlTypes.NpgsqlPoint(x: 0.10460664689620536d, y: 0.8308326712543438d), new NpgsqlTypes.NpgsqlPoint(x: 0.6565113034872251d, y: 0.9285452131509678d)),
},
            new NpgsqlPathpath0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6166624611062593d, y: 0.7558641294194999d), new NpgsqlTypes.NpgsqlPoint(x: 0.2777452181393597d, y: 0.5411768046371075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4009345547973333d, y: 0.5105585716437389d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2912815894861568d, y: 0.04127801401293274d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905101115616456d, y: 0.6684754226483735d), new NpgsqlTypes.NpgsqlPoint(x: 0.7972867108437637d, y: 0.8707846202519783d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46123434251353235d, y: 0.6332655453547779d), new NpgsqlTypes.NpgsqlPoint(x: 0.6185178349746986d, y: 0.12663004732798744d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600704300229283d, y: 0.33997072720299526d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4899247431504943d, y: 0.8295876752134748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9253311551455016d, y: 0.8021428796536737d), new NpgsqlTypes.NpgsqlPoint(x: 0.12459981571812795d, y: 0.4302704409433745d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5667246470158483d, y: 0.2467564061603741d), new NpgsqlTypes.NpgsqlPoint(x: 0.7432868385573548d, y: 0.8170682685632404d), new NpgsqlTypes.NpgsqlPoint(x: 0.49890184418240646d, y: 0.7076580643643393d)),
},
            new NpgsqlPathpath0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9624502600765864d, y: 0.6765442118623345d), new NpgsqlTypes.NpgsqlPoint(x: 0.12612097354617513d, y: 0.9770251536817579d), new NpgsqlTypes.NpgsqlPoint(x: 0.35662893444696864d, y: 0.15369183807400544d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4382015015305337d, y: 0.7420027161101488d), new NpgsqlTypes.NpgsqlPoint(x: 0.8508575321005708d, y: 0.19990427574172231d), new NpgsqlTypes.NpgsqlPoint(x: 0.1467309439164619d, y: 0.35019513715791306d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8726033416838378d, y: 0.32085157596510516d), new NpgsqlTypes.NpgsqlPoint(x: 0.2570322867755165d, y: 0.10662273625471697d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036198147350299d, y: 0.4467080698830166d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3376467312111995d, y: 0.7581410863782065d), new NpgsqlTypes.NpgsqlPoint(x: 0.9322085459891242d, y: 0.914296067687913d), new NpgsqlTypes.NpgsqlPoint(x: 0.3011485825490494d, y: 0.1702840806558219d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36627870482679914d, y: 0.34492492475932246d), new NpgsqlTypes.NpgsqlPoint(x: 0.318554210930728d, y: 0.9698938423751585d), new NpgsqlTypes.NpgsqlPoint(x: 0.6257947100384058d, y: 0.21363134934618533d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39136314316120735d, y: 0.7949694810955394d), new NpgsqlTypes.NpgsqlPoint(x: 0.8850411502043067d, y: 0.5461824659231653d), new NpgsqlTypes.NpgsqlPoint(x: 0.3455256320827903d, y: 0.5034586282454978d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9476397615573684d, y: 0.7214005264697351d), new NpgsqlTypes.NpgsqlPoint(x: 0.23356794245348933d, y: 0.679318900454175d), new NpgsqlTypes.NpgsqlPoint(x: 0.49682767210403567d, y: 0.12468898768015013d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3377235477876638d, y: 0.837355889707616d), new NpgsqlTypes.NpgsqlPoint(x: 0.20308756710892795d, y: 0.8859168985337266d), new NpgsqlTypes.NpgsqlPoint(x: 0.963609578337132d, y: 0.6976466745747086d)),
},
            new NpgsqlPathpath0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4349991072510673d, y: 0.7057411139098452d), new NpgsqlTypes.NpgsqlPoint(x: 0.6947949644774595d, y: 0.3660481734764873d), new NpgsqlTypes.NpgsqlPoint(x: 0.9792047262005656d, y: 0.8584137928217198d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5527440142572652d, y: 0.5166302794186026d), new NpgsqlTypes.NpgsqlPoint(x: 0.16953649373242752d, y: 0.39127914971039024d), new NpgsqlTypes.NpgsqlPoint(x: 0.8915087023038695d, y: 0.0350177760243805d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9382764585185911d, y: 0.7732457362328554d), new NpgsqlTypes.NpgsqlPoint(x: 0.1960427362182151d, y: 0.7151285338466137d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124652494436873d, y: 0.9716027019186939d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9506249431343747d, y: 0.5600654544542147d), new NpgsqlTypes.NpgsqlPoint(x: 0.8992463466465683d, y: 0.639774642080477d), new NpgsqlTypes.NpgsqlPoint(x: 0.31166542519445684d, y: 0.2900245609001785d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3252956867843597d, y: 0.08179046049316763d), new NpgsqlTypes.NpgsqlPoint(x: 0.3233747521432163d, y: 0.5363629772512772d), new NpgsqlTypes.NpgsqlPoint(x: 0.795084856218932d, y: 0.09591704394232037d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15910695085826954d, y: 0.4189374571669323d), new NpgsqlTypes.NpgsqlPoint(x: 0.15081147085593993d, y: 0.9582963610415034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8460955247873118d, y: 0.5172273360644092d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9359096991729784d, y: 0.4965000189239075d), new NpgsqlTypes.NpgsqlPoint(x: 0.14890064779581946d, y: 0.8277048180797949d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747335083295574d, y: 0.30974193577958753d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0782284740547795d, y: 0.37982624142610855d), new NpgsqlTypes.NpgsqlPoint(x: 0.889332860130029d, y: 0.34656317870977116d), new NpgsqlTypes.NpgsqlPoint(x: 0.5002532207413608d, y: 0.5828767148651792d)),
},
            new NpgsqlPathpath0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5164766793174392d, y: 0.5213613991353119d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116253611164276d, y: 0.8810551162797668d), new NpgsqlTypes.NpgsqlPoint(x: 0.3085016959853629d, y: 0.9475439972255362d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3489619944948096d, y: 0.5834148618488152d), new NpgsqlTypes.NpgsqlPoint(x: 0.19775589913090508d, y: 0.4187730393954008d), new NpgsqlTypes.NpgsqlPoint(x: 0.23088800588239944d, y: 0.47513195840967526d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22088885813037307d, y: 0.9557961621608739d), new NpgsqlTypes.NpgsqlPoint(x: 0.6644332464781146d, y: 0.8347476688119715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5184038731986863d, y: 0.8575890139896246d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05165476746733644d, y: 0.028655926595719028d), new NpgsqlTypes.NpgsqlPoint(x: 0.03457433774631535d, y: 0.16075453826609298d), new NpgsqlTypes.NpgsqlPoint(x: 0.16991737171068133d, y: 0.04425811255442058d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7112320490808934d, y: 0.8963846842561312d), new NpgsqlTypes.NpgsqlPoint(x: 0.16793568556378013d, y: 0.041735591082717516d), new NpgsqlTypes.NpgsqlPoint(x: 0.08134462165841816d, y: 0.9254888084643703d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23214065629942549d, y: 0.19812632988609113d), new NpgsqlTypes.NpgsqlPoint(x: 0.25220842760407824d, y: 0.8297523471143128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455563588499515d, y: 0.07974179283497451d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6727025942154948d, y: 0.8623893025676641d), new NpgsqlTypes.NpgsqlPoint(x: 0.3414261021931343d, y: 0.634175047288639d), new NpgsqlTypes.NpgsqlPoint(x: 0.9015523436268948d, y: 0.5537605125483938d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9418341143972704d, y: 0.3119069291046428d), new NpgsqlTypes.NpgsqlPoint(x: 0.8464853780125533d, y: 0.5124083486402952d), new NpgsqlTypes.NpgsqlPoint(x: 0.25185500776953107d, y: 0.9487642006071406d)),
},
            new NpgsqlPathpath0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.674152549635956d, y: 0.7296848325323522d), new NpgsqlTypes.NpgsqlPoint(x: 0.6794379786432687d, y: 0.8564446829520764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8710596770834754d, y: 0.9216556656896965d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5331066141208703d, y: 0.5353960525904325d), new NpgsqlTypes.NpgsqlPoint(x: 0.4345936810587916d, y: 0.9184329812657642d), new NpgsqlTypes.NpgsqlPoint(x: 0.10222037186275246d, y: 0.18548399806159777d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06879248285341821d, y: 0.6819436351595272d), new NpgsqlTypes.NpgsqlPoint(x: 0.8968301291113417d, y: 0.6895460709150619d), new NpgsqlTypes.NpgsqlPoint(x: 0.6738449447534851d, y: 0.9821848845742497d)),
},
            new NpgsqlPathpath0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.052793863351644155d, y: 0.6509834942319761d), new NpgsqlTypes.NpgsqlPoint(x: 0.27943152512601555d, y: 0.3703164835205629d), new NpgsqlTypes.NpgsqlPoint(x: 0.4944084577506883d, y: 0.8922033967493999d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9419341499747026d, y: 0.43852691969868585d), new NpgsqlTypes.NpgsqlPoint(x: 0.9829000629185255d, y: 0.1459247420068489d), new NpgsqlTypes.NpgsqlPoint(x: 0.5295454919525352d, y: 0.32523308198096346d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22666122060687344d, y: 0.8605084040550666d), new NpgsqlTypes.NpgsqlPoint(x: 0.3067864598944934d, y: 0.38114284076564353d), new NpgsqlTypes.NpgsqlPoint(x: 0.44922910867449406d, y: 0.37025263186234203d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4061737950231603d, y: 0.3370229453081264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9269249494023103d, y: 0.655667560231936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5260244834480033d, y: 0.7877335537321054d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4608317394073129d, y: 0.8995434104277462d), new NpgsqlTypes.NpgsqlPoint(x: 0.5116020467924388d, y: 0.21255552480470175d), new NpgsqlTypes.NpgsqlPoint(x: 0.6521838242514353d, y: 0.16803139792545319d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9956698964991504d, y: 0.8267420061952422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927529371173205d, y: 0.520205558419824d), new NpgsqlTypes.NpgsqlPoint(x: 0.15763528225337797d, y: 0.023532543721785038d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07964271663049871d, y: 0.21625466426155304d), new NpgsqlTypes.NpgsqlPoint(x: 0.02826531062442117d, y: 0.6239871315391012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010611411991968d, y: 0.06086917251947366d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3360659778030959d, y: 0.13050440598198876d), new NpgsqlTypes.NpgsqlPoint(x: 0.7760754237397676d, y: 0.2952763583901977d), new NpgsqlTypes.NpgsqlPoint(x: 0.9516022370299011d, y: 0.7924994566507133d)),
},
            new NpgsqlPathpath0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.009205243088441284d, y: 0.7619941425110427d), new NpgsqlTypes.NpgsqlPoint(x: 0.8388293573247092d, y: 0.5726032608478397d), new NpgsqlTypes.NpgsqlPoint(x: 0.3934942912284578d, y: 0.7865988759990384d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7593649334614679d, y: 0.06745130541800104d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234055764785916d, y: 0.8021885237950619d), new NpgsqlTypes.NpgsqlPoint(x: 0.9574819770663681d, y: 0.42560006104171266d)),
},
            new NpgsqlPathpath0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7339940859199082d, y: 0.21205342034697472d), new NpgsqlTypes.NpgsqlPoint(x: 0.5528514721979946d, y: 0.015635846325114833d), new NpgsqlTypes.NpgsqlPoint(x: 0.4466957903160135d, y: 0.8547227865027591d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8609008106347593d, y: 0.43488559687149486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4113178995848519d, y: 0.5349597101934777d), new NpgsqlTypes.NpgsqlPoint(x: 0.5535469547166451d, y: 0.4018268544897273d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7194188707441711d, y: 0.4639265092515741d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481906812570419d, y: 0.9802595125199505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213005166554235d, y: 0.24889448838216055d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31846270050372905d, y: 0.7466958668534716d), new NpgsqlTypes.NpgsqlPoint(x: 0.40002593775108863d, y: 0.23919117393252387d), new NpgsqlTypes.NpgsqlPoint(x: 0.7210444638299245d, y: 0.439970365671721d)),
},
            new NpgsqlPathpath0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30472554422756915d, y: 0.9318508720002607d), new NpgsqlTypes.NpgsqlPoint(x: 0.8899995683026247d, y: 0.34024482404791734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7342672444983434d, y: 0.06222734275834463d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5570504737075197d, y: 0.16458486569432873d), new NpgsqlTypes.NpgsqlPoint(x: 0.24358478675208062d, y: 0.45623765249170345d), new NpgsqlTypes.NpgsqlPoint(x: 0.8366680153066103d, y: 0.3286874832522447d)),
},
            new NpgsqlPathpath0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47178714646140507d, y: 0.738065011288784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5668246510535818d, y: 0.4582741699557924d), new NpgsqlTypes.NpgsqlPoint(x: 0.8259033130500462d, y: 0.14015743213703302d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9797639784608396d, y: 0.7919012339607749d), new NpgsqlTypes.NpgsqlPoint(x: 0.3496504210316209d, y: 0.8062897539163459d), new NpgsqlTypes.NpgsqlPoint(x: 0.11168826780388386d, y: 0.4435177749787017d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6745571974730579d, y: 0.6691712773011513d), new NpgsqlTypes.NpgsqlPoint(x: 0.8278564980468751d, y: 0.34376711436110674d), new NpgsqlTypes.NpgsqlPoint(x: 0.7408662940538073d, y: 0.9494049965083525d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11133071228130131d, y: 0.16691008786259143d), new NpgsqlTypes.NpgsqlPoint(x: 0.32156950818260377d, y: 0.9057176804282426d), new NpgsqlTypes.NpgsqlPoint(x: 0.3598597472846653d, y: 0.3472768162038743d)),
},
            new NpgsqlPathpath0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012416520411553833d, y: 0.008710360586396515d), new NpgsqlTypes.NpgsqlPoint(x: 0.9995025636683124d, y: 0.0716295417409003d), new NpgsqlTypes.NpgsqlPoint(x: 0.023714282957931654d, y: 0.8908448945063003d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5213377353989377d, y: 0.9691687783146103d), new NpgsqlTypes.NpgsqlPoint(x: 0.6679946804292065d, y: 0.3106934308649578d), new NpgsqlTypes.NpgsqlPoint(x: 0.12844839749893322d, y: 0.7054191840624274d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13412314637753509d, y: 0.6113287205828896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7046191111392793d, y: 0.9023049297197723d), new NpgsqlTypes.NpgsqlPoint(x: 0.8487342595535583d, y: 0.6199822451010455d)),
},
            new NpgsqlPathpath0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3569338186119879d, y: 0.36803058588640336d), new NpgsqlTypes.NpgsqlPoint(x: 0.17452068203579874d, y: 0.7270472986577301d), new NpgsqlTypes.NpgsqlPoint(x: 0.24208127436364346d, y: 0.06690940760336583d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07205563321140318d, y: 0.37079057906148105d), new NpgsqlTypes.NpgsqlPoint(x: 0.29525409826709614d, y: 0.5391395586407982d), new NpgsqlTypes.NpgsqlPoint(x: 0.4299413683643296d, y: 0.33785942426410653d)),
},
            new NpgsqlPathpath0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13638636790930492d, y: 0.6990521699070708d), new NpgsqlTypes.NpgsqlPoint(x: 0.8373341215015491d, y: 0.872204615331761d), new NpgsqlTypes.NpgsqlPoint(x: 0.41017085124020125d, y: 0.9658504510981286d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6629937204305132d, y: 0.99551910681736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6674168613598188d, y: 0.4978964258334777d), new NpgsqlTypes.NpgsqlPoint(x: 0.4501586182412398d, y: 0.24921439352180785d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2850136624616719d, y: 0.29914370247220834d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621682531807783d, y: 0.729529484907072d), new NpgsqlTypes.NpgsqlPoint(x: 0.0571904984581344d, y: 0.10351827380758805d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31730065613792247d, y: 0.6451884082836582d), new NpgsqlTypes.NpgsqlPoint(x: 0.8430231261912171d, y: 0.9011527225999498d), new NpgsqlTypes.NpgsqlPoint(x: 0.14434058439472253d, y: 0.5577225473954898d)),
},
            new NpgsqlPathpath0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6905292479369856d, y: 0.4509364644760697d), new NpgsqlTypes.NpgsqlPoint(x: 0.7838482434322487d, y: 0.4876624255112253d), new NpgsqlTypes.NpgsqlPoint(x: 0.10086137255347893d, y: 0.2767241949039999d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5930120164903414d, y: 0.07567181356174046d), new NpgsqlTypes.NpgsqlPoint(x: 0.8347904300829705d, y: 0.9388990202866088d), new NpgsqlTypes.NpgsqlPoint(x: 0.806455226307867d, y: 0.7423401734002334d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8802616763503964d, y: 0.543861546788293d), new NpgsqlTypes.NpgsqlPoint(x: 0.5797061244763986d, y: 0.8776199357267158d), new NpgsqlTypes.NpgsqlPoint(x: 0.5807487497039383d, y: 0.4633047055826611d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8997098038224279d, y: 0.7291748218831778d), new NpgsqlTypes.NpgsqlPoint(x: 0.706876762327436d, y: 0.6303660582047204d), new NpgsqlTypes.NpgsqlPoint(x: 0.4203088836148756d, y: 0.2063048500849597d)),
},
            new NpgsqlPathpath0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07611599600234897d, y: 0.5398505635886515d), new NpgsqlTypes.NpgsqlPoint(x: 0.03570926958221876d, y: 0.7311505035126676d), new NpgsqlTypes.NpgsqlPoint(x: 0.12123471750290327d, y: 0.4199804765472722d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 169,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7907206596051018d, y: 0.36194169130351905d), new NpgsqlTypes.NpgsqlPoint(x: 0.7911846208411916d, y: 0.9518022207133512d), new NpgsqlTypes.NpgsqlPoint(x: 0.9529028038105093d, y: 0.6317256905056364d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3186978704422603d, y: 0.07991429793186677d), new NpgsqlTypes.NpgsqlPoint(x: 0.25755790659164446d, y: 0.3741086185241067d), new NpgsqlTypes.NpgsqlPoint(x: 0.43131615412048563d, y: 0.4784669976549757d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 174,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8774183618421599d, y: 0.5023730230555371d), new NpgsqlTypes.NpgsqlPoint(x: 0.1110603967093039d, y: 0.5766830467688002d), new NpgsqlTypes.NpgsqlPoint(x: 0.25402690709407405d, y: 0.5462944078693827d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8542510979240512d, y: 0.43669536972564327d), new NpgsqlTypes.NpgsqlPoint(x: 0.42049265977980277d, y: 0.1621531291327365d), new NpgsqlTypes.NpgsqlPoint(x: 0.11344169422426664d, y: 0.6960878210245561d)),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3377235477876638d, y: 0.837355889707616d), new NpgsqlTypes.NpgsqlPoint(x: 0.20308756710892795d, y: 0.8859168985337266d), new NpgsqlTypes.NpgsqlPoint(x: 0.963609578337132d, y: 0.6976466745747086d))));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpath0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPath), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpathpath0mi_id", 
                methodParametrName: "npgsqlpathpath0mi_id", 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 123;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 68;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 132;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 12, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 117, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 95, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 65, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 50, query1, 98, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 98, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 34, query1, 163, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 63, query1, 75, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 79, 79))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 132, 21))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[30],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[29], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[30], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[31], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[32], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[33], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 160);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[32], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[33], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1384995200950282d, y: 0.5252533379055196d), new NpgsqlTypes.NpgsqlPoint(x: 0.4598215542579537d, y: 0.9644666177891673d), new NpgsqlTypes.NpgsqlPoint(x: 0.29519547835075177d, y: 0.05924478896337926d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8479615231470851d, y: 0.6291298478361824d), new NpgsqlTypes.NpgsqlPoint(x: 0.9468266653414035d, y: 0.057772955036834106d), new NpgsqlTypes.NpgsqlPoint(x: 0.9754945590606792d, y: 0.18096804385360243d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7350290410565198d, y: 0.8845762881467716d), new NpgsqlTypes.NpgsqlPoint(x: 0.9974374038754376d, y: 0.878373030274475d), new NpgsqlTypes.NpgsqlPoint(x: 0.17321265609241365d, y: 0.11157401299159464d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5535473154609128d, y: 0.10644811647736874d), new NpgsqlTypes.NpgsqlPoint(x: 0.2924448588377757d, y: 0.9881136664319986d), new NpgsqlTypes.NpgsqlPoint(x: 0.6249133223559027d, y: 0.49219952934084577d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49904417889770336d, y: 0.22603153458078062d), new NpgsqlTypes.NpgsqlPoint(x: 0.10460664689620536d, y: 0.8308326712543438d), new NpgsqlTypes.NpgsqlPoint(x: 0.6565113034872251d, y: 0.9285452131509678d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6166624611062593d, y: 0.7558641294194999d), new NpgsqlTypes.NpgsqlPoint(x: 0.2777452181393597d, y: 0.5411768046371075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4009345547973333d, y: 0.5105585716437389d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2912815894861568d, y: 0.04127801401293274d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905101115616456d, y: 0.6684754226483735d), new NpgsqlTypes.NpgsqlPoint(x: 0.7972867108437637d, y: 0.8707846202519783d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46123434251353235d, y: 0.6332655453547779d), new NpgsqlTypes.NpgsqlPoint(x: 0.6185178349746986d, y: 0.12663004732798744d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600704300229283d, y: 0.33997072720299526d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4899247431504943d, y: 0.8295876752134748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9253311551455016d, y: 0.8021428796536737d), new NpgsqlTypes.NpgsqlPoint(x: 0.12459981571812795d, y: 0.4302704409433745d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5667246470158483d, y: 0.2467564061603741d), new NpgsqlTypes.NpgsqlPoint(x: 0.7432868385573548d, y: 0.8170682685632404d), new NpgsqlTypes.NpgsqlPoint(x: 0.49890184418240646d, y: 0.7076580643643393d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9624502600765864d, y: 0.6765442118623345d), new NpgsqlTypes.NpgsqlPoint(x: 0.12612097354617513d, y: 0.9770251536817579d), new NpgsqlTypes.NpgsqlPoint(x: 0.35662893444696864d, y: 0.15369183807400544d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4382015015305337d, y: 0.7420027161101488d), new NpgsqlTypes.NpgsqlPoint(x: 0.8508575321005708d, y: 0.19990427574172231d), new NpgsqlTypes.NpgsqlPoint(x: 0.1467309439164619d, y: 0.35019513715791306d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8726033416838378d, y: 0.32085157596510516d), new NpgsqlTypes.NpgsqlPoint(x: 0.2570322867755165d, y: 0.10662273625471697d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036198147350299d, y: 0.4467080698830166d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3376467312111995d, y: 0.7581410863782065d), new NpgsqlTypes.NpgsqlPoint(x: 0.9322085459891242d, y: 0.914296067687913d), new NpgsqlTypes.NpgsqlPoint(x: 0.3011485825490494d, y: 0.1702840806558219d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36627870482679914d, y: 0.34492492475932246d), new NpgsqlTypes.NpgsqlPoint(x: 0.318554210930728d, y: 0.9698938423751585d), new NpgsqlTypes.NpgsqlPoint(x: 0.6257947100384058d, y: 0.21363134934618533d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39136314316120735d, y: 0.7949694810955394d), new NpgsqlTypes.NpgsqlPoint(x: 0.8850411502043067d, y: 0.5461824659231653d), new NpgsqlTypes.NpgsqlPoint(x: 0.3455256320827903d, y: 0.5034586282454978d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9476397615573684d, y: 0.7214005264697351d), new NpgsqlTypes.NpgsqlPoint(x: 0.23356794245348933d, y: 0.679318900454175d), new NpgsqlTypes.NpgsqlPoint(x: 0.49682767210403567d, y: 0.12468898768015013d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3377235477876638d, y: 0.837355889707616d), new NpgsqlTypes.NpgsqlPoint(x: 0.20308756710892795d, y: 0.8859168985337266d), new NpgsqlTypes.NpgsqlPoint(x: 0.963609578337132d, y: 0.6976466745747086d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4349991072510673d, y: 0.7057411139098452d), new NpgsqlTypes.NpgsqlPoint(x: 0.6947949644774595d, y: 0.3660481734764873d), new NpgsqlTypes.NpgsqlPoint(x: 0.9792047262005656d, y: 0.8584137928217198d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5527440142572652d, y: 0.5166302794186026d), new NpgsqlTypes.NpgsqlPoint(x: 0.16953649373242752d, y: 0.39127914971039024d), new NpgsqlTypes.NpgsqlPoint(x: 0.8915087023038695d, y: 0.0350177760243805d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9382764585185911d, y: 0.7732457362328554d), new NpgsqlTypes.NpgsqlPoint(x: 0.1960427362182151d, y: 0.7151285338466137d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124652494436873d, y: 0.9716027019186939d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9506249431343747d, y: 0.5600654544542147d), new NpgsqlTypes.NpgsqlPoint(x: 0.8992463466465683d, y: 0.639774642080477d), new NpgsqlTypes.NpgsqlPoint(x: 0.31166542519445684d, y: 0.2900245609001785d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3252956867843597d, y: 0.08179046049316763d), new NpgsqlTypes.NpgsqlPoint(x: 0.3233747521432163d, y: 0.5363629772512772d), new NpgsqlTypes.NpgsqlPoint(x: 0.795084856218932d, y: 0.09591704394232037d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15910695085826954d, y: 0.4189374571669323d), new NpgsqlTypes.NpgsqlPoint(x: 0.15081147085593993d, y: 0.9582963610415034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8460955247873118d, y: 0.5172273360644092d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9359096991729784d, y: 0.4965000189239075d), new NpgsqlTypes.NpgsqlPoint(x: 0.14890064779581946d, y: 0.8277048180797949d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747335083295574d, y: 0.30974193577958753d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0782284740547795d, y: 0.37982624142610855d), new NpgsqlTypes.NpgsqlPoint(x: 0.889332860130029d, y: 0.34656317870977116d), new NpgsqlTypes.NpgsqlPoint(x: 0.5002532207413608d, y: 0.5828767148651792d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5164766793174392d, y: 0.5213613991353119d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116253611164276d, y: 0.8810551162797668d), new NpgsqlTypes.NpgsqlPoint(x: 0.3085016959853629d, y: 0.9475439972255362d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3489619944948096d, y: 0.5834148618488152d), new NpgsqlTypes.NpgsqlPoint(x: 0.19775589913090508d, y: 0.4187730393954008d), new NpgsqlTypes.NpgsqlPoint(x: 0.23088800588239944d, y: 0.47513195840967526d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22088885813037307d, y: 0.9557961621608739d), new NpgsqlTypes.NpgsqlPoint(x: 0.6644332464781146d, y: 0.8347476688119715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5184038731986863d, y: 0.8575890139896246d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05165476746733644d, y: 0.028655926595719028d), new NpgsqlTypes.NpgsqlPoint(x: 0.03457433774631535d, y: 0.16075453826609298d), new NpgsqlTypes.NpgsqlPoint(x: 0.16991737171068133d, y: 0.04425811255442058d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7112320490808934d, y: 0.8963846842561312d), new NpgsqlTypes.NpgsqlPoint(x: 0.16793568556378013d, y: 0.041735591082717516d), new NpgsqlTypes.NpgsqlPoint(x: 0.08134462165841816d, y: 0.9254888084643703d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23214065629942549d, y: 0.19812632988609113d), new NpgsqlTypes.NpgsqlPoint(x: 0.25220842760407824d, y: 0.8297523471143128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455563588499515d, y: 0.07974179283497451d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6727025942154948d, y: 0.8623893025676641d), new NpgsqlTypes.NpgsqlPoint(x: 0.3414261021931343d, y: 0.634175047288639d), new NpgsqlTypes.NpgsqlPoint(x: 0.9015523436268948d, y: 0.5537605125483938d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9418341143972704d, y: 0.3119069291046428d), new NpgsqlTypes.NpgsqlPoint(x: 0.8464853780125533d, y: 0.5124083486402952d), new NpgsqlTypes.NpgsqlPoint(x: 0.25185500776953107d, y: 0.9487642006071406d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.674152549635956d, y: 0.7296848325323522d), new NpgsqlTypes.NpgsqlPoint(x: 0.6794379786432687d, y: 0.8564446829520764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8710596770834754d, y: 0.9216556656896965d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5331066141208703d, y: 0.5353960525904325d), new NpgsqlTypes.NpgsqlPoint(x: 0.4345936810587916d, y: 0.9184329812657642d), new NpgsqlTypes.NpgsqlPoint(x: 0.10222037186275246d, y: 0.18548399806159777d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06879248285341821d, y: 0.6819436351595272d), new NpgsqlTypes.NpgsqlPoint(x: 0.8968301291113417d, y: 0.6895460709150619d), new NpgsqlTypes.NpgsqlPoint(x: 0.6738449447534851d, y: 0.9821848845742497d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.052793863351644155d, y: 0.6509834942319761d), new NpgsqlTypes.NpgsqlPoint(x: 0.27943152512601555d, y: 0.3703164835205629d), new NpgsqlTypes.NpgsqlPoint(x: 0.4944084577506883d, y: 0.8922033967493999d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9419341499747026d, y: 0.43852691969868585d), new NpgsqlTypes.NpgsqlPoint(x: 0.9829000629185255d, y: 0.1459247420068489d), new NpgsqlTypes.NpgsqlPoint(x: 0.5295454919525352d, y: 0.32523308198096346d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22666122060687344d, y: 0.8605084040550666d), new NpgsqlTypes.NpgsqlPoint(x: 0.3067864598944934d, y: 0.38114284076564353d), new NpgsqlTypes.NpgsqlPoint(x: 0.44922910867449406d, y: 0.37025263186234203d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4061737950231603d, y: 0.3370229453081264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9269249494023103d, y: 0.655667560231936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5260244834480033d, y: 0.7877335537321054d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4608317394073129d, y: 0.8995434104277462d), new NpgsqlTypes.NpgsqlPoint(x: 0.5116020467924388d, y: 0.21255552480470175d), new NpgsqlTypes.NpgsqlPoint(x: 0.6521838242514353d, y: 0.16803139792545319d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9956698964991504d, y: 0.8267420061952422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927529371173205d, y: 0.520205558419824d), new NpgsqlTypes.NpgsqlPoint(x: 0.15763528225337797d, y: 0.023532543721785038d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07964271663049871d, y: 0.21625466426155304d), new NpgsqlTypes.NpgsqlPoint(x: 0.02826531062442117d, y: 0.6239871315391012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010611411991968d, y: 0.06086917251947366d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3360659778030959d, y: 0.13050440598198876d), new NpgsqlTypes.NpgsqlPoint(x: 0.7760754237397676d, y: 0.2952763583901977d), new NpgsqlTypes.NpgsqlPoint(x: 0.9516022370299011d, y: 0.7924994566507133d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.009205243088441284d, y: 0.7619941425110427d), new NpgsqlTypes.NpgsqlPoint(x: 0.8388293573247092d, y: 0.5726032608478397d), new NpgsqlTypes.NpgsqlPoint(x: 0.3934942912284578d, y: 0.7865988759990384d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7593649334614679d, y: 0.06745130541800104d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234055764785916d, y: 0.8021885237950619d), new NpgsqlTypes.NpgsqlPoint(x: 0.9574819770663681d, y: 0.42560006104171266d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7339940859199082d, y: 0.21205342034697472d), new NpgsqlTypes.NpgsqlPoint(x: 0.5528514721979946d, y: 0.015635846325114833d), new NpgsqlTypes.NpgsqlPoint(x: 0.4466957903160135d, y: 0.8547227865027591d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8609008106347593d, y: 0.43488559687149486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4113178995848519d, y: 0.5349597101934777d), new NpgsqlTypes.NpgsqlPoint(x: 0.5535469547166451d, y: 0.4018268544897273d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7194188707441711d, y: 0.4639265092515741d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481906812570419d, y: 0.9802595125199505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213005166554235d, y: 0.24889448838216055d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31846270050372905d, y: 0.7466958668534716d), new NpgsqlTypes.NpgsqlPoint(x: 0.40002593775108863d, y: 0.23919117393252387d), new NpgsqlTypes.NpgsqlPoint(x: 0.7210444638299245d, y: 0.439970365671721d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30472554422756915d, y: 0.9318508720002607d), new NpgsqlTypes.NpgsqlPoint(x: 0.8899995683026247d, y: 0.34024482404791734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7342672444983434d, y: 0.06222734275834463d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5570504737075197d, y: 0.16458486569432873d), new NpgsqlTypes.NpgsqlPoint(x: 0.24358478675208062d, y: 0.45623765249170345d), new NpgsqlTypes.NpgsqlPoint(x: 0.8366680153066103d, y: 0.3286874832522447d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47178714646140507d, y: 0.738065011288784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5668246510535818d, y: 0.4582741699557924d), new NpgsqlTypes.NpgsqlPoint(x: 0.8259033130500462d, y: 0.14015743213703302d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9797639784608396d, y: 0.7919012339607749d), new NpgsqlTypes.NpgsqlPoint(x: 0.3496504210316209d, y: 0.8062897539163459d), new NpgsqlTypes.NpgsqlPoint(x: 0.11168826780388386d, y: 0.4435177749787017d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6745571974730579d, y: 0.6691712773011513d), new NpgsqlTypes.NpgsqlPoint(x: 0.8278564980468751d, y: 0.34376711436110674d), new NpgsqlTypes.NpgsqlPoint(x: 0.7408662940538073d, y: 0.9494049965083525d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11133071228130131d, y: 0.16691008786259143d), new NpgsqlTypes.NpgsqlPoint(x: 0.32156950818260377d, y: 0.9057176804282426d), new NpgsqlTypes.NpgsqlPoint(x: 0.3598597472846653d, y: 0.3472768162038743d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012416520411553833d, y: 0.008710360586396515d), new NpgsqlTypes.NpgsqlPoint(x: 0.9995025636683124d, y: 0.0716295417409003d), new NpgsqlTypes.NpgsqlPoint(x: 0.023714282957931654d, y: 0.8908448945063003d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5213377353989377d, y: 0.9691687783146103d), new NpgsqlTypes.NpgsqlPoint(x: 0.6679946804292065d, y: 0.3106934308649578d), new NpgsqlTypes.NpgsqlPoint(x: 0.12844839749893322d, y: 0.7054191840624274d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13412314637753509d, y: 0.6113287205828896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7046191111392793d, y: 0.9023049297197723d), new NpgsqlTypes.NpgsqlPoint(x: 0.8487342595535583d, y: 0.6199822451010455d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3569338186119879d, y: 0.36803058588640336d), new NpgsqlTypes.NpgsqlPoint(x: 0.17452068203579874d, y: 0.7270472986577301d), new NpgsqlTypes.NpgsqlPoint(x: 0.24208127436364346d, y: 0.06690940760336583d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07205563321140318d, y: 0.37079057906148105d), new NpgsqlTypes.NpgsqlPoint(x: 0.29525409826709614d, y: 0.5391395586407982d), new NpgsqlTypes.NpgsqlPoint(x: 0.4299413683643296d, y: 0.33785942426410653d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13638636790930492d, y: 0.6990521699070708d), new NpgsqlTypes.NpgsqlPoint(x: 0.8373341215015491d, y: 0.872204615331761d), new NpgsqlTypes.NpgsqlPoint(x: 0.41017085124020125d, y: 0.9658504510981286d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6629937204305132d, y: 0.99551910681736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6674168613598188d, y: 0.4978964258334777d), new NpgsqlTypes.NpgsqlPoint(x: 0.4501586182412398d, y: 0.24921439352180785d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2850136624616719d, y: 0.29914370247220834d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621682531807783d, y: 0.729529484907072d), new NpgsqlTypes.NpgsqlPoint(x: 0.0571904984581344d, y: 0.10351827380758805d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31730065613792247d, y: 0.6451884082836582d), new NpgsqlTypes.NpgsqlPoint(x: 0.8430231261912171d, y: 0.9011527225999498d), new NpgsqlTypes.NpgsqlPoint(x: 0.14434058439472253d, y: 0.5577225473954898d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6905292479369856d, y: 0.4509364644760697d), new NpgsqlTypes.NpgsqlPoint(x: 0.7838482434322487d, y: 0.4876624255112253d), new NpgsqlTypes.NpgsqlPoint(x: 0.10086137255347893d, y: 0.2767241949039999d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5930120164903414d, y: 0.07567181356174046d), new NpgsqlTypes.NpgsqlPoint(x: 0.8347904300829705d, y: 0.9388990202866088d), new NpgsqlTypes.NpgsqlPoint(x: 0.806455226307867d, y: 0.7423401734002334d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8802616763503964d, y: 0.543861546788293d), new NpgsqlTypes.NpgsqlPoint(x: 0.5797061244763986d, y: 0.8776199357267158d), new NpgsqlTypes.NpgsqlPoint(x: 0.5807487497039383d, y: 0.4633047055826611d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8997098038224279d, y: 0.7291748218831778d), new NpgsqlTypes.NpgsqlPoint(x: 0.706876762327436d, y: 0.6303660582047204d), new NpgsqlTypes.NpgsqlPoint(x: 0.4203088836148756d, y: 0.2063048500849597d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07611599600234897d, y: 0.5398505635886515d), new NpgsqlTypes.NpgsqlPoint(x: 0.03570926958221876d, y: 0.7311505035126676d), new NpgsqlTypes.NpgsqlPoint(x: 0.12123471750290327d, y: 0.4199804765472722d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7907206596051018d, y: 0.36194169130351905d), new NpgsqlTypes.NpgsqlPoint(x: 0.7911846208411916d, y: 0.9518022207133512d), new NpgsqlTypes.NpgsqlPoint(x: 0.9529028038105093d, y: 0.6317256905056364d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3186978704422603d, y: 0.07991429793186677d), new NpgsqlTypes.NpgsqlPoint(x: 0.25755790659164446d, y: 0.3741086185241067d), new NpgsqlTypes.NpgsqlPoint(x: 0.43131615412048563d, y: 0.4784669976549757d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8774183618421599d, y: 0.5023730230555371d), new NpgsqlTypes.NpgsqlPoint(x: 0.1110603967093039d, y: 0.5766830467688002d), new NpgsqlTypes.NpgsqlPoint(x: 0.25402690709407405d, y: 0.5462944078693827d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8542510979240512d, y: 0.43669536972564327d), new NpgsqlTypes.NpgsqlPoint(x: 0.42049265977980277d, y: 0.1621531291327365d), new NpgsqlTypes.NpgsqlPoint(x: 0.11344169422426664d, y: 0.6960878210245561d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1384995200950282d, y: 0.5252533379055196d), new NpgsqlTypes.NpgsqlPoint(x: 0.4598215542579537d, y: 0.9644666177891673d), new NpgsqlTypes.NpgsqlPoint(x: 0.29519547835075177d, y: 0.05924478896337926d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8479615231470851d, y: 0.6291298478361824d), new NpgsqlTypes.NpgsqlPoint(x: 0.9468266653414035d, y: 0.057772955036834106d), new NpgsqlTypes.NpgsqlPoint(x: 0.9754945590606792d, y: 0.18096804385360243d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7350290410565198d, y: 0.8845762881467716d), new NpgsqlTypes.NpgsqlPoint(x: 0.9974374038754376d, y: 0.878373030274475d), new NpgsqlTypes.NpgsqlPoint(x: 0.17321265609241365d, y: 0.11157401299159464d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5535473154609128d, y: 0.10644811647736874d), new NpgsqlTypes.NpgsqlPoint(x: 0.2924448588377757d, y: 0.9881136664319986d), new NpgsqlTypes.NpgsqlPoint(x: 0.6249133223559027d, y: 0.49219952934084577d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49904417889770336d, y: 0.22603153458078062d), new NpgsqlTypes.NpgsqlPoint(x: 0.10460664689620536d, y: 0.8308326712543438d), new NpgsqlTypes.NpgsqlPoint(x: 0.6565113034872251d, y: 0.9285452131509678d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6166624611062593d, y: 0.7558641294194999d), new NpgsqlTypes.NpgsqlPoint(x: 0.2777452181393597d, y: 0.5411768046371075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4009345547973333d, y: 0.5105585716437389d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2912815894861568d, y: 0.04127801401293274d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905101115616456d, y: 0.6684754226483735d), new NpgsqlTypes.NpgsqlPoint(x: 0.7972867108437637d, y: 0.8707846202519783d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46123434251353235d, y: 0.6332655453547779d), new NpgsqlTypes.NpgsqlPoint(x: 0.6185178349746986d, y: 0.12663004732798744d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600704300229283d, y: 0.33997072720299526d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4899247431504943d, y: 0.8295876752134748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9253311551455016d, y: 0.8021428796536737d), new NpgsqlTypes.NpgsqlPoint(x: 0.12459981571812795d, y: 0.4302704409433745d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5667246470158483d, y: 0.2467564061603741d), new NpgsqlTypes.NpgsqlPoint(x: 0.7432868385573548d, y: 0.8170682685632404d), new NpgsqlTypes.NpgsqlPoint(x: 0.49890184418240646d, y: 0.7076580643643393d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9624502600765864d, y: 0.6765442118623345d), new NpgsqlTypes.NpgsqlPoint(x: 0.12612097354617513d, y: 0.9770251536817579d), new NpgsqlTypes.NpgsqlPoint(x: 0.35662893444696864d, y: 0.15369183807400544d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4382015015305337d, y: 0.7420027161101488d), new NpgsqlTypes.NpgsqlPoint(x: 0.8508575321005708d, y: 0.19990427574172231d), new NpgsqlTypes.NpgsqlPoint(x: 0.1467309439164619d, y: 0.35019513715791306d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8726033416838378d, y: 0.32085157596510516d), new NpgsqlTypes.NpgsqlPoint(x: 0.2570322867755165d, y: 0.10662273625471697d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036198147350299d, y: 0.4467080698830166d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3376467312111995d, y: 0.7581410863782065d), new NpgsqlTypes.NpgsqlPoint(x: 0.9322085459891242d, y: 0.914296067687913d), new NpgsqlTypes.NpgsqlPoint(x: 0.3011485825490494d, y: 0.1702840806558219d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36627870482679914d, y: 0.34492492475932246d), new NpgsqlTypes.NpgsqlPoint(x: 0.318554210930728d, y: 0.9698938423751585d), new NpgsqlTypes.NpgsqlPoint(x: 0.6257947100384058d, y: 0.21363134934618533d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39136314316120735d, y: 0.7949694810955394d), new NpgsqlTypes.NpgsqlPoint(x: 0.8850411502043067d, y: 0.5461824659231653d), new NpgsqlTypes.NpgsqlPoint(x: 0.3455256320827903d, y: 0.5034586282454978d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9476397615573684d, y: 0.7214005264697351d), new NpgsqlTypes.NpgsqlPoint(x: 0.23356794245348933d, y: 0.679318900454175d), new NpgsqlTypes.NpgsqlPoint(x: 0.49682767210403567d, y: 0.12468898768015013d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3377235477876638d, y: 0.837355889707616d), new NpgsqlTypes.NpgsqlPoint(x: 0.20308756710892795d, y: 0.8859168985337266d), new NpgsqlTypes.NpgsqlPoint(x: 0.963609578337132d, y: 0.6976466745747086d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4349991072510673d, y: 0.7057411139098452d), new NpgsqlTypes.NpgsqlPoint(x: 0.6947949644774595d, y: 0.3660481734764873d), new NpgsqlTypes.NpgsqlPoint(x: 0.9792047262005656d, y: 0.8584137928217198d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5527440142572652d, y: 0.5166302794186026d), new NpgsqlTypes.NpgsqlPoint(x: 0.16953649373242752d, y: 0.39127914971039024d), new NpgsqlTypes.NpgsqlPoint(x: 0.8915087023038695d, y: 0.0350177760243805d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9382764585185911d, y: 0.7732457362328554d), new NpgsqlTypes.NpgsqlPoint(x: 0.1960427362182151d, y: 0.7151285338466137d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124652494436873d, y: 0.9716027019186939d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9506249431343747d, y: 0.5600654544542147d), new NpgsqlTypes.NpgsqlPoint(x: 0.8992463466465683d, y: 0.639774642080477d), new NpgsqlTypes.NpgsqlPoint(x: 0.31166542519445684d, y: 0.2900245609001785d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3252956867843597d, y: 0.08179046049316763d), new NpgsqlTypes.NpgsqlPoint(x: 0.3233747521432163d, y: 0.5363629772512772d), new NpgsqlTypes.NpgsqlPoint(x: 0.795084856218932d, y: 0.09591704394232037d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15910695085826954d, y: 0.4189374571669323d), new NpgsqlTypes.NpgsqlPoint(x: 0.15081147085593993d, y: 0.9582963610415034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8460955247873118d, y: 0.5172273360644092d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9359096991729784d, y: 0.4965000189239075d), new NpgsqlTypes.NpgsqlPoint(x: 0.14890064779581946d, y: 0.8277048180797949d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747335083295574d, y: 0.30974193577958753d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0782284740547795d, y: 0.37982624142610855d), new NpgsqlTypes.NpgsqlPoint(x: 0.889332860130029d, y: 0.34656317870977116d), new NpgsqlTypes.NpgsqlPoint(x: 0.5002532207413608d, y: 0.5828767148651792d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5164766793174392d, y: 0.5213613991353119d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116253611164276d, y: 0.8810551162797668d), new NpgsqlTypes.NpgsqlPoint(x: 0.3085016959853629d, y: 0.9475439972255362d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3489619944948096d, y: 0.5834148618488152d), new NpgsqlTypes.NpgsqlPoint(x: 0.19775589913090508d, y: 0.4187730393954008d), new NpgsqlTypes.NpgsqlPoint(x: 0.23088800588239944d, y: 0.47513195840967526d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22088885813037307d, y: 0.9557961621608739d), new NpgsqlTypes.NpgsqlPoint(x: 0.6644332464781146d, y: 0.8347476688119715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5184038731986863d, y: 0.8575890139896246d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05165476746733644d, y: 0.028655926595719028d), new NpgsqlTypes.NpgsqlPoint(x: 0.03457433774631535d, y: 0.16075453826609298d), new NpgsqlTypes.NpgsqlPoint(x: 0.16991737171068133d, y: 0.04425811255442058d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7112320490808934d, y: 0.8963846842561312d), new NpgsqlTypes.NpgsqlPoint(x: 0.16793568556378013d, y: 0.041735591082717516d), new NpgsqlTypes.NpgsqlPoint(x: 0.08134462165841816d, y: 0.9254888084643703d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23214065629942549d, y: 0.19812632988609113d), new NpgsqlTypes.NpgsqlPoint(x: 0.25220842760407824d, y: 0.8297523471143128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455563588499515d, y: 0.07974179283497451d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6727025942154948d, y: 0.8623893025676641d), new NpgsqlTypes.NpgsqlPoint(x: 0.3414261021931343d, y: 0.634175047288639d), new NpgsqlTypes.NpgsqlPoint(x: 0.9015523436268948d, y: 0.5537605125483938d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9418341143972704d, y: 0.3119069291046428d), new NpgsqlTypes.NpgsqlPoint(x: 0.8464853780125533d, y: 0.5124083486402952d), new NpgsqlTypes.NpgsqlPoint(x: 0.25185500776953107d, y: 0.9487642006071406d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.674152549635956d, y: 0.7296848325323522d), new NpgsqlTypes.NpgsqlPoint(x: 0.6794379786432687d, y: 0.8564446829520764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8710596770834754d, y: 0.9216556656896965d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5331066141208703d, y: 0.5353960525904325d), new NpgsqlTypes.NpgsqlPoint(x: 0.4345936810587916d, y: 0.9184329812657642d), new NpgsqlTypes.NpgsqlPoint(x: 0.10222037186275246d, y: 0.18548399806159777d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06879248285341821d, y: 0.6819436351595272d), new NpgsqlTypes.NpgsqlPoint(x: 0.8968301291113417d, y: 0.6895460709150619d), new NpgsqlTypes.NpgsqlPoint(x: 0.6738449447534851d, y: 0.9821848845742497d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.052793863351644155d, y: 0.6509834942319761d), new NpgsqlTypes.NpgsqlPoint(x: 0.27943152512601555d, y: 0.3703164835205629d), new NpgsqlTypes.NpgsqlPoint(x: 0.4944084577506883d, y: 0.8922033967493999d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9419341499747026d, y: 0.43852691969868585d), new NpgsqlTypes.NpgsqlPoint(x: 0.9829000629185255d, y: 0.1459247420068489d), new NpgsqlTypes.NpgsqlPoint(x: 0.5295454919525352d, y: 0.32523308198096346d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22666122060687344d, y: 0.8605084040550666d), new NpgsqlTypes.NpgsqlPoint(x: 0.3067864598944934d, y: 0.38114284076564353d), new NpgsqlTypes.NpgsqlPoint(x: 0.44922910867449406d, y: 0.37025263186234203d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4061737950231603d, y: 0.3370229453081264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9269249494023103d, y: 0.655667560231936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5260244834480033d, y: 0.7877335537321054d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4608317394073129d, y: 0.8995434104277462d), new NpgsqlTypes.NpgsqlPoint(x: 0.5116020467924388d, y: 0.21255552480470175d), new NpgsqlTypes.NpgsqlPoint(x: 0.6521838242514353d, y: 0.16803139792545319d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9956698964991504d, y: 0.8267420061952422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927529371173205d, y: 0.520205558419824d), new NpgsqlTypes.NpgsqlPoint(x: 0.15763528225337797d, y: 0.023532543721785038d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07964271663049871d, y: 0.21625466426155304d), new NpgsqlTypes.NpgsqlPoint(x: 0.02826531062442117d, y: 0.6239871315391012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010611411991968d, y: 0.06086917251947366d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3360659778030959d, y: 0.13050440598198876d), new NpgsqlTypes.NpgsqlPoint(x: 0.7760754237397676d, y: 0.2952763583901977d), new NpgsqlTypes.NpgsqlPoint(x: 0.9516022370299011d, y: 0.7924994566507133d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.009205243088441284d, y: 0.7619941425110427d), new NpgsqlTypes.NpgsqlPoint(x: 0.8388293573247092d, y: 0.5726032608478397d), new NpgsqlTypes.NpgsqlPoint(x: 0.3934942912284578d, y: 0.7865988759990384d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7593649334614679d, y: 0.06745130541800104d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234055764785916d, y: 0.8021885237950619d), new NpgsqlTypes.NpgsqlPoint(x: 0.9574819770663681d, y: 0.42560006104171266d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7339940859199082d, y: 0.21205342034697472d), new NpgsqlTypes.NpgsqlPoint(x: 0.5528514721979946d, y: 0.015635846325114833d), new NpgsqlTypes.NpgsqlPoint(x: 0.4466957903160135d, y: 0.8547227865027591d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8609008106347593d, y: 0.43488559687149486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4113178995848519d, y: 0.5349597101934777d), new NpgsqlTypes.NpgsqlPoint(x: 0.5535469547166451d, y: 0.4018268544897273d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7194188707441711d, y: 0.4639265092515741d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481906812570419d, y: 0.9802595125199505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213005166554235d, y: 0.24889448838216055d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31846270050372905d, y: 0.7466958668534716d), new NpgsqlTypes.NpgsqlPoint(x: 0.40002593775108863d, y: 0.23919117393252387d), new NpgsqlTypes.NpgsqlPoint(x: 0.7210444638299245d, y: 0.439970365671721d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30472554422756915d, y: 0.9318508720002607d), new NpgsqlTypes.NpgsqlPoint(x: 0.8899995683026247d, y: 0.34024482404791734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7342672444983434d, y: 0.06222734275834463d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5570504737075197d, y: 0.16458486569432873d), new NpgsqlTypes.NpgsqlPoint(x: 0.24358478675208062d, y: 0.45623765249170345d), new NpgsqlTypes.NpgsqlPoint(x: 0.8366680153066103d, y: 0.3286874832522447d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47178714646140507d, y: 0.738065011288784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5668246510535818d, y: 0.4582741699557924d), new NpgsqlTypes.NpgsqlPoint(x: 0.8259033130500462d, y: 0.14015743213703302d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9797639784608396d, y: 0.7919012339607749d), new NpgsqlTypes.NpgsqlPoint(x: 0.3496504210316209d, y: 0.8062897539163459d), new NpgsqlTypes.NpgsqlPoint(x: 0.11168826780388386d, y: 0.4435177749787017d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6745571974730579d, y: 0.6691712773011513d), new NpgsqlTypes.NpgsqlPoint(x: 0.8278564980468751d, y: 0.34376711436110674d), new NpgsqlTypes.NpgsqlPoint(x: 0.7408662940538073d, y: 0.9494049965083525d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11133071228130131d, y: 0.16691008786259143d), new NpgsqlTypes.NpgsqlPoint(x: 0.32156950818260377d, y: 0.9057176804282426d), new NpgsqlTypes.NpgsqlPoint(x: 0.3598597472846653d, y: 0.3472768162038743d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012416520411553833d, y: 0.008710360586396515d), new NpgsqlTypes.NpgsqlPoint(x: 0.9995025636683124d, y: 0.0716295417409003d), new NpgsqlTypes.NpgsqlPoint(x: 0.023714282957931654d, y: 0.8908448945063003d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5213377353989377d, y: 0.9691687783146103d), new NpgsqlTypes.NpgsqlPoint(x: 0.6679946804292065d, y: 0.3106934308649578d), new NpgsqlTypes.NpgsqlPoint(x: 0.12844839749893322d, y: 0.7054191840624274d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13412314637753509d, y: 0.6113287205828896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7046191111392793d, y: 0.9023049297197723d), new NpgsqlTypes.NpgsqlPoint(x: 0.8487342595535583d, y: 0.6199822451010455d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3569338186119879d, y: 0.36803058588640336d), new NpgsqlTypes.NpgsqlPoint(x: 0.17452068203579874d, y: 0.7270472986577301d), new NpgsqlTypes.NpgsqlPoint(x: 0.24208127436364346d, y: 0.06690940760336583d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07205563321140318d, y: 0.37079057906148105d), new NpgsqlTypes.NpgsqlPoint(x: 0.29525409826709614d, y: 0.5391395586407982d), new NpgsqlTypes.NpgsqlPoint(x: 0.4299413683643296d, y: 0.33785942426410653d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13638636790930492d, y: 0.6990521699070708d), new NpgsqlTypes.NpgsqlPoint(x: 0.8373341215015491d, y: 0.872204615331761d), new NpgsqlTypes.NpgsqlPoint(x: 0.41017085124020125d, y: 0.9658504510981286d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6629937204305132d, y: 0.99551910681736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6674168613598188d, y: 0.4978964258334777d), new NpgsqlTypes.NpgsqlPoint(x: 0.4501586182412398d, y: 0.24921439352180785d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2850136624616719d, y: 0.29914370247220834d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621682531807783d, y: 0.729529484907072d), new NpgsqlTypes.NpgsqlPoint(x: 0.0571904984581344d, y: 0.10351827380758805d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31730065613792247d, y: 0.6451884082836582d), new NpgsqlTypes.NpgsqlPoint(x: 0.8430231261912171d, y: 0.9011527225999498d), new NpgsqlTypes.NpgsqlPoint(x: 0.14434058439472253d, y: 0.5577225473954898d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6905292479369856d, y: 0.4509364644760697d), new NpgsqlTypes.NpgsqlPoint(x: 0.7838482434322487d, y: 0.4876624255112253d), new NpgsqlTypes.NpgsqlPoint(x: 0.10086137255347893d, y: 0.2767241949039999d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5930120164903414d, y: 0.07567181356174046d), new NpgsqlTypes.NpgsqlPoint(x: 0.8347904300829705d, y: 0.9388990202866088d), new NpgsqlTypes.NpgsqlPoint(x: 0.806455226307867d, y: 0.7423401734002334d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8802616763503964d, y: 0.543861546788293d), new NpgsqlTypes.NpgsqlPoint(x: 0.5797061244763986d, y: 0.8776199357267158d), new NpgsqlTypes.NpgsqlPoint(x: 0.5807487497039383d, y: 0.4633047055826611d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8997098038224279d, y: 0.7291748218831778d), new NpgsqlTypes.NpgsqlPoint(x: 0.706876762327436d, y: 0.6303660582047204d), new NpgsqlTypes.NpgsqlPoint(x: 0.4203088836148756d, y: 0.2063048500849597d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07611599600234897d, y: 0.5398505635886515d), new NpgsqlTypes.NpgsqlPoint(x: 0.03570926958221876d, y: 0.7311505035126676d), new NpgsqlTypes.NpgsqlPoint(x: 0.12123471750290327d, y: 0.4199804765472722d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7907206596051018d, y: 0.36194169130351905d), new NpgsqlTypes.NpgsqlPoint(x: 0.7911846208411916d, y: 0.9518022207133512d), new NpgsqlTypes.NpgsqlPoint(x: 0.9529028038105093d, y: 0.6317256905056364d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3186978704422603d, y: 0.07991429793186677d), new NpgsqlTypes.NpgsqlPoint(x: 0.25755790659164446d, y: 0.3741086185241067d), new NpgsqlTypes.NpgsqlPoint(x: 0.43131615412048563d, y: 0.4784669976549757d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8774183618421599d, y: 0.5023730230555371d), new NpgsqlTypes.NpgsqlPoint(x: 0.1110603967093039d, y: 0.5766830467688002d), new NpgsqlTypes.NpgsqlPoint(x: 0.25402690709407405d, y: 0.5462944078693827d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8542510979240512d, y: 0.43669536972564327d), new NpgsqlTypes.NpgsqlPoint(x: 0.42049265977980277d, y: 0.1621531291327365d), new NpgsqlTypes.NpgsqlPoint(x: 0.11344169422426664d, y: 0.6960878210245561d)))));

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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpath0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpath0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0m m
LEFT JOIN public.binary_npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpath0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpath0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI), typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpath0MI>();
                var models2 = new List<NpgsqlPathpath0MI>();
                await ((INpgsqlPathSingleTypepath)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MI>();
                var models2 = new List<NpgsqlPathpath0MI>();
                ((INpgsqlPathSingleTypepath)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

