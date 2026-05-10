

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9975679848993214d, y: 0.18354641848385245d), new NpgsqlTypes.NpgsqlPoint(x: 0.9524957615677568d, y: 0.44956182421336555d), new NpgsqlTypes.NpgsqlPoint(x: 0.060149722970735287d, y: 0.8658174461866008d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8183406667311793d, y: 0.38114060917398873d), new NpgsqlTypes.NpgsqlPoint(x: 0.10196207475240104d, y: 0.9751199745150356d), new NpgsqlTypes.NpgsqlPoint(x: 0.40923151133504476d, y: 0.030277352241872668d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15455332400797117d, y: 0.8729955380547832d), new NpgsqlTypes.NpgsqlPoint(x: 0.8795170368899531d, y: 0.4592882414277186d), new NpgsqlTypes.NpgsqlPoint(x: 0.7144683318268519d, y: 0.4693066140771224d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8759921719310211d, y: 0.778206789764016d), new NpgsqlTypes.NpgsqlPoint(x: 0.823674608873253d, y: 0.5622417832801095d), new NpgsqlTypes.NpgsqlPoint(x: 0.30105424524003754d, y: 0.8219188548010162d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1261957524810986d, y: 0.814126747030449d), new NpgsqlTypes.NpgsqlPoint(x: 0.6323586936402422d, y: 0.737207872401203d), new NpgsqlTypes.NpgsqlPoint(x: 0.8810898877880488d, y: 0.2345864686410909d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38294275764653884d, y: 0.7888788290344027d), new NpgsqlTypes.NpgsqlPoint(x: 0.3751472535711875d, y: 0.39989595882598483d), new NpgsqlTypes.NpgsqlPoint(x: 0.6953834467060809d, y: 0.3271546424982865d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10707265419668688d, y: 0.7646476369017859d), new NpgsqlTypes.NpgsqlPoint(x: 0.797764905120573d, y: 0.3064860536214393d), new NpgsqlTypes.NpgsqlPoint(x: 0.09786166007866337d, y: 0.9817515538095009d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9279278965801476d, y: 0.8465556056569322d), new NpgsqlTypes.NpgsqlPoint(x: 0.7594274915357488d, y: 0.1161254973718926d), new NpgsqlTypes.NpgsqlPoint(x: 0.11003755161830986d, y: 0.0826629021313382d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25590052849799316d, y: 0.36206879637472855d), new NpgsqlTypes.NpgsqlPoint(x: 0.1747180753812818d, y: 0.15604898218388474d), new NpgsqlTypes.NpgsqlPoint(x: 0.7567554274231475d, y: 0.2974669490209616d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2868553670191346d, y: 0.27190577028641283d), new NpgsqlTypes.NpgsqlPoint(x: 0.8292198482562744d, y: 0.4212820988199164d), new NpgsqlTypes.NpgsqlPoint(x: 0.0923765146316281d, y: 0.42356357193269967d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003283820918275282d, y: 0.16944039478121353d), new NpgsqlTypes.NpgsqlPoint(x: 0.06650544544214265d, y: 0.933000214504976d), new NpgsqlTypes.NpgsqlPoint(x: 0.875460095247187d, y: 0.5005075249525843d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6533752514221985d, y: 0.367976132174079d), new NpgsqlTypes.NpgsqlPoint(x: 0.13391906555304345d, y: 0.9953313050910017d), new NpgsqlTypes.NpgsqlPoint(x: 0.963369949605771d, y: 0.6020433706642928d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5466884509843953d, y: 0.0920062956494182d), new NpgsqlTypes.NpgsqlPoint(x: 0.4753853378774824d, y: 0.2698433406557754d), new NpgsqlTypes.NpgsqlPoint(x: 0.21670076951598483d, y: 0.7322630018316962d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7647288665930119d, y: 0.7325086944478739d), new NpgsqlTypes.NpgsqlPoint(x: 0.4184544554122305d, y: 0.0034176499858113996d), new NpgsqlTypes.NpgsqlPoint(x: 0.05720187835349988d, y: 0.9879832683510091d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22145480959633612d, y: 0.5770804664862993d), new NpgsqlTypes.NpgsqlPoint(x: 0.9318358074933245d, y: 0.7323605071830089d), new NpgsqlTypes.NpgsqlPoint(x: 0.21977707706648364d, y: 0.6196203831483077d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6663982863842193d, y: 0.0009082895886547426d), new NpgsqlTypes.NpgsqlPoint(x: 0.6691637388340379d, y: 0.21374300742089858d), new NpgsqlTypes.NpgsqlPoint(x: 0.923059724993021d, y: 0.48776764844792386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3569756070744231d, y: 0.9428123586921598d), new NpgsqlTypes.NpgsqlPoint(x: 0.2218995103629413d, y: 0.2760288869119497d), new NpgsqlTypes.NpgsqlPoint(x: 0.19133734788089107d, y: 0.4395765663304009d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0981581572161343d, y: 0.40953707721584165d), new NpgsqlTypes.NpgsqlPoint(x: 0.4400742277704689d, y: 0.41470062597087953d), new NpgsqlTypes.NpgsqlPoint(x: 0.5888984803664065d, y: 0.9213252586311591d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22674415309010998d, y: 0.18526343232412912d), new NpgsqlTypes.NpgsqlPoint(x: 0.9679910712811292d, y: 0.8568155780730712d), new NpgsqlTypes.NpgsqlPoint(x: 0.5955889973631653d, y: 0.394258853936192d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10561674853429914d, y: 0.6316894606758978d), new NpgsqlTypes.NpgsqlPoint(x: 0.08051084400680941d, y: 0.4064865359947495d), new NpgsqlTypes.NpgsqlPoint(x: 0.2537328096229513d, y: 0.4249966028930513d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36029624453940334d, y: 0.3776521558428706d), new NpgsqlTypes.NpgsqlPoint(x: 0.5699745690449335d, y: 0.6877129968058485d), new NpgsqlTypes.NpgsqlPoint(x: 0.8429611396536513d, y: 0.28742236204053573d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4395314796331228d, y: 0.588397465045609d), new NpgsqlTypes.NpgsqlPoint(x: 0.4752713290678814d, y: 0.6979744317303669d), new NpgsqlTypes.NpgsqlPoint(x: 0.11141612664523037d, y: 0.45090369417919096d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42092455495087455d, y: 0.8422975444467646d), new NpgsqlTypes.NpgsqlPoint(x: 0.30081492474687954d, y: 0.24153845241781757d), new NpgsqlTypes.NpgsqlPoint(x: 0.2693120093500767d, y: 0.654604883399901d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27828811413769716d, y: 0.6642862616137727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6060305042371719d, y: 0.03242200866512335d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407686232667686d, y: 0.42000652300316854d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7556067389038914d, y: 0.03947514035586863d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982229310093015d, y: 0.8326794684476276d), new NpgsqlTypes.NpgsqlPoint(x: 0.9650568318282862d, y: 0.9421691069008703d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6269244645998161d, y: 0.9075169348327544d), new NpgsqlTypes.NpgsqlPoint(x: 0.43710813766927115d, y: 0.917712840908039d), new NpgsqlTypes.NpgsqlPoint(x: 0.40112467386933726d, y: 0.4910854803504354d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9507520674740186d, y: 0.5618819222644476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6729264379186685d, y: 0.684376259130246d), new NpgsqlTypes.NpgsqlPoint(x: 0.6867294711395708d, y: 0.3771422127023675d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7958042646719996d, y: 0.09279464525021841d), new NpgsqlTypes.NpgsqlPoint(x: 0.9520802622414867d, y: 0.7370850429974403d), new NpgsqlTypes.NpgsqlPoint(x: 0.607610262909435d, y: 0.4308999311704852d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02059420943901602d, y: 0.8904358285210456d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513652704636343d, y: 0.30730710004327266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5839140596182149d, y: 0.6400129235372668d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1388721502102661d, y: 0.19559081542592327d), new NpgsqlTypes.NpgsqlPoint(x: 0.9778833551890063d, y: 0.7668223327526201d), new NpgsqlTypes.NpgsqlPoint(x: 0.4922909099476064d, y: 0.08443723828798544d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10830239965200728d, y: 0.2907016440970308d), new NpgsqlTypes.NpgsqlPoint(x: 0.2537043811536218d, y: 0.8724969898164955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9224928650408448d, y: 0.5444711448943145d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9894361190319387d, y: 0.39814042263683624d), new NpgsqlTypes.NpgsqlPoint(x: 0.4522944834872813d, y: 0.06314571912242761d), new NpgsqlTypes.NpgsqlPoint(x: 0.41905132940434d, y: 0.9562893843555572d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9578670086492624d, y: 0.3876521847047998d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004862238989503d, y: 0.18335461437198786d), new NpgsqlTypes.NpgsqlPoint(x: 0.9955686107885391d, y: 0.3106908825901388d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31212054344034035d, y: 0.3070734755472295d), new NpgsqlTypes.NpgsqlPoint(x: 0.8882293537235564d, y: 0.8928807926024598d), new NpgsqlTypes.NpgsqlPoint(x: 0.7766447772767241d, y: 0.3720440923411493d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5593401506256555d, y: 0.6294819340768278d), new NpgsqlTypes.NpgsqlPoint(x: 0.9646490646571287d, y: 0.06432004438043226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6347743512285803d, y: 0.7071207360454164d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.134996123039539d, y: 0.6036207096949356d), new NpgsqlTypes.NpgsqlPoint(x: 0.31746223859389433d, y: 0.3683579306811199d), new NpgsqlTypes.NpgsqlPoint(x: 0.03807846397479897d, y: 0.9731761522010075d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3791275314298007d, y: 0.3829582129586574d), new NpgsqlTypes.NpgsqlPoint(x: 0.20348888331575088d, y: 0.6288484255466957d), new NpgsqlTypes.NpgsqlPoint(x: 0.3364960727289291d, y: 0.43831483127172355d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5272883539853991d, y: 0.36955113890099867d), new NpgsqlTypes.NpgsqlPoint(x: 0.17838652632410812d, y: 0.8524474656876668d), new NpgsqlTypes.NpgsqlPoint(x: 0.2513404250938097d, y: 0.055447945324007986d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25330293640202717d, y: 0.19244355629138432d), new NpgsqlTypes.NpgsqlPoint(x: 0.561178674230005d, y: 0.1756125635730894d), new NpgsqlTypes.NpgsqlPoint(x: 0.8245753280109668d, y: 0.4333355864806938d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.655834883884041d, y: 0.4063104717615703d), new NpgsqlTypes.NpgsqlPoint(x: 0.9209834630700604d, y: 0.23361064978123358d), new NpgsqlTypes.NpgsqlPoint(x: 0.2006004657507443d, y: 0.12767771693271468d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5419301479772d, y: 0.5681033492002607d), new NpgsqlTypes.NpgsqlPoint(x: 0.7615517983394821d, y: 0.9500603100457837d), new NpgsqlTypes.NpgsqlPoint(x: 0.4603162448821396d, y: 0.32114888186300006d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.913406134263428d, y: 0.317159818522308d), new NpgsqlTypes.NpgsqlPoint(x: 0.18189542006691417d, y: 0.7381137053934417d), new NpgsqlTypes.NpgsqlPoint(x: 0.21153914740783675d, y: 0.9742130887651658d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3125784492363268d, y: 0.8336010813461655d), new NpgsqlTypes.NpgsqlPoint(x: 0.5362614483211756d, y: 0.39126341812764864d), new NpgsqlTypes.NpgsqlPoint(x: 0.7385175318238731d, y: 0.9914160871229881d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9373497632271472d, y: 0.9551644688384542d), new NpgsqlTypes.NpgsqlPoint(x: 0.6374712273545863d, y: 0.4964909480207996d), new NpgsqlTypes.NpgsqlPoint(x: 0.653253484203416d, y: 0.8906384033350012d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06975350466036312d, y: 0.42595052121162247d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515492249871213d, y: 0.9784767068295122d), new NpgsqlTypes.NpgsqlPoint(x: 0.8431782446112375d, y: 0.5833999192782541d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08810549026629133d, y: 0.10462700170036143d), new NpgsqlTypes.NpgsqlPoint(x: 0.10490477244895646d, y: 0.08659685912983173d), new NpgsqlTypes.NpgsqlPoint(x: 0.19391646850417488d, y: 0.2641519251444264d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9638046652020948d, y: 0.9553332889617755d), new NpgsqlTypes.NpgsqlPoint(x: 0.9318349144514827d, y: 0.4785225171105856d), new NpgsqlTypes.NpgsqlPoint(x: 0.23829106236569741d, y: 0.38930642390102954d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9727844737754823d, y: 0.3719375290001171d), new NpgsqlTypes.NpgsqlPoint(x: 0.5783802757303063d, y: 0.7329770221758564d), new NpgsqlTypes.NpgsqlPoint(x: 0.5387641081016259d, y: 0.46257125931737275d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8169663979161459d, y: 0.13975640529779598d), new NpgsqlTypes.NpgsqlPoint(x: 0.3886549136193479d, y: 0.4291082728861517d), new NpgsqlTypes.NpgsqlPoint(x: 0.7322131651739406d, y: 0.7943174100243245d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31835782221537756d, y: 0.02368847218657255d), new NpgsqlTypes.NpgsqlPoint(x: 0.999613664781582d, y: 0.32080398460599013d), new NpgsqlTypes.NpgsqlPoint(x: 0.14175985007326586d, y: 0.931012535887164d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7399856644835664d, y: 0.6521402265981237d), new NpgsqlTypes.NpgsqlPoint(x: 0.4190632002572279d, y: 0.11669384570231278d), new NpgsqlTypes.NpgsqlPoint(x: 0.7050369499080187d, y: 0.638772149136514d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6196289982639801d, y: 0.31213607001770294d), new NpgsqlTypes.NpgsqlPoint(x: 0.9850101341357558d, y: 0.620868080600736d), new NpgsqlTypes.NpgsqlPoint(x: 0.3877103748785897d, y: 0.018879629137375953d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7192739080102621d, y: 0.8179501904176117d), new NpgsqlTypes.NpgsqlPoint(x: 0.6727534598702136d, y: 0.47994008527253273d), new NpgsqlTypes.NpgsqlPoint(x: 0.801577302421354d, y: 0.8920267432544376d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0733968414673215d, y: 0.383534635584838d), new NpgsqlTypes.NpgsqlPoint(x: 0.5535037831662468d, y: 0.9335829070663724d), new NpgsqlTypes.NpgsqlPoint(x: 0.3122495312536966d, y: 0.018856164043422274d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6708176233334898d, y: 0.7783261601301081d), new NpgsqlTypes.NpgsqlPoint(x: 0.07858480167389037d, y: 0.07474781667637709d), new NpgsqlTypes.NpgsqlPoint(x: 0.11128052952225143d, y: 0.7107216596589309d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13551331758901053d, y: 0.8373505474233632d), new NpgsqlTypes.NpgsqlPoint(x: 0.8328494242308001d, y: 0.4025005253296895d), new NpgsqlTypes.NpgsqlPoint(x: 0.4666780826309931d, y: 0.05286120959776264d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7015409983953739d, y: 0.9756132365440573d), new NpgsqlTypes.NpgsqlPoint(x: 0.8859421921267703d, y: 0.3339650503795345d), new NpgsqlTypes.NpgsqlPoint(x: 0.14715226114228508d, y: 0.16137640376034157d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12613342141292383d, y: 0.4155257904550468d), new NpgsqlTypes.NpgsqlPoint(x: 0.6026681627987077d, y: 0.8110885695156458d), new NpgsqlTypes.NpgsqlPoint(x: 0.978824883805715d, y: 0.9040586981934623d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4148247700647224d, y: 0.9206584133747044d), new NpgsqlTypes.NpgsqlPoint(x: 0.4944439365761655d, y: 0.27784463934743d), new NpgsqlTypes.NpgsqlPoint(x: 0.23696797406948777d, y: 0.7142554033908171d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18929848685077744d, y: 0.7422453385669494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8992494392193797d, y: 0.22394804413493463d), new NpgsqlTypes.NpgsqlPoint(x: 0.8020767572670178d, y: 0.29194636230459925d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7475777563502763d, y: 0.22822348298452544d), new NpgsqlTypes.NpgsqlPoint(x: 0.4054083401421923d, y: 0.5284192970361373d), new NpgsqlTypes.NpgsqlPoint(x: 0.03929256342861498d, y: 0.30114253802858015d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013064929166905048d, y: 0.3958339814213374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9931150819580392d, y: 0.04066183397241485d), new NpgsqlTypes.NpgsqlPoint(x: 0.8008462424130973d, y: 0.334306614441788d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6751000602715287d, y: 0.20323771828957948d), new NpgsqlTypes.NpgsqlPoint(x: 0.5308105694361698d, y: 0.9256786430250512d), new NpgsqlTypes.NpgsqlPoint(x: 0.23868620614806835d, y: 0.35815836823870895d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8353000360801056d, y: 0.933251899495197d), new NpgsqlTypes.NpgsqlPoint(x: 0.0003697389058889833d, y: 0.6520491434341669d), new NpgsqlTypes.NpgsqlPoint(x: 0.8789212645602782d, y: 0.7166701954596254d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3927111722609703d, y: 0.46737344605096354d), new NpgsqlTypes.NpgsqlPoint(x: 0.3486342535444046d, y: 0.2756114628679118d), new NpgsqlTypes.NpgsqlPoint(x: 0.754767101868512d, y: 0.5649279244710906d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1986454776835569d, y: 0.6377539592118774d), new NpgsqlTypes.NpgsqlPoint(x: 0.14192982020336786d, y: 0.31752392185906697d), new NpgsqlTypes.NpgsqlPoint(x: 0.004793024448177197d, y: 0.21561948160586353d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7903778253727816d, y: 0.3811527366112114d), new NpgsqlTypes.NpgsqlPoint(x: 0.42706006012836917d, y: 0.4747361028313415d), new NpgsqlTypes.NpgsqlPoint(x: 0.05719547131486069d, y: 0.8031573418054222d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21254723637953454d, y: 0.186526034092234d), new NpgsqlTypes.NpgsqlPoint(x: 0.06956632536801255d, y: 0.44644764585779606d), new NpgsqlTypes.NpgsqlPoint(x: 0.27943016809297627d, y: 0.4505216464586289d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9839300717969477d, y: 0.03885891848877443d), new NpgsqlTypes.NpgsqlPoint(x: 0.053532385904777824d, y: 0.16460091967548884d), new NpgsqlTypes.NpgsqlPoint(x: 0.3275264881115706d, y: 0.30771103144013434d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9206062705431363d, y: 0.06691395121758681d), new NpgsqlTypes.NpgsqlPoint(x: 0.49628394094972184d, y: 0.4439298918148141d), new NpgsqlTypes.NpgsqlPoint(x: 0.05601244458906618d, y: 0.21103006648583456d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11060804193966178d, y: 0.8346197522757856d), new NpgsqlTypes.NpgsqlPoint(x: 0.6803287873159476d, y: 0.08637132942331827d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499238118619092d, y: 0.48709220509101936d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.717856851651911d, y: 0.31094997110786093d), new NpgsqlTypes.NpgsqlPoint(x: 0.24534850349018733d, y: 0.499017072160326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7919144282564078d, y: 0.17160617069800566d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34266772184871297d, y: 0.700043924828123d), new NpgsqlTypes.NpgsqlPoint(x: 0.6847608842351006d, y: 0.3636248533859636d), new NpgsqlTypes.NpgsqlPoint(x: 0.6606831984967703d, y: 0.78874034713456d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.046520503339969044d, y: 0.12758063732187852d), new NpgsqlTypes.NpgsqlPoint(x: 0.41233404828879283d, y: 0.9732767977102473d), new NpgsqlTypes.NpgsqlPoint(x: 0.7365056514532801d, y: 0.1250551622670153d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8589620541631524d, y: 0.3872988872470108d), new NpgsqlTypes.NpgsqlPoint(x: 0.36748030924135333d, y: 0.2562789523273242d), new NpgsqlTypes.NpgsqlPoint(x: 0.6426514984447345d, y: 0.8079958473272811d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28585626300801037d, y: 0.5927596652706885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9182475763472797d, y: 0.7741089128593225d), new NpgsqlTypes.NpgsqlPoint(x: 0.3012908406413557d, y: 0.10607387829359705d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5292596340086946d, y: 0.47407275749254896d), new NpgsqlTypes.NpgsqlPoint(x: 0.24839903026103693d, y: 0.5278501635255483d), new NpgsqlTypes.NpgsqlPoint(x: 0.005871782712207785d, y: 0.30262771839848013d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09217864626558236d, y: 0.44814027530732503d), new NpgsqlTypes.NpgsqlPoint(x: 0.45598590788354343d, y: 0.1050657693205913d), new NpgsqlTypes.NpgsqlPoint(x: 0.22894980570262624d, y: 0.5716485955460806d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9921723153006227d, y: 0.957337716386917d), new NpgsqlTypes.NpgsqlPoint(x: 0.2826597261975863d, y: 0.8201146589379772d), new NpgsqlTypes.NpgsqlPoint(x: 0.055307649583733354d, y: 0.7597547557377881d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8671109013033983d, y: 0.6478222353215148d), new NpgsqlTypes.NpgsqlPoint(x: 0.7179183307787897d, y: 0.9279910530873631d), new NpgsqlTypes.NpgsqlPoint(x: 0.15314349221388135d, y: 0.7223858376608182d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4090723391838218d, y: 0.9381599659539653d), new NpgsqlTypes.NpgsqlPoint(x: 0.45361563557526907d, y: 0.8998165435019609d), new NpgsqlTypes.NpgsqlPoint(x: 0.4642153221898727d, y: 0.08118978575385538d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18773650421713317d, y: 0.7077763166369258d), new NpgsqlTypes.NpgsqlPoint(x: 0.5106155210719523d, y: 0.04034739501666762d), new NpgsqlTypes.NpgsqlPoint(x: 0.6769823333401581d, y: 0.9033819402941266d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4070419058638297d, y: 0.8600788190216547d), new NpgsqlTypes.NpgsqlPoint(x: 0.51675281822354d, y: 0.574563411391291d), new NpgsqlTypes.NpgsqlPoint(x: 0.8325793173355565d, y: 0.8629858136831954d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3185695544027858d, y: 0.3927004183129035d), new NpgsqlTypes.NpgsqlPoint(x: 0.857246039058073d, y: 0.2622218103835352d), new NpgsqlTypes.NpgsqlPoint(x: 0.01434908292769177d, y: 0.029769403006255635d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02505088256801058d, y: 0.16125651605937352d), new NpgsqlTypes.NpgsqlPoint(x: 0.7040242758890128d, y: 0.49399980293287116d), new NpgsqlTypes.NpgsqlPoint(x: 0.2862248980246054d, y: 0.17564532119565834d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7636683799532448d, y: 0.7845769345053044d), new NpgsqlTypes.NpgsqlPoint(x: 0.0562731621500292d, y: 0.13854497310479486d), new NpgsqlTypes.NpgsqlPoint(x: 0.043132376261881156d, y: 0.19488695979346338d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01326472840874593d, y: 0.7783878184245965d), new NpgsqlTypes.NpgsqlPoint(x: 0.08616473637491351d, y: 0.964086935182302d), new NpgsqlTypes.NpgsqlPoint(x: 0.11826576119577148d, y: 0.8301450355806952d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8134391730194352d, y: 0.9077983484055123d), new NpgsqlTypes.NpgsqlPoint(x: 0.8878904819275052d, y: 0.9988460405322868d), new NpgsqlTypes.NpgsqlPoint(x: 0.2947654089265337d, y: 0.9075907810188583d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3077222326353807d, y: 0.30769371694364045d), new NpgsqlTypes.NpgsqlPoint(x: 0.012745875779483717d, y: 0.7847739648026109d), new NpgsqlTypes.NpgsqlPoint(x: 0.8249504708587098d, y: 0.6997399346710078d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2757193629989131d, y: 0.7307541319549442d), new NpgsqlTypes.NpgsqlPoint(x: 0.8260942137460573d, y: 0.3803931424899065d), new NpgsqlTypes.NpgsqlPoint(x: 0.9043469610630493d, y: 0.006829009394367813d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38284858206666184d, y: 0.17040756944376212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6357512641313166d, y: 0.2659258813657961d), new NpgsqlTypes.NpgsqlPoint(x: 0.006640390706369348d, y: 0.2452188716213971d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5815619340743715d, y: 0.8825462000373018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7995761211860384d, y: 0.8981086534307017d), new NpgsqlTypes.NpgsqlPoint(x: 0.6102440063523881d, y: 0.60677986539937d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8191055855566887d, y: 0.9230955007502356d), new NpgsqlTypes.NpgsqlPoint(x: 0.32405995560458556d, y: 0.3518672808721449d), new NpgsqlTypes.NpgsqlPoint(x: 0.9130587194726341d, y: 0.5579100420839844d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8581164417114919d, y: 0.7952458419715691d), new NpgsqlTypes.NpgsqlPoint(x: 0.011434354401792524d, y: 0.37762335442552386d), new NpgsqlTypes.NpgsqlPoint(x: 0.18961048125295932d, y: 0.0540246583926316d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9150738926125338d, y: 0.9254238441627285d), new NpgsqlTypes.NpgsqlPoint(x: 0.5751285332977892d, y: 0.296878521385858d), new NpgsqlTypes.NpgsqlPoint(x: 0.2506521355137098d, y: 0.45274039457076076d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06998235890297999d, y: 0.38806194012291273d), new NpgsqlTypes.NpgsqlPoint(x: 0.22148885158483578d, y: 0.45853924598766393d), new NpgsqlTypes.NpgsqlPoint(x: 0.26794802812323704d, y: 0.7115111588450997d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5021608986379276d, y: 0.24730634395531437d), new NpgsqlTypes.NpgsqlPoint(x: 0.0852584664924072d, y: 0.14406171412465085d), new NpgsqlTypes.NpgsqlPoint(x: 0.5992988107553868d, y: 0.9901522573719593d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24181483792328473d, y: 0.16462578686476115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8637915103441933d, y: 0.9483963752362505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6635966878060214d, y: 0.3217308036155957d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3820269681769577d, y: 0.8441135445065917d), new NpgsqlTypes.NpgsqlPoint(x: 0.46601510938662494d, y: 0.0018250922627222055d), new NpgsqlTypes.NpgsqlPoint(x: 0.0454890805544137d, y: 0.48144158984759666d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7387639779942541d, y: 0.5352856933453632d), new NpgsqlTypes.NpgsqlPoint(x: 0.8999634194717857d, y: 0.7933909103665823d), new NpgsqlTypes.NpgsqlPoint(x: 0.35944842545514843d, y: 0.26933734554623256d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8623254073106887d, y: 0.5912406957992904d), new NpgsqlTypes.NpgsqlPoint(x: 0.06885659521435672d, y: 0.030878700004080217d), new NpgsqlTypes.NpgsqlPoint(x: 0.37093697855129304d, y: 0.7997149029395649d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3717653230494128d, y: 0.014911092118919833d), new NpgsqlTypes.NpgsqlPoint(x: 0.0779531441041118d, y: 0.6277270544186766d), new NpgsqlTypes.NpgsqlPoint(x: 0.2356467095676159d, y: 0.46009373029255507d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7938686529819615d, y: 0.9899221354445275d), new NpgsqlTypes.NpgsqlPoint(x: 0.06022592878558819d, y: 0.0764760246843883d), new NpgsqlTypes.NpgsqlPoint(x: 0.2744351624221206d, y: 0.20007386432110907d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22043186590642172d, y: 0.12008192690564023d), new NpgsqlTypes.NpgsqlPoint(x: 0.44084756230268607d, y: 0.5290914545463645d), new NpgsqlTypes.NpgsqlPoint(x: 0.9458424870421603d, y: 0.2985007871966012d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06355523148945319d, y: 0.2809246579843815d), new NpgsqlTypes.NpgsqlPoint(x: 0.17739167800041655d, y: 0.37222011421096834d), new NpgsqlTypes.NpgsqlPoint(x: 0.6726304822000286d, y: 0.5762034712630592d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014451657774585236d, y: 0.6178878476255097d), new NpgsqlTypes.NpgsqlPoint(x: 0.5190337682214858d, y: 0.9514744848424277d), new NpgsqlTypes.NpgsqlPoint(x: 0.5291770315017403d, y: 0.7692624795352567d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5418146345523406d, y: 0.08484279678589413d), new NpgsqlTypes.NpgsqlPoint(x: 0.6728456231007357d, y: 0.5166570542903862d), new NpgsqlTypes.NpgsqlPoint(x: 0.9209247091353597d, y: 0.19861976638583068d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12480885192367197d, y: 0.9619344794340001d), new NpgsqlTypes.NpgsqlPoint(x: 0.8906542759624224d, y: 0.17462672611628516d), new NpgsqlTypes.NpgsqlPoint(x: 0.07824974461116596d, y: 0.12922953750754462d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6274516992218939d, y: 0.09495815906379912d), new NpgsqlTypes.NpgsqlPoint(x: 0.06731111510143328d, y: 0.27248948648465643d), new NpgsqlTypes.NpgsqlPoint(x: 0.3137328381046054d, y: 0.1915085107492821d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03575201587399335d, y: 0.7399317604697017d), new NpgsqlTypes.NpgsqlPoint(x: 0.8136825568421184d, y: 0.3574851334766017d), new NpgsqlTypes.NpgsqlPoint(x: 0.5672532710911096d, y: 0.05371388880056194d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8570324945010985d, y: 0.0016644091979138853d), new NpgsqlTypes.NpgsqlPoint(x: 0.978480446868207d, y: 0.9106264437916408d), new NpgsqlTypes.NpgsqlPoint(x: 0.06908747303286022d, y: 0.8000076795888431d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6813865464225873d, y: 0.8293251098135567d), new NpgsqlTypes.NpgsqlPoint(x: 0.5113936285648739d, y: 0.29584491521417966d), new NpgsqlTypes.NpgsqlPoint(x: 0.9907254241805613d, y: 0.40399135424527555d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3719521571362956d, y: 0.1649506602019627d), new NpgsqlTypes.NpgsqlPoint(x: 0.6767038563796096d, y: 0.47232826209213064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9151723007514359d, y: 0.7253728112226839d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.75379196326559d, y: 0.1657535065742196d), new NpgsqlTypes.NpgsqlPoint(x: 0.2552736517088102d, y: 0.7842751563292195d), new NpgsqlTypes.NpgsqlPoint(x: 0.48725347176640665d, y: 0.32545600092863425d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.059305485776647515d, y: 0.5858675810968745d), new NpgsqlTypes.NpgsqlPoint(x: 0.7442572942857295d, y: 0.9357317644184469d), new NpgsqlTypes.NpgsqlPoint(x: 0.36686309690331975d, y: 0.6857739906020773d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20314543824190512d, y: 0.7911729995732533d), new NpgsqlTypes.NpgsqlPoint(x: 0.413266321304847d, y: 0.19474162669177053d), new NpgsqlTypes.NpgsqlPoint(x: 0.26687598490570774d, y: 0.044094824024647705d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7306348414463306d, y: 0.3688314442883184d), new NpgsqlTypes.NpgsqlPoint(x: 0.9400629382048682d, y: 0.20053592062921521d), new NpgsqlTypes.NpgsqlPoint(x: 0.00946865875666758d, y: 0.10356669086362147d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37204212659803626d, y: 0.1401190749064224d), new NpgsqlTypes.NpgsqlPoint(x: 0.6500718493581585d, y: 0.33644914206689835d), new NpgsqlTypes.NpgsqlPoint(x: 0.2817936130953459d, y: 0.30615420946887617d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23074131750419868d, y: 0.4474839608781168d), new NpgsqlTypes.NpgsqlPoint(x: 0.3932537174756615d, y: 0.07053057430564036d), new NpgsqlTypes.NpgsqlPoint(x: 0.6939597059054051d, y: 0.9984172538076822d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29795204671084996d, y: 0.3112167801158763d), new NpgsqlTypes.NpgsqlPoint(x: 0.1292547511541997d, y: 0.8018208180465107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7585191403381664d, y: 0.9083578530773181d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013236538872786308d, y: 0.08209379851083043d), new NpgsqlTypes.NpgsqlPoint(x: 0.671143809332356d, y: 0.6933390819094732d), new NpgsqlTypes.NpgsqlPoint(x: 0.7547045780678884d, y: 0.4716005888862016d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43268974566233886d, y: 0.5400490315904898d), new NpgsqlTypes.NpgsqlPoint(x: 0.24460507255523467d, y: 0.05095382171385965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6752730055024907d, y: 0.33391952183510176d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6265882686926911d, y: 0.39636884560400654d), new NpgsqlTypes.NpgsqlPoint(x: 0.49518491518621777d, y: 0.7158248484965278d), new NpgsqlTypes.NpgsqlPoint(x: 0.42148102660499787d, y: 0.5000037103483974d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6468656618559319d, y: 0.3291307394739499d), new NpgsqlTypes.NpgsqlPoint(x: 0.2007708151786609d, y: 0.5164917029827314d), new NpgsqlTypes.NpgsqlPoint(x: 0.13221651735408702d, y: 0.09686174582329998d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40313394637532873d, y: 0.4175303067248174d), new NpgsqlTypes.NpgsqlPoint(x: 0.16773621065094402d, y: 0.8757364307134223d), new NpgsqlTypes.NpgsqlPoint(x: 0.8373408604234128d, y: 0.0828592561717083d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7581487967307111d, y: 0.1567603427175901d), new NpgsqlTypes.NpgsqlPoint(x: 0.583944667524516d, y: 0.06155164615305064d), new NpgsqlTypes.NpgsqlPoint(x: 0.6291324245649512d, y: 0.018717020985927757d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8578909240746952d, y: 0.25453087330462687d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261611102140992d, y: 0.31371259493249615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5118195774859862d, y: 0.9141987747464145d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2458092665047198d, y: 0.38012075693019987d), new NpgsqlTypes.NpgsqlPoint(x: 0.7355434999242834d, y: 0.48049770261255464d), new NpgsqlTypes.NpgsqlPoint(x: 0.8637705139706974d, y: 0.16574847734755993d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8192561172273101d, y: 0.6185668381448252d), new NpgsqlTypes.NpgsqlPoint(x: 0.4600256222693132d, y: 0.8300836569270421d), new NpgsqlTypes.NpgsqlPoint(x: 0.833337291170922d, y: 0.19061562281121902d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.327894763408633d, y: 0.06187821119562453d), new NpgsqlTypes.NpgsqlPoint(x: 0.31716243098929253d, y: 0.33748627903896d), new NpgsqlTypes.NpgsqlPoint(x: 0.2961651988234395d, y: 0.13898663559170366d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5926183606254116d, y: 0.9159205948534124d), new NpgsqlTypes.NpgsqlPoint(x: 0.3810291017150892d, y: 0.37024027157570716d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354016914660463d, y: 0.38949857140624566d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4472877399712526d, y: 0.5734653252861763d), new NpgsqlTypes.NpgsqlPoint(x: 0.3870998011612088d, y: 0.5982306824159702d), new NpgsqlTypes.NpgsqlPoint(x: 0.9353553178718512d, y: 0.7942498516909665d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5153080956567736d, y: 0.09388217302947732d), new NpgsqlTypes.NpgsqlPoint(x: 0.22215310100989594d, y: 0.9728456093573725d), new NpgsqlTypes.NpgsqlPoint(x: 0.6327421355659754d, y: 0.0399879418748611d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2343418419607759d, y: 0.35472277049487d), new NpgsqlTypes.NpgsqlPoint(x: 0.7485839599772044d, y: 0.7042543852412382d), new NpgsqlTypes.NpgsqlPoint(x: 0.2958794110455182d, y: 0.2038775116940592d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.652018234767993d, y: 0.48658369579936267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6583068572604293d, y: 0.39940133552191104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5195553857144444d, y: 0.034733173830228004d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5073213260394701d, y: 0.14798638011984644d), new NpgsqlTypes.NpgsqlPoint(x: 0.15856379420790723d, y: 0.6055266758612341d), new NpgsqlTypes.NpgsqlPoint(x: 0.4710580028760851d, y: 0.03353703121829987d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26250931796288934d, y: 0.6400212789010477d), new NpgsqlTypes.NpgsqlPoint(x: 0.49519627694842405d, y: 0.8220572599507963d), new NpgsqlTypes.NpgsqlPoint(x: 0.45669990520391457d, y: 0.18860884835282532d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6914657893123247d, y: 0.960470707527585d), new NpgsqlTypes.NpgsqlPoint(x: 0.8038573897509403d, y: 0.06808989450269476d), new NpgsqlTypes.NpgsqlPoint(x: 0.4244803855758702d, y: 0.9689382891465024d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23349058095143949d, y: 0.21247617929544094d), new NpgsqlTypes.NpgsqlPoint(x: 0.23491433012855878d, y: 0.6499289883659722d), new NpgsqlTypes.NpgsqlPoint(x: 0.23977960870210147d, y: 0.04664820390752089d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8262057446437914d, y: 0.7218664256557193d), new NpgsqlTypes.NpgsqlPoint(x: 0.5008981087226306d, y: 0.8927230528785566d), new NpgsqlTypes.NpgsqlPoint(x: 0.407009026615859d, y: 0.7759060539551537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3258637678912871d, y: 0.8596564943016675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6609813458443973d, y: 0.7683108673094542d), new NpgsqlTypes.NpgsqlPoint(x: 0.2246096678024747d, y: 0.8549088851781559d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06012085998636363d, y: 0.6159203467035529d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623006365269412d, y: 0.10995171449182839d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121388545560619d, y: 0.5763697582342057d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0601012876860777d, y: 0.9221151306309626d), new NpgsqlTypes.NpgsqlPoint(x: 0.19511708725734633d, y: 0.5378376756556749d), new NpgsqlTypes.NpgsqlPoint(x: 0.1511650643785274d, y: 0.10809741396444617d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.436454684271807d, y: 0.661039385764257d), new NpgsqlTypes.NpgsqlPoint(x: 0.9300535727799487d, y: 0.06122263138966644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8047239680707591d, y: 0.9714465328171987d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3168787012197529d, y: 0.4767943835592182d), new NpgsqlTypes.NpgsqlPoint(x: 0.7405894221906983d, y: 0.5033972405943627d), new NpgsqlTypes.NpgsqlPoint(x: 0.4104153106296463d, y: 0.6335141209434432d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.753726710003058d, y: 0.5407207351557727d), new NpgsqlTypes.NpgsqlPoint(x: 0.32612595355996765d, y: 0.4066858840455939d), new NpgsqlTypes.NpgsqlPoint(x: 0.14493479342156002d, y: 0.008062803362474447d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20281530384010715d, y: 0.34105139181561117d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292274991261826d, y: 0.08707670548740976d), new NpgsqlTypes.NpgsqlPoint(x: 0.07133422516885579d, y: 0.5868821602735214d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6933092273071889d, y: 0.6022166202062192d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005582606755773d, y: 0.0768295082001399d), new NpgsqlTypes.NpgsqlPoint(x: 0.15163836002591524d, y: 0.7440211756113505d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9091893683204862d, y: 0.8792729975810167d), new NpgsqlTypes.NpgsqlPoint(x: 0.26732822179368d, y: 0.8522154407280264d), new NpgsqlTypes.NpgsqlPoint(x: 0.21306425295500786d, y: 0.2357194495776309d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14169004090091697d, y: 0.5732736605988922d), new NpgsqlTypes.NpgsqlPoint(x: 0.3500534095426785d, y: 0.5905268585280263d), new NpgsqlTypes.NpgsqlPoint(x: 0.2172284220025189d, y: 0.42053381515034904d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7833782669638116d, y: 0.32279107065275636d), new NpgsqlTypes.NpgsqlPoint(x: 0.48236989079546944d, y: 0.6132254197062704d), new NpgsqlTypes.NpgsqlPoint(x: 0.6318074934877497d, y: 0.39004393795315817d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13531245435148398d, y: 0.007425713238422116d), new NpgsqlTypes.NpgsqlPoint(x: 0.9968135747184133d, y: 0.696539167497536d), new NpgsqlTypes.NpgsqlPoint(x: 0.18776331235031984d, y: 0.31204959778734054d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5521586061546917d, y: 0.044213094762254546d), new NpgsqlTypes.NpgsqlPoint(x: 0.8839949090493662d, y: 0.8763049933009818d), new NpgsqlTypes.NpgsqlPoint(x: 0.23817165097143955d, y: 0.044332906546008743d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6392285297680138d, y: 0.4443484986828652d), new NpgsqlTypes.NpgsqlPoint(x: 0.2058149967576165d, y: 0.9092805891244277d), new NpgsqlTypes.NpgsqlPoint(x: 0.9099040562218322d, y: 0.41731747433364097d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9932077746353462d, y: 0.4307248664817396d), new NpgsqlTypes.NpgsqlPoint(x: 0.9306955267523452d, y: 0.11755987806901635d), new NpgsqlTypes.NpgsqlPoint(x: 0.43399220818771556d, y: 0.17693085292465782d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9213207942869723d, y: 0.9306146208610085d), new NpgsqlTypes.NpgsqlPoint(x: 0.3447884201241921d, y: 0.6087093333052255d), new NpgsqlTypes.NpgsqlPoint(x: 0.47271526995131674d, y: 0.7904763818308861d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6253778152011344d, y: 0.6318857706923893d), new NpgsqlTypes.NpgsqlPoint(x: 0.8196923775650298d, y: 0.8728289627788206d), new NpgsqlTypes.NpgsqlPoint(x: 0.03581922234809509d, y: 0.9654455331257994d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6852902155248446d, y: 0.8320917873283471d), new NpgsqlTypes.NpgsqlPoint(x: 0.7314454667958392d, y: 0.1391494501767594d), new NpgsqlTypes.NpgsqlPoint(x: 0.779489489102312d, y: 0.4142044586444745d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9671539775970649d, y: 0.3829906186510128d), new NpgsqlTypes.NpgsqlPoint(x: 0.995843327163825d, y: 0.24409012626855586d), new NpgsqlTypes.NpgsqlPoint(x: 0.9065790927919348d, y: 0.26547324651654225d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.834431292293947d, y: 0.03217615699472054d), new NpgsqlTypes.NpgsqlPoint(x: 0.01744309142434053d, y: 0.4834004797765141d), new NpgsqlTypes.NpgsqlPoint(x: 0.10657613663338117d, y: 0.5593267421856944d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8797470056833407d, y: 0.8669431163944189d), new NpgsqlTypes.NpgsqlPoint(x: 0.5379559802938567d, y: 0.22782677760000236d), new NpgsqlTypes.NpgsqlPoint(x: 0.4773717559990942d, y: 0.2205667229008823d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15570623120540705d, y: 0.3432021394503336d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006606061181954d, y: 0.9585477713284901d), new NpgsqlTypes.NpgsqlPoint(x: 0.8446464551781584d, y: 0.8360539522522721d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4179622908367566d, y: 0.07893803459074111d), new NpgsqlTypes.NpgsqlPoint(x: 0.033807687615099336d, y: 0.8359545177263275d), new NpgsqlTypes.NpgsqlPoint(x: 0.11892851605691535d, y: 0.8445348370192225d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7473335906033316d, y: 0.2042344223081901d), new NpgsqlTypes.NpgsqlPoint(x: 0.4548582894638533d, y: 0.1252989458269993d), new NpgsqlTypes.NpgsqlPoint(x: 0.6653850281360362d, y: 0.7579208755083655d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8831919953326396d, y: 0.08604745180720719d), new NpgsqlTypes.NpgsqlPoint(x: 0.0017800714121021244d, y: 0.2076242463860556d), new NpgsqlTypes.NpgsqlPoint(x: 0.45897858058832086d, y: 0.8427456388031037d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7741324388496834d, y: 0.40533041804759073d), new NpgsqlTypes.NpgsqlPoint(x: 0.42604087134134994d, y: 0.1097934489376391d), new NpgsqlTypes.NpgsqlPoint(x: 0.6419271334409173d, y: 0.49963357280086695d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9032711241628961d, y: 0.04545520984447815d), new NpgsqlTypes.NpgsqlPoint(x: 0.13301032321533235d, y: 0.14058692546932183d), new NpgsqlTypes.NpgsqlPoint(x: 0.21094686481038394d, y: 0.9799669875205849d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5640653415059551d, y: 0.1449476970525958d), new NpgsqlTypes.NpgsqlPoint(x: 0.19860580111381199d, y: 0.6496944770885581d), new NpgsqlTypes.NpgsqlPoint(x: 0.13117666900066016d, y: 0.23921369087350708d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004616616588228095d, y: 0.0916143372120134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5075756930858252d, y: 0.07572103604432412d), new NpgsqlTypes.NpgsqlPoint(x: 0.28030426452565516d, y: 0.7154509320038489d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9077128178938606d, y: 0.5769745545837411d), new NpgsqlTypes.NpgsqlPoint(x: 0.2508386864421557d, y: 0.22770021180922106d), new NpgsqlTypes.NpgsqlPoint(x: 0.7507521608167581d, y: 0.1449060994143344d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4824020041770042d, y: 0.6918815575731556d), new NpgsqlTypes.NpgsqlPoint(x: 0.7405488019726802d, y: 0.02303976007406361d), new NpgsqlTypes.NpgsqlPoint(x: 0.06499703378677024d, y: 0.5004612814664936d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3778957822969651d, y: 0.20919933592836404d), new NpgsqlTypes.NpgsqlPoint(x: 0.7085277448167647d, y: 0.020280084960772937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914942915361836d, y: 0.6191186942448682d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3929600337234047d, y: 0.6185610403394917d), new NpgsqlTypes.NpgsqlPoint(x: 0.2647978992856871d, y: 0.3540806644768373d), new NpgsqlTypes.NpgsqlPoint(x: 0.8853183334471861d, y: 0.8288301544189802d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3112289635523636d, y: 0.2787275269422598d), new NpgsqlTypes.NpgsqlPoint(x: 0.45726360302444535d, y: 0.44202797627071466d), new NpgsqlTypes.NpgsqlPoint(x: 0.5553605068287008d, y: 0.4262567833271297d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6634702848398476d, y: 0.7799709806476066d), new NpgsqlTypes.NpgsqlPoint(x: 0.2656804774225443d, y: 0.9683110299395544d), new NpgsqlTypes.NpgsqlPoint(x: 0.13417091687772964d, y: 0.14466870915834296d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8633758605187435d, y: 0.4798054772091189d), new NpgsqlTypes.NpgsqlPoint(x: 0.768677380749889d, y: 0.6901563590625813d), new NpgsqlTypes.NpgsqlPoint(x: 0.820030358148558d, y: 0.9917499804423594d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.924509739585637d, y: 0.5510192686842618d), new NpgsqlTypes.NpgsqlPoint(x: 0.6048795927686631d, y: 0.27727786304625823d), new NpgsqlTypes.NpgsqlPoint(x: 0.49490132968131784d, y: 0.32368963246854854d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.547529569632948d, y: 0.8085645026678269d), new NpgsqlTypes.NpgsqlPoint(x: 0.19925054861789682d, y: 0.7483745189727816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8295087834651231d, y: 0.07145355142194432d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2923466743101899d, y: 0.8174660769814677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7002794353864168d, y: 0.2891957430316401d), new NpgsqlTypes.NpgsqlPoint(x: 0.4474978330315712d, y: 0.8369323285430913d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3664118131482048d, y: 0.9597307564776142d), new NpgsqlTypes.NpgsqlPoint(x: 0.4739924031939762d, y: 0.8360089576056685d), new NpgsqlTypes.NpgsqlPoint(x: 0.08270751259690412d, y: 0.24964287127015594d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08026068683874243d, y: 0.19688509666111276d), new NpgsqlTypes.NpgsqlPoint(x: 0.12477205322432394d, y: 0.3282684478775537d), new NpgsqlTypes.NpgsqlPoint(x: 0.034638263995604546d, y: 0.43029199810152785d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4836725224410813d, y: 0.3800394866821133d), new NpgsqlTypes.NpgsqlPoint(x: 0.9424598198342655d, y: 0.9498376555755531d), new NpgsqlTypes.NpgsqlPoint(x: 0.8155348145048239d, y: 0.37304096860251845d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4329661354180747d, y: 0.1767602263522794d), new NpgsqlTypes.NpgsqlPoint(x: 0.7504602910062623d, y: 0.6395331847339518d), new NpgsqlTypes.NpgsqlPoint(x: 0.8610086167466685d, y: 0.37391894203827847d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9565355732499767d, y: 0.2634161574124749d), new NpgsqlTypes.NpgsqlPoint(x: 0.1717858642139921d, y: 0.8716092971627981d), new NpgsqlTypes.NpgsqlPoint(x: 0.5114419095190289d, y: 0.6166198220273859d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4598570172673402d, y: 0.4566544269773919d), new NpgsqlTypes.NpgsqlPoint(x: 0.6606050808265586d, y: 0.4732361229627047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5459902156798848d, y: 0.896000177577888d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2267830328115693d, y: 0.45560873091963905d), new NpgsqlTypes.NpgsqlPoint(x: 0.06060821006667716d, y: 0.7531055979213429d), new NpgsqlTypes.NpgsqlPoint(x: 0.9332687548755253d, y: 0.4789122061054035d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19726338432184898d, y: 0.8432034459620456d), new NpgsqlTypes.NpgsqlPoint(x: 0.14125435104116624d, y: 0.9083033537162754d), new NpgsqlTypes.NpgsqlPoint(x: 0.0837901003096787d, y: 0.08389345515150826d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9130032875375367d, y: 0.7165983552494112d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459218788423366d, y: 0.17182108248309091d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601777814117313d, y: 0.30543038216785734d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39146303271561156d, y: 0.8385362664818807d), new NpgsqlTypes.NpgsqlPoint(x: 0.3673303754361047d, y: 0.4491312054346196d), new NpgsqlTypes.NpgsqlPoint(x: 0.46327366090308675d, y: 0.9134255203200176d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45620753445420104d, y: 0.9611005827639819d), new NpgsqlTypes.NpgsqlPoint(x: 0.8852320755765872d, y: 0.8708840511141518d), new NpgsqlTypes.NpgsqlPoint(x: 0.7902314284127995d, y: 0.8355136252487504d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9381211641620327d, y: 0.013937946240825783d), new NpgsqlTypes.NpgsqlPoint(x: 0.20131188568039682d, y: 0.6868468894172061d), new NpgsqlTypes.NpgsqlPoint(x: 0.29160305261608255d, y: 0.4425162531191532d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.867701070355665d, y: 0.24757385823535039d), new NpgsqlTypes.NpgsqlPoint(x: 0.1914441147421142d, y: 0.9734019773497263d), new NpgsqlTypes.NpgsqlPoint(x: 0.4262281341601949d, y: 0.9184465944576597d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9352413488025665d, y: 0.04447304944708619d), new NpgsqlTypes.NpgsqlPoint(x: 0.15412825573359457d, y: 0.5374017678078203d), new NpgsqlTypes.NpgsqlPoint(x: 0.2875869512402143d, y: 0.9369374674626636d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18090159641875225d, y: 0.8613404792690469d), new NpgsqlTypes.NpgsqlPoint(x: 0.4329098498459427d, y: 0.889255622590331d), new NpgsqlTypes.NpgsqlPoint(x: 0.022535479702231465d, y: 0.495664706384107d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023311109350483084d, y: 0.5158693451457479d), new NpgsqlTypes.NpgsqlPoint(x: 0.03640989282665896d, y: 0.0934504969888117d), new NpgsqlTypes.NpgsqlPoint(x: 0.6222829365445652d, y: 0.29720702157749734d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.841591140993543d, y: 0.3235280574426722d), new NpgsqlTypes.NpgsqlPoint(x: 0.2703709753421767d, y: 0.7432631448432386d), new NpgsqlTypes.NpgsqlPoint(x: 0.1902872434858237d, y: 0.15552798565283832d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28971649737379634d, y: 0.3904997694070651d), new NpgsqlTypes.NpgsqlPoint(x: 0.23577693056913795d, y: 0.7484901459508017d), new NpgsqlTypes.NpgsqlPoint(x: 0.3655070228050916d, y: 0.6310783180839051d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7805725599158362d, y: 0.5656191607589431d), new NpgsqlTypes.NpgsqlPoint(x: 0.73295927690743d, y: 0.42957355545496045d), new NpgsqlTypes.NpgsqlPoint(x: 0.9389852834320576d, y: 0.5681524836217413d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8397447952221647d, y: 0.10365545233804074d), new NpgsqlTypes.NpgsqlPoint(x: 0.4502100601708354d, y: 0.11128702388215905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5672915513920247d, y: 0.4636628322671469d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5910853970546351d, y: 0.515931203381598d), new NpgsqlTypes.NpgsqlPoint(x: 0.8326479750896133d, y: 0.692139769217965d), new NpgsqlTypes.NpgsqlPoint(x: 0.051451051578536466d, y: 0.6538727195662664d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3122956827776391d, y: 0.8492724116178998d), new NpgsqlTypes.NpgsqlPoint(x: 0.6180064719786305d, y: 0.6660354446280217d), new NpgsqlTypes.NpgsqlPoint(x: 0.495271283857446d, y: 0.5546370669084665d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30984791395403977d, y: 0.6779800704057478d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455905052146526d, y: 0.9540363890672798d), new NpgsqlTypes.NpgsqlPoint(x: 0.4414520244517316d, y: 0.44937100302693767d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5474504080679743d, y: 0.45168542167854486d), new NpgsqlTypes.NpgsqlPoint(x: 0.22122439856348586d, y: 0.6043697047346658d), new NpgsqlTypes.NpgsqlPoint(x: 0.8605543937101265d, y: 0.4421325554866503d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6876796290812407d, y: 0.8753883525374598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5598721965949993d, y: 0.17615999624078627d), new NpgsqlTypes.NpgsqlPoint(x: 0.8164960059652016d, y: 0.4320659261044343d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9721471469012876d, y: 0.21341518550402994d), new NpgsqlTypes.NpgsqlPoint(x: 0.9063604034931128d, y: 0.8130042082053857d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768655654169926d, y: 0.24625198494261602d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5006026266074064d, y: 0.7139516918797792d), new NpgsqlTypes.NpgsqlPoint(x: 0.38636779913320707d, y: 0.9110940854551145d), new NpgsqlTypes.NpgsqlPoint(x: 0.08248282878072177d, y: 0.9909506225937955d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29404589748929577d, y: 0.8690145852799537d), new NpgsqlTypes.NpgsqlPoint(x: 0.2688690639467973d, y: 0.5488328828379252d), new NpgsqlTypes.NpgsqlPoint(x: 0.22904007604359433d, y: 0.04646969178771265d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8332462143879819d, y: 0.004791265466160044d), new NpgsqlTypes.NpgsqlPoint(x: 0.963632509922484d, y: 0.21685350635149492d), new NpgsqlTypes.NpgsqlPoint(x: 0.8693871525124481d, y: 0.35370044801037925d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6327874634672133d, y: 0.08165261437827853d), new NpgsqlTypes.NpgsqlPoint(x: 0.12076534685819673d, y: 0.36572057799140634d), new NpgsqlTypes.NpgsqlPoint(x: 0.6525363978825514d, y: 0.37498218667036987d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4142982233260434d, y: 0.27364009576364035d), new NpgsqlTypes.NpgsqlPoint(x: 0.5071414756460911d, y: 0.6559172903885476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005248624517464d, y: 0.826196478470684d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3097557364361486d, y: 0.10826072292685018d), new NpgsqlTypes.NpgsqlPoint(x: 0.586404613523174d, y: 0.2388147699244153d), new NpgsqlTypes.NpgsqlPoint(x: 0.6982286226264519d, y: 0.5014331389280692d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6831676978988829d, y: 0.46202936016373186d), new NpgsqlTypes.NpgsqlPoint(x: 0.777662970238455d, y: 0.5102618675791419d), new NpgsqlTypes.NpgsqlPoint(x: 0.1954509662395385d, y: 0.16555476678646153d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09994368616805571d, y: 0.4633682566690297d), new NpgsqlTypes.NpgsqlPoint(x: 0.6044568643755932d, y: 0.11443047029346476d), new NpgsqlTypes.NpgsqlPoint(x: 0.0380906371238483d, y: 0.10800656760521665d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8270166160436334d, y: 0.6952349497675662d), new NpgsqlTypes.NpgsqlPoint(x: 0.10884139732462683d, y: 0.7679345926329243d), new NpgsqlTypes.NpgsqlPoint(x: 0.4002746416074838d, y: 0.49938525922955657d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3752819965064579d, y: 0.48460236873526563d), new NpgsqlTypes.NpgsqlPoint(x: 0.0847034333145047d, y: 0.552568925345496d), new NpgsqlTypes.NpgsqlPoint(x: 0.135930832391306d, y: 0.4320612104243823d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5285473632526854d, y: 0.08404952310100344d), new NpgsqlTypes.NpgsqlPoint(x: 0.8381049548149913d, y: 0.5165974595216279d), new NpgsqlTypes.NpgsqlPoint(x: 0.3319279336284604d, y: 0.17525478973935116d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19901565223744688d, y: 0.8734066879065779d), new NpgsqlTypes.NpgsqlPoint(x: 0.5951738754563279d, y: 0.34543356817108084d), new NpgsqlTypes.NpgsqlPoint(x: 0.3747560426530694d, y: 0.9899775227965778d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.945410449246615d, y: 0.7254551196593959d), new NpgsqlTypes.NpgsqlPoint(x: 0.3236440903909297d, y: 0.4610975470187487d), new NpgsqlTypes.NpgsqlPoint(x: 0.09900754090176012d, y: 0.6575824510388707d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2186237789062393d, y: 0.9954507576899406d), new NpgsqlTypes.NpgsqlPoint(x: 0.2202787184065348d, y: 0.7810207329802742d), new NpgsqlTypes.NpgsqlPoint(x: 0.917449210803613d, y: 0.4853992912844072d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07351141499954017d, y: 0.4089895780720886d), new NpgsqlTypes.NpgsqlPoint(x: 0.6546261711163432d, y: 0.016444589156245804d), new NpgsqlTypes.NpgsqlPoint(x: 0.3866058492501374d, y: 0.12124307576963445d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9129161189426346d, y: 0.17808501391820397d), new NpgsqlTypes.NpgsqlPoint(x: 0.5062763491453598d, y: 0.7526680097878594d), new NpgsqlTypes.NpgsqlPoint(x: 0.36495524920830125d, y: 0.3906482415418159d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24887372165717658d, y: 0.791107028697409d), new NpgsqlTypes.NpgsqlPoint(x: 0.6472672774838304d, y: 0.43123461743635605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8264230551390274d, y: 0.6064789910854302d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8580012799811625d, y: 0.11570404950091229d), new NpgsqlTypes.NpgsqlPoint(x: 0.48284293273189993d, y: 0.3754592831508875d), new NpgsqlTypes.NpgsqlPoint(x: 0.2905058346193883d, y: 0.2577795830085947d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21449287479386892d, y: 0.33361188594393654d), new NpgsqlTypes.NpgsqlPoint(x: 0.9875288443915881d, y: 0.6694122692401028d), new NpgsqlTypes.NpgsqlPoint(x: 0.7732586180370589d, y: 0.9398973251243646d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28045338358918304d, y: 0.03146161234188971d), new NpgsqlTypes.NpgsqlPoint(x: 0.938065341785445d, y: 0.2718867411013559d), new NpgsqlTypes.NpgsqlPoint(x: 0.24403148086253668d, y: 0.2647134255002752d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8579831686086167d, y: 0.12663556537779153d), new NpgsqlTypes.NpgsqlPoint(x: 0.38261002218360785d, y: 0.8178699167767919d), new NpgsqlTypes.NpgsqlPoint(x: 0.7441732745733752d, y: 0.35927481512165504d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6841817966808706d, y: 0.597481384114369d), new NpgsqlTypes.NpgsqlPoint(x: 0.24746079434703105d, y: 0.6790974365438794d), new NpgsqlTypes.NpgsqlPoint(x: 0.7521295598284299d, y: 0.0711158777962747d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4049929759009039d, y: 0.5179909398069369d), new NpgsqlTypes.NpgsqlPoint(x: 0.6256148208424032d, y: 0.5128466820851152d), new NpgsqlTypes.NpgsqlPoint(x: 0.5322794170690085d, y: 0.8963962136322017d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09972565597525551d, y: 0.6257675170112619d), new NpgsqlTypes.NpgsqlPoint(x: 0.9128955428430108d, y: 0.19421793573864776d), new NpgsqlTypes.NpgsqlPoint(x: 0.2010544980392679d, y: 0.5113130581783027d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11062020760349833d, y: 0.45889959905673006d), new NpgsqlTypes.NpgsqlPoint(x: 0.8646082626029323d, y: 0.10400888949825415d), new NpgsqlTypes.NpgsqlPoint(x: 0.02114499874732445d, y: 0.004050946634407082d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9835618330223391d, y: 0.9735459162305533d), new NpgsqlTypes.NpgsqlPoint(x: 0.0956549113658316d, y: 0.6138579565064035d), new NpgsqlTypes.NpgsqlPoint(x: 0.5078050336929228d, y: 0.9763052965534684d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5150283437596459d, y: 0.5073624808812324d), new NpgsqlTypes.NpgsqlPoint(x: 0.8053141943152704d, y: 0.806930451439761d), new NpgsqlTypes.NpgsqlPoint(x: 0.8768962499642772d, y: 0.7511297055672885d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7541742278880105d, y: 0.7272330322482452d), new NpgsqlTypes.NpgsqlPoint(x: 0.7833482352916151d, y: 0.1428938942500928d), new NpgsqlTypes.NpgsqlPoint(x: 0.48802730395102d, y: 0.43201761970842645d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9144561773714802d, y: 0.2982153592589569d), new NpgsqlTypes.NpgsqlPoint(x: 0.44733961621029217d, y: 0.5407116879626205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6222225882710306d, y: 0.6337305693012036d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34257381989267477d, y: 0.21944678380300753d), new NpgsqlTypes.NpgsqlPoint(x: 0.29193337394517205d, y: 0.6300467536999276d), new NpgsqlTypes.NpgsqlPoint(x: 0.9857564900840333d, y: 0.12761578176428034d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09596443816506528d, y: 0.9968297183370644d), new NpgsqlTypes.NpgsqlPoint(x: 0.1682373386928736d, y: 0.6306404305407972d), new NpgsqlTypes.NpgsqlPoint(x: 0.6524150635172279d, y: 0.23227319798430157d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11305797885465818d, y: 0.41334834166034407d), new NpgsqlTypes.NpgsqlPoint(x: 0.30244827513265304d, y: 0.08891090392304568d), new NpgsqlTypes.NpgsqlPoint(x: 0.15919959760289204d, y: 0.34674572372307333d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9496073972812463d, y: 0.64901054633726d), new NpgsqlTypes.NpgsqlPoint(x: 0.3572707158877467d, y: 0.08428325083880606d), new NpgsqlTypes.NpgsqlPoint(x: 0.13431343608838886d, y: 0.022118468286451476d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10025148458534261d, y: 0.7639608641923251d), new NpgsqlTypes.NpgsqlPoint(x: 0.6347101761398819d, y: 0.8463062143015465d), new NpgsqlTypes.NpgsqlPoint(x: 0.25441291023014867d, y: 0.7534436963786628d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21753814548892958d, y: 0.11726180079995596d), new NpgsqlTypes.NpgsqlPoint(x: 0.10539020052774417d, y: 0.21893581678535667d), new NpgsqlTypes.NpgsqlPoint(x: 0.130500907004785d, y: 0.9338954827120401d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3170803809646827d, y: 0.2398651930006357d), new NpgsqlTypes.NpgsqlPoint(x: 0.18932544652924044d, y: 0.44949886621359625d), new NpgsqlTypes.NpgsqlPoint(x: 0.255885210156773d, y: 0.9067756861013118d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5109108189218521d, y: 0.8189770604312077d), new NpgsqlTypes.NpgsqlPoint(x: 0.6027546241887899d, y: 0.15771943893802742d), new NpgsqlTypes.NpgsqlPoint(x: 0.1624781204505681d, y: 0.24728485398917488d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.796275194035364d, y: 0.4216303564333397d), new NpgsqlTypes.NpgsqlPoint(x: 0.6102150662580422d, y: 0.03549101978046265d), new NpgsqlTypes.NpgsqlPoint(x: 0.4893698953102149d, y: 0.19714290350601404d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1720870699781064d, y: 0.3012039205444872d), new NpgsqlTypes.NpgsqlPoint(x: 0.3285844886482777d, y: 0.2083506864257363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9968778022840061d, y: 0.18301527443711485d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7654290285515221d, y: 0.8959301741158977d), new NpgsqlTypes.NpgsqlPoint(x: 0.10348452917116635d, y: 0.2865560030290242d), new NpgsqlTypes.NpgsqlPoint(x: 0.5319717060147744d, y: 0.23027150652172146d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6618584322124622d, y: 0.061151462687183966d), new NpgsqlTypes.NpgsqlPoint(x: 0.3243672641102421d, y: 0.9608062201299524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5872396035035918d, y: 0.8799912228518217d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17801906619982744d, y: 0.4947613846342127d), new NpgsqlTypes.NpgsqlPoint(x: 0.23474888136823568d, y: 0.7039896812362642d), new NpgsqlTypes.NpgsqlPoint(x: 0.3338833253059237d, y: 0.20885530340460323d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.511687356200044d, y: 0.5038583720843763d), new NpgsqlTypes.NpgsqlPoint(x: 0.6906335468777631d, y: 0.8860173545763042d), new NpgsqlTypes.NpgsqlPoint(x: 0.04258820699623833d, y: 0.5542376311568548d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32782039534751606d, y: 0.8601207128972447d), new NpgsqlTypes.NpgsqlPoint(x: 0.36609713151140755d, y: 0.6470851383924272d), new NpgsqlTypes.NpgsqlPoint(x: 0.29178707616005173d, y: 0.9349744090723795d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24487159266705183d, y: 0.6823810730424313d), new NpgsqlTypes.NpgsqlPoint(x: 0.011884776426481225d, y: 0.9269934531421024d), new NpgsqlTypes.NpgsqlPoint(x: 0.7321625762092235d, y: 0.23047658666147208d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21124508054593816d, y: 0.7587245862978151d), new NpgsqlTypes.NpgsqlPoint(x: 0.4280126306604607d, y: 0.3547416857920407d), new NpgsqlTypes.NpgsqlPoint(x: 0.24557586768544837d, y: 0.8766703977411054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.057228629209714166d, y: 0.3692524244810751d), new NpgsqlTypes.NpgsqlPoint(x: 0.619795298648257d, y: 0.19209139588061053d), new NpgsqlTypes.NpgsqlPoint(x: 0.6840905469238553d, y: 0.6405012426577378d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6890198935423579d, y: 0.162593522768667d), new NpgsqlTypes.NpgsqlPoint(x: 0.8896193388329051d, y: 0.5652297268209802d), new NpgsqlTypes.NpgsqlPoint(x: 0.7629294574039043d, y: 0.6455127442465437d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4198402704447709d, y: 0.702343825096773d), new NpgsqlTypes.NpgsqlPoint(x: 0.35217347129847076d, y: 0.5900060678980485d), new NpgsqlTypes.NpgsqlPoint(x: 0.2958209365784279d, y: 0.48634981201403416d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25879783524758027d, y: 0.16937643245423684d), new NpgsqlTypes.NpgsqlPoint(x: 0.26505901548632327d, y: 0.153351479107937d), new NpgsqlTypes.NpgsqlPoint(x: 0.043001947165061005d, y: 0.35167985152124315d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07848831253510247d, y: 0.081706468967083d), new NpgsqlTypes.NpgsqlPoint(x: 0.138306947370624d, y: 0.36507532541729715d), new NpgsqlTypes.NpgsqlPoint(x: 0.3556740389069779d, y: 0.9279500754055866d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9049205065095496d, y: 0.9305884882405683d), new NpgsqlTypes.NpgsqlPoint(x: 0.905136040272977d, y: 0.9134206792469564d), new NpgsqlTypes.NpgsqlPoint(x: 0.579354782999885d, y: 0.8103366310014662d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016902552218920563d, y: 0.6208216223900422d), new NpgsqlTypes.NpgsqlPoint(x: 0.747746804150523d, y: 0.45045640464089376d), new NpgsqlTypes.NpgsqlPoint(x: 0.37098488761240267d, y: 0.7192862880939068d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21811521226400632d, y: 0.8125500555540408d), new NpgsqlTypes.NpgsqlPoint(x: 0.7413349197402936d, y: 0.16006318687020105d), new NpgsqlTypes.NpgsqlPoint(x: 0.8084969217198493d, y: 0.9124423334049169d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42157970124199373d, y: 0.7690737846304393d), new NpgsqlTypes.NpgsqlPoint(x: 0.24642742898796288d, y: 0.6745858444050028d), new NpgsqlTypes.NpgsqlPoint(x: 0.8015448664066401d, y: 0.1962693337104755d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.807898459321729d, y: 0.5818279609031414d), new NpgsqlTypes.NpgsqlPoint(x: 0.09553840917610013d, y: 0.3526649110721949d), new NpgsqlTypes.NpgsqlPoint(x: 0.735145046357406d, y: 0.2341529469324043d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13484474801591617d, y: 0.5162131047775314d), new NpgsqlTypes.NpgsqlPoint(x: 0.5393373891993019d, y: 0.037920834728185415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5940878955107385d, y: 0.911034630901247d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07657414682185781d, y: 0.8377988632529701d), new NpgsqlTypes.NpgsqlPoint(x: 0.2621353322197377d, y: 0.9221866635358492d), new NpgsqlTypes.NpgsqlPoint(x: 0.42360201191782576d, y: 0.5962800320615743d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46442343743685066d, y: 0.8420776764774579d), new NpgsqlTypes.NpgsqlPoint(x: 0.03339504586600417d, y: 0.5742761328396773d), new NpgsqlTypes.NpgsqlPoint(x: 0.849046378200743d, y: 0.36202788261972907d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16909446575043896d, y: 0.347673508845462d), new NpgsqlTypes.NpgsqlPoint(x: 0.8444320711917918d, y: 0.062387595208187596d), new NpgsqlTypes.NpgsqlPoint(x: 0.23004569834774535d, y: 0.2907930897453228d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7426449503921992d, y: 0.5860401092273825d), new NpgsqlTypes.NpgsqlPoint(x: 0.057002054009721914d, y: 0.8426344625395324d), new NpgsqlTypes.NpgsqlPoint(x: 0.47769444464090594d, y: 0.8872017442991974d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11992418497422164d, y: 0.2807007888013683d), new NpgsqlTypes.NpgsqlPoint(x: 0.2178710182217164d, y: 0.6432222508848673d), new NpgsqlTypes.NpgsqlPoint(x: 0.37474566012547883d, y: 0.854035594798258d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3820737753782678d, y: 0.8152451794507665d), new NpgsqlTypes.NpgsqlPoint(x: 0.2534376219940796d, y: 0.7383742017753662d), new NpgsqlTypes.NpgsqlPoint(x: 0.7628141413114303d, y: 0.6866567160528776d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9133269482884591d, y: 0.7020919231253253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5066639201134798d, y: 0.8413325604008343d), new NpgsqlTypes.NpgsqlPoint(x: 0.5608770059186615d, y: 0.23308980237164312d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8510176056408043d, y: 0.09803226409796528d), new NpgsqlTypes.NpgsqlPoint(x: 0.023125173694555468d, y: 0.5228427123433592d), new NpgsqlTypes.NpgsqlPoint(x: 0.34552480296169663d, y: 0.9356908498735226d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06976093678023643d, y: 0.2227406577638481d), new NpgsqlTypes.NpgsqlPoint(x: 0.6881187055171896d, y: 0.4305311700857033d), new NpgsqlTypes.NpgsqlPoint(x: 0.008739368740370623d, y: 0.8784474561158673d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08688946779037388d, y: 0.4387908168309782d), new NpgsqlTypes.NpgsqlPoint(x: 0.8172386548419193d, y: 0.34675551117775716d), new NpgsqlTypes.NpgsqlPoint(x: 0.4895248868709997d, y: 0.9284279882050874d)),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 40;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 23;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 114;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 9, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 86, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 132, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 111, query1, 158, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 132, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 82, query1, 111, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 114, query1, 110, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 90, query1, 21, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 30, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 110, 17))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[32],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[29],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[30],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[31],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[32],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[29],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[30],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[31],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[32],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[33],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray2M),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI), typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                await ((INpgsqlPathListpathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                ((INpgsqlPathListpathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

