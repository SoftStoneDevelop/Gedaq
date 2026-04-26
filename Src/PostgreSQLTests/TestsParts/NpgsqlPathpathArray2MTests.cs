

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8793001786195687d, y: 0.019376004395019852d), new NpgsqlTypes.NpgsqlPoint(x: 0.44397391404011344d, y: 0.7028799589528898d), new NpgsqlTypes.NpgsqlPoint(x: 0.5242248446769133d, y: 0.10097189033291298d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8629924967326632d, y: 0.23352331740560173d), new NpgsqlTypes.NpgsqlPoint(x: 0.32495536759355337d, y: 0.05436069776259511d), new NpgsqlTypes.NpgsqlPoint(x: 0.08387920748925803d, y: 0.6446807748727442d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3151758988519193d, y: 0.7989753865304591d), new NpgsqlTypes.NpgsqlPoint(x: 0.02438733492493328d, y: 0.17682221943651566d), new NpgsqlTypes.NpgsqlPoint(x: 0.3147001805769629d, y: 0.8351571453565154d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6000139124556761d, y: 0.1819187309917536d), new NpgsqlTypes.NpgsqlPoint(x: 0.36992555981072106d, y: 0.0005642961533954827d), new NpgsqlTypes.NpgsqlPoint(x: 0.2585396391872621d, y: 0.03673078323135748d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7242074374166931d, y: 0.011378852081580848d), new NpgsqlTypes.NpgsqlPoint(x: 0.6727697098249019d, y: 0.8344781807254219d), new NpgsqlTypes.NpgsqlPoint(x: 0.35064868687889594d, y: 0.5782609071368495d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5015409790129763d, y: 0.24733920741779236d), new NpgsqlTypes.NpgsqlPoint(x: 0.8071797932315553d, y: 0.1197693639303723d), new NpgsqlTypes.NpgsqlPoint(x: 0.5496997883573325d, y: 0.2851368799647137d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3254398082622939d, y: 0.6945973916962386d), new NpgsqlTypes.NpgsqlPoint(x: 0.05759509540416241d, y: 0.4497144436451437d), new NpgsqlTypes.NpgsqlPoint(x: 0.41267182842951255d, y: 0.6470717559063273d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4632325165774357d, y: 0.265062899212128d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564708161426297d, y: 0.10487705053845997d), new NpgsqlTypes.NpgsqlPoint(x: 0.3664182417389553d, y: 0.9793516198664736d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9353819883842052d, y: 0.5717092027544323d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304223441187286d, y: 0.8774243320374496d), new NpgsqlTypes.NpgsqlPoint(x: 0.22778388736115307d, y: 0.5582462912971967d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20160729526671084d, y: 0.46169716777548087d), new NpgsqlTypes.NpgsqlPoint(x: 0.9977838474127853d, y: 0.5779971747136862d), new NpgsqlTypes.NpgsqlPoint(x: 0.17046452197898987d, y: 0.35600892651447746d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2921404328576622d, y: 0.4131006457915818d), new NpgsqlTypes.NpgsqlPoint(x: 0.5954753952769863d, y: 0.03373112758008201d), new NpgsqlTypes.NpgsqlPoint(x: 0.004353087785160192d, y: 0.35850885150489675d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21598149504107422d, y: 0.6682744885300272d), new NpgsqlTypes.NpgsqlPoint(x: 0.8866398039630002d, y: 0.45244635568027103d), new NpgsqlTypes.NpgsqlPoint(x: 0.3510691426259337d, y: 0.8688292042648388d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1578270839255913d, y: 0.9217539264524919d), new NpgsqlTypes.NpgsqlPoint(x: 0.0008466763904851904d, y: 0.24995704685000508d), new NpgsqlTypes.NpgsqlPoint(x: 0.050955257980029534d, y: 0.4784380397583803d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8577280340712103d, y: 0.7842112153199454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4836722885091791d, y: 0.08359853388652838d), new NpgsqlTypes.NpgsqlPoint(x: 0.5436093891207915d, y: 0.06657758212784337d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6731024719481458d, y: 0.708393159626535d), new NpgsqlTypes.NpgsqlPoint(x: 0.7975450410919862d, y: 0.9992742237115784d), new NpgsqlTypes.NpgsqlPoint(x: 0.3707891297498075d, y: 0.04688138291466104d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8894323308679938d, y: 0.3514695798050451d), new NpgsqlTypes.NpgsqlPoint(x: 0.9337078828243891d, y: 0.18679421970634158d), new NpgsqlTypes.NpgsqlPoint(x: 0.5903457474209546d, y: 0.21171932022260842d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07451333517387759d, y: 0.24505103740618317d), new NpgsqlTypes.NpgsqlPoint(x: 0.4821878077994781d, y: 0.5702895508094407d), new NpgsqlTypes.NpgsqlPoint(x: 0.217400096330448d, y: 0.48998596856007537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31904141445083145d, y: 0.8550009036740494d), new NpgsqlTypes.NpgsqlPoint(x: 0.6134195953684846d, y: 0.590914067801561d), new NpgsqlTypes.NpgsqlPoint(x: 0.05676407571019659d, y: 0.1852721675135509d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07783478137449884d, y: 0.5796263697296287d), new NpgsqlTypes.NpgsqlPoint(x: 0.8878665902674864d, y: 0.6325621943765232d), new NpgsqlTypes.NpgsqlPoint(x: 0.9202204890833976d, y: 0.33636434024448314d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7929133391584537d, y: 0.3352648039188577d), new NpgsqlTypes.NpgsqlPoint(x: 0.7049195450639741d, y: 0.807904646369211d), new NpgsqlTypes.NpgsqlPoint(x: 0.050987193204079184d, y: 0.04008714156604842d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8891805548514671d, y: 0.7059327366751819d), new NpgsqlTypes.NpgsqlPoint(x: 0.6667327757012406d, y: 0.13948671588363482d), new NpgsqlTypes.NpgsqlPoint(x: 0.4402095981351768d, y: 0.5114986565380064d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5198837897295282d, y: 0.1328621255879976d), new NpgsqlTypes.NpgsqlPoint(x: 0.21656791225027305d, y: 0.5836672391630237d), new NpgsqlTypes.NpgsqlPoint(x: 0.1916109403207844d, y: 0.6449256139066153d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6613890208490545d, y: 0.29956124372787685d), new NpgsqlTypes.NpgsqlPoint(x: 0.40207910934284674d, y: 0.9242625568758739d), new NpgsqlTypes.NpgsqlPoint(x: 0.6828150435659921d, y: 0.7309232932932597d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5567122706276786d, y: 0.6401154547594d), new NpgsqlTypes.NpgsqlPoint(x: 0.21372409073861554d, y: 0.2604014652707006d), new NpgsqlTypes.NpgsqlPoint(x: 0.5149858594478183d, y: 0.022580081136202135d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1555480812707447d, y: 0.03794020516842289d), new NpgsqlTypes.NpgsqlPoint(x: 0.3177551347517298d, y: 0.44401756835986883d), new NpgsqlTypes.NpgsqlPoint(x: 0.37216316398336613d, y: 0.05363518324009764d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.055097450296874406d, y: 0.7894174603925506d), new NpgsqlTypes.NpgsqlPoint(x: 0.7778017968701515d, y: 0.8632955792495663d), new NpgsqlTypes.NpgsqlPoint(x: 0.5579662466093495d, y: 0.24438105379849884d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48909794670724316d, y: 0.7941402979801164d), new NpgsqlTypes.NpgsqlPoint(x: 0.939121271733328d, y: 0.44596201039980676d), new NpgsqlTypes.NpgsqlPoint(x: 0.22524475677235845d, y: 0.13469808567810226d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7617323299174101d, y: 0.23377460445685505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8841286608784575d, y: 0.7526017483479513d), new NpgsqlTypes.NpgsqlPoint(x: 0.6111069969165807d, y: 0.28378511199110945d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.093589214078736d, y: 0.7379471315120416d), new NpgsqlTypes.NpgsqlPoint(x: 0.8767136536502593d, y: 0.44236747794315157d), new NpgsqlTypes.NpgsqlPoint(x: 0.24863583577154236d, y: 0.11882636681191094d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8942316570459601d, y: 0.8685090121670715d), new NpgsqlTypes.NpgsqlPoint(x: 0.23874886823379826d, y: 0.9819728605911061d), new NpgsqlTypes.NpgsqlPoint(x: 0.0519398772733356d, y: 0.17889556740615253d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10477273174565416d, y: 0.06800966106590489d), new NpgsqlTypes.NpgsqlPoint(x: 0.20258196795950267d, y: 0.9369947904837203d), new NpgsqlTypes.NpgsqlPoint(x: 0.31419959968593525d, y: 0.7920493982515304d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7929982790378045d, y: 0.2298172374745695d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261987346944976d, y: 0.44218261003045567d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010263534700828d, y: 0.31395369994894007d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08568789131720178d, y: 0.8559855759903141d), new NpgsqlTypes.NpgsqlPoint(x: 0.0052070588483200675d, y: 0.14776017586660817d), new NpgsqlTypes.NpgsqlPoint(x: 0.16231661758547633d, y: 0.3092402957988184d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6811457030659326d, y: 0.815948497058944d), new NpgsqlTypes.NpgsqlPoint(x: 0.8686613616079722d, y: 0.370413816001126d), new NpgsqlTypes.NpgsqlPoint(x: 0.846925018024206d, y: 0.5946966592972124d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25006591826776847d, y: 0.7649507731068649d), new NpgsqlTypes.NpgsqlPoint(x: 0.5147625332817075d, y: 0.3970948152874685d), new NpgsqlTypes.NpgsqlPoint(x: 0.8402109031108198d, y: 0.48665774833328246d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0660304800535303d, y: 0.7704031439647169d), new NpgsqlTypes.NpgsqlPoint(x: 0.4427359845970348d, y: 0.848058524475642d), new NpgsqlTypes.NpgsqlPoint(x: 0.19469915951103012d, y: 0.46297211740556843d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17304784071814527d, y: 0.48398617810256495d), new NpgsqlTypes.NpgsqlPoint(x: 0.10860882089488011d, y: 0.7687188131540857d), new NpgsqlTypes.NpgsqlPoint(x: 0.6418810152654368d, y: 0.09580660407114283d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8738504007173369d, y: 0.6260903822211457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6211968463504837d, y: 0.8453296695032103d), new NpgsqlTypes.NpgsqlPoint(x: 0.37259150639194183d, y: 0.3851817482518498d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49488706864082277d, y: 0.37286747985203317d), new NpgsqlTypes.NpgsqlPoint(x: 0.7714121664595245d, y: 0.046258377757680935d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900244788276738d, y: 0.15572678048595612d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6013549684586974d, y: 0.30987839095498204d), new NpgsqlTypes.NpgsqlPoint(x: 0.06949688150102329d, y: 0.9673544875164832d), new NpgsqlTypes.NpgsqlPoint(x: 0.7925027817509449d, y: 0.6866469626562688d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9885368437480487d, y: 0.04939130021204219d), new NpgsqlTypes.NpgsqlPoint(x: 0.022166376971994306d, y: 0.31388530639831647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7217653359555749d, y: 0.37929644564964193d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9674312491966693d, y: 0.8505320289246774d), new NpgsqlTypes.NpgsqlPoint(x: 0.7875153089332334d, y: 0.10022271363668d), new NpgsqlTypes.NpgsqlPoint(x: 0.5424483965966054d, y: 0.18783009281887786d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4193427052298504d, y: 0.4780178894721554d), new NpgsqlTypes.NpgsqlPoint(x: 0.8741112679617283d, y: 0.6747130539570639d), new NpgsqlTypes.NpgsqlPoint(x: 0.28076220664096785d, y: 0.4033816057852141d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30228531492660893d, y: 0.8045805489366313d), new NpgsqlTypes.NpgsqlPoint(x: 0.15600876088495574d, y: 0.6004734323394956d), new NpgsqlTypes.NpgsqlPoint(x: 0.34951965353840186d, y: 0.882024771988378d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28670281799555397d, y: 0.47404535827579064d), new NpgsqlTypes.NpgsqlPoint(x: 0.1458778930135125d, y: 0.7348911323742082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9190036519372908d, y: 0.1508391835181705d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5793284887848652d, y: 0.584070643837813d), new NpgsqlTypes.NpgsqlPoint(x: 0.17708830612998938d, y: 0.6686421812415094d), new NpgsqlTypes.NpgsqlPoint(x: 0.11477287641352263d, y: 0.2588607741966211d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08545421185586399d, y: 0.037061144376624d), new NpgsqlTypes.NpgsqlPoint(x: 0.9013694006701533d, y: 0.8197627692981555d), new NpgsqlTypes.NpgsqlPoint(x: 0.6876659470659315d, y: 0.3628961195694732d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21177363846504405d, y: 0.6463614735953158d), new NpgsqlTypes.NpgsqlPoint(x: 0.8596054519829887d, y: 0.4978517864734906d), new NpgsqlTypes.NpgsqlPoint(x: 0.08869775390487011d, y: 0.5726665522713557d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3235540442808924d, y: 0.10458606587095232d), new NpgsqlTypes.NpgsqlPoint(x: 0.5571445463893523d, y: 0.8374407619435645d), new NpgsqlTypes.NpgsqlPoint(x: 0.39345295743378683d, y: 0.6676190197889005d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6261180050982378d, y: 0.3402371302058681d), new NpgsqlTypes.NpgsqlPoint(x: 0.13012271768764527d, y: 0.49874821828720095d), new NpgsqlTypes.NpgsqlPoint(x: 0.11269549922442401d, y: 0.7318287314647858d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05398349790388346d, y: 0.31536451368809915d), new NpgsqlTypes.NpgsqlPoint(x: 0.41872616447244715d, y: 0.6565841528545123d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205440671742262d, y: 0.5698832940094803d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26116645976389474d, y: 0.2823004997753721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7886966294877387d, y: 0.9251158718415763d), new NpgsqlTypes.NpgsqlPoint(x: 0.7496171097319302d, y: 0.7432233479364976d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6745600996228084d, y: 0.4780834454625158d), new NpgsqlTypes.NpgsqlPoint(x: 0.7436845815153171d, y: 0.10894409749792111d), new NpgsqlTypes.NpgsqlPoint(x: 0.2261780494957274d, y: 0.23160780152626814d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16954434200824775d, y: 0.7375989637989722d), new NpgsqlTypes.NpgsqlPoint(x: 0.416324080203733d, y: 0.31595350694614166d), new NpgsqlTypes.NpgsqlPoint(x: 0.723349831458534d, y: 0.018871769623584278d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7925969952216494d, y: 0.03551857554161075d), new NpgsqlTypes.NpgsqlPoint(x: 0.21140048769041409d, y: 0.45778814912186727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6333486678988949d, y: 0.09316875457886487d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7190315807235569d, y: 0.6331007422415935d), new NpgsqlTypes.NpgsqlPoint(x: 0.9206086102155252d, y: 0.1374820268367245d), new NpgsqlTypes.NpgsqlPoint(x: 0.41674797096216576d, y: 0.2833646302810777d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008553892586089962d, y: 0.33146122513634046d), new NpgsqlTypes.NpgsqlPoint(x: 0.18418440926621304d, y: 0.335045082290904d), new NpgsqlTypes.NpgsqlPoint(x: 0.9780943577378952d, y: 0.14724487664523778d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38682530867703624d, y: 0.5033752773763548d), new NpgsqlTypes.NpgsqlPoint(x: 0.14789847402241507d, y: 0.8776893491513735d), new NpgsqlTypes.NpgsqlPoint(x: 0.4253998558271195d, y: 0.3540078942259449d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19966499278519223d, y: 0.7109487881348618d), new NpgsqlTypes.NpgsqlPoint(x: 0.4964684629027126d, y: 0.17346157181189548d), new NpgsqlTypes.NpgsqlPoint(x: 0.057638503579870326d, y: 0.06734869472259153d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9432684182002202d, y: 0.01781975436702643d), new NpgsqlTypes.NpgsqlPoint(x: 0.49465873802197935d, y: 0.06820850053870298d), new NpgsqlTypes.NpgsqlPoint(x: 0.5221697415300149d, y: 0.8404984799404283d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26732702232181704d, y: 0.2910041839656904d), new NpgsqlTypes.NpgsqlPoint(x: 0.862623616406351d, y: 0.6722482052330846d), new NpgsqlTypes.NpgsqlPoint(x: 0.36365601584492047d, y: 0.10033142838358444d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007388568828663344d, y: 0.5387382597958486d), new NpgsqlTypes.NpgsqlPoint(x: 0.25925575116191435d, y: 0.07899308460753895d), new NpgsqlTypes.NpgsqlPoint(x: 0.6762982024238505d, y: 0.8064197658006494d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1483788592680907d, y: 0.9324190998843419d), new NpgsqlTypes.NpgsqlPoint(x: 0.8319838679965261d, y: 0.7887881691600781d), new NpgsqlTypes.NpgsqlPoint(x: 0.1314313783198704d, y: 0.5533190463017228d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013274311202573275d, y: 0.37890246029977603d), new NpgsqlTypes.NpgsqlPoint(x: 0.8033784768248228d, y: 0.806734623283253d), new NpgsqlTypes.NpgsqlPoint(x: 0.8394055535572957d, y: 0.9310131944175031d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31789591197368094d, y: 0.8893952838609563d), new NpgsqlTypes.NpgsqlPoint(x: 0.7894842501380389d, y: 0.3667464788951571d), new NpgsqlTypes.NpgsqlPoint(x: 0.3239901172464881d, y: 0.7545973735070282d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8456240697211839d, y: 0.5318457681470411d), new NpgsqlTypes.NpgsqlPoint(x: 0.09485592727044923d, y: 0.8490759799481951d), new NpgsqlTypes.NpgsqlPoint(x: 0.8489122923166245d, y: 0.3695529289365491d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5784043577453574d, y: 0.6246056418515333d), new NpgsqlTypes.NpgsqlPoint(x: 0.37094777280655333d, y: 0.5780678105194571d), new NpgsqlTypes.NpgsqlPoint(x: 0.6521025878963297d, y: 0.9610856480414197d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8840490708891994d, y: 0.14859120265645887d), new NpgsqlTypes.NpgsqlPoint(x: 0.33730306916645436d, y: 0.15170082001980112d), new NpgsqlTypes.NpgsqlPoint(x: 0.9688551004259008d, y: 0.70426486478329d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12372833253320237d, y: 0.530068444780728d), new NpgsqlTypes.NpgsqlPoint(x: 0.686451583874522d, y: 0.1656225131684872d), new NpgsqlTypes.NpgsqlPoint(x: 0.6193578442455853d, y: 0.5444041137194064d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03198342903592344d, y: 0.11217435162072431d), new NpgsqlTypes.NpgsqlPoint(x: 0.278171569043021d, y: 0.5016678763517093d), new NpgsqlTypes.NpgsqlPoint(x: 0.8501851993761702d, y: 0.7037949455495894d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9706592461709672d, y: 0.9424984666358528d), new NpgsqlTypes.NpgsqlPoint(x: 0.9756848831131898d, y: 0.37897075437705063d), new NpgsqlTypes.NpgsqlPoint(x: 0.09440887936776854d, y: 0.635403169120321d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10029305820495882d, y: 0.7446863865174892d), new NpgsqlTypes.NpgsqlPoint(x: 0.26255454683150325d, y: 0.3200711327869523d), new NpgsqlTypes.NpgsqlPoint(x: 0.600573891902101d, y: 0.8908712963035266d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38998485584275133d, y: 0.26350925358692d), new NpgsqlTypes.NpgsqlPoint(x: 0.8966216345133828d, y: 0.27280591876169d), new NpgsqlTypes.NpgsqlPoint(x: 0.26300451445097817d, y: 0.4905508954755746d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5659562682225184d, y: 0.10956200443817443d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359077245144846d, y: 0.9336603218109155d), new NpgsqlTypes.NpgsqlPoint(x: 0.4324369115258452d, y: 0.465277092278658d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7155923135717235d, y: 0.6690591846382228d), new NpgsqlTypes.NpgsqlPoint(x: 0.14842120806635928d, y: 0.8532990539999021d), new NpgsqlTypes.NpgsqlPoint(x: 0.9325161019305886d, y: 0.9380226887790662d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3596875263240864d, y: 0.5883218004695621d), new NpgsqlTypes.NpgsqlPoint(x: 0.30745678694429257d, y: 0.3467923541695668d), new NpgsqlTypes.NpgsqlPoint(x: 0.2190456172801456d, y: 0.10310488418421193d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13927262283875874d, y: 0.686091743880663d), new NpgsqlTypes.NpgsqlPoint(x: 0.9986928799186638d, y: 0.5003030980901605d), new NpgsqlTypes.NpgsqlPoint(x: 0.726752574872026d, y: 0.2588259628478323d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5182448265672746d, y: 0.0627321607439798d), new NpgsqlTypes.NpgsqlPoint(x: 0.4077578360502141d, y: 0.8220393738851709d), new NpgsqlTypes.NpgsqlPoint(x: 0.16659068395326604d, y: 0.9743399526970348d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23452907396569778d, y: 0.25479097455549526d), new NpgsqlTypes.NpgsqlPoint(x: 0.1933311565662158d, y: 0.028595064017063354d), new NpgsqlTypes.NpgsqlPoint(x: 0.13760749738452205d, y: 0.20179509158324682d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11867643484724488d, y: 0.7309321411588211d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626085630563602d, y: 0.7267359001874292d), new NpgsqlTypes.NpgsqlPoint(x: 0.6457045345679143d, y: 0.5199492793903808d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9217238150652585d, y: 0.872462085569275d), new NpgsqlTypes.NpgsqlPoint(x: 0.5995206653581612d, y: 0.900854566570077d), new NpgsqlTypes.NpgsqlPoint(x: 0.2421029398902137d, y: 0.328556500977891d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39444573313055964d, y: 0.1696000823861502d), new NpgsqlTypes.NpgsqlPoint(x: 0.47389018658768334d, y: 0.5858764383660574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5628294834590937d, y: 0.5793042077472152d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7560386240975754d, y: 0.08613973644131034d), new NpgsqlTypes.NpgsqlPoint(x: 0.15425522432157124d, y: 0.2296912117664739d), new NpgsqlTypes.NpgsqlPoint(x: 0.5021152994388893d, y: 0.23582820423473372d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8242465906946475d, y: 0.12252298476277002d), new NpgsqlTypes.NpgsqlPoint(x: 0.7525129778140097d, y: 0.5720789175398577d), new NpgsqlTypes.NpgsqlPoint(x: 0.8135462367907426d, y: 0.12704549470604953d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6210542374929903d, y: 0.2760817661742474d), new NpgsqlTypes.NpgsqlPoint(x: 0.554759935207682d, y: 0.5258265203966188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9286498707890832d, y: 0.5690891620186712d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7691226154848932d, y: 0.6453426014706806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8045277235343337d, y: 0.8732585459976703d), new NpgsqlTypes.NpgsqlPoint(x: 0.001078486297023007d, y: 0.5662324526874744d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17787017813944928d, y: 0.675850036938907d), new NpgsqlTypes.NpgsqlPoint(x: 0.09234865641754542d, y: 0.25035647787636894d), new NpgsqlTypes.NpgsqlPoint(x: 0.11183731591420121d, y: 0.7091877424693052d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2773239087975863d, y: 0.9500496202072942d), new NpgsqlTypes.NpgsqlPoint(x: 0.46900823208812736d, y: 0.09787292536375536d), new NpgsqlTypes.NpgsqlPoint(x: 0.8769340963280771d, y: 0.8199915131005684d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7585219323195489d, y: 0.4998982836289366d), new NpgsqlTypes.NpgsqlPoint(x: 0.5128839454936869d, y: 0.5479850582064092d), new NpgsqlTypes.NpgsqlPoint(x: 0.6592328762998843d, y: 0.07496530530035905d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9648723270065753d, y: 0.21698423669240674d), new NpgsqlTypes.NpgsqlPoint(x: 0.3003188736520749d, y: 0.6825864337823574d), new NpgsqlTypes.NpgsqlPoint(x: 0.1434040176317144d, y: 0.42424656018675166d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8378594813344348d, y: 0.17355864223622863d), new NpgsqlTypes.NpgsqlPoint(x: 0.96811691969616d, y: 0.7221337308192928d), new NpgsqlTypes.NpgsqlPoint(x: 0.459830207017644d, y: 0.7006554588214063d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6791305864035748d, y: 0.915092990349399d), new NpgsqlTypes.NpgsqlPoint(x: 0.029334743351326797d, y: 0.4364769368767676d), new NpgsqlTypes.NpgsqlPoint(x: 0.10944332693570691d, y: 0.6127116427488907d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9269067342345729d, y: 0.06899146634520137d), new NpgsqlTypes.NpgsqlPoint(x: 0.376872003461043d, y: 0.23884784563385852d), new NpgsqlTypes.NpgsqlPoint(x: 0.7735154394573304d, y: 0.4190109419727769d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2293676265782173d, y: 0.4674528407235746d), new NpgsqlTypes.NpgsqlPoint(x: 0.36145667680016835d, y: 0.8951936547854187d), new NpgsqlTypes.NpgsqlPoint(x: 0.9431985594603883d, y: 0.9657985464277606d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8481896214065326d, y: 0.18104848450152222d), new NpgsqlTypes.NpgsqlPoint(x: 0.3506889468428158d, y: 0.2937889124950941d), new NpgsqlTypes.NpgsqlPoint(x: 0.9433163548835577d, y: 0.8735406721036829d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24031262558186484d, y: 0.9261803472015608d), new NpgsqlTypes.NpgsqlPoint(x: 0.4119229843662092d, y: 0.4971211757014561d), new NpgsqlTypes.NpgsqlPoint(x: 0.0912949878649324d, y: 0.8285634407319675d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7576052427711242d, y: 0.26461406185769776d), new NpgsqlTypes.NpgsqlPoint(x: 0.06305182757403394d, y: 0.8720818879387076d), new NpgsqlTypes.NpgsqlPoint(x: 0.23696956240278266d, y: 0.5316903578952205d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4816265401385941d, y: 0.11663776427141592d), new NpgsqlTypes.NpgsqlPoint(x: 0.07658165345648804d, y: 0.8576279631105395d), new NpgsqlTypes.NpgsqlPoint(x: 0.6997631970149775d, y: 0.4640285226525388d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5400951512339998d, y: 0.9307704385833427d), new NpgsqlTypes.NpgsqlPoint(x: 0.0038783011661893685d, y: 0.667927504131954d), new NpgsqlTypes.NpgsqlPoint(x: 0.3727809582965159d, y: 0.2647585931180233d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21991934336143004d, y: 0.17193326721708035d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989437365632179d, y: 0.953870734248288d), new NpgsqlTypes.NpgsqlPoint(x: 0.8185064681722419d, y: 0.8552212620824071d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12215404931990792d, y: 0.12434806851898539d), new NpgsqlTypes.NpgsqlPoint(x: 0.6256933332998602d, y: 0.47838833022290206d), new NpgsqlTypes.NpgsqlPoint(x: 0.8149886588240676d, y: 0.8447716555664582d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31451278785762693d, y: 0.7498948896822552d), new NpgsqlTypes.NpgsqlPoint(x: 0.37048599225211576d, y: 0.5200595498089643d), new NpgsqlTypes.NpgsqlPoint(x: 0.0794086576872951d, y: 0.07099864411116608d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24077391178815533d, y: 0.47823065908272366d), new NpgsqlTypes.NpgsqlPoint(x: 0.7651589320608013d, y: 0.7138922963174239d), new NpgsqlTypes.NpgsqlPoint(x: 0.9697493987264766d, y: 0.7650876787810528d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.057591614346542586d, y: 0.035170258001871346d), new NpgsqlTypes.NpgsqlPoint(x: 0.0332105661850729d, y: 0.020313788788545395d), new NpgsqlTypes.NpgsqlPoint(x: 0.08682357375748606d, y: 0.02211463773309752d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8550032313292689d, y: 0.03111818824207846d), new NpgsqlTypes.NpgsqlPoint(x: 0.31409786798005856d, y: 0.8831540736600945d), new NpgsqlTypes.NpgsqlPoint(x: 0.3500745329872834d, y: 0.8296109553076936d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3422908174650925d, y: 0.44799446260929743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8505892178239044d, y: 0.027055781349151764d), new NpgsqlTypes.NpgsqlPoint(x: 0.45270788261343475d, y: 0.2932114691863812d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9123836067379788d, y: 0.3347234206693376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7319584449660002d, y: 0.36965249157892355d), new NpgsqlTypes.NpgsqlPoint(x: 0.3919451738228735d, y: 0.7784953738956013d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6477983663055258d, y: 0.48170706288833987d), new NpgsqlTypes.NpgsqlPoint(x: 0.5753304848355592d, y: 0.9687437984066206d), new NpgsqlTypes.NpgsqlPoint(x: 0.027403745608862495d, y: 0.28355692609813943d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07920647082613685d, y: 0.10382811530329739d), new NpgsqlTypes.NpgsqlPoint(x: 0.07236591434774353d, y: 0.16730572767209606d), new NpgsqlTypes.NpgsqlPoint(x: 0.15978157358313494d, y: 0.10703445973144932d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4446324655925977d, y: 0.7031073155518698d), new NpgsqlTypes.NpgsqlPoint(x: 0.042522673041494374d, y: 0.08375832258350713d), new NpgsqlTypes.NpgsqlPoint(x: 0.8261422989861198d, y: 0.2193186172177657d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7217367387204767d, y: 0.7344317056760917d), new NpgsqlTypes.NpgsqlPoint(x: 0.8723085962703393d, y: 0.4639092263334086d), new NpgsqlTypes.NpgsqlPoint(x: 0.5141966938309209d, y: 0.06295484035810128d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.308968755787029d, y: 0.8312055797191765d), new NpgsqlTypes.NpgsqlPoint(x: 0.4336515980295642d, y: 0.4224314294500283d), new NpgsqlTypes.NpgsqlPoint(x: 0.9344320536588073d, y: 0.964347771520352d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3662675535362684d, y: 0.07669574004538371d), new NpgsqlTypes.NpgsqlPoint(x: 0.41273923536594814d, y: 0.6427800591766312d), new NpgsqlTypes.NpgsqlPoint(x: 0.25370728938200404d, y: 0.5015388937659039d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4531481130431335d, y: 0.7826757181636645d), new NpgsqlTypes.NpgsqlPoint(x: 0.40401157137253907d, y: 0.9773862921621764d), new NpgsqlTypes.NpgsqlPoint(x: 0.28622842137329585d, y: 0.6520004750405389d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5731282366786492d, y: 0.3476703558307951d), new NpgsqlTypes.NpgsqlPoint(x: 0.8252723833482795d, y: 0.6268396623244237d), new NpgsqlTypes.NpgsqlPoint(x: 0.19663917483486992d, y: 0.45103742595529595d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1762538080944448d, y: 0.2856480420629127d), new NpgsqlTypes.NpgsqlPoint(x: 0.2947128883193899d, y: 0.8810058993399112d), new NpgsqlTypes.NpgsqlPoint(x: 0.5758305321134577d, y: 0.7128380223493423d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.81903270358146d, y: 0.643805621809304d), new NpgsqlTypes.NpgsqlPoint(x: 0.6066773091258978d, y: 0.1704994271294089d), new NpgsqlTypes.NpgsqlPoint(x: 0.9856979082919474d, y: 0.8379169116155627d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09640305152203044d, y: 0.8300055480925709d), new NpgsqlTypes.NpgsqlPoint(x: 0.7883768741385726d, y: 0.7178483910028288d), new NpgsqlTypes.NpgsqlPoint(x: 0.7583519264926861d, y: 0.14846173638268545d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.455082595790123d, y: 0.8654421486596895d), new NpgsqlTypes.NpgsqlPoint(x: 0.9706382075761208d, y: 0.9004201741071239d), new NpgsqlTypes.NpgsqlPoint(x: 0.5641640956137481d, y: 0.515273318524902d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32454697148606604d, y: 0.351610232828914d), new NpgsqlTypes.NpgsqlPoint(x: 0.8624488978027643d, y: 0.3910375159327242d), new NpgsqlTypes.NpgsqlPoint(x: 0.014442416427896343d, y: 0.3258427490175264d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03459580293976394d, y: 0.8873184419527745d), new NpgsqlTypes.NpgsqlPoint(x: 0.520593050386059d, y: 0.7195628441471218d), new NpgsqlTypes.NpgsqlPoint(x: 0.4959208424879211d, y: 0.566686434034938d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2343974920321169d, y: 0.13871112550410925d), new NpgsqlTypes.NpgsqlPoint(x: 0.8073942127189241d, y: 0.8732996676768845d), new NpgsqlTypes.NpgsqlPoint(x: 0.7287210724276663d, y: 0.7297516317343593d)),

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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.334308793730808d, y: 0.118168656558725d), new NpgsqlTypes.NpgsqlPoint(x: 0.5530406045340873d, y: 0.07626806215507254d), new NpgsqlTypes.NpgsqlPoint(x: 0.6449445275176194d, y: 0.5935673095900752d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47448910059865756d, y: 0.28383998189612125d), new NpgsqlTypes.NpgsqlPoint(x: 0.9602519797743135d, y: 0.4576044039720246d), new NpgsqlTypes.NpgsqlPoint(x: 0.4825152319580145d, y: 0.3971455529723298d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5480112059080345d, y: 0.21618665761238476d), new NpgsqlTypes.NpgsqlPoint(x: 0.7927618445122159d, y: 0.17184270705392313d), new NpgsqlTypes.NpgsqlPoint(x: 0.36425836150878177d, y: 0.30490264468572803d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7632118058792948d, y: 0.876321230355078d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432263130416825d, y: 0.7995315170880174d), new NpgsqlTypes.NpgsqlPoint(x: 0.03813375500156502d, y: 0.3890940200081908d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9401390176601665d, y: 0.33714877018331935d), new NpgsqlTypes.NpgsqlPoint(x: 0.006253154961050611d, y: 0.5698671776662934d), new NpgsqlTypes.NpgsqlPoint(x: 0.5247341913424113d, y: 0.4233515819301704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2615065996990201d, y: 0.025737206868603257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7680376599311002d, y: 0.4947060379813303d), new NpgsqlTypes.NpgsqlPoint(x: 0.5423222585789393d, y: 0.9388188583294187d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15418371944139286d, y: 0.8777714280093358d), new NpgsqlTypes.NpgsqlPoint(x: 0.46726171254163096d, y: 0.6527434728767375d), new NpgsqlTypes.NpgsqlPoint(x: 0.29544499381465517d, y: 0.15817530882517883d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6464630315934679d, y: 0.3015092266862486d), new NpgsqlTypes.NpgsqlPoint(x: 0.6527689143060689d, y: 0.6302727519819145d), new NpgsqlTypes.NpgsqlPoint(x: 0.12830132116412074d, y: 0.3979098987049411d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7563668907160227d, y: 0.23336489192925702d), new NpgsqlTypes.NpgsqlPoint(x: 0.8445547378720201d, y: 0.528028644086352d), new NpgsqlTypes.NpgsqlPoint(x: 0.013535250896905993d, y: 0.42056752539727715d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7608753559493918d, y: 0.5537923962728392d), new NpgsqlTypes.NpgsqlPoint(x: 0.7790788680977507d, y: 0.8305933208341418d), new NpgsqlTypes.NpgsqlPoint(x: 0.1653680437592584d, y: 0.9565389532202734d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7988970061911876d, y: 0.1752541598061782d), new NpgsqlTypes.NpgsqlPoint(x: 0.8569425906344508d, y: 0.4225771120618992d), new NpgsqlTypes.NpgsqlPoint(x: 0.8572140452419803d, y: 0.02083532677263411d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9711478459560401d, y: 0.05441111073073501d), new NpgsqlTypes.NpgsqlPoint(x: 0.6244451053494126d, y: 0.7660443017181393d), new NpgsqlTypes.NpgsqlPoint(x: 0.7343250637462031d, y: 0.1966207803404627d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8942339338726708d, y: 0.3597227518394539d), new NpgsqlTypes.NpgsqlPoint(x: 0.3661089554445658d, y: 0.6716016945937061d), new NpgsqlTypes.NpgsqlPoint(x: 0.9487506771995712d, y: 0.2690889063803722d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02968729097701528d, y: 0.5111917359015383d), new NpgsqlTypes.NpgsqlPoint(x: 0.05650541462692604d, y: 0.15399871252337605d), new NpgsqlTypes.NpgsqlPoint(x: 0.6529722340344243d, y: 0.6588978067534541d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08748755813206588d, y: 0.3569918140817814d), new NpgsqlTypes.NpgsqlPoint(x: 0.2899488196740342d, y: 0.7178927743245627d), new NpgsqlTypes.NpgsqlPoint(x: 0.03265726475173658d, y: 0.7067589008906647d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6701526208095251d, y: 0.7982251338522343d), new NpgsqlTypes.NpgsqlPoint(x: 0.5699950193625778d, y: 0.0356652783609166d), new NpgsqlTypes.NpgsqlPoint(x: 0.3383411194564798d, y: 0.7908682076653795d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6695668651658857d, y: 0.2028893465921433d), new NpgsqlTypes.NpgsqlPoint(x: 0.589726347175522d, y: 0.7954555481221715d), new NpgsqlTypes.NpgsqlPoint(x: 0.43306043765553626d, y: 0.8802561714935316d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1243342125662813d, y: 0.5924282689813977d), new NpgsqlTypes.NpgsqlPoint(x: 0.48072329909272327d, y: 0.18946430351613885d), new NpgsqlTypes.NpgsqlPoint(x: 0.8727712428554013d, y: 0.509154438603503d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6911568310325373d, y: 0.1772933226114165d), new NpgsqlTypes.NpgsqlPoint(x: 0.6485753167683849d, y: 0.6649275927483937d), new NpgsqlTypes.NpgsqlPoint(x: 0.05297405795612997d, y: 0.436926854914117d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2668917920121995d, y: 0.06090010659370382d), new NpgsqlTypes.NpgsqlPoint(x: 0.9079474492495997d, y: 0.05536919100523485d), new NpgsqlTypes.NpgsqlPoint(x: 0.8511285755178611d, y: 0.6924354684762496d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7964858775445867d, y: 0.7049765888532081d), new NpgsqlTypes.NpgsqlPoint(x: 0.15721596048494024d, y: 0.6906640354827123d), new NpgsqlTypes.NpgsqlPoint(x: 0.5908142331800164d, y: 0.7322712274043911d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32518554656057586d, y: 0.14997917640341762d), new NpgsqlTypes.NpgsqlPoint(x: 0.09322989185780539d, y: 0.9220587051230887d), new NpgsqlTypes.NpgsqlPoint(x: 0.6158492445770848d, y: 0.3466738708366571d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5516040982200794d, y: 0.7010612781482483d), new NpgsqlTypes.NpgsqlPoint(x: 0.6564586786843808d, y: 0.609533090800631d), new NpgsqlTypes.NpgsqlPoint(x: 0.35004546300315054d, y: 0.21158460679877056d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9887375035176547d, y: 0.07376636731589337d), new NpgsqlTypes.NpgsqlPoint(x: 0.9314099934044965d, y: 0.763549972851725d), new NpgsqlTypes.NpgsqlPoint(x: 0.9231526610777807d, y: 0.09349729800354989d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9325676431345437d, y: 0.26906017356180323d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005339115854325893d, y: 0.6399864208024989d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624752683080588d, y: 0.0025229582599811673d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.979913067621342d, y: 0.20461544001314558d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275701541466922d, y: 0.6293457130543975d), new NpgsqlTypes.NpgsqlPoint(x: 0.4628436799204283d, y: 0.14100697924999317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4942938830987311d, y: 0.8706018257155526d), new NpgsqlTypes.NpgsqlPoint(x: 0.8877934651715521d, y: 0.38648864690379425d), new NpgsqlTypes.NpgsqlPoint(x: 0.7513756450639312d, y: 0.6669009479362195d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7690169592000337d, y: 0.012037984201344165d), new NpgsqlTypes.NpgsqlPoint(x: 0.20003713073282714d, y: 0.04749930811990122d), new NpgsqlTypes.NpgsqlPoint(x: 0.8430644439372151d, y: 0.7655124706105081d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4431499600487381d, y: 0.9928345915319985d), new NpgsqlTypes.NpgsqlPoint(x: 0.8646528411005134d, y: 0.2593395345511066d), new NpgsqlTypes.NpgsqlPoint(x: 0.749727239323667d, y: 0.4188524794212676d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2575260500302995d, y: 0.9458258136078141d), new NpgsqlTypes.NpgsqlPoint(x: 0.1831953306961388d, y: 0.8065878278419121d), new NpgsqlTypes.NpgsqlPoint(x: 0.6346490043199592d, y: 0.5630507849891727d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48738601160753936d, y: 0.606841821729271d), new NpgsqlTypes.NpgsqlPoint(x: 0.7374989492487356d, y: 0.5840348191276398d), new NpgsqlTypes.NpgsqlPoint(x: 0.755645991420393d, y: 0.20859958496754616d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8637140428478797d, y: 0.09883821281065008d), new NpgsqlTypes.NpgsqlPoint(x: 0.07306720221615659d, y: 0.6567831912334989d), new NpgsqlTypes.NpgsqlPoint(x: 0.6321410205026743d, y: 0.7383429304391711d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6987185489019248d, y: 0.4854329361750783d), new NpgsqlTypes.NpgsqlPoint(x: 0.2935978916433518d, y: 0.7790336818441423d), new NpgsqlTypes.NpgsqlPoint(x: 0.7471225589176717d, y: 0.994950434684103d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13653196146276925d, y: 0.046911518645030514d), new NpgsqlTypes.NpgsqlPoint(x: 0.6337020275390435d, y: 0.6812337565121482d), new NpgsqlTypes.NpgsqlPoint(x: 0.913680888771744d, y: 0.29280439834335537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023758688695204477d, y: 0.22793549745837505d), new NpgsqlTypes.NpgsqlPoint(x: 0.03870170413553409d, y: 0.8301620528350921d), new NpgsqlTypes.NpgsqlPoint(x: 0.7543132283015727d, y: 0.7572455344348119d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7576739315265628d, y: 0.9596646454012905d), new NpgsqlTypes.NpgsqlPoint(x: 0.7062900373555574d, y: 0.6295324245782983d), new NpgsqlTypes.NpgsqlPoint(x: 0.8903318609101358d, y: 0.6293474817033456d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7543026085210199d, y: 0.7030981473599393d), new NpgsqlTypes.NpgsqlPoint(x: 0.058632973079546735d, y: 0.380131244178305d), new NpgsqlTypes.NpgsqlPoint(x: 0.11931848267862877d, y: 0.05243459709974996d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9813727734618382d, y: 0.3613768321392642d), new NpgsqlTypes.NpgsqlPoint(x: 0.5583740025629048d, y: 0.7162992021608673d), new NpgsqlTypes.NpgsqlPoint(x: 0.868607679754472d, y: 0.7334208531855033d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.162700443247613d, y: 0.5480563465323439d), new NpgsqlTypes.NpgsqlPoint(x: 0.8020009077126501d, y: 0.9967673175131763d), new NpgsqlTypes.NpgsqlPoint(x: 0.47097875449513993d, y: 0.04614984633228658d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3384752299957853d, y: 0.8852268424315514d), new NpgsqlTypes.NpgsqlPoint(x: 0.9269783249373884d, y: 0.1984019392800237d), new NpgsqlTypes.NpgsqlPoint(x: 0.4771283894801128d, y: 0.8032189090061702d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4163229859957541d, y: 0.5510892909050216d), new NpgsqlTypes.NpgsqlPoint(x: 0.19075030960353467d, y: 0.3542913676248033d), new NpgsqlTypes.NpgsqlPoint(x: 0.3229860787581672d, y: 0.6271284562772881d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8039455731584753d, y: 0.505017947623535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6211243575032779d, y: 0.9244767926828498d), new NpgsqlTypes.NpgsqlPoint(x: 0.4302170899691665d, y: 0.7046188737113785d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5254003072220871d, y: 0.3241641031951805d), new NpgsqlTypes.NpgsqlPoint(x: 0.32513437960213754d, y: 0.6484823270513705d), new NpgsqlTypes.NpgsqlPoint(x: 0.6941991541140824d, y: 0.9258332246461708d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28922977163261776d, y: 0.42493674824257033d), new NpgsqlTypes.NpgsqlPoint(x: 0.3631107550598609d, y: 0.7007036544302421d), new NpgsqlTypes.NpgsqlPoint(x: 0.5041100882424335d, y: 0.5195943161200807d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8060384930536177d, y: 0.3311183856983384d), new NpgsqlTypes.NpgsqlPoint(x: 0.9012981740596064d, y: 0.30704975528116385d), new NpgsqlTypes.NpgsqlPoint(x: 0.7257156987642857d, y: 0.5725509219808165d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.391407830151805d, y: 0.24200752852409313d), new NpgsqlTypes.NpgsqlPoint(x: 0.5109167402584672d, y: 0.34107458122299084d), new NpgsqlTypes.NpgsqlPoint(x: 0.23728236313665718d, y: 0.7614304685949799d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7695793942456659d, y: 0.9101007919772167d), new NpgsqlTypes.NpgsqlPoint(x: 0.40345048364516645d, y: 0.20396822469479226d), new NpgsqlTypes.NpgsqlPoint(x: 0.014236570452682784d, y: 0.08385876412446869d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28962495506334096d, y: 0.5563344680303727d), new NpgsqlTypes.NpgsqlPoint(x: 0.953137272535247d, y: 0.5398492773031459d), new NpgsqlTypes.NpgsqlPoint(x: 0.20163894540798877d, y: 0.651128339368926d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03762205341188973d, y: 0.2894213845220358d), new NpgsqlTypes.NpgsqlPoint(x: 0.9938023493399787d, y: 0.7703477456332698d), new NpgsqlTypes.NpgsqlPoint(x: 0.6298825824967202d, y: 0.12246114794883634d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8730468913416707d, y: 0.9410232311173585d), new NpgsqlTypes.NpgsqlPoint(x: 0.7919354886375939d, y: 0.21743572669328548d), new NpgsqlTypes.NpgsqlPoint(x: 0.2719947879329324d, y: 0.8397544339908182d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27760548300331356d, y: 0.3537165570050895d), new NpgsqlTypes.NpgsqlPoint(x: 0.5647750696981373d, y: 0.10156388266339234d), new NpgsqlTypes.NpgsqlPoint(x: 0.2959690236098763d, y: 0.26938991187436734d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22841702734783365d, y: 0.9507250210492229d), new NpgsqlTypes.NpgsqlPoint(x: 0.650146044159601d, y: 0.4521148126821197d), new NpgsqlTypes.NpgsqlPoint(x: 0.03904373802959249d, y: 0.14587631975485138d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38913639984223247d, y: 0.147698733626482d), new NpgsqlTypes.NpgsqlPoint(x: 0.758498433448611d, y: 0.9159121099094278d), new NpgsqlTypes.NpgsqlPoint(x: 0.3412119245018228d, y: 0.661622888618528d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5732092063447167d, y: 0.8990380320873287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6737578585825503d, y: 0.78663774503856d), new NpgsqlTypes.NpgsqlPoint(x: 0.8940158492924983d, y: 0.816527099902524d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5859228882322839d, y: 0.38851544584883335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7051280550244713d, y: 0.38389115420522923d), new NpgsqlTypes.NpgsqlPoint(x: 0.29202051613777025d, y: 0.8558851285677741d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6307417543308174d, y: 0.6545234315953393d), new NpgsqlTypes.NpgsqlPoint(x: 0.594900133924548d, y: 0.5336445235591001d), new NpgsqlTypes.NpgsqlPoint(x: 0.7429494705060887d, y: 0.9573006127909626d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.036518226503673645d, y: 0.31308406580593917d), new NpgsqlTypes.NpgsqlPoint(x: 0.8996484458469669d, y: 0.14629252560306416d), new NpgsqlTypes.NpgsqlPoint(x: 0.1639714647830074d, y: 0.6333624952060272d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16180094193707062d, y: 0.5002031189129924d), new NpgsqlTypes.NpgsqlPoint(x: 0.5488348777806533d, y: 0.1787463941521149d), new NpgsqlTypes.NpgsqlPoint(x: 0.31586103202175864d, y: 0.4203575536432169d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6549122580007248d, y: 0.6785247733785253d), new NpgsqlTypes.NpgsqlPoint(x: 0.24484908001639183d, y: 0.9427721723105245d), new NpgsqlTypes.NpgsqlPoint(x: 0.129962676846896d, y: 0.30154714297200713d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13903264589218323d, y: 0.27908330638669265d), new NpgsqlTypes.NpgsqlPoint(x: 0.4296509218547453d, y: 0.3631437890027096d), new NpgsqlTypes.NpgsqlPoint(x: 0.27849413797570144d, y: 0.024556373590048697d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34812718177646473d, y: 0.8628098281818457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6618711746614073d, y: 0.6807986331873374d), new NpgsqlTypes.NpgsqlPoint(x: 0.4085974049801008d, y: 0.18488212463940645d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28787842741332714d, y: 0.7375269089424438d), new NpgsqlTypes.NpgsqlPoint(x: 0.4992985467976234d, y: 0.2859223092840477d), new NpgsqlTypes.NpgsqlPoint(x: 0.7410634492111231d, y: 0.32242561868200037d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6736544723403672d, y: 0.5829783428878158d), new NpgsqlTypes.NpgsqlPoint(x: 0.619673504958813d, y: 0.3975072637841506d), new NpgsqlTypes.NpgsqlPoint(x: 0.5528094566549698d, y: 0.2145766276624178d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8288268914243959d, y: 0.6176766744027107d), new NpgsqlTypes.NpgsqlPoint(x: 0.3559465619761637d, y: 0.9835964557662077d), new NpgsqlTypes.NpgsqlPoint(x: 0.10067138576219403d, y: 0.4047301300994779d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4042457673077948d, y: 0.39844040321949825d), new NpgsqlTypes.NpgsqlPoint(x: 0.6018741374053423d, y: 0.4377744061540386d), new NpgsqlTypes.NpgsqlPoint(x: 0.6313162430738007d, y: 0.4289454032572101d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42341653510109745d, y: 0.4291987810351596d), new NpgsqlTypes.NpgsqlPoint(x: 0.1341068935673857d, y: 0.9015217423721125d), new NpgsqlTypes.NpgsqlPoint(x: 0.5671044431357127d, y: 0.7424721017934665d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9059487488553557d, y: 0.3144106512266466d), new NpgsqlTypes.NpgsqlPoint(x: 0.00028307534204408125d, y: 0.2622418120028931d), new NpgsqlTypes.NpgsqlPoint(x: 0.9896629582642573d, y: 0.3069455836281604d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6723941383249821d, y: 0.5469447113928166d), new NpgsqlTypes.NpgsqlPoint(x: 0.31729858967987423d, y: 0.7856083056427756d), new NpgsqlTypes.NpgsqlPoint(x: 0.11083390000979032d, y: 0.8326104980940948d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2774221534799952d, y: 0.38644562616317046d), new NpgsqlTypes.NpgsqlPoint(x: 0.47438269007427947d, y: 0.8211676282074937d), new NpgsqlTypes.NpgsqlPoint(x: 0.1805653903747242d, y: 0.14270189778346576d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4468755992615423d, y: 0.9567419913212695d), new NpgsqlTypes.NpgsqlPoint(x: 0.7443119829798504d, y: 0.9638244010076071d), new NpgsqlTypes.NpgsqlPoint(x: 0.062068413783829546d, y: 0.500921152239639d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3024438117550341d, y: 0.6869281417480199d), new NpgsqlTypes.NpgsqlPoint(x: 0.08152061618485118d, y: 0.5112449237379442d), new NpgsqlTypes.NpgsqlPoint(x: 0.7575721116859729d, y: 0.03437790556000153d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49263851998402797d, y: 0.4199051421977319d), new NpgsqlTypes.NpgsqlPoint(x: 0.37567483152927905d, y: 0.23720883806690873d), new NpgsqlTypes.NpgsqlPoint(x: 0.06941955115412779d, y: 0.07443722545149489d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11692652313430285d, y: 0.22793927638180855d), new NpgsqlTypes.NpgsqlPoint(x: 0.18954646737094039d, y: 0.6927179072387702d), new NpgsqlTypes.NpgsqlPoint(x: 0.26626478246339735d, y: 0.715111403429802d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6504533809216569d, y: 0.373249914572787d), new NpgsqlTypes.NpgsqlPoint(x: 0.7752720551440346d, y: 0.3834196843856179d), new NpgsqlTypes.NpgsqlPoint(x: 0.8117070123268201d, y: 0.8503737297622119d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7188270450349463d, y: 0.7812845346508543d), new NpgsqlTypes.NpgsqlPoint(x: 0.03781408645017281d, y: 0.6401657870200983d), new NpgsqlTypes.NpgsqlPoint(x: 0.6571566055742568d, y: 0.7900653947164951d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6210527370265301d, y: 0.07335795149321311d), new NpgsqlTypes.NpgsqlPoint(x: 0.30055752258382096d, y: 0.70149637582955d), new NpgsqlTypes.NpgsqlPoint(x: 0.5622168701150778d, y: 0.012771809478692497d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31254148689136274d, y: 0.7291002388479408d), new NpgsqlTypes.NpgsqlPoint(x: 0.6596312774816973d, y: 0.29753490739717425d), new NpgsqlTypes.NpgsqlPoint(x: 0.7706027052782877d, y: 0.20638869051488662d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6869862057614055d, y: 0.42467576386061934d), new NpgsqlTypes.NpgsqlPoint(x: 0.3746897079224838d, y: 0.2439279724671466d), new NpgsqlTypes.NpgsqlPoint(x: 0.3504702840439913d, y: 0.18116740655777797d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7156862763570113d, y: 0.02363340794285873d), new NpgsqlTypes.NpgsqlPoint(x: 0.9453143282550567d, y: 0.1974943940530557d), new NpgsqlTypes.NpgsqlPoint(x: 0.3061236082272286d, y: 0.0009120788606057362d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8088202207254003d, y: 0.8197590917350138d), new NpgsqlTypes.NpgsqlPoint(x: 0.36142239086891426d, y: 0.06464791647612966d), new NpgsqlTypes.NpgsqlPoint(x: 0.1587892074267181d, y: 0.10052504984048993d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9020245438536985d, y: 0.24709725810415073d), new NpgsqlTypes.NpgsqlPoint(x: 0.8411832408337843d, y: 0.2064649215969524d), new NpgsqlTypes.NpgsqlPoint(x: 0.19238280791746853d, y: 0.3674397017072d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9149847960951597d, y: 0.6075982345477341d), new NpgsqlTypes.NpgsqlPoint(x: 0.15628788649938985d, y: 0.9279019271489408d), new NpgsqlTypes.NpgsqlPoint(x: 0.3461962629296075d, y: 0.29528647615728765d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0615561766545335d, y: 0.5819455648367129d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868288708047026d, y: 0.24991591432487292d), new NpgsqlTypes.NpgsqlPoint(x: 0.2808497296971284d, y: 0.6856893661457435d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4029292825468075d, y: 0.9011853484583734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7631656482151816d, y: 0.7140424492463018d), new NpgsqlTypes.NpgsqlPoint(x: 0.5116898421054662d, y: 0.7866075215774255d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05380277510026221d, y: 0.43419550361580994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7582841230245668d, y: 0.9928326025582703d), new NpgsqlTypes.NpgsqlPoint(x: 0.0033690661329214278d, y: 0.5030364763341729d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9622517362111745d, y: 0.9987774431225809d), new NpgsqlTypes.NpgsqlPoint(x: 0.0734444542984628d, y: 0.07619830898403257d), new NpgsqlTypes.NpgsqlPoint(x: 0.36179050211040875d, y: 0.9588520551565811d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36273797813366426d, y: 0.9288735343945406d), new NpgsqlTypes.NpgsqlPoint(x: 0.26321298328481857d, y: 0.0860253699435728d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412986434516155d, y: 0.8116916855983216d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38392954289250325d, y: 0.9580112961223172d), new NpgsqlTypes.NpgsqlPoint(x: 0.27358903445929406d, y: 0.3389327231977908d), new NpgsqlTypes.NpgsqlPoint(x: 0.449031706912307d, y: 0.8497296856977398d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29879610583614546d, y: 0.9186841531959145d), new NpgsqlTypes.NpgsqlPoint(x: 0.5184576334010967d, y: 0.0985174757609385d), new NpgsqlTypes.NpgsqlPoint(x: 0.3360908267987499d, y: 0.6219840632717003d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11365215473508394d, y: 0.8742895572353765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9678839937165162d, y: 0.08758547211702183d), new NpgsqlTypes.NpgsqlPoint(x: 0.18810692171722965d, y: 0.5890773212435242d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8584542716380466d, y: 0.3179608258010812d), new NpgsqlTypes.NpgsqlPoint(x: 0.01820084361843466d, y: 0.7017340157780345d), new NpgsqlTypes.NpgsqlPoint(x: 0.15371389866865903d, y: 0.12202548476028086d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6387733207248317d, y: 0.25188083870386124d), new NpgsqlTypes.NpgsqlPoint(x: 0.018805327814647388d, y: 0.07343305791629329d), new NpgsqlTypes.NpgsqlPoint(x: 0.2694934955434988d, y: 0.9381398723920108d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29266845205700476d, y: 0.5015701897154096d), new NpgsqlTypes.NpgsqlPoint(x: 0.1587100922987995d, y: 0.4209568862632892d), new NpgsqlTypes.NpgsqlPoint(x: 0.5543988783156603d, y: 0.3810370739172334d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1902025879161683d, y: 0.7289477191100877d), new NpgsqlTypes.NpgsqlPoint(x: 0.8912358512916919d, y: 0.6427643290772382d), new NpgsqlTypes.NpgsqlPoint(x: 0.5255551412134906d, y: 0.6739172866388087d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2400460434520636d, y: 0.5724944603490649d), new NpgsqlTypes.NpgsqlPoint(x: 0.22091741384608343d, y: 0.066563966335773d), new NpgsqlTypes.NpgsqlPoint(x: 0.6579318679446867d, y: 0.6261261851019532d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6665298157958792d, y: 0.740010285597043d), new NpgsqlTypes.NpgsqlPoint(x: 0.3990948932381595d, y: 0.6898708139527392d), new NpgsqlTypes.NpgsqlPoint(x: 0.33710361603400996d, y: 0.47379555732967904d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42315096118419815d, y: 0.7794886140052238d), new NpgsqlTypes.NpgsqlPoint(x: 0.3623754044206754d, y: 0.8129798839714248d), new NpgsqlTypes.NpgsqlPoint(x: 0.3788382461354014d, y: 0.49676227030220743d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5287395210255643d, y: 0.25225753762798986d), new NpgsqlTypes.NpgsqlPoint(x: 0.26323865404091973d, y: 0.022130208230429216d), new NpgsqlTypes.NpgsqlPoint(x: 0.898019494183508d, y: 0.5014602917736837d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7258553449177089d, y: 0.13098778395816302d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512767974937656d, y: 0.4850187251278727d), new NpgsqlTypes.NpgsqlPoint(x: 0.8009448680135217d, y: 0.3858835328465392d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7359890959298359d, y: 0.09557662173170423d), new NpgsqlTypes.NpgsqlPoint(x: 0.3257859255845239d, y: 0.713772687479342d), new NpgsqlTypes.NpgsqlPoint(x: 0.6980010127888945d, y: 0.5819022135939957d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2476464120412143d, y: 0.8929777446590234d), new NpgsqlTypes.NpgsqlPoint(x: 0.5089644659812925d, y: 0.3402066232953199d), new NpgsqlTypes.NpgsqlPoint(x: 0.2826562608508868d, y: 0.362977530819642d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07916511750541211d, y: 0.023369148477425328d), new NpgsqlTypes.NpgsqlPoint(x: 0.324342456672559d, y: 0.018920663788907666d), new NpgsqlTypes.NpgsqlPoint(x: 0.9066499120610306d, y: 0.5079974365074905d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49737913213081d, y: 0.4121732388098591d), new NpgsqlTypes.NpgsqlPoint(x: 0.7872833929972258d, y: 0.07293003087176686d), new NpgsqlTypes.NpgsqlPoint(x: 0.5560531621744854d, y: 0.23333703030749253d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21817091171043124d, y: 0.17651191263797072d), new NpgsqlTypes.NpgsqlPoint(x: 0.7238627140877488d, y: 0.6338200677276739d), new NpgsqlTypes.NpgsqlPoint(x: 0.9034370967689505d, y: 0.00024363588301778982d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5896930752593317d, y: 0.14829229554248902d), new NpgsqlTypes.NpgsqlPoint(x: 0.6126440577633995d, y: 0.060936462318387896d), new NpgsqlTypes.NpgsqlPoint(x: 0.13875513371882975d, y: 0.13059567813128925d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8179691068065422d, y: 0.9140737080270535d), new NpgsqlTypes.NpgsqlPoint(x: 0.48998377120399605d, y: 0.49053878923720595d), new NpgsqlTypes.NpgsqlPoint(x: 0.8427641224496271d, y: 0.37181895172913004d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8133629286092274d, y: 0.4978924929627986d), new NpgsqlTypes.NpgsqlPoint(x: 0.46452876860336223d, y: 0.5931147662309698d), new NpgsqlTypes.NpgsqlPoint(x: 0.7035020927621062d, y: 0.6158426983179607d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32586167952327416d, y: 0.3227140393551572d), new NpgsqlTypes.NpgsqlPoint(x: 0.8546945583110614d, y: 0.36556414747939525d), new NpgsqlTypes.NpgsqlPoint(x: 0.5819020308612952d, y: 0.09740768859076965d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9300574263494641d, y: 0.8671791126074515d), new NpgsqlTypes.NpgsqlPoint(x: 0.4220118114908826d, y: 0.19026578072259026d), new NpgsqlTypes.NpgsqlPoint(x: 0.2746398909314959d, y: 0.7668104318212337d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7939076832103171d, y: 0.8281704231735263d), new NpgsqlTypes.NpgsqlPoint(x: 0.5114806699356174d, y: 0.3842025615276772d), new NpgsqlTypes.NpgsqlPoint(x: 0.5600626749495956d, y: 0.05972370437836694d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5385600794473556d, y: 0.6601078894665771d), new NpgsqlTypes.NpgsqlPoint(x: 0.03648306457277062d, y: 0.09638612057042084d), new NpgsqlTypes.NpgsqlPoint(x: 0.478808466192587d, y: 0.20862350905669336d)),

},
    NullableValue = null,
},
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 132, query1, 108, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 84, query1, 154, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[16], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[17], false);FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[18], false);FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[19], false);FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[20], false);FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[21], false);FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[22], false);FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[23], false);FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[24], false);FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[25], false);FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[26], false);FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSelectModelBatchAsync(connection, 108, 74))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSelectModelBatch(connection, 123, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
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
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray2M>(15);

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
                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

