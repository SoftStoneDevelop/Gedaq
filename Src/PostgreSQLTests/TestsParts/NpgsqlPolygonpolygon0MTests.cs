

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
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8047318169874136d, y: 0.9652332061725162d), new NpgsqlTypes.NpgsqlPoint(x: 0.06868974328935162d, y: 0.6615021507614237d), new NpgsqlTypes.NpgsqlPoint(x: 0.21857728484981698d, y: 0.6548984287266749d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005390488088714007d, y: 0.23806297201068483d), new NpgsqlTypes.NpgsqlPoint(x: 0.5665953854377828d, y: 0.8944886322092398d), new NpgsqlTypes.NpgsqlPoint(x: 0.48480928402386336d, y: 0.9216982822641056d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.843395444333835d, y: 0.6935563385387999d), new NpgsqlTypes.NpgsqlPoint(x: 0.5866132936126232d, y: 0.26289822065254564d), new NpgsqlTypes.NpgsqlPoint(x: 0.7191529900165857d, y: 0.6911838792690815d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1754864054195674d, y: 0.10474453650820337d), new NpgsqlTypes.NpgsqlPoint(x: 0.9793649792602974d, y: 0.33149352924305d), new NpgsqlTypes.NpgsqlPoint(x: 0.35492127171132615d, y: 0.21952600403129363d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25874979975318035d, y: 0.8894222427272966d), new NpgsqlTypes.NpgsqlPoint(x: 0.6738044683975749d, y: 0.9873006569522662d), new NpgsqlTypes.NpgsqlPoint(x: 0.0859456432569734d, y: 0.8295995318398927d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1511708624486442d, y: 0.5401815110208702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6093479438040512d, y: 0.6846625045216972d), new NpgsqlTypes.NpgsqlPoint(x: 0.33086070057660233d, y: 0.4605766946827904d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.90718389626049d, y: 0.08754341360075335d), new NpgsqlTypes.NpgsqlPoint(x: 0.3279856886865251d, y: 0.7885311759458478d), new NpgsqlTypes.NpgsqlPoint(x: 0.25411024510171876d, y: 0.4358753395739039d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1797135398148595d, y: 0.5402342495355057d), new NpgsqlTypes.NpgsqlPoint(x: 0.22616553693660868d, y: 0.2813114569558052d), new NpgsqlTypes.NpgsqlPoint(x: 0.20255410200374224d, y: 0.06511101423587828d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8344508049289302d, y: 0.6583468235545337d), new NpgsqlTypes.NpgsqlPoint(x: 0.7345319439463264d, y: 0.27616336804187136d), new NpgsqlTypes.NpgsqlPoint(x: 0.9577366337786654d, y: 0.8755253751869605d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7988262994524109d, y: 0.7965040397706398d), new NpgsqlTypes.NpgsqlPoint(x: 0.0017216251839493601d, y: 0.5309670502123425d), new NpgsqlTypes.NpgsqlPoint(x: 0.45246093534959386d, y: 0.009234917576889323d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13614860856702682d, y: 0.6373918430042269d), new NpgsqlTypes.NpgsqlPoint(x: 0.9246981521090122d, y: 0.766399506653715d), new NpgsqlTypes.NpgsqlPoint(x: 0.4512481402352717d, y: 0.5508831565167738d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5993718598031076d, y: 0.49704692996985533d), new NpgsqlTypes.NpgsqlPoint(x: 0.29580798125406504d, y: 0.6661828196827883d), new NpgsqlTypes.NpgsqlPoint(x: 0.32898641373495896d, y: 0.3233564953606294d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2156881777775579d, y: 0.24270492744977135d), new NpgsqlTypes.NpgsqlPoint(x: 0.24911305407855155d, y: 0.5628381108227547d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435838983622986d, y: 0.2818902637982743d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18008056683509344d, y: 0.7830738562113044d), new NpgsqlTypes.NpgsqlPoint(x: 0.85370045432723d, y: 0.5976613790302233d), new NpgsqlTypes.NpgsqlPoint(x: 0.26109848228273547d, y: 0.9641606001889134d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27902966927975903d, y: 0.4410910173867567d), new NpgsqlTypes.NpgsqlPoint(x: 0.5985333022987941d, y: 0.22592766737939074d), new NpgsqlTypes.NpgsqlPoint(x: 0.25597489151028086d, y: 0.27082338175560106d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19285453870891567d, y: 0.6607846308683272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5994309745439126d, y: 0.31943231641127645d), new NpgsqlTypes.NpgsqlPoint(x: 0.23686552711020603d, y: 0.5548093760843767d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5794307653357281d, y: 0.4486487584485427d), new NpgsqlTypes.NpgsqlPoint(x: 0.013099923738627006d, y: 0.9448006419163942d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905083160289752d, y: 0.4132861146344686d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9505087288774706d, y: 0.5264271607622313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7433423726601948d, y: 0.7289308337521256d), new NpgsqlTypes.NpgsqlPoint(x: 0.387369403184772d, y: 0.8958017421167838d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7120596645153948d, y: 0.7735995001800926d), new NpgsqlTypes.NpgsqlPoint(x: 0.928576821887469d, y: 0.751723233302685d), new NpgsqlTypes.NpgsqlPoint(x: 0.19297259650301057d, y: 0.9385269609084839d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2341046107152569d, y: 0.4151683090644759d), new NpgsqlTypes.NpgsqlPoint(x: 0.6062599131583737d, y: 0.6905176779323241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9300218344249932d, y: 0.4133632604201878d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9453622400102438d, y: 0.7355589568312271d), new NpgsqlTypes.NpgsqlPoint(x: 0.40426881640817247d, y: 0.6205673407259251d), new NpgsqlTypes.NpgsqlPoint(x: 0.9002468545150123d, y: 0.7148856039455157d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8267210641040879d, y: 0.0011933155671126627d), new NpgsqlTypes.NpgsqlPoint(x: 0.30068028524171875d, y: 0.689840364073271d), new NpgsqlTypes.NpgsqlPoint(x: 0.40012976646233545d, y: 0.005123135945775514d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7327187857785897d, y: 0.6052670577809555d), new NpgsqlTypes.NpgsqlPoint(x: 0.40536523644100964d, y: 0.6788073833469864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280073238465647d, y: 0.2874203240834502d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.549442364917599d, y: 0.9690809889232141d), new NpgsqlTypes.NpgsqlPoint(x: 0.46813948555262475d, y: 0.6213744823983631d), new NpgsqlTypes.NpgsqlPoint(x: 0.3645186926748847d, y: 0.7561240319771707d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9966884377030152d, y: 0.405536937810425d), new NpgsqlTypes.NpgsqlPoint(x: 0.27809467433412227d, y: 0.6661209817381801d), new NpgsqlTypes.NpgsqlPoint(x: 0.29414589798308666d, y: 0.45641426732697743d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6325582233984689d, y: 0.37016001540733834d), new NpgsqlTypes.NpgsqlPoint(x: 0.9310901389480833d, y: 0.5239557670640705d), new NpgsqlTypes.NpgsqlPoint(x: 0.30635513438542183d, y: 0.20430397394568045d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9129869039856442d, y: 0.4552596804930208d), new NpgsqlTypes.NpgsqlPoint(x: 0.642198991677157d, y: 0.2695468664844276d), new NpgsqlTypes.NpgsqlPoint(x: 0.1473026026346138d, y: 0.7706534717194589d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8299870593711285d, y: 0.7886763233920958d), new NpgsqlTypes.NpgsqlPoint(x: 0.44530428379482734d, y: 0.21540085570408118d), new NpgsqlTypes.NpgsqlPoint(x: 0.7954372038452494d, y: 0.1478259482003249d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12173942793934556d, y: 0.9085895743732512d), new NpgsqlTypes.NpgsqlPoint(x: 0.7395217330358964d, y: 0.7439308135258258d), new NpgsqlTypes.NpgsqlPoint(x: 0.18332889395610985d, y: 0.23966936194642074d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09761979732753656d, y: 0.18546077984682896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7158311106330629d, y: 0.49112952435325063d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286305658147453d, y: 0.1269854182186566d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25537082118724175d, y: 0.4178289630189146d), new NpgsqlTypes.NpgsqlPoint(x: 0.02285991641072349d, y: 0.790626601293975d), new NpgsqlTypes.NpgsqlPoint(x: 0.30603752099314474d, y: 0.10409179593500872d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8631356480533037d, y: 0.27047715737057454d), new NpgsqlTypes.NpgsqlPoint(x: 0.07712942095860054d, y: 0.048486871195060566d), new NpgsqlTypes.NpgsqlPoint(x: 0.7895954445910938d, y: 0.5132581125101021d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4983527712161637d, y: 0.7837411261861715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5049925005218281d, y: 0.22258593818438388d), new NpgsqlTypes.NpgsqlPoint(x: 0.808190444133804d, y: 0.14275451470685896d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9168101316743966d, y: 0.9121921116434428d), new NpgsqlTypes.NpgsqlPoint(x: 0.281759573322676d, y: 0.6636055180959277d), new NpgsqlTypes.NpgsqlPoint(x: 0.99495092625065d, y: 0.25330429959736633d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15940442874741345d, y: 0.5427844434971547d), new NpgsqlTypes.NpgsqlPoint(x: 0.2713705398430444d, y: 0.9965321181353147d), new NpgsqlTypes.NpgsqlPoint(x: 0.24207274607595142d, y: 0.5604767637073703d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7981380868667722d, y: 0.31405070483830944d), new NpgsqlTypes.NpgsqlPoint(x: 0.7765924904024847d, y: 0.5278445353524246d), new NpgsqlTypes.NpgsqlPoint(x: 0.42684977687412173d, y: 0.5352536929526437d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7906362910758238d, y: 0.10373023289275674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8251753957645085d, y: 0.8557570315586439d), new NpgsqlTypes.NpgsqlPoint(x: 0.2624016382968555d, y: 0.19700279687269007d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39631275348242867d, y: 0.9584679268348079d), new NpgsqlTypes.NpgsqlPoint(x: 0.5100980394155595d, y: 0.09179163115194489d), new NpgsqlTypes.NpgsqlPoint(x: 0.7129847882462402d, y: 0.3133015010033555d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7781936636006825d, y: 0.8075794512823d), new NpgsqlTypes.NpgsqlPoint(x: 0.8334844865788792d, y: 0.43990673325944374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9031359899518484d, y: 0.22671067139362844d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5982428155569757d, y: 0.7042328484525121d), new NpgsqlTypes.NpgsqlPoint(x: 0.2107277710376927d, y: 0.6041566579613782d), new NpgsqlTypes.NpgsqlPoint(x: 0.5347298583854928d, y: 0.01874005745296492d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28509543769797585d, y: 0.5883669307710381d), new NpgsqlTypes.NpgsqlPoint(x: 0.5896284968432569d, y: 0.08349003912072805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8288217250706906d, y: 0.6238728117136345d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44401953995209476d, y: 0.632466052160996d), new NpgsqlTypes.NpgsqlPoint(x: 0.37686075419191256d, y: 0.30448657126338763d), new NpgsqlTypes.NpgsqlPoint(x: 0.8169404424843193d, y: 0.4601874718223017d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6138279972197956d, y: 0.8416945486340524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9050626835788821d, y: 0.13087102025527309d), new NpgsqlTypes.NpgsqlPoint(x: 0.08254587096355614d, y: 0.2628830854676022d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5662234628770697d, y: 0.9524817296789395d), new NpgsqlTypes.NpgsqlPoint(x: 0.7397605552333721d, y: 0.8892764418096515d), new NpgsqlTypes.NpgsqlPoint(x: 0.26685913343861234d, y: 0.13155989028110282d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9612171807953999d, y: 0.28968451267468587d), new NpgsqlTypes.NpgsqlPoint(x: 0.17611939613355299d, y: 0.9868818357967754d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832623238680716d, y: 0.6864926003762668d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11223427883931825d, y: 0.3578058594795883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7150575970747208d, y: 0.004260615770263709d), new NpgsqlTypes.NpgsqlPoint(x: 0.2455632206327354d, y: 0.14762269960451124d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13321136121809407d, y: 0.2280473106687898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7995491207056156d, y: 0.8436498336164527d), new NpgsqlTypes.NpgsqlPoint(x: 0.38075236508923627d, y: 0.7557606442000487d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0389991706639089d, y: 0.9845853365634543d), new NpgsqlTypes.NpgsqlPoint(x: 0.8462805533349969d, y: 0.91833076616165d), new NpgsqlTypes.NpgsqlPoint(x: 0.9646539926692603d, y: 0.0736864717593656d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13447214481079817d, y: 0.3809803570635323d), new NpgsqlTypes.NpgsqlPoint(x: 0.4856988116338957d, y: 0.10479234272703453d), new NpgsqlTypes.NpgsqlPoint(x: 0.04598284884899606d, y: 0.30716538782718106d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2109897759581778d, y: 0.5834248812079155d), new NpgsqlTypes.NpgsqlPoint(x: 0.7149249273731936d, y: 0.6228690826926363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9106219141331887d, y: 0.7335701432826255d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10630485521797384d, y: 0.8533406082726898d), new NpgsqlTypes.NpgsqlPoint(x: 0.31255377108566673d, y: 0.6044066837798193d), new NpgsqlTypes.NpgsqlPoint(x: 0.5629217384985168d, y: 0.4656044828219643d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7047436889507489d, y: 0.4563555994895747d), new NpgsqlTypes.NpgsqlPoint(x: 0.3367273506679477d, y: 0.8681168910060177d), new NpgsqlTypes.NpgsqlPoint(x: 0.5037385566293162d, y: 0.7322385393448853d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40369511412161685d, y: 0.011078790011653794d), new NpgsqlTypes.NpgsqlPoint(x: 0.3679250345908588d, y: 0.9814489245464625d), new NpgsqlTypes.NpgsqlPoint(x: 0.5913884273593785d, y: 0.9354175472712845d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41667873912087505d, y: 0.17341509361711838d), new NpgsqlTypes.NpgsqlPoint(x: 0.5001548690386384d, y: 0.6965372167259853d), new NpgsqlTypes.NpgsqlPoint(x: 0.7179387239423215d, y: 0.7301753745624542d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44915171019185807d, y: 0.9254764645601699d), new NpgsqlTypes.NpgsqlPoint(x: 0.07451747239176798d, y: 0.4685542284215848d), new NpgsqlTypes.NpgsqlPoint(x: 0.4807137963871917d, y: 0.43218859957539224d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6897891374779426d, y: 0.4541831059639746d), new NpgsqlTypes.NpgsqlPoint(x: 0.7771471197713464d, y: 0.6775440218192557d), new NpgsqlTypes.NpgsqlPoint(x: 0.4418448035646263d, y: 0.5988577156853899d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3209942562941096d, y: 0.0435704129069896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7567985641294183d, y: 0.5948800705436701d), new NpgsqlTypes.NpgsqlPoint(x: 0.19701608535882964d, y: 0.39064604952540205d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7875639456220467d, y: 0.5735150315195261d), new NpgsqlTypes.NpgsqlPoint(x: 0.24359573363540643d, y: 0.2866459030598999d), new NpgsqlTypes.NpgsqlPoint(x: 0.3768863065721306d, y: 0.8962465589203599d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9346308559516238d, y: 0.33801909101253313d), new NpgsqlTypes.NpgsqlPoint(x: 0.37689206780592754d, y: 0.9895538936740255d), new NpgsqlTypes.NpgsqlPoint(x: 0.7539501763895488d, y: 0.3549828303339323d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4710265869192767d, y: 0.5165735588107181d), new NpgsqlTypes.NpgsqlPoint(x: 0.9816323402488034d, y: 0.3050907502308636d), new NpgsqlTypes.NpgsqlPoint(x: 0.07788702992021246d, y: 0.9710120642445011d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4751522028630609d, y: 0.5672220429909719d), new NpgsqlTypes.NpgsqlPoint(x: 0.33208718744568255d, y: 0.04977148742477966d), new NpgsqlTypes.NpgsqlPoint(x: 0.3008161144111854d, y: 0.7031612075063396d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8542630706299713d, y: 0.1871468145815811d), new NpgsqlTypes.NpgsqlPoint(x: 0.9540039634350403d, y: 0.8654542824212096d), new NpgsqlTypes.NpgsqlPoint(x: 0.27825507609900146d, y: 0.7607569356920465d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.011386422769950832d, y: 0.7168744191072972d), new NpgsqlTypes.NpgsqlPoint(x: 0.8064044575732439d, y: 0.951655836906835d), new NpgsqlTypes.NpgsqlPoint(x: 0.06632453516188874d, y: 0.14901724810690342d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5787812911031522d, y: 0.6766096510688082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223948967502261d, y: 0.2048496956326189d), new NpgsqlTypes.NpgsqlPoint(x: 0.39216496013402025d, y: 0.3226365676696854d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7046204684169807d, y: 0.3820307468367615d), new NpgsqlTypes.NpgsqlPoint(x: 0.03938107351192899d, y: 0.5986743901662293d), new NpgsqlTypes.NpgsqlPoint(x: 0.3205683713948918d, y: 0.8601510503289016d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3736443042312707d, y: 0.16749460569320196d), new NpgsqlTypes.NpgsqlPoint(x: 0.7407881806436186d, y: 0.7586071353871808d), new NpgsqlTypes.NpgsqlPoint(x: 0.8934417411273322d, y: 0.8160206355048935d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20392895771694353d, y: 0.7480075880271363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9157324835892472d, y: 0.9203133194737882d), new NpgsqlTypes.NpgsqlPoint(x: 0.27559405283068106d, y: 0.7470852508934176d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8245678947722775d, y: 0.16737079014549983d), new NpgsqlTypes.NpgsqlPoint(x: 0.15013388851266796d, y: 0.47651203601733594d), new NpgsqlTypes.NpgsqlPoint(x: 0.5016212188501301d, y: 0.4716286229396358d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3821353591127432d, y: 0.07192137489109407d), new NpgsqlTypes.NpgsqlPoint(x: 0.20577749680968493d, y: 0.4794782617032679d), new NpgsqlTypes.NpgsqlPoint(x: 0.39256060066169496d, y: 0.06138977101085363d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7233328674933157d, y: 0.4944285904210365d), new NpgsqlTypes.NpgsqlPoint(x: 0.43036017276779304d, y: 0.4617755203421703d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005011317546262939d, y: 0.26694200644729793d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 166,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8534424937894731d, y: 0.08739605330393063d), new NpgsqlTypes.NpgsqlPoint(x: 0.9273139259616452d, y: 0.8159073236681046d), new NpgsqlTypes.NpgsqlPoint(x: 0.22910924719926096d, y: 0.4559104072013528d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8019988819888805d, y: 0.48612439875891744d), new NpgsqlTypes.NpgsqlPoint(x: 0.29942488492978225d, y: 0.31128181041924685d), new NpgsqlTypes.NpgsqlPoint(x: 0.6808009558945887d, y: 0.997853109816777d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8541758574694438d, y: 0.035892062338324426d), new NpgsqlTypes.NpgsqlPoint(x: 0.003147126389919652d, y: 0.2150925947817236d), new NpgsqlTypes.NpgsqlPoint(x: 0.5459779176972263d, y: 0.5495038451360013d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006238692859262485d, y: 0.09266868418028662d), new NpgsqlTypes.NpgsqlPoint(x: 0.19156493738773728d, y: 0.04897648030715529d), new NpgsqlTypes.NpgsqlPoint(x: 0.18110153619186853d, y: 0.09584186319560029d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 168,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9781615645007286d, y: 0.8878646903909151d), new NpgsqlTypes.NpgsqlPoint(x: 0.08347027690199116d, y: 0.21296936176386738d), new NpgsqlTypes.NpgsqlPoint(x: 0.09457111783561634d, y: 0.4502236687257427d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21764308963415746d, y: 0.2780342192053079d), new NpgsqlTypes.NpgsqlPoint(x: 0.49218868986365816d, y: 0.12289460787268813d), new NpgsqlTypes.NpgsqlPoint(x: 0.6418084249356325d, y: 0.22743111976749764d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 175,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.049160451432308405d, y: 0.7078383602488174d), new NpgsqlTypes.NpgsqlPoint(x: 0.1352091323153033d, y: 0.5319746725029523d), new NpgsqlTypes.NpgsqlPoint(x: 0.6994020339079421d, y: 0.4080482735536294d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9740972079520268d, y: 0.7309085061986234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8869128388159023d, y: 0.5154645903002667d), new NpgsqlTypes.NpgsqlPoint(x: 0.24785038014214344d, y: 0.8197334756365375d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 178,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32408563625424314d, y: 0.4848337256538665d), new NpgsqlTypes.NpgsqlPoint(x: 0.4876211785444775d, y: 0.8495910576779546d), new NpgsqlTypes.NpgsqlPoint(x: 0.026631822176449882d, y: 0.7708602959815353d)),
    ModelInner = null,
    NullableValue = null,
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5993718598031076d, y: 0.49704692996985533d), new NpgsqlTypes.NpgsqlPoint(x: 0.29580798125406504d, y: 0.6661828196827883d), new NpgsqlTypes.NpgsqlPoint(x: 0.32898641373495896d, y: 0.3233564953606294d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27902966927975903d, y: 0.4410910173867567d), new NpgsqlTypes.NpgsqlPoint(x: 0.5985333022987941d, y: 0.22592766737939074d), new NpgsqlTypes.NpgsqlPoint(x: 0.25597489151028086d, y: 0.27082338175560106d))));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2341046107152569d, y: 0.4151683090644759d), new NpgsqlTypes.NpgsqlPoint(x: 0.6062599131583737d, y: 0.6905176779323241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9300218344249932d, y: 0.4133632604201878d))));
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.549442364917599d, y: 0.9690809889232141d), new NpgsqlTypes.NpgsqlPoint(x: 0.46813948555262475d, y: 0.6213744823983631d), new NpgsqlTypes.NpgsqlPoint(x: 0.3645186926748847d, y: 0.7561240319771707d))));
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[34], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[34], false);
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[34], false);
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 67, query1, 166, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[34], false);
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 141, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 50, query1, 166, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[34], false);
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 135, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[29],_testData[34], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 6, query1, 162, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 135, query1, 92, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 30, query1, 100, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 122, query1, 145, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[34], false);
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 47, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 50, 154))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[34], false);
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
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 50);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[30], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[31], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[32], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[33], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 166);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[32], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[33], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8047318169874136d, y: 0.9652332061725162d), new NpgsqlTypes.NpgsqlPoint(x: 0.06868974328935162d, y: 0.6615021507614237d), new NpgsqlTypes.NpgsqlPoint(x: 0.21857728484981698d, y: 0.6548984287266749d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005390488088714007d, y: 0.23806297201068483d), new NpgsqlTypes.NpgsqlPoint(x: 0.5665953854377828d, y: 0.8944886322092398d), new NpgsqlTypes.NpgsqlPoint(x: 0.48480928402386336d, y: 0.9216982822641056d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.843395444333835d, y: 0.6935563385387999d), new NpgsqlTypes.NpgsqlPoint(x: 0.5866132936126232d, y: 0.26289822065254564d), new NpgsqlTypes.NpgsqlPoint(x: 0.7191529900165857d, y: 0.6911838792690815d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1754864054195674d, y: 0.10474453650820337d), new NpgsqlTypes.NpgsqlPoint(x: 0.9793649792602974d, y: 0.33149352924305d), new NpgsqlTypes.NpgsqlPoint(x: 0.35492127171132615d, y: 0.21952600403129363d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25874979975318035d, y: 0.8894222427272966d), new NpgsqlTypes.NpgsqlPoint(x: 0.6738044683975749d, y: 0.9873006569522662d), new NpgsqlTypes.NpgsqlPoint(x: 0.0859456432569734d, y: 0.8295995318398927d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1511708624486442d, y: 0.5401815110208702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6093479438040512d, y: 0.6846625045216972d), new NpgsqlTypes.NpgsqlPoint(x: 0.33086070057660233d, y: 0.4605766946827904d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.90718389626049d, y: 0.08754341360075335d), new NpgsqlTypes.NpgsqlPoint(x: 0.3279856886865251d, y: 0.7885311759458478d), new NpgsqlTypes.NpgsqlPoint(x: 0.25411024510171876d, y: 0.4358753395739039d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1797135398148595d, y: 0.5402342495355057d), new NpgsqlTypes.NpgsqlPoint(x: 0.22616553693660868d, y: 0.2813114569558052d), new NpgsqlTypes.NpgsqlPoint(x: 0.20255410200374224d, y: 0.06511101423587828d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8344508049289302d, y: 0.6583468235545337d), new NpgsqlTypes.NpgsqlPoint(x: 0.7345319439463264d, y: 0.27616336804187136d), new NpgsqlTypes.NpgsqlPoint(x: 0.9577366337786654d, y: 0.8755253751869605d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7988262994524109d, y: 0.7965040397706398d), new NpgsqlTypes.NpgsqlPoint(x: 0.0017216251839493601d, y: 0.5309670502123425d), new NpgsqlTypes.NpgsqlPoint(x: 0.45246093534959386d, y: 0.009234917576889323d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13614860856702682d, y: 0.6373918430042269d), new NpgsqlTypes.NpgsqlPoint(x: 0.9246981521090122d, y: 0.766399506653715d), new NpgsqlTypes.NpgsqlPoint(x: 0.4512481402352717d, y: 0.5508831565167738d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5993718598031076d, y: 0.49704692996985533d), new NpgsqlTypes.NpgsqlPoint(x: 0.29580798125406504d, y: 0.6661828196827883d), new NpgsqlTypes.NpgsqlPoint(x: 0.32898641373495896d, y: 0.3233564953606294d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2156881777775579d, y: 0.24270492744977135d), new NpgsqlTypes.NpgsqlPoint(x: 0.24911305407855155d, y: 0.5628381108227547d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435838983622986d, y: 0.2818902637982743d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18008056683509344d, y: 0.7830738562113044d), new NpgsqlTypes.NpgsqlPoint(x: 0.85370045432723d, y: 0.5976613790302233d), new NpgsqlTypes.NpgsqlPoint(x: 0.26109848228273547d, y: 0.9641606001889134d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27902966927975903d, y: 0.4410910173867567d), new NpgsqlTypes.NpgsqlPoint(x: 0.5985333022987941d, y: 0.22592766737939074d), new NpgsqlTypes.NpgsqlPoint(x: 0.25597489151028086d, y: 0.27082338175560106d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19285453870891567d, y: 0.6607846308683272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5994309745439126d, y: 0.31943231641127645d), new NpgsqlTypes.NpgsqlPoint(x: 0.23686552711020603d, y: 0.5548093760843767d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5794307653357281d, y: 0.4486487584485427d), new NpgsqlTypes.NpgsqlPoint(x: 0.013099923738627006d, y: 0.9448006419163942d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905083160289752d, y: 0.4132861146344686d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9505087288774706d, y: 0.5264271607622313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7433423726601948d, y: 0.7289308337521256d), new NpgsqlTypes.NpgsqlPoint(x: 0.387369403184772d, y: 0.8958017421167838d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7120596645153948d, y: 0.7735995001800926d), new NpgsqlTypes.NpgsqlPoint(x: 0.928576821887469d, y: 0.751723233302685d), new NpgsqlTypes.NpgsqlPoint(x: 0.19297259650301057d, y: 0.9385269609084839d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2341046107152569d, y: 0.4151683090644759d), new NpgsqlTypes.NpgsqlPoint(x: 0.6062599131583737d, y: 0.6905176779323241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9300218344249932d, y: 0.4133632604201878d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9453622400102438d, y: 0.7355589568312271d), new NpgsqlTypes.NpgsqlPoint(x: 0.40426881640817247d, y: 0.6205673407259251d), new NpgsqlTypes.NpgsqlPoint(x: 0.9002468545150123d, y: 0.7148856039455157d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8267210641040879d, y: 0.0011933155671126627d), new NpgsqlTypes.NpgsqlPoint(x: 0.30068028524171875d, y: 0.689840364073271d), new NpgsqlTypes.NpgsqlPoint(x: 0.40012976646233545d, y: 0.005123135945775514d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7327187857785897d, y: 0.6052670577809555d), new NpgsqlTypes.NpgsqlPoint(x: 0.40536523644100964d, y: 0.6788073833469864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280073238465647d, y: 0.2874203240834502d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.549442364917599d, y: 0.9690809889232141d), new NpgsqlTypes.NpgsqlPoint(x: 0.46813948555262475d, y: 0.6213744823983631d), new NpgsqlTypes.NpgsqlPoint(x: 0.3645186926748847d, y: 0.7561240319771707d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9966884377030152d, y: 0.405536937810425d), new NpgsqlTypes.NpgsqlPoint(x: 0.27809467433412227d, y: 0.6661209817381801d), new NpgsqlTypes.NpgsqlPoint(x: 0.29414589798308666d, y: 0.45641426732697743d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6325582233984689d, y: 0.37016001540733834d), new NpgsqlTypes.NpgsqlPoint(x: 0.9310901389480833d, y: 0.5239557670640705d), new NpgsqlTypes.NpgsqlPoint(x: 0.30635513438542183d, y: 0.20430397394568045d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9129869039856442d, y: 0.4552596804930208d), new NpgsqlTypes.NpgsqlPoint(x: 0.642198991677157d, y: 0.2695468664844276d), new NpgsqlTypes.NpgsqlPoint(x: 0.1473026026346138d, y: 0.7706534717194589d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8299870593711285d, y: 0.7886763233920958d), new NpgsqlTypes.NpgsqlPoint(x: 0.44530428379482734d, y: 0.21540085570408118d), new NpgsqlTypes.NpgsqlPoint(x: 0.7954372038452494d, y: 0.1478259482003249d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12173942793934556d, y: 0.9085895743732512d), new NpgsqlTypes.NpgsqlPoint(x: 0.7395217330358964d, y: 0.7439308135258258d), new NpgsqlTypes.NpgsqlPoint(x: 0.18332889395610985d, y: 0.23966936194642074d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09761979732753656d, y: 0.18546077984682896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7158311106330629d, y: 0.49112952435325063d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286305658147453d, y: 0.1269854182186566d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25537082118724175d, y: 0.4178289630189146d), new NpgsqlTypes.NpgsqlPoint(x: 0.02285991641072349d, y: 0.790626601293975d), new NpgsqlTypes.NpgsqlPoint(x: 0.30603752099314474d, y: 0.10409179593500872d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8631356480533037d, y: 0.27047715737057454d), new NpgsqlTypes.NpgsqlPoint(x: 0.07712942095860054d, y: 0.048486871195060566d), new NpgsqlTypes.NpgsqlPoint(x: 0.7895954445910938d, y: 0.5132581125101021d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4983527712161637d, y: 0.7837411261861715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5049925005218281d, y: 0.22258593818438388d), new NpgsqlTypes.NpgsqlPoint(x: 0.808190444133804d, y: 0.14275451470685896d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9168101316743966d, y: 0.9121921116434428d), new NpgsqlTypes.NpgsqlPoint(x: 0.281759573322676d, y: 0.6636055180959277d), new NpgsqlTypes.NpgsqlPoint(x: 0.99495092625065d, y: 0.25330429959736633d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15940442874741345d, y: 0.5427844434971547d), new NpgsqlTypes.NpgsqlPoint(x: 0.2713705398430444d, y: 0.9965321181353147d), new NpgsqlTypes.NpgsqlPoint(x: 0.24207274607595142d, y: 0.5604767637073703d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7981380868667722d, y: 0.31405070483830944d), new NpgsqlTypes.NpgsqlPoint(x: 0.7765924904024847d, y: 0.5278445353524246d), new NpgsqlTypes.NpgsqlPoint(x: 0.42684977687412173d, y: 0.5352536929526437d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7906362910758238d, y: 0.10373023289275674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8251753957645085d, y: 0.8557570315586439d), new NpgsqlTypes.NpgsqlPoint(x: 0.2624016382968555d, y: 0.19700279687269007d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39631275348242867d, y: 0.9584679268348079d), new NpgsqlTypes.NpgsqlPoint(x: 0.5100980394155595d, y: 0.09179163115194489d), new NpgsqlTypes.NpgsqlPoint(x: 0.7129847882462402d, y: 0.3133015010033555d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7781936636006825d, y: 0.8075794512823d), new NpgsqlTypes.NpgsqlPoint(x: 0.8334844865788792d, y: 0.43990673325944374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9031359899518484d, y: 0.22671067139362844d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5982428155569757d, y: 0.7042328484525121d), new NpgsqlTypes.NpgsqlPoint(x: 0.2107277710376927d, y: 0.6041566579613782d), new NpgsqlTypes.NpgsqlPoint(x: 0.5347298583854928d, y: 0.01874005745296492d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28509543769797585d, y: 0.5883669307710381d), new NpgsqlTypes.NpgsqlPoint(x: 0.5896284968432569d, y: 0.08349003912072805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8288217250706906d, y: 0.6238728117136345d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44401953995209476d, y: 0.632466052160996d), new NpgsqlTypes.NpgsqlPoint(x: 0.37686075419191256d, y: 0.30448657126338763d), new NpgsqlTypes.NpgsqlPoint(x: 0.8169404424843193d, y: 0.4601874718223017d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6138279972197956d, y: 0.8416945486340524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9050626835788821d, y: 0.13087102025527309d), new NpgsqlTypes.NpgsqlPoint(x: 0.08254587096355614d, y: 0.2628830854676022d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5662234628770697d, y: 0.9524817296789395d), new NpgsqlTypes.NpgsqlPoint(x: 0.7397605552333721d, y: 0.8892764418096515d), new NpgsqlTypes.NpgsqlPoint(x: 0.26685913343861234d, y: 0.13155989028110282d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9612171807953999d, y: 0.28968451267468587d), new NpgsqlTypes.NpgsqlPoint(x: 0.17611939613355299d, y: 0.9868818357967754d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832623238680716d, y: 0.6864926003762668d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11223427883931825d, y: 0.3578058594795883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7150575970747208d, y: 0.004260615770263709d), new NpgsqlTypes.NpgsqlPoint(x: 0.2455632206327354d, y: 0.14762269960451124d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13321136121809407d, y: 0.2280473106687898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7995491207056156d, y: 0.8436498336164527d), new NpgsqlTypes.NpgsqlPoint(x: 0.38075236508923627d, y: 0.7557606442000487d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0389991706639089d, y: 0.9845853365634543d), new NpgsqlTypes.NpgsqlPoint(x: 0.8462805533349969d, y: 0.91833076616165d), new NpgsqlTypes.NpgsqlPoint(x: 0.9646539926692603d, y: 0.0736864717593656d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13447214481079817d, y: 0.3809803570635323d), new NpgsqlTypes.NpgsqlPoint(x: 0.4856988116338957d, y: 0.10479234272703453d), new NpgsqlTypes.NpgsqlPoint(x: 0.04598284884899606d, y: 0.30716538782718106d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2109897759581778d, y: 0.5834248812079155d), new NpgsqlTypes.NpgsqlPoint(x: 0.7149249273731936d, y: 0.6228690826926363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9106219141331887d, y: 0.7335701432826255d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10630485521797384d, y: 0.8533406082726898d), new NpgsqlTypes.NpgsqlPoint(x: 0.31255377108566673d, y: 0.6044066837798193d), new NpgsqlTypes.NpgsqlPoint(x: 0.5629217384985168d, y: 0.4656044828219643d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7047436889507489d, y: 0.4563555994895747d), new NpgsqlTypes.NpgsqlPoint(x: 0.3367273506679477d, y: 0.8681168910060177d), new NpgsqlTypes.NpgsqlPoint(x: 0.5037385566293162d, y: 0.7322385393448853d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40369511412161685d, y: 0.011078790011653794d), new NpgsqlTypes.NpgsqlPoint(x: 0.3679250345908588d, y: 0.9814489245464625d), new NpgsqlTypes.NpgsqlPoint(x: 0.5913884273593785d, y: 0.9354175472712845d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41667873912087505d, y: 0.17341509361711838d), new NpgsqlTypes.NpgsqlPoint(x: 0.5001548690386384d, y: 0.6965372167259853d), new NpgsqlTypes.NpgsqlPoint(x: 0.7179387239423215d, y: 0.7301753745624542d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44915171019185807d, y: 0.9254764645601699d), new NpgsqlTypes.NpgsqlPoint(x: 0.07451747239176798d, y: 0.4685542284215848d), new NpgsqlTypes.NpgsqlPoint(x: 0.4807137963871917d, y: 0.43218859957539224d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6897891374779426d, y: 0.4541831059639746d), new NpgsqlTypes.NpgsqlPoint(x: 0.7771471197713464d, y: 0.6775440218192557d), new NpgsqlTypes.NpgsqlPoint(x: 0.4418448035646263d, y: 0.5988577156853899d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3209942562941096d, y: 0.0435704129069896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7567985641294183d, y: 0.5948800705436701d), new NpgsqlTypes.NpgsqlPoint(x: 0.19701608535882964d, y: 0.39064604952540205d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7875639456220467d, y: 0.5735150315195261d), new NpgsqlTypes.NpgsqlPoint(x: 0.24359573363540643d, y: 0.2866459030598999d), new NpgsqlTypes.NpgsqlPoint(x: 0.3768863065721306d, y: 0.8962465589203599d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9346308559516238d, y: 0.33801909101253313d), new NpgsqlTypes.NpgsqlPoint(x: 0.37689206780592754d, y: 0.9895538936740255d), new NpgsqlTypes.NpgsqlPoint(x: 0.7539501763895488d, y: 0.3549828303339323d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4710265869192767d, y: 0.5165735588107181d), new NpgsqlTypes.NpgsqlPoint(x: 0.9816323402488034d, y: 0.3050907502308636d), new NpgsqlTypes.NpgsqlPoint(x: 0.07788702992021246d, y: 0.9710120642445011d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4751522028630609d, y: 0.5672220429909719d), new NpgsqlTypes.NpgsqlPoint(x: 0.33208718744568255d, y: 0.04977148742477966d), new NpgsqlTypes.NpgsqlPoint(x: 0.3008161144111854d, y: 0.7031612075063396d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8542630706299713d, y: 0.1871468145815811d), new NpgsqlTypes.NpgsqlPoint(x: 0.9540039634350403d, y: 0.8654542824212096d), new NpgsqlTypes.NpgsqlPoint(x: 0.27825507609900146d, y: 0.7607569356920465d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.011386422769950832d, y: 0.7168744191072972d), new NpgsqlTypes.NpgsqlPoint(x: 0.8064044575732439d, y: 0.951655836906835d), new NpgsqlTypes.NpgsqlPoint(x: 0.06632453516188874d, y: 0.14901724810690342d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5787812911031522d, y: 0.6766096510688082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223948967502261d, y: 0.2048496956326189d), new NpgsqlTypes.NpgsqlPoint(x: 0.39216496013402025d, y: 0.3226365676696854d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7046204684169807d, y: 0.3820307468367615d), new NpgsqlTypes.NpgsqlPoint(x: 0.03938107351192899d, y: 0.5986743901662293d), new NpgsqlTypes.NpgsqlPoint(x: 0.3205683713948918d, y: 0.8601510503289016d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3736443042312707d, y: 0.16749460569320196d), new NpgsqlTypes.NpgsqlPoint(x: 0.7407881806436186d, y: 0.7586071353871808d), new NpgsqlTypes.NpgsqlPoint(x: 0.8934417411273322d, y: 0.8160206355048935d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20392895771694353d, y: 0.7480075880271363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9157324835892472d, y: 0.9203133194737882d), new NpgsqlTypes.NpgsqlPoint(x: 0.27559405283068106d, y: 0.7470852508934176d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8245678947722775d, y: 0.16737079014549983d), new NpgsqlTypes.NpgsqlPoint(x: 0.15013388851266796d, y: 0.47651203601733594d), new NpgsqlTypes.NpgsqlPoint(x: 0.5016212188501301d, y: 0.4716286229396358d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3821353591127432d, y: 0.07192137489109407d), new NpgsqlTypes.NpgsqlPoint(x: 0.20577749680968493d, y: 0.4794782617032679d), new NpgsqlTypes.NpgsqlPoint(x: 0.39256060066169496d, y: 0.06138977101085363d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7233328674933157d, y: 0.4944285904210365d), new NpgsqlTypes.NpgsqlPoint(x: 0.43036017276779304d, y: 0.4617755203421703d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005011317546262939d, y: 0.26694200644729793d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8534424937894731d, y: 0.08739605330393063d), new NpgsqlTypes.NpgsqlPoint(x: 0.9273139259616452d, y: 0.8159073236681046d), new NpgsqlTypes.NpgsqlPoint(x: 0.22910924719926096d, y: 0.4559104072013528d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8019988819888805d, y: 0.48612439875891744d), new NpgsqlTypes.NpgsqlPoint(x: 0.29942488492978225d, y: 0.31128181041924685d), new NpgsqlTypes.NpgsqlPoint(x: 0.6808009558945887d, y: 0.997853109816777d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8541758574694438d, y: 0.035892062338324426d), new NpgsqlTypes.NpgsqlPoint(x: 0.003147126389919652d, y: 0.2150925947817236d), new NpgsqlTypes.NpgsqlPoint(x: 0.5459779176972263d, y: 0.5495038451360013d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006238692859262485d, y: 0.09266868418028662d), new NpgsqlTypes.NpgsqlPoint(x: 0.19156493738773728d, y: 0.04897648030715529d), new NpgsqlTypes.NpgsqlPoint(x: 0.18110153619186853d, y: 0.09584186319560029d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9781615645007286d, y: 0.8878646903909151d), new NpgsqlTypes.NpgsqlPoint(x: 0.08347027690199116d, y: 0.21296936176386738d), new NpgsqlTypes.NpgsqlPoint(x: 0.09457111783561634d, y: 0.4502236687257427d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21764308963415746d, y: 0.2780342192053079d), new NpgsqlTypes.NpgsqlPoint(x: 0.49218868986365816d, y: 0.12289460787268813d), new NpgsqlTypes.NpgsqlPoint(x: 0.6418084249356325d, y: 0.22743111976749764d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.049160451432308405d, y: 0.7078383602488174d), new NpgsqlTypes.NpgsqlPoint(x: 0.1352091323153033d, y: 0.5319746725029523d), new NpgsqlTypes.NpgsqlPoint(x: 0.6994020339079421d, y: 0.4080482735536294d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9740972079520268d, y: 0.7309085061986234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8869128388159023d, y: 0.5154645903002667d), new NpgsqlTypes.NpgsqlPoint(x: 0.24785038014214344d, y: 0.8197334756365375d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32408563625424314d, y: 0.4848337256538665d), new NpgsqlTypes.NpgsqlPoint(x: 0.4876211785444775d, y: 0.8495910576779546d), new NpgsqlTypes.NpgsqlPoint(x: 0.026631822176449882d, y: 0.7708602959815353d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8047318169874136d, y: 0.9652332061725162d), new NpgsqlTypes.NpgsqlPoint(x: 0.06868974328935162d, y: 0.6615021507614237d), new NpgsqlTypes.NpgsqlPoint(x: 0.21857728484981698d, y: 0.6548984287266749d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005390488088714007d, y: 0.23806297201068483d), new NpgsqlTypes.NpgsqlPoint(x: 0.5665953854377828d, y: 0.8944886322092398d), new NpgsqlTypes.NpgsqlPoint(x: 0.48480928402386336d, y: 0.9216982822641056d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.843395444333835d, y: 0.6935563385387999d), new NpgsqlTypes.NpgsqlPoint(x: 0.5866132936126232d, y: 0.26289822065254564d), new NpgsqlTypes.NpgsqlPoint(x: 0.7191529900165857d, y: 0.6911838792690815d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1754864054195674d, y: 0.10474453650820337d), new NpgsqlTypes.NpgsqlPoint(x: 0.9793649792602974d, y: 0.33149352924305d), new NpgsqlTypes.NpgsqlPoint(x: 0.35492127171132615d, y: 0.21952600403129363d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25874979975318035d, y: 0.8894222427272966d), new NpgsqlTypes.NpgsqlPoint(x: 0.6738044683975749d, y: 0.9873006569522662d), new NpgsqlTypes.NpgsqlPoint(x: 0.0859456432569734d, y: 0.8295995318398927d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1511708624486442d, y: 0.5401815110208702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6093479438040512d, y: 0.6846625045216972d), new NpgsqlTypes.NpgsqlPoint(x: 0.33086070057660233d, y: 0.4605766946827904d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.90718389626049d, y: 0.08754341360075335d), new NpgsqlTypes.NpgsqlPoint(x: 0.3279856886865251d, y: 0.7885311759458478d), new NpgsqlTypes.NpgsqlPoint(x: 0.25411024510171876d, y: 0.4358753395739039d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1797135398148595d, y: 0.5402342495355057d), new NpgsqlTypes.NpgsqlPoint(x: 0.22616553693660868d, y: 0.2813114569558052d), new NpgsqlTypes.NpgsqlPoint(x: 0.20255410200374224d, y: 0.06511101423587828d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8344508049289302d, y: 0.6583468235545337d), new NpgsqlTypes.NpgsqlPoint(x: 0.7345319439463264d, y: 0.27616336804187136d), new NpgsqlTypes.NpgsqlPoint(x: 0.9577366337786654d, y: 0.8755253751869605d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7988262994524109d, y: 0.7965040397706398d), new NpgsqlTypes.NpgsqlPoint(x: 0.0017216251839493601d, y: 0.5309670502123425d), new NpgsqlTypes.NpgsqlPoint(x: 0.45246093534959386d, y: 0.009234917576889323d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13614860856702682d, y: 0.6373918430042269d), new NpgsqlTypes.NpgsqlPoint(x: 0.9246981521090122d, y: 0.766399506653715d), new NpgsqlTypes.NpgsqlPoint(x: 0.4512481402352717d, y: 0.5508831565167738d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5993718598031076d, y: 0.49704692996985533d), new NpgsqlTypes.NpgsqlPoint(x: 0.29580798125406504d, y: 0.6661828196827883d), new NpgsqlTypes.NpgsqlPoint(x: 0.32898641373495896d, y: 0.3233564953606294d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2156881777775579d, y: 0.24270492744977135d), new NpgsqlTypes.NpgsqlPoint(x: 0.24911305407855155d, y: 0.5628381108227547d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435838983622986d, y: 0.2818902637982743d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18008056683509344d, y: 0.7830738562113044d), new NpgsqlTypes.NpgsqlPoint(x: 0.85370045432723d, y: 0.5976613790302233d), new NpgsqlTypes.NpgsqlPoint(x: 0.26109848228273547d, y: 0.9641606001889134d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27902966927975903d, y: 0.4410910173867567d), new NpgsqlTypes.NpgsqlPoint(x: 0.5985333022987941d, y: 0.22592766737939074d), new NpgsqlTypes.NpgsqlPoint(x: 0.25597489151028086d, y: 0.27082338175560106d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19285453870891567d, y: 0.6607846308683272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5994309745439126d, y: 0.31943231641127645d), new NpgsqlTypes.NpgsqlPoint(x: 0.23686552711020603d, y: 0.5548093760843767d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5794307653357281d, y: 0.4486487584485427d), new NpgsqlTypes.NpgsqlPoint(x: 0.013099923738627006d, y: 0.9448006419163942d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905083160289752d, y: 0.4132861146344686d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9505087288774706d, y: 0.5264271607622313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7433423726601948d, y: 0.7289308337521256d), new NpgsqlTypes.NpgsqlPoint(x: 0.387369403184772d, y: 0.8958017421167838d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7120596645153948d, y: 0.7735995001800926d), new NpgsqlTypes.NpgsqlPoint(x: 0.928576821887469d, y: 0.751723233302685d), new NpgsqlTypes.NpgsqlPoint(x: 0.19297259650301057d, y: 0.9385269609084839d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2341046107152569d, y: 0.4151683090644759d), new NpgsqlTypes.NpgsqlPoint(x: 0.6062599131583737d, y: 0.6905176779323241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9300218344249932d, y: 0.4133632604201878d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9453622400102438d, y: 0.7355589568312271d), new NpgsqlTypes.NpgsqlPoint(x: 0.40426881640817247d, y: 0.6205673407259251d), new NpgsqlTypes.NpgsqlPoint(x: 0.9002468545150123d, y: 0.7148856039455157d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8267210641040879d, y: 0.0011933155671126627d), new NpgsqlTypes.NpgsqlPoint(x: 0.30068028524171875d, y: 0.689840364073271d), new NpgsqlTypes.NpgsqlPoint(x: 0.40012976646233545d, y: 0.005123135945775514d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7327187857785897d, y: 0.6052670577809555d), new NpgsqlTypes.NpgsqlPoint(x: 0.40536523644100964d, y: 0.6788073833469864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280073238465647d, y: 0.2874203240834502d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.549442364917599d, y: 0.9690809889232141d), new NpgsqlTypes.NpgsqlPoint(x: 0.46813948555262475d, y: 0.6213744823983631d), new NpgsqlTypes.NpgsqlPoint(x: 0.3645186926748847d, y: 0.7561240319771707d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9966884377030152d, y: 0.405536937810425d), new NpgsqlTypes.NpgsqlPoint(x: 0.27809467433412227d, y: 0.6661209817381801d), new NpgsqlTypes.NpgsqlPoint(x: 0.29414589798308666d, y: 0.45641426732697743d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6325582233984689d, y: 0.37016001540733834d), new NpgsqlTypes.NpgsqlPoint(x: 0.9310901389480833d, y: 0.5239557670640705d), new NpgsqlTypes.NpgsqlPoint(x: 0.30635513438542183d, y: 0.20430397394568045d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9129869039856442d, y: 0.4552596804930208d), new NpgsqlTypes.NpgsqlPoint(x: 0.642198991677157d, y: 0.2695468664844276d), new NpgsqlTypes.NpgsqlPoint(x: 0.1473026026346138d, y: 0.7706534717194589d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8299870593711285d, y: 0.7886763233920958d), new NpgsqlTypes.NpgsqlPoint(x: 0.44530428379482734d, y: 0.21540085570408118d), new NpgsqlTypes.NpgsqlPoint(x: 0.7954372038452494d, y: 0.1478259482003249d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12173942793934556d, y: 0.9085895743732512d), new NpgsqlTypes.NpgsqlPoint(x: 0.7395217330358964d, y: 0.7439308135258258d), new NpgsqlTypes.NpgsqlPoint(x: 0.18332889395610985d, y: 0.23966936194642074d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09761979732753656d, y: 0.18546077984682896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7158311106330629d, y: 0.49112952435325063d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286305658147453d, y: 0.1269854182186566d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25537082118724175d, y: 0.4178289630189146d), new NpgsqlTypes.NpgsqlPoint(x: 0.02285991641072349d, y: 0.790626601293975d), new NpgsqlTypes.NpgsqlPoint(x: 0.30603752099314474d, y: 0.10409179593500872d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8631356480533037d, y: 0.27047715737057454d), new NpgsqlTypes.NpgsqlPoint(x: 0.07712942095860054d, y: 0.048486871195060566d), new NpgsqlTypes.NpgsqlPoint(x: 0.7895954445910938d, y: 0.5132581125101021d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4983527712161637d, y: 0.7837411261861715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5049925005218281d, y: 0.22258593818438388d), new NpgsqlTypes.NpgsqlPoint(x: 0.808190444133804d, y: 0.14275451470685896d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9168101316743966d, y: 0.9121921116434428d), new NpgsqlTypes.NpgsqlPoint(x: 0.281759573322676d, y: 0.6636055180959277d), new NpgsqlTypes.NpgsqlPoint(x: 0.99495092625065d, y: 0.25330429959736633d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15940442874741345d, y: 0.5427844434971547d), new NpgsqlTypes.NpgsqlPoint(x: 0.2713705398430444d, y: 0.9965321181353147d), new NpgsqlTypes.NpgsqlPoint(x: 0.24207274607595142d, y: 0.5604767637073703d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7981380868667722d, y: 0.31405070483830944d), new NpgsqlTypes.NpgsqlPoint(x: 0.7765924904024847d, y: 0.5278445353524246d), new NpgsqlTypes.NpgsqlPoint(x: 0.42684977687412173d, y: 0.5352536929526437d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7906362910758238d, y: 0.10373023289275674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8251753957645085d, y: 0.8557570315586439d), new NpgsqlTypes.NpgsqlPoint(x: 0.2624016382968555d, y: 0.19700279687269007d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39631275348242867d, y: 0.9584679268348079d), new NpgsqlTypes.NpgsqlPoint(x: 0.5100980394155595d, y: 0.09179163115194489d), new NpgsqlTypes.NpgsqlPoint(x: 0.7129847882462402d, y: 0.3133015010033555d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7781936636006825d, y: 0.8075794512823d), new NpgsqlTypes.NpgsqlPoint(x: 0.8334844865788792d, y: 0.43990673325944374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9031359899518484d, y: 0.22671067139362844d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5982428155569757d, y: 0.7042328484525121d), new NpgsqlTypes.NpgsqlPoint(x: 0.2107277710376927d, y: 0.6041566579613782d), new NpgsqlTypes.NpgsqlPoint(x: 0.5347298583854928d, y: 0.01874005745296492d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28509543769797585d, y: 0.5883669307710381d), new NpgsqlTypes.NpgsqlPoint(x: 0.5896284968432569d, y: 0.08349003912072805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8288217250706906d, y: 0.6238728117136345d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44401953995209476d, y: 0.632466052160996d), new NpgsqlTypes.NpgsqlPoint(x: 0.37686075419191256d, y: 0.30448657126338763d), new NpgsqlTypes.NpgsqlPoint(x: 0.8169404424843193d, y: 0.4601874718223017d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6138279972197956d, y: 0.8416945486340524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9050626835788821d, y: 0.13087102025527309d), new NpgsqlTypes.NpgsqlPoint(x: 0.08254587096355614d, y: 0.2628830854676022d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5662234628770697d, y: 0.9524817296789395d), new NpgsqlTypes.NpgsqlPoint(x: 0.7397605552333721d, y: 0.8892764418096515d), new NpgsqlTypes.NpgsqlPoint(x: 0.26685913343861234d, y: 0.13155989028110282d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9612171807953999d, y: 0.28968451267468587d), new NpgsqlTypes.NpgsqlPoint(x: 0.17611939613355299d, y: 0.9868818357967754d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832623238680716d, y: 0.6864926003762668d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11223427883931825d, y: 0.3578058594795883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7150575970747208d, y: 0.004260615770263709d), new NpgsqlTypes.NpgsqlPoint(x: 0.2455632206327354d, y: 0.14762269960451124d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13321136121809407d, y: 0.2280473106687898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7995491207056156d, y: 0.8436498336164527d), new NpgsqlTypes.NpgsqlPoint(x: 0.38075236508923627d, y: 0.7557606442000487d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0389991706639089d, y: 0.9845853365634543d), new NpgsqlTypes.NpgsqlPoint(x: 0.8462805533349969d, y: 0.91833076616165d), new NpgsqlTypes.NpgsqlPoint(x: 0.9646539926692603d, y: 0.0736864717593656d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13447214481079817d, y: 0.3809803570635323d), new NpgsqlTypes.NpgsqlPoint(x: 0.4856988116338957d, y: 0.10479234272703453d), new NpgsqlTypes.NpgsqlPoint(x: 0.04598284884899606d, y: 0.30716538782718106d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2109897759581778d, y: 0.5834248812079155d), new NpgsqlTypes.NpgsqlPoint(x: 0.7149249273731936d, y: 0.6228690826926363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9106219141331887d, y: 0.7335701432826255d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10630485521797384d, y: 0.8533406082726898d), new NpgsqlTypes.NpgsqlPoint(x: 0.31255377108566673d, y: 0.6044066837798193d), new NpgsqlTypes.NpgsqlPoint(x: 0.5629217384985168d, y: 0.4656044828219643d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7047436889507489d, y: 0.4563555994895747d), new NpgsqlTypes.NpgsqlPoint(x: 0.3367273506679477d, y: 0.8681168910060177d), new NpgsqlTypes.NpgsqlPoint(x: 0.5037385566293162d, y: 0.7322385393448853d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40369511412161685d, y: 0.011078790011653794d), new NpgsqlTypes.NpgsqlPoint(x: 0.3679250345908588d, y: 0.9814489245464625d), new NpgsqlTypes.NpgsqlPoint(x: 0.5913884273593785d, y: 0.9354175472712845d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41667873912087505d, y: 0.17341509361711838d), new NpgsqlTypes.NpgsqlPoint(x: 0.5001548690386384d, y: 0.6965372167259853d), new NpgsqlTypes.NpgsqlPoint(x: 0.7179387239423215d, y: 0.7301753745624542d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44915171019185807d, y: 0.9254764645601699d), new NpgsqlTypes.NpgsqlPoint(x: 0.07451747239176798d, y: 0.4685542284215848d), new NpgsqlTypes.NpgsqlPoint(x: 0.4807137963871917d, y: 0.43218859957539224d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6897891374779426d, y: 0.4541831059639746d), new NpgsqlTypes.NpgsqlPoint(x: 0.7771471197713464d, y: 0.6775440218192557d), new NpgsqlTypes.NpgsqlPoint(x: 0.4418448035646263d, y: 0.5988577156853899d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3209942562941096d, y: 0.0435704129069896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7567985641294183d, y: 0.5948800705436701d), new NpgsqlTypes.NpgsqlPoint(x: 0.19701608535882964d, y: 0.39064604952540205d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7875639456220467d, y: 0.5735150315195261d), new NpgsqlTypes.NpgsqlPoint(x: 0.24359573363540643d, y: 0.2866459030598999d), new NpgsqlTypes.NpgsqlPoint(x: 0.3768863065721306d, y: 0.8962465589203599d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9346308559516238d, y: 0.33801909101253313d), new NpgsqlTypes.NpgsqlPoint(x: 0.37689206780592754d, y: 0.9895538936740255d), new NpgsqlTypes.NpgsqlPoint(x: 0.7539501763895488d, y: 0.3549828303339323d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4710265869192767d, y: 0.5165735588107181d), new NpgsqlTypes.NpgsqlPoint(x: 0.9816323402488034d, y: 0.3050907502308636d), new NpgsqlTypes.NpgsqlPoint(x: 0.07788702992021246d, y: 0.9710120642445011d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4751522028630609d, y: 0.5672220429909719d), new NpgsqlTypes.NpgsqlPoint(x: 0.33208718744568255d, y: 0.04977148742477966d), new NpgsqlTypes.NpgsqlPoint(x: 0.3008161144111854d, y: 0.7031612075063396d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8542630706299713d, y: 0.1871468145815811d), new NpgsqlTypes.NpgsqlPoint(x: 0.9540039634350403d, y: 0.8654542824212096d), new NpgsqlTypes.NpgsqlPoint(x: 0.27825507609900146d, y: 0.7607569356920465d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.011386422769950832d, y: 0.7168744191072972d), new NpgsqlTypes.NpgsqlPoint(x: 0.8064044575732439d, y: 0.951655836906835d), new NpgsqlTypes.NpgsqlPoint(x: 0.06632453516188874d, y: 0.14901724810690342d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5787812911031522d, y: 0.6766096510688082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223948967502261d, y: 0.2048496956326189d), new NpgsqlTypes.NpgsqlPoint(x: 0.39216496013402025d, y: 0.3226365676696854d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7046204684169807d, y: 0.3820307468367615d), new NpgsqlTypes.NpgsqlPoint(x: 0.03938107351192899d, y: 0.5986743901662293d), new NpgsqlTypes.NpgsqlPoint(x: 0.3205683713948918d, y: 0.8601510503289016d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3736443042312707d, y: 0.16749460569320196d), new NpgsqlTypes.NpgsqlPoint(x: 0.7407881806436186d, y: 0.7586071353871808d), new NpgsqlTypes.NpgsqlPoint(x: 0.8934417411273322d, y: 0.8160206355048935d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20392895771694353d, y: 0.7480075880271363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9157324835892472d, y: 0.9203133194737882d), new NpgsqlTypes.NpgsqlPoint(x: 0.27559405283068106d, y: 0.7470852508934176d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8245678947722775d, y: 0.16737079014549983d), new NpgsqlTypes.NpgsqlPoint(x: 0.15013388851266796d, y: 0.47651203601733594d), new NpgsqlTypes.NpgsqlPoint(x: 0.5016212188501301d, y: 0.4716286229396358d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3821353591127432d, y: 0.07192137489109407d), new NpgsqlTypes.NpgsqlPoint(x: 0.20577749680968493d, y: 0.4794782617032679d), new NpgsqlTypes.NpgsqlPoint(x: 0.39256060066169496d, y: 0.06138977101085363d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7233328674933157d, y: 0.4944285904210365d), new NpgsqlTypes.NpgsqlPoint(x: 0.43036017276779304d, y: 0.4617755203421703d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005011317546262939d, y: 0.26694200644729793d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8534424937894731d, y: 0.08739605330393063d), new NpgsqlTypes.NpgsqlPoint(x: 0.9273139259616452d, y: 0.8159073236681046d), new NpgsqlTypes.NpgsqlPoint(x: 0.22910924719926096d, y: 0.4559104072013528d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8019988819888805d, y: 0.48612439875891744d), new NpgsqlTypes.NpgsqlPoint(x: 0.29942488492978225d, y: 0.31128181041924685d), new NpgsqlTypes.NpgsqlPoint(x: 0.6808009558945887d, y: 0.997853109816777d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8541758574694438d, y: 0.035892062338324426d), new NpgsqlTypes.NpgsqlPoint(x: 0.003147126389919652d, y: 0.2150925947817236d), new NpgsqlTypes.NpgsqlPoint(x: 0.5459779176972263d, y: 0.5495038451360013d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006238692859262485d, y: 0.09266868418028662d), new NpgsqlTypes.NpgsqlPoint(x: 0.19156493738773728d, y: 0.04897648030715529d), new NpgsqlTypes.NpgsqlPoint(x: 0.18110153619186853d, y: 0.09584186319560029d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9781615645007286d, y: 0.8878646903909151d), new NpgsqlTypes.NpgsqlPoint(x: 0.08347027690199116d, y: 0.21296936176386738d), new NpgsqlTypes.NpgsqlPoint(x: 0.09457111783561634d, y: 0.4502236687257427d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21764308963415746d, y: 0.2780342192053079d), new NpgsqlTypes.NpgsqlPoint(x: 0.49218868986365816d, y: 0.12289460787268813d), new NpgsqlTypes.NpgsqlPoint(x: 0.6418084249356325d, y: 0.22743111976749764d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.049160451432308405d, y: 0.7078383602488174d), new NpgsqlTypes.NpgsqlPoint(x: 0.1352091323153033d, y: 0.5319746725029523d), new NpgsqlTypes.NpgsqlPoint(x: 0.6994020339079421d, y: 0.4080482735536294d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9740972079520268d, y: 0.7309085061986234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8869128388159023d, y: 0.5154645903002667d), new NpgsqlTypes.NpgsqlPoint(x: 0.24785038014214344d, y: 0.8197334756365375d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32408563625424314d, y: 0.4848337256538665d), new NpgsqlTypes.NpgsqlPoint(x: 0.4876211785444775d, y: 0.8495910576779546d), new NpgsqlTypes.NpgsqlPoint(x: 0.026631822176449882d, y: 0.7708602959815353d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlPolygonpolygon0M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI), typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

